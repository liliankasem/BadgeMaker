﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BadgeMakerBackEnd.Models
{
    public class Quiz
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<Question> Question { get; set; }

        public string Owner { get; set; }
    }
}
