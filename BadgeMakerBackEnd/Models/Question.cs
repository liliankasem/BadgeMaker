using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BadgeMakerBackEnd.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string QuestionText { get; set; }

        public List<QuestionOption> Options { get; set; }

        public string Owner { get; set; }
    }
}
