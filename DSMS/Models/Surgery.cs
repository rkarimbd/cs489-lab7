namespace DSMS.Models
{
    public class Surgery
    {
        public int SurgeryId { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
       // public int AddressId { get; set; }
        public Address Address { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }

}
