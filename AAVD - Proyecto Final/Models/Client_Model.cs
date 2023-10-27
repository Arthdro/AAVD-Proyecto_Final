using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD___Proyecto_Final.Models
{
    internal class Client_Model
    {
        #region _Atributtes
        static private Client_Model _currentSesion;
        public Guid clientID { get; set; }
        public string fullName { get; set; }
        public string street_name { get; set; }
        public string ext_num { get; set; }
        public string district { get; set; }
        public string zipcode { get; set; }
        public string rfc { get; set; }
        public string email { get; set; }
        public string BC_PhoneNumer { get; set; }
        public string CellPhone { get; set; }
        public string dateOfBirth { get; set; }
        public byte status { get; set; } = 0;
        public string civilStatus { get; set; }
        #endregion

        #region _Constructors
        public Client_Model() {

        }
        #endregion _Constructors

        #region _Functions
        public static Client_Model getInstance()
        {
            if (_currentSesion == null)
                _currentSesion = new Client_Model();
            return _currentSesion;
        }

        public bool blankSpaceValidation()
        {
            if (this.fullName == "" || this.street_name == "" || this.ext_num == "" ||
                this.district == "" || this.zipcode == "" || this.rfc == "" ||
                this.email == "" || this.BC_PhoneNumer == "" || this.CellPhone == "" ||
                this.dateOfBirth == "" || this.civilStatus == "") {
                MessageBox.Show("Please, fill all the textboxs.", "Incomplete information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
