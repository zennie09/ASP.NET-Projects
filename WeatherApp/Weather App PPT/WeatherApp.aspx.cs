//This is A Weather Application that can used to send employee emails
//on the current weather on that day and indicate to them if they
//should work or not.
//Created By:Zennie09
//Dated:Feburary 10,2018

using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;




namespace Weather_App_PPT
{
    public partial class WeatherApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      


        protected void chkweather_Click(object sender, EventArgs e)
        {

            string api = "http://api.openweathermap.org/data/2.5/weather?q=";
            string api_key = "&mode=json&appid=00f72a003b44ffba04eb845dad696055";

            string url;


            using (WebClient client = new WebClient())
            {
                if(city.Text != "")
                {
                    lbl_warning.Text = "";
                    //api address
                    url = api + city.Text + api_key;

                    //Convert API in to JSON
                    var jsondata = client.DownloadString(url);


                    WeatherClass.root weatherdata = JsonConvert.DeserializeObject<WeatherClass.root>(jsondata);

                    lbl_country.Text = weatherdata.sys.country;
                    lbl_Cityname.Text = weatherdata.name;
                    lbl_temp.Text = weatherdata.main.temp.ToString();
                    lbl_pressure.Text = weatherdata.main.pressure.ToString() + "hpa";
                    lbl_humidity.Text = weatherdata.main.humidity.ToString() + "%";
                    lblmini.Text = weatherdata.main.temp_min.ToString();
                    lblmax.Text = weatherdata.main.temp_max.ToString();
                    lbl_Latitude.Text = weatherdata.coord.lat.ToString();
                    lbl_Longitude.Text = weatherdata.coord.lon.ToString();
                    lbl_TypeofWeather.Text = weatherdata.weather[0].main;
                    lbl_speed.Text = weatherdata.wind.speed.ToString();
                    lbl_degree.Text = weatherdata.wind.deg.ToString() + "°";
                    tblweather.Visible = true;

                    if (lbl_TypeofWeather.Text == "Rain")
                    {
                       
                        //ConnectionString
                        string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                        SqlDataReader reader;

                        //get all emails of employees from dattabase
                        string sendMessage = "SELECT Email_Address FROM Employee_Info";

                        using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                        {

                            myConnection.Open();
                            SqlCommand myCommand = new SqlCommand(sendMessage, myConnection);

                            ArrayList emailArray = new ArrayList();
                            reader = myCommand.ExecuteReader();


                            var emails = new List<Employee>();

                            while (reader.Read())
                            {

                                emails.Add(new Employee
                                {
                                    Email = Convert.ToString(reader["Email_Address"]),


                                });
                            }
                            //Send Emails
                            foreach (Employee Email_Address in emails)
                            {
                                string username = "";
                                string password = "":

                                string body = "From:" + "No Work" + "\n";
                                
                                body += " Message:" + " It is a Rainy Day. You should not go on the road to work." + "\n";
                                var smtp = new System.Net.Mail.SmtpClient();


                                {
                                    smtp.Host = "smtp.gmail.com";
                                    smtp.Port = 587;
                                    smtp.EnableSsl = true;
                                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                                    smtp.Credentials = new NetworkCredential(username, password);
                                    smtp.Timeout = 20000;
                                }
                                
                                smtp.Send(username, Email_Address.Email, "Rainy Day", body);
                                //lbldisplay.Text = "Sented";
                                Response.Write("<script language=javascript>alert('Today will be a Rainy Day, Emails are sent To Employees that they should not be on the Road!.')</script>");
                            }
                        }


                    }
                    else if (lbl_TypeofWeather.Text == "Sun")
                    {
                        
                        //ConnectionString
                        string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                        SqlDataReader reader;

                        string sendMessage = "SELECT Email_Address FROM Employee_Info";

                        using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                        {

                            myConnection.Open();
                            SqlCommand myCommand = new SqlCommand(sendMessage, myConnection);

                            ArrayList emailArray = new ArrayList();
                            reader = myCommand.ExecuteReader();


                            var emails = new List<Employee>();

                            while (reader.Read())
                            {
                                emails.Add(new Employee
                                {
                                    Email = Convert.ToString(reader["Email_Address"]),


                                });
                            }

                            foreach (Employee Email_Address in emails)
                            {
                                string username = "";
                                string password = "";

                                string body = "From:" + " Sunny Day" + "\n";
                                body += " Message:" + " scheduled for 8 hours  " + "\n";
                                var smtp = new System.Net.Mail.SmtpClient();


                                {

                                    smtp.Host = "smtp.gmail.com";
                                    smtp.Port = 587;
                                    smtp.EnableSsl = true;
                                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                                    smtp.Credentials = new NetworkCredential(username, password);
                                    smtp.Timeout = 20000;


                                }
                                
                                smtp.Send(username, Email_Address.Email, "Sunny Day", body);
                                //lbldisplay.Text = "Sented";
                                Response.Write("<script language=javascript>alert('Today will be a Sunny Day, Emails are sent To Employees to be scheduled for eight(8) Hours!.')</script>");
                            }
                        }


                    }
                    else if (lbl_TypeofWeather.Text == "Light Rain")
                    {
                        
                        //ConnectionString
                        string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                        SqlDataReader reader;

                        string sendMessage = "SELECT Email_Address FROM Employee_Info";

                        using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                        {

                            myConnection.Open();
                            SqlCommand myCommand = new SqlCommand(sendMessage, myConnection);

                            ArrayList emailArray = new ArrayList();
                            reader = myCommand.ExecuteReader();


                            var emails = new List<Employee>();

                            while (reader.Read())
                            {
                                emails.Add(new Employee
                                {
                                    Email = Convert.ToString(reader["Email_Address"]),


                                });
                            }

                            foreach (Employee Email_Address in emails)
                            {
                                string username = "";
                                string password = "";

                                string body = "From:" + " Light Rain" + "\n";
                                body += " Message:" + " with a schedule change - effectively,  only working 4 hours today and not the usual 8 hours!" + "\n";
                                var smtp = new System.Net.Mail.SmtpClient();
                               


                                {

                                    smtp.Host = "smtp.gmail.com";
                                    smtp.Port = 587;
                                    smtp.EnableSsl = true;
                                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                                    smtp.Credentials = new NetworkCredential(username, password);
                                    smtp.Timeout = 20000;


                                }
                               
                                smtp.Send(username, Email_Address.Email, "Light Rain", body);
                                //lbldisplay.Text = "Sented";
                                Response.Write("<script language=javascript>alert('Today will be a Rainy Day, Emails are sent To Employees that they should only work for four(4) Hours! !.')</script>");
                            }
                        }

                    }else if (lbl_TypeofWeather.Text != "Light Rain" || lbl_TypeofWeather.Text != "Rain" || lbl_TypeofWeather.Text != "Sun")
                    {
                       // weather_image.ImageUrl = "~/Images/weather_og.png";
                    }
                }else{
                    lbl_country.Text = "";
                    lbl_Cityname.Text = "";
                    lbl_temp.Text = "";
                    lbl_pressure.Text = "";
                    lbl_humidity.Text = "";
                    lblmini.Text = "";
                    lblmax.Text = "";
                    lbl_Latitude.Text = "";
                    lbl_Longitude.Text = "";
                    lbl_TypeofWeather.Text = "";
                    lbl_speed.Text = "";
                    lbl_degree.Text = "";
                    tblweather.Visible = false;
                    Response.Write("<script language=javascript>alert('Please Enter A City!.')</script>");
                }

               


            }
        }
    }

    //Use Employee Class
    internal class Employee
    {
        public string Email { get; set; }
    }
}