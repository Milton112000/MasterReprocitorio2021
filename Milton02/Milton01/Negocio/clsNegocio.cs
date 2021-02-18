using Milton01.DAO;
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

        ClsListasUsuario cls = new ClsListasUsuario();
        public Boolean acceder (login log)
        {
            for (int i=0;i< cls.user.Length;i++) { 
            if (log.Usuario.Equals(cls.user[i]) && log.Paswork.Equals(cls.pas[i]))
            {
                return true;

            }
            }
            
                return false;
           
            
            
        }
      
      

       


    }
}
