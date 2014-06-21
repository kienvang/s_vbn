using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Collections.Generic;
using System.Xml;

/// <summary>
/// Summary description for Maps
/// </summary>
/// 

namespace Modules.GoogleMaps
{
    public class Maps
    {
        public static Maps CreateInstant()
        {
            return new Maps();
        }

        /// <summary>
        /// get Lat Long form string[]
        /// </summary>
        /// <param name="objs">Ex: (lat:long:zoom) getLagLong("10.326:35.1369:12","12.346:1547:10") or getLatLong(string[])</param>
        /// <returns></returns>
        public List<LatLongEntity> getLatLong(params string[] objs)
        {
            List<LatLongEntity> latlong = new List<LatLongEntity>();
            if (objs != null && objs.Length > 0)
            {
                for (int i = 0; i < objs.Length; i++)
                {
                    string[] str = objs[i].Split(':');
                    if (str != null && str.Length == 3)
                    {
                        if (!string.IsNullOrEmpty(str[0]) && !string.IsNullOrEmpty(str[1]) && !string.IsNullOrEmpty(str[2]))
                        {
                            LatLongEntity item = new LatLongEntity();
                            item.Lat = str[0];
                            item.Long = str[1];
                            item.Zoom = str[2];

                            latlong.Add(item);
                        }
                    }
                }
            }
            return latlong;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objs">Ex: (lat:long:zoom) getLagLong("10.326:35.1369:12","12.346:1547:10") or getLatLong(string[])</param>
        /// <returns></returns>
        public string ConvertLatLongToString(List<string> objs)
        {
            string str = "";// "10.75918:106.662498:10";
            if (objs != null && objs.Count > 0)
            {
                str = objs[0];
                for (int i = 1; i < objs.Count; i++)
                {
                    str += "|" + objs[i];
                }
            }
            return str;
        }

        public string ReadXmlMap(List<LatLongEntity> latlong, List<LocationEntity> Address, List<LocationEntity> CityName)
        {
            XmlDocument xmlDoc = new XmlDocument();

            string xml = "<markers>";
            if (latlong != null && latlong.Count > 0)
            {
                for (int i = 0; i < latlong.Count; i++)
                    xml += "<marker lat=\"" + latlong[i].Lat + "\" long=\"" + latlong[i].Long + "\" zoom=\"" + latlong[i].Zoom + "\" />";
            }

            if (Address != null && Address.Count > 0)
            {
                for (int i = 0; i < Address.Count; i++)
                    xml += "<address value=\"" + Address[i].Location + "\" zoom=\"" + Address[i].ZoomLevel + "\" />";
            }

            if (CityName != null && CityName.Count > 0)
            {
                for (int i = 0; i < CityName.Count; i++)
                    xml += "<city value=\"" + CityName[i].Location + "\" zoom=\"" + CityName[i].ZoomLevel +  "\" />";
            }

            //if ((latlong == null || latlong.Count == 0) && (Address == null || Address.Count == 0) && (CityName == null || CityName.Count == 0))
            //{
            //    xml += "<marker lat=\"10.75918\" long=\"106.662498\" name=\"Ho Chi Minh\" zoom=\"10\" />";
            //    xml += "<marker lat=\"21.0341\" long=\"105.8372\" name=\"Hanoi\"/>";
            //}
            xml += "</markers>";

            return xml;
        }

        public bool CheckMap(List<string> latlong, List<LocationEntity> Address, List<LocationEntity> CityName)
        {
            if ((latlong == null || latlong.Count == 0) && (Address == null || Address.Count == 0) && (CityName == null || CityName.Count == 0))
                return false;

            for (int i = 0; latlong != null && i < latlong.Count ; i++)
            {
                string[] str = latlong[i].Split(':');
                if (str == null || str.Length != 3) return false;
                if (string.IsNullOrEmpty(str[0]) || string.IsNullOrEmpty(str[1]) || string.IsNullOrEmpty(str[2]))
                    return false;
            }

            return true;
        }
    }
}