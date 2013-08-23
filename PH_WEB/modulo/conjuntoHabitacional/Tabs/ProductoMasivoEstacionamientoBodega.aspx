<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductoMasivoEstacionamientoBodega.aspx.cs" Inherits="modulo_conjuntoHabitacional_Tabs_ProductoMasivoEstacionamientoBodega" %>

<form id="formPrincipal" runat="server">
<h1>CARGA MASIVA BODEGA / ESTACIONAMIENTO </h1>

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
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " },
			  { n_est_bod: " ", mt2terr: " ", direccion: " ", rolsii: " ", valoruf: " ", descuento: " ", valorfinaluf: " ", gastooperacionaluf: " " }
			];

	      var $container = $("#example5");
	      $container.handsontable({
	          data: objectData,
	          dataSchema: { id: null, first: null, last: null },
	          colWidths: ['80', '120', '120', '50', '60', '90', '100', '150'],
	          startRows: 5,
	          startCols: 4,
	          //fixedRowsTop: 2,
	          //fixedColumnsLeft: 2,
	          colHeaders: ['N° Est./Bod', 'Total Mts2 Terreno', 'Dirección Comunal', 'Rol SII', 'Valor (UF)', 'Descuento %', 'Valor Final (UF)', 'Gasto Operacional (UF)'],
	          rowHeaders: true,
	          columns: [
                { data: "n_est_bod" },
                { data: "mt2terr" },
                { data: "direccion" },
                { data: "rolsii" },
                { data: "valoruf" },
                { data: "descuento" },
                { data: "valorfinaluf" },
                { data: "gastooperacionaluf" }
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