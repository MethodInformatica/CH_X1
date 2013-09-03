using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using PH_ENT;
using System.Collections.Generic;
using PH_BSS;

public partial class modulo_conjuntoHabitacional_Tabs_ProductoListado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ConjuntoHabitacional_ENT oConjunto = (ConjuntoHabitacional_ENT)Session["sessionConjuntoHabitacional"];
        //this.cargarDatosConjunto(oConjunto); 
        if (!Page.IsPostBack)
        {
            List<Producto_ENT> productos = new Producto_BSS().listAllProductos();
            this.cargaListado(productos);
        }
        else 
        {
            // Código a ejecutar solo si vuelve a la pagina.
        }
    }

    protected void cargarDatosConjunto(ConjuntoHabitacional_ENT oConjunto)
    {
        //text_codigo_conjunto.Text = oConjunto.CodigoConjunto;
        //text_nombre_conjunto.Text = oConjunto.NombreConjunto;
        //text_etapa.Text = oConjunto.Etapa;
    } 

    protected void btn_CargaUnoUno_Click(object sender, EventArgs e)
    {
        int tipo = Convert.ToInt32(ddlTipoProducto.SelectedValue);

        if (tipo == 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert("Debe seleccionar un tipo de producto!!!"));
        }
        else if (tipo == 1 || tipo == 2 || tipo == 3) 
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoCasa.aspx?t=" + tipo + "");
        }
        else if (tipo == 4)
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoDepto.aspx?t=" + tipo + "");
        }
        else if (tipo == 5 || tipo == 6)
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoEstacionamientoBodega.aspx?t=" + tipo + "");
        }
        else if (tipo == 7)
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoLocalComercial.aspx?t=" + tipo + "");
        }
    }

    protected void btn_CargaMasiva_Click(object sender, EventArgs e)
    {
        ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Funcionalidad en construcción!!!"));
    }

    public void cargaListado(List<Producto_ENT> productos)
    {
        int i = 1;
        foreach (Producto_ENT producto in productos)
        {
            HtmlTableRow row = new HtmlTableRow();
            row.Cells.Add(new HtmlTableCell() { InnerHtml = i.ToString() });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = producto.CodigoProducto});
            row.Cells.Add(new HtmlTableCell() { InnerHtml = producto.TipoProducto });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = producto.ValoUF});
            row.Cells.Add(new HtmlTableCell()
            {
                InnerHtml = "<button class='btn btn-mini btn-info' type='button'onclick=\"JaVASCRIPT:centralTabs('" + producto.IdProducto + "','" + producto.IdReferencia + "','" + producto.IdTipoProducto + "','" + 1 + "');\">Visualizar</button>&nbsp &nbsp" +
                    "<button class='btn btn-mini btn-warning' type='button' onclick=\"JaVASCRIPT:centralTabs('" + producto.IdProducto + "','" + producto.IdReferencia + "','" + producto.IdTipoProducto + "','" + 2 + "');\">Editar</button>&nbsp &nbsp" +
                    "<button class='btn btn-mini btn-danger' type='button' onclick=\"if(confirm('¿Está seguro que desea eliminar el producto: " + producto.CodigoProducto + " ?')){centralTabs('" + producto.IdProducto + "','" + producto.IdReferencia + "','" + producto.IdTipoProducto + "','" + 3 + "');};\">Eliminar</button>"
            });
            i++;
            tablaProductos.Rows.Add(row);
        }
    }

    protected void btn_buscar_producto_Click(object sender, EventArgs e)
    {
        string codigoProducto = text_codigoProducto_Busqueda.Text;
        int tipoProducto = Convert.ToInt32(ddlTipoProducto_Busqueda.SelectedValue);
        string monto = text_monto_busqueda.Text;

        if (codigoProducto != "" && tipoProducto != 0 && monto != "")
        {
            List<Producto_ENT> productos = new Producto_BSS().listAllProductos();
            this.cargaListado(productos);
        }
        else{
            List<Producto_ENT> productos = new Producto_BSS().listProductosParametro(codigoProducto, tipoProducto, monto);
            this.cargaListado(productos);
        }
        
    }
}
