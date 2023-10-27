using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAVD___Proyecto_Final.Models
{
    internal class State_Model
    {
        #region Attributes
        public int stateID { get; set; } = 0;
        public string stateName { get; set; }
        public string stateAbbrevation { get; set; }
        public byte status { get; set; }
        public int countryID { get; set; } = 0;
        #endregion Attributes
    }
}
