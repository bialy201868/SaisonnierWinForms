using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Controleur
{
 public  class LoginCTRL : ContextSaison
    {

        public int AddLogin(login l)
        {
            context.logins.Add(l);
            context.SaveChanges();


            int id_login = context.logins.Select(ll =>ll.ID_LOGIN).Max();

            return id_login; 
        }


        public login CheckLogin(string log, string mdp)
        {
            login loginDB = (login)context.logins.Where(l => l.LOGIN1 == log && l.MOT_DE_PASSE == mdp).FirstOrDefault();
            if (loginDB != null)
            {
                return loginDB;
            }
            else
            {
                return null;
            }

            
        }

    }
}
