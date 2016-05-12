<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true"
    CodeFile="Belt.aspx.cs" Inherits="Belt" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%--<style type="text/css">
        .style3
        {
            width: 100%;
        }
        .style4
        {
            width: 205px;
            height: 161px;
            background-color: #6666FF;
        }
        .style5
        {
            height: 161px;
        }
        .style7
        {
            width: 205px;
            height: 25px;
            color: #FFFFFF;
            background-color: #6666FF;
        }
    </style>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--<table class="style3">
        <tr>
            <td class="style7">
                <asp:Label ID="Label1" runat="server" Text="Filter"></asp:Label>
            </td>
            <td class="style5" rowspan="8">
                <asp:Panel ID="Panel1" runat="server" Height="865px">
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Men" />
                <br />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Women" />
                <br />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Kids" />
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style4">
            </td>
        </tr>
        <tr>
            <td class="style4">
            </td>
        </tr>
        <tr>
            <td class="style4">
            </td>
        </tr>
        <tr>
            <td class="style4">
            </td>
        </tr>
        <tr>
            <td class="style4">
            </td>
        </tr>
    </table>--%>
    <table style="width: 100%">
        <tr>
            <td width="21%" valign="top">
                <table width="100%">
                    <tr>
                        <td>
                            Filter
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Men" />
                            <br />
                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Women" />
                            <br />
                            <asp:CheckBox ID="CheckBox3" runat="server" Text="Kids" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Price
                        </td>
                    </tr>
                    <tr>
                        <td>
                            
                            <asp:CheckBox ID="CheckBox4" runat="server" Text="Below 2500" />
                            <br />
                            <asp:CheckBox ID="CheckBox5" runat="server" Text="2500-5500" />
                            <br />
                            <asp:CheckBox ID="CheckBox6" runat="server" Text="5501-8500" />
                            <br />
                            <asp:CheckBox ID="CheckBox7" runat="server" Text="8501-11500" />
                            <br />
                            <asp:CheckBox ID="CheckBox8" runat="server" Text="Above 11500" />
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
                    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                            
                        </td>
                    </tr>
                </table>
            </td>
            <td valign="top">
                <asp:Panel ID="Panel1" runat="server" Width="100%" ScrollBars="Vertical" 
                    Height="637px">
                    <br />
                   
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>
