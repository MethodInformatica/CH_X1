<%@ Page Language="C#" MasterPageFile="~/modulo/conjuntoHabitacional/Tabs/MarcoTab.master" AutoEventWireup="true" CodeFile="ProductoListado.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_ProductoListado" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="content" ContentPlaceHolderID="bodyTabContent" Runat="Server"> 
<form id="formPrincipal" runat="server">
<ajaxToolkit:ToolkitScriptManager runat="Server" EnableScriptGlobalization="true" EnableScriptLocalization="true" ID="ScriptManager1" ScriptMode="Debug" CombineScripts="false" />
<script>
    function confirmarEliminarDoc(ic) {
        if (confirm("Esta seguro de eliminar el Documento '" + ic + "'?")) {
            return false;
        }
    }
    function centralTabs(x,y,t,i) {
        window.location.href = "centralTabs.aspx?x=" + x + "&y=" + y + "&t=" + t + "&i=" + i + " ";
    }
    
    
</script>
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
        
        <br />
        <legend>Viviendas o Departamentos</legend>
        <table border="1" cellpadding="0" cellspacing="0" width="70%">
           <tr>
                <td align="left" valign="middle">Tipo producto:<br/>
                    <asp:DropDownList ID="ddlTipoProducto" runat="server" class="input-medium">
                        <asp:ListItem Text="Seleccione" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Casas Aisladas" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Casas Pareadas" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Casas Compuestas" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Departamentos" Value="4"></asp:ListItem>
                        <asp:ListItem Text="Bodegas" Value="5"></asp:ListItem>
                        <asp:ListItem Text="Estacionamiento" Value="6"></asp:ListItem>
                        <asp:ListItem Text="Locales Comerciales" Value="7"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td align="left" valign="middle" colspan="2"><br/>
                    <asp:Button ID="btn_CargaMasiva" CssClass="btn btn-success" runat="server" 
                        Text="Carga Masiva" Width="150" onclick="btn_CargaMasiva_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_CargaUnoUno" CssClass="btn btn-primary" runat="server" 
                        Text="Uno a uno" onclick="btn_CargaUnoUno_Click" Width="150" />
                </td>
           </tr>
       </table>
       
        <legend>Criterios de busqueda</legend>
        <table border="1" cellpadding="1" cellspacing="1" width="100%">
            <tr>
                <td align="left" valign="middle">Código Producto:<br/>
                    <asp:TextBox ID="text_codigoProducto_Busqueda" runat="server" MaxLength="5"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Tipo Producto:<br/>
	                <asp:DropDownList ID="ddlTipoProducto_Busqueda" runat="server" class="input-medium">
                        <asp:ListItem Text="Seleccione" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Casas Aisladas" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Casas Pareadas" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Casas Compuestas" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Departamentos" Value="4"></asp:ListItem>
                        <asp:ListItem Text="Bodegas" Value="5"></asp:ListItem>
                        <asp:ListItem Text="Estacionamiento" Value="6"></asp:ListItem>
                        <asp:ListItem Text="Locales Comerciales" Value="7"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td align="left" valign="middle">Monto:<br/>
                    <asp:TextBox ID="text_monto_busqueda" runat="server" MaxLength="4"></asp:TextBox>
                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" TargetControlID="text_monto_busqueda" FilterType="Numbers" />
                </td>
                <td valign="middle"><asp:Button class="btn btn-primary" Text="Buscar Producto" ID="btn_buscar_producto" runat="server" onclick="btn_buscar_producto_Click"  /></td>
            </tr>
        </table>
        
        <legend>Listado viviendas o departamentos</legend>
        <table class="table table-striped" id="tablaProductos" runat="server">
            <thead>
                <th>#</th><th>Código Producto</th><th>Tipo Producto</th><th>Monto (UF)</th><th>Rut Cliente</th><th>Acciones</th>
            </thead>
            <tbody>
            </tbody>
        </table>
        <div class="pagination" id="paginador" runat="server" style="visibility:hidden">
        <ul>
            <li><a href="#">Anterior</a></li>
            <li><a href="#">1</a></li>
            <li><a href="#">2</a></li>
            <li><a href="#">3</a></li>
            <li><a href="#">4</a></li>
            <li><a href="#">5</a></li>
            <li><a href="#">Siguiente</a></li>
        </ul>
        </div>
</form>
</asp:Content>