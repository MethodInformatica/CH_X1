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
    public EstacionamientoBodega_ENT detalleEstacionamientoBodegaENT;
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
        }
    }

    protected void traeDatos(int IdProducto)
    {
        Producto_ENT oProducto = new Producto_ENT();
        oProducto.IdProducto = IdProducto;
        productoENT = new Producto_BSS().getProductoID(oProducto);

        EstacionamientoBodega_ENT oEstaBode = new EstacionamientoBodega_ENT();
        oEstaBode.IdEstacionamientoBodega = productoENT.IdReferencia;
        detalleEstacionamientoBodegaENT = new EstacionamientoBodega_BSS().getEstacionamientoBodegaID(oEstaBode);

        DetalleProducto_ENT oDetalleProducto = new DetalleProducto_ENT();
        oDetalleProducto.IdProducto = IdProducto;
        detalleProductoENT = new DetalleProducto_BSS().getProductoDetalleIdProducto(oDetalleProducto);

        this.cargaDatosCajas();
    }

    protected void cargaDatosCajas()
    {
        //Hidden
        x.Text = productoENT.IdProducto.ToString();
        y.Text = detalleEstacionamientoBodegaENT.IdEstacionamientoBodega.ToString();
        z.Text = detalleProductoENT.IdDetalle.ToString();

        //Estacionamiento/Bodega
        text_nEstaBode.Text = detalleEstacionamientoBodegaENT.NumeroEstBod;
        
        //Detalle
        text_caracteristicas.Value = detalleProductoENT.Caracteristicas;
        text_mTerreno.Text = Convert.ToString(detalleProductoENT.MtsTerreno);
        text_direccionComunal.Text = detalleProductoENT.DireccionComunal;
        text_rolSII.Text = detalleProductoENT.RolSii;
        ddlEstadoProducto.SelectedValue = Convert.ToString(detalleProductoENT.EstadoProducto);
        text_valorUF.Text = Convert.ToString(detalleProductoENT.ValorUf);
        text_descuento.Text = Convert.ToString(detalleProductoENT.Descuento);
        text_valorFinalUF.Text = Convert.ToString(detalleProductoENT.ValorFinalUf);
        text_gastoOperacional.Text = Convert.ToString(detalleProductoENT.GastosOperacionalesUf);
    }

    protected void cargarDatosConjunto()
    {
        //text_codConjunto.Text = oConjunto.CodigoConjunto;
        //text_nombreConjunto.Text = oConjunto.NombreConjunto;
        //text_etapa.Text = oConjunto.Etapa;
        text_tipoProducto.Text = nombreProducto;
    } 

}
