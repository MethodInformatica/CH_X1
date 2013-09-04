<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/modulo/conjuntoHabitacional/Tabs/MarcoTab.master" CodeFile="ProductoCasa.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_ProductoCasa" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="content" ContentPlaceHolderID="bodyTabContent" Runat="Server">
<form id="formPrincipal" runat="server">
<ajaxToolkit:ToolkitScriptManager runat="Server" EnableScriptGlobalization="true" EnableScriptLocalization="true" ID="ScriptManager1" ScriptMode="Debug" CombineScripts="false" />
    <h1>INGRESO DE CASAS</h1>
    <legend>Información Conjunto Habitacional <span style="float:right; width: 20%; text-align:left";><a class="btn" href="#">Volver</a></span></legend>
        <table border="1" cellpadding="0" cellspacing="0" width="90%">
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
    <table border="1" cellpadding="0" cellspacing="0" width="90%">
        <tr>
            <td align="left" valign="middle">Manzana:<br/>
                <asp:TextBox ID="text_manzana" runat="server" Width="120" MaxLength="5"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Sitio:<br/>
	            <asp:TextBox ID="text_sitio" runat="server" Width="120" MaxLength="5"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Casa Esquina:<br/>
	            <asp:DropDownList ID="ddlCasaEsquina" runat="server" class="input-medium">
	                <asp:ListItem Value="0" Text="Seleccione"></asp:ListItem>
	                <asp:ListItem Value="1" Text="SI"></asp:ListItem>
	                <asp:ListItem Value="2" Text="NO"></asp:ListItem>
	            </asp:DropDownList>
            </td>
            <td align="left" valign="middle">Modelo:<br/>
	            <asp:TextBox ID="text_modelo" runat="server" Width="120" MaxLength="30"></asp:TextBox>
            </td>
        </tr>
    </table>

    <legend>Datos generales</legend>
    <table border="1" cellpadding="0" cellspacing="0" width="90%">
        <tr>
            <td align="left" valign="middle" colspan="2">Característica:<br/>
                <asp:TextBox ID="text_caracteristica" runat="server" width="250" height="50" MaxLength="250"></asp:TextBox>
            </td>
            <td align="left" valign="middle" colspan="2">Deslindes:<br/>
	            <asp:TextBox ID="text_deslindes" runat="server" width="250" height="50" MaxLength="250"></asp:TextBox>
            </td>
            </tr>
            <tr>
            <td align="left" valign="middle" colspan="2">Orientación:<br/>
	            <asp:DropDownList ID="ddlOrientacion" runat="server" class="input-medium" Width="130">
	                <asp:ListItem Value="0" Text="Seleccione"></asp:ListItem>
	                <asp:ListItem Value="1" Text="Norte"></asp:ListItem>
	                <asp:ListItem Value="2" Text="Sur"></asp:ListItem>
	                <asp:ListItem Value="3" Text="Oriente"></asp:ListItem>
	                <asp:ListItem Value="4" Text="Poniente"></asp:ListItem>
	                <asp:ListItem Value="5" Text="Nororiente"></asp:ListItem>
	                <asp:ListItem Value="6" Text="Norponiente"></asp:ListItem>
	                <asp:ListItem Value="7" Text="Suroriente"></asp:ListItem>
	                <asp:ListItem Value="8" Text="Surponiente"></asp:ListItem>
	            </asp:DropDownList>
            </td>
            <td align="left" valign="middle">Dirección Comunal:<br/>
                <asp:TextBox ID="text_direccionComunal" runat="server" width="250" MaxLength="250"></asp:TextBox>
            </td>
        </tr>
        <tr><td colspan="4">&nbsp</td></tr>
        <tr>
            <td align="left" valign="middle">Total Mts2 Construido (EJ: 70,43):<br/>
                <asp:TextBox ID="text_mConstruido" runat="server" width="100" MaxLength="4"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender TargetControlID="text_mConstruido" ID="FilteredTextBoxExtender1" runat="server" FilterType="Numbers" />
            </td>
            <td align="left" valign="middle">Total Mts2 Terreno (Ej: 100,23):<br/>
                <asp:TextBox ID="text_mTerreno" runat="server" width="100" MaxLength="4"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender TargetControlID="text_mTerreno" ID="FilteredTextBoxExtender2" runat="server" FilterType="Numbers" />
            </td>
            <td align="left" valign="middle">Rol SII:<br/>
                <asp:TextBox ID="text_rolSII" runat="server" width="100" MaxLength="5"></asp:TextBox>
            </td>
            <td align="left" valign="middle">
            </td>
        </tr>
        <tr>
           <td align="left" valign="middle" colspan="4"><br/>
           </td>
        </tr>
    </table>

    <legend>Valores</legend>
    <table border="1" cellpadding="0" cellspacing="0" width="90%">
        <tr>
            <td align="left" valign="middle">Valor (UF):<br/>
                <asp:TextBox ID="text_valorUF" runat="server" Width="100" MaxLength="5"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender TargetControlID="text_valorUF" ID="FilteredTextBoxExtender3" runat="server" FilterType="Numbers" />
            </td>
            <td align="left" valign="middle">Descuento (%):<br/>
	            <asp:TextBox ID="text_descuento" runat="server" width="100" MaxLength="3"></asp:TextBox>
	            <ajaxToolkit:FilteredTextBoxExtender TargetControlID="text_descuento" ID="FilteredTextBoxExtender4" runat="server" FilterType="Numbers" />
            </td>
            <td align="left" valign="middle">Valor Final (UF):<br/>
	            <asp:TextBox ID="text_valorFinalUF" runat="server" width="100" MaxLength="3"></asp:TextBox>
	            <ajaxToolkit:FilteredTextBoxExtender TargetControlID="text_valorFinalUF" ID="FilteredTextBoxExtender5" runat="server" FilterType="Numbers" />
            </td>
            <td align="left" valign="middle">Gasto Operacional (UF):<br/>
	            <asp:TextBox ID="text_gastoOperacional" runat="server" width="100" MaxLength="4"></asp:TextBox>
	            <ajaxToolkit:FilteredTextBoxExtender TargetControlID="text_gastoOperacional" ID="FilteredTextBoxExtender6" runat="server" FilterType="Numbers" />
            </td>
        </tr>
    </table>

    <legend>Cliente</legend>
    <table border="1" cellpadding="0" cellspacing="0" width="90%">
        <tr>
            <td align="left" valign="middle">Rut:<br/>
                <asp:TextBox ID="text_rutCliente" runat="server" Width="100" disabled></asp:TextBox>
            </td>
            <td align="left" valign="middle">Nombre:<br/>
	            <asp:TextBox ID="text_nombreCliente" runat="server" Width="150" disabled></asp:TextBox>
            </td>
            <td align="left" valign="middle">E-mail:<br/>
	            <asp:TextBox ID="text_emailCliente" runat="server" Width="150" disabled></asp:TextBox>
            </td>
            <td align="left" valign="middle">Teléfono :<br/>
	            <asp:TextBox ID="text_telefonoCliente_Area" runat="server" Width="20" disabled></asp:TextBox>
	             - 
	             <asp:TextBox ID="text_telefonoCliente_Telefono" runat="server" Width="60" disabled></asp:TextBox>
            </td>
        </tr>
    </table>

    <legend>Compromiso Reserva / Carta Oferta</legend>
    <table border="1" cellpadding="0" cellspacing="0" width="90%">
        <tr>
            <td align="left" valign="middle">N° Reserva:<br/>
                <asp:TextBox ID="text_nReserva" runat="server" Width="100" disabled></asp:TextBox>
            </td>
            <td align="left" valign="middle">Fecha Reserva:<br/>
	            <asp:TextBox ID="text_fechaReserva" runat="server" Width="100" disabled></asp:TextBox>
            </td>
            <td align="left" valign="middle">N° Carta Oferta:<br/>
	            <asp:TextBox ID="text_numeroCartaOferta" runat="server" Width="100" disabled></asp:TextBox>
            </td>
            <td align="left" valign="middle">Fecha Carta Oferta :<br/>
	            <asp:TextBox ID="text_fechaCartaOferta" runat="server" Width="100" disabled></asp:TextBox>
            </td>
        </tr>
    </table>

    <legend>Información Interna</legend>
    <table border="1" cellpadding="0" cellspacing="0" width="90%">
        <tr>
            <td align="left" valign="middle">Ejecutivo de Venta:<br/>
                <asp:TextBox ID="text_ejecutivoVenta" runat="server" disabled></asp:TextBox>
            </td>
            <td align="left" valign="middle">Fecha Venta:<br/>
	            <asp:TextBox ID="text_fechaVenta" runat="server" disabled></asp:TextBox>
            </td>
            <td align="left" valign="middle">Código Proyecto Proviene Cliente:<br/>
	            <asp:TextBox ID="text_codigoProyecto" runat="server" disabled></asp:TextBox>
            </td>
        </tr>
    </table>
    <p class="separador"></p>  
    <br/>

        <asp:Button ID="btn_grabar" runat="server" Text="Guardar" class="btn btn-large btn-success" onclick="btn_grabar_Click" />
        <asp:Button ID="btn_limpiar" runat="server" Text="Limpiar Formulario" class="btn btn-large btn-warning" />
        <br/>
        <span class="destacado1"> * </span><span style="font-size:12px; color: #333;">Información Obligatoria.</span>
    
</form>
</asp:Content>