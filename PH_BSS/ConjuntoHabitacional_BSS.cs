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
        private string codigo;
        private string nombre;       
        private string region;       
        private int total;        
        private int cantidadRegistros;        
        private int pagina;        
        private List<int> paginas = new List<int>();
        private List<ConjuntoHabitacional_ENT> elementos = new List<ConjuntoHabitacional_ENT>();       


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
            oConjunto.ComunaConjunto = new Comuna_BSS().getComunaID(new Comuna_ENT() { IdComuna = oConjunto.IdComunaConjunto });
            oConjunto.ComunaConjunto.Ciudad = new Ciudad_BSS().getById(new Ciudad_ENT() { IdCiudad = oConjunto.ComunaConjunto.IdCiudad });
            oConjunto.ComunaConjunto.Ciudad.Region = new Region_BSS().getById(new Region_ENT() { IdRegion = oConjunto.ComunaConjunto.Ciudad.IdRegion });

            oConjunto.ComunaVendedora = new Comuna_BSS().getComunaID(new Comuna_ENT() { IdComuna = oConjunto.IdComunaEmpresaVendedora });
            if (oConjunto.ComunaVendedora != null)
            {
                oConjunto.ComunaVendedora.Ciudad = new Ciudad_BSS().getById(new Ciudad_ENT() { IdCiudad = oConjunto.ComunaVendedora.IdCiudad });
                if (oConjunto.ComunaVendedora.Ciudad != null)
                {
                    oConjunto.ComunaVendedora.Ciudad.Region = new Region_BSS().getById(new Region_ENT() { IdRegion = oConjunto.ComunaVendedora.Ciudad.IdRegion });
                    if (oConjunto.ComunaVendedora.Ciudad.Region == null)
                        oConjunto.ComunaVendedora.Ciudad.Region = new Region_ENT();
                }
                else
                    oConjunto.ComunaVendedora.Ciudad = new Ciudad_ENT();
            }
            else
                oConjunto.ComunaVendedora = new Comuna_ENT();

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

        public ConjuntoHabitacional_ENT getByCodigo(string codigo)
        {
            ConjuntoHabitacional_ENT oConjunto = new ConjuntoHabitacional_DAO().getByCodigo(codigo);
            oConjunto.ComunaConjunto = new Comuna_BSS().getComunaID(new Comuna_ENT() { IdComuna = oConjunto.IdComunaConjunto });
            oConjunto.ComunaConjunto.Ciudad = new Ciudad_BSS().getById(new Ciudad_ENT() { IdCiudad = oConjunto.ComunaConjunto.IdCiudad });
            oConjunto.ComunaConjunto.Ciudad.Region = new Region_BSS().getById(new Region_ENT() { IdRegion = oConjunto.ComunaConjunto.Ciudad.IdRegion });

            oConjunto.ComunaVendedora = new Comuna_BSS().getComunaID(new Comuna_ENT() { IdComuna = oConjunto.IdComunaEmpresaVendedora });
            if (oConjunto.ComunaVendedora != null)
            {
                oConjunto.ComunaVendedora.Ciudad = new Ciudad_BSS().getById(new Ciudad_ENT() { IdCiudad = oConjunto.ComunaVendedora.IdCiudad });
                if (oConjunto.ComunaVendedora.Ciudad != null)
                {
                    oConjunto.ComunaVendedora.Ciudad.Region = new Region_BSS().getById(new Region_ENT() { IdRegion = oConjunto.ComunaVendedora.Ciudad.IdRegion });
                    if (oConjunto.ComunaVendedora.Ciudad.Region == null)
                        oConjunto.ComunaVendedora.Ciudad.Region = new Region_ENT();
                }
                else
                    oConjunto.ComunaVendedora.Ciudad = new Ciudad_ENT();
            }
            else
                oConjunto.ComunaVendedora = new Comuna_ENT();

            return oConjunto;
        }

        public int getAllCantidadByFiltro(int all)
        {
            return new ConjuntoHabitacional_DAO().getCount(new ConjuntoHabitacional_ENT() { 
                CodigoConjunto = this.Codigo,
                NombreConjunto = this.Nombre,
                IdComunaConjunto = Convert.ToInt32(this.Region)
            },all);
        }

        public List<ConjuntoHabitacional_ENT> getAllByPage(int desde, int hasta, int all)
        {
            List<ConjuntoHabitacional_ENT> conjuntos =  new ConjuntoHabitacional_DAO().getAllByPage(new ConjuntoHabitacional_ENT()
            {
                CodigoConjunto = this.Codigo,
                NombreConjunto = this.Nombre,
                IdComunaConjunto = Convert.ToInt32(this.Region)
            },desde,hasta,all);
            foreach (ConjuntoHabitacional_ENT conjunto in conjuntos)
            {
                conjunto.ComunaConjunto = new Comuna_BSS().getComunaID(new Comuna_ENT() { IdComuna = conjunto.IdComunaConjunto });
                conjunto.ComunaConjunto.Ciudad = new Ciudad_BSS().getById(new Ciudad_ENT() { IdCiudad = conjunto.ComunaConjunto.IdCiudad });
                conjunto.ComunaConjunto.Ciudad.Region = new Region_BSS().getById(new Region_ENT() { IdRegion = conjunto.ComunaConjunto.Ciudad.IdRegion });
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

        public void generarResultado(int all)
        {
            if (this.Pagina <= 0)
                this.Pagina = 1;
            this.Total = this.getAllCantidadByFiltro(all);
            if (this.CantidadRegistros <= 0)
                this.CantidadRegistros = 1;
            this.generarPaginas();
            this.Elementos = this.getAllByPage(this.Pagina.Equals(1) ? 1 : ((this.Pagina - 1) * cantidadRegistros) + 1,
                (this.Pagina * cantidadRegistros) + 1,all);
        }

        public int deleteByCodigo(string codigo)
        {
            return new ConjuntoHabitacional_DAO().deleteByCodigo(codigo);
        }
        public int update(ConjuntoHabitacional_ENT conjunto)
        {
            return new ConjuntoHabitacional_DAO().update(conjunto);              
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Region
        {
            get { return region; }
            set { region = value; }
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
        public List<ConjuntoHabitacional_ENT> Elementos
        {
            get { return elementos; }
            set { elementos = value; }
        }

    }
}
