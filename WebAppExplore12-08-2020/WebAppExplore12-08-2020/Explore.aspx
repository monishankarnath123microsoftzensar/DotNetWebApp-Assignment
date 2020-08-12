<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Explore.aspx.cs" Inherits="WebAppExplore12_08_2020.Explore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            List Box:<br />
            ================</div>
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>Kolkata</asp:ListItem>
            <asp:ListItem>Pune</asp:ListItem>
            <asp:ListItem>Bangalore</asp:ListItem>
            <asp:ListItem>Delhi</asp:ListItem>
        </asp:ListBox>
        Design Time============RunTime<asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
        <br />
        ================<br />
        RadioButton List:<br />
        Design Time<asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Moni</asp:ListItem>
            <asp:ListItem>Samiran</asp:ListItem>
            <asp:ListItem>Dipanjan</asp:ListItem>
            <asp:ListItem>Subhojit</asp:ListItem>
        </asp:RadioButtonList>
        ============RunTime<br />
        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
        </asp:RadioButtonList>
        <br />
        ===================<br />
        Checkbox List:<br />
        Design Time<asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Biriyani</asp:ListItem>
            <asp:ListItem>Rosogolla</asp:ListItem>
            <asp:ListItem>Kochuri</asp:ListItem>
            <asp:ListItem>Gelabi</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        ==============RunTime<asp:CheckBoxList ID="CheckBoxList2" runat="server">
        </asp:CheckBoxList>
    </form>
</body>
</html>
