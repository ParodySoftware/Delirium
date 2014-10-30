using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirium.Shared.Services.DataContracts
{
    public class User
    {
        public string Id { get; set; }

        public object Created { get; set; }

        public object Deleted { get; set; }

        public IEnumerable<object> Postings { get; set; }

        public string Name { get; set; }

        public string Mail { get; set; }

        public object Phone { get; set; }

        public bool Enabled { get; set; }

        public IEnumerable<Role> Roles { get; set; }

        public string Password { get; set; }
    }
}
