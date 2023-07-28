using System.Linq;
using System.Web;

namespace CasgemTravel.DAL.Entities
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}