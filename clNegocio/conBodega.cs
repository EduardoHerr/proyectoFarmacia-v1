using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using clDatos;

namespace clNegocio
{
    public class conBodega
    {
        dbBodega dbBodega = new dbBodega();
        public object listarProd()
        {
            var data = dbBodega.ListarProd();

            return data;
        }
    }
}
