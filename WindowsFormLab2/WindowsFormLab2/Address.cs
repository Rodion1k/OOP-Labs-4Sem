using System;
using System.Xml.Serialization;

namespace WindowsFormLab2
{
    public interface IAddress
    {
        IAddress Clone();
    }

    [Serializable]
    public class Address : IAddress
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

        public Address(string town, string street, string index, string houseNum, string apNum)
        {
            Town = town;
            Street = street;
            Index = index;
            NumOfHouse = houseNum;
            NumOfApartment = apNum;
        }

        public Address()
        {
        }

        public IAddress Clone()
        {
            return new Address(Town, Street, Index, NumOfHouse, NumOfApartment);
        }
    }
}