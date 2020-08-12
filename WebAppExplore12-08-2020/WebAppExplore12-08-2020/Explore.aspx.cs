using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExplore12_08_2020
{
    public partial class Explore : System.Web.UI.Page
    {
        ArrayList arr = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                

                arr.Add("Select");
                arr.Add("Kolkata");
                arr.Add("Pune");
                arr.Add("Hydrabad");
                arr.Add("Bangalore");

                List<string> names = new List<string>();
                names.AddRange(new string[] { "Moni", "Shreya", "Smriti", "Dipanjan", "Samiran" });

                foreach (string s in names)
                {
                    ListBox2.Items.Add(s);
                }
                foreach (string s in arr)
                {
                    RadioButtonList2.Items.Add(s);
                }
                foreach (string s in arr)
                {
                    CheckBoxList2.Items.Add(s);
                }
            }
        }
    } 
}