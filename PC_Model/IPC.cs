using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PC_Model
{
    public interface IPC
    {
        CPU CPU { get; set; }
        GPU GPU { get; set; }
        RAM RAM { get; set; }
        HDD HDD { get; set; }

        string RunOS(string OSName);
    }
}