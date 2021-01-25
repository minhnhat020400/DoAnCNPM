using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHabit.DTO
{
    class ChangeAcc
    {
        private string mail;
        private string pass;

        public string email { get => mail; set => mail = value; }
        public string password { get => pass; set => pass = value; }
    }
}

