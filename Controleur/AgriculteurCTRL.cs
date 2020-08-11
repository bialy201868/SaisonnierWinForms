using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace Controleur
{
   public  class AgriculteurCTRL : ContextSaison
    {
        public List<agriculteur> GetFromDB()
        {
            return context.agriculteurs.ToList();
        }

        public agriculteur GetAgri(int idlogin)
        {
            return context.agriculteurs.Where(a => a.ID_LOGIN == idlogin).FirstOrDefault();    
        }
            

        public int AddToDB(agriculteur a)
        {    
            context.agriculteurs.Add(a);
            context.SaveChanges();
            return a.CODE_AGRI;
        }

        public int DeleteFromDB(agriculteur a)
        {
            agriculteur agriculteur = context.agriculteurs.Find(a.CODE_AGRI);
            login login = context.logins.Find(a.ID_LOGIN);
            context.logins.Remove(login);
            context.agriculteurs.Remove(agriculteur);
            return context.SaveChanges();

        }

        public int UpdateDB(agriculteur a)
        {
            agriculteur agriculteur = context.agriculteurs.Find(a.CODE_AGRI);

            agriculteur.PRENOM_AGRI = a.PRENOM_AGRI;
            agriculteur.NOM_AGRI = a.NOM_AGRI;
            agriculteur.CODE_REGION = a.CODE_REGION;
            agriculteur.PROFIL_TEXTE = a.PROFIL_TEXTE;
            agriculteur.MAIL_AGRI = a.MAIL_AGRI;
            agriculteur.TEL_AGRI = a.TEL_AGRI;
            agriculteur.CODE_AGRI = a.CODE_AGRI;
            agriculteur.ID_LOGIN = a.ID_LOGIN;

            return context.SaveChanges();

        }
    }
}
