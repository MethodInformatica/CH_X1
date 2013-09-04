using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class Seguimiento_BSS
    {
        private int idConjuntoHabitacional;        
        private int total;
        private int cantidadRegistros;
        private int pagina;
        private List<int> paginas = new List<int>();
        private List<Seguimiento_ENT> elementos = new List<Seguimiento_ENT>();

        public Seguimiento_ENT save(Seguimiento_ENT seguimiento)
        {
           return new Seguimiento_DAO().insert(seguimiento);
        }

        public int getAllCantidad()
        {
            return new Seguimiento_DAO().getCount(new Seguimiento_ENT()
            {
                IdConjuntoHabitacional = this.IdConjuntoHabitacional                
            });
        }

        public List<Seguimiento_ENT> getAllByPage(int desde, int hasta)
        {
            List<Seguimiento_ENT> conjuntos = new Seguimiento_DAO().getAllByPage(new Seguimiento_ENT()
            {
                IdConjuntoHabitacional = this.IdConjuntoHabitacional,
            }, desde, hasta);
            foreach (Seguimiento_ENT seguimiento in conjuntos)
            {
                UsuarioSistema_ENT usuario = new Usuario_BSS().getByIdUsuario(
                    new UsuarioSistema_ENT() { IdUsuarioSistema = seguimiento.IdUsuario });
                if (usuario != null)
                    seguimiento.Usuario = usuario;
            }
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

        public void generarResultado()
        {
            if (this.Pagina <= 0)
                this.Pagina = 1;
            this.Total = this.getAllCantidad();
            if (this.CantidadRegistros <= 0)
                this.CantidadRegistros = 1;
            this.generarPaginas();
            this.Elementos = this.getAllByPage(this.Pagina.Equals(1) ? 1 : ((this.Pagina - 1) * cantidadRegistros) + 1,
                (this.Pagina * cantidadRegistros) + 1);
        }


        public int IdConjuntoHabitacional
        {
            get { return idConjuntoHabitacional; }
            set { idConjuntoHabitacional = value; }
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
        public List<Seguimiento_ENT> Elementos
        {
            get { return elementos; }
            set { elementos = value; }
        }
    }
}
