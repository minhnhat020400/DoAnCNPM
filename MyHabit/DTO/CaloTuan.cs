using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHabit.DTO
{
    public class CaloTuan
    {
        string valo;
        string vreateAt;

        public string total { get => valo; set => valo = value; }
        public string createAt { get => vreateAt; set => vreateAt = value; }   
    }
}
