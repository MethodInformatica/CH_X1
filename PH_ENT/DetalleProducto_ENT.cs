using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class DetalleProducto_ENT
    {      
        private int idDetalle;
        private int idProducto;
        private string caracteristicas;        
        private string deslines;        
        private int orientacion;        
        private string direccion;        
        private decimal mtsConstruidos;        
        private decimal mtsTerreno;        
        private string direccionComunal;        
        private string rolSii;        
        private int estadoProducto;      
        private decimal valorUf;        
        private decimal descuento;        
        private decimal valorFinalUf;        
        private decimal gastosOperacionalesUf;

        public DetalleProducto_ENT()
        {
        }
        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        public int IdDetalle
        {
            get { return idDetalle; }
            set { idDetalle = value; }
        }
        public decimal GastosOperacionalesUf
        {
            get { return gastosOperacionalesUf; }
            set { gastosOperacionalesUf = value; }
        }
        public decimal ValorFinalUf
        {
            get { return valorFinalUf; }
            set { valorFinalUf = value; }
        }
        public decimal Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public decimal ValorUf
        {
            get { return valorUf; }
            set { valorUf = value; }
        }
        public int EstadoProducto
        {
            get { return estadoProducto; }
            set { estadoProducto = value; }
        }
        public string RolSii
        {
            get { return rolSii; }
            set { rolSii = value; }
        }
        public string DireccionComunal
        {
            get { return direccionComunal; }
            set { direccionComunal = value; }
        }
        public decimal MtsTerreno
        {
            get { return mtsTerreno; }
            set { mtsTerreno = value; }
        }
        public decimal MtsConstruidos
        {
            get { return mtsConstruidos; }
            set { mtsConstruidos = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Orientacion
        {
            get { return orientacion; }
            set { orientacion = value; }
        }
        public string Deslines
        {
            get { return deslines; }
            set { deslines = value; }
        }
        public string Caracteristicas
        {
            get { return caracteristicas; }
            set { caracteristicas = value; }
        }        
    }
}
