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
        private int numeroReserva;
        private DateTime fechaReserva;
        private int numeroCartaOferta;
        private DateTime fechaCartaOferta;
        private string caracteristicas;
        private string deslines;
        private int orientacion;
        private decimal mtsConstruidos;
        private decimal mtsTerreno;
        private string direccionComunal;
        private string rolSii;
        private int ejecutivoVenta;
        private DateTime fechaVenta;
        private string codigoProyectoCliente;
        private decimal valorUf;
        private decimal descuento;
        private decimal valorFinalUf;
        private decimal gastosOperacionalesUf;
        private string direccion;

        
        public int IdDetalle
        {
            get { return idDetalle; }
            set { idDetalle = value; }
        }
        
        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        
        public int NumeroReserva
        {
            get { return numeroReserva; }
            set { numeroReserva = value; }
        }
        
        public DateTime FechaReserva
        {
            get { return fechaReserva; }
            set { fechaReserva = value; }
        }
        
        public int NumeroCartaOferta
        {
            get { return numeroCartaOferta; }
            set { numeroCartaOferta = value; }
        }
        
        public DateTime FechaCartaOferta
        {
            get { return fechaCartaOferta; }
            set { fechaCartaOferta = value; }
        }
        
        public string Caracteristicas
        {
            get { return caracteristicas; }
            set { caracteristicas = value; }
        }
        
        public string Deslines
        {
            get { return deslines; }
            set { deslines = value; }
        }
        
        public int Orientacion
        {
            get { return orientacion; }
            set { orientacion = value; }
        }
        
        public decimal MtsConstruidos
        {
            get { return mtsConstruidos; }
            set { mtsConstruidos = value; }
        }
        
        public decimal MtsTerreno
        {
            get { return mtsTerreno; }
            set { mtsTerreno = value; }
        }
        
        public string DireccionComunal
        {
            get { return direccionComunal; }
            set { direccionComunal = value; }
        }
        
        public string RolSii
        {
            get { return rolSii; }
            set { rolSii = value; }
        }
        
        public int EjecutivoVenta
        {
            get { return ejecutivoVenta; }
            set { ejecutivoVenta = value; }
        }
        
        public DateTime FechaVenta
        {
            get { return fechaVenta; }
            set { fechaVenta = value; }
        }
        
        public string CodigoProyectoCliente
        {
            get { return codigoProyectoCliente; }
            set { codigoProyectoCliente = value; }
        }
        
        public decimal ValorUf
        {
            get { return valorUf; }
            set { valorUf = value; }
        }
        
        public decimal Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        
        public decimal ValorFinalUf
        {
            get { return valorFinalUf; }
            set { valorFinalUf = value; }
        }
        
        public decimal GastosOperacionalesUf
        {
            get { return gastosOperacionalesUf; }
            set { gastosOperacionalesUf = value; }
        }

        public DetalleProducto_ENT() { 
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

    }
}
