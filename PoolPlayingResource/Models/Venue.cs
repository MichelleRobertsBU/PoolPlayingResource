using System.ComponentModel.DataAnnotations;

namespace PoolPlayingResource.Models
{
        
    public partial class Venue
    {
        public int VenueId { get; set; }
        public string VenueName { get; set; }
        public Nullable<int> NumberTables { get; set; }
        public string VenueAddress { get; set; }
        public string TableFee { get; set; }
        public Nullable<int> TableSize { get; set; }
    }
}
