using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    public class Submission
    {
        public decimal score { get; set; }
        public int user_id { get; set; }
        public int challenge_id { get; set; }
        public DateTime created_at { get; set; }
        public User user { get; set; }
        public Challenge challenge { get; set; }
    }
}
