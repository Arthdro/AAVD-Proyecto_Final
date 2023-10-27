using AAVD___Proyecto_Final.DB;
using AAVD___Proyecto_Final.Models;
using Cassandra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD___Proyecto_Final.Forms
{
    public partial class CRUDHotel_Form : Form
    {
        Managment db;
        Guid _currentUser;
        
        public CRUDHotel_Form()
        {
            InitializeComponent();
            nUDFloors.Minimum = 1;
            nUDRooms.Minimum = 1;
            cBoxState.Enabled = false;
            cBoxCity.Enabled = false;
            db = Managment.getInstance();
            List<Country_Model> countries = db.getCountries();
            cBoxCountry.DisplayMember = "countryName";
            cBoxCountry.ValueMember = "countryID";
            cBoxCountry.DataSource = countries;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit", "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                this.Close();
            }
            else
                return;
        }

        private void btnAddHotel_Click(object sender, EventArgs e) {
            Hotel_Model new_hotel = Hotel_Model.getInstance();
            //new_hotel = getParameters(new_hotel);
            if (getParameters(new_hotel) == null)
                return;
            else {
                db.createHotel(new_hotel, _currentUser);
                MessageBox.Show("The new hotel was added.", "Task completed successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

        }

        #region _Form-Validations
        private void cBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCountry = int.Parse(cBoxCountry.SelectedValue.ToString());
            List<State_Model> states = db.getStates(selectedCountry);
            if (states.Count() != 0)
            {
                cBoxState.DisplayMember = "stateName";
                cBoxState.ValueMember = "stateID";
                cBoxState.DataSource = states;
                cBoxState.Enabled = true;
            }
            else
            {
                cBoxState.Enabled = false;
                cBoxCity.Enabled = false;
            }
        }

        private void cBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedState = int.Parse(cBoxState.SelectedValue.ToString());
            List<City_Model> cities = db.getCities(selectedState);
            if (cities.Count() != 0)
            {
                cBoxCity.DisplayMember = "cityName";
                cBoxCity.ValueMember = "cityID";
                cBoxCity.DataSource = cities;
                cBoxCity.Enabled = true;
            }
            else
            {
                cBoxState.Enabled = false;
                cBoxCity.Enabled = false;
            }
        }

        private void txtboxHotelName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 37) || (e.KeyChar > 39 && e.KeyChar <= 44) ||
                (e.KeyChar == 47) || (e.KeyChar > 59 && e.KeyChar <= 64) || (e.KeyChar > 91 && e.KeyChar <= 96) ||
                (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Character not allowed.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxHotelStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 37) || (e.KeyChar > 39 && e.KeyChar <= 44) ||
                (e.KeyChar == 47) || (e.KeyChar > 59 && e.KeyChar <= 64) ||
                (e.KeyChar > 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Character not allowed.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxHotelNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) ||
                (e.KeyChar >= 90 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("This textbox do not accepts special characters.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxHotelSuburb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) ||
                (e.KeyChar >= 90 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("This textbox do not accepts special characters.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxHotelZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("This space only accpets numbers.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion _Form-Validations

        private Hotel_Model getParameters(Hotel_Model aux) {
            aux.hotelName = txtboxHotelName.Text;
            aux.street_name = txtboxHotelStreet.Text;
            aux.ext_num = txtboxHotelNumber.Text;
            aux.district = txtboxHotelSuburb.Text;
            aux.zipcode = txtboxHotelZipCode.Text;
            aux.countryID = byte.Parse(cBoxCountry.SelectedValue.ToString());
            aux.stateID = byte.Parse(cBoxState.SelectedValue.ToString());
            aux.cityID = byte.Parse(cBoxCity.SelectedValue.ToString());
            aux.begin_operation = dtpBeginOperations.Text;
            aux.floors = byte.Parse(nUDFloors.Value.ToString());
            aux.rooms = byte.Parse(nUDRooms.Value.ToString());
            aux.turistic_zone = txtBoxTuristicZone.Text;

            bool validation = aux.blankSpaceValidation();
            if (validation)
                return null;
            else {

                return aux;
            }
        }

        public void getSession(Guid aux_ID)  {
            _currentUser = aux_ID;

            return;
        }

    }
}
