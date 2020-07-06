using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    public class User
    {
        public int id { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public string nickName { get; set; }
        public string password { get; set; }
        public DateTime created_at { get; set; }
        public List<Candidate> candidate { get; set; }
        public List<Submission> submission { get; set; }
    }
}
