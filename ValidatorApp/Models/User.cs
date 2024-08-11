using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidatorApp.Models.Enums;

namespace ValidatorApp.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public UserPermission UserPermission { get; set; }
    }
}
