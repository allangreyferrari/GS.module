<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="GS.Helpdesk.services.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="TestList" runat="server" Text="Listar" OnClick="TestList_Click" />
        <asp:Button ID="TestInsert" runat="server" Text="Insertar" OnClick="TestInsert_Click" />
        <asp:Button ID="TestEdit" runat="server" Text="Editar" />
        <br />
        <asp:Button ID="Test2List" runat="server" Text="Listar" OnClick="Test2List_Click" />
        <asp:Button ID="Test2RangoFecha" runat="server" Text="Rango de Fechas" OnClick="Test2RangoFecha_Click" />
    </div>
    </form>
</body>
</html>
