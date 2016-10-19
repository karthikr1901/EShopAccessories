<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true"
    CodeFile="OffersImage.aspx.cs" Inherits="OffersImage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%">
        <tr>
            <td>
                <strong>Upload Images on Home Page
            </strong>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlImage" runat="server">
                    <asp:ListItem>Main Image</asp:ListItem>
                    <asp:ListItem>Right Top</asp:ListItem>
                    <asp:ListItem>Right Bottom</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="txtPic" runat="server" Visible="False"></asp:TextBox>
                <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="btnUpload" Text="Upload" 
                    onclick="btnUpload_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
