using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class Documento_BSS
    {
        private int idConjuntoHabitacional;        
        private string folio;        
        private string nombre;
        private DateTime fechaDocumento = new DateTime();
        private DateTime fechaVencimiento = new DateTime();        
        private int total;
        private int cantidadRegistros;
        private int pagina;
        private List<int> paginas = new List<int>();
        private List<Documento_ENT> elementos = new List<Documento_ENT>();

        public Documento_ENT insertDocumento(Documento_ENT datosDocumento)
        {
            Documento_ENT oDocumento = new Documento_DAO().insert(datosDocumento);
            return oDocumento;
        }

        public int deleteDocumento(Documento_ENT datosDocumento)
        {
            int error = new Documento_DAO().delete(datosDocumento);
            return error;
        }

        public Documento_ENT getDocumentoID(Documento_ENT datosDocumento)
        {
            Documento_ENT oDocumento = new Documento_DAO().getForIdDocumento(datosDocumento);
            return oDocumento;
        }

        public List<Documento_ENT> listAllByIdConjunto(int idConjunto)
        {
            List<Documento_ENT> listConjunto = new Documento_DAO().listConjuntoHabitacional(idConjunto);
            return listConjunto;
        }

        public int update(Documento_ENT documento)
        {
            return new Documento_DAO().update(documento);
        }
        public int getAllCantidadByFiltro(int all)
        {
            return new Documento_DAO().getCount(new Documento_ENT()
            {
                IdConjuntoHabitacional = this.IdConjuntoHabitacional,
                Folio = this.Folio,
                Nombre = this.Nombre,
                FechaDocumento = this.FechaDocumento,
                FechaVencimiento = this.FechaVencimiento
            }, all);
        }

        public List<Documento_ENT> getAllByPage(int desde, int hasta, int all)
        {
            List<Documento_ENT> conjuntos = new Documento_DAO().getAllByPage(new Documento_ENT()
            {
                IdConjuntoHabitacional = this.IdConjuntoHabitacional,
                Folio = this.Folio,
                Nombre = this.Nombre,
                FechaDocumento = this.FechaDocumento,
                FechaVencimiento = this.FechaVencimiento
            }, desde, hasta, all);
             return conjuntos;
        }
        public void generarPaginas()
        {
            double sinRedondear = Convert.ToDouble(this.total) / Convert.ToDouble(this.cantidadRegistros);
            double redondear = Convert.ToDouble(this.total / this.cantidadRegistros);
            int cant = 1;
            if (sinRedondear > redondear)
                cant = Convert.ToInt32(redondear) + 1;
            else
                cant = Convert.ToInt32(redondear);
            int i = 1;
            List<int> listadoPaginas = new List<int>();
            for (i = 1; i <= cant; i++)
                listadoPaginas.Add(i);
            this.paginas = listadoPaginas;
            if (this.pagina > i)
                this.pagina = i;
        }

        public void generarResultado(int all)
        {
            if (this.Pagina <= 0)
                this.Pagina = 1;
            this.Total = this.getAllCantidadByFiltro(all);
            if (this.CantidadRegistros <= 0)
                this.CantidadRegistros = 1;
            this.generarPaginas();
            this.Elementos = this.getAllByPage(this.Pagina.Equals(1) ? 1 : ((this.Pagina - 1) * cantidadRegistros) + 1,
                (this.Pagina * cantidadRegistros) + 1, all);
        }

        public int IdConjuntoHabitacional
        {
            get { return idConjuntoHabitacional; }
            set { idConjuntoHabitacional = value; }
        }
        public string Folio
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
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public int CantidadRegistros
        {
            get { return cantidadRegistros; }
            set { cantidadRegistros = value; }
        }
        public int Pagina
        {
            get { return pagina; }
            set { pagina = value; }
        }
        public List<int> Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }
        public List<Documento_ENT> Elementos
        {
            get { return elementos; }
            set { elementos = value; }
        }
    }
}
