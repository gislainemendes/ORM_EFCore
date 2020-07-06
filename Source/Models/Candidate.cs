using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    public class Candidate
    {
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public int user_id { get; set; }
        public int company_id { get; set; }
        public int acceleration_id { get; set; }
        public User user { get; set; }
        public Company company { get; set; }
        public Acceleration acceleration { get; set; }

    }
}
