using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    public class Company
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public DateTime created_at { get; set; }
        public List<Candidate> candidate { get; set; }

    }
}