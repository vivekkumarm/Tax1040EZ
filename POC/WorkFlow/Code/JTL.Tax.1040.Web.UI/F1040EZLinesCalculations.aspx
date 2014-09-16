<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="F1040EZLinesCalculations.aspx.cs" Inherits="Tax1040Web.F1040EZLinesCalculations" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=3.5.40412.0, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblError" Visible="false" runat="server" ForeColor="Red" Text="You are not Eligible to file 1040Ez"></asp:Label></td>

                    </tr>
                    <tr>
                        <td>
                            <asp:ValidationSummary ID="validationSummary" runat="server" ForeColor="Red" />

                        </td>
                    </tr>
                </table>
                <table>
                    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
                    <tr>
                        <td>
                            <h3>W2 FORM INPUT</h3>

                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblW21" runat="server" Text="WageAmount1"></asp:Label>
                            <asp:TextBox ID="txtW21" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblW22" runat="server" Text="WageAmount2"></asp:Label>
                            <asp:TextBox ID="txtW22" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblW23" runat="server" Text="WageAmount3"></asp:Label>
                            <asp:TextBox ID="txtW23" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFTW21" runat="server" Text="FederalTaxWithHeldW21"></asp:Label>
                            <asp:TextBox ID="txtFTW21" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFTW22" runat="server" Text="FederalTaxWithHeldW22"></asp:Label>
                            <asp:TextBox ID="txtFTW2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblFTW23" runat="server" Text="FederalTaxWithHeldW23"></asp:Label>
                            <asp:TextBox ID="txtFTW3" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblw2Line11" runat="server" Text="Non Qualified plans"></asp:Label>
                            <asp:TextBox ID="txtw2Line11Amount" runat="server"></asp:TextBox>

                        </td>

                    </tr>
                     <tr>
                        <td><br/></td>

                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="lbl12a" runat="server" Text="W2 12a"></asp:Label>
                            <asp:DropDownList ID="ddlw212a" runat="server">
                                <asp:ListItem Value="0">None</asp:ListItem>
                                <asp:ListItem Value="1">A</asp:ListItem>
                                <asp:ListItem Value="2">B</asp:ListItem>
                                <asp:ListItem Value="3">C</asp:ListItem>
                                <asp:ListItem Value="4">D</asp:ListItem>
                                <asp:ListItem Value="5">E</asp:ListItem>
                                <asp:ListItem Value="6">F</asp:ListItem>
                                <asp:ListItem Value="7">G</asp:ListItem>
                                <asp:ListItem Value="8">H</asp:ListItem>
                                <asp:ListItem Value="9">J</asp:ListItem>
                                <asp:ListItem Value="10">K</asp:ListItem>
                                <asp:ListItem Value="11">L</asp:ListItem>
                                <asp:ListItem Value="12">M</asp:ListItem>
                                <asp:ListItem Value="13">N</asp:ListItem>
                                <asp:ListItem Value="14">P</asp:ListItem>
                                <asp:ListItem Value="15">Q</asp:ListItem>
                                <asp:ListItem Value="16">R</asp:ListItem>
                                <asp:ListItem Value="17">S</asp:ListItem>
                                <asp:ListItem Value="18">T</asp:ListItem>
                                <asp:ListItem Value="19">V</asp:ListItem>
                                <asp:ListItem Value="20">W</asp:ListItem>
                                <asp:ListItem Value="21">Z</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="lblW212aAmount" runat="server" Text="W2 12a Amount"></asp:Label>
                            <asp:TextBox ID="txtW212aAmount" runat="server"></asp:TextBox>
                        </td>

                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="lbl12b" runat="server" Text="W2 12b"></asp:Label>
                            <asp:DropDownList ID="ddlW212b" runat="server">
                                <asp:ListItem Value="0">None</asp:ListItem>
                                <asp:ListItem Value="1">A</asp:ListItem>
                                <asp:ListItem Value="2">B</asp:ListItem>
                                <asp:ListItem Value="3">C</asp:ListItem>
                                <asp:ListItem Value="4">D</asp:ListItem>
                                <asp:ListItem Value="5">E</asp:ListItem>
                                <asp:ListItem Value="6">F</asp:ListItem>
                                <asp:ListItem Value="7">G</asp:ListItem>
                                <asp:ListItem Value="8">H</asp:ListItem>
                                <asp:ListItem Value="9">J</asp:ListItem>
                                <asp:ListItem Value="10">K</asp:ListItem>
                                <asp:ListItem Value="11">L</asp:ListItem>
                                <asp:ListItem Value="12">M</asp:ListItem>
                                <asp:ListItem Value="13">N</asp:ListItem>
                                <asp:ListItem Value="14">P</asp:ListItem>
                                <asp:ListItem Value="15">Q</asp:ListItem>
                                <asp:ListItem Value="16">R</asp:ListItem>
                                <asp:ListItem Value="17">S</asp:ListItem>
                                <asp:ListItem Value="18">T</asp:ListItem>
                                <asp:ListItem Value="19">V</asp:ListItem>
                                <asp:ListItem Value="20">W</asp:ListItem>
                                <asp:ListItem Value="21">Z</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="lblW212bAmount" runat="server" Text="W2 12b Amount"></asp:Label>
                            <asp:TextBox ID="txtW212bAmount" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                     <tr>
                        <td>
                            <br />
                        </td>

                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="lblW2212a" runat="server" Text="W2 2 12a"></asp:Label>
                            <asp:DropDownList ID="ddlw2212a" runat="server">
                                <asp:ListItem Value="0">None</asp:ListItem>
                                <asp:ListItem Value="1">A</asp:ListItem>
                                <asp:ListItem Value="2">B</asp:ListItem>
                                <asp:ListItem Value="3">C</asp:ListItem>
                                <asp:ListItem Value="4">D</asp:ListItem>
                                <asp:ListItem Value="5">E</asp:ListItem>
                                <asp:ListItem Value="6">F</asp:ListItem>
                                <asp:ListItem Value="7">G</asp:ListItem>
                                <asp:ListItem Value="8">H</asp:ListItem>
                                <asp:ListItem Value="9">J</asp:ListItem>
                                <asp:ListItem Value="10">K</asp:ListItem>
                                <asp:ListItem Value="11">L</asp:ListItem>
                                <asp:ListItem Value="12">M</asp:ListItem>
                                <asp:ListItem Value="13">N</asp:ListItem>
                                <asp:ListItem Value="14">P</asp:ListItem>
                                <asp:ListItem Value="15">Q</asp:ListItem>
                                <asp:ListItem Value="16">R</asp:ListItem>
                                <asp:ListItem Value="17">S</asp:ListItem>
                                <asp:ListItem Value="18">T</asp:ListItem>
                                <asp:ListItem Value="19">V</asp:ListItem>
                                <asp:ListItem Value="20">W</asp:ListItem>
                                <asp:ListItem Value="21">Z</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="lblW2212aAmount" runat="server" Text="W2 2 12a Amount"></asp:Label>
                            <asp:TextBox ID="txtW2212aAmount" runat="server"></asp:TextBox>
                        </td>

                    </tr>
                     

                    <tr>
                        <td>
                            <asp:Label ID="lblW2212b" runat="server" Text="W2 2 12b"></asp:Label>
                            <asp:DropDownList ID="ddlW2212b" runat="server">
                                <asp:ListItem Value="0">None</asp:ListItem>
                                <asp:ListItem Value="1">A</asp:ListItem>
                                <asp:ListItem Value="2">B</asp:ListItem>
                                <asp:ListItem Value="3">C</asp:ListItem>
                                <asp:ListItem Value="4">D</asp:ListItem>
                                <asp:ListItem Value="5">E</asp:ListItem>
                                <asp:ListItem Value="6">F</asp:ListItem>
                                <asp:ListItem Value="7">G</asp:ListItem>
                                <asp:ListItem Value="8">H</asp:ListItem>
                                <asp:ListItem Value="9">J</asp:ListItem>
                                <asp:ListItem Value="10">K</asp:ListItem>
                                <asp:ListItem Value="11">L</asp:ListItem>
                                <asp:ListItem Value="12">M</asp:ListItem>
                                <asp:ListItem Value="13">N</asp:ListItem>
                                <asp:ListItem Value="14">P</asp:ListItem>
                                <asp:ListItem Value="15">Q</asp:ListItem>
                                <asp:ListItem Value="16">R</asp:ListItem>
                                <asp:ListItem Value="17">S</asp:ListItem>
                                <asp:ListItem Value="18">T</asp:ListItem>
                                <asp:ListItem Value="19">V</asp:ListItem>
                                <asp:ListItem Value="20">W</asp:ListItem>
                                <asp:ListItem Value="21">Z</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="lblW2212bAmount" runat="server" Text="W2 2 12b Amount"></asp:Label>
                            <asp:TextBox ID="txtW2212bAmount" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                     <tr>
                        <td>
                            <br />
                        </td>

                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="lblW2312a" runat="server" Text="W2 3 12a"></asp:Label>
                            <asp:DropDownList ID="ddlw2312a" runat="server">
                                <asp:ListItem Value="0">None</asp:ListItem>
                                <asp:ListItem Value="1">A</asp:ListItem>
                                <asp:ListItem Value="2">B</asp:ListItem>
                                <asp:ListItem Value="3">C</asp:ListItem>
                                <asp:ListItem Value="4">D</asp:ListItem>
                                <asp:ListItem Value="5">E</asp:ListItem>
                                <asp:ListItem Value="6">F</asp:ListItem>
                                <asp:ListItem Value="7">G</asp:ListItem>
                                <asp:ListItem Value="8">H</asp:ListItem>
                                <asp:ListItem Value="9">J</asp:ListItem>
                                <asp:ListItem Value="10">K</asp:ListItem>
                                <asp:ListItem Value="11">L</asp:ListItem>
                                <asp:ListItem Value="12">M</asp:ListItem>
                                <asp:ListItem Value="13">N</asp:ListItem>
                                <asp:ListItem Value="14">P</asp:ListItem>
                                <asp:ListItem Value="15">Q</asp:ListItem>
                                <asp:ListItem Value="16">R</asp:ListItem>
                                <asp:ListItem Value="17">S</asp:ListItem>
                                <asp:ListItem Value="18">T</asp:ListItem>
                                <asp:ListItem Value="19">V</asp:ListItem>
                                <asp:ListItem Value="20">W</asp:ListItem>
                                <asp:ListItem Value="21">Z</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="lblW2312aAmount" runat="server" Text="W2 3 12a Amount"></asp:Label>
                            <asp:TextBox ID="txtW2312aAmount" runat="server"></asp:TextBox>
                        </td>

                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="lblW2312b" runat="server" Text="W2 3 12b"></asp:Label>
                            <asp:DropDownList ID="ddlW2312b" runat="server">
                                <asp:ListItem Value="0">None</asp:ListItem>
                                <asp:ListItem Value="1">A</asp:ListItem>
                                <asp:ListItem Value="2">B</asp:ListItem>
                                <asp:ListItem Value="3">C</asp:ListItem>
                                <asp:ListItem Value="4">D</asp:ListItem>
                                <asp:ListItem Value="5">E</asp:ListItem>
                                <asp:ListItem Value="6">F</asp:ListItem>
                                <asp:ListItem Value="7">G</asp:ListItem>
                                <asp:ListItem Value="8">H</asp:ListItem>
                                <asp:ListItem Value="9">J</asp:ListItem>
                                <asp:ListItem Value="10">K</asp:ListItem>
                                <asp:ListItem Value="11">L</asp:ListItem>
                                <asp:ListItem Value="12">M</asp:ListItem>
                                <asp:ListItem Value="13">N</asp:ListItem>
                                <asp:ListItem Value="14">P</asp:ListItem>
                                <asp:ListItem Value="15">Q</asp:ListItem>
                                <asp:ListItem Value="16">R</asp:ListItem>
                                <asp:ListItem Value="17">S</asp:ListItem>
                                <asp:ListItem Value="18">T</asp:ListItem>
                                <asp:ListItem Value="19">V</asp:ListItem>
                                <asp:ListItem Value="20">W</asp:ListItem>
                                <asp:ListItem Value="21">Z</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="lblW2312bAmount" runat="server" Text="W2 3 12b Amount"></asp:Label>
                            <asp:TextBox ID="txtW2312bAmount" runat="server"></asp:TextBox>
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
                            <h3>1099-OID FORM INPUT</h3>

                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblOID1" runat="server" Text="OID1"></asp:Label>
                            <asp:TextBox ID="txtOID1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblOID2" runat="server" Text="OID2"></asp:Label>
                            <asp:TextBox ID="txtOID2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblOID3" runat="server" Text="OID3"></asp:Label>
                            <asp:TextBox ID="txtOID3" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFDOID1" runat="server" Text="FederalTaxWithHeldOID1"></asp:Label>
                            <asp:TextBox ID="txtFDOID1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFDOID2" runat="server" Text="FederalTaxWithHeldOID2"></asp:Label>
                            <asp:TextBox ID="txtFDOID2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblFDOID3" runat="server" Text="FederalTaxWithHeldOID3"></asp:Label>
                            <asp:TextBox ID="txtFDOID3" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>

                    </tr>


                    <tr>
                        <td>
                            <asp:Label ID="lblOPIOID1" runat="server" Text="OtherPeriodicInterestOID1"></asp:Label>
                            <asp:TextBox ID="txtOPIOID1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblOPIOID2" runat="server" Text="OtherPeriodicInterestOID2"></asp:Label>
                            <asp:TextBox ID="txtOPIOID2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblOPIOID3" runat="server" Text="OtherPeriodicInterestOID3"></asp:Label>
                            <asp:TextBox ID="txtOPIOID3" runat="server"></asp:TextBox>


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
                            <h3>1099G FORM INPUT</h3>

                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblG1" runat="server" Text="UnEmploymentG1"></asp:Label>
                            <asp:TextBox ID="txtg1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblG2" runat="server" Text="UnEmploymentG2"></asp:Label>
                            <asp:TextBox ID="txtg2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblG3" runat="server" Text="UnEmploymentG3"></asp:Label>
                            <asp:TextBox ID="txtg3" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFDG1" runat="server" Text="FederalTaxWithHeldG1"></asp:Label>
                            <asp:TextBox ID="txtFDG1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFDG2" runat="server" Text="FederalTaxWithHeldG2"></asp:Label>
                            <asp:TextBox ID="txtFDG2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblFDG3" runat="server" Text="FederalTaxWithHeldG3"></asp:Label>
                            <asp:TextBox ID="txtFDG3" runat="server"></asp:TextBox>

                        </td>
                    </tr>

                    <tr>
                        <td>
                            <br />
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblAlaska1" runat="server" Text="AlaskaAlaskaPermanentFund1"></asp:Label>
                            <asp:TextBox ID="txtAlaska1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblAlaska2" runat="server" Text="AlaskaAlaskaPermanentFund2"></asp:Label>
                            <asp:TextBox ID="txtAlaska2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblAlaska3" runat="server" Text="AlaskaAlaskaPermanentFund3"></asp:Label>
                            <asp:TextBox ID="txtAlaska3" runat="server"></asp:TextBox>

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
                            <h3>1099-INT FORM INPUT</h3>

                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblIntIncome1" runat="server" Text="IntrestIncome1"></asp:Label>
                            <asp:TextBox ID="txtIntrestIncome1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblIntIncome2" runat="server" Text="IntrestIncome2"></asp:Label>
                            <asp:TextBox ID="txtIntrestIncome2" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFTWIntInc1" runat="server" Text="FederalTaxWithHeldIntInc1"></asp:Label>
                            <asp:TextBox ID="txtFTWIntInc1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFTWIntInc2" runat="server" Text="FederalTaxWithHeldIntInc2"></asp:Label>
                            <asp:TextBox ID="txtFTWIntInc2" runat="server"></asp:TextBox>
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
                            <h3>PERSONAL INPUT</h3>

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
                            <asp:Label ID="lblPrimaryTaxPayerDOB" runat="server" Text="Primary TaxPayer DOB"></asp:Label>
                            <asp:TextBox ID="txtPrimaryTaxPayerDOB" runat="server">
                            </asp:TextBox>
                            <ajaxToolkit:CalendarExtender ID="CeDOB" runat="server" TargetControlID="txtPrimaryTaxPayerDOB" PopupButtonID="">
                            </ajaxToolkit:CalendarExtender>

                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblSpouseTaxpayerDOB" runat="server" Text="TaxPayerSpouse DOB"></asp:Label>
                            <asp:TextBox ID="txtSpouseDOB" runat="server">
                            </asp:TextBox>
                            <ajaxToolkit:CalendarExtender ID="CalendarDOB" runat="server" TargetControlID="txtSpouseDOB" PopupButtonID="">
                            </ajaxToolkit:CalendarExtender>
                    
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="chkHasClaimedAsDependentTP" Text="chkHasClaimedAsDependentTaxPayer" runat="server" />

                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:CheckBox ID="chkHasClaimedAsDependentS" Text="chkHasClaimedAsDependentSpouse" runat="server" />

                        </td>
                    </tr>
                    <tr>
                        <td><br/></td>

                    </tr>

                </table>
            </fieldset>
            <Fieldset>
                
                 <asp:Label ID="lblEICDetails" runat="server" Text="EIC RULE CHECK" Font-Bold="True"></asp:Label>
                <br/>
                <table>
             <tr>
                <td>
                    <asp:CheckBox ID="chkLivedInUSStatus" Text="Lived in United States for more than half of the year" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkVaildSSN" Text="You or your spouse has a valid social security Number " runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkQualifyingChild" Text="You or your Spouse has treated as qualifying child for another person in 2014. " runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkIRSNotice" Text="Have You received a notice from IRS that he/she can’t claim the EIC credit in 2014. " runat="server" />
                </td>
            </tr>
                    <tr>
                        <td>
                            
                            <asp:CheckBox ID="chkIRSFiling8862" Text="Have You received notice from IRS states that you can file Form 8862 to claim disallowance(EIC) " runat="server" />
                        </td>
                    </tr>
               </table>
   <tr>
                        <td><br/></td>

                    </tr>

            </Fieldset>
            <Fieldset>
                 <asp:Label ID="lblOther" runat="server" Text="OTHER EIC " Font-Bold="True"></asp:Label>
                <table>
                    <tr>
                        <td>
                            <asp:CheckBox ID="chkTaxableScholarship" Text="Did you or your spouse receive any taxable scholarship or Fellowship Income?" AutoPostBack="True" runat="server" />
                        </td>
                        
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="pnlTaxableScholarship" Visible="False" runat="server">
                            <asp:TextBox ID="txtTaxableScholarshipAmount" runat="server"></asp:TextBox>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="chkPensionPlans" Text="Did you or your spouse receive any Pension or annuity from a non-qualified deferred compensation plan?" AutoPostBack="True" runat="server" />
                            
                        </td>
                        

                    </tr>
                    <tr>
                        <asp:Panel ID="pnlPensionPlans" Visible="False" runat="server">
                        <td>
                            <asp:TextBox ID="txtPensionPlansAmount" runat="server"></asp:TextBox>
                        </td>
                        </asp:Panel>
                        
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="chkPenalInstitution" Text="Did you or your spouse receive wages for work done while an inmate in a penal institution?" AutoPostBack="True" runat="server" />

                        </td>
                       
                    </tr>
                    <tr>
                        <asp:Panel ID="pnlPenalInstitution" Visible="False" runat="server">
                         <td>
                            <asp:TextBox ID="txtPenalInstitutionAmount"  runat="server"></asp:TextBox>
                        </td>
                        </asp:Panel>
                    </tr>
                      <tr>
                        <td><br/></td>

                    </tr>
                </table>
            </Fieldset>

            <fieldset>
                <table>

                      <tr>
                        <td>
                            <h3>SOCIAL SECURITY BENEFITS INPUT</h3>

                        </td>

                    </tr>
                   <tr>
                <td>
                    <asp:Label ID="lblNetBenefitSSB" Text="SSB Net Benefit" runat="server"></asp:Label>
                    <asp:TextBox ID="txtNetBenefitSSB" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFederalWithSSB" Text="SSB Federal Tax Withholding" runat="server"></asp:Label>
                    <asp:TextBox ID="txtFederalWithSSB" runat="server"></asp:TextBox>
                </td>
            </tr>
            </table>
            </fieldset>

            <fieldset>
           <table>
               <tr>
                        <td>
                            <h3>Railroad Retirement BENEFITS INPUT</h3>

                        </td>

              </tr>
                    
            <tr>
                <td>
                    <asp:Label ID="lblNetBenefitRRB" Text="RRB Net Benefit" runat="server"></asp:Label>
                    <asp:TextBox ID="txtNetBenefitRRB" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFederalWithRRB" Text="RRB Federal Tax Withhoding" runat="server"></asp:Label>
                    <asp:TextBox ID="txtFederalWithRRB" runat="server"></asp:TextBox>
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



        </div>
    </form>
</body>
</html>

