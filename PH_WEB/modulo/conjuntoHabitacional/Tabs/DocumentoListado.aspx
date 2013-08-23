<%@ Page Language="C#" MasterPageFile="~/modulo/conjuntoHabitacional/Tabs/MarcoTab.master" AutoEventWireup="true" CodeFile="DocumentoListado.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_DocumentoListado" %>
<asp:Content ID="content" ContentPlaceHolderID="bodyTabContent" Runat="Server"> 
<form id="formPrincipal" runat="server">
<legend>Información Conjunto Habitacional</legend>
<table border="1" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
            <span class="destacado1"></span><asp:TextBox ID="text_codigo_conjunto" runat="server" CssClass="form-control input-small" disabled></asp:TextBox>
        </td>
        <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
	        <span class="destacado1"></span><asp:TextBox ID="text_nombre_conjunto" runat="server" disabled></asp:TextBox>
        </td>
        <td align="left" valign="middle">Etapa:<br/>
	        <asp:TextBox ID="text_etapa" runat="server" disabled></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="errorConjuntoHabitacional" runat="server" Text="Falta completar algún campo requerido!!" Visible="False"></asp:Label>
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
        <table class="table table-striped" id="tabla" runat="server">
            <tr>
                <th>#</th>
                <th>Folio</th>
                <th>Nombre</th>
                <th>Fecha ingreso</th>
                <th>Fecha Vencimiento</th>
                <th>Acciones</th>
                </tr>
            <tbody>
                <tr>
                    <td>1</td><td>SE55031</td><td>Permiso de Edificación</td><td>15-04-2013</td><td>07-07-2014</td><td><button class="btn btn-mini btn-info" type="button">Ver archivo</button>&nbsp;&nbsp;<button class="btn btn-mini btn-info" type="button">Visualizar</button>&nbsp;&nbsp;<button class="btn btn-mini btn-danger" type="button">Eliminar</button></td>
                </tr>
                <tr>
                    <td>2</td><td>DFG44555</td><td>Certificado de Avaluó Fiscal</td><td>23-04-2013</td><td>07-07-2014</td><td><button class="btn btn-mini btn-info" type="button">Ver archivo</button>&nbsp;&nbsp;<button class="btn btn-mini btn-info" type="button">Visualizar</button>&nbsp;&nbsp;<button class="btn btn-mini btn-danger" type="button">Eliminar</button></td>
                </tr>
                <tr>
                    <td>3</td><td>WLH5678</td><td>Certificado de Tesorería</td><td>02-05-2013</td><td>07-07-2014</td><td><button class="btn btn-mini btn-info" type="button">Ver archivo</button>&nbsp;&nbsp;<button class="btn btn-mini btn-info" type="button">Visualizar</button>&nbsp;&nbsp;<button class="btn btn-mini btn-danger" type="button">Eliminar</button></td>
                </tr>
            </tbody>
        </table>
        <div class="pagination" id="paginador" runat="server">
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
</asp:Content>