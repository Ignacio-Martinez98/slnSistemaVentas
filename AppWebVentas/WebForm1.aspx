<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AppWebVentas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:Label ID="lblId" runat="server" Text="Id:"></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <asp:Button ID="btnTraerPorID" runat="server" OnClick="btnTraerPorID_Click" Text="Traer por ID" />
        </div>
        <p>
            <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <asp:Button ID="btnTraerTodos" runat="server" OnClick="btnTraerTodos_Click" Text="TraerTodos" />
        </p>
        <asp:Label ID="lblDni" runat="server" Text="Dni:"></asp:Label>
        <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblComision" runat="server" Text="Comision:"></asp:Label>
            <asp:TextBox ID="txtComision" runat="server"></asp:TextBox>
            <asp:Button ID="btnTraerPorComision" runat="server" OnClick="btnTraerPorComision_Click" Text="Traer por comision" />
        </p>
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
        <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" />
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
        <asp:GridView ID="gridVendedores" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
