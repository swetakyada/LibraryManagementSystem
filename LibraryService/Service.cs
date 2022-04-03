using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService
{
    public class Service : IService
    {
        public SqlConnection connection;
        public SqlCommand cmd;
        public Service()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            cmd = new SqlCommand
            {
                Connection = connection
            };
        }

        public bool AddBook(string title, string author)
        {
            int result = -1;
            try
            {
                cmd.CommandText = "INSERT INTO dbo.Books (title, author) VALUES (@title, @author)";
                cmd.Parameters.Add(new SqlParameter("@title", title));
                cmd.Parameters.Add(new SqlParameter("@author", author));
                connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in AddBook : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result >= 0;
        }

        public bool DeleteBook(int id)
        {
            int result = 0;
            try
            {
                cmd.CommandText = "DELETE FROM dbo.Books WHERE id = @id";
                cmd.Parameters.Add(new SqlParameter("@id", id));
                connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in DeleteBook : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result > 0;
        }

        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            SqlDataReader rd;
            try
            {
                cmd.CommandText = "SELECT * FROM Books WHERE issued = 0";
                connection.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Book book = new Book
                    {
                        Id = rd.GetInt32(0),
                        Title = rd.GetString(1),
                        Author = rd.GetString(2),
                        Issued = rd.GetBoolean(3)
                    };
                    books.Add(book);
                }
                rd.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception in GetBooks : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return books;
        }

        public Book GetBook(int id)
        {
            Book book = null;
            SqlDataReader rd;
            try
            {
                cmd.CommandText = "SELECT * FROM Books WHERE id = @id";
                cmd.Parameters.Add(new SqlParameter("@id", id));
                connection.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    book = new Book
                    {
                        Id = rd.GetInt32(0),
                        Title = rd.GetString(1),
                        Author = rd.GetString(2),
                        Issued = rd.GetBoolean(3)
                    };
                }
                rd.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in GetBook : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return book;
        }

        public bool doTask(int id, int value)
        {
            int result = -1;
            try
            {
                if(value == 1)
                    cmd.CommandText = "UPDATE Books SET issued=1 WHERE id=@id";
                else
                    cmd.CommandText = "UPDATE Books SET issued=0 WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IssueBook : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result >= 0;
        }

        public bool IssueBook(int student, int book)
        {
            int result = -1;
            try
            {
                DateTime thisDay = DateTime.Today;
                cmd.CommandText = "INSERT INTO dbo.Transactions (student, book, issuedate) VALUES (@student, @book, @issuedate)";
                cmd.Parameters.Add(new SqlParameter("@student", student));
                cmd.Parameters.Add(new SqlParameter("@book", book));
                cmd.Parameters.Add(new SqlParameter("@issuedate", thisDay));
                connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IssueBook : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result >= 0 && doTask(book, 1);
        }

        public bool ReturnBook(int id, int book)
        {
            int result = -1;
            try
            {
                cmd.CommandText = "DELETE FROM dbo.Transactions WHERE id = @id";
                cmd.Parameters.Add(new SqlParameter("@id", id));
                connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in ReturnBook : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result >= 0;
        }

        public bool UpdateBook(int id, string title, string author)
        {
            int result = -1;
            try
            {
                cmd.CommandText = "UPDATE dbo.Books SET title = @title, author = @author WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in UpdateBook : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result >= 0;
        }

        public List<Transaction> GetIssuedBooks(int id)
        {
            List<Transaction> transactions = new List<Transaction>();
            SqlDataReader rd;
            try
            {
                cmd.CommandText = "SELECT * FROM dbo.Transactions WHERE student = @id";
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Transaction transaction = new Transaction
                    {
                        Id = rd.GetInt32(0),
                        Student = rd.GetInt32(1),
                        Book = rd.GetInt32(2),
                        IssueDate = rd.GetDateTime(3)
                    };
                    transactions.Add(transaction);
                }
                rd.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in GetTransactions : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return transactions;
        }

        public List<Transaction> GetIssuedBooksInfo()
        {
            List<Transaction> transactions = new List<Transaction>();
            SqlDataReader rd;
            try
            {
                cmd.CommandText = "SELECT * FROM dbo.Transactions";
                connection.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Transaction transaction = new Transaction
                    {
                        Id = rd.GetInt32(0),
                        Student = rd.GetInt32(1),
                        Book = rd.GetInt32(2),
                        IssueDate = rd.GetDateTime(3)
                    };
                    transactions.Add(transaction);
                }
                rd.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in GetTransactions : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return transactions;
        }

        public Student GetStudent(int id)
        {
            Student student = null;
            SqlDataReader rd;
            try
            {
                cmd.CommandText = "SELECT * FROM dbo.Students WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    student = new Student
                    {
                        Id = rd.GetInt32(0),
                        Name = rd.GetString(1),
                        Email = rd.GetString(2),
                        Password = rd.GetString(3)
                    };
                }
                rd.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in GetStudents : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return student;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            SqlDataReader rd;
            try
            {
                cmd.CommandText = "SELECT * FROM dbo.Students";
                connection.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Student student = new Student
                    {
                        Id = rd.GetInt32(0),
                        Name = rd.GetString(1),
                        Email = rd.GetString(2),
                        Password = rd.GetString(3)
                    };
                    students.Add(student);
                }
                rd.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in GetStudents : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return students;
        }

        public int LoginStudent(string email, string password)
        {
            SqlDataReader rd;
            try
            {
                cmd.CommandText = "SELECT * FROM dbo.Students WHERE email = @email";
                cmd.Parameters.AddWithValue("@email", email);
                connection.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Student student = new Student
                    {
                        Id = rd.GetInt32(0),
                        Name = rd.GetString(1),
                        Email = rd.GetString(2),
                        Password = rd.GetString(3)
                    };
                    if (student.Password.Trim() == password.Trim())
                        return student.Id;
                }
                rd.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in LoginStudent : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return -1;
        }

        public int RegisterStudent(string name, string email, string password)
        {
            int result = -1;
            try
            {
                cmd.CommandText = "INSERT INTO dbo.Students (name, email, password) VALUES (@name, @email, @password)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in RegisterStudent : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public bool UpdateStudentInfo(int id, string name, string email)
        {
            int result = -1;
            try
            {
                cmd.CommandText = "UPDATE dbo.Students SET name = @name, email = @email WHERE id = @id";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in UpdateStudentInfo : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result >= 0;
        }

    }
}
