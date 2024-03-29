﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DVCP.ViewModel
{
    public class ViewPostViewModel
    {
        public int post_id { get; set; }
        public string firstTag { get; set; }
        public int? userid { get; set; }

        [Required]
        [StringLength(200)]
        public string post_title { get; set; }

        [Required]
        [StringLength(500)]
        public string post_teaser { get; set; }

        [StringLength(500)]
        public string post_review { get; set; }

        
        public string post_content { get; set; }
        public string post_slug { get; set; }

        public int post_type { get; set; }

        [StringLength(200)]
        public string post_tag { get; set; }

        public DateTime? create_date { get; set; }

        public DateTime? edit_date { get; set; }

        [StringLength(50)]
        public string dynasty { get; set; }

        public int ViewCount { get; set; }

        public int Rated { get; set; }

        [StringLength(200)]
        public string AvatarImage { get; set; }

        public bool status { get; set; }
        //public string firstTag { get; set; }
        public List<TagList> tagLists { get; set; }
        public String Comment { get; set; }
    }
    public class TagList
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
    }
}