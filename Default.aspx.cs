using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = "unesi ime";
        ListBox1.Width=111;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Button1.BackColor = Color.LightGreen;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        MySqlConnection veza = new MySqlConnection();
        veza.ConnectionString = "SERVER=localhost;" + "DATABASE=bp_select;" + "UID=root;" + "PASSWORD=Urovica11;";
        MySqlCommand naredba = new MySqlCommand();
        naredba.Connection = veza;
        naredba.CommandText = "Select nazivk, ime, pime from knjige, pisci where pisci.rbp=knjige.pisac";
        veza.Open();
        MySqlDataReader citac;
        citac = naredba.ExecuteReader();
        //int k = 0;
        while (citac.Read())
        {
            string s;
            s = citac[0] + ", " + citac[1] + ", " + citac[2];
            ListBox1.Items.Add(s);
            //listBox1.Items.Add(citac.GetValue(k).ToString());
            //k++;
        }
        veza.Close();
    }
}