namespace Zamyad.Exemption.UI.Models
{
    public class WebSystemUserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        public bool IsActive { get; set; }
        public bool UserIsValid { get; set; }

    }
}
