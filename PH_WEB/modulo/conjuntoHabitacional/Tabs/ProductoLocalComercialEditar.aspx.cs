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

public partial class modulo_conjuntoHabitacional_Tabs_ProductoLocalComercial : System.Web.UI.Page
{
    public string codProducto;
    public int idConjuntoHabitacional;
    public int tipoProducto;
    public string nombreProducto;
    public LocalComercial_ENT localComercialENT;
    public DetalleProducto_ENT detalleProductoENT;
    public Producto_ENT productoENT;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //ConjuntoHabitacional_ENT oConjunto = (ConjuntoHabitacional_ENT)Session["sessionConjuntoHabitacional"];
            //codProducto = oConjunto.CodigoConjunto;
            //idConjuntoHabitacional = oConjunto.IdConjuntoHabitacional;
            //this.cargarDatosConjunto(oConjunto); 
            codProducto = "13001";
            idConjuntoHabitacional = 21;

            int idTipoProducto = Convert.ToInt32(Request.QueryString["t"]);
            TipoProducto_ENT oTipoProducto = new TipoProducto_ENT();
            oTipoProducto = new TipoProducto_BSS().getTipoProducto(idTipoProducto);
            tipoProducto = oTipoProducto.IdTipoProducto;
            nombreProducto = oTipoProducto.Nombre;

            this.cargarDatosConjunto();
            this.traeDatos(Convert.ToInt32(Request.QueryString["x"]));
        }
        else 
        {
            // Código a ejecutar solo si vuelve a la pagina.
        }
    }

    protected void traeDatos(int IdProducto)
    {
        Producto_ENT oProducto = new Producto_ENT();
        oProducto.IdProducto = IdProducto;
        productoENT = new Producto_BSS().getProductoID(oProducto);

        LocalComercial_ENT oLocalComercial = new LocalComercial_ENT();
        oLocalComercial.IdLocalComercial = productoENT.IdReferencia;
        localComercialENT = new LocalComercial_BSS().getLocalComercialID(oLocalComercial);

        DetalleProducto_ENT oDetalleProducto = new DetalleProducto_ENT();
        oDetalleProducto.IdProducto = IdProducto;
        detalleProductoENT = new DetalleProducto_BSS().getProductoDetalleIdProducto(oDetalleProducto);

        this.cargaDatosCajas();
    }

    protected void cargaDatosCajas()
    {
        //Hidden
        x.Text = productoENT.IdProducto.ToString();
        y.Text = localComercialENT.IdLocalComercial.ToString();
        z.Text = detalleProductoENT.IdDetalle.ToString();

        //Local Comercial
        text_sitio.Text = localComercialENT.Sitio;

        //Detalle
        text_caracteristicas.Value = detalleProductoENT.Caracteristicas;
        ddlOrientacion.SelectedValue = Convert.ToString(detalleProductoENT.Orientacion);
        text_mConstruido.Text = Convert.ToString(detalleProductoENT.MtsConstruidos);
        text_mTerreno.Text = Convert.ToString(detalleProductoENT.MtsTerreno);
        text_direccionComunal.Text = detalleProductoENT.DireccionComunal;
        text_rolSII.Text = detalleProductoENT.RolSii;
        ddlEstadoProducto.SelectedValue = Convert.ToString(detalleProductoENT.EstadoProducto);
        text_valorUF.Text = Convert.ToString(detalleProductoENT.ValorUf);
        text_descuento.Text = Convert.ToString(detalleProductoENT.Descuento);
        text_valorFinalUF.Text = Convert.ToString(detalleProductoENT.ValorFinalUf);
        text_gastoOperacional.Text = Convert.ToString(detalleProductoENT.GastosOperacionalesUf);
    }

    //protected void cargarDatosConjunto(ConjuntoHabitacional_ENT oConjunto)
    protected void cargarDatosConjunto()
    {
        //text_codConjunto.Text = oConjunto.CodigoConjunto;
        //text_nombreConjunto.Text = oConjunto.NombreConjunto;
        //text_etapa.Text = oConjunto.Etapa;
        text_codProducto.Text = codProducto;
        text_tipoProducto.Text = nombreProducto;
    } 

    protected void btn_grabar_Click(object sender, EventArgs e)
    {
        if (this.validar())
        {
            LocalComercial_ENT local = this.datosLocal();
            local.IdLocalComercial = Convert.ToInt32(y.Text);
            new LocalComercial_BSS().updateLocalComercial(local);

            DetalleProducto_ENT oDetalleProducto = this.datosDetalleProducto();
            oDetalleProducto.IdProducto = Convert.ToInt32(x.Text);
            oDetalleProducto.IdDetalle = Convert.ToInt32(z.Text);

            new DetalleProducto_BSS().updateDetalleProducto(oDetalleProducto);

            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoListado.aspx");
        }
    }

    public DetalleProducto_ENT datosDetalleProducto()
    {
        DetalleProducto_ENT oDetalleProducto = new DetalleProducto_ENT();
        oDetalleProducto.Caracteristicas = text_caracteristicas.Value;
        oDetalleProducto.Orientacion = Convert.ToInt32(ddlOrientacion.SelectedValue);       
        oDetalleProducto.MtsConstruidos = Convert.ToDecimal(text_mConstruido.Text);
        oDetalleProducto.MtsTerreno = Convert.ToDecimal(text_mTerreno.Text);
        oDetalleProducto.DireccionComunal = text_direccionComunal.Text;
        oDetalleProducto.RolSii = text_rolSII.Text;
        oDetalleProducto.EstadoProducto = Convert.ToInt32(ddlEstadoProducto.SelectedValue);
        oDetalleProducto.ValorUf = Convert.ToDecimal(text_valorUF.Text);
        oDetalleProducto.Descuento = Convert.ToDecimal(text_descuento.Text);
        oDetalleProducto.ValorFinalUf = Convert.ToDecimal(text_valorFinalUF.Text);
        oDetalleProducto.GastosOperacionalesUf = Convert.ToDecimal(text_gastoOperacional.Text);
        return oDetalleProducto;
    }

    public LocalComercial_ENT datosLocal()
    {
        LocalComercial_ENT oLocal = new LocalComercial_ENT();
        oLocal.Sitio = text_sitio.Text;

        return oLocal;
    }

    public bool validar()
    {        
        if (!new Utilidad().validarLargo(text_sitio.Text, 1, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el sitio (mínimo 1 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(text_caracteristicas.Value, 1, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar las caracteristicas (mínimo 5 cáracteres)"));
            return false;
        }
        if (ddlOrientacion.SelectedIndex.Equals("0"))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe seleccionar la orientacion de la casa"));
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
