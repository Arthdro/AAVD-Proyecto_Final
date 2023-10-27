using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAVD___Proyecto_Final.Models
{
    internal class Hotel_Model
    {
        static private Hotel_Model _currentHotel;

        #region _Constructors
        public Hotel_Model(){

        }
        #endregion _Constructors

        public Guid hotelID { get; set; }
        public string hotelName { get; set; }
        public string street_name { get; set; }
        public string ext_num { get; set; }
        public string district { get; set; }
        public string zipcode { get; set; }
        public byte countryID { get; set; }
        public uint stateID { get; set; }
        public uint cityID { get; set; }
        public string begin_operation { get; set; }
        public byte floors { get; set; }
        public short rooms { get; set; }
        public string turistic_zone { get; set; }

        #region _Functions
        public static Hotel_Model getInstance()
        {
            if (_currentHotel == null)
                _currentHotel = new Hotel_Model();
            return _currentHotel;
        }

        public bool blankSpaceValidation()
        {
            if (this.hotelName == "" || this.street_name == "" || this.ext_num == "" ||
                this.district == "" || this.zipcode == "" || this.countryID == 0 ||
                this.stateID == 0 || this.cityID == 0 || this.begin_operation == "" ||
                this.floors == 0 || this.rooms == 0 || this.turistic_zone == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion _Functions

    }
}
