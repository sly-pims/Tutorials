namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressID)
        {
            AddressID = addressID;
        }

        public int AddressID { get; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }


        public bool Validate()
        {
            var isValid = true;

            //if (string.IsNullOrWhiteSpace(Street1)) isValid = false;
            //if (string.IsNullOrWhiteSpace(Street2)) isValid = false;
            //if (string.IsNullOrWhiteSpace(City)) isValid = false;
            //if (string.IsNullOrWhiteSpace(State)) isValid = false;
            if (string.IsNullOrWhiteSpace(PostCode)) isValid = false;
            //if (string.IsNullOrWhiteSpace(Country)) isValid = false;

            return isValid;
        }
    }

}
