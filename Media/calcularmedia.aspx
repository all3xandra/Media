<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calcularmedia.aspx.cs" Inherits="Media.calcularmedia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Selecciona una asignatura:"></asp:Label>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <br />
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HADS22-07ConnectionString %>" SelectCommand="SELECT [codigo] FROM [Asignatura]"></asp:SqlDataSource>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Calcular media" />
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
