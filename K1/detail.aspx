<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true"
    CodeFile="detail.aspx.cs" Inherits="detail" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <table style="width: 100%">
            <tr>
                <td width="20%">
                </td>
                <td width="80%">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <table>
                        <tr>
                            <td style="width: 30%">
                                <asp:Image ID="Image1" runat="server" />
                                <br />
                            </td>
                            <td valign="top">
                                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                                <br />
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <table width="100%">
                                    <tr>
                                        <td style="width: 100px">
                                <asp:Label ID="Label4" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                                            <br />
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            Cost:
                                        </td>
                                        <td>
                                            <asp:Label runat="server" ID="lblCost"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Discount:
                                        </td>
                                        <td>
                                            <asp:Label runat="server" ID="lblDiscount"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Final Prize:
                                        </td>
                                        <td>
                                            <asp:Label ID="Label3" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add to cart" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
