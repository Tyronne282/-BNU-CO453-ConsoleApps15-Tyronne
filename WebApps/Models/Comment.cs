﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApps.Models
{
    public class Comment
    {
        // Primary Key
        public int CommentID { get; set; }

        // Foreign Key
        public int PostId { get; set; }

        public string Text { get; set; }

        public virtual Post Post { get; set; }
    }
}