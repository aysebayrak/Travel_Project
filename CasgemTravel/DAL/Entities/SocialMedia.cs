namespace CasgemTravel.DAL.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        public string SocialName { get; set; }
        public string SocialMediaUrl { get; set; }
        public int GuideID { get; set; }
        public virtual Guide Guide { get; set; }
    }
}