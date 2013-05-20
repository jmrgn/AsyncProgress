﻿using System.ComponentModel.DataAnnotations;

namespace AsyncDemo.Models
{
    public class ToDoItem
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public bool Finished { get; set; }
    }
}