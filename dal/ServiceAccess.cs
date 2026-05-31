using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.model;

namespace MediaTek86.dal
{

    /// <summary>
    /// Classe gérant les demandes concernant les services
    /// </summary>
    public class ServiceAccess
    {

        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ServiceAccess()
        {
            access = Access.GetInstance();
        }

        public List<Service> GetLesServices()
        {
            List<Service> LesServices = new List<Service>();
            if (access.Manager != null)  
            {
                string req = "select * from service order by nom";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service(Convert.ToInt32(record[0]), Convert.ToString(record[1]));
                        }
                    }
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return null;
        }
    }
}
