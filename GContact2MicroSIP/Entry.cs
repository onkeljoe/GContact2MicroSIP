using System.Xml.Serialization;

namespace GContact2MicroSIP
{
    public class Entry
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("number")]
        public string Phone { get; set; }
        [XmlAttribute("presence")]
        public int Presence { get; set; }
        [XmlAttribute("directory")]
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
