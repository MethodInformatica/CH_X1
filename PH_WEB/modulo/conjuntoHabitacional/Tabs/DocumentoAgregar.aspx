<%@ Page UICulture="es" Culture="es-cl" Language="C#" MasterPageFile="~/modulo/conjuntoHabitacional/Tabs/MarcoTab.master" AutoEventWireup="true" CodeFile="DocumentoAgregar.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_DocumentoAgregar" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="content" ContentPlaceHolderID="bodyTabContent" Runat="Server"> 
<script language="javascript">
    $(document).ready(function() {
        var altura = document.getElementById("contenidoFull").offsetHeight;
        parent.document.getElementById("frameDocumentos").height = altura;
    });
</script>
<div id="contenidoFull" style="height:100%;width:100%;">
<form id="formPrincipal" runat="server" >
<ajaxToolkit:ToolkitScriptManager runat="Server" EnableScriptGlobalization="true"
        EnableScriptLocalization="true" ID="ScriptManager1" ScriptMode="Debug" CombineScripts="false" />
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
<p class="separador"></p> 
    
<legend>Agregar Nuevo Documento</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Folio Documento:<br/>
            <span class="destacado1">*</span><asp:TextBox ID="txtFolioDocumento" runat="server" class="input-xlarge"></asp:TextBox>
            <asp:Label ID="errorFolioDocumento" runat="server" Text="Falta completar el folio del documento!!" Visible="False"></asp:Label>
            <br />
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td align="left" valign="middle">Nombre Documento:<br/>
	        <span class="destacado1">*</span><asp:TextBox ID="txtNombreDocumento" runat="server" class="input-xlarge"></asp:TextBox>
	        <asp:Label ID="errorNombreDocumento" runat="server" Text="Falta completar el nombre del documento!!" Visible="False"></asp:Label>
	        <br />
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td align="left" valign="middle">Fecha Documento ( dd-mm-aaaa):<br/>
	        <asp:TextBox ID="txtFechaDocumento" runat="server" CssClass="form-control input-small"></asp:TextBox>
	        <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFechaDocumento"
           CssClass="MyCalendar" Format="dd-MM-yyyy" PopupPosition="TopLeft" 
                TodaysDateFormat="dd-MM-yyyy" DaysModeTitleFormat="MMM-yyyy "/>
	        <br />
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td align="left" valign="middle">Fecha Vencimiento ( dd-mm-aaaa):<br/>
	        <asp:TextBox ID="txtFechaVencimiento" runat="server" CssClass="form-control input-small"></asp:TextBox>
	        <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtFechaVencimiento"
           CssClass="MyCalendar" Format="dd-MM-yyyy" PopupPosition="TopLeft" 
                TodaysDateFormat="dd-MM-yyyy" DaysModeTitleFormat="MMM-yyyy "/>
	        <br />
        </td>
   </tr>
   <tr><td>&nbsp;</td></tr>
   <tr>
        <td align="left" valign="middle">Descripción:<br/>
	        <textarea ID="txtDescripcion" runat="server" class="input-xlarge"></textarea>
	        <asp:Label ID="errorDescripcionDocumento" runat="server" Text="Falta completar la descripcion del documento!!" Visible="False"></asp:Label>
	        <br />
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td align="leff"> Selección de archivo:<br />
        <asp:FileUpload runat="server" ID="fileArchivo" />
        </td>
    </tr>
</table>    

<br/>
    <asp:Button ID="btn_grabar_docAsociada"  runat="server" Text="Guardar" class="btn btn-large btn-success" onclick="btn_grabar_docAsociada_Click" />
    <asp:Button ID="btn_limpiar_docAsociada" runat="server" Text="Limpiar Formulario" class="btn btn-large btn-warning" />
    <br/>
    <div class="alert alert-block">
<button type="button" class="close" data-dismiss="alert">&times;</button>
<span class="destacado1"> * </span>Información Obligatoria.
</div>
</form>
</div>
</asp:Content>