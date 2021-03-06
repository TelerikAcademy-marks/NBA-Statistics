using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NBAStatistics.Models
{
    public class School
    {
        private ICollection<Player> players;

        public School()
        {
            this.players = new HashSet<Player>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public int? CityId { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Player> Players
        {
            get { return this.players; }
            set { this.players = value; }
        }
    }
}
