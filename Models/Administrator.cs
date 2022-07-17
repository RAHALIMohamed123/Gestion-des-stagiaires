using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_des_Stagiaires.Models
{
    public class Administrator
    {

        public int Id { get; set; }
        public string lastName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public  DateTime CreatedOn { get; set; }

    }
}
