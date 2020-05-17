using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.CSharp.RuntimeBinder;

namespace Sofia
{
    public partial class exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select * from seurityexam";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                sqlconn.Close();


            }
        }

        protected void ButSubmit_Click(object sender, EventArgs e)
        {

            foreach(RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb1 = (RadioButton)ri.FindControl("RadOption1");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");
                labcorrectans.Visible = true;
                if(rb1.Checked == true)
                {
                    if(rb1.Text.Equals(labcorrectans.Text))
                    {
                        Label UserSelectedAnswer = (Label)ri.FindControl("LabUserSelectOption");
                       // UserSelectedAnswer.Text = "The Selected answer is <b>" + rb1.Text.ToString() + "</b> Is Correct";
                       // UserSelectedAnswer.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        Label WrongAnswer = (Label)ri.FindControl("LabUserSelectOption");
                      //  WrongAnswer.Text = "The Selected answer is <b>" + rb1.Text.ToString() + "</b> Is Wrong.";
                      //  WrongAnswer.ForeColor = System.Drawing.Color.Red;
                    }
                }


            }


            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb2 = (RadioButton)ri.FindControl("RadOption2");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");
                labcorrectans.Visible = true;
                if (rb2.Checked == true)
                {
                    if (rb2.Text.Equals(labcorrectans.Text))
                    {
                        Label UserSelectedAnswer = (Label)ri.FindControl("LabUserSelectOption");
                      //  UserSelectedAnswer.Text = "The Selected answer is <b>" + rb2.Text.ToString() + "</b>";
                      // UserSelectedAnswer.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        Label WrongAnswer = (Label)ri.FindControl("LabUserSelectOption");
                     //   WrongAnswer.Text = "The Selected answer is <b>" + rb2.Text.ToString() + "</b> Is Wrong.";
                      //  WrongAnswer.ForeColor = System.Drawing.Color.Red;
                    }
                }


            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb3 = (RadioButton)ri.FindControl("RadOption3");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");
                labcorrectans.Visible = true;
                if (rb3.Checked == true)
                {
                    if (rb3.Text.Equals(labcorrectans.Text))
                    {
                        Label UserSelectedAnswer = (Label)ri.FindControl("LabUserSelectOption");
                       // UserSelectedAnswer.Text = "The Selected answer is <b>" + rb3.Text.ToString() + "</b>";
                       // UserSelectedAnswer.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        Label WrongAnswer = (Label)ri.FindControl("LabUserSelectOption");
                       // WrongAnswer.Text = "The Selected answer is <b>" + rb3.Text.ToString() + "</b> Is Wrong.";
                     //  WrongAnswer.ForeColor = System.Drawing.Color.Red;
                    }
                }


            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb4 = (RadioButton)ri.FindControl("RadOption4");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");
                labcorrectans.Visible = true;
                if (rb4.Checked == true)
                {
                    if (rb4.Text.Equals(labcorrectans.Text))
                    {
                        Label UserSelectedAnswer = (Label)ri.FindControl("LabUserSelectOption");
                      //  UserSelectedAnswer.Text = "The Selected answer is <b>" + rb4.Text.ToString() + "</b>";
                       // UserSelectedAnswer.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        Label WrongAnswer = (Label)ri.FindControl("LabUserSelectOption");
                      //  WrongAnswer.Text = "The Selected answer is <b>" + rb4.Text.ToString() + "</b> Is Wrong.";
                      //  WrongAnswer.ForeColor = System.Drawing.Color.Red;
                    }
                }


            }



        }

    }
}
