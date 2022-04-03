<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LibraryClient.Home" MasterPageFile="Admin.Master" %>

<asp:Content ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <center>
                <h3>Available Books</h3>
            </center>
            <br />
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th scope="col">No.</th>
                        <th scope="col">ID</th>
                        <th scope="col">Book Name</th>
                        <th scope="col">Author Name</th>
                        <th scope="col"></th>
                        <th scope="col"></th>
                        <th scope="col"></th>
                    </tr>
                </thead>
                <tbody>
                    <% for (int i = 0; i < books.Length; i++)
                        { %>
                    <tr>
                        <th scope="row"><%= i+1 %></th>
                        <td><%= books[i].Id %></td>
                        <td><%= books[i].Title %></td>
                        <td><%= books[i].Author %></td>
                        <td><a href="IssueBook.aspx?id=<%= books[i].Id %>">Issue</a></td>
                        <td><a href="EditBook.aspx?id=<%= books[i].Id %>">Edit</a></td>
                        <td><a href="DeleteBook.aspx?id=<%= books[i].Id %>">Delete</a></td>
                    </tr>
                    <% } %>
                </tbody>
            </table>
        </div>
    </form>
</asp:Content>