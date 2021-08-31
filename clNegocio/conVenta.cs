using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clDatos;
using System.Data;

namespace clNegocio
{
    public class conVenta
    {
        dbVenta vent = new dbVenta();

        public object listaVen(int id)
        {
            return vent.listarVentaxId(id);
        }

        public void insertVenta(int cli, int prod, string ven, DateTime fecha, string nom, int cant, double pre)
        {
            vent.AgregarVenta(cli,prod,ven,fecha,nom,cant,pre);
        }

        public DataSet codVen(int id)
        {
            return vent.codVent(id);
        }
    }
}
