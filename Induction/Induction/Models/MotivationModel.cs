using System;

namespace Induction.Models
{
    public class MotivationModel
    {
        public int id { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        
        
        
        
        //Relationship : One-To-Many: User => Motivations
        public UserModel User { get; set; }
        //FK 
        public int UserId { get; set; }
    }
}