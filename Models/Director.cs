using System;
using System.ComponentModel.DataAnnotations;

namespace adfs2.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Birthday { get; set; }
    }

}