<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="LibraryClient.AddBook" MasterPageFile="Admin.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />
        <center>
            <h3>Add Book</h3>
        </center>
        <br />
        <form id="form1" runat="server">
                <div class="card ms-auto me-auto p-5" style="width: 30rem;">
                    <asp:Label ID="Label1" runat="server" Text="Book Name :"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="TextBox1"
                        ErrorMessage="Book name is a required field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                    <asp:Label ID="Label2" runat="server" Text="Author Name :"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                        ControlToValidate="TextBox2"
                        ErrorMessage="Author name is a required field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                    <br />
                    <asp:Button ID="Button1" CssClass="btn-dark" runat="server" Text="Submit" OnClick="Button1_Click" />
                    <asp:Label ID="Label3" CssClass="text-danger" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>
        </form>
    </div>
</asp:Content>
