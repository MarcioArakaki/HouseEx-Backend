namespace HouseEX.Persistence.Model
{
    public class User
    {
        public int Id { get; set; }

        public string? AboutMe { get; set; }

        public string DisplayName { get; set; } = null!;

        public string? WebSiteUrl { get; set; }
    }
}