<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true"
    CodeFile="Cart.aspx.cs" Inherits="Cart" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="Scripts/JScriptLib.js" type="text/javascript"></script>
    <script src="Scripts/JScript.js" type="text/javascript"></script>
    <script src="Scripts/Cart.js" type="text/javascript"></script>
    <style type="text/css">
        .style6
        {
            width: 100%;
            height: 227px;
        }
        .style7
        {
            width: 378px;
        }
        .style10
        {
            width: 182px;
            height: 42px;
        }
        .style11
        {
            width: 189px;
            height: 42px;
        }
        .style12
        {
            height: 42px;
        }
        .style13
        {
            width: 100%;
        }
        .style15
        {
            width: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="Panel1" runat="server" Height="611px">
        <br />
        <asp:Panel ID="pnlGridpnel" runat="server" Width="100%" ScrollBars="Vertical" 
            Height="248px">                        
                            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table class="style13">
                <tr>
                    <td class="style15">
                        &nbsp;</td>
                    <td>
                        <asp:GridView ID="gvTest" runat="server" AutoGenerateColumns="false" 
                            Height="77px" Width="97%">
                            <Columns>
                                <asp:TemplateField HeaderText="ProductID">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lblNo" runat="server" OnClick="lblNo_Click" 
                                            Text='<% #Eval("PicID") %>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Name" HeaderText="Name" />
                                <asp:BoundField DataField="Price" HeaderText="Price" />
                                <asp:TemplateField HeaderText="Delete">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="imgDelete" runat="server" ImageUrl="~/images/delete.gif" 
                                            OnClick="imgDelte_Click" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblRandom" runat="server" Text='<%# Eval("Random") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Total"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="Panel2" runat="server" Height="324px">
            <table class="style6">
                <tr>
                    <td class="style15" rowspan="2">
                        &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="style7" rowspan="2">
                        <asp:Label ID="Label7" runat="server" Text="Mode of Payment"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                            RepeatDirection="Horizontal" 
                            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
                            <asp:ListItem>Credit Card/Debit Card</asp:ListItem>
                            <asp:ListItem>Net Banking</asp:ListItem>
                        </asp:RadioButtonList>
                        <br />
                        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Select" />
                    </td>
                    <td class="style7" rowspan="2">
                        <asp:Panel ID="Panel3" runat="server">
                            <table class="style6">
                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="Label8" runat="server" Text="Name"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style12" colspan="2">
                                        <asp:Label ID="Label9" runat="server" Text="Card Type"></asp:Label>
                                        <asp:RadioButtonList ID="RadioButtonList2" runat="server" 
                                            RepeatDirection = "Horizontal" 
                                            onselectedindexchanged="RadioButtonList2_SelectedIndexChanged" 
                                            AutoPostBack="True" >
                                            <asp:ListItem>Maestro</asp:ListItem>
                                            <asp:ListItem>Mastercard</asp:ListItem>
                                            <asp:ListItem>Visa</asp:ListItem>
                                        </asp:RadioButtonList>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="Label10" runat="server" Text="Card Number"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox11" runat="server" Width="66px" MaxLength="4"></asp:TextBox>
                                        <asp:TextBox ID="TextBox12" runat="server" Width="66px" Height="22px" 
                                            MaxLength="4"></asp:TextBox>
                                        <asp:TextBox ID="TextBox13" runat="server" Width="66px" MaxLength="4"></asp:TextBox>
                                        <asp:TextBox ID="TextBox14" runat="server" Width="66px" MaxLength="4"></asp:TextBox>
                                        <asp:TextBox ID="TextBox15" runat="server" Width="66px" MaxLength="3"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style11">
                                        <asp:Label ID="Label11" runat="server" Text="Card Expiry Date"></asp:Label>
                                        <br />
                                        <asp:DropDownList ID="DropDownList2" runat="server">
                                            <asp:ListItem>MM</asp:ListItem>
                                            <asp:ListItem>01</asp:ListItem>
                                            <asp:ListItem>02</asp:ListItem>
                                            <asp:ListItem>03</asp:ListItem>
                                            <asp:ListItem>04</asp:ListItem>
                                            <asp:ListItem>05</asp:ListItem>
                                            <asp:ListItem>06</asp:ListItem>
                                            <asp:ListItem>07</asp:ListItem>
                                            <asp:ListItem>08</asp:ListItem>
                                            <asp:ListItem>09</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>11</asp:ListItem>
                                            <asp:ListItem>12</asp:ListItem>
                                        </asp:DropDownList>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:DropDownList ID="DropDownList3" runat="server">
                                            <asp:ListItem>YYYY</asp:ListItem>
                                            <asp:ListItem>2013</asp:ListItem>
                                            <asp:ListItem>2014</asp:ListItem>
                                            <asp:ListItem>2015</asp:ListItem>
                                            <asp:ListItem>2016</asp:ListItem>
                                            <asp:ListItem>2017</asp:ListItem>
                                            <asp:ListItem>2018</asp:ListItem>
                                            <asp:ListItem>2019</asp:ListItem>
                                            <asp:ListItem>2020</asp:ListItem>
                                            <asp:ListItem>2021</asp:ListItem>
                                            <asp:ListItem>2022</asp:ListItem>
                                            <asp:ListItem>2023</asp:ListItem>
                                            <asp:ListItem>2024</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="style10">
                                        <asp:Label ID="Label13" runat="server" Text="CVV"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtCVV" runat="server" style="margin-left: 3px" 
                                            TextMode="Password" Width="66px" MaxLength="3"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style12" colspan="2">
                                        <asp:Label ID="Label14" runat="server" Text="Password"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox18" runat="server" TextMode="Password"></asp:TextBox>
                                        <br />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
            </table>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
                Text="Purchase" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox9" runat="server" Style="margin-bottom: 0px"></asp:TextBox>
            <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
