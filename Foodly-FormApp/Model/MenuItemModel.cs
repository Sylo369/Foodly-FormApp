﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodly_FormApp.Model
{
    public class MenuItemModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string? Description { get; set; }

    }
}
