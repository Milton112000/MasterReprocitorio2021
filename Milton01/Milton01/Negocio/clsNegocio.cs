using Milton01.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milton01.Negocio
{
    class clsNegocio
    {
        public Boolean acceder (login log)
        {

            if (log.Usuario.Equals("milton") && log.Paswork.Equals("123"))
            {
                return true;

            }
            else {
                return false;
            }
                

        }
        
    }
}
