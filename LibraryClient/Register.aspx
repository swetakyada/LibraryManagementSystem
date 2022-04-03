<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LibraryClient.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Registration</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <meta name="viewport" content="width=device-width, initial-scale=1">
</head>
<body>
    <div class="container">
        <br />
        <br />
        <br />
        <center>
            <h3>Student Registration</h3>
        </center>
        <br />
        <form id="form1" runat="server">
                <div class="card ms-auto me-auto p-5" style="width: 30rem;">
                    <asp:Label ID="Label1" runat="server" Text="Student Name :"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="TextBox1"
                        ErrorMessage="Student name is a required field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                    <asp:Label ID="Label2" runat="server" Text="Student Email :"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                        ControlToValidate="TextBox2"
                        ErrorMessage="Student email is a required field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                    <asp:Label ID="Label3" runat="server" Text="Password :"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                        ControlToValidate="TextBox3"
                        ErrorMessage="Student email is a required field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                    <asp:Button ID="Button1" CssClass="btn-dark" runat="server" Text="Register" OnClick="Button1_Click" />
                    <asp:Label ID="Label4" CssClass="text-danger" runat="server" Text="" ForeColor="Red"></asp:Label>
                    <br />
                    <div style="display:inline">
                    <center>Already have an account? Login <a href="Login.aspx">here</a></center>
                    </div>
                </div>
        </form>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js"></script>
</body>
</html>
