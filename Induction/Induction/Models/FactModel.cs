using System;
using System.ComponentModel.DataAnnotations;

namespace Induction.Models
{
    public class FactModel
    {
        public int Id { get; set; }
        [Required]
        public string Body { get; set; }
        public DateTime CreatedAt { get; set;  }
        [Url]
        public string Attachment { get; set; }
        
        
        
        
        //Relationship : One-To-Many: User => Facts
        public UserModel User { get; set; }
        //FK 
        public int UserId { get; set; }
    }
    
    
    
}