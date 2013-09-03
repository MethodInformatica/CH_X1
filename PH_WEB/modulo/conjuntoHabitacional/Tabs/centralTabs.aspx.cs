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
using PH_BSS;
using PH_ENT;

public partial class modulo_conjuntoHabitacional_Tabs_editarTabs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String IdProducto = Request.QueryString["x"];
        String IdReferencia = Request.QueryString["y"];
        String IdTipoProducto = Request.QueryString["z"];
        String accion = Request.QueryString["i"];

        if (accion == "1")
        {
            this.visualizarDatos(IdProducto, IdReferencia, IdTipoProducto);
        }
        else if (accion == "2")
        {
            this.editarDatos(IdProducto, IdReferencia, IdTipoProducto);
        }
        else if (accion == "3")
        {
            this.eliminarDatos(IdProducto, IdReferencia, IdTipoProducto);
        }
    }

    protected void visualizarDatos(String IdProducto, String IdReferencia, String IdTipoProducto)
    {
        if (IdTipoProducto == "1")
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoCasaVisualizar.aspx?x=" + IdProducto);
        }
        else if (IdTipoProducto == "2")
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoDeptoVisualizar.aspx?x=" + IdProducto);
        }
        else if (IdTipoProducto == "3")
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoEstacionamientoBodegaVisualizar.aspx?x=" + IdProducto);
        }
        else if (IdTipoProducto == "4")
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoLocalComercialVisualizar.aspx?x=" + IdProducto);
        }
    }

    protected void editarDatos(String IdProducto, String IdReferencia, String IdTipoProducto)
    {
        if (IdTipoProducto == "1") {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoCasaEditar.aspx?x=" + IdProducto);
        }
        else if (IdTipoProducto == "2") {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoDeptoEditar.aspx?x=" + IdProducto);
        }
        else if (IdTipoProducto == "3") {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoEstacionamientoBodegaEditar.aspx?x=" + IdProducto);
        }
        else if (IdTipoProducto == "4") {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoLocalComercialEditar.aspx?x=" + IdProducto);
        }
    }

    protected void eliminarDatos(String IdProducto, String IdReferencia, String IdTipoProducto)
    {
        DetalleProducto_ENT oDetalleProducto = new DetalleProducto_ENT();
        oDetalleProducto.IdProducto = Convert.ToInt32(IdProducto);
        new DetalleProducto_BSS().deleteDetalleProducto(oDetalleProducto);

        Casa_ENT oCasa = new Casa_ENT();
        oCasa.IdCasa = Convert.ToInt32(IdReferencia);
        new Casa_BSS().deleteCasa(oCasa);

        Producto_ENT oProducto = new Producto_ENT();
        oProducto.IdProducto = Convert.ToInt32(IdProducto);
        new Producto_BSS().deleteProducto(oProducto);

        Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoListado.aspx");
    }

    

}
