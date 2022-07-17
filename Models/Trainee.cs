using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_des_Stagiaires.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string lastName { get; set; }
        public string FirstName { get; set; }
        public string  Organism{ get; set; }
        public string Structure { get; set; }
        public string Direction { get; set; }
        public string ThemeTitle { get; set; }
        public string TrainingDuration { get; set; }

    
        public string DossierNumber { get; set; }

        public string AttestationNumber { get; set; }
        public DateTime TrainingStartedOn { get; set; }
        public DateTime TrainingEndedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModefiedOn { get; set; }
        public TraineeType TraineeType { get; set; }
        public TraineeType Traineestatus { get; set; }

        [ForeignKey("TrainerId")]
        public int TrainerId { get; set; }

        public Trainer Trainer { get; set; }
      
    }
}
