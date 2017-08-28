using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IMDB.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Genre { get; set; }

        [Required]
        public String Director { get; set; }

        [Required]
        public String Year { get; set; }
    }
}