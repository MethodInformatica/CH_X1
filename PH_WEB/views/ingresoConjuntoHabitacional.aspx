<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ingresoConjuntoHabitacional.aspx.cs" Inherits="views_ingresoConjuntoHabitacional" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

	<link href="../css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="../css/smoothness/jquery-ui-1.10.3.custom.css" rel="stylesheet" type="text/css" />
    <link href="../css/themes/base/jquery.ui.all.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.9.1.js" type="text/javascript"></script>
    <script src="../js/jquery-ui-1.10.3.custom.js" type="text/javascript"></script>
    <script src="../js/jquery-ui-1.10.3.custom.min.js" type="text/javascript"></script>
    <script src="../js/jqueryslidemenu.js" type="text/javascript"></script>
    <script src="../js/bootstrap.js" type="text/javascript"></script>
    <script src="../js/bootstrap.min.js" type="text/javascript"></script>
    <script src="../js/ui/jquery.ui.core.js" type="text/javascript"></script>
	<script src="../js/ui/jquery.ui.datepicker.js" type="text/javascript"></script>  
    
    <script type="text/javascript">
        jQuery(function($) {
            $.datepicker.regional['es'] = {
                changeYear: true,
                changeMonth: true,
                monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
                monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
                dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
                dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mié', 'Juv', 'Vie', 'Sáb'],
                dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sa'],
                dateFormat: 'dd-mm-yy'
            };
            $.datepicker.setDefaults($.datepicker.regional['es']);
        }); 
        $(function() {
            $("#text_fecha_contrato").datepicker();
            $("#text_fecha_termino_construccion").datepicker();
            $("#text_fecha_recepcion_municipal").datepicker();
            $("#text_fecha_recepcion_prohogar").datepicker();    
        });
	</script>
       
    <title>Ingreso Conjunto Habitacional</title>
    
</head>
<body>
<form id="form1" runat="server">
    
<!-- #INCLUDE FILE="menu.aspx" --> 
<div class="div1">
<div class="div2">
<br />
<span class="destacado1"> * </span><span style="font-size:12px; color: #333;">Información Obligatoria.</span>
<h1>INGRESO CONJUNTO HABITACIONAL</h1>

<legend>Conjuto Habitacional</legend>
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
            <span class="destacado1">*</span><asp:TextBox ID="text_codigo_conjunto" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
	        <span class="destacado1">*</span><asp:TextBox ID="text_nombre_conjunto" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Etapa:<br/>
	        <asp:TextBox ID="text_etapa" runat="server"></asp:TextBox>
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
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Región:<br/>
            <span class="destacado1">*</span><asp:DropDownList ID="drop_region" runat="server" class="input-medium">
                <asp:ListItem Value="0">Región</asp:ListItem>
                <asp:ListItem Value="1">1</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td align="left" valign="middle">Ciudad:<br/>
	        <span class="destacado1">*</span><asp:DropDownList ID="drop_ciudad" runat="server" class="input-medium">
	            <asp:ListItem Value="0">Ciudad</asp:ListItem>
	            <asp:ListItem Value="1">1</asp:ListItem>
	        </asp:DropDownList>
        </td>
        <td align="left" valign="middle">Comuna:<br/>
	        <span class="destacado1">*</span><asp:DropDownList ID="drop_id_comuna_conjunto" runat="server" class="input-medium">
	            <asp:ListItem Value="0">Comuna</asp:ListItem>
	            <asp:ListItem Value="1">1</asp:ListItem>
	        </asp:DropDownList>
        </td>
        <td align="left" valign="middle">Dirección:<br/>
	        <span class="destacado1">*</span><asp:TextBox ID="text_direccion_conjunto" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:Label ID="errorDireccionConjuntoHabitacional" runat="server" Text="Falta completar algún campo requerido!!" Visible="False"></asp:Label>
        </td>
    </tr>
</table>
<p class="separador"></p>

<legend>Antecedentes Empresa Constructora</legend>
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Rut (12345678-k):<br/>
            <asp:TextBox ID="text_rut_constructora" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Nombre o Razón Social:<br/>
	        <asp:TextBox ID="text_nombre_constructora" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<p class="separador"></p>    

<legend>Antecedentes Empresa Vendedora</legend>
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Rut (12345678-k):<br/>
            <asp:TextBox ID="text_rut_empresa_vendedora" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Nombre o Razón Social:<br/>
	        <asp:TextBox ID="text_nombre_empresa_vendedora" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Nombre Representante:<br/>
	        <asp:TextBox ID="text_nombre_representante" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr><td colspan="4">&nbsp;</td></tr>
    <tr>
        <td align="left" valign="middle">Región:<br/>
                <asp:DropDownList ID="drop_id_region_EV" runat="server" class="input-medium">
                <asp:ListItem Value="0">Región</asp:ListItem>
                <asp:ListItem Value="1">1</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td align="left" valign="middle">Ciudad:<br/>
	            <asp:DropDownList ID="drop_id_ciudad_EV" runat="server" class="input-medium">
	            <asp:ListItem Value="0">Ciudad</asp:ListItem>
	            <asp:ListItem Value="1">1</asp:ListItem>
	        </asp:DropDownList>
        </td>
        <td align="left" valign="middle">Comuna:<br/>
	            <asp:DropDownList ID="drop_id_comuna_empresa_vendedora" runat="server" class="input-medium">
	            <asp:ListItem Value="0">Comuna</asp:ListItem>
	            <asp:ListItem Value="1">1</asp:ListItem>
	        </asp:DropDownList>
        </td>
        <td align="left" valign="middle">Dirección:<br/>
	            <span class="destacado1">*</span><asp:TextBox ID="text_direccion_empresa_vendedora" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr><td colspan="4">&nbsp;</td></tr>
    <tr>
        <td align="left" valign="middle">Teléfono:<br/>
            <asp:TextBox ID="text_area_empresa_vendedora" runat="server" Width="20"></asp:TextBox><asp:TextBox ID="text_telefono_empresa_vendedora" runat="server" Width="100"></asp:TextBox>
        </td>
        <td align="left" valign="middle">E-mail:<br/>
            <asp:TextBox ID="text_email_empresa_vendedora" runat="server"></asp:TextBox>
        </td>
        <td colspan="2" align="left" valign="middle">&nbsp;</td>
    </tr>
</table>
<p class="separador"></p>    

<legend>Información de fechas (dd-mm-aaaa)</legend>
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Fecha Contrato:<br/>
            <input type="text" ID="text_fecha_contrato" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
        <td align="left" valign="middle">Fecha Termino Construcción:<br/>
            <input type="text" ID="text_fecha_termino_construccion" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
        <td align="left" valign="middle">Fecha Recepción Municipal:<br/>
            <input type="text" ID="text_fecha_recepcion_municipal" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
        <td>Fecha Recepción Prohogar:<br/>          
            <input type="text" ID="text_fecha_recepcion_prohogar" runat="server">
        </td>
    </tr>
    </table>
<p class="separador"></p>    
<br/>

    <asp:Button ID="btn_grabar" runat="server" Text="Grabar Registro" class="btn btn-large btn-success" onclick="btn_grabar_Click" />
    <asp:Button ID="btn_limpiar" runat="server" Text="Limpiar Formulario" class="btn btn-large btn-warning" />
    <br/>
    <span class="destacado1"></span><span style="font-size:12px; color: #333;">Información Obligatoria.</span>
<br/>
<br/>    
<br/>
    
</div>
</div>

<!-- #INCLUDE FILE="piePagina.aspx" --> 

</form>
    
    
</body>
</html>
