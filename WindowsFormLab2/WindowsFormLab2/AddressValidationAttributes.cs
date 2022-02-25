using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WindowsFormLab2
{
    public class AddressIndexAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Regex validIndex = new Regex(@"\d{6}");
            if (value != null && validIndex.IsMatch(value.ToString()))
                return true;
            this.ErrorMessage = @"invalid index";
            return false;
        }
    }

    public class AddressStreetAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null && Student.CheckTextBox(value.ToString()) && !string.IsNullOrWhiteSpace(value.ToString()))
                return true;
            this.ErrorMessage = @"invalid street";
            return false;
        }
    }
    public class AddressTownAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null && Student.CheckTextBox(value.ToString()) && !string.IsNullOrWhiteSpace(value.ToString()))
                return true;
            this.ErrorMessage = @"invalid town";
            return false;
        }
    }

    public class AddressHouseAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Regex validHouse = new Regex(@"^[0-9]+([A-Z])?$");
            if(value != null && validHouse.IsMatch(value.ToString()))
                return true;
            this.ErrorMessage = @"invalid house number";
            return false;
        }
    }
    public class AddressApartmentAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Regex validHouse = new Regex(@"^[0-9]+$");
            if(value != null && validHouse.IsMatch(value.ToString()))
                return true;
            this.ErrorMessage = @"invalid apartment number";
            return false;
        }
    }
    // public class AddressValidationAttribute : ValidationAttribute
    // {
    //     public override bool IsValid(object value)
    //     {
    //         Address address = value as Address;
    //         if (address != null && address.NumOfApartment != 0 && address.NumOfHouse != 0)
    //             return true;
    //         this.ErrorMessage = @"invalid address";
    //         return false;
    //     }
    // }
    
}