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

        private void btnAddRooms_Click(object sender, EventArgs e)
        {

        }

        public void getSession(Guid aux_ID){
            _currentUser = aux_ID;
        }
    }
}
