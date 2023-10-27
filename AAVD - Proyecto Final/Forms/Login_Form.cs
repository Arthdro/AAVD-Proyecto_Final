using AAVD___Proyecto_Final.DB;
using AAVD___Proyecto_Final.Forms;
using AAVD___Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD___Proyecto_Final
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)  {  
            
            try {
                string userEmail = txtboxUsername.Text;
                string password = txtboxPassword.Text;
                if (userEmail == "" || password == "") {
                    MessageBox.Show("There´s no information on the text box.");
                }
                else {
                    Managment db = Managment.getInstance();
                    if (db._checkUserName(userEmail)) {
                        User_data new_session = db.getUserData(userEmail, password);

                        if (new_session == null) {
                            MessageBox.Show("The password it´s no matching.");
                            db._wrongPasswordCounter(userEmail);
                        }
                        else {
                            this.Hide();
                            Home_Menu home_menu = new Home_Menu();
                            home_menu.getSession(new_session.userID, new_session.type);
                            home_menu.Show();              
                            //home_menu.getSession(new_session);
                        }
                   }                    
                }       
            }
            catch (Exception) {

                throw;
            }         
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ckBoxSPassword_CheckedChanged(object sender, EventArgs e) {
            txtboxPassword.PasswordChar = ckBoxSPassword.Checked ? '\0' : '*'; 
        }
    }
}
