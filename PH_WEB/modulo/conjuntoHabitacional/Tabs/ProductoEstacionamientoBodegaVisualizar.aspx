﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductoEstacionamientoBodegaVisualizar.aspx.cs" 
Inherits="modulo_conjuntoHabitacional_Tabs_ProductoEstacionamientoBodega" MasterPageFile="~/modulo/conjuntoHabitacional/Tabs/MarcoTab.master" %>
 <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="content" ContentPlaceHolderID="bodyTabContent" Runat="Server">
<form id="formPrincipal" runat="server">
<h1>VISUALIZACION DE ESTACIONAMIENTO/BODEGA</h1>
    <legend>Información Conjunto Habitacional <span style="float:right; width: 20%; text-align:left";>
                <a class="btn" href="#">Volver</a>
            </span></legend>
            <asp:Label Visible="false" ID="x" runat="server"></asp:Label>
            <asp:Label Visible="false" ID="y" runat="server"></asp:Label>
            <asp:Label Visible="false" ID="z" runat="server"></asp:Label>
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


<legend>Antecedentes Estacionamiento / Bodega </legend>
<table border="1" cellpadding="0" cellspacing="0" width="90%">
    <tr>
        <td align="left" valign="middle">N° Est./Bod.:<br/>
            <asp:TextBox ID="text_nEstaBode" runat="server" width="100" ReadOnly="true"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Total Mts2 Terreno (EJ: 70,43) :<br/>
	        <asp:TextBox ID="text_mTerreno" runat="server" width="100" ReadOnly="true"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Dirección Comunal:<br/>
	        <asp:TextBox ID="text_direccionComunal" runat="server" width="100" ReadOnly="true"></asp:TextBox>
        </td>
        <td align="left" valign="middle">Rol SII:<br/>
	        <asp:TextBox ID="text_rolSII" runat="server" width="100" ReadOnly="true"></asp:TextBox>
        </td>
    </tr>
</table>

<legend>Datos Generales </legend>
<table>
    <tr>
        <td valign="top">Característica:</td>
        <td valign="top">&nbsp</td>
        <td colspan="3"><textarea rows="5" class="input-xxlarge" id="text_caracteristicas" runat="server" disabled></textarea></td>
    </tr>
    <tr>
           <td align="left" valign="middle" colspan="5">Estado del Producto:<br/>
                <asp:DropDownList ID="ddlEstadoProducto" runat="server" class="input-medium" Enabled="false">
	                <asp:ListItem Value="0" Text="Seleccione"></asp:ListItem>
	                <asp:ListItem Value="1" Text="Reservado"></asp:ListItem>
	                <asp:ListItem Value="2" Text="Asociado a Cliente"></asp:ListItem>
	            </asp:DropDownList>
           </td>
        </tr>
</table>

 <legend>Valores</legend>
    <table border="1" cellpadding="0" cellspacing="0" width="90%">
        <tr>
            <td align="left" valign="middle">Valor (UF):<br/>
                <asp:TextBox ID="text_valorUF" runat="server" Width="100" ReadOnly="true"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Descuento (%):<br/>
	            <asp:TextBox ID="text_descuento" runat="server" width="100" ReadOnly="true"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Valor Final (UF):<br/>
	            <asp:TextBox ID="text_valorFinalUF" runat="server" width="100" ReadOnly="true"></asp:TextBox>
            </td>
            <td align="left" valign="middle">Gasto Operacional (UF):<br/>
	            <asp:TextBox ID="text_gastoOperacional" runat="server" width="100" ReadOnly="true"></asp:TextBox>
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
	            <asp:TextBox ID="text_telefonoCliente" runat="server" Width="20" disabled></asp:TextBox>
	             - 
	             <asp:TextBox ID="TextBox30" runat="server" Width="60" disabled></asp:TextBox>
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
    <br/>
</form>
</asp:Content>