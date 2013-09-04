<%@ Page Language="C#" MasterPageFile="~/modulo/conjuntoHabitacional/Tabs/MarcoTab.master" AutoEventWireup="true" CodeFile="DocumentoListado.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_DocumentoListado" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="content" ContentPlaceHolderID="bodyTabContent" Runat="Server"> 

    <script language="javascript">
    $(document).ready(function() {
        var altura = document.getElementById("contenidoFull").offsetHeight;
        parent.document.getElementById("frameDocumentos").height = altura;
    });
</script>
<div id="contenidoFull" style="height:100%;width:100%;">
<form id="formPrincipal" runat="server">
<ajaxToolkit:ToolkitScriptManager runat="Server" EnableScriptGlobalization="true"
        EnableScriptLocalization="true" ID="ScriptManager1" ScriptMode="Debug" CombineScripts="false" />
<script>
    function confirmarEliminarDoc(ic,ie,key) {
        if (confirm("Esta seguro de eliminar el Documento '" + ic + "'?")) {
            window.open("DocumentoListado.aspx?key=" + key + "&ic=" + ie, "_self");
        }
    }
    function visualizarDoc(path) {
        window.open(path, "_blank");
    }
    function modificarDoc(ie, key) {
        window.open("DocumentoEditar.aspx?key=" + key + "&ic=" + ie, "_self");
    }
</script>
<legend>Información Conjunto Habitacional</legend>
<table border="1" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
            <span class="destacado1"></span><asp:TextBox ID="txtCodigoConjunto" runat="server" CssClass="form-control input-small" disabled></asp:TextBox>
        </td>
        <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
	        <span class="destacado1"></span><asp:TextBox ID="txtNombreConjunto" runat="server" disabled></asp:TextBox>
        </td>
        <td align="left" valign="middle">Etapa:<br/>
	        <asp:TextBox ID="txtEtapa" runat="server" disabled></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="errorConjuntoHabitacional" runat="server" Text="Falta completar algún campo requerido!!" Visible="False"></asp:Label>
        </td>
    </tr>
</table>
<br />
<legend>Criterios de búsqueda</legend>
<table border="1" cellpadding="0" cellspacing="0" width="85%">
    <tr>
        <td align="left" valign="middle">Folio Documento:<br/>
            <asp:TextBox ID="txtFolio" runat="server" CssClass="form-control input-small"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Nombre Documento:<br/>
	        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Fecha Documento:<br/>
            <asp:TextBox ID="txtFechaDocumento" runat="server" CssClass="form-control input-small"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFechaDocumento"
           CssClass="MyCalendar" Format="dd-MM-yyyy" PopupPosition="TopLeft" 
                TodaysDateFormat="dd-MM-yyyy" DaysModeTitleFormat="MMM-yyyy "/>
        </td>
         <td align="left" valign="middle">Fecha Vencimiento:<br/>
            <asp:TextBox ID="txtFechaVencimiento" runat="server" CssClass="form-control input-small"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtFechaVencimiento"
           CssClass="MyCalendar" Format="dd-MM-yyyy" PopupPosition="TopLeft" 
                TodaysDateFormat="dd-MM-yyyy" DaysModeTitleFormat="MMM-yyyy "/>
        </td>
        <td valign="middle">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary" 
                onclick="btnBuscar_Click" />          
        </td>
    </tr>
</table>
               
        <br/>
        <legend>
            Listado de documentación
            <span style="float:right; width: 30%; text-align:center";>
                <a class="btn btn-small" href="DocumentoAgregar.aspx">Ingresar Documento</a>
            </span>
        </legend>
        <table class="table table-striped" id="tablaDocumentos" runat="server">
            <tr>
                <th>#</th>
                <th>Folio</th>
                <th>Nombre</th>
                <th>Fecha Documento</th>
                <th>Fecha Vencimiento</th>
                <th>Acciones</th>
                </tr>
            <tbody>               
            </tbody>
        </table>
        <div class="pagination" id="paginador" runat="server" style="visibility:hidden">
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
        
</form>
</div>
</asp:Content>