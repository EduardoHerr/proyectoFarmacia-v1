using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clDatos;

namespace clNegocio
{
    public class conCliente
    {
        dbCliente cli = new dbCliente();

        public object listarCliente()
        {
            var data = cli.listarCliente();

            return data;
        }

    }
}
