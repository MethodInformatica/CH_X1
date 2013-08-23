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

public partial class modulo_conjuntoHabitacional_Tabs_ProductoListado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ConjuntoHabitacional_ENT oConjunto = (ConjuntoHabitacional_ENT)Session["sessionConjuntoHabitacional"];
        //this.cargarDatosConjunto(oConjunto); 
    }

    protected void cargarDatosConjunto(ConjuntoHabitacional_ENT oConjunto)
    {
        //text_codigo_conjunto.Text = oConjunto.CodigoConjunto;
        //text_nombre_conjunto.Text = oConjunto.NombreConjunto;
        //text_etapa.Text = oConjunto.Etapa;
    } 

    protected void btn_CargaUnoUno_Click(object sender, EventArgs e)
    {
        int tipo = Convert.ToInt32(ddlTipoProducto.SelectedValue);

        if (tipo == 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe seleccionar un tipo de producto!!!"));
        }
        else if (tipo == 1) 
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoCasa.aspx");
        }
        else if (tipo == 2)
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoDepto.aspx");
        }
        else if (tipo == 3)
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoEstacionamientoBodega.aspx");
        }
        else if (tipo == 4)
        {
            Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/ProductoLocalComercial.aspx");
        }
    }

    protected void btn_CargaMasiva_Click(object sender, EventArgs e)
    {
        ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Funcionalidad en construcción!!!"));
    }
}