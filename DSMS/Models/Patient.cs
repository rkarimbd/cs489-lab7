namespace DSMS.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int AddressId { get; set; } // Foreign key
        public Address Address { get; set; } // Navigation property   

       // public ICollection<Appointment> Appointments { get; set; }
    }

}
