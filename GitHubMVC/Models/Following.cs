using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GitHubMVC.Models
{
    public class Following
    {
        [Key]
        [Column(Order= 1)]
        public int FollowerId { get; set; }
        public ApplicationUser Follower { get; set; }

        [Key]
        [Column(Order = 2)]
        public int FolloweeId { get; set; }
        public ApplicationUser Followee { get; set; }

    }
}