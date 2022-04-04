<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowedBooks.aspx.cs" Inherits="LibraryClient.BorrowedBooks" MasterPageFile="~/Student.Master" %>

<asp:Content ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />
        <center>
            <h3>Taken Books</h3>
        </center>
        <br />
        <table class="table table-hover">
            <thead>
                <tr>
                    <th scope="col">No.</th>
                    <th scope="col">Book Name</th>
                    <th scope="col">Author Name</th>
                    <th scope="col">Issue Date</th>
                </tr>
            </thead>
            <tbody>
                <% for (int i = 0; i < books.Length; i++)
                    { %>
                <tr>
                    <th scope="row"><%= i+1 %></th>
                    <td><%= books[i].Title %></td>
                    <td><%= books[i].Author %></td>
                    <td><%= transactions[i].IssueDate %></td>
                </tr>
                <% } %>
            </tbody>
        </table>
    </div>
</asp:Content>
