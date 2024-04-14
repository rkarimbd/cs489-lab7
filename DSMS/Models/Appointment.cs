namespace DSMS.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
       // public int DentistId { get; set; }
      //  public Dentist dentist { get; set; }
      // public int PatientId { get; set; }            
       // public Patient patient { get; set; }
      // public int SurgeryId { get; set; }
       // public Surgery surgery { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string Status { get; set; } 
    }

}
