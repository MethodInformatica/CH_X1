<%@ Page Language="C#" AutoEventWireup="true" CodeFile="conjuntoHabitacionalPestanas.aspx.cs" Inherits="views_conjuntoHabitacionalPestanas" %>

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
            $("#tabs").tabs();
            $("#text_fecha_contrato").datepicker();
            $("#text_fecha_termino_construccion").datepicker();
            $("#text_fecha_recepcion_municipal").datepicker();
            $("#text_fecha_recepcion_prohogar").datepicker();
        });

        $(function() {
            $("#seguimiento").click(function() {
                var params = "{'msg' : 'From Client'}";
                $.ajax({
                    type: "POST",
                    url: "conjuntoHabitacionalPestanas.aspx/cargarDocAsociada",
                    data: params,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    async: true,
                    success: function(result) {
                        alert(result.d);
                    },
                    error: function(XMLHttpRequest, textStatus, errorThrown) {
                        alert(textStatus + ": " + XMLHttpRequest.responseText);
                    }
                });
            });
        });

        function LoadCiudades(result) {
            alert(result.d);
        }        
        
           
	</script>
    
    <title>Pestañas Conjunto Habitacional</title>
    
</head>
<body>
<form id="form1" runat="server">

<!-- #INCLUDE FILE="menu.aspx" -->    

<div class="div1">
<div class="div2">

