using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PC_Model
{
    public class CPU
    {
        private int Cores { get; set; }
        private int Threads { get; set; }
        private decimal BaseFrequency { get; set; }
        private decimal BoostFrequency { get; set; }
        private int TDP { get; set; }
        private string Architecture { get; set; }
    }
}