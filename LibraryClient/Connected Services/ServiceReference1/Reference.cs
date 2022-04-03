﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/LibraryService")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IssuedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Issued {
            get {
                return this.IssuedField;
            }
            set {
                if ((this.IssuedField.Equals(value) != true)) {
                    this.IssuedField = value;
                    this.RaisePropertyChanged("Issued");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Transaction", Namespace="http://schemas.datacontract.org/2004/07/LibraryService")]
    [System.SerializableAttribute()]
    public partial class Transaction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime IssueDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Book {
            get {
                return this.BookField;
            }
            set {
                if ((this.BookField.Equals(value) != true)) {
                    this.BookField = value;
                    this.RaisePropertyChanged("Book");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime IssueDate {
            get {
                return this.IssueDateField;
            }
            set {
                if ((this.IssueDateField.Equals(value) != true)) {
                    this.IssueDateField = value;
                    this.RaisePropertyChanged("IssueDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Student {
            get {
                return this.StudentField;
            }
            set {
                if ((this.StudentField.Equals(value) != true)) {
                    this.StudentField = value;
                    this.RaisePropertyChanged("Student");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/LibraryService")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddBook", ReplyAction="http://tempuri.org/IService/AddBookResponse")]
        bool AddBook(string title, string author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddBook", ReplyAction="http://tempuri.org/IService/AddBookResponse")]
        System.Threading.Tasks.Task<bool> AddBookAsync(string title, string author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateBook", ReplyAction="http://tempuri.org/IService/UpdateBookResponse")]
        bool UpdateBook(int id, string title, string author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateBook", ReplyAction="http://tempuri.org/IService/UpdateBookResponse")]
        System.Threading.Tasks.Task<bool> UpdateBookAsync(int id, string title, string author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteBook", ReplyAction="http://tempuri.org/IService/DeleteBookResponse")]
        bool DeleteBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteBook", ReplyAction="http://tempuri.org/IService/DeleteBookResponse")]
        System.Threading.Tasks.Task<bool> DeleteBookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetBook", ReplyAction="http://tempuri.org/IService/GetBookResponse")]
        LibraryClient.ServiceReference1.Book GetBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetBook", ReplyAction="http://tempuri.org/IService/GetBookResponse")]
        System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Book> GetBookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetBooks", ReplyAction="http://tempuri.org/IService/GetBooksResponse")]
        LibraryClient.ServiceReference1.Book[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetBooks", ReplyAction="http://tempuri.org/IService/GetBooksResponse")]
        System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Book[]> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/doTask", ReplyAction="http://tempuri.org/IService/doTaskResponse")]
        bool doTask(int id, int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/doTask", ReplyAction="http://tempuri.org/IService/doTaskResponse")]
        System.Threading.Tasks.Task<bool> doTaskAsync(int id, int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IssueBook", ReplyAction="http://tempuri.org/IService/IssueBookResponse")]
        bool IssueBook(int student, int book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IssueBook", ReplyAction="http://tempuri.org/IService/IssueBookResponse")]
        System.Threading.Tasks.Task<bool> IssueBookAsync(int student, int book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReturnBook", ReplyAction="http://tempuri.org/IService/ReturnBookResponse")]
        bool ReturnBook(int id, int book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReturnBook", ReplyAction="http://tempuri.org/IService/ReturnBookResponse")]
        System.Threading.Tasks.Task<bool> ReturnBookAsync(int id, int book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIssuedBooks", ReplyAction="http://tempuri.org/IService/GetIssuedBooksResponse")]
        LibraryClient.ServiceReference1.Transaction[] GetIssuedBooks(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIssuedBooks", ReplyAction="http://tempuri.org/IService/GetIssuedBooksResponse")]
        System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Transaction[]> GetIssuedBooksAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIssuedBooksInfo", ReplyAction="http://tempuri.org/IService/GetIssuedBooksInfoResponse")]
        LibraryClient.ServiceReference1.Transaction[] GetIssuedBooksInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIssuedBooksInfo", ReplyAction="http://tempuri.org/IService/GetIssuedBooksInfoResponse")]
        System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Transaction[]> GetIssuedBooksInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RegisterStudent", ReplyAction="http://tempuri.org/IService/RegisterStudentResponse")]
        int RegisterStudent(string name, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RegisterStudent", ReplyAction="http://tempuri.org/IService/RegisterStudentResponse")]
        System.Threading.Tasks.Task<int> RegisterStudentAsync(string name, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LoginStudent", ReplyAction="http://tempuri.org/IService/LoginStudentResponse")]
        int LoginStudent(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LoginStudent", ReplyAction="http://tempuri.org/IService/LoginStudentResponse")]
        System.Threading.Tasks.Task<int> LoginStudentAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateStudentInfo", ReplyAction="http://tempuri.org/IService/UpdateStudentInfoResponse")]
        bool UpdateStudentInfo(int id, string name, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateStudentInfo", ReplyAction="http://tempuri.org/IService/UpdateStudentInfoResponse")]
        System.Threading.Tasks.Task<bool> UpdateStudentInfoAsync(int id, string name, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudent", ReplyAction="http://tempuri.org/IService/GetStudentResponse")]
        LibraryClient.ServiceReference1.Student GetStudent(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudent", ReplyAction="http://tempuri.org/IService/GetStudentResponse")]
        System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Student> GetStudentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudents", ReplyAction="http://tempuri.org/IService/GetStudentsResponse")]
        LibraryClient.ServiceReference1.Student[] GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudents", ReplyAction="http://tempuri.org/IService/GetStudentsResponse")]
        System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Student[]> GetStudentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : LibraryClient.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<LibraryClient.ServiceReference1.IService>, LibraryClient.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddBook(string title, string author) {
            return base.Channel.AddBook(title, author);
        }
        
        public System.Threading.Tasks.Task<bool> AddBookAsync(string title, string author) {
            return base.Channel.AddBookAsync(title, author);
        }
        
        public bool UpdateBook(int id, string title, string author) {
            return base.Channel.UpdateBook(id, title, author);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateBookAsync(int id, string title, string author) {
            return base.Channel.UpdateBookAsync(id, title, author);
        }
        
        public bool DeleteBook(int id) {
            return base.Channel.DeleteBook(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteBookAsync(int id) {
            return base.Channel.DeleteBookAsync(id);
        }
        
        public LibraryClient.ServiceReference1.Book GetBook(int id) {
            return base.Channel.GetBook(id);
        }
        
        public System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Book> GetBookAsync(int id) {
            return base.Channel.GetBookAsync(id);
        }
        
        public LibraryClient.ServiceReference1.Book[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Book[]> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public bool doTask(int id, int value) {
            return base.Channel.doTask(id, value);
        }
        
        public System.Threading.Tasks.Task<bool> doTaskAsync(int id, int value) {
            return base.Channel.doTaskAsync(id, value);
        }
        
        public bool IssueBook(int student, int book) {
            return base.Channel.IssueBook(student, book);
        }
        
        public System.Threading.Tasks.Task<bool> IssueBookAsync(int student, int book) {
            return base.Channel.IssueBookAsync(student, book);
        }
        
        public bool ReturnBook(int id, int book) {
            return base.Channel.ReturnBook(id, book);
        }
        
        public System.Threading.Tasks.Task<bool> ReturnBookAsync(int id, int book) {
            return base.Channel.ReturnBookAsync(id, book);
        }
        
        public LibraryClient.ServiceReference1.Transaction[] GetIssuedBooks(int id) {
            return base.Channel.GetIssuedBooks(id);
        }
        
        public System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Transaction[]> GetIssuedBooksAsync(int id) {
            return base.Channel.GetIssuedBooksAsync(id);
        }
        
        public LibraryClient.ServiceReference1.Transaction[] GetIssuedBooksInfo() {
            return base.Channel.GetIssuedBooksInfo();
        }
        
        public System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Transaction[]> GetIssuedBooksInfoAsync() {
            return base.Channel.GetIssuedBooksInfoAsync();
        }
        
        public int RegisterStudent(string name, string email, string password) {
            return base.Channel.RegisterStudent(name, email, password);
        }
        
        public System.Threading.Tasks.Task<int> RegisterStudentAsync(string name, string email, string password) {
            return base.Channel.RegisterStudentAsync(name, email, password);
        }
        
        public int LoginStudent(string email, string password) {
            return base.Channel.LoginStudent(email, password);
        }
        
        public System.Threading.Tasks.Task<int> LoginStudentAsync(string email, string password) {
            return base.Channel.LoginStudentAsync(email, password);
        }
        
        public bool UpdateStudentInfo(int id, string name, string email) {
            return base.Channel.UpdateStudentInfo(id, name, email);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateStudentInfoAsync(int id, string name, string email) {
            return base.Channel.UpdateStudentInfoAsync(id, name, email);
        }
        
        public LibraryClient.ServiceReference1.Student GetStudent(int id) {
            return base.Channel.GetStudent(id);
        }
        
        public System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Student> GetStudentAsync(int id) {
            return base.Channel.GetStudentAsync(id);
        }
        
        public LibraryClient.ServiceReference1.Student[] GetStudents() {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Student[]> GetStudentsAsync() {
            return base.Channel.GetStudentsAsync();
        }
    }
}
