<%@ Page Language="C#" AutoEventWireup="true" CodeFile="documentacionAsociada.aspx.cs" Inherits="views_documentacionAsociada" %>

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
    
    
    <title></title>
    
</head>
<body>
<form id="form1" runat="server">
    
<!-- #INCLUDE FILE="menu.aspx" --> 

<div class="div1">
<div class="div2">
<br />
<span class="destacado1"> * </span><span style="font-size:12px; color: #333;">Información Obligatoria.</span>
<h1>DOCUMENTACION ASOCIADA</h1>
<legend>Información conjunto</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
        <tr>
            <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
                <asp:TextBox ID="text_codigo_conjunto" runat="server" Enabled="false"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
                <asp:TextBox ID="text_nombre_conjunto" runat="server" Enabled="false"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Etapa:<br/>
                <asp:TextBox ID="text_etapa" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
    </table>
    
<legend>Datos Generales</legend>
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
	        <asp:TextBox ID="text_descripcion" runat="server" class="input-xlarge"></asp:TextBox>
	        <asp:Label ID="errorDescripcionDocumento" runat="server" Text="Falta completar la descripcion del documento!!" Visible="False"></asp:Label>
	        <br />
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td align="left" valign="middle" >Seleccion de archivo:<br />
            <asp:FileUpload id="file_archivoUpload" runat="server" class="btn" Height="40px" Width="308px" />
            <asp:Label ID="errorArchvio" runat="server" Text="Falta seleccionar el archivo para cargar!!" Visible="False"></asp:Label>
            
        </td>
    </tr>
</table>    

<br/>
    <asp:Button ID="btn_grabar_docAsociada" runat="server" Text="Grabar Registro" class="btn btn-large btn-success" onclick="btn_grabar_docAsociada_Click" />
    <asp:Button ID="btn_limpiar_docAsociada" runat="server" Text="Limpiar Formulario" class="btn btn-large btn-warning" />
    <br/>
    <span class="destacado1"> * </span><span style="font-size:12px; color: #333;">Información Obligatoria.</span>
<br/>
<br/>    
<br/>
    
</div>
</div>


<!-- #INCLUDE FILE="piePagina.aspx" --> 
    
    
</form>
</body>
</html>




