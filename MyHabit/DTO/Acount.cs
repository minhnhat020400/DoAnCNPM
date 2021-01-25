using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHabit.DTO
{
    public class Acount
    {
        private string mail;
        private string n;
        private string p;

        public string email { get => mail; set => mail = value; }
        public string name { get => n; set => n = value; }
        public string password { get => p; set => p = value; }

    }
}
