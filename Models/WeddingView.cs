using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    [Table("DVW_Wedding")]
    public class WeddingView
    {
        [Key]
        [Required]
        public int WeddingId {get;set;}

        [Display(Name = "Creator Name")]
        [Required]
        public string CreatorName {get;set;}

        [Display(Name = "Wedding")]
        [Required]
        public string WedderOneTwoFirstName {get;set;}

        [DataType(DataType.Date)]
        [Display(Name = "Wedding Date:")]
        [Required]
        public DateTime WeddingDate {get;set;}

        [Display(Name = "Address")]
        [Required]
        public string Address {get;set;}

        [Display(Name = "Guest Count")]
        [Required]
        public int GuestCount {get;set;}

        public string GuestIds {get;set;}

        [Required]
        public int CreatorUserId {get;set;}

        [Required]
        public int WedderOneUserId {get;set;}

        [Required]
        public int WedderTwoUserId {get;set;}

        [Required]
        public DateTime CreatedAt {get;set;}

        [Required]
        public DateTime UpdatedAt {get;set;}
    }

}