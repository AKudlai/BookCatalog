﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookCatalog.Web.Models
{
    public class AuthorViewModel
    {
        public Guid AuthorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;
    }
}