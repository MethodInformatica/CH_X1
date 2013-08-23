<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ingresoDepartamentos.aspx.cs" Inherits="views_ingresoDepartamentos" %>

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
       
    <title></title>
    
</head>
<body>
<form id="form1" runat="server">
    
<div class="banner">
    <p>Conectado(a) como: <strong>Adminstrador - ibalmaceda</strong></p>
</div>

<!--menu-->
<div class="menu1">
    <div id="myslidemenu" class="jqueryslidemenu">
    <ul>
        <li><a href="#">Clientes</a>
        <ul>
        <li><a href="#">Ingresar Clientes Nuevos</a></li>
        <li><a href="#">Mantenedor de Clientes</a></li>
        <li><a href="#">Reportes</a></li>
        </ul>
        </li>
        <li><a href="#">Viviendas</a>
        <ul>
        <li><a href="#">Proyectos</a></li>
        <li><a href="#">Conjuntos</a></li>
        <li><a href="#">Asignación Vivienda</a></li>
        <li><a href="#">Escrituración</a></li>
        </ul>
        </li>
        <li><a href="#">Dineros</a>
        <ul>
        <li><a href="#">Pago Asesorias</a>
        <ul>
        <li><a href="#">Por Cliente</a></li>
        <li><a href="#">Por Período</a></li>
        </ul>
        </li>
        </ul>
        </li>
        <li><a href="#">Gestión</a>
        <ul>
        <li><a href="#">Elemento sin título</a></li>
        </ul>
        </li>
        <li><a href="#">Mantención</a>
        <ul>
        <li><a href="#">Logs Acciones</a></li>
        <li><a href="#">Mantención Tablas</a></li>
        <li><a href="#">Usuarios</a></li>
        </ul>
        </li>
        <li><a href="#">Salir</a></li>
    </ul>
    <br style="clear: left" />
    </div>
</div>
<!--fin: menu-->
<div class="div1">
<div class="div2">
<br />
<span class="destacado1"> * </span><span style="font-size:12px; color: #333;">Información Obligatoria.</span>
<h1>INGRESO DE DEPARTAMENTO</h1>
<legend>Información conjunto</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;" width="100%">
        <tr>
            <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
                <asp:TextBox ID="TextBox16" runat="server" ReadOnly="true" Width="100"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
                <asp:TextBox ID="TextBox17" runat="server" ReadOnly="true" Width="100"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Etapa:<br/>
                <asp:TextBox ID="TextBox160" runat="server" ReadOnly="true" Width="100"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Código Producto:<br/>
                <asp:TextBox ID="TextBox170" runat="server" ReadOnly="true" Width="100"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Tipo Producto:<br/>
	            <asp:TextBox ID="TextBox108" runat="server" ReadOnly="true" Width="100"></asp:TextBox>
            </td>
            <td></td>
        </tr>
    </table>

<legend>Antecedentes del departamento</legend>
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Block:<br/>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Piso:<br/>
	        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">N° Dpto.:<br/>
	        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Modelo:<br/>
	        <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>

<legend>Datos gnerales</legend>
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Característica:<br/>
            <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Deslindes:<br/>
	        <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Orientación:<br/>
	        <asp:DropDownList ID="DropDownList3" runat="server" class="input-medium">
	            <asp:ListItem Value="Comuna"></asp:ListItem>
	        </asp:DropDownList>
        </td>
        <td align="left" valign="middle">&nbsp</td>
    </tr>
    <tr><td colspan="4">&nbsp</td></tr>
    <tr>
        <td align="left" valign="middle">Total Mts2 Construido (EJ: 70,43):<br/>
	        <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Dirección Comunal:<br/>
            <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Rol SII:<br/>
            <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">&nbsp</td>
    </tr>
</table>

<legend>Valores</legend>
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Valor (UF):<br/>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Descuento (%):<br/>
	        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Valor Final (UF):<br/>
	        <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Gasto Operacional (UF):<br/>
	        <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>

<legend>Cliente</legend>
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Rut:<br/>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Nombre:<br/>
	        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">E-mail:<br/>
	        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Teléfono :<br/>
	        <asp:TextBox ID="TextBox29" runat="server" Width="20"></asp:TextBox><asp:TextBox ID="TextBox30" runat="server" Width="100"></asp:TextBox>
        </td>
    </tr>
</table>

<legend>Compromiso reserva / Carta Oferta</legend>
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">N° Reserva:<br/>
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Fecha Reserva:<br/>
	        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">N° Carta Oferta:<br/>
	        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Fecha Carta Oferta :<br/>
	        <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>

<legend>Información interna</legend>
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Ejecutivo de Venta:<br/>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Fecha Venta:<br/>
	        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Código Proyecto Proviene Cliente:<br/>
	        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<p class="separador"></p>  
<br/>

    <asp:Button ID="Button1" runat="server" Text="Grabar Registro" class="btn btn-large btn-success" />
    <asp:Button ID="Button2" runat="server" Text="Limpiar Formulario" class="btn btn-large btn-warning" />
    <br/>
    <span class="destacado1"> * </span><span style="font-size:12px; color: #333;">Información Obligatoria.</span>
<br/>
<br/>    
<br/>
    
</div>
</div>


</form>
<div class="pie">
<p>Inmobiliaria Prohogar S.A. / Merced 464, Santiago / Fono: (562) 964 5405</p>
</div>
    
    
    </form>
</body>
</html>