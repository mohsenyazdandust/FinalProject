using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class MemberModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string joined_at { get; set; }
        public string phone { get; set; }
        public string paid { get; set; }
        public string age { get; set; }

        public MemberModel(string id, string name, string joined_at, string phone, string paid, string age)
        {
            this.name = name;
            this.id = id;
            this.joined_at = joined_at;
            this.phone = phone;
            this.paid = paid;
            this.age = age;
        }
    }
}
