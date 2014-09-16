<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Tax1040Web.Registration" %>

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
                <asp:Label ID="lblemail"  runat="server" Text="Email Address"></asp:Label>
           
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            </td>
                </tr>
            <tr>
            <td>
                <asp:Label ID="lblusername"  runat="server" Text="User Name"> </asp:Label>
            
                <asp:TextBox ID="txtusername"  runat="server"></asp:TextBox>
            </td>
                </tr>
           <tr>
               <td>
                    <asp:Label ID="lblpasswd"  runat="server" Text="Password"> </asp:Label>
            
                <asp:TextBox ID="txtpasswd"  runat="server" TextMode="Password"></asp:TextBox>
               </td>
           </tr>
            <tr>
                <td>
                    <asp:Label ID="lblcpasswd" runat="server" Text="Conform Password"> </asp:Label>
            
                <asp:TextBox ID="txtcpasswd"  runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblsquestion"  runat="server" Text="Security Question"> </asp:Label>
            
                <asp:TextBox ID="txtsquestion"  runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblanswer"  runat="server" Text="Answer"> </asp:Label>
            
                <asp:TextBox ID="txtanswer"  runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkagree" Text="I agree to site" runat="server" /> 
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkremember" Text="Remember me on the computer" runat="server" /> 
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
