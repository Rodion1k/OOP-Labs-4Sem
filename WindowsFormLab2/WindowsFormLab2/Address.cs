using System;
using System.Xml.Serialization;

namespace WindowsFormLab2
{
    [Serializable]
    public class Address
    {
        [XmlElement(ElementName = "Town")]
        [AddressTown]
        public string Town { get; set; }
        [XmlElement(ElementName = "Street")]
        [AddressStreet]
        public string Street { get; set; }
        [XmlElement(ElementName = "Index")]
        [AddressIndex]
        public string Index { get; set; }
        [XmlElement(ElementName = "NumOfHouse")]
        [AddressHouse]
        public string NumOfHouse { get; set; }
        [XmlElement(ElementName = "NumOfApartment")]
        [AddressApartment]
        public string NumOfApartment { get; set; }
    }
}