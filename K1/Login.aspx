<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" MaintainScrollPositionOnPostback ="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 100%">
        <tr>  
        <td>
        </td>
        </tr>
        <tr><td>
        <table style="width: 100%">
        <tr>
            <td width="5%" valign="top">                
            </td>
            <td width = "45%" valign = "middle">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/login.jpg" />
            </td>
            <td width = "5%" valign = "middle">
            </td>
            <td width = "45%" valign = "middle">

                <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Sign-in" />
                <br />
                <asp:Label ID="Label4" runat="server" Text="New user???"></asp:Label>
&nbsp;
                <asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="~/Signup.aspx">Sign-up here</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="~/Password.aspx">Forgot Password???</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                &nbsp;<asp:Label ID="lbl" runat="server"></asp:Label>
&nbsp;</td>
            </tr> 

        </table> 
        </td>       
        </tr>
    </table>
    
</asp:Content>
