<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true"
    CodeFile="Users.aspx.cs" Inherits="Users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%">
        <tr>
            <td align="center">
                Users
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlGrid" runat="server" Width="100%" Height="500px" ScrollBars="Vertical">
                    <asp:GridView runat="server" ID="gvUsers" AutoGenerateColumns="false" Width="100%">
                        <Columns>
                            <asp:TemplateField HeaderText="ID" ItemStyle-Width="10%">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbID" runat="server" Text='<%# Eval("CustomerID") %>' OnClick="lbID_Click"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Name" DataField="Name" ItemStyle-Width="30%" />
                            <asp:BoundField HeaderText="City" DataField="Address2" ItemStyle-Width="30%" />
                            <asp:BoundField HeaderText="Email" DataField="Email" ItemStyle-Width="30%" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>
