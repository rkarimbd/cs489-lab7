namespace DSMS.DTOs
{
    public record PatientDto
    {
        public int PatientId { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string ContactPhoneNumber { get; init; }
        public string Email { get; init; }
        public DateTime DateOfBirth { get; init; }
        public AddressDto primaryAddress { get; init; }
    }

}
