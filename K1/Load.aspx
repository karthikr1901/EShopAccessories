<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true"
    CodeFile="Load.aspx.cs" Inherits="Load" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="Scripts/JScriptLib.js" type="text/javascript"></script>
    <script src="Scripts/LoadValidation.js" type="text/javascript"></script>
    <style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style7
        {
            width: 125px;
        }
        .style8
        {
            width: 125px;
            height: 49px;
        }
        .style9
        {
            height: 49px;
        }
        .rowheight
        {
            height: 30px;
        }
        .pricetext
        {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="style6">
        <tr>
            <td class="style8">
            </td>
            <td class="style9">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
            </td>
            <td>
                <table width="100%">
                    <tr>
                        <td style="width: 15%; height: 30px;">
                            <asp:Label ID="Label1" runat="server" Text="PicID"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPicID" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rowheight">
                            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server" Width="250px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rowheight">
                            <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDesc" runat="server" Width="250px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rowheight">
                            <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rowheight">
                            <asp:Label ID="Label5" runat="server" Text="Stock"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rowheight">
                            <asp:Label ID="Label6" runat="server" Text="Category1"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCategory1" runat="server" Width="128px">
                                <asp:ListItem>Bags</asp:ListItem>
                                <asp:ListItem>Belts</asp:ListItem>
                                <asp:ListItem>Pens</asp:ListItem>
                                <asp:ListItem>Shoes</asp:ListItem>
                                <asp:ListItem>Sunglasses</asp:ListItem>
                                <asp:ListItem>Wallets</asp:ListItem>
                                <asp:ListItem>Watches</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="rowheight">
                            <asp:Label ID="Label7" runat="server" Text="Discount"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rowheight">
                            <asp:Label ID="Label8" runat="server" Text="Pic"></asp:Label>
                        </td>
                        <td>
                            <asp:FileUpload ID="FileUpload1" runat="server" Width="250px" />
                            <asp:TextBox ID="txtUrl" runat="server" Visible="false"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rowheight">
                            <asp:Label ID="Label9" runat="server" Text="Brand"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtBrand" runat="server" Width="250px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rowheight">
                            <asp:Label ID="Label10" runat="server" Text="Category2"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCategory2" runat="server" Width="128px">
                                <asp:ListItem Value="K">Kids</asp:ListItem>
                                <asp:ListItem Value="M">Men</asp:ListItem>
                                <asp:ListItem Value="W">Women</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="rowheight">
                            <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" />
                        </td>
                        <td style="padding: 20px;">
                            <asp:Button ID="btnEdit" runat="server" OnClick="Button2_Click" Text="Edit" Width="66px" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="rowheight">
                            <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
