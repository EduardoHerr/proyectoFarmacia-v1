using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clDatos;

namespace clNegocio
{
    public class conProds
    {
        dbProds db = new dbProds();

        public object listarProds()
        {
            var data = db.verProds();
            return data;
        }

    }
}
