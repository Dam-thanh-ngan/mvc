using System;
using System.ComponentModel.DataAnnotations;

namespace demonet.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Title is required.")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}