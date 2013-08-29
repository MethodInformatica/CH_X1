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
using PH_BSS;

public partial class modulo_conjuntoHabitacional_Tabs_ProductoCasa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ConjuntoHabitacional_ENT oConjunto = (ConjuntoHabitacional_ENT)Session["sessionConjuntoHabitacional"];
        //this.cargarDatosConjunto(oConjunto); 
        this.cargarDatosConjunto(); 
    }

    //protected void cargarDatosConjunto(ConjuntoHabitacional_ENT oConjunto)
    protected void cargarDatosConjunto()
    {
        //text_codConjunto.Text = oConjunto.CodigoConjunto;
        //text_nombreConjunto.Text = oConjunto.NombreConjunto;
        //text_etapa.Text = oConjunto.Etapa;
        text_codProducto.Text = "";
        text_tipoProducto.Text = "CASA";
    } 

    protected void btn_grabar_Click(object sender, EventArgs e)
    {
        if (this.validar())
        {
            Casa_ENT casa = this.datosCasa();
            casa = new Casa_BSS().insertCasa(casa);
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoListado.aspx");
        }
    }

    public Casa_ENT datosCasa()
    {
        Casa_ENT oCasa = new Casa_ENT();
        oCasa.Manzana = text_manzana.Text;
        oCasa.Sitio = text_sitio.Text;
        oCasa.CasaEsquina = Convert.ToInt32(ddlCasaEsquina.SelectedValue);
        oCasa.Modelo = text_modelo.Text;
        oCasa.ODetalleProducto.Caracteristicas = text_caracteristica.Text;
        oCasa.ODetalleProducto.Deslines = text_deslindes.Text;
        oCasa.ODetalleProducto.Orientacion = Convert.ToInt32(ddlOrientacion.SelectedValue);
        oCasa.ODetalleProducto.Direccion = text_direccion.Text;
        oCasa.ODetalleProducto.MtsConstruidos = Convert.ToDecimal(text_mConstruido.Text);
        oCasa.ODetalleProducto.MtsTerreno = Convert.ToDecimal(text_mTerreno.Text);
        oCasa.ODetalleProducto.DireccionComunal = text_direccionComunal.Text;
        oCasa.ODetalleProducto.RolSii = text_rolSII.Text;
        oCasa.ODetalleProducto.ValorUf = Convert.ToDecimal(text_valorUF.Text);
        oCasa.ODetalleProducto.Descuento = Convert.ToDecimal(text_descuento.Text);
        oCasa.ODetalleProducto.ValorFinalUf = Convert.ToDecimal(text_valorFinalUF.Text);
        oCasa.ODetalleProducto.GastosOperacionalesUf = Convert.ToDecimal(text_gastoOperacional.Text);
        return oCasa;
    }

    public bool validar()
    {
        if (!new Utilidad().validarLargo(text_manzana.Text, 5, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar la manzana (mínimo 5 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_sitio.Text, 5, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el sitio (mínimo 5 cáracteres)"));
            return false;
        }
        if (ddlCasaEsquina.SelectedIndex.Equals("0"))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe seleccionar si corresponde a cada esquina"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_modelo.Text, 5, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el nombre del modelo de la casa (mínimo 5 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_caracteristica.Text, 5, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar las caracteristicas de la casa (mínimo 5 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_deslindes.Text, 5, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar los deslindes de la casa (mínimo 5 cáracteres)"));
            return false;
        }
        if (ddlOrientacion.SelectedIndex.Equals("0"))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe seleccionar la orientacion de la casa"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_direccion.Text, 5, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar la dirección (mínimo 5 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_mConstruido.Text, 1, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar los metros construidos (mínimo 5 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_mTerreno.Text, 1, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar los metros correspondientes al terreno (mínimo 5 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_direccionComunal.Text, 5, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar la dirección comunal (mínimo 5 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_rolSII.Text, 1, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el Rol de SII (mínimo 5 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_valorUF.Text, 1, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el valor de la UF (mínimo 5 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_descuento.Text, 1, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el valor del descuento (mínimo 5 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_valorFinalUF.Text, 1, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar valor final en UF (mínimo 5 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_gastoOperacional.Text, 1, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar los gastos operacionales (mínimo 5 cáracteres)"));
            return false;
        }
        return true;
    }

}
