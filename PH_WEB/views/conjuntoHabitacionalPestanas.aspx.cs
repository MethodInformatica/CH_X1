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
using System.Web.Services;

public partial class views_conjuntoHabitacionalPestanas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ConjuntoHabitacional_ENT oConjunto = (ConjuntoHabitacional_ENT)Session["sessionConjuntoHabitacional"];
        //this.cargarDatosConjunto(oConjunto); 
    }

    public void cargarDatosConjunto(ConjuntoHabitacional_ENT oConjunto)
    {
        text_codigo_conjunto.Text = oConjunto.CodigoConjunto;
        text_nombre_conjunto.Text = oConjunto.NombreConjunto;
        text_etapa.Text = oConjunto.Etapa;
        drop_id_comuna_conjunto.SelectedValue = Convert.ToString(oConjunto.IdComunaConjunto);
        text_direccion_conjunto.Text = oConjunto.DireccionConjunto;
        text_rut_constructora.Text = oConjunto.RutConstructora;
        text_nombre_constructora.Text = oConjunto.NombreConstructora;
        text_rut_empresa_vendedora.Text = oConjunto.RutEmpresaVendedora;
        text_nombre_empresa_vendedora.Text = oConjunto.NombreEmpresaVendedora;
        text_nombre_representante.Text = oConjunto.RepresentanteEmpresaVendedora;
        drop_id_comuna_empresa_vendedora.SelectedValue = Convert.ToString(oConjunto.IdComunaEmpresaVendedora);
        text_direccion_empresa_vendedora.Text = oConjunto.DireccionEmpresaVendedora;
        text_area_empresa_vendedora.Text = oConjunto.AreaEmpresaVendedora;
        text_telefono_empresa_vendedora.Text = oConjunto.TelefonoEmpresaVendedora;
        text_email_empresa_vendedora.Text = oConjunto.EmailEmpresaVendedora;
        text_fecha_contrato.Value = Convert.ToString(oConjunto.FechaContrato);
        text_fecha_termino_construccion.Value = Convert.ToString(oConjunto.FechaTerminoConstruccion);
        text_fecha_recepcion_municipal.Value = Convert.ToString(oConjunto.FechaRecepcionMunicipal);
        text_fecha_recepcion_prohogar.Value = Convert.ToString(oConjunto.FechaRecepcionProhogar); 

    }

    
  
    public static string cargarDocAsociada(string msg) {
        String result = "Resultado : "+ DateTime.Now.ToString();
        return result;
    }
    
    

}
