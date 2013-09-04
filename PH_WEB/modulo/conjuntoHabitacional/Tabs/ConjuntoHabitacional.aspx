<%@ Page UICulture="es" Culture="es-cl" Language="C#"  MasterPageFile="~/modulo/conjuntoHabitacional/Tabs/MarcoTab.master" AutoEventWireup="true" CodeFile="ConjuntoHabitacional.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_ConjuntoHabitacional" MaintainScrollPositionOnPostback="true"%>
  <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="content" ContentPlaceHolderID="bodyTabContent" Runat="Server">
<script language="javascript">
    $(document).ready(function() {
        var altura = document.getElementById("contenidoFull").offsetHeight;
        parent.document.getElementById("frameConjunto").height = altura;
    });
</script>
<div id="contenidoFull" style="height:100%;width:100%;">
<form id="formPrincipal" runat="server">
<ajaxToolkit:ToolkitScriptManager runat="Server" EnableScriptGlobalization="true"
        EnableScriptLocalization="true" ID="ScriptManager1" ScriptMode="Debug" CombineScripts="false" />
<div class="alert alert-block">
<button type="button" class="close" data-dismiss="alert">&times;</button>
<span class="destacado1" runat="server" id="lblEstrella"> * </span>Información Obligatoria.
</div>

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

<legend>Dirección del Conjunto Habitacional</legend>
<table border="1" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td align="left" valign="middle">Región:<br/>
            <span class="destacado1">*</span><asp:DropDownList ID="ddlRegionConjunto" 
                runat="server" class="input-xlarge" 
                onselectedindexchanged="ddlRegionConjunto_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Value="0">Seleccione</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td align="left" valign="middle">Ciudad:<br/>
	        <span class="destacado1">*</span><asp:DropDownList ID="ddlCiudadConjunto" 
                runat="server" class="input-medium" 
                onselectedindexchanged="ddlCiudadConjunto_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Value="0">Seleccione</asp:ListItem>
	        </asp:DropDownList>
        </td>
        <td align="left" valign="middle">Comuna:<br/>
	        <span class="destacado1">*</span><asp:DropDownList ID="ddlComuna" runat="server" 
	        class="input-medium">
	        <asp:ListItem Value="0">Seleccione</asp:ListItem>
	        </asp:DropDownList>
        </td>
        <tr>
        <td colspan="3" align="left" valign="middle">Dirección:<br/>	    
	        <span class="destacado1">*</span>
	        <asp:TextBox ID="txtDireccionConjunto" runat="server" MaxLength="50" CssClass="form-control input-lg" />
	    </td>
        </tr>
    </tr>
    <tr>
        <td colspan="4">
            <asp:Label ID="errorDireccionConjuntoHabitacional" runat="server" Text="Falta completar algún campo requerido!!" Visible="False"></asp:Label>
        </td>
    </tr>
</table>
<p class="separador"></p>

<legend>Antecedentes Empresa Constructora</legend>
<table border="1" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td align="left" valign="middle">Rut (12345678-k):<br/>
            <asp:TextBox ID="txtRutConstructora" runat="server" MaxLength="10" CssClass="form-control input-small"></asp:TextBox>
            
        </td>
        <td align="left" valign="middle">Nombre o Razón Social:<br/>
	        <asp:TextBox ID="txtNombreConstructora" runat="server" MaxLength="30"></asp:TextBox>
        </td>
    </tr>
</table>
<p class="separador"></p>    

