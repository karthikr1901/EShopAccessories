<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true"
    CodeFile="Purchase.aspx.cs" Inherits="Purchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%">
        <tr>
            <td align="center">
                <asp:Label runat="server" Text="" ID="lblHead"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlGrid" runat="server" Width="100%" Height="500px" ScrollBars="Vertical">
                    <asp:GridView runat="server" ID="gvPurchase" AutoGenerateColumns="false" Width="100%">
                        <Columns>
                            <asp:BoundField HeaderText="Name" DataField="Name" ItemStyle-Width="50%" />
                            <asp:BoundField HeaderText="Date" DataField="Date" ItemStyle-Width="30%" />
                            <asp:BoundField HeaderText="Price" DataField="Price" ItemStyle-Width="20%" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTotalItems" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTotalPrice" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
