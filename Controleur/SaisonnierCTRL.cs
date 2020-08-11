using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Controleur
{
  public  class SaisonnierCTRL : ContextSaison
    {

        public saisonnier GetSaisonnier(int idlogin)
        {
            return  context.saisonniers.Where(s => s.ID_LOGIN == idlogin).FirstOrDefault();
        }

        public List<saisonnier> GetFromDB()
        {
            return context.saisonniers.ToList();
        }

        public int AddToDB(saisonnier s)
        {
           
            context.saisonniers.Add(s);
            return context.SaveChanges();
        }

        public int DeleteFromDB(saisonnier s)
        {
            saisonnier saisonnier = context.saisonniers.Find(s.CODE_SAISONNIER);
            login login = context.logins.Find(s.ID_LOGIN);
            context.logins.Remove(login);
            context.saisonniers.Remove(saisonnier);

            return context.SaveChanges();

        }

        public int UpdateDB(saisonnier s)
        {
            saisonnier saisonnier = context.saisonniers.Find(s.CODE_SAISONNIER);
            saisonnier.PRENOM_SAISON = s.PRENOM_SAISON;
            saisonnier.NOM_SAISON = s.NOM_SAISON;
            saisonnier.MAIL_SAISONNIER = s.MAIL_SAISONNIER;
            saisonnier.TEL_SAISONNIER = s.TEL_SAISONNIER;
            saisonnier.PROFIL_TEXTE_SAISON = s.PROFIL_TEXTE_SAISON;
            saisonnier.DATE_NAISSANCE_SAISON = s.DATE_NAISSANCE_SAISON;

            return context.SaveChanges();

        }
    }
}
