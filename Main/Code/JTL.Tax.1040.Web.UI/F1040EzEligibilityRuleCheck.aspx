<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="F1040EzEligibilityRuleCheck.aspx.cs" Inherits="Tax1040Web.Startup" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit"%> 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
   
    <form id="form1" runat="server">
        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
        <table>
            <tr>
                <td><asp:Label ID="lblError" Visible="false" runat="server" ForeColor="Red" Text="You are not Eligible to file 1040Ez"></asp:Label></td>

            </tr>
            <tr>
                <td>
                    <asp:ValidationSummary ID="validationSummary" runat="server" ForeColor="Red" />

                </td>
            </tr>
        </table>
        
         <fieldset>
        <table>
            <tr>
                <td>
                    <h3>TAX1040 ELIGIBLITY INPUT</h3>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFilingStatus" runat="server" Text="FilingStatus"></asp:Label>
                    <asp:DropDownList ID="ddlFilingStatus" runat="server">
                        <asp:ListItem Value="0">None</asp:ListItem>
                        <asp:ListItem Value="1">Single</asp:ListItem>
                        <asp:ListItem Value="2">MFJ</asp:ListItem>
                        <asp:ListItem Value="3">MFS</asp:ListItem>
                        <asp:ListItem Value="4">HOH</asp:ListItem>
                        <asp:ListItem Value="5">QW</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkHasClaimedAsDependent" Text="HasClaimedAsDependent" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkHasAGIDeductions" Text="chkHasAGIDeductions" runat="server" />
                </td>
            </tr>         
            <tr>
                <td>
                    <asp:CheckBox ID="chkHasCreditsToClaim" Text="HasCreditsToClaim" runat="server" />
                </td>
            </tr>         
            <tr>
                <td>
                    <asp:CheckBox ID="chkHasOwedHouseholdEmploymentTax" Text="HasOwedHouseholdEmploymentTax" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkHasAlternativeMinimumTax" Text="HasAlternativeMinimumTax" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkHasIncomeFromOtherSources" Text="HasIncomeFromOtherSources" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkHasItemizedDeductions" Text="HasItemizedDeductions" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkHasEstimatedTaxPayments" Text="HasEstimatedTaxPayments" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkIsBankruptcyDebtor" Text="IsBankruptcyDebtor" runat="server" />
                </td>
            </tr>

            <tr>

                <td>
                    <asp:CheckBox runat="server" ID="chktaxpayerblind" />
                    <asp:Label ID="lbltaxpayerblind" runat="server" Text="Tax Payer IsLegallyBlind"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox runat="server" ID="chkspouseblind" />
                    <asp:Label ID="txtspouseblind" runat="server" Text="Spouse IsLegallyBlind"></asp:Label>
                </td>
            </tr>
            <tr>

                <td>
                    <br />
                </td>
            </tr>
            </table>
             </fieldset>
            <fieldset>
            <table>
            <tr>
                <td>
                    <asp:Label ID="lblSpouseDOB" runat="server" Text="Spouse Date Of Birth"></asp:Label>
                    <asp:TextBox ID="txtSpouseDOB" runat="server">
                    </asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CeSpouseDOB" runat="server" TargetControlID="txtSpouseDOB" PopupButtonID="">
                    </ajaxToolkit:CalendarExtender>
                </td>

            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbltaxpayer" runat="server" Text="Tax Payer Date Of Birth"></asp:Label>
                    <asp:TextBox ID="txttaxpayer" runat="server">
                    </asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CeTaxpayer" runat="server" TargetControlID="txttaxpayer" PopupButtonID="">
                    </ajaxToolkit:CalendarExtender>

                </td>
            </tr>
            <tr>

                <td>
                    <br />
                </td>
            </tr>            
        </table>
            </fieldset>

        <table>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>

            </tr>
        </table>
    <div>
    </div>
            
 </form>
         
</body>
</html>
    
