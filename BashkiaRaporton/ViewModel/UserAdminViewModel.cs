using BashkiaRaporton.Models;
using System.Collections.Generic;

namespace BashkiaRaporton.ViewModel
{
    public class UserAdminViewModel
    {
        public List<Banore> Banores { get; set; }
        public List<Role> Roles { get; set; }
    }
}
