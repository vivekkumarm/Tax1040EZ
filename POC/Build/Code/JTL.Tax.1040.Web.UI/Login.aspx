<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tax1040Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblusername" Text="User Name"></asp:Label>
                <asp:TextBox runat="server" ID="txtusername" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblpassword" Text="Password"></asp:Label>
                <asp:TextBox runat="server" ID="txtpassword" TextMode="Password" ></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td>
               <asp:CheckBox ID="chkusername" Text="Stay Signed in" runat="server"/><br/>
                 <asp:Label ID="lblnewuser" Text="New User" runat="server"></asp:Label>
                <a href="Registration.aspx">Create an Account</a>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click"/>
              
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
