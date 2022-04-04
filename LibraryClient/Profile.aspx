<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="LibraryClient.Profile" MasterPageFile="~/Student.Master" %>

<asp:Content ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />
        <br />
        <br />
        <br />
        <br />
        <center>
            <h3>Student Profile</h3>
        </center>
        <br />
        <form id="form1" runat="server">
            <div class="card ms-auto me-auto p-5" style="width: 30rem;">
                <asp:Label ID="Label1" runat="server" Text="Id :"></asp:Label>
                <span class="border border-dark"><%= student.Id %></span>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Name :"></asp:Label>
                <span class="border border-dark"><%= student.Name %></span>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Email :"></asp:Label>
                <span class="border border-dark"><%= student.Email %></span>
                <br />
                <asp:Button ID="Button1" CssClass="btn-dark" runat="server" Text="Edit" OnClick="Button1_Click" />
            </div>
        </form>
    </div>
</asp:Content>