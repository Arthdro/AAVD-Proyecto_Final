using AAVD___Proyecto_Final.DB;
using AAVD___Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD___Proyecto_Final.Forms
{
    public partial class CRUDUser_Form : Form
    {
        Guid _currentUser;
        public CRUDUser_Form()
        {
            InitializeComponent();
            cboxTypeOfUser.DisplayMember = "Text";
            cboxTypeOfUser.ValueMember = "Value";
            cboxTypeOfUser.Items.Add(new { Text = "OPERATOR", Value = "0" });
            cboxTypeOfUser.Items.Add(new { Text = "ADMIN", Value = "1" });
        }

        private void btnAddEditOp_Click(object sender, EventArgs e) {
            try {
                Managment db = Managment.getInstance();
                User_data new_user = User_data.getInstance();

                if (getParameters(new_user) == null)
                    return;            
                else {
                    db.createUser(new_user, _currentUser);
                    MessageBox.Show("The new client was added.", "Task completed successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
            }
            catch (Exception) {

                throw;
            }
            
        }

        private void btnDeleteOp_Click(object sender, EventArgs e) {

        }

        private void btnCancelOp_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit", "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                this.Close();
            }
            else
                return;
            
        }

        private User_data getParameters(User_data aux_model) {

            aux_model.fullName = txtboxLastName1.Text;
            aux_model.fullName = aux_model.fullName + " " + txtboxLastName2.Text;
            aux_model.fullName = aux_model.fullName + " " + txtboxFirstNameOp.Text;
            aux_model.userEmail = txtboxEmailOp.Text;
            aux_model.payrollNumber = txtboxPayrollNum.Text;
            aux_model.dateOfBirth = datetpDOB.Text;
            aux_model.userPassword = txtboxPasswordOp.Text;
            aux_model.street_name = txtboxStreetOp.Text;
            aux_model.ext_num = txtboxHouseNoOp.Text;
            aux_model.district = txtboxSuburbOp.Text;
            aux_model.zipcode = txtboxZipCodeOp.Text;
            aux_model.BC_PhoneNumer = txtboxHomePhoneOp.Text;
            aux_model.CellPhone = txtboxCellPhoneOp.Text;
            aux_model.type = cboxTypeOfUser.Text;

            bool validation = aux_model.blankSpaceValidation();
            if (validation)
                return null;
            else {
                if (EmailValidation(aux_model.userEmail) || passwordValidation(aux_model.userPassword))
                    return null;
                else
                    return aux_model;
            }
        }

        #region _Form-Validations
        private void txtboxFirstNameOp_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255)) {
                MessageBox.Show("This textbox only accepts letters.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxLastName1_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))  {
                MessageBox.Show("This textbox only accepts letters.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxLastName2_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255)) {
                MessageBox.Show("This textbox only accepts letters.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxZipCodeOp_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) {
                MessageBox.Show("This space only accpets numbers.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxHomePhoneOp_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) {
                MessageBox.Show("This space only accpets numbers.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxCellPhoneOp_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) {
                MessageBox.Show("This space only accpets numbers.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxPayrollNum_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) {
                MessageBox.Show("This space only accpets numbers.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public bool EmailValidation(string aux_user) {
            var emailFormat = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
            bool isValidated = emailFormat.IsMatch(aux_user);
            if (!isValidated)
            {
                MessageBox.Show("The email does not satisfy the current format.",
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else
                return false;
        }

        public bool passwordValidation(string p_password) {
            var upperCaseFormat = new Regex(@"[A-Z]+");
            var lowercaseFormat = new Regex(@"[a-z]+");
            var numbersFormat = new Regex(@"[0-9]+");
            var specialCharactersFormat = new Regex(@"[¡”#$%&\/\.=’?¡¿:;,.\-_+\*{\][}]+");
            var lengthFormt = p_password.Length;

            if (lengthFormt < 8 || lengthFormt > 16) {
                MessageBox.Show("The password has to be between 8 and 16 chararters.",
                   "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else {
                if (!upperCaseFormat.IsMatch(p_password) || !lowercaseFormat.IsMatch(p_password))
                {
                    MessageBox.Show("The password needs an uppercase and lowercase.",
                   "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
                else if (!numbersFormat.IsMatch(p_password))
                {
                    MessageBox.Show("The password needs numbers.",
                   "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
                else if (!specialCharactersFormat.IsMatch(p_password))
                {
                    MessageBox.Show("The password needs an special characters.",
                   "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
                else
                    return false;
            }
        }

        public void getSession(Guid aux_ID) {
            _currentUser = aux_ID;
        }


        #endregion _Form-Validations
    }
}
