<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="LibraryClient.EditProfile" MasterPageFile="~/Student.Master" %>

<asp:Content ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />
        <br />
        <br />
        <br />
        <br />
        <center>
            <h3>Edit Profile</h3>
        </center>
        <br />
        <form id="form1" runat="server">
            <div class="card ms-auto me-auto p-5" style="width: 30rem;">
                <asp:Label ID="Label1" runat="server" Text="Student Name :"></asp:Label>
                <span class="border"><%= student.Name %></span>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Email :"></asp:Label>
                <span class="border"><%= student.Email %></span>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" CssClass="btn-dark" runat="server" Text="Save" OnClick="Button1_Click" />
                <asp:Label ID="Label3" CssClass="text-danger" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>
        </form>
    </div>
</asp:Content>