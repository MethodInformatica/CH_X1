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

public partial class views_ingresoConjuntoHabitacional : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Usuario_ENT usuario = (Usuario_ENT)Session["usuario"];
            //ConjuntoHabitacional_ENT conjuntoHabitacional = (ConjuntoHabitacional_BSS)Session["conjuntohabitacional"];
            //conjuntoHabitacional.IdConjuntoHabitacional;
        }
        else
        {

        }
    }

    protected void btn_grabar_Click(object sender, EventArgs e)
    {
        ConjuntoHabitacional_ENT oConjunto = new ConjuntoHabitacional_ENT();
        bool flag = this.validarIngreso();
        if (flag == true)
        {
            oConjunto = this.datosConjuntoHabitacional();
            oConjunto = new ConjuntoHabitacional_BSS().insertConjuntoHabitacional(oConjunto);
            Session["sessionConjuntoHabitacional"] = oConjunto;
            Response.Redirect("~/views/conjuntoHabitacionalPestanas.aspx");
        }
    }

    public ConjuntoHabitacional_ENT datosConjuntoHabitacional()
    {

        ConjuntoHabitacional_ENT oConjunto = new ConjuntoHabitacional_ENT();

        oConjunto.CodigoConjunto = Convert.ToString(text_codigo_conjunto.Text);
        oConjunto.NombreConjunto = Convert.ToString(text_nombre_conjunto.Text);
        oConjunto.Etapa = Convert.ToString(text_etapa.Text);
        oConjunto.IdComunaConjunto = Convert.ToInt32(drop_id_comuna_conjunto.SelectedValue);
        oConjunto.DireccionConjunto = Convert.ToString(text_direccion_conjunto.Text);
        oConjunto.RutConstructora = Convert.ToString(text_rut_constructora.Text);
        oConjunto.NombreConstructora = Convert.ToString(text_nombre_constructora.Text);
        oConjunto.RutEmpresaVendedora = Convert.ToString(text_rut_empresa_vendedora.Text);
        oConjunto.NombreEmpresaVendedora = Convert.ToString(text_nombre_empresa_vendedora.Text);
        oConjunto.RepresentanteEmpresaVendedora = Convert.ToString(text_nombre_representante.Text);
        oConjunto.IdComunaEmpresaVendedora = Convert.ToInt32(drop_id_comuna_empresa_vendedora.SelectedValue);
        oConjunto.DireccionEmpresaVendedora = Convert.ToString(text_direccion_empresa_vendedora.Text);
        oConjunto.AreaEmpresaVendedora = Convert.ToString(text_area_empresa_vendedora.Text);
        oConjunto.TelefonoEmpresaVendedora = Convert.ToString(text_telefono_empresa_vendedora.Text);
        oConjunto.EmailEmpresaVendedora = Convert.ToString(text_email_empresa_vendedora.Text);
        //oConjunto.FechaContrato = text_fecha_contrato.Equals("") ? DateTime.Today : Convert.ToDateTime(text_fecha_contrato.Text); ;
        //oConjunto.FechaTerminoConstruccion = text_fecha_termino_construccion.Equals("") ? DateTime.Today : Convert.ToDateTime(text_fecha_termino_construccion.Text);
        //oConjunto.FechaRecepcionMunicipal = text_fecha_recepcion_municipal.Equals("") ? DateTime.Today : Convert.ToDateTime(text_fecha_recepcion_municipal.Text);
        //oConjunto.FechaRecepcionProhogar = text_fecha_recepcion_prohogar.Equals("") ? DateTime.Today : Convert.ToDateTime(text_fecha_recepcion_prohogar.Text); 

        return oConjunto;

    }

    public bool validarIngreso()
    {

        if (text_codigo_conjunto.Text.Equals(""))
        {
            string msg = "Ingrese el código del conjunto!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorConjuntoHabitacional.Visible = true;
            text_codigo_conjunto.Focus();
            return false;
        }
        else { errorConjuntoHabitacional.Visible = false; }

        if (text_nombre_conjunto.Text.Equals(""))
        {
            string msg = "Ingrese el nombre del conjunto!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));

            errorConjuntoHabitacional.Visible = true;
            text_nombre_conjunto.Focus();
            return false;
        }
        else { errorConjuntoHabitacional.Visible = false; }

        if (drop_region.SelectedValue == "0")
        {
            string msg = "Seleccione una región!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorDireccionConjuntoHabitacional.Visible = true;
            drop_region.Focus();
            return false;
        }
        else { errorDireccionConjuntoHabitacional.Visible = false; }

        if (drop_region.SelectedValue == "0")
        {
            string msg = "Seleccione una región!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorDireccionConjuntoHabitacional.Visible = true;
            drop_region.Focus();
            return false;
        }
        else { errorDireccionConjuntoHabitacional.Visible = false; }

        if (drop_ciudad.SelectedValue == "0")
        {
            string msg = "Seleccione una ciudad!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorDireccionConjuntoHabitacional.Visible = true;
            drop_ciudad.Focus();
            return false;
        }
        else { errorDireccionConjuntoHabitacional.Visible = false; }

        if (drop_id_comuna_conjunto.SelectedValue == "0")
        {
            string msg = "Seleccione una comuna!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorDireccionConjuntoHabitacional.Visible = true;
            drop_id_comuna_conjunto.Focus();
            return false;
        }
        else { errorDireccionConjuntoHabitacional.Visible = false; }

        if (text_direccion_conjunto.Text.Equals(""))
        {
            string msg = "Ingrese la dirección del conjunto!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorConjuntoHabitacional.Visible = true;
            text_direccion_conjunto.Focus();
            return false;
        }
        else { errorConjuntoHabitacional.Visible = false; }

        return true;

    }
}
