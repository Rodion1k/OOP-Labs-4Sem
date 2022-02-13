using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace WindowsFormLab2
{
    [Serializable]
    public class Address
    {
        
        [XmlElement(ElementName = "Town")]
        public string Town { get; set; }
        [XmlElement(ElementName = "Street")]
        public string Street { get; set; }
        [XmlElement(ElementName = "Index")]
        public int Index { get; set; }
        [XmlElement(ElementName = "NumOfHouse")]
        public int NumOfHouse { get; set; }
        [XmlElement(ElementName = "NumOfApartment")]
        public int NumOfApartment { get; set; }
    }
}