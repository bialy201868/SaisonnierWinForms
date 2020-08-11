using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur
{
   public class PropositionCTRL : ContextSaison
    {

        public List<proposition> GetPropositions()
        {
            return context.propositions.ToList();
        }
        public List<proposition> GetPropositions(DateTime debut)
        {
            return context.propositions.Where(p=>p.DATE_DEBUT_PROPO >= debut).ToList();
        }

        public int AddProposition(proposition p, int code_agri)
        {
            context.propositions.Add(p);
            context.SaveChanges();
            int nb_proposition = context.propositions.Where(pp => pp.CODE_AGRI == code_agri).Count();

            return nb_proposition;
        }

        public bool UpdatePropositionMinus(int code_proposition)
        {
          
            var p = context.propositions.Find(code_proposition);
            if (p.CODE_PROPOS > 0)
            {
                p.NB_PLACES -= 1;
                context.SaveChanges();
                return true;
            }
            else 
            {
                return false;
            }

            
            
        }
        public bool UpdatePropositionPlus(int code_proposition)
        {

            var p = context.propositions.Find(code_proposition);
            if (p.CODE_PROPOS > 0)
            {
                p.NB_PLACES += 1;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }



        }



    }
}
