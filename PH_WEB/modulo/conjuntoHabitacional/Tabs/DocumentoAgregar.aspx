<%@ Page Language="C#" MasterPageFile="~/modulo/conjuntoHabitacional/Tabs/MarcoTab.master" AutoEventWireup="true" CodeFile="DocumentoAgregar.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_DocumentoAgregar" %>
<asp:Content ID="content" ContentPlaceHolderID="bodyTabContent" Runat="Server"> 
<form id="formPrincipal" runat="server" >
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
<p class="separador"></p> 
    
<legend>Agregar Nuevo Documento</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Folio Documento:<br/>
            <asp:TextBox ID="tetx_folio_documento" runat="server" class="input-xlarge"></asp:TextBox>
            <asp:Label ID="errorFolioDocumento" runat="server" Text="Falta completar el folio del documento!!" Visible="False"></asp:Label>
            <br />
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td align="left" valign="middle">Nombre Documento:<br/>
	        <asp:TextBox ID="tetx_nombre_documento" runat="server" class="input-xlarge"></asp:TextBox>
	        <asp:Label ID="errorNombreDocumento" runat="server" Text="Falta completar el nombre del documento!!" Visible="False"></asp:Label>
	        <br />
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td align="left" valign="middle">Fecha Documento ( dd-mm-aaaa):<br/>
	        <asp:TextBox ID="text_fecha_documento" runat="server" class="input-xlarge"></asp:TextBox>
	        <asp:Label ID="errorFechaDocumento" runat="server" Text="Falta completar la fecha del documento!!" Visible="False"></asp:Label>
	        <br />
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td align="left" valign="middle">Fecha Vencimiento ( dd-mm-aaaa):<br/>
	        <asp:TextBox ID="text_fecha_vencimiento" runat="server" class="input-xlarge"></asp:TextBox>
	        <asp:Label ID="errorVencimientoDocumento" runat="server" Text="Falta completar la fecha vencimiento del documento!!" Visible="False"></asp:Label>
	        <br />
        </td>
   </tr>
   <tr><td>&nbsp;</td></tr>
   <tr>
        <td align="left" valign="middle">Descripción:<br/>
	        <textarea ID="text_descripcion" runat="server" class="input-xlarge"></textarea>
	        <asp:Label ID="errorDescripcionDocumento" runat="server" Text="Falta completar la descripcion del documento!!" Visible="False"></asp:Label>
	        <br />
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td align="leff"> Selección de archivo:<br />
        <input type="file" id="archivo" name="archivo"  />
            
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
</asp:Content>