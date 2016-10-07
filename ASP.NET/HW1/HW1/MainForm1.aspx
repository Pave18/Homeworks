<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm1.aspx.cs" Inherits="HW1.MainForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBoxPoducts" SelectionMode="Multiple" runat="server"></asp:ListBox>
            <asp:Button ID="ButtonAddBasket" runat="server" Text="Add Basket" OnClick="ButtonAddBasket_Click"  />
            <asp:Button ID="ButtonAllAddBasket" runat="server" Text="All Add Basket" OnClick="ButtonAllAddBasket_Click" />
        </div>
        <div>
            <asp:ListBox ID="ListBoxBasket" SelectionMode="Multiple" runat="server"></asp:ListBox>
            <asp:Button ID="ButtonOutBasket" runat="server" Text="Out Basket" OnClick="ButtonOutBasket_Click" />
            <asp:Button ID="ButtonAllOutBasket" runat="server" Text="All Out Basket" OnClick="ButtonAllOutBasket_Click" />
        </div>
    </form>
</body>
</html>