<br />
<h1>DATOS CONJUNTO HABITACIONAL</h1>
<div id="tabs">
    <ul>
        <li><a href="#tabs-1" runat="server" id="prueba">Conjunto Habitacional</a></li>
        <li><a href="#tabs-2">Documentación Asociada</a></li>
        <li><a href="#tabs-3" id="seguimiento">Seguimiento</a></li>
        <li><a href="#tabs-4">Detalle de Viviendas o Dpto</a></li>
    </ul>
    
    <div id="tabs-1"><!-- tabs-1 (Conjunto Habitacional) -->
    
    <span class="destacado1"> * </span><span style="font-size:12px; color: #333;">Información Obligatoria.</span>
    <legend>Conjuto Habitacional</legend>
    <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
        <tr>
            <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
                <asp:TextBox ID="text_codigo_conjunto" runat="server" ReadOnly="true"></asp:TextBox>
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
                <input type="text" ID="text_fecha_contrato" runat="server"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td align="left" valign="middle">Fecha Termino Construcción:<br/>
                <input type="text" ID="text_fecha_termino_construccion" runat="server"/>
	            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td align="left" valign="middle">Fecha Recepción Municipal:<br/>
                <input type="text" ID="text_fecha_recepcion_municipal" runat="server"/>
	            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>Fecha Recepción Prohogar:<br/>          
                <input type="text" ID="text_fecha_recepcion_prohogar" runat="server"/>
            </td>
        </tr>
    </table>
    <p class="separador"></p>    
    <br/>

        <asp:Button ID="btnGrabarConjunto" runat="server" Text="Grabar Registro" class="btn btn-large btn-success" />
        <asp:Button ID="btnLimpiarConjunto" runat="server" Text="Limpiar Formulario" class="btn btn-large btn-warning" />
        <br/>
        <span class="destacado1"> * </span><span style="font-size:12px; color: #333;">Información Obligatoria.</span>
        <br/>
        <br/>    
        <br/>
    </div><!-- fin tabs-1 (Conjunto Habitacional) -->

    <div id="tabs-2"><!-- tabs-2 -->
    <legend>Información conjunto</legend>
        <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
            <tr>
                <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
	                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
                <td align="left" vaEtapa:<br/>
                    <asp:TextBox ID="TextBox26" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
        </table>
               
        <br/>
        <legend>
            Listado de documentación
            <span style="float:right; width: 63px;";>
                <a class="btn btn-small" href="documentacionAsociada.aspx">Agregar</a>
            </span>
        </legend>
        <table class="table table-striped" id="tabla" runat="server">
            <thead>
                <th>#         <th>#</th><th>Folio</th><th>Nombre</th><th>Fecha ingreso</th><th>Fecha Vencimiento</th><th>Acciones</th>
            </thead>
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
            <li><a href="#">Prev</a></li>
            <li><a href="#">1</a></li>
            <li><a href="#">2</a></li>
            <li><a href="#">3</a></li>
            <li><a href="#">4</a></li>
            <li><a href="#">5</a></li>
            <li><a href="#">Next</a></li>
        </ul>
        </div>
    </div><!-- fin tabs-2 -->
    
    
    <div id="tabs-3"><!-- tabs-3 -->
        <legend>Información conjunto</legend>
        <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
            <tr>
                <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
                    <asp:TextBox ID="text_cod_conjunto_tabs3" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
	                <asp:TextBox ID="TextBox19" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Etapa:<br/>
                    <asp:TextBox ID="TextBox20" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
        </table>
        
       <br/>
       <legend>Ingreso Mensaje</legend>
       <table>
            <tr>
                <td align="left" valign="middle" colspan="4">Usuario:<br/>
                    <asp:TextBox ID="TextBox28" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="left" valign="middle" colspan="4">Fecha mensaje:<br/>
                    <asp:TextBox ID="TextBox27" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="left" valign="middle" colspan="4"><br/></td>
            </tr>
            <tr>
                <td valign="top">Mensaje:</td>
                <td valign="top">&nbsp</td>
                <td colspan="2"><textarea rows="5" class="input-xxlarge"></textarea></td>
            </tr>
            <tr align="right"><td colspan="3"><button type="submit" class="btn btn-primary">Ingresar</button></td></tr>
        </table>
        
        <legend>Listado de mensajes</legend>
        <table class="table table-striped">
            <thead><th><button type="submit" class="btn">Actualizar</button></th></thead>
            <tbody>
                <tr>
                    <td>
                    <h4>maviles - 22/05/2013 14:00</h4>
                    <p class="text-warning">Etiam porta sem malesuada magna mollis euismod.</p>
                    </td>
                </tr>
                <tr>
                    <td>
                    <h4>maviles - 22/05/2013 14:00</h4>
                    <p class="text-warning">Etiam porta sem malesuada magna mollis euismod.</p>
                    </td>
                </tr>
                <tr>
                    <td>
                    <h4>maviles - 22/05/2013 14:00</h4>
                    <p class="text-warning">Etiam porta sem malesuada magna mollis euismod.</p>
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
    </div><!-- fin tabs-3 -->
    
    <div id="tabs-4"> <!-- tabs-4 -->
        <legend>Información conjunto</legend>
        <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
            <tr>
                <td align="left" valign="middle">Código Conjunto Habitacional:<br/>
                    <asp:TextBox ID="TextBox29" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Nombre Conjunto Habitacional:<br/>
	                <asp:TextBox ID="TextBox30" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Etapa:<br/>
                    <asp:TextBox ID="TextBox31" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
        </table>
        
        <br />
        <legend>Viviendas o Departamentos</legend>
        <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
           <tr>
                <td align="left" valign="middle">Tipo producto:<br/>
                    <asp:DropDownList ID="DropDownList10" runat="server" class="input-medium">
                        <asp:ListItem Value="Tipo producto"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td align="left" valign="middle" colspan="2"><br/>
                    <button type="submit" class="btn btn-success">Carga Masiva</button>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <button type="submit" class="btn btn-primary">Uno a uno</button>
                </td>
           </tr>
       </table>
       
        <legend>Criterios de busqueda</legend>
        <table border="1" cellpadding="0" cellspacing="0" style="margin: 0 0 15px 0;">
            <tr>
                <td align="left" valign="middle">Código Producto:<br/>
                    <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Tipo:<br/>
	                <asp:DropDownList ID="DropDownList11" runat="server">
                    <asp:ListItem Value="Tipo"></asp:ListItem>
                </asp:DropDownList>
                </td>
                <td align="left" valign="middle">Monto:<br/>
                    <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
                </td>
                <td valign="bottom"><button type="submit" class="btn btn-primary">Buscar</button></td>
            </tr>
        </table>
        
        <legend>Listado viviendas o departamentos</legend>
        <table class="table table-striped">
            <thead>
                <th>#</th><th>Código Producto</th><th>Tipo Producto</th><th>Monto (UF)</th><th>Rut Cliente</th><th>Acciones</th>
            </thead>
            <tbody>
                <tr>
                    <td>1</td><td>CA001</td><td>Casa Aislada</td><td>850</td><td>11111111-1</td>
                    <td>
                        <button class="btn btn-mini btn-info" type="button">Visualizar</button>
                        <button class="btn btn-mini btn-warning" type="button">Editar</button>
                        <button class="btn btn-mini btn-danger" type="button">Eliminar</button>
                    </td>
                </tr>
                <tr>
                    <td>2</td><td>CA002</td><td>Casa Pareada</td><td>800</td><td>22222222-1</td>
                    <td>
                        <button class="btn btn-mini btn-info" type="button">Visualizar</button>
                        <button class="btn btn-mini btn-warning" type="button">Editar</button>
                        <button class="btn btn-mini btn-danger" type="button">Eliminar</button>
                    </td>
                </tr>
                <tr>
                    <td>3</td><td>CA003</td><td>Casa Pareada</td><td>780</td><td>33333333-1</td>
                    <td>
                        <button class="btn btn-mini btn-info" type="button">Visualizar</button>
                        <button class="btn btn-mini btn-warning" type="button">Editar</button>
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
    </div><!-- fin tabs-4 -->
</div>


<br/>
<br/>    
<br/>
    
</div>
</div>

<!-- #INCLUDE FILE="piePagina.aspx" --> 
    
</form>    

</body>
</html>