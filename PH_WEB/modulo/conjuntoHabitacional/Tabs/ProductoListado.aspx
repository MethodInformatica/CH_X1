<%@ Page Language="C#" MasterPageFile="~/modulo/conjuntoHabitacional/Tabs/MarcoTab.master" AutoEventWireup="true" CodeFile="ProductoListado.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_ProductoListado" %>
<asp:Content ID="content" ContentPlaceHolderID="bodyTabContent" Runat="Server"> 
<form id="formPrincipal" runat="server">
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
                        <asp:ListItem Text="Casa" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Departamento" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Estacionamiento/Bodega" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Local Comercial" Value="4"></asp:ListItem>
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
                    <asp:TextBox ID="text_codigoProducto_Busqueda" runat="server"></asp:TextBox>
                </td>
                <td align="left" valign="middle">Tipo Producto:<br/>
	                <asp:DropDownList ID="ddlTipoProducto_Busqueda" runat="server" class="input-medium">
                        <asp:ListItem Text="Seleccione" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Casa" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Departamento" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Estacionamiento/Bodega" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Local Comercial" Value="4"></asp:ListItem>
                    </asp:DropDownList>
                </asp:DropDownList>
                </td>
                <td align="left" valign="middle">Monto:<br/>
                    <asp:TextBox ID="text_monto_busqueda" runat="server"></asp:TextBox>
                </td>
                <td valign="middle"><button type="submit" class="btn btn-primary">Buscar Producto</button></td>
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