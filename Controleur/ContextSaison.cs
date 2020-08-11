using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace Controleur
{
 public  class ContextSaison
    {
        protected Model_new context;  

        public ContextSaison()
        {
            context = new Model_new();
        }

    }
}
