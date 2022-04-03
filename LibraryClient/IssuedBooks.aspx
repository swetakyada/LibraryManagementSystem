<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssuedBooks.aspx.cs" Inherits="LibraryClient.IssuedBooks" MasterPageFile="Admin.Master" %>

<asp:Content ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <center>
                <h3>Issued Books</h3>
            </center>
            <br />
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th scope="col">No.</th>
                        <th scope="col">Book ID</th>
                        <th scope="col">Book Name</th>
                        <th scope="col">Author Name</th>
                        <th scope="col">Student ID</th>
                        <th scope="col">Student Name</th>
                        <th scope="col">Issue Date</th>
                        <th scope="col"></th>
                    </tr>
                </thead>
                <tbody>
                    <% for (int i = 0; i < transactions.Length; i++)
                        { %>
                    <tr>
                        <th scope="row"><%= i+1 %></th>
                        <td><%= books[i].Id %></td>
                        <td><%= books[i].Title %></td>
                        <td><%= books[i].Author %></td>
                        <td><%= students[i].Id %></td>
                        <td><%= students[i].Name %></td>
                        <td><%= transactions[i].IssueDate %></td>
                        <td><a href="ReturnBook.aspx?id=<%= transactions[i].Id %>&book=<%= transactions[i].Book %>">Return Book</a></td>
                    </tr>
                    <% } %>
                </tbody>
            </table>
        </div>
    </form>
</asp:Content>