using AAVD___Proyecto_Final.DB;
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

namespace AAVD___Proyecto_Final.Forms
{
    public partial class AddRooms_Form : Form
    {
        Guid _currentUser;
        Guid selectedHotel;
        Managment db;
        public AddRooms_Form()
        {
            InitializeComponent();
            NUDAmounPeople.Minimum = 1;
            NUDQuantityBeds.Minimum = 1;
            NUDQuantityRooms.Minimum = 1;
            cmBoxStates.Enabled = false;
            cmboxCity.Enabled = false;
            cmboxHotel.Enabled = false;
            txtboxRoomName.Enabled = false;
            cmboxTypeBed.Enabled = false;
            cmboxRoomLevel.Enabled = false;
            db = Managment.getInstance();
            List<Country_Model> countries = db.getCountries();
            cmBoxCountries.DisplayMember = "countryName";
            cmBoxCountries.ValueMember = "countryID";
            cmBoxCountries.DataSource = countries;
        }

        private void btnAddRooms_Click(object sender, EventArgs e) {
            

            Managment db = Managment.getInstance();
            Room_model new_room = new Room_model();
            //Client_Model new_client = Client_Model.getInstance();
            if (getParameters(new_room) == null) {
                return;
            }
            else {
                db.createRoom(new_room, _currentUser);
                MessageBox.Show("The new client was added.", "Task completed successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
        }

        public void getSession(Guid aux_ID){
            _currentUser = aux_ID;
        }

        private void cmBoxStates_SelectedIndexChanged(object sender, EventArgs e) {
            int selectedState = int.Parse(cmBoxStates.SelectedValue.ToString());
            List<City_Model> cities = db.getCities(selectedState);
            if (cities.Count() != 0)
            {
                cmboxCity.DisplayMember = "cityName";
                cmboxCity.ValueMember = "cityID";
                cmboxCity.DataSource = cities;
                cmboxCity.Enabled = true;
            }
            else
            {
                cmBoxStates.Enabled = false;
                cmboxCity.Enabled = false;
            }
        }

        private void cmboxCity_SelectedIndexChanged(object sender, EventArgs e) {
            int selectedCity = int.Parse(cmboxCity.SelectedValue.ToString());
            int selectedState = int.Parse(cmBoxStates.SelectedValue.ToString());
            int selectedCountry = int.Parse(cmBoxCountries.SelectedValue.ToString());
            List<Hotel_Model> selectedHotels = db.getHotelsByCity(selectedCity, selectedState, selectedCountry);
            if (selectedHotels.Count() != 0) {
                cmboxHotel.DisplayMember = "hotelName";
                cmboxHotel.ValueMember = "hotelID";
                cmboxHotel.DataSource = selectedHotels;
                cmboxHotel.Enabled = true;
            }
            else {
                /*cmBoxStates.Enabled = false;
                cmboxCity.Enabled = false;*/
            }
        }

        private void cmBoxCountries_SelectedIndexChanged(object sender, EventArgs e) {
            int selectedCountry = int.Parse(cmBoxCountries.SelectedValue.ToString());
            List<State_Model> states = db.getStates(selectedCountry);
            if (states.Count() != 0)
            {
                cmBoxStates.DisplayMember = "stateName";
                cmBoxStates.ValueMember = "stateID";
                cmBoxStates.DataSource = states;
                cmBoxStates.Enabled = true;
            }
            else
            {
                cmBoxStates.Enabled = false;
                cmboxCity.Enabled = false;
            }
        }

        private void cmboxHotel_SelectedIndexChanged(object sender, EventArgs e) {
            selectedHotel = Guid.Parse(cmboxHotel.SelectedValue.ToString());
        }

        private Room_model getParameters(Room_model aux_model) {
            //aux_model.roomId = txtboxFNClient.Text;
            aux_model.roomName = txtboxRoomName.Text;
            aux_model.typeOfBed = cmboxTypeBed.Text;
            aux_model.roomLevel = cmboxRoomLevel.Text;
            aux_model.hotelID = Guid.Parse(cmboxHotel.SelectedValue.ToString());
            aux_model.amountOfPeople = byte.Parse(NUDAmounPeople.Value.ToString());
            aux_model.quantityOfBeds = byte.Parse(NUDQuantityBeds.Value.ToString());
            aux_model.quantityRoom = byte.Parse(NUDQuantityRooms.Value.ToString());
            aux_model.roomSize = float.Parse(txtboxSize.Text);
            aux_model.roomPrice = float.Parse(txtboxPriceNight.Text);
            //aux_model.status = txtboxCellPhoneClient.Text;

            bool validation = aux_model.blankSpaceValidation();
            if (validation)
                return null;
            else
                return aux_model;
        }
    }
}
