using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3S2
{
    internal class shipfile
    {
        private string _passengerFirstName;
        private string _passengerSurname;
        private string _age;
        private string _gender;
        private string _departCountry;
        private string _destination;
        private string _passengerPort;
        private string _manifestNum;
        private string _date;
        private string _occupation;

        //properties
        public string PassengerFirstName
        {
            get { return _passengerFirstName; }
            set { _passengerFirstName = value; }
        }

        public string Occupation
        {
            get { return _occupation; }
            set { _occupation = value; }
        
        }

        public string PassengerSurname
        {
            get { return _passengerSurname; }
            set { _passengerSurname = value; }
        }
        public string Age
        {
            get { return _age; }
            set
            {
                _age = value;
            }
        }
        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
            }

        }
        public string DepartCountry
        {
            get { return _departCountry; }
            set
            {
                _departCountry = value;
            }
        }
        public string Destination
        {
            get { return _destination; }
            set
            {
                _destination = value;
            }
        }
        public string PassengerPort
        {
            get { return _passengerPort; }
            set
            {
                _passengerPort = value;
            }
        }
        public string ManifestNum
        {
            get { return _manifestNum; }
            set
            {
                _manifestNum = value;
            }
        }
        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        //constructor
        public shipfile(string passengerFirstName, string passengerSurname, string age,string gender, string occupation, string departCountry, string destination, string passengerPort, string manifestNum, string date)
        {
            PassengerFirstName = passengerFirstName;
            PassengerSurname = passengerSurname;
            Age = age;
            Gender = gender;
            Occupation = occupation;
            DepartCountry = departCountry;
            Destination = destination;
            PassengerPort = passengerPort;
            ManifestNum = manifestNum;
            Date = date;
            
        }

       







    }
}
