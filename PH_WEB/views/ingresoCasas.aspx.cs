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

public partial class views_ingresoCasas : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Usuario_ENT usuario = (Usuario_BSS)Session["usuario"];
            //ConjuntoHabitacional_ENT conjuntoHabitacional = (ConjuntoHabitacional_BSS)Session["conjuntohabitacional"];
            //conjuntoHabitacional.IdConjuntoHabitacional;
        }
        else
        {

        }
    }

    protected void btn_grabar_Click(object sender, EventArgs e)
    {
        Casa_ENT oCasa = new Casa_BSS().insertCasa(this.datosCasa());
        this.datosDetalleProducto().IdProducto = oCasa.IdCasa;
        DetalleProducto_ENT oDetalleProducto = new DetalleProducto_BSS().insertDetalleProducto(this.datosDetalleProducto());
    }

    public Casa_ENT datosCasa()
    {
        Casa_ENT casa = new Casa_ENT();
        casa.Manzana = text_manzana.Text;
        casa.Sitio = text_sitio.Text;
        casa.CasaEsquina = Convert.ToInt32(text_casaEsquina.Text);
        casa.Modelo = text_modelo.Text;
        return casa;
    }

    public Cliente_ENT datosClientes()
    {
        Cliente_ENT cliente = new Cliente_ENT();
        cliente.Rut = text_rutCliente.Text;
        cliente.Nombre = text_nombreCliente.Text;
        cliente.Email = text_emailCliente.Text;
        cliente.Telefono = text_telefonoCliente.Text;
        return cliente;
    }

    public DetalleProducto_ENT datosDetalleProducto()
    {
        DetalleProducto_ENT detalleProducto = new DetalleProducto_ENT();
        detalleProducto.Caracteristicas = text_caracteristica.Text;
        detalleProducto.Deslines = text_deslindes.Text;
        detalleProducto.Orientacion = Convert.ToInt32(drop_orientacion.Text);
        detalleProducto.DireccionComunal = text_direccion.Text;
        detalleProducto.MtsConstruidos = Convert.ToDecimal(text_mConstruido.Text);
        detalleProducto.MtsTerreno = Convert.ToDecimal(text_mTerreno.Text);
        detalleProducto.DireccionComunal = text_direccionComunal.Text;
        detalleProducto.RolSii = text_rolSII.Text;
        detalleProducto.ValorUf = Convert.ToDecimal(text_valorUF.Text);
        detalleProducto.Descuento = Convert.ToDecimal(text_descuento.Text);
        detalleProducto.ValorFinalUf = Convert.ToDecimal(text_valorFinalUF.Text);
        detalleProducto.GastosOperacionalesUf = Convert.ToDecimal(text_gastoOperacional.Text);
        return detalleProducto;
    }

}
