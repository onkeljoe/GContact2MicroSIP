using System;
using System.IO;

namespace GContact2MicroSIP
{
    public class Entry
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Presence { get; set; }
        public int Directory { get; set; }

        public Entry (string name, string phone, int presence, int directory)
        {
            Name = name;
            Phone = phone;
            Presence = presence;
            Directory = directory;
        }
        public Entry (string name, string phone)
        {
            Name = name;
            Phone = phone;
            Presence = 0;
            Directory = 0;
        }

        public Entry()
        {
            Name = string.Empty;
            Phone = string.Empty;
            Presence = 0;
            Directory = 0;
        }
       
    }

}
