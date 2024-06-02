namespace FinalProject.Models
{
    public class AppUser
    {
        public string username { get; set; }
        public string is_superuser { get; set; }

        public AppUser(string username) 
        {
            this.username = username;
        }
    }
}
