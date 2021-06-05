using System.Collections.Generic;

namespace Induction.Models
{
    public class ChapterModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        
        
        //Relationship : One-To-Many: Book => Chapters
        public BookModel Book { get; set; }
        //FK 
        public int BookId { get; set; }
        
        
        //Relationship : One-To-Many: Chapter => ChapterChunks
        public List<ChapterChunkModel> ChapterChuncks { get; set; }
        


    }
}