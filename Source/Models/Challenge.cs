using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    public class Challenge
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public DateTime created_at { get; set; }
        public List<Submission> submission { get; set; }
        public List<Acceleration> acceleration { get; set; }
    }
}
