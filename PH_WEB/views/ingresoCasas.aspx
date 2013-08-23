<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ingresoCasas.aspx.cs" Inherits="views_ingresoCasas" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

    <link href="../css/bootstrap/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../css/bootstrap/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../css/estilos.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.9.1.js" type="text/javascript"></script>
    <script src="../js/jquery-ui-1.10.3.custom.js" type="text/javascript"></script>
    <script src="../js/jquery-ui-1.10.3.custom.min.js" type="text/javascript"></script>
    <script src="../js/jqueryslidemenu.js" type="text/javascript"></script>
    <script src="../js/bootstrap/bootstrap.js" type="text/javascript"></script>
    <script src="../js/bootstrap/bootstrap.min.js" type="text/javascript"></script>
       
    <title>Formulario Ingreso Casas</title>
    
</head>

<body>
<form id="formIngresoCasas" runat="server">

    <!-- #INCLUDE FILE="menu.aspx" --> 
    <div class="div1">
    <div class="div2">
    <br />
    <span class="destacado1"> * </span><span style="font-size:12px; color: #333;">Información Obligatoria.</span>
    <h1>INGRESO DE CASAS</h1>
    <legend>Información conjunto</legend>
        <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;" width="100%">
            <tr>
                <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
                    <asp:TextBox ID="text_codConjunto" runat="server" ReadOnly="true" Width="100"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
                    <asp:TextBox ID="text_nombreConjunto" runat="server" ReadOnly="true" Width="100"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Etapa:<br/>
                    <asp:TextBox ID="text_etapa" runat="server" ReadOnly="true" Width="100"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Código Producto:<br/>
                    <asp:TextBox ID="text_codProducto" runat="server" ReadOnly="true" Width="100"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Tipo Producto:<br/>
	                <asp:TextBox ID="text_tipoProducto" runat="server" ReadOnly="true" Width="100"></asp:TextBox>
                </td>
                <td></td>
            </tr>
        </table>

    <legend>Antecedentes de la casa</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
        <tr>
            <td align="left" valign="middle">Manzana:<br/>
                <asp:TextBox ID="text_manzana" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Sitio:<br/>
	            <asp:TextBox ID="text_sitio" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Casa Esquina:<br/>
	            <asp:TextBox ID="text_casaEsquina" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Modelo:<br/>
	            <asp:TextBox ID="text_modelo" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>

    <legend>Datos gnerales</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
        <tr>
            <td align="left" valign="middle">Característica:<br/>
                <asp:TextBox ID="text_caracteristica" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Deslindes:<br/>
	            <asp:TextBox ID="text_deslindes" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Orientación:<br/>
	            <asp:DropDownList ID="drop_orientacion" runat="server" class="input-medium">
	                <asp:ListItem Value="Comuna"></asp:ListItem>
	            </asp:DropDownList>
            </td>
            <td align="left" valign="middle">Dirección:<br/>
	            <asp:TextBox ID="text_direccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr><td colspan="4">&nbsp</td></tr>
        <tr>
            <td align="left" valign="middle">Total Mts2 Construido (EJ: 70,43):<br/>
                <asp:TextBox ID="text_mConstruido" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Total Mts2 Terreno (Ej: 100,23):<br/>
                <asp:TextBox ID="text_mTerreno" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Dirección Comunal:<br/>
                <asp:TextBox ID="text_direccionComunal" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Rol SII:<br/>
                <asp:TextBox ID="text_rolSII" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>

    <legend>Valores</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
        <tr>
            <td align="left" valign="middle">Valor (UF):<br/>
                <asp:TextBox ID="text_valorUF" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Descuento (%):<br/>
	            <asp:TextBox ID="text_descuento" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Valor Final (UF):<br/>
	            <asp:TextBox ID="text_valorFinalUF" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Gasto Operacional (UF):<br/>
	            <asp:TextBox ID="text_gastoOperacional" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>

    <legend>Cliente</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
        <tr>
            <td align="left" valign="middle">Rut:<br/>
                <asp:TextBox ID="text_rutCliente" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Nombre:<br/>
	            <asp:TextBox ID="text_nombreCliente" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">E-mail:<br/>
	            <asp:TextBox ID="text_emailCliente" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Teléfono :<br/>
	            <asp:TextBox ID="text_telefonoCliente" runat="server" Width="20"></asp:TextBox><asp:TextBox ID="TextBox30" runat="server" Width="100"></asp:TextBox>
            </td>
        </tr>
    </table>

    <legend>Compromiso reserva / Carta Oferta</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
        <tr>
            <td align="left" valign="middle">N° Reserva:<br/>
                <asp:TextBox ID="text_nReserva" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Fecha Reserva:<br/>
	            <asp:TextBox ID="text_fechaReserva" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">N° Carta Oferta:<br/>
	            <asp:TextBox ID="text_numeroCartaOferta" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Fecha Carta Oferta :<br/>
	            <asp:TextBox ID="text_fechaCartaOferta" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>

    <legend>Información interna</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
        <tr>
            <td align="left" valign="middle">Ejecutivo de Venta:<br/>
                <asp:TextBox ID="text_ejecutivoVenta" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Fecha Venta:<br/>
	            <asp:TextBox ID="text_fechaVenta" runat="server"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Código Proyecto Proviene Cliente:<br/>
	            <asp:TextBox ID="text_codigoProyecto" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <p class="separador"></p>  
    <br/>

        <asp:Button ID="btn_grabar" runat="server" Text="Grabar Registro" 
                    class="btn btn-large btn-success" onclick="btn_grabar_Click" />
        <asp:Button ID="btn_limpiar" runat="server" Text="Limpiar Formulario" class="btn btn-large btn-warning" />
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