using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Assigment13_08_2020
{
    public partial class InsertUpdateDelete : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-KIFD9N1G;Initial Catalog=DotNetWebApp;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        public void ShowGrid()
        {
            conn.Open();
            cmd = new SqlCommand("select * from EmployeeTbl", conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            dr.Close();
            conn.Close();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowGrid();
            }
        }

        protected void srhname_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_searchEmpName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empname", SqlDbType.Int).Value = txtname.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtempid.Text = dr["empId"].ToString();
                txtsal.Text = dr["empSal"].ToString();
                txtgender.Text = dr["gender"].ToString();
            }
            else
            {
                txtempid.Text = "Employee Does Not Exis";
                txtsal.Text = "";
            }
            dr.Close();
            conn.Close();
            
        }

        protected void srhid_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_searchEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(txtempid.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtname.Text = dr["empName"].ToString();
                txtsal.Text = dr["empSal"].ToString();
                txtgender.Text = dr["gender"].ToString();
            }
            else
            {
                txtname.Text = "Employee Does Not Exis";
                txtsal.Text = "";
            }
            dr.Close();
            conn.Close();
            
        }

        protected void btninsrtqt_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into EmployeeTbl(empName, empSal, gender) values('" + txtname.Text + "','" + Convert.ToInt32(txtsal.Text) + "','" + txtgender.Text + "')", conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Label1.Text = "One row Inserted";
            }
            conn.Close();
            ShowGrid();
            txtname.Text = "";
            txtsal.Text = "";
            txtgender.Text = "";
        }

        protected void btninsrtpar_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into EmployeeTbl(empName, empSal, gender) values(@empname , @sal , @gender)", conn);
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = txtname.Text;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar, 6).Value = txtgender.Text;
            cmd.Parameters.Add("@sal", SqlDbType.Float).Value = Convert.ToSingle(txtsal.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Label1.Text =  "One row Inserted";
            }
            conn.Close();
            ShowGrid();
            txtname.Text = "";
            txtsal.Text = "";
            txtgender.Text = "";
        }

        protected void btninsrtproc_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_insertName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = txtname.Text;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar, 6).Value = txtgender.Text;
            cmd.Parameters.Add("@sal", SqlDbType.Float).Value = Convert.ToSingle(txtsal.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Label1.Text = "One row Inserted";
            }
            conn.Close();
            ShowGrid();
            txtname.Text = "";
            txtsal.Text = "";
            txtgender.Text = "";
        }

        protected void btnupqua_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("update EmployeeTbl set empName='" + txtname.Text + "', empSal='" + Convert.ToInt32(txtsal.Text) + "' where empId = '" + Convert.ToInt32(txtupdate.Text) +"'", conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Label1.Text = "One row Updated";
            }
            conn.Close();
            ShowGrid();
            txtname.Text = "";
            txtsal.Text = "";
            txtupdate.Text = "";
            
        }

        protected void btnuppar_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("update EmployeeTbl set empName=@empN, empSal=@sal where empId = @id", conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(txtupdate.Text);
            cmd.Parameters.Add("@empN", SqlDbType.VarChar, 20).Value = txtname.Text;
            cmd.Parameters.Add("@sal", SqlDbType.Float).Value = Convert.ToSingle(txtsal.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Label1.Text = "One row Updated";
            }
            conn.Close();
            ShowGrid();
            txtname.Text = "";
            txtsal.Text = "";
            txtupdate.Text = "";
        }

        protected void btnuppro_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_updateName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empN", SqlDbType.VarChar, 20).Value = txtname.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(txtupdate.Text);
            cmd.Parameters.Add("@sal", SqlDbType.Float).Value = Convert.ToSingle(txtsal.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Label1.Text = "One row Updated";
            }
            conn.Close();
            ShowGrid();
            txtname.Text = "";
            txtsal.Text = "";
            txtupdate.Text = "";
        }

        protected void btndelproc_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_DeleteEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(txtdel.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Label1.Text = "One row Deleted";
            }
            conn.Close();
            ShowGrid();
            txtdel.Text = "";
        }

        protected void btndelpar_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from EmployeeTbl where empName=@empN", conn);
            cmd.Parameters.Add("@empN", SqlDbType.VarChar, 20).Value = txtdel.Text;

            if (cmd.ExecuteNonQuery() > 0)
            {
                Label1.Text = "One row Deleted";
            }
            conn.Close();
            ShowGrid();
            txtdel.Text = "";
        }

        protected void btndelqua_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from EmployeeTbl where empId = '" + Convert.ToInt32(txtdel.Text) + "'", conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Label1.Text = "One row Deleted";
            }
            conn.Close();
            ShowGrid();
            txtdel.Text = "";
        }
    }
    
    
}