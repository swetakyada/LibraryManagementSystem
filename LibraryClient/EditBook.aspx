<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditBook.aspx.cs" Inherits="LibraryClient.EditBook" MasterPageFile="Admin.Master" %>

<asp:Content ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />
        <center>
            <h3>Edit Book</h3>
        </center>
        <br />
        <form id="form1" runat="server">
                <div class="card ms-auto me-auto p-5" style="width: 30rem;">
                    <asp:Label ID="Label1" runat="server" Text="Book Id :"></asp:Label>
                    <span class="border border-dark"><%= book.Id %></span>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Book Name :"></asp:Label>
                    <span class="border"><%= book.Title %></span>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Author Name :"></asp:Label>
                    <span class="border"><%= book.Author %></span>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" CssClass="btn-dark" runat="server" Text="Save" OnClick="Button1_Click" />
                    <asp:Label ID="Label4" CssClass="text-danger" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>
        </form>
    </div>
</asp:Content>
