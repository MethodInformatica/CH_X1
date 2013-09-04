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

public partial class modulo_conjuntoHabitacional_Tabs_ProductoEstacionamientoBodega : System.Web.UI.Page
{    
    public int idConjuntoHabitacional;
    public int tipoProducto;
    public string nombreProducto;
    public string codigo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //ConjuntoHabitacional_ENT oConjunto = (ConjuntoHabitacional_ENT)Session["sessionConjuntoHabitacional"];
        //codProducto = oConjunto.CodigoConjunto;
        //idConjuntoHabitacional = oConjunto.IdConjuntoHabitacional;
        //this.cargarDatosConjunto(oConjunto); 
        idConjuntoHabitacional = 21;

        int idTipoProducto = Convert.ToInt32(Request.QueryString["t"]);
        TipoProducto_ENT oTipoProducto = new TipoProducto_ENT();
        oTipoProducto = new TipoProducto_BSS().getTipoProducto(idTipoProducto);
        tipoProducto = oTipoProducto.IdTipoProducto;
        nombreProducto = oTipoProducto.Nombre;
        codigo = oTipoProducto.Codigo;

        this.cargarDatosConjunto(); 
    }

    protected void cargarDatosConjunto()
    {
        //text_codConjunto.Text = oConjunto.CodigoConjunto;
        //text_nombreConjunto.Text = oConjunto.NombreConjunto;
        //text_etapa.Text = oConjunto.Etapa;
        text_tipoProducto.Text = nombreProducto;
    } 

    protected void btn_grabar_Click(object sender, EventArgs e)
    {
        if (this.validar())
        {
            EstacionamientoBodega_ENT oEstaBode = new EstacionamientoBodega_BSS().generaCodigo(codigo);

            EstacionamientoBodega_ENT estaBode = this.datosEstaBode();
            estaBode.IdEstacionamientoBodega = oEstaBode.IdEstacionamientoBodega;
            new EstacionamientoBodega_BSS().updateEstacionamientoBodega(estaBode);

            Producto_ENT oProducto = this.datosProducto(estaBode.IdEstacionamientoBodega);
            oProducto = new Producto_BSS().insert(oProducto);
            
            DetalleProducto_ENT oDetalleProducto = this.datosDetalleProducto();
            oDetalleProducto.IdProducto = oProducto.IdProducto;

            oDetalleProducto = new DetalleProducto_BSS().insertDetalleProducto(oDetalleProducto);

            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoListado.aspx");
        }

    }

    public Producto_ENT datosProducto(int idEstaBod)
    {
        Producto_ENT oProducto = new Producto_ENT();
        oProducto.IdTipoProducto = tipoProducto;
        oProducto.IdConjuntoHabitacional = idConjuntoHabitacional;
        oProducto.RutCliente = "";//Vacio
        oProducto.IdReferencia = idEstaBod;

        return oProducto;
    }

    public DetalleProducto_ENT datosDetalleProducto()
    {
        DetalleProducto_ENT oDetalleProducto = new DetalleProducto_ENT();
        oDetalleProducto.MtsTerreno = Convert.ToDecimal(text_mTerreno.Text);
        oDetalleProducto.DireccionComunal = text_direccionComunal.Text;
        oDetalleProducto.RolSii = text_rolSII.Text;
        oDetalleProducto.Caracteristicas = text_caracteristicas.Value;
        oDetalleProducto.EstadoProducto = Convert.ToInt32(ddlEstadoProducto.SelectedValue);
        oDetalleProducto.ValorUf = Convert.ToDecimal(text_valorUF.Text);
        oDetalleProducto.Descuento = Convert.ToDecimal(text_descuento.Text);
        oDetalleProducto.ValorFinalUf = Convert.ToDecimal(text_valorFinalUF.Text);
        oDetalleProducto.GastosOperacionalesUf = Convert.ToDecimal(text_gastoOperacional.Text);
        return oDetalleProducto;
    }

    public EstacionamientoBodega_ENT datosEstaBode()
    {
        EstacionamientoBodega_ENT oEstaBode = new EstacionamientoBodega_ENT();
        oEstaBode.NumeroEstBod = text_nEstaBode.Text;
        return oEstaBode;
    }

    public bool validar()
    {
        if (!new Utilidad().validarLargo(text_nEstaBode.Text, 1, 4))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar los metros correspondientes al terreno (mínimo 5 cáracteres)"));
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
        if (!new Utilidad().validarLargo(text_caracteristicas.Value, 5, 450))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el Rol de SII (mínimo 5 cáracteres)"));
            return false;
        }
        if (ddlEstadoProducto.SelectedIndex.Equals("0"))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe seleccionar el estado del producto"));
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
