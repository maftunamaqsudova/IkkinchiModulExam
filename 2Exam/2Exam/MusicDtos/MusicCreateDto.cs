using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Exam.MusicDtos
{
    public class MusicCreateDto
    {
        public string? Name { get; set; }
        public string? AuthorName { get; set; }
        public string? Description { get; set; }
        public int QuentityLikes { get; set; }
    }
}
