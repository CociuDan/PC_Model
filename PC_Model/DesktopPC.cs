using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PC_Model
{
    public class DesktopPC : IPC
    {
        CPU IPC.CPU { get; set; }

        GPU IPC.GPU { get; set; }

        RAM IPC.RAM { get; set; }

        HDD IPC.HDD { get; set; }

        public CASE CASE { get; set; }

        public PSU PSU { get; set; }

        public MotherBoard MotherBoard { get; set; }

        public string RunOS(string OSName)
        {
            return OSName;
        }

        public void PlayGames()
        {
            
        }

        public void InternetBrowsing()
        {
            
        }

        public void WorkingWIthDocuments()
        {
            
        }

        public void VideoRendering()
        {
            
        }

        public void PhotoEditing()
        {
            
        }

        public void ProducingMusic()
        {
            
        }
    }
}