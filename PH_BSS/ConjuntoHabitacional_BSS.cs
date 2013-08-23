using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class ConjuntoHabitacional_BSS
    {
        public ConjuntoHabitacional_ENT insertConjuntoHabitacional(ConjuntoHabitacional_ENT datosConjuntoHabitacional)
        {
            ConjuntoHabitacional_ENT oConjunto = new ConjuntoHabitacional_DAO().insert(datosConjuntoHabitacional);
            return oConjunto;
        }

        public int deleteConjuntoHabitacional(ConjuntoHabitacional_ENT datosConjuntoHabitacional)
        {
            int error = new ConjuntoHabitacional_DAO().delete(datosConjuntoHabitacional);
            return error;
        }

        public ConjuntoHabitacional_ENT getConjuntoHabitacionalID(ConjuntoHabitacional_ENT datosConjuntoHabitacional)
        {
            ConjuntoHabitacional_ENT oConjunto = new ConjuntoHabitacional_DAO().getForIdConjuntoHabitacional(datosConjuntoHabitacional);
            return oConjunto;
        }

        public List<ConjuntoHabitacional_ENT> listConjuntoHabitacional()
        {
            List<ConjuntoHabitacional_ENT> listConjunto = new ConjuntoHabitacional_DAO().listConjuntoHabitacional();
            List<ConjuntoHabitacional_ENT> newListConjunto = new List<ConjuntoHabitacional_ENT>();

            foreach (ConjuntoHabitacional_ENT dato in listConjunto)
            {
                ConjuntoHabitacional_ENT oConjunto = new ConjuntoHabitacional_ENT();
                Comuna_ENT oComuna = new Comuna_ENT();

                oConjunto.IdConjuntoHabitacional = dato.IdConjuntoHabitacional;
                oConjunto.CodigoConjunto = dato.CodigoConjunto;
                oConjunto.NombreConjunto = dato.NombreConjunto;
                oConjunto.Etapa = dato.Etapa;
                oConjunto.DireccionConjunto = dato.DireccionConjunto;
                oConjunto.RutConstructora = dato.RutConstructora;
                oConjunto.NombreConjunto = dato.NombreConjunto;
                oConjunto.RutEmpresaVendedora = dato.RutEmpresaVendedora;
                oConjunto.NombreEmpresaVendedora = dato.NombreEmpresaVendedora;
                oConjunto.RepresentanteEmpresaVendedora = dato.RepresentanteEmpresaVendedora;
                oComuna.IdComuna = dato.IdComunaConjunto;
                oConjunto.NombreComunaConjunto = new Comuna_BSS().getComunaID(oComuna).Nombre;
                oConjunto.DireccionEmpresaVendedora = dato.DireccionEmpresaVendedora;
                oConjunto.AreaEmpresaVendedora = dato.AreaEmpresaVendedora;
                oConjunto.TelefonoEmpresaVendedora = dato.TelefonoEmpresaVendedora;
                oConjunto.EmailEmpresaVendedora = dato.EmailEmpresaVendedora;
                oConjunto.FechaContrato = dato.FechaContrato;
                oConjunto.FechaTerminoConstruccion = dato.FechaTerminoConstruccion;
                oConjunto.FechaRecepcionMunicipal = dato.FechaRecepcionMunicipal;
                oConjunto.FechaRecepcionProhogar = dato.FechaRecepcionProhogar;

                newListConjunto.Add(oConjunto);
            }


            return newListConjunto;

        }
    }
}
