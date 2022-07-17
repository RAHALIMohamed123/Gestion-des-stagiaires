using System.Collections.Generic;

namespace Gestion_des_Stagiaires.Models
{
    public class Trainer
     {
        public int Id { get; set; }
        public string lastName { get; set; }
        public string FirstName { get; set; }
        public string Structure { get; set; }
        public string Direction { get; set; }
        public int TraineesNumber { get; set; }
        public ICollection<Trainee> Trainees { get; set; }

    }
}
