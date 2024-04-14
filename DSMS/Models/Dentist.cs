namespace DSMS.Models
{
    public class Dentist
    {
        public int DentistId { get; set; }        
        public string Name { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string Email { get; set; }
        public string Specialization { get; set; }       
        public ICollection<Appointment> Appointments { get; set; }
    }

}
