<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductoMasivoCasa.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_ProductoMasivoCasa" %>

    

<form id="formPrincipal" runat="server">
<h1>CARGA MASIVA CASAS </h1>

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
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ",sitio: " ",casae: " " ,modelo: " ",orientacion: " ",totalmt2Cons: " ",totalmt2terr:" ",direccion: " ",rolsii: " ",valoruf:" ",descuento: " ",valorfinaluf: " ",gastoopuf:" " },
			  { manzana: " ", sitio: " ", casae: " ", modelo: " ", orientacion: " ", totalmt2Cons: " ", totalmt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { manzana: " ", sitio: " ", casae: " ", modelo: " ", orientacion: " ", totalmt2Cons: " ", totalmt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " },
			  { manzana: " ", sitio: " ", casae: " ", modelo: " ", orientacion: " ", totalmt2Cons: " ", totalmt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastoopuf: " " }
			];

	      var $container = $("#example5");
	      $container.handsontable({
	          data: objectData,
	          dataSchema: { id: null, first: null, last: null },
	          colWidths: ['70', '40', '90', '60', '70', '100', '90', '80', '50', '70', '70', '90', '70'],
	          startRows: 5,
	          startCols: 4,
	          //fixedRowsTop: 2,
	          //fixedColumnsLeft: 2,
	          colHeaders: ['Manzana', 'Sitio', 'Casa Esquina', 'Modelo', 'Orientación', 'Total mt2 Const', 'Total mt2 terr', 'Dir. Comunal', 'Rol SII', 'Valor (UF)', 'Descuento', 'Valor Final (UF)', 'Gasto Operacional (UF)'],
	          rowHeaders: true,
	          columns: [ 
	          {data:"manzana"},
	          {data:"sitio"},
	          {data:"casae"},
	          {data:"modelo"},
	          {data:"orientacion"},
	          {data:"totalmt2Cons"},
	          {data:"totalmt2terr"},
	          {data:"direccion"},
	          {data:"rolsii"},
	          {data:"valoruf"},
	          {data:"descuento"},
	          {data:"valorfinaluf"},
	          {data:"gastoopuf"} ],
	          minSpareRows: 1
	      });
      </script>
<br/>
<br/>

    <asp:Button ID="Button1" runat="server" Text="Grabar" class="btn btn-large btn-success" />
    <asp:Button ID="Button2" runat="server" Text="Cancelar" class="btn btn-large btn-warning" />
    <br/>
    </form>