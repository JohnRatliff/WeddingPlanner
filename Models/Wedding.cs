using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    [Table("weddings")]
    public class Wedding
    {
        [Key]
        [Required]
        public int WeddingId {get;set;}

        [Display(Name = "Creator:")]
        [Required]
        public int CreatorUserId {get;set;}

        [Display(Name = "Wedder One:")]
        [Required]
        public int WedderOneUserId {get;set;}

        [Display(Name = "Wedder Two:")]
        [Required]
        public int WedderTwoUserId {get;set;}

        [DataType(DataType.Date)]
        [Display(Name = "Wedding Date:")]
        [OnlyFutureDate]
        [Required]
        public DateTime WeddingDate {get;set;}
        
        [Display(Name = "Address:")]
        [Required]
        [StringLength(400)]
        public string Address {get;set;}

        [Required]
        public DateTime CreatedAt {get;set;}

        [Required]
        public DateTime UpdatedAt {get;set;}

        public User Creator {get;set;}
        public User WedderOne {get;set;}
        public User WedderTwo {get;set;}

        public List<Guest> Guests {get;set;}
    }

}