using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class Documento_ENT
    {
        private int idDocumento;
        private int idConjuntoHabitacional;
        private int folio;
        private string nombre;
        private DateTime fechaDocumento;
        private DateTime fechaVencimiento;
        private DateTime fechaIngreso;
        private string descripcion;
        private string archivoNombre;
        private string archivoExtencion;
        private string archivoTipo;
        private bool estado;

        public int IdDocumento
        {
            get { return idDocumento; }
            set { idDocumento = value; }
        }
        
        public int IdConjuntoHabitacional
        {
            get { return idConjuntoHabitacional; }
            set { idConjuntoHabitacional = value; }
        }
        
        public int Folio
        {
            get { return folio; }
            set { folio = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public DateTime FechaDocumento
        {
            get { return fechaDocumento; }
            set { fechaDocumento = value; }
        }
        
        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }
        
        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        public string ArchivoNombre
        {
            get { return archivoNombre; }
            set { archivoNombre = value; }
        }
        
        public string ArchivoExtencion
        {
            get { return archivoExtencion; }
            set { archivoExtencion = value; }
        }
        
        public string ArchivoTipo
        {
            get { return archivoTipo; }
            set { archivoTipo = value; }
        }
        
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
