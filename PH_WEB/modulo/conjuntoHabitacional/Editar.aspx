<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/modulo/conjuntoHabitacional/MarcoModulo.master" 
CodeFile="Editar.aspx.cs" Inherits="modulo_conjuntoHabitacional_Editar" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="head" ContentPlaceHolderID="contentHead" Runat="Server">
    <!--<script type="text/javascript">
        $(function() {
            $("#tabs").tabs({
                beforeLoad: function(event, ui) {
                    ui.jqXHR.error(function() {
                        ui.panel.html(
            "No es posible cargar la información");
                    });
                },
                activate: function(event, ui) {
                //alert(JSON.stringify(ui));
                }
            });
        });
        function cargarContenido(index) {
            $("#tabs").tabs({ active: index });    
        }
  </script>-->
</asp:Content>
<asp:Content ID="content" ContentPlaceHolderID="contentBody" Runat="Server">   
<form id="formPrincipal" runat="server">
<ajaxToolkit:ToolkitScriptManager runat="Server" EnablePartialRendering="true" ID="ScriptManager1" />
<h1>DATOS CONJUNTO HABITACIONAL</h1>
<!--
<div id="tabs">
    <ul>
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/ConjuntoHabitacional.aspx") %>'>Conjunto Habitacional</a></li>
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/DocumentoListado.aspx") %>'>Documentación Asociada</a></li>
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/Seguimiento.aspx") %>'>Seguimiento</a></li>
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/ProductoListado.aspx") %>'>Detalle de Viviendas o Dpto</a></li>
        
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/ProductoCasa.aspx") %>'>Casa</a></li>
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/ProductoDepto.aspx") %>'>Depto</a></li>
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/ProductoEstacionamientoBodega.aspx") %>'>Estacionamiento</a></li>
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/ProductoLocalComercial.aspx") %>'>Local</a></li>
        
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/ProductoMasivoCasa.aspx") %>'>MCasa</a></li>
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/ProductoMasivoDepto.aspx") %>'>MDepto</a></li>
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/ProductoMasivoLocalComercial.aspx") %>'>MLoca</a></li>
        <li><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/ProductoMasivoEstacionamientoBodega.aspx") %>'>MEstac</a></li>
        
        <li style="display:none"><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/DocumentoAgregar.aspx") %>'>Agregar Documento</a></li>
        <li style="display:none"><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/DocumentoEditar.aspx") %>'>Editar Documento</a></li>
        <li style="display:none"><a href='<%= Page.ResolveUrl("~/modulo/conjuntoHabitacional/Tabs/DocumentoVer.aspx") %>'>Ver Documento</a></li>
    </ul>
</div>
-->   
    <ajaxToolkit:TabContainer ID="TabContainer1" runat="server" OnDemand="true">
    <ajaxToolkit:TabPanel ID="TabPanel1" runat="server" 
    HeaderText="Conjunto Habitacional">
        <ContentTemplate>
         <iframe name="" frameborder="0" height="1130" marginheight="0" marginwidth="0" width="100%" 
         scrolling="no" src="Tabs/ConjuntoHabitacional.aspx"></iframe>
        </ContentTemplate>
    </ajaxToolkit:TabPanel>
    <ajaxToolkit:TabPanel ID="TabPanel2" runat="server" 
    HeaderText="Documentación Asociada">
    <ContentTemplate>
         <iframe name="" frameborder="0" height="830" marginheight="0" marginwidth="0" width="100%" 
         scrolling="no" src="Tabs/DocumentoListado.aspx"></iframe>
        </ContentTemplate>
    </ajaxToolkit:TabPanel>
    <ajaxToolkit:TabPanel ID="TabPanel3" runat="server" 
    HeaderText="Seguimiento">
    <ContentTemplate>
         <iframe name="" frameborder="0" height="830" marginheight="0" marginwidth="0" width="100%" 
         scrolling="no" src="Tabs/Seguimiento.aspx"></iframe>
        </ContentTemplate>
    </ajaxToolkit:TabPanel>
    <ajaxToolkit:TabPanel ID="TabPanel4" runat="server" 
    HeaderText="Detalle de Viviendas o Dpto">
    <ContentTemplate>
         <iframe name="" frameborder="0" height="830" marginheight="0" marginwidth="0" width="100%" 
         scrolling="no" src="Tabs/ProductoListado.aspx"></iframe>
        </ContentTemplate>
    </ajaxToolkit:TabPanel>
    </ajaxToolkit:TabContainer>
    </form>
</asp:Content>
        
