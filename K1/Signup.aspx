<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true"
    CodeFile="Signup.aspx.cs" Inherits="Signup" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="Scripts/SignupValidation.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 100%">
        <tr style="height: 50px">
            <td style="width: 20%">
            </td>
            <td style="width: 60%">
            </td>
            <td style="width: 20%">
            </td>
        </tr>
        <tr>
            <td style="width: 20%">
            </td>
            <td style="width: 60%">
                <table style="width: 100%">
                    <tr>
                        <td style="width: 20%">
                            <asp:Label ID="Label1" runat="server" Text="Sign up"></asp:Label>
                        </td>
                        <td style="width: 50%">
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Height="50px" 
                                Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="City"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCity" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Mobile number"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtMobile" runat="server" Width="200px" MaxLength="10"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" 
                                ValidationGroup="a" />
                        </td>
                        <td>
                            &nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnOK" runat="server" OnClick="Button2_Click" Text="OK" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label9" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="width: 20%">
            </td>
        </tr>
        <tr>
            <td style="width: 20%">
            </td>
            <td style="width: 60%">
                <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>
<%--                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4"
                    ErrorMessage="Enter numbers 0 - 9 for mobile number" ValidationExpression="(^(\+?\-? *[0-9]+)([,0-9 ]*)([0-9 ])*$)|(^ *$)"
                    ValidationGroup="a"></asp:RegularExpressionValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox8" runat="server" Enabled="False" Visible="False">smsmarartt@gmail.com</asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Enter valid name" ValidationExpression="" ValidationGroup="a"></asp:RegularExpressionValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="Enter valid address" ValidationExpression="" ValidationGroup="a"></asp:RegularExpressionValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox3"
                    ErrorMessage="Enter valid city" ValidationExpression="" ValidationGroup="a"></asp:RegularExpressionValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox6"
                    ErrorMessage="Enter valid email-id" ValidationExpression="" ValidationGroup="a"></asp:RegularExpressionValidator>
                <br />--%>
            </td>
            <td style="width: 20%">
            </td>
        </tr>
    </table>
</asp:Content>
