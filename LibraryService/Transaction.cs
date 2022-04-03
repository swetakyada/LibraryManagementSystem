using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService
{
    [DataContract]
    public class Transaction
    {
        private int id, student, book;
        private DateTime issuedate;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public int Student
        {
            get { return student; }
            set { student = value; }
        }

        [DataMember]
        public int Book
        {
            get { return book; }
            set { book = value; }
        }

        [DataMember]
        public DateTime IssueDate
        {
            get { return issuedate; }
            set { issuedate = value; }
        }
    }
}
