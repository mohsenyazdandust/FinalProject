using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    internal class AppUser
    {
        public string username { get; set; }
        public string is_superuser { get; set; }

        public AppUser(string username) 
        {
            this.username = username;
        }
    }
}
