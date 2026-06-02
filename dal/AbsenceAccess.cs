using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.model;

namespace MediaTek86.dal
{
    public class AbsenceAccess
    {

        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur de la classe AbsenceAccess
        /// </summary>
        public AbsenceAccess() 
        {
            access = Access.GetInstance();
        }

        public List<Absence> GetLesAbsences(int idPersonnel)
        {
            
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select a.idpersonnel as idpersonnel, a.datedebut as datedebut, a.datefin as datefin, a.idmotif as idmotif, m.libelle as libelle ";
                req += "from absence a join motif m on (a.idmotif = m.idmotif) ";
                req += "where a.idpersonnel = @idpersonnel ";
                req += "order by a.datedebut DESC;";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", idPersonnel);

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[3], (string)record[4]);
                            Absence absence = new Absence(Convert.ToInt32(record[0]), (DateTime)record[1], (DateTime)record[2], motif);

                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }

        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values(@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Idpersonnel);
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);

                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        public void UpdateAbsence(Absence absence, DateTime ancienneDateDebut)
        {
            if (access.Manager != null)
            {
                string req = "update absence set datedebut = @datedebut, datefin = @datefin, idmotif = @motif ";
                req += "where idpersonnel = @idpersonnel and datedebut = @ancienneDateDebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Idpersonnel);
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                parameters.Add("@motif", absence.Motif.Idmotif);
                parameters.Add("@ancienneDateDebut", ancienneDateDebut);

                try
                {
                    access.Manager.ReqSelect(req, parameters);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null) 
            {
                string req = "delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Idpersonnel);
                parameters.Add("@datedebut", absence.Datedebut);

                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }

        }
    }
}
