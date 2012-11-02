<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MiniaturePrice1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <center>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Current Price:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCurrentPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Days In Future:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDays" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                    <br />
                        <asp:Literal ID="lblFutureContract" runat="server"></asp:Literal>
                    </td>
                </tr>
            </table>
        </center>
    </div>
</asp:Content>
