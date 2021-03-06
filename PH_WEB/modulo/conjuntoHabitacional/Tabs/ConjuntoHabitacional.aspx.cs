﻿using System;
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

public partial class modulo_conjuntoHabitacional_Tabs_ConjuntoHabitacional : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ConjuntoHabitacional_ENT conjunto = (ConjuntoHabitacional_ENT)Session["conjuntoHabitacionalSeleccionado"];
            conjunto = new ConjuntoHabitacional_BSS().getByCodigo(conjunto.CodigoConjunto);
            this.cargarFormulario(conjunto);
        }
        else
        {
            ConjuntoHabitacional_ENT conjunto = (ConjuntoHabitacional_ENT)Session["conjuntoHabitacionalSeleccionado"];
            txtCodigoConjunto.Text = conjunto.CodigoConjunto;
            txtNombreConjunto.Text = conjunto.NombreConjunto;
            txtEtapa.Text = conjunto.Etapa;
        }
    }

    private void cargarFormulario(ConjuntoHabitacional_ENT conjunto)
    {
        txtCodigoConjunto.Text = conjunto.CodigoConjunto;
        txtNombreConjunto.Text= conjunto.NombreConjunto;
        txtEtapa.Text = conjunto.Etapa;
        txtDireccionConjunto.Text= conjunto.DireccionConjunto;
        txtRutConstructora.Text= conjunto.RutConstructora;
        txtNombreConstructora.Text= conjunto.NombreConstructora;
        txtRutVendedora.Text= conjunto.RutEmpresaVendedora;
        txtNombreVendedora.Text= conjunto.NombreEmpresaVendedora;
        txtNombreRepresentateVendedora.Text= conjunto.RepresentanteEmpresaVendedora;
        txtDireccionVendedora.Text = conjunto.DireccionEmpresaVendedora;
        txtCodigoFonoVendedora.Text = conjunto.AreaEmpresaVendedora;
        txtFonoVendedora.Text = conjunto.TelefonoEmpresaVendedora;
        txtMailVendedora.Text = conjunto.EmailEmpresaVendedora;
        txtFechaContrato.Text= conjunto.FechaContrato.Year.Equals(1900)?"":conjunto.FechaContrato.ToShortDateString();
        txtFechaTermino.Text= conjunto.FechaTerminoConstruccion.Year.Equals(1900)?"":conjunto.FechaTerminoConstruccion.ToShortDateString();
        txtFechaRecepcionMunicipal.Text= conjunto.FechaRecepcionMunicipal.Year.Equals(1900)?"":conjunto.FechaRecepcionMunicipal.ToShortDateString();
        txtFechaRecepcionProHogar.Text= conjunto.FechaRecepcionProhogar.Year.Equals(1900)?"":conjunto.FechaRecepcionProhogar.ToShortDateString();
        new Utilidad().cargarRegion(ddlRegionConjunto, conjunto.ComunaConjunto.Ciudad.Region.IdRegion.ToString());
        new Utilidad().cargarCiudad(ddlCiudadConjunto, conjunto.ComunaConjunto.Ciudad.Region.IdRegion.ToString(),conjunto.ComunaConjunto.Ciudad.IdCiudad.ToString());
        new Utilidad().cargarComuna(ddlComuna, conjunto.ComunaConjunto.Ciudad.IdCiudad.ToString(), conjunto.ComunaConjunto.IdComuna.ToString());

        new Utilidad().cargarRegion(ddlRegionVendedora, conjunto.ComunaVendedora.Ciudad.Region.IdRegion.ToString());
        new Utilidad().cargarCiudad(ddlCiudadVendedora, conjunto.ComunaVendedora.Ciudad.Region.IdRegion.ToString(), conjunto.ComunaVendedora.Ciudad.IdCiudad.ToString());
        new Utilidad().cargarComuna(ddlComunaVendedora, conjunto.ComunaVendedora.Ciudad.IdCiudad.ToString(), conjunto.ComunaVendedora.IdComuna.ToString());
    }
    public ConjuntoHabitacional_ENT datosConjuntoHabitacional()
    {

        ConjuntoHabitacional_ENT oConjunto = new ConjuntoHabitacional_ENT();
        oConjunto.CodigoConjunto = "";
        oConjunto.NombreConjunto = Convert.ToString(txtNombreConjunto.Text);
        oConjunto.Etapa = Convert.ToString(txtEtapa.Text);
        oConjunto.ComunaConjunto.IdComuna = Convert.ToInt32(ddlComuna.SelectedValue);
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
        oConjunto.FechaContrato = txtFechaContrato.Text.Equals("") ? new DateTime(1900, 1, 1) : Convert.ToDateTime(txtFechaContrato.Text); ;
        oConjunto.FechaTerminoConstruccion = txtFechaTermino.Text.Equals("") ? new DateTime(1900, 1, 1) : Convert.ToDateTime(txtFechaTermino.Text);
        oConjunto.FechaRecepcionMunicipal = txtFechaRecepcionMunicipal.Text.Equals("") ? new DateTime(1900, 1, 1) : Convert.ToDateTime(txtFechaRecepcionMunicipal.Text);
        oConjunto.FechaRecepcionProhogar = txtFechaRecepcionProHogar.Text.Equals("") ? new DateTime(1900, 1, 1) : Convert.ToDateTime(txtFechaRecepcionProHogar.Text);
        return oConjunto;

    }

    private bool validar()
    {
        if (!new Utilidad().validarLargo(txtNombreConjunto.Text, 5, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el nombre del conjunto habitacional (mínimo 5 cáracteres)"));
            return false;
        }
        if (ddlRegionConjunto.SelectedIndex.Equals("0"))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe seleccionar una región para el Conjunto Habitacional"));
            return false;
        }
        if (ddlCiudadConjunto.SelectedIndex.Equals("0"))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe seleccionar una Ciudad para el Conjunto Habitacional"));
            return false;
        }
        if (ddlComuna.SelectedIndex.Equals("0"))
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
        if (!string.IsNullOrEmpty(txtRutConstructora.Text))
        {
            if (!new Utilidad().validarRut(txtRutConstructora.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("el Rut de la empresa Constructora no es válido"));
                return false;
            }
        }
        if (!string.IsNullOrEmpty(txtRutVendedora.Text))
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
            ConjuntoHabitacional_ENT conjuntoSession = (ConjuntoHabitacional_ENT)Session["conjuntoHabitacionalSeleccionado"];
            conjunto.IdConjuntoHabitacional = conjuntoSession.IdConjuntoHabitacional;
            conjunto.CodigoConjunto = conjuntoSession.CodigoConjunto;
            conjunto.Etapa = conjuntoSession.Etapa;
            new ConjuntoHabitacional_BSS().update(conjunto);
            Session["conjuntoHabitacionalSeleccionado"] = conjunto;
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Conjunto Habitacional Actualizado exitósamente"));
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ConjuntoHabitacional.aspx");
        }
    }

    protected void ddlRegionConjunto_SelectedIndexChanged(object sender, EventArgs e)
    {
        new Utilidad().cargarCiudad(ddlCiudadConjunto, ddlRegionConjunto.SelectedValue, "0");
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
        Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ConjuntoHabitacional.aspx");
    }
}
