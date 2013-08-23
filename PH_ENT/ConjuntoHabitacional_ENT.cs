using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class ConjuntoHabitacional_ENT
    {
        private int idConjuntoHabitacional;
        private string codigoConjunto;
        private string nombreConjunto;
        private string etapa;
        private int idComunaConjunto;
        private string nombreComunaConjunto;

        
        private string direccionConjunto;
        private string rutConstructora;
        private string nombreConstructora;
        private string rutEmpresaVendedora;
        private string nombreEmpresaVendedora;
        private string representanteEmpresaVendedora;
        private int idComunaEmpresaVendedora;
        private string direccionEmpresaVendedora;
        private string areaEmpresaVendedora;
        private string telefonoEmpresaVendedora;
        private string emailEmpresaVendedora;
        private DateTime fechaContrato;
        private DateTime fechaTerminoConstruccion;
        private DateTime fechaRecepcionMunicipal;
        private DateTime fechaRecepcionProhogar;

        public int IdConjuntoHabitacional
        {
            get { return idConjuntoHabitacional; }
            set { idConjuntoHabitacional = value; }
        }

        public string CodigoConjunto
        {
            get { return codigoConjunto; }
            set { codigoConjunto = value; }
        }
        
        public string NombreConjunto
        {
            get { return nombreConjunto; }
            set { nombreConjunto = value; }
        }
        
        public string Etapa
        {
            get { return etapa; }
            set { etapa = value; }
        }

        public int IdComunaConjunto
        {
            get { return idComunaConjunto; }
            set { idComunaConjunto = value; }
        }

        public string NombreComunaConjunto
        {
            get { return nombreComunaConjunto; }
            set { nombreComunaConjunto = value; }
        }

        public string DireccionConjunto
        {
            get { return direccionConjunto; }
            set { direccionConjunto = value; }
        }
        
        public string RutConstructora
        {
            get { return rutConstructora; }
            set { rutConstructora = value; }
        }
        
        public string NombreConstructora
        {
            get { return nombreConstructora; }
            set { nombreConstructora = value; }
        }
        
        public string RutEmpresaVendedora
        {
            get { return rutEmpresaVendedora; }
            set { rutEmpresaVendedora = value; }
        }
        
        public string NombreEmpresaVendedora
        {
            get { return nombreEmpresaVendedora; }
            set { nombreEmpresaVendedora = value; }
        }

        public string RepresentanteEmpresaVendedora
        {
            get { return representanteEmpresaVendedora; }
            set { representanteEmpresaVendedora = value; }
        }
        
        public int IdComunaEmpresaVendedora
        {
            get { return idComunaEmpresaVendedora; }
            set { idComunaEmpresaVendedora = value; }
        }
        
        public string DireccionEmpresaVendedora
        {
            get { return direccionEmpresaVendedora; }
            set { direccionEmpresaVendedora = value; }
        }
        
        public string AreaEmpresaVendedora
        {
            get { return areaEmpresaVendedora; }
            set { areaEmpresaVendedora = value; }
        }
        
        public string TelefonoEmpresaVendedora
        {
            get { return telefonoEmpresaVendedora; }
            set { telefonoEmpresaVendedora = value; }
        }
        
        public string EmailEmpresaVendedora
        {
            get { return emailEmpresaVendedora; }
            set { emailEmpresaVendedora = value; }
        }
        
        public DateTime FechaContrato
        {
            get { return fechaContrato; }
            set { fechaContrato = value; }
        }
        
        public DateTime FechaTerminoConstruccion
        {
            get { return fechaTerminoConstruccion; }
            set { fechaTerminoConstruccion = value; }
        }
        
        public DateTime FechaRecepcionMunicipal
        {
            get { return fechaRecepcionMunicipal; }
            set { fechaRecepcionMunicipal = value; }
        }
        
        public DateTime FechaRecepcionProhogar
        {
            get { return fechaRecepcionProhogar; }
            set { fechaRecepcionProhogar = value; }
        }

    }
}
