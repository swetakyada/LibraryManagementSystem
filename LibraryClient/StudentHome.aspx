<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="LibraryClient.StudentHome" MasterPageFile="~/Student.Master" %>

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
                        <th scope="col">Book Name</th>
                        <th scope="col">Author Name</th>
                    </tr>
                </thead>
                <tbody>
                    <% for (int i = 0; i < books.Length; i++)
                        { %>
                    <tr>
                        <th scope="row"><%= i+1 %></th>
                        <td><%= books[i].Title %></td>
                        <td><%= books[i].Author %></td>
                    </tr>
                    <% } %>
                </tbody>
            </table>
        </div>
    </form>
</asp:Content>