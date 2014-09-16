<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="F1040EZLineByLineCalculations.aspx.cs" Inherits="Tax1040Web.F1040EZLineByLineCalculations" %>
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
                           <asp:Label ID="lblSocialSecurityWages1" runat="server" Text="Social security Wages"></asp:Label>
                            <asp:TextBox ID="txtSocialSecurityWages1" runat="server"></asp:TextBox>
                        </td>
</tr>
                    <tr>
                        <td>
                           <asp:Label ID="lblSocialSecurityWages2" runat="server" Text="Social security Wages"></asp:Label>
                            <asp:TextBox ID="txtSocialSecurityWages2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <asp:Label ID="lblSocialSecurityWages3" runat="server" Text="Social security Wages"></asp:Label>
                            <asp:TextBox ID="txtSocialSecurityWages3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <td>
                            <br />
                        </td>
                    <tr>
                        <td>
                           <asp:Label ID="lblSocialSecurityWithholding1" runat="server" Text="Social security Tax Withholding"></asp:Label>
                            <asp:TextBox ID="txtSocialSecurityWithholding1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <asp:Label ID="lblSocialSecurityWithholding2" runat="server" Text="Social security Tax Withholding"></asp:Label>
                            <asp:TextBox ID="txtSocialSecurityWithholding2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <asp:Label ID="lblSocialSecurityWithholding3" runat="server" Text="Social security Tax Withholding"></asp:Label>
                            <asp:TextBox ID="txtSocialSecurityWithholding3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <td>
                            <br />
                        </td>
                    <tr>
                        <td>
                            <asp:Label ID="lblMedicareWages1" runat="server" Text="Medicare Wages"></asp:Label>
                            <asp:TextBox ID="txtMedicareWages1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMedicareWages2" runat="server" Text="Medicare Wages"></asp:Label>
                            <asp:TextBox ID="txtMedicareWages2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMedicareWages3" runat="server" Text="Medicare Wages"></asp:Label>
                            <asp:TextBox ID="txtMedicareWages3" runat="server"></asp:TextBox>
                        </td>
                    </tr> 
                    <td>
                            <br />
                        </td>
                    <tr>
                        <td>
                            <asp:Label ID="lblMedicareWithheld1" runat="server" Text="Medicare Withheld"></asp:Label>
                            <asp:TextBox ID="txtMedicareWithheld1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMedicareWithheld2" runat="server" Text="Medicare Withheld"></asp:Label>
                            <asp:TextBox ID="txtMedicareWithheld2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMedicareWithheld3" runat="server" Text="Medicare Withheld"></asp:Label>
                            <asp:TextBox ID="txtMedicareWithheld3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <td>
                            <br />
                        </td>
                    <tr>
                        <td>
                            <asp:Label ID="lblAllocatedTips1" runat="server" Text="Allocated Tips"></asp:Label>
                            <asp:TextBox ID="txtAllocatedTips1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                         <td>
                            <asp:Label ID="lblAllocatedTips2" runat="server" Text="Allocated Tips"></asp:Label>
                            <asp:TextBox ID="txtAllocatedTips2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblAllocatedTips3" runat="server" Text="Allocated Tips"></asp:Label>
                            <asp:TextBox ID="txtAllocatedTips3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr><td><br /></td></tr>
                    <tr>
                        <td>
                             <asp:Label runat="server" ID="lblDependentCareBenefits1" Text="DependentCareBenefitsAmount1" ></asp:Label>
                            <asp:TextBox ID="txtDependentCareBenefits1" runat="server" ></asp:TextBox>  
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <asp:Label runat="server" ID="lblDependentCareBenefits2" Text="DependentCareBenefitsAmount2" ></asp:Label>
                            <asp:TextBox ID="txtDependentCareBenefits2" runat="server" ></asp:TextBox>  
                        </td>
                    </tr>
                    <tr>
                          <td>
                             <asp:Label runat="server" ID="lblDependentCareBenefits3" Text="DependentCareBenefitsAmount3" ></asp:Label>
                            <asp:TextBox ID="txtDependentCareBenefits3" runat="server" ></asp:TextBox>  
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblStateWages1" Text="StateWagesAmount1" ></asp:Label>
                            <asp:TextBox runat="server" ID="txtStateWages1" ></asp:TextBox>
                        </td>
                    </tr>
                      <tr>
                        <td>
                            <asp:Label runat="server" ID="lblStateWages2" Text="StateWagesAmount2" ></asp:Label>
                            <asp:TextBox runat="server" ID="txtStateWages2" ></asp:TextBox>
                        </td>
                    </tr>
                      <tr>
                        <td>
                            <asp:Label runat="server" ID="lblStateWages3" Text="StateWagesAmount3" ></asp:Label>
                            <asp:TextBox runat="server" ID="txtStateWages3" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr><td><br /></td></tr>

                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblStateWagesWTH1" Text="State Wages With Held" ></asp:Label>
                            <asp:TextBox runat="server" ID="txtStateWagesWTH1" ></asp:TextBox>
                        </td>

                    </tr>

                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblStateWagesWTH2" Text="State Wages With Held" ></asp:Label>
                            <asp:TextBox runat="server" ID="txtStateWagesWTH2" ></asp:TextBox>
                        </td>

                    </tr>

                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblStateWagesWTH3" Text="State Wages With Held" ></asp:Label>
                            <asp:TextBox runat="server" ID="txtStateWagesWTH3" ></asp:TextBox>
                        </td>

                    </tr>
                    <tr><td><br /></td></tr>
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
                   <tr>
                        <td>

                            <asp:Label ID="lblAcquisition1" runat="server" Text="AcquisitionPremium1"></asp:Label>
                            <asp:TextBox ID="txtAcquisition1" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblAcquisition2" runat="server" Text="AcquisitionPremium2"></asp:Label>
                            <asp:TextBox ID="txtAcquisition2" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblAcquisition3" runat="server" Text="AcquisitionPremium3"></asp:Label>
                            <asp:TextBox ID="txtAcquisition3" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br/>
                        </td>
                    </tr>
                     <tr>
                        <td>

                            <asp:Label ID="lblStateTaxWithHoldOID1" runat="server" Text="StateTaxWithholdingAmount1"></asp:Label>
                            <asp:TextBox ID="txtStateTaxWithHoldOID1" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                     <tr>
                        <td>

                            <asp:Label ID="lblStateTaxWithHoldOID2" runat="server" Text="StateTaxWithholdingAmount2"></asp:Label>
                            <asp:TextBox ID="txtStateTaxWithHoldOID2" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                     <tr>
                        <td>

                            <asp:Label ID="lblStateTaxWithHoldOID3" runat="server" Text="StateTaxWithholdingAmount3"></asp:Label>
                            <asp:TextBox ID="txtStateTaxWithHoldOID3" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr><td><br /></td></tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblWithdrawalPenalty1" runat="server" Text="EarlyWithdrawalPenalty1"></asp:Label>
                            <asp:TextBox ID="txtWithdrawalPenalty1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblWithdrawalPenalty2" runat="server" Text="EarlyWithdrawalPenalty2"></asp:Label>
                            <asp:TextBox ID="txtWithdrawalPenalty2" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblWithdrawalPenalty3" runat="server" Text="EarlyWithdrawalPenalty3"></asp:Label>
                            <asp:TextBox ID="txtWithdrawalPenalty3" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr><td><br /></td></tr>
                     <tr>
                        <td>
                            <asp:Label ID="lblUSTreasury1" runat="server" Text="USTreasuryObligations1"></asp:Label>
                            <asp:TextBox ID="txtUSTreasury1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                     <tr>
                        <td>
                            <asp:Label ID="lblUSTreasury2" runat="server" Text="USTreasuryObligations2"></asp:Label>
                            <asp:TextBox ID="txtUSTreasury2" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                     <tr>
                        <td>
                            <asp:Label ID="lblUSTreasury3" runat="server" Text="USTreasuryObligations3"></asp:Label>
                            <asp:TextBox ID="txtUSTreasury3" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr><td><br /></td></tr>
                    <tr>
                        <td>
                             <asp:Label ID="lblInvestmentExpenses1" runat="server" Text="InvestmentExpenses1"></asp:Label>
                            <asp:TextBox ID="txtInvestmentExpenses1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <asp:Label ID="lblInvestmentExpenses2" runat="server" Text="InvestmentExpenses2"></asp:Label>
                            <asp:TextBox ID="txtInvestmentExpenses2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <asp:Label ID="lblInvestmentExpenses3" runat="server" Text="InvestmentExpenses3"></asp:Label>
                            <asp:TextBox ID="txtInvestmentExpenses3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr><td><br /></td></tr>
                   
                    <tr><td><br /></td></tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMarketDiscount1" runat="server" Text="IncomeMarketDiscount1"></asp:Label>
                            <asp:TextBox ID="txtMarketDiscount1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMarketDiscount2" runat="server" Text="IncomeMarketDiscount2"></asp:Label>
                            <asp:TextBox ID="txtMarketDiscount2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMarketDiscount3" runat="server" Text="IncomeMarketDiscount3"></asp:Label>
                            <asp:TextBox ID="txtMarketDiscount3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr><td><br /></td></tr>

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
                     <tr>
                        <td>

                            <asp:Label ID="lblStateLocalTax1" runat="server" Text="StateOrLocalIncomeTaxRefunds1"></asp:Label>
                            <asp:TextBox ID="txtStateLocalTax1" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblStateLocalTax2" runat="server" Text="StateOrLocalIncomeTaxRefunds2"></asp:Label>
                            <asp:TextBox ID="txtStateLocalTax2" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="lblStateLocalTax3" runat="server" Text="StateOrLocalIncomeTaxRefunds3"></asp:Label>
                            <asp:TextBox ID="txtStateLocalTax3" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br/>
                        </td>
                    </tr>
                     <tr>
                        <td>

                            <asp:Label ID="lblStateTaxWithHold1" runat="server" Text="StateTaxWithholdingAmount1"></asp:Label>
                            <asp:TextBox ID="txtStateTaxWithHold1" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                     <tr>
                        <td>

                            <asp:Label ID="lblStateTaxWithHold2" runat="server" Text="StateTaxWithholdingAmount2"></asp:Label>
                            <asp:TextBox ID="txtStateTaxWithHold2" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                     <tr>
                        <td>

                            <asp:Label ID="lblStateTaxWithHold3" runat="server" Text="StateTaxWithholdingAmount3"></asp:Label>
                            <asp:TextBox ID="txtStateTaxWithHold3" runat="server"></asp:TextBox>


                        </td>
                    </tr>

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
                    <tr>
                        <td>

                            <asp:Label ID="lblStateTaxWithHoldInt1" runat="server" Text="StateTaxWithholdingAmount1"></asp:Label>
                            <asp:TextBox ID="txtStateTaxWithHoldInt1" runat="server"></asp:TextBox>


                        </td>
                    </tr>
                     <tr>
                        <td>

                            <asp:Label ID="lblStateTaxWithHoldInt2" runat="server" Text="StateTaxWithholdingAmount2"></asp:Label>
                            <asp:TextBox ID="txtStateTaxWithHoldInt2" runat="server"></asp:TextBox>


                        </td>
                         </tr>
                    <tr><td><br /></td></tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblEarlyWithdrawalPenalty1" runat="server" Text="EarlyWithdrawalPenalty1"></asp:Label>
                            <asp:TextBox ID="txtEarlyWithdrawalPenalty1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                     <tr>
                        <td>
                            <asp:Label ID="lblEarlyWithdrawalPenalty2" runat="server" Text="EarlyWithdrawalPenalty2"></asp:Label>
                            <asp:TextBox ID="txtEarlyWithdrawalPenalty2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                     <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                   
                    <tr><td><br /></td></tr>
                    <tr>
                        <td>
                             <asp:Label ID="lblInvestment1" runat="server" Text="InvestmentExpenses1"></asp:Label>
                            <asp:TextBox ID="txtInvestment1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <asp:Label ID="lblInvestment2" runat="server" Text="InvestmentExpenses2"></asp:Label>
                            <asp:TextBox ID="txtInvestment2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr><td><br /></td></tr>
                    <tr>
                        <td>
                             <asp:Label ID="lblForeignTaxPaid1" runat="server" Text="ForeignTaxPaid1"></asp:Label>
                             <asp:TextBox ID="txtForeignTaxPaid1" runat="server"></asp:TextBox>
     
                        </td>
                   </tr>
                    <tr>
                        <td>
                             <asp:Label ID="lblForeignTaxPaid2" runat="server" Text="ForeignTaxPaid2"></asp:Label>
                             <asp:TextBox ID="txtForeignTaxPaid2" runat="server"></asp:TextBox>
     
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
                        <td>          <b>           Date of Death</b>  </td>

                    </tr>

                    <tr>
                        
                        <td>
                            <asp:Label ID="lblPrimaryTaxPayerDOD" runat="server" Text="TaxPayer Date of death"></asp:Label>
                            <asp:TextBox ID="txtTpDateOfDeath" runat="server">
                            </asp:TextBox>
                            <ajaxToolkit:CalendarExtender ID="CdTpDeathOf" runat="server" TargetControlID="txtTpDateOfDeath" PopupButtonID="">
                            </ajaxToolkit:CalendarExtender>

                        </td>

                    </tr>

                    <tr>
                        
                        <td>
                            <asp:Label ID="lblSpouseDOD" runat="server" Text="Spouse Date of death"></asp:Label>
                            <asp:TextBox ID="txtSpouseDateOfDeath" runat="server">
                            </asp:TextBox>
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtSpouseDateOfDeath" PopupButtonID="">
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
                            
                            <asp:CheckBox ID="chkIRSFiling8862" Text="Have You received notice from IRS states that you can file Form 8862 to claim disallowance(EIC)" AutoPostBack="true" runat="server" />
                            <asp:Panel ID="pnlForF8862" runat="server" Visible="false">
                                &nbsp&nbsp&nbsp<asp:CheckBox ID="chkEICdisallowed" Text="HasEICdisallowed" runat="server" /><br />
                                &nbsp;&nbsp;&nbsp;<asp:CheckBox ID="chkReportedIncorrectIncome" Text="HasReportedIncorrectIncome" runat="server" /><br />
                                &nbsp;&nbsp;&nbsp;<asp:CheckBox ID="chkDaysLivedInUS" runat="server" AutoPostBack="true" Text="How many days Tax payer lived in US" /><br />
                                <asp:Panel runat="server" Visible="false" ID="pnlF8860Q3">
                                    &nbsp&nbsp&nbsp&nbsp
                                            <asp:Label ID="lbltaxpayer" runat="server" Text="Tax Payer lived in US"> </asp:Label>
                                    &nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtTaxpayer8862" runat="server" /><br />
                                </asp:Panel>
                                &nbsp;&nbsp;&nbsp;<asp:CheckBox ID="chkspouse" Text="How many day spouse lived in US" AutoPostBack="true" runat="server" /><br />
                                <asp:Panel runat="server" Visible="false" ID="pnlspouse">
                                    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblspousepayer" runat="server" Text="Spouse Payer Lived in US"> </asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtspouse8862" runat="server" />
                                </asp:Panel>
                            </asp:Panel>
                            <br />
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
                    <asp:Label ID="lblNetBenefitSSB1" Text="SSB Net Benefit1" runat="server"></asp:Label>
                    <asp:TextBox ID="txtNetBenefitSSB1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFederalWithSSB1" Text="SSB Federal Tax Withholding1" runat="server"></asp:Label>
                    <asp:TextBox ID="txtFederalWithSSB1" runat="server"></asp:TextBox>
                </td>
            </tr>
                    <tr>
                        <td>
                             <asp:Label ID="lblNetBenefitSSB2" Text="SSB Net Benefit2" runat="server"></asp:Label>
                    <asp:TextBox ID="txtNetBenefitSSB2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                          <asp:Label ID="lblFederalWithSSB2" Text="SSB Federal Tax Withholding2" runat="server"></asp:Label>
                    <asp:TextBox ID="txtFederalWithSSB2" runat="server"></asp:TextBox>
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
                    <asp:Label ID="lblNetBenefitRRB1" Text="RRB Net Benefit1" runat="server"></asp:Label>
                    <asp:TextBox ID="txtNetBenefitRRB1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="lblNetBenefitRRB2" Text="RRB Net Benefit2" runat="server"></asp:Label>
                    <asp:TextBox ID="txtNetBenefitRRB2" runat="server"></asp:TextBox>
                </td>
            </tr>
               <tr>
                <td>
                    <asp:Label ID="lblFederalWithRRB1" Text="RRB Federal Tax Withhoding1" runat="server"></asp:Label>
                    <asp:TextBox ID="txtFederalWithRRB1" runat="server"></asp:TextBox>
                </td>
            </tr>
               <tr>
                <td>
                    <asp:Label ID="lblFederalWithRRB2" Text="RRB Federal Tax Withhoding2" runat="server"></asp:Label>
                    <asp:TextBox ID="txtFederalWithRRB2" runat="server"></asp:TextBox>
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
