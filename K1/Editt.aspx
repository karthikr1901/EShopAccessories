<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true"
    CodeFile="Editt.aspx.cs" Inherits="Editt" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="Scripts/JScriptLib.js" type="text/javascript"></script>
    <script src="Scripts/LoadValidation.js" type="text/javascript"></script>
    <style type="text/css">
        .style4
        {
            width: 41%;
        }
        .style7
        {
            height: 26px;
        }
        .style8
        {
            width: 41%;
            height: 27px;
        }
        .style9
        {
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="Panel1" runat="server" Height="614px">
        <table width="100%">
            <tr>
                <td style="width: 50%;">
                    <asp:Panel ID="pnlGridpnel" runat="server" Width="100%" ScrollBars="Vertical" Height="250px">
                        <asp:GridView ID="gvTest" runat="server" AutoGenerateColumns="false" Width="98%">
                            <Columns>
                                <asp:TemplateField HeaderText="PicID">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lblNo" runat="server" Text='<% #Eval("PicID") %>' OnClick="lblNo_Click"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Name" HeaderText="Name" />
                                <asp:BoundField DataField="Price" HeaderText="Price" />
                                <asp:BoundField DataField="Stock" HeaderText="Stock" />
                                <asp:BoundField DataField="Category" HeaderText="Category" />
                                <asp:BoundField DataField="Discount" HeaderText="Discount" />
                                <asp:BoundField DataField="Pic" HeaderText="Pic" />
                                <asp:BoundField DataField="Brand" HeaderText="Brand" />
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    <table width="100%">
                        <tr>
                            <td class="style4">
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pic ID
                            </td>
                            <td>
                                <asp:TextBox ID="txtProductID" runat="server" Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Description
                            </td>
                            <td>
                                <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Price
                            </td>
                            <td>
                                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Stock
                            </td>
                            <td>
                                <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Category
                                1
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlCategory1" runat="server">
                                    <asp:ListItem>Bags</asp:ListItem>
                                    <asp:ListItem>Belts</asp:ListItem>
                                    <asp:ListItem>Pens</asp:ListItem>
                                    <asp:ListItem>Shoes</asp:ListItem>
                                    <asp:ListItem>Sunglasses</asp:ListItem>
                                    <asp:ListItem>Wallets</asp:ListItem>
                                    <asp:ListItem>Watches</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Discount
                            </td>
                            <td>
                                <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pic
                            </td>
                            <td>
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                &nbsp;&nbsp;
                                <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                                <asp:TextBox ID="txtPic" runat="server" Visible="False"></asp:TextBox>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class="style8">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Brand
                            </td>
                            <td class="style9">
                                <asp:TextBox ID="txtBrand" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Category 2
                            </td>
                            <td class="style7">
                                <asp:DropDownList ID="ddlCategory2" runat="server">
                                    <asp:ListItem Value="K">Kids</asp:ListItem>
                                    <asp:ListItem Value="M">Men</asp:ListItem>
                                    <asp:ListItem Value="W">Women</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center">
                                <asp:Button runat="server" Text="Save" ID="btnSubmit" OnClick="btnSave_Click" 
                                    style="height: 26px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" 
                                    Text="Delete" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
