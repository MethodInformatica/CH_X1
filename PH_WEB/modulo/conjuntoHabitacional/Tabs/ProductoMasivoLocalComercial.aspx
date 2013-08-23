<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductoMasivoLocalComercial.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_ProductoMasivoLocalComercial" %>

<form id="formPrincipal" runat="server">
<h1>CARGA MASIVA LOCAL COMERCIAL </h1>

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
    
<legend>Información Mínima Requerida</legend>
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
</form>