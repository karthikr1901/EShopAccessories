<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Password.aspx.cs" Inherits="Password" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script src="Scripts/SignupValidation.js" type="text/javascript"></script>
    <style type="text/css">
        .style6
        {
            width: 100%;
        }
        .style7
        {
            width: 142px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <br />
        <br />
        <br />
        <table class="style6">
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td>
        <asp:Label ID="Label1" runat="server" Text="Forgot Password"></asp:Label>
                    <br />
                    <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter your email id and phone no"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Visible="False">Password Recovery</asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Visible="False">smsmarartt@gmail.com</asp:TextBox>
        <br />
        <br />
                    <asp:Label ID="Label4" runat="server" Text="Mobile No."></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtMobile" runat="server" MaxLength="10"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                    <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" onclick="Button1_Click" Text="Submit" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

