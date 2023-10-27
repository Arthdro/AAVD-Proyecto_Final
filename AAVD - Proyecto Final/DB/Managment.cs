using AAVD___Proyecto_Final.Forms;
using AAVD___Proyecto_Final.Models;
using Cassandra;
using Cassandra.Mapping;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AAVD___Proyecto_Final.DB
{
    internal class Managment
    {
        #region _Connection
        static private string cassandraHome { get; set; } = "";
        static private string keySpace { get; set; } = "";
        static private Cluster cluster;
        static private ISession session;                
        static private Managment _instance;
        #endregion _Connection
        private Managment() {
            Connect();
        }

        public static Managment getInstance()
        {
            if (_instance == null)
                _instance = new Managment();
            return _instance;
        }
        /*Investigar que es un Singleton
        Class GameManager()
        static GameManager gm
        private GameManager (){} 
        
        public GameManager getGameManager(){
         if(gm == null){
            gm = new GameManager();
         }
            return gm;
        }
        */
        private static void Connect() {
            cassandraHome = System.Configuration.ConfigurationSettings.AppSettings["AAVD"].ToString();
            keySpace = System.Configuration.ConfigurationSettings.AppSettings["keyspace"].ToString();
            cluster = Cluster.Builder().AddContactPoint(cassandraHome).Build();
            session = cluster.Connect(keySpace);
        }

        /*public List<User_data> getUserData(string p_username, string p_password)
        {
            string query = String.Format("SELECT * FROM HOTEL_SYSTEM.USER_DATA " +
                "WHERE userName = '{0}' AND userPassword = '{1}' ALLOW FILTERING;", p_username, p_password);
            session.Execute(query);
            IMapper mapper = new Mapper(session);
            IEnumerable<User_data> user_data = mapper.Fetch<User_data>(query);

            if (user_data.Count() == 0) {
                MessageBox.Show("No hay nada en la lista");
                return user_data.ToList();
            }
            else { 
            MessageBox.Show("Hay un elemento en la lista");
            return user_data.ToList();
            }
        }*/

        public User_data getUserData(string p_userEmail, string p_password)
        {
            try {
                string query = String.Format("Select userID, userEmail, userPassword, fullName, dateOfBirth,payrollNumber," +
                    "Address.street_name AS street_name, Address.ext_num AS ext_num, Address.district AS district, " +
                    "Address.zipcode AS zipcode, Phones.BC_PhoneNumer AS BC_PhoneNumer, Phones.CellPhone AS CellPhone, " +
                    "status,type FROM HOTEL_SYSTEM.USER_DATA WHERE userEmail = '{0}' " +
                    "AND userPassword = '{1}' ALLOW FILTERING", p_userEmail, p_password);
                session.Execute(query);
                IMapper mapper = new Mapper(session);
                IEnumerable<User_data> users_data = mapper.Fetch<User_data>(query);
                User_data current_user = users_data.FirstOrDefault();
                return current_user;                              
            }
            catch (Exception) {
                throw;
            }           
        }

        public bool _checkUserName(string p_username)
        {
            try
            {
                int result  = 0;
                string query = String.Format("SELECT * FROM HOTEL_SYSTEM.USER_DATA " +
                    "WHERE userEmail = '{0}' ALLOW FILTERING;", p_username);
                session.Execute(query);
                IMapper mapper = new Mapper(session);
                IEnumerable<User_data> users_data = mapper.Fetch<User_data>(query);
                result = users_data.Count();
                if (result != 0) {
                    return true;
                }
                else {
                    MessageBox.Show("There´s no username on the database.");
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void _wrongPasswordCounter(string p_username)
        {
            try
            {
                string query = String.Format("Update HOTEL_SYSTEM.PASSWORD_COUNTER SET wrong_password = wrong_password + 1 " +
                    "WHERE userName = '{0}'; ", p_username);
                session.Execute(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void createUser(User_data new_user, Guid aux_session) {
            try {
            string query = String.Format("INSERT INTO HOTEL_SYSTEM.USER_DATA (userID, userEmail, userPassword, fullName, " +
             "dateOfBirth, payrollNumber, Address, Phones, status, type, user_crea, date_crea, user_modif, date_modif) " +
             "VALUES (UUID(), '{0}', '{1}', '{2}', '{3}', '{4}', " +
             "{{street_name: '{5}', ext_num: '{6}', district: '{7}', zipcode: '{8}'}}, " +
             "{{BC_PhoneNumer: '{9}', CellPhone: '{10}'}}, {11}, '{12}', {13}, toTimestamp(toDate(now())), " +
             "{14}, toTimestamp(toDate(now()))) IF NOT EXISTS", new_user.userEmail, new_user.userPassword, new_user.fullName, new_user.dateOfBirth, new_user.payrollNumber,
            new_user.street_name, new_user.ext_num, new_user.district, new_user.zipcode, new_user.BC_PhoneNumer, new_user.CellPhone,
            new_user.status, new_user.type, aux_session, aux_session);
                session.Execute(query);
            }
            catch (Exception) {

                throw;
            }          
        }

        public void createClient(Client_Model new_client, Guid aux_session)
        {
            try
            {
                string query = String.Format("INSERT INTO HOTEL_SYSTEM.CLIENT_DATA (clientID, fullName, address," +
                 " rfc, email, phones, dateOfBirth, status, user_crea, date_crea, user_modif, date_modif)" +
                 "VALUES (UUID(), '{0}', {{street_name: '{1}', ext_num: '{2}', district: '{3}', zipcode: '{4}'}}, " +
                 "'{5}', '{6}', {{BC_PhoneNumer: '{7}', CellPhone: '{8}'}}," +
                 " '{9}', {10}, {11}, toUnixTimestamp(now()), " +
                 "{12}, toUnixTimestamp(now())) IF NOT EXISTS",
                 new_client.fullName, new_client.street_name, new_client.ext_num, new_client.district, new_client.zipcode,
                 new_client.rfc, new_client.email, new_client.BC_PhoneNumer, new_client.CellPhone, new_client.dateOfBirth,
                 new_client.status, aux_session, aux_session);
                session.Execute(query);
            }
            catch (Exception )
            {

                throw;
            }
        }

        public void createHotel(Hotel_Model new_hotel, Guid aux_session)
        {
            try {
               string query = String.Format("INSERT INTO HOTEL_SYSTEM.HOTEL_DATA(hotelID, hotelName, location, " +
                     "status, countryID, stateID, cityID, begin_operation, floors, rooms, turistic_zone, user_crea," +
                     " date_crea, user_modif, date_modif) " +
                     "VALUES (UUID(), '{0}', " +
                     "{{street_name: '{1}', ext_num: '{2}', district: '{3}', zipcode: '{4}'}}," +
                     " 0, {5}, {6}, {7}, '{8}', {9}, {10}, '{11}', {12}, " +
                     "toTimestamp(toDate(now())), {13}, toTimestamp(toDate(now()))) IF NOT EXISTS",
                     new_hotel.hotelName, new_hotel.street_name, new_hotel.ext_num, new_hotel.district,
                     new_hotel.zipcode, new_hotel.countryID, new_hotel.stateID, new_hotel.cityID,
                     new_hotel.begin_operation, new_hotel.floors, new_hotel.rooms, new_hotel.turistic_zone, aux_session, aux_session);
               session.Execute(query);
            }
            catch (Exception) {
                throw;
            }
        }

        public List<Country_Model> getCountries()
        {
            try {
                string query = String.Format("SELECT countryID, countryName " +
                    "FROM HOTEL_SYSTEM.COUNTRY_DATA WHERE status = 0 ALLOW FILTERING;");
                session.Execute(query);
                IMapper mapper = new Mapper(session);
                IEnumerable<Country_Model> countries = mapper.Fetch<Country_Model>(query);
                return countries.ToList();
            }
            catch (Exception) {

                throw;
            }      
        }

        public List<State_Model> getStates(int country)
        {
            try
            {
                string query = String.Format("SELECT stateID, statename FROM HOTEL_SYSTEM.STATE_DATA " +
                    "WHERE countryid = {0} ALLOW FILTERING", country);
                session.Execute(query);
                IMapper mapper = new Mapper(session);
                IEnumerable<State_Model> states = mapper.Fetch<State_Model>(query);
                return states.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<City_Model> getCities(int state)  {
            try  {
                string query = String.Format("SELECT cityID, cityName FROM HOTEL_SYSTEM.CITY_DATA " +
                    "WHERE stateID = {0} AND status = 0 ALLOW FILTERING", state);
                session.Execute(query);
                IMapper mapper = new Mapper(session);
                IEnumerable<City_Model> cities = mapper.Fetch<City_Model>(query);
                return cities.ToList();
            }
            catch (Exception)  {
                throw;
            }
        }

        //public void SaveStudent(StudentModel student)
        //{
        //    string query = String.Format("INSERT INTO Student (studentId, name, age) VALUES (UUID(), '{0}', {1})", student.name, student.age);
        //    session.Execute(query);
        //}

        //public List<StudentModel> getStudent(string uuid)
        //{
        //    string query = String.Format("SELECT * FROM Student WHERE studentId = {0}", uuid);
        //    session.Execute(query);
        //    IMapper mapper = new Mapper(session);
        //    IEnumerable<Student> students = mapper.Fetch<Student>(query);
        //    return student.ToList();
        //}

        //public List<StudentModel> getAllStudent()
        //{
        //    string query = "SELECT * FROM Student";
        //    session.Execute(query);
        //    IMapper mapper = new Mapper(session);
        //    IEnumerable<Student> students = mapper.Fetch<Student>(query);
        //    return student.ToList();
        //}
    }
}
