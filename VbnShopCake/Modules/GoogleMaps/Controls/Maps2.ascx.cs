using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Collections.Generic;
using Modules.GoogleMaps;

public partial class Modules_GoogleMaps_Controls_Maps2 : System.Web.UI.UserControl
{
    int _Width = 600;
    int _Height = 400;
    List<string> _latlong;
    List<LocationEntity> _address;
    List<LocationEntity> _cityname;

    public int MapWidth
    {
        get { return _Width; }
        set { _Width = value; }
    }

    public int MapHeight
    {
        get { return _Height; }
        set { _Height = value; }
    }

    /// <summary>
    /// Ex: (lat:long:zoom) 10.3535:12.656:10
    /// </summary>
    public List<string> LatLong
    {
        get 
        { 
            return _latlong; 
        }
        set 
        { 
            _latlong = value;
        }
    }

    public List<LocationEntity> Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public List<LocationEntity> CityName
    {
        get { return _cityname; }
        set { _cityname = value; }
    }

    public string Center
    {
        get;
        set;
    }

    public string GetLatLong
    {
        get
        {
            return Maps.CreateInstant().ConvertLatLongToString(LatLong);
        }
    }

    public bool CheckMaps()
    {
        return Maps.CreateInstant().CheckMap(LatLong, Address, CityName);
    }

    public void AddAddress(string address, string zoom)
    {
        LocationEntity item = new LocationEntity();
        item.Location = address;
        item.ZoomLevel = zoom;
        Address.Add(item);
    }

    public void AddCity(string city, string zoom)
    {
        LocationEntity item = new LocationEntity();
        item.Location = city;
        item.ZoomLevel = zoom;
        CityName.Add(item);
    }

    public string ReadMaps()
    {
        string strMap = GetLatLong;//Request.QueryString["maps"];

        string[] map = strMap.Split('|');

        List<LatLongEntity> latlong = Maps.CreateInstant().getLatLong(map);

        string st = Maps.CreateInstant().ReadXmlMap(latlong, Address, CityName);
        return st;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //this.Visible = Maps.CreateInstant().CheckMap(LatLong);
    }
}
