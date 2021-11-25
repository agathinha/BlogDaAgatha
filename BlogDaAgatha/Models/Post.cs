﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogDaAgatha.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [StringLength(500)]

        public string Title { get; set; }
        [Required]
        [StringLength(4000)]
        [AllowHtml]
        public string Body { get; set; }
       
        public DateTime DateCreated { get; set; }
       public DateTime? DateUpdated { get; set; }


    }
}