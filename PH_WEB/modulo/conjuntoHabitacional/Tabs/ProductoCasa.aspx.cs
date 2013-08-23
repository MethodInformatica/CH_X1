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
            DetalleProducto_ENT detalleProducto = this.datosDetalleProducto();
            detalleProducto.IdProducto = casa.IdCasa;

            

            casa = new Casa_BSS().insertCasa(casa);
            detalleProducto = new DetalleProducto_BSS().insertDetalleProducto(detalleProducto);

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
        
        return oCasa;
    }

    public DetalleProducto_ENT datosDetalleProducto() 
    {
        DetalleProducto_ENT oDetalleProducto = new DetalleProducto_ENT();
        oDetalleProducto.Caracteristicas = text_caracteristica.Text;
        oDetalleProducto.Deslines = text_deslindes.Text;
        oDetalleProducto.Orientacion = Convert.ToInt32(ddlOrientacion.SelectedValue);
        oDetalleProducto.Direccion = text_direccion.Text;
        oDetalleProducto.MtsConstruidos = Convert.ToDecimal(text_mConstruido.Text);
        oDetalleProducto.MtsTerreno = Convert.ToDecimal(text_mTerreno.Text);
        oDetalleProducto.DireccionComunal = text_direccionComunal.Text;
        oDetalleProducto.RolSii = text_rolSII.Text;
        oDetalleProducto.ValorUf = Convert.ToDecimal(text_valorUF.Text);
        oDetalleProducto.Descuento = Convert.ToDecimal(text_descuento.Text);
        oDetalleProducto.ValorFinalUf = Convert.ToDecimal(text_valorFinalUF.Text);
        oDetalleProducto.GastosOperacionalesUf = Convert.ToDecimal(text_gastoOperacional.Text);
        return oDetalleProducto
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
