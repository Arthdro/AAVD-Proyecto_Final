using AAVD___Proyecto_Final.DB;
using AAVD___Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD___Proyecto_Final.Forms
{
    public partial class CRUDClient_Form : Form
    {
        Guid _currentUser;
        public CRUDClient_Form()
        {
            InitializeComponent();
            
            cBoxCivilStatus.DisplayMember = "Text";
            cBoxCivilStatus.ValueMember = "Value";
            cBoxCivilStatus.Items.Add(new { Text = "-- Elige una opción --", Value = "0" });
            cBoxCivilStatus.Items.Add(new { Text = "Soltera/o", Value = "1" });
            cBoxCivilStatus.Items.Add(new { Text = "Casada/o", Value = "2" });
            cBoxCivilStatus.Items.Add(new { Text = "Divorciado/a.", Value = "3" });
            cBoxCivilStatus.Items.Add(new { Text = "Separado/a en proceso judicial.", Value = "4" });
            cBoxCivilStatus.Items.Add(new { Text = "Viudo/a.", Value = "5" });
            cBoxCivilStatus.Items.Add(new { Text = "Concubinato.", Value = "6" });
            cBoxCivilStatus.SelectedIndex = 0;
        }

        #region _Form-Validations
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
        private void txtboxFNClient_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255)) {
                MessageBox.Show("This textbox only accepts letters.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtboxLN1Client_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255)) {
                MessageBox.Show("This textbox only accepts letters.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtboxLN2Client_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255)) {
                MessageBox.Show("This textbox only accepts letters.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtboxZipCodeClient_KeyPress(object sender, KeyPressEventArgs e){
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
                MessageBox.Show("This space only accpets numbers.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtboxHomePhoneClient_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) {
                MessageBox.Show("This space only accpets numbers.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtboxCellPhoneClient_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) {
                MessageBox.Show("This space only accpets numbers.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion _Form-Validations

        private void btnAddEditClient_Click(object sender, EventArgs e) {
            Managment db = Managment.getInstance();
            Client_Model new_client = Client_Model.getInstance();
            if (getParameters(new_client) == null) {
                return;
            }
            else {
                db.createClient(new_client, _currentUser);
                MessageBox.Show("The new client was added.", "Task completed successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
        }

        private void btnCancelClient_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit", "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                this.Close();
            }
            else
                return;
        }

        private Client_Model getParameters(Client_Model aux_model) {
            aux_model.fullName = txtboxFNClient.Text;
            aux_model.fullName = aux_model.fullName + " " + txtboxLN1Client.Text;
            aux_model.fullName = aux_model.fullName + " " + txtboxLN2Client.Text;
            aux_model.street_name = txtboxStreetClient.Text;
            aux_model.ext_num = txtboxHouseNoClient.Text;
            aux_model.district = txtboxSuburbClient.Text;
            aux_model.zipcode = txtboxZipCodeClient.Text;
            aux_model.rfc = txtboxRFC.Text;
            aux_model.email = txtboxEmailClient.Text;
            aux_model.BC_PhoneNumer = txtboxHomePhoneClient.Text;
            aux_model.CellPhone = txtboxCellPhoneClient.Text;
            aux_model.dateOfBirth = datetpDOB.Text;

            bool validation = aux_model.blankSpaceValidation();
            if (validation)
                return null;
            else {
                if(EmailValidation(txtboxEmailClient.Text) /* || funcion para RFC*/)
                    return null;
                else
                    return aux_model;
            }     
        }

        public void getSession(Guid aux_ID) {
            _currentUser = aux_ID;
            return;
        }
    }
}
