using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD___Proyecto_Final.Models
{
    internal class Room_model
    {
        public uint roomId { get; set; } = 0;
        public string roomName { get; set; } = "";
        public string typeOfBed { get; set; } = "";
        public string roomLevel { get; set; } = "";
        public Guid hotelID { get; set; }

        /*public int cityID { get; set; } = 0;
        public int stateID { get; set; } = 0;
        public int countryID { get; set; } = 0;*/
        public byte amountOfPeople { get; set; } = 0;
        public byte quantityOfBeds { get; set; } = 0;
        public byte quantityRoom { get; set; } = 0;
        public float roomSize { get; set; } = 0;
        public float roomPrice { get; set; } = 0;
        public byte status { get; set; } = 0;

        #region _Functions
        public bool blankSpaceValidation()
        {
            if (this.roomName == "" || this.typeOfBed == "" ||  this.roomLevel == "" || 
                this.hotelID == null || this.amountOfPeople == 0 || this.quantityOfBeds == 0 || 
                this.quantityRoom == 0 || this.roomSize == 0 || this.roomPrice == 0) {
                MessageBox.Show("Please, fill all the textboxs.", "Incomplete information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else {
                return false;
            }
        }
        #endregion _Functions
    }
}
