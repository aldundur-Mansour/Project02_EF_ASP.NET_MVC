﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Induction.Models
{
    public class ChapterChunkModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public DateTime CreatedAt { get; set;  }
        [Required]
        public int CurrentPage { get; set; } 
        
        
        
        //Relationship : One-To-Many: Chapter => ChapterChunks
        public ChapterModel Chapter { get; set; }
        //FK
        public int ChapterId { get; set; } 
    }
}