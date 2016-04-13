using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BadgeMakerBackEnd.Models
{
    public class QuizResponse
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public List<Answer> Answers { get; set; }
    }
}
