<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table style = "width :100%">
    <tr>
    <td>
    </td>
    </tr>

    <tr>
    <td>
    <table style = "width :100%">
                <tr>
                    <td style = "width :10%">
                    </td>
                    <td style = "width :80%">
                    <table style = "width :100%">
                    <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Feedback" style="font-size: large"></asp:Label>
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="EmailID"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Enter feedback"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="298px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <asp:Panel ID="Panel1" runat="server" Height="288px" ScrollBars = "Vertical">
                            <asp:GridView runat="server" ID="gvUsers" AutoGenerateColumns="false" 
                        Width="100%">
                                <Columns>                                    
                                <asp:BoundField HeaderText="Sno" DataField="Sno" ItemStyle-Width="5%" />
                                    <asp:BoundField HeaderText="Feedback" DataField="EmailID" ItemStyle-Width="5%" />
                                    <asp:BoundField HeaderText="Feedback" DataField="Feedback" ItemStyle-Width="60%" />
                                    <asp:BoundField HeaderText="Posted" DataField="Posted" ItemStyle-Width="30%" />
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>
                    </td>
                    </tr>
                    </table>
                    </td>
                    <td style = "width :10%">
                    </td>
                </tr>
    </table>
    </td>
    </tr>
                
        <tr>
        <td>
        </td>
        </tr>
        
    </table>
        
</asp:Content>

