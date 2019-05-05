<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherApp.aspx.cs" Inherits="Weather_App_PPT.WeatherApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weather Application</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" integrity="sha512-dTfge/zgoMYpP7QbHy4gWMEGsbsdZeCXz7irItjcC3sPUFtf0kuFbDz/ixG7ArTxmDjLXDmezHubeNikyKGVyQ==" crossorigin="anonymous"/>
    <style type="text/css">
        .auto-style1 {
            width: 428px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <div class="jumbotron" style="margin-bottom:0px; color:white; background-color:#4aa1f3;">
			        <h2 class="text-center" style="font-size:50px; font-weight:600;"> Get Weather </h2>
	             </div>

	            <div id="show">
	            </div>
	
	
	
	            <div class= "container" style="height: 600px;">
	            	<div class="row" style="margin-bottom:20px;">

                          <table id="tblweather" runat="server" border="0" cellpadding ="0" cellspacing="0" visible="false"  class="table table-sm table-striped table-hover">
                            <tr>
                                <th colspan="2" class="thead-inverse">Weather Information</th>
                                <th colspan="1" class="thead-inverse">Geographical Coordinates</th>
                            </tr>

                            <tr>                 
                                 <td>
                                      <h4>Country:</h4>  <h3><asp:Label ID ="lbl_country" runat="server"></asp:Label></h3>
                                      <br />
                                      <h4>City Name:</h4> <h3><asp:Label ID ="lbl_Cityname" runat="server"></asp:Label></h3>
                                 </td>

                                 <td>
                                    <h4>Temperature:</h4> <h3><asp:Label ID ="lbl_temp" runat="server"></asp:Label></h3>
                                     <br />
                                     <h4>Pressure:</h4> <h3><asp:Label ID ="lbl_pressure" runat="server"></asp:Label></h3>
                                </td>

                                <td>                                                                   
                                    <h4>Longitude:</h4> <h3><asp:Label ID ="lbl_Longitude" runat="server"></asp:Label></h3>
                                    <br />
                                    <h4>Latitude:</h4> <h3><asp:Label ID ="lbl_Latitude" runat="server"></asp:Label></h3>                                   
                               </td>
                
                         </tr>

                           <tr>
                             <th colspan="1" class="thead-inverse">Temperature</th>
                             <th colspan="1" class="thead-inverse"> Wind</th>
                             <th colspan="1" class="thead-inverse">Type of Weather</th>
                           </tr>

                            <tr>  
                                <td>
                                  <h4>Minimum:</h4>  <h3><asp:Label ID ="lblmini" runat="server"></asp:Label></h3>
                                  <br />
                                  <h4>Maximum:</h4> <h3><asp:Label ID ="lblmax" runat="server"></asp:Label></h3>
                               </td>

                               <td>
                                  <h4>Speed:</h4>  <h3><asp:Label ID ="lbl_speed" runat="server"></asp:Label></h3>
                                  <br />
                                  <h4>Degree:</h4> <h3><asp:Label ID ="lbl_degree" runat="server"></asp:Label></h3>
                               </td>

                               <td>
                                   <h4>Humidity:</h4> <h3><asp:Label ID ="lbl_humidity" runat="server"></asp:Label></h3>
                                   <br />
                                   <h4>Type of Weather:</h4> <h3><asp:Label ID ="lbl_TypeofWeather" runat="server"></asp:Label></h3>
                                  
                               </td>
                             </tr>
                           
                          </table>

			            <h3 class="text-center text-primary"> Enter City Name </h3>
                        <p class="text-center text-primary"> 
                            <asp:Label ID="lbldisplay" runat="server"></asp:Label>
               
	                     <asp:Label ID ="lbl_warning" runat="server"></asp:Label>
                        </p>
		            </div>
		
	                <div class="row form-group" style="margin:auto; text-align:center; width:60%;">
		                <asp:TextBox ID="city" runat="server" Width="171px" placeholder="Enter Weather" class="form-control input-lg" style="margin:auto; text-align:center; width:60%;"></asp:TextBox>
                        &nbsp;<br/>
                        &nbsp;<br/>
                    
                        <asp:Button ID="chkweather" runat="server" Text="Check Weather" OnClick="chkweather_Click" class="btn btn-primary btn-lg"/>
                    </div>	
	            </div>

        
	
	               <div class="navbar-fixed-bottom" style="margin-bottom:0px; color:white; background-color:#4aa1f3;">
		            <div class= "container">
			            <div class="row text-center" style="padding-top:30px;">
				            <p style="color:white;"> Copyright &copy2018 Weather App</p>
			            </div>
		            </div>
	            </div>

            </center>

          

        </div>

     
                
    </form>
</body>
</html>
