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
    public partial class Home_Menu : Form
    {
        //User_data _currentSesion;
        //User_data session;
        Guid _currentUser;
        string _userType = "";
        public Home_Menu() {
            InitializeComponent();
            customizeDesing();
            //session = User_data.getInstance();
        }

        //regex.com
        //regex tutorial
        //^ Inicio de cadena
        //$ Final de cadena
        //+ mínimo una vez o muchas veces
        //? puede no estar o estar una vez
        //* puede no estar o estar muchas veces
        //() busca un grupo de caracteres que se encuentren en coonjunto
        //{4,6} busca que exista la y 4 veces entre 6
        //[] 
        // ([a-z0-9]+)([a-z0-9\.\_]*)@([a-z0-9]+)(\.([a-z]){2,4})+

        /// <summary>
        /// Source: DataPropertyName idHotel (Se agrega el nombre del dato que va a alamcenar)
        /// 
        /// </summary>

        #region _Variables
        private Form activeForm = null;
        #endregion

        #region _ChildForm
        private void openChildForm(Form childForm) {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region _SubMenu-System
        private void customizeDesing() {
            //pnlPrincipalMenu.Visible = false;
            pnlSMCheckAndCancel.Visible = false;
            pnlSMEmployeeManagment.Visible = false;
            pnlSMHotelManagment.Visible = false;
            pnlSMSystemReport.Visible = false;
        }

        private void hideSubMenu() {
            //if (pnlPrincipalMenu.Visible == true)
            //    pnlPrincipalMenu.Visible = false;
            if (pnlSMCheckAndCancel.Visible == true)
                pnlSMCheckAndCancel.Visible = false;
            if (pnlSMEmployeeManagment.Visible == true)
                pnlSMEmployeeManagment.Visible = false;
            if (pnlSMHotelManagment.Visible == true)
                pnlSMHotelManagment.Visible = false;
            if (pnlSMSystemReport.Visible == true)
                pnlSMSystemReport.Visible = false;
        }

        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false) {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion _SubMenu-System

        #region _SubMenu
        private void btnSystemReport_Click(object sender, EventArgs e) {
            showSubMenu(pnlSMSystemReport);
        }

        private void btnHotelManagment_Click(object sender, EventArgs e) {
            showSubMenu(pnlSMHotelManagment);
        }

        private void btnEmployeeManagment_Click(object sender, EventArgs e) {
            showSubMenu(pnlSMEmployeeManagment);
        }

        private void btnReservations_Click(object sender, EventArgs e) {
            showSubMenu(pnlSMCheckAndCancel);
        }


        #endregion _SubMenu

        #region _Buttons-SubMenu
        private void btnSMSalesReport_Click(object sender, EventArgs e)
        {
            SalesReport_Form salesReport_Form = new SalesReport_Form();
            openChildForm(salesReport_Form);

            //..
            //.. Code
            //..
            hideSubMenu();
        }

        private void btnSMCustomerRecord_Click(object sender, EventArgs e)
        {
            CustomerRecord_Form customerRecord_Form = new CustomerRecord_Form();
            openChildForm(customerRecord_Form);
            //..
            //.. Code
            //..
            hideSubMenu();
        }

        private void btnSMHotelOccupancy_Click(object sender, EventArgs e)
        {
            //..
            //.. Code
            //..
            hideSubMenu();
        }

        private void btnSMCRUDHotel_Click(object sender, EventArgs e)
        {
            CRUDHotel_Form crudHotel_Form = new CRUDHotel_Form();
            openChildForm(crudHotel_Form);
            crudHotel_Form.getSession(_currentUser);
            hideSubMenu();
        }

        private void btnSMCRUDRooms_Click(object sender, EventArgs e)
        {
            //..
            //.. Code
            //..
            hideSubMenu();
        }

        private void btnSMCRUDEmployee_Click(object sender, EventArgs e)
        {
            CRUDUser_Form crudUser_Form = new CRUDUser_Form();
            openChildForm(crudUser_Form);
            crudUser_Form.getSession(_currentUser);
            hideSubMenu();
        }

        private void btnCRUDClient_Click(object sender, EventArgs e)
        {
            CRUDClient_Form crudClient_Form = new CRUDClient_Form();
            openChildForm(crudClient_Form);
            crudClient_Form.getSession(_currentUser);
            hideSubMenu();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            //..
            //.. Code
            //..
            hideSubMenu();
        }

        private void btnSMCheckIn_Click(object sender, EventArgs e)
        {
            //..
            //.. Code
            //..
            hideSubMenu();
        }

        private void btnSMCheckOut_Click(object sender, EventArgs e)
        {
            //..
            //.. Code
            //..
            hideSubMenu();
        }

        private void btnSMCancelation_Click(object sender, EventArgs e)
        {
            //..
            //.. Code
            //..
            hideSubMenu();
        }
        #endregion _Buttons-SubMenu

        #region _Functions
        public void getSession(Guid aux_ID, string aux_type)
        {
            _currentUser = aux_ID;
            _userType = aux_type;
            if (_userType == "ADMIN"){

            }
            else if (_userType == "OPERATOR") {
                btnSystemReport.Visible = false;
                btnHotelManagment.Visible = false;
                btnEmployeeManagment.Visible = false;
            }
        }
        #endregion _Functions
    }
}
