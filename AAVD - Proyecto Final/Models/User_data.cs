using AAVD___Proyecto_Final.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AAVD___Proyecto_Final.Models
{
    internal class User_data
    {
        static private User_data _currentSesion;

        #region _Constructors
        public User_data() {

        }

        /*private User_data(string userName, string userPassword, string names, string f_lastname, 
            string s_lastname, string status, string type) {
            this.userName = userName;
            this.userPassword = userPassword;
            this.names = names;
            this.f_lastname = f_lastname;
            this.s_lastname = s_lastname;
            this.status = status;
            this.type = type;
        }*/
        #endregion _Constructors

        #region _Attributes
        public Guid userID { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public string fullName { get; set; }
        public string dateOfBirth { get; set; }
        public string payrollNumber { get; set; }
        public string street_name { get; set; }
        public string ext_num { get; set; }
        public string district { get; set; }
        public string zipcode { get; set; }
        public string BC_PhoneNumer { get; set; }
        public string CellPhone { get; set; }
        public byte status { get; set; }
        public string type { get; set; }

        #endregion _Attributes

        public static User_data getInstance()
        {
            if (_currentSesion == null)
                _currentSesion = new User_data();
            return _currentSesion;
        }

        public bool blankSpaceValidation() {
            if (this.userEmail == "" || this.userPassword == "" || this.fullName == "" || this.dateOfBirth == "" || 
                this.payrollNumber == "" || this.street_name == "" || this.ext_num == "" || this.district == "" || 
                this.zipcode == "" ||  this.BC_PhoneNumer == "" || this.CellPhone == "" || this.type == "") {
                MessageBox.Show("Please, fill all the textboxs.", "Incomplete information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
