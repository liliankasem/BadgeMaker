using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BadgeMakerBackEnd.Models
{
    public class QuestionOption
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCorrect { get; set; }
    }
}
