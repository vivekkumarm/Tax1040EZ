<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="BuildNotification.aspx.cs" Inherits="BuildNotification.BuildNotification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span style="text-align: center"><h3>Build Notification Messenger</h3></span>
        </div>
        <div id="dvsuccess" style="color: green" runat="server" Visible="False"><b>Notification has been send Successfully</b></div>
        <fieldset>
        <div>
            <b>BUILD MANAGER INFO</b><br /><br/>
            Build Manager Email
                <asp:TextBox ID="txtBuildManagerEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvBuildManagerEmail" ControlToValidate="txtBuildManagerEmail" runat="server" ErrorMessage="Enter Build Manager Email"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revrfvBuildManagerEmail" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtBuildManagerEmail" ErrorMessage="Invalid Email Format"></asp:RegularExpressionValidator>
           
        </div>
             <br/>
            </fieldset>
        <br />
        <fieldset>
        <div>

            <b>SMOKE RELEASE</b><br />
            <br />
            <asp:Button ID="btnSmokeLogin" runat="server" Text="Smoke Log In Notification"
                OnClick="btnSmokeLogin_Click" />
            <asp:Button ID="btnSmokeLogOff" runat="server" Text="Smoke Log Off Notification"
                OnClick="btnSmokeLogOff_Click" /><br />

        </div>
        <br />
 </fieldset>
        <fieldset>
        <div>
            <b>QA RELEASE</b><br />
            <br />
            <asp:FileUpload ID="fpReleaseNotes" runat="server" /><br />
            <br />
            
           <%-- Release Number
            <asp:DropDownList ID="ddlReleaseNo" runat="server">
                <asp:ListItem Text="5" Value="1"></asp:ListItem>
                <asp:ListItem Text="6" Value="2"></asp:ListItem>
                <asp:ListItem Text="7" Value="3"></asp:ListItem>
                  <asp:ListItem Text="8" Value="4"></asp:ListItem>
                
                
            </asp:DropDownList>
            <br/>
            <br/>--%>
            

            <asp:Button ID="btnQaLogin" runat="server" Text="QA Log In Notification"
                OnClick="btnQaLogin_Click" />
            <asp:Button ID="btnQaLogOff" runat="server" Text="QA Log off Notification"
                OnClick="btnQaLogOff_Click" /><br />
        </div>

</fieldset>



    </form>
</body>
</html>
