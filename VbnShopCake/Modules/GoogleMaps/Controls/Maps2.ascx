<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Maps2.ascx.cs" Inherits="Modules_GoogleMaps_Controls_Maps2" %>

<script src="http://maps.google.com/maps?file=api&amp;v=2&amp;key=<%= ConfigurationManager.AppSettings["GoogleMapsAPIKey"] %>"
        type="text/javascript"></script>
        <script type="text/javascript">
    $(document).ready(function() {
        
        var geocoder = null;
        var map = null;
        var showmap = "0"
        
        InitMaps();
        
        function load()
        {
            //alert('<%=CheckMaps() %>');
            if ('<%=CheckMaps() %>' == 'True')
                $("#maps").show();
            else
                $("#maps").hide();
        }
        
        function InitMaps() {
			if (GBrowserIsCompatible()) {
			    
			    geocoder = new GClientGeocoder();
			    
				map = new GMap2(document.getElementById("maps"));
				map.addControl(new GSmallMapControl());
				map.addControl(new GMapTypeControl());
				
				var data = '<%=this.ReadMaps() %>';
			    //alert(data);
				var xml = GXml.parse(data);
				var markers = xml.documentElement.getElementsByTagName("marker");
				var address = xml.documentElement.getElementsByTagName("address");
				var city = xml.documentElement.getElementsByTagName("city");
				
				showmap = "0";
				
				//var center = xml.documentElement.getElementsByTagName("center");
				if (markers.length > 0)
				{
				    showmap = "1";
				    var point0 = new GLatLng(parseFloat(markers[0].getAttribute("lat")), parseFloat(markers[0].getAttribute("long")));
                    var zoom0 = parseInt(markers[0].getAttribute("zoom"), 10);
                    map.setCenter(point0, zoom0);
                    for (var i = 0; i < markers.length; i++) 
				    {
					    var point = new GLatLng(parseFloat(markers[i].getAttribute("lat")),
                                parseFloat(markers[i].getAttribute("long")));
                        var zoom = parseInt(markers[i].getAttribute("zoom"), 10);
					    map.addOverlay(new GMarker(point));
    					
				    }
				}
				
				if (address.length > 0)
				{
				    showCenter(address[0].getAttribute("value"), parseInt(address[0].getAttribute("zoom")));
                    
                    for(var i=0; i<address.length; i++)
				    {
				        showPoint(address[i].getAttribute("value"));
				    }
				}
				
				if (city.length > 0)
				{
				    showCenter(city[0].getAttribute("value"), parseInt(city[0].getAttribute("zoom")));
                    
                    for(var i=0; i<city.length; i++)
				    {
				        showPoint(city[i].getAttribute("value"));
				    }
				}
			}
		}
		
		function showCenter(address,zoom){
		    if (geocoder) {
                geocoder.getLatLng(
                    address,
                    function(point) {
                        if (showmap == "0")
                        {
                            if(point) 
                            {
                                map.setCenter(point, zoom);
                            } 
                            else 
                            {
                                $("#maps").hide();
                            }
                        }
                    }
                    
                );
            } 
        }
		
		function showPoint(address){
		    if (geocoder) {
                geocoder.getLatLng(
                    address,
                    function(point) {
                        if (showmap == "0")
                        {
                            if(point) 
                            {
                                map.addOverlay(new GMarker(point));
                                showmap = "1";
                                $("#maps").show();
                            } 
                            else 
                            {
                                $("#maps").hide();
                            }
                        }
                    }
                );
            } 
        }
        
        
    });
    
    $(document.body).unload(function() {
        if (GBrowserIsCompatible()) {
            GUnload();
        }
    });
</script>
        
<div id="maps" style="margin:0 0 20px 0; width: <%=this.MapWidth%>px; height: <%=this.MapHeight%>px;">
    
</div>


<%--<iframe width='<%=this.MapWidth %>' height='<%= this.MapHeight %>' src="<%= Chudu24.Modules.GoogleMaps.UrlBuilder.Root %>/Default2.aspx?h=<%= this.MapHeight %>&w=<%=this.MapWidth %>&maps=<%= this.GetLatLong %>" frameborder="no" scrolling="no" style="border:1px solid #ccc;"></iframe>--%>