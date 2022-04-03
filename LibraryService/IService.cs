using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        bool AddBook(string title, string author);

        [OperationContract]
        bool UpdateBook(int id, string title, string author);

        [OperationContract]
        bool DeleteBook(int id);

        [OperationContract]
        Book GetBook(int id);

        [OperationContract]
        List<Book> GetBooks();

        [OperationContract]
        bool doTask(int id, int value);

        [OperationContract]
        bool IssueBook(int student, int book);

        [OperationContract]
        bool ReturnBook(int id, int book);

        [OperationContract]
        List<Transaction> GetIssuedBooks(int id);

        [OperationContract]
        List<Transaction> GetIssuedBooksInfo();

        [OperationContract]
        int RegisterStudent(string name, string email, string password);

        [OperationContract]
        int LoginStudent(string email, string password);

        [OperationContract]
        bool UpdateStudentInfo(int id, string name, string email);

        [OperationContract]
        Student GetStudent(int id);

        [OperationContract]
        List<Student> GetStudents();
    }
}

