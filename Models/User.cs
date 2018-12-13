using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [Required]
        public int UserId {get;set;}

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address:")]
        [Required]
        [StringLength(200)]
        public string Email {get;set;}
        
        [Display(Name = "First Name:")]
        [MinLength(2, ErrorMessage="First Name must be at least 2 characters long")]
        [Required]
        [StringLength(40)]
        public string FirstName {get;set;}
        
        [Display(Name = "Last Name:")]
        [MinLength(2, ErrorMessage="Last Name must be at least 2 characters long")]
        [Required]
        [StringLength(40)]
        public string LastName {get;set;}
        
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters long")]
        [Required]
        [StringLength(400)]
        public string Password {get;set;}
        
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password:")]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters long")]
        [NotMapped]
        [Required]
        [StringLength(400)]
        public string ConfirmPassword {get;set;}

        [Required]
        public DateTime CreatedAt {get;set;}

        [Required]
        public DateTime UpdatedAt {get;set;}
    }

}