<legend>Antecedentes Empresa Vendedora</legend>
<table border="1" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td align="left" valign="middle">Rut (12345678-k):<br/>
            <asp:TextBox ID="txtRutVendedora" runat="server" MaxLength="10" CssClass="form-control input-small"></asp:TextBox>
            
        </td>
        <td align="left" valign="middle">Nombre o Razón Social:<br/>
	        <asp:TextBox ID="txtNombreVendedora" runat="server" MaxLength="30"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Nombre Representante:<br/>
	        <asp:TextBox ID="txtNombreRepresentateVendedora" runat="server" MaxLength="30"></asp:TextBox>
        </td>
    </tr>
    <tr>
         <td align="left" valign="middle">Región:<br/>
                <asp:DropDownList ID="ddlRegionVendedora" runat="server" 
                class="input-xlarge" 
                onselectedindexchanged="ddlRegionVendedora_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Value="0">Seleccione</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td align="left" valign="middle">Ciudad:<br/>
	            <asp:DropDownList ID="ddlCiudadVendedora" runat="server" 
                class="input-medium" 
                onselectedindexchanged="ddlCiudadVendedora_SelectedIndexChanged" AutoPostBack="true">
	            <asp:ListItem Value="0">Seleccione</asp:ListItem>
	        </asp:DropDownList>
        </td>
        <td align="left" valign="middle">Comuna:<br/>
	            <asp:DropDownList ID="ddlComunaVendedora" runat="server" class="input-medium">
	            <asp:ListItem Value="0">Seleccione</asp:ListItem>
	        </asp:DropDownList>
        </td>      
    </tr>
    <tr> <td align="left" valign="middle" colspan="3">Dirección:<br/>
	            <span class="destacado1"></span><asp:TextBox ID="txtDireccionVendedora" MaxLength="50" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="left" valign="middle">Teléfono:<br/>
            <asp:TextBox ID="txtCodigoFonoVendedora" runat="server" Width="20" MaxLength="2"></asp:TextBox>
             - 
             <asp:TextBox ID="txtFonoVendedora" runat="server" Width="100" MaxLength="7"></asp:TextBox>
             <ajaxToolkit:FilteredTextBoxExtender
           ID="FilteredTextBoxExtender1"
           runat="server"
           TargetControlID="txtCodigoFonoVendedora"
           FilterType="Numbers" />
           <ajaxToolkit:FilteredTextBoxExtender
           ID="FilteredTextBoxExtender2"
           runat="server"
           TargetControlID="txtFonoVendedora"
           FilterType="Numbers" />
        </td>
        <td align="left" valign="middle">E-mail:<br/>
            <asp:TextBox ID="txtMailVendedora" runat="server" MaxLength="30"></asp:TextBox>
        </td>
        <td align="left" valign="middle">&nbsp;</td>
    </tr>
</table>
<p class="separador"></p>    

<legend>Información de fechas (dd-mm-aaaa)</legend>
<table border="1" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td align="left" valign="middle">Fecha Contrato:<br/>
            <asp:TextBox runat="server" ID="txtFechaContrato" MaxLength="10" CssClass="form-control input-small"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="customCalendarExtender" runat="server" TargetControlID="txtFechaContrato"
           CssClass="MyCalendar" Format="dd-MM-yyyy" PopupPosition="TopLeft" 
                TodaysDateFormat="dd-MM-yyyy" DaysModeTitleFormat="MMM-yyyy "/>
        </td>
        <td align="left" valign="middle">Fecha Termino Construcción:<br/>
            <asp:TextBox runat="server" ID="txtFechaTermino" MaxLength="10" CssClass="form-control input-small"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFechaTermino"
           CssClass="MyCalendar" Format="dd-MM-yyyy" PopupPosition="TopLeft" 
                TodaysDateFormat="dd-MM-yyyy" DaysModeTitleFormat="MMM-yyyy "/>
        </td>
        <td align="left" valign="middle">Fecha Recepción Municipal:<br/>
            <asp:TextBox runat="server" ID="txtFechaRecepcionMunicipal" MaxLength="10" CssClass="form-control input-small"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtFechaRecepcionMunicipal"
           CssClass="MyCalendar" Format="dd-MM-yyyy" PopupPosition="TopLeft" 
                TodaysDateFormat="dd-MM-yyyy" DaysModeTitleFormat="MMM-yyyy "/>
                </td>
       <td align="left" valign="middle">Fecha Recepción Prohogar:<br/>          
            <asp:TextBox runat="server" ID="txtFechaRecepcionProHogar" MaxLength="10" CssClass="form-control input-small"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="txtFechaRecepcionProHogar"
           CssClass="MyCalendar" Format="dd-MM-yyyy" PopupPosition="TopLeft" 
                TodaysDateFormat="dd-MM-yyyy" DaysModeTitleFormat="MMM-yyyy "/>
        </td>
    </tr>
    </table>
<p class="separador"></p>    
<br/>

    <asp:Button ID="btnGrabar" runat="server" Text="Guardar" 
            class="btn btn-large btn-success" onclick="btnGrabar_Click"/>
    <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar Formulario" 
                class="btn btn-large btn-warning" onclick="btnLimpiar_Click" />
    <br/>
    <div class="alert alert-block">
<button type="button" class="close" data-dismiss="alert">&times;</button>
<span class="destacado1" runat="server" id="Span1"> * </span>Información Obligatoria.
</div>
</form>
</div>
</asp:Content>