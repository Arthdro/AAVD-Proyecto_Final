using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAVD___Proyecto_Final.Models
{
    internal class City_Model
    {
        #region Attributes
        public int cityID { get; set; } = 0;
        public string cityName { get; set; }
        //public string cityAbbrevation { get; set; }
        public byte status { get; set; }
        public int stateID { get; set; } = 0;
        #endregion Attributes
    }
}
