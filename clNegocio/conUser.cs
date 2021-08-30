using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clDatos;

namespace clNegocio
{
    public class conUser
    {
        dbUsuario db = new dbUsuario();
        public object conUsuario()
        {
            var data = db.listarUser();

            return data;

        }

    }
}
