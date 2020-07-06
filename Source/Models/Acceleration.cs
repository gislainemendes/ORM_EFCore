using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    public class Acceleration
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public int challenge_id { get; set; }
        public DateTime created_at { get; set; }
        public List<Candidate> candidate { get; set; }
        public Challenge challenge { get; set; }
    }
}
