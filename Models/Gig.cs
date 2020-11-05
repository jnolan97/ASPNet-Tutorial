using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsCanceled { get; private set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public byte GenreId { get; set; }
        public Genre Genre { get; set; }

        [Required]
        public string ArtistId { get; set; }
        public ApplicationUser Artist { get; set; }


        public Gig()
        {
            
        }

    }
}


