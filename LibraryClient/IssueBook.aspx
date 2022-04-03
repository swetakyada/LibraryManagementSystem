<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssueBook.aspx.cs" Inherits="LibraryClient.IssueBook" MasterPageFile="Admin.Master" %>

<asp:Content ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
     <div class="container">
        <br />
        <center>
            <h3>Issue Book</h3>
        </center>
        <br />
        <form id="form1" runat="server">
                <div class="card ms-auto me-auto p-5" style="width: 30rem;">
                    <asp:Label ID="Label1" runat="server" Text="Book Id :"></asp:Label>
                    <span class="border border-dark"><%= book.Id %></span>
                    <asp:Label ID="Label2" runat="server" Text="Book Name :"></asp:Label>
                    <span class="border border-dark"><%= book.Title %></span>
                    <asp:Label ID="Label3" runat="server" Text="Author Name :"></asp:Label>
                    <span class="border border-dark"><%= book.Author %></span>
                    <asp:Label ID="Label4" runat="server" Text="Student Id :"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" CssClass="btn-dark" runat="server" Text="Issue" OnClick="Button1_Click" />
                    <asp:Label ID="Label5" CssClass="text-danger" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>
        </form>
    </div>
</asp:Content>
