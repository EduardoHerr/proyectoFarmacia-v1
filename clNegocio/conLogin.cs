using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clDatos;

namespace clNegocio
{
    public class conLogin
    {
        dblogin dblog = new dblogin(); 

        public int Ingresar(string us,string pwd)
        {
            int rol = dblog.Loggeo(us, pwd);

            return rol;
        }
    }
}
