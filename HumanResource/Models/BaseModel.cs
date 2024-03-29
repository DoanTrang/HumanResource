﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.Models
{
    [NotMapped]
    class BaseModel
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
    
    class BaseModel2
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CRUDDate { get; set; }
        public DateTime CRUDBy { get; set; }

    }
}
