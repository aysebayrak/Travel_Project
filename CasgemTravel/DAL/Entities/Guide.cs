using System.Collections.Generic;

namespace CasgemTravel.DAL.Entities
{
    public class Guide
    {
        public int GuideID { get; set; }
        public string GuideName { get; set; }
        public string GuideTitle { get; set; }
        public string GuideImageUrl { get; set; }
        public List<SocialMedia> SocialMedia { get; set; }
    }
}