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
using System.Collections.Generic;

public partial class modulo_conjuntoHabitacional_Agregar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            new Utilidad().cargarRegion(ddlRegionConjunto, "0");
            new Utilidad().cargarRegion(ddlRegionVendedora, "0");
        }
        else
        {

        }
    }

    public ConjuntoHabitacional_ENT datosConjuntoHabitacional()
    {

        ConjuntoHabitacional_ENT oConjunto = new ConjuntoHabitacional_ENT();
        oConjunto.CodigoConjunto = txtCodigoConjunto.Text;
        oConjunto.NombreConjunto = Convert.ToString(txtNombreConjunto.Text);
        oConjunto.Etapa = Convert.ToString(txtEtapa.Text);
        oConjunto.IdComunaConjunto = Convert.ToInt32(ddlComuna.SelectedValue);
        oConjunto.DireccionConjunto = Convert.ToString(txtDireccionConjunto.Text);
        oConjunto.RutConstructora = Convert.ToString(txtRutConstructora.Text);
        oConjunto.NombreConstructora = Convert.ToString(txtNombreConstructora.Text);
        oConjunto.RutEmpresaVendedora = Convert.ToString(txtRutVendedora.Text);
        oConjunto.NombreEmpresaVendedora = Convert.ToString(txtNombreVendedora.Text);
        oConjunto.RepresentanteEmpresaVendedora = Convert.ToString(txtNombreRepresentateVendedora.Text);
        oConjunto.IdComunaEmpresaVendedora = Convert.ToInt32(ddlComunaVendedora.SelectedValue);
        oConjunto.DireccionEmpresaVendedora = Convert.ToString(txtDireccionVendedora.Text);
        oConjunto.AreaEmpresaVendedora = Convert.ToString(txtCodigoFonoVendedora.Text);
        oConjunto.TelefonoEmpresaVendedora = Convert.ToString(txtFonoVendedora.Text);
        oConjunto.EmailEmpresaVendedora = Convert.ToString(txtMailVendedora.Text);
        oConjunto.FechaContrato = txtFechaContrato.Text.Equals("") ? new DateTime(1900,1,1): Convert.ToDateTime(txtFechaContrato.Text); ;
        oConjunto.FechaTerminoConstruccion = txtFechaTermino.Text.Equals("") ? new DateTime(1900, 1, 1) : Convert.ToDateTime(txtFechaTermino.Text);
        oConjunto.FechaRecepcionMunicipal = txtFechaRecepcionMunicipal.Text.Equals("") ? new DateTime(1900, 1, 1) : Convert.ToDateTime(txtFechaRecepcionMunicipal.Text);
        oConjunto.FechaRecepcionProhogar = txtFechaRecepcionProHogar.Text.Equals("") ? new DateTime(1900, 1, 1) : Convert.ToDateTime(txtFechaRecepcionProHogar.Text); 
        return oConjunto;

    }

    private bool validar()
    {
        if (!new Utilidad().validarLargo(txtCodigoConjunto.Text, 3, 10))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el código del conjunto habitacional (mínimo 3 cáracteres)"));
            return false;
        }
        if (!new Utilidad().validarLargo(txtNombreConjunto.Text, 5, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el nombre del conjunto habitacional (mínimo 5 cáracteres)"));
             return false;
        }
        if (ddlRegionConjunto.SelectedValue.Equals("0"))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe seleccionar una región para el Conjunto Habitacional"));
            return false;
        }
        if (ddlCiudadConjunto.SelectedValue.Equals("0"))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe seleccionar una Ciudad para el Conjunto Habitacional"));
            return false;
        }
        if (ddlComuna.SelectedValue.Equals("0"))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe seleccionar una Comuna para el Conjunto Habitacional"));
            return false;
        }
        if (!new Utilidad().validarLargo(txtDireccionConjunto.Text, 10, 50))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar la dirección del conjunto habitacional (mínimo 10 cáracteres)"));
            return false;
        }
        if(!string.IsNullOrEmpty(txtRutConstructora.Text))
        {
            if (!new Utilidad().validarRut(txtRutConstructora.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("el Rut de la empresa Constructora no es válido"));
                return false;
            }
        }
        if(!string.IsNullOrEmpty(txtRutVendedora.Text))
        {
            if (!new Utilidad().validarRut(txtRutVendedora.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("EL Rut de la empresa Vendedora no es válido"));
                return false;
            }
        }
        if (!string.IsNullOrEmpty(txtFechaRecepcionProHogar.Text))
        {
            if (!new Utilidad().validarFecha(txtFechaRecepcionProHogar.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("La fecha de recepción ProHogar no es válido"));
                return false;
            }
        }
        if (!string.IsNullOrEmpty(txtFechaTermino.Text))
        {
            if (!new Utilidad().validarFecha(txtFechaTermino.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("La fecha de término no es válido"));
                return false;
            }
        }
        if (!string.IsNullOrEmpty(txtFechaRecepcionMunicipal.Text))
        {
            if (!new Utilidad().validarFecha(txtFechaRecepcionMunicipal.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("La fecha de recepción municipal no es válido"));
                return false;
            }
        }
        if (!string.IsNullOrEmpty(txtFechaContrato.Text))
        {
            if (!new Utilidad().validarFecha(txtFechaContrato.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("La fecha de contrato no es válido"));
                return false;
            }
        }
        return true;
        
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        if (this.validar())
        {
            ConjuntoHabitacional_ENT conjunto = this.datosConjuntoHabitacional();
            if (new ConjuntoHabitacional_BSS().getByCodigo(conjunto.CodigoConjunto)==null)
            {
                conjunto = new ConjuntoHabitacional_BSS().insertConjuntoHabitacional(conjunto);
                Session["conjuntoHabitacionalSeleccionado"] = conjunto;
                Response.Redirect("~/modulo/conjuntoHabitacional/Listado.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("El código del conjunto habitacional ya se encuentra registrado"));
            }
        }
    }
    protected void ddlRegionConjunto_SelectedIndexChanged(object sender, EventArgs e)
    {
        new Utilidad().cargarCiudad(ddlCiudadConjunto, ddlRegionConjunto.SelectedValue,"0");
    }
    protected void ddlCiudadConjunto_SelectedIndexChanged(object sender, EventArgs e)
    {
        new Utilidad().cargarComuna(ddlComuna, ddlCiudadConjunto.SelectedValue, "0");
    }
    protected void ddlRegionVendedora_SelectedIndexChanged(object sender, EventArgs e)
    {
        new Utilidad().cargarCiudad(ddlCiudadVendedora, ddlRegionVendedora.SelectedValue, "0");
    }
    protected void ddlCiudadVendedora_SelectedIndexChanged(object sender, EventArgs e)
    {
        new Utilidad().cargarComuna(ddlComunaVendedora, ddlCiudadVendedora.SelectedValue, "0");
    }
    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/modulo/conjuntoHabitacional/Agregar.aspx");
    }
}
