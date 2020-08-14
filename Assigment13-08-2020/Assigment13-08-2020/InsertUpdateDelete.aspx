<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertUpdateDelete.aspx.cs" Inherits="Assigment13_08_2020.InsertUpdateDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            Emp Id: <asp:TextBox ID="txtempid" runat="server"></asp:TextBox>
            <br />
            Emp Name:
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <br />
            Emp Salary:
            <asp:TextBox ID="txtsal" runat="server"></asp:TextBox>
            <br />
            Emp Gender:
            <asp:TextBox ID="txtgender" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="srhname" runat="server" OnClick="srhname_Click" Text="Search By name" />
            <asp:Button ID="srhid" runat="server" Text="Search by Id" OnClick="srhid_Click" />
            <br />
            <br />
            <asp:Button ID="btninsrtqt" runat="server" Text="Insert qutation" OnClick="btninsrtqt_Click" />
            <asp:Button ID="btninsrtpar" runat="server" Text="Insert Parameter" OnClick="btninsrtpar_Click" />
            <asp:Button ID="btninsrtproc" runat="server" Text="Insert Prosedure" OnClick="btninsrtproc_Click" />
            <br />
            Update By Id: <asp:TextBox ID="txtupdate" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnupqua" runat="server" Text="Update Qutation" OnClick="btnupqua_Click" />
            <asp:Button ID="btnuppar" runat="server" Text="Update Parameter" OnClick="btnuppar_Click" />
            <asp:Button ID="btnuppro" runat="server" Text="Update Procedure" OnClick="btnuppro_Click" />
            <br />
            For Delete:<asp:TextBox ID="txtdel" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btndelproc" runat="server" Text="DeleteById Proc" OnClick="btndelproc_Click" />
            <asp:Button ID="btndelpar" runat="server" Text="DeleteByName Para" OnClick="btndelpar_Click" />
            <asp:Button ID="btndelqua" runat="server" Text="DeleteById Qua" OnClick="btndelqua_Click" />
        </div>
    </form>
</body>
</html>
