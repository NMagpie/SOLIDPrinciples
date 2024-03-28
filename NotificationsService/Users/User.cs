namespace _12._SOLID_principles.NotificationsService.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public string TelNumber { get; set; }

        public string Device { get; set; }

        public User(int id, string email, string telNumber, string device)
        {
            this.Id = id;
            this.Email = email;
            this.TelNumber = telNumber;
            this.Device = device;
        }
    }
}
