﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Listado.aspx.cs" MasterPageFile="~/modulo/conjuntoHabitacional/MarcoModulo.master"Inherits="modulo_conjuntoHabitacional_Listado" %>

<asp:Content ID="content" ContentPlaceHolderID="contentBody" Runat="Server">

    <script>
    function ingresarCJ(ic,key) {
        window.open("Editar.aspx?key="+key+"&id="+ic,"_self");
    }
    function confirmarEliminarCJ(ic, key) {
        if (confirm("Está seguro de eliminar el Conjunto Habitacional '" + ic + "' y todo su contenido?")) {
            window.open("Listado.aspx?key=" + key + "&ic=" + ic, "_self");
        }
    }
</script>
<form id="formPrincipal" runat="server">
    <h1>MANTENEDOR CONJUNTOS HABITACIONALES</h1>
<br />
<legend>Criterios de búsqueda</legend>
<table border="1" cellpadding="0" cellspacing="0" width="85%">
    <tr>
        <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
	        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Región:<br/>
            <asp:DropDownList ID="ddlRegion" runat="server">
            <asp:ListItem Value="0">Seleccion</asp:ListItem>
        </asp:DropDownList>
        </td>
        <td valign="middle">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary" 
                onclick="btnBuscar_Click"/>          
        </td>
    </tr>
</table>
    
<br/>
<legend>Listado conjuntos habitacionales <span style="float:right;">
<asp:Button ID="btnAgregar" class="btn btn-success" runat="server" 
                    Text="Agregar Conjunto Habitacional" onclick="btnAgregar_Click" />
</span></legend>
    <table class="table table-striped" runat="server" id="tableConjuntos">
        <tr>
            <th>#</th><th>Código Conjunto Habitacional</th><th>Nombre Conjunto Habitacional</th><th>Región</th><th>Acciones</th>
        </tr>
        <tbody>           
        </tbody>
    </table>
    <div class="pagination" style="visibility:hidden">
        <ul>
            <li><a href="#">Anterior</a></li>
            <li><a href="#">1</a></li>
            <li><a href="#">2</a></li>
            <li><a href="#">3</a></li>
            <li><a href="#">4</a></li>
            <li><a href="#">5</a></li>
            <li><a href="#">Siguiente</a></li>
        </ul>
    </div>
<br/>    
<br/>
</form>
</asp:Content>