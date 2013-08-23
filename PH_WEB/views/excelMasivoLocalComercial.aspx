<%@ Page Language="C#" AutoEventWireup="true" CodeFile="excelMasivoLocalComercial.aspx.cs" Inherits="views_excelMasivoLocalComercial" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

    <link href="../css/bootstrap/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../css/bootstrap/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="../css/bootstrap/bootstrap-fileupload.css" rel="stylesheet" type="text/css" />
    <link href="../css/bootstrap/bootstrap-fileupload.min.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.9.1.js" type="text/javascript"></script>
    <script src="../js/jquery-ui-1.10.3.custom.js" type="text/javascript"></script>
    <script src="../js/jquery-ui-1.10.3.custom.min.js" type="text/javascript"></script>
    <script src="../js/jqueryslidemenu.js" type="text/javascript"></script>
    <script src="../js/bootstrap/bootstrap-fileupload.js" type="text/javascript"></script>
    <script src="../js/bootstrap/bootstrap-fileupload.min.js" type="text/javascript"></script>
    <script src="../js/bootstrap/bootstrap.js" type="text/javascript"></script>
    <script src="../js/bootstrap/bootstrap.min.js" type="text/javascript"></script>
    
    <script src="http://www.method.cl/MTD_Grilla/include/jquery.handsontable.full.js"></script>
    <link href="http://www.method.cl/MTD_Grilla/include/jquery.handsontable.full.css" rel="stylesheet" media="screen">
    <script src="http://www.method.cl/MTD_Grilla/include/samples.js"></script>
    <script src="http://www.method.cl/MTD_Grilla/include/highlight.pack.js"></script>
    
    
    
    
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
<h1>CARGA MASIVA LOCAL COMERCIAL </h1>

<legend>Información conjunto</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
        <tr>
            <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
                <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="true"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Etapa:<br/>
                <asp:TextBox ID="TextBox26" runat="server" ReadOnly="true"></asp:TextBox>
            </td>
        </tr>
    </table>
    
<legend>Información minima requerida</legend>
 <div id="example5" class="handsontable"></div>	  
	  
	  <script>


	      var objectData = [
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { sitio: " ", orientacion: " ", mt2construido: " ", mt2terreno: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " }
			  
			];

	      var $container = $("#example5");
	      $container.handsontable({
	          data: objectData,
	          dataSchema: { id: null, first: null, last: null },
	          colWidths: ['50', '70', '100', '80', '120', '50', '60', '90', '100', '110'],
	          startRows: 5,
	          startCols: 4,
	          //fixedRowsTop: 2,
	          //fixedColumnsLeft: 2,
	          colHeaders: ['Sitio', 'Orientación', 'Mts2 Construido', 'Mts2 Terreno', 'Dirección Comunal', 'Rol SII', 'Valor (UF)', 'Descuento %', 'Valor Final (UF)', 'Gasto Operacional (UF)'],
	          rowHeaders: true,
	          columns: [
                { data: "sitio" },
                { data: "orientacion" },
                { data: "mt2construido" },
                { data: "mt2terreno" },
                { data: "direccion" },
                { data: "rolsii" },
                { data: "valoruf" },
                { data: "descuento" },
                { data: "valorfinaluf" },
                { data: "gastoopuf" }
             ],
	          minSpareRows: 1
	      });
      </script>
<br/>
<br/>

    <asp:Button ID="Button1" runat="server" Text="Grabar" class="btn btn-large btn-success" />
    <asp:Button ID="Button2" runat="server" Text="Cancelar" class="btn btn-large btn-warning" />
    <br/>
<br/>
<br/>    

    
</div>
</div>

<div class="pie">
<p>Inmobiliaria Prohogar S.A. / Merced 464, Santiago / Fono: (562) 964 5405</p>
</div>
</form>
</body>
</html>