using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BelgiumCampusRegistrationApp
{
    internal class DataHandler
    {
        public DataHandler() { }

        string connect = "Data Source =SQLEXPRESS; Initial Catalog = BelgiumCampusITVersity; Integrated Security= SSPI";

        SqlDataAdapter adapter;
        SqlConnection con;
        SqlCommand command;

        public void Register(int sid, string n, string s, string cid) 
        {
            string query = $"INSERT INTO StudentDetails VALUES('{sid}', '{n}', '{s}', '{cid}')";

            con = new SqlConnection(connect);       
            con.Open();
            command = new SqlCommand(query, con);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Student Successfully registered");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not saved." + ex.Message);
            }
            finally 
            {
                con.Close();
            }
        }

        public void Update(int sid, string n, string s, string cid) 
        {
            string query = $"UPDATE StudentDetails SET [LastName] = '{s}', [Surname] = '{n}', [CourseID] = '{cid}' WHERE [StudentID] = '{sid}'";

            con = new SqlConnection(connect);
            con.Open();
            command = new SqlCommand(query, con);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Details for Student Successfully Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not updated." + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(int sid) 
        {

            string query = $"DELETE FROM StudentDetails WHERE StudentID = '{sid}'";

            con = new SqlConnection(connect);
            con.Open();
            command = new SqlCommand(query, con);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show($"Details for Student with ID: {sid} has been deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not deleted." + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Search(int sid) 
        {
            string query = $"SELECT * FROM StudentDetails WHERE [StudentID] = '{sid}'";

            con = new SqlConnection(connect);
            adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }
    }
}
