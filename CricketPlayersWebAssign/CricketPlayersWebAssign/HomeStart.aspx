<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeStart.aspx.cs" Inherits="CricketPlayersWebAssign.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="player" Text="Cricket Players" AutoPostBack="True" OnCheckedChanged="RadioButton1_CheckedChanged" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="player" Text="Tennis Players" AutoPostBack="True" OnCheckedChanged="RadioButton2_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel ID="Panel1" runat="server">
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Sachin.html">Sachin Tendulkar</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/virat.html">Virat Kohli</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/msdhoni.html">MS Dhoni</asp:HyperLink><br />
                        </asp:Panel>
                    </td>
                    <td>
                        <asp:Panel ID="Panel2" runat="server">
                            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/novak.html">Novak Djokovic</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/roger.html">Roger Federer</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/andy.html">Andy Murray</asp:HyperLink><br />
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
