<%@ Page Language="C#" MasterPageFile="~/modulo/conjuntoHabitacional/Tabs/MarcoTab.master" AutoEventWireup="true" CodeFile="Seguimiento.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_Seguimiento" %>
<asp:Content ID="content" ContentPlaceHolderID="bodyTabContent" Runat="Server"> 
<script language="javascript">
$( document ).ready(function() {
var altura = document.getElementById("contenidoFull").offsetHeight;
parent.document.getElementById("frameSeguimiento").height = altura;
});
</script>
<form id="formPrincipal" runat="server">
<div id="contenidoFull" style="height:100%">
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
        
       <br/>
       <legend>Ingreso de Comentarios</legend>
       <table>            
            <tr>
                <td align="left" valign="middle" colspan="4"><br/></td>
            </tr>
            <tr>
                <td valign="top">Comentario:</td>
                <td valign="top">&nbsp</td>
                <td colspan="2"><textarea rows="5" class="input-xxlarge" runat="server" id="txtComentario"></textarea></td>
            </tr>
            <tr align="right"><td colspan="3">
            <asp:Button CssClass="btn btn-primary" Text="Ingresar Comentario" runat="server" 
                    ID="btnComentario" onclick="btnComentario_Click" />
            </td></tr>
        </table>
        
        <legend>Listado de comentarios</legend>
        <table class="table table-striped" runat="server" id="tablaSeguimiento">
            <tr><td><button type="submit" class="btn">Actualizar</button></td></tr>
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
        
 </div>
</form>
</asp:Content>