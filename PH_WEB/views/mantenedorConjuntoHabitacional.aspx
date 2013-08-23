<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mantenedorConjuntoHabitacional.aspx.cs" Inherits="views_mantenedorConjuntoHabitacional" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    
    <link href="../css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../css/estilos.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.9.1.js" type="text/javascript"></script>
    <script src="../js/jquery-ui-1.10.3.custom.js" type="text/javascript"></script>
    <script src="../js/jquery-ui-1.10.3.custom.min.js" type="text/javascript"></script>
    <script src="../js/jqueryslidemenu.js" type="text/javascript"></script>
    <script src="../js/bootstrap.js" type="text/javascript"></script>
    <script src="../js/bootstrap.min.js" type="text/javascript"></script>
    
       
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
<h1>MANTENEDOR CONJUNTOS HABITACIONALES</h1>
<br />
<legend>Criterios de busqueda</legend>
<table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
    <tr>
        <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
	        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Región:<br/>
            <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="Región"></asp:ListItem>
        </asp:DropDownList>
        </td>
        <td valign="bottom">
            <button type="submit" class="btn btn-primary">Buscar</button>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <button type="submit" class="btn btn-success">Agregar</button>
        </td>
    </tr>
</table>
    
<br/>
<legend>Listado conjuntos habitacionales</legend>
    <table class="table table-striped">
        <thead>
            <th>#</th><th>Código Conjunto Habitacional</th><th>Nombre Conjunto Habitacional</th><th>Región</th><th>Acciones</th>
        </thead>
        <tbody>
            <tr>
                <td>1</td><td>130001</td><td>Los Olivos</td><td>Metropolitana</td>
                <td>
                    <button class="btn btn-mini btn-primary" type="button">Ingresar</button>
                    <button class="btn btn-mini btn-danger" type="button">Eliminar</button>
                </td>
            </tr>
            <tr>
                <td>2</td><td>130002</td><td>Cantaros de Agua</td><td>Metropolitana</td>
                <td>
                    <button class="btn btn-mini btn-primary" type="button">Ingresar</button>
                    <button class="btn btn-mini btn-danger" type="button">Eliminar</button>
                </td>
            </tr>
            <tr>
                <td>3</td><td>130003</td><td>Los Coihues</td><td>Metropolitana</td>
                <td>
                    <button class="btn btn-mini btn-primary" type="button">Ingresar</button>
                    <button class="btn btn-mini btn-danger" type="button">Eliminar</button>
                </td>
            </tr>
        </tbody>
    </table>
    <div class="pagination">
        <ul>
            <li><a href="#">Prev</a></li>
            <li><a href="#">1</a></li>
            <li><a href="#">2</a></li>
            <li><a href="#">3</a></li>
            <li><a href="#">4</a></li>
            <li><a href="#">5</a></li>
            <li><a href="#">Next</a></li>
        </ul>
    </div>
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