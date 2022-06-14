using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GitHubMVC.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required] // Not Nullable
        [StringLength(255)] // nvarchar(255)
        public string Name { get; set; }

    }
}