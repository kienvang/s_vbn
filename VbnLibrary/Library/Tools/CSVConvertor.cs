using System;
using System.Data;
using System.IO;
using System.Text;

namespace Library.Tools
{
	/// <summary>
	/// Summary description for CSVConvertor.
	/// </summary>
	public class CSVConvertor
	{
		/// <summary>
		/// To generate CSV file.
		/// </summary>
		/// <param name="oDataTable"></param>
		/// <param name="directoryPath"></param>
		/// <param name="fileName"></param>
		/// <returns></returns>
		public string Convert(DataTable oDataTable, string directoryPath, string fileName)	
		{

			string fullpath = "";

			if (directoryPath.Substring(directoryPath.Length - 1,1) == @"\" ||directoryPath.Substring(directoryPath.Length - 1,1) == "/")	
			{
				fullpath = directoryPath + fileName;
			}
			else	
			{
				fullpath = directoryPath + @"\" + fileName;
			}

			StreamWriter SW;
			SW=File.CreateText(fullpath);
			
			
			StringBuilder oStringBuilder = new StringBuilder();

			
			/*******************************************************************
			 * Start, Creating column header
			 * *****************************************************************/

			foreach(DataColumn oDataColumn in oDataTable.Columns)	
			{
				oStringBuilder.Append(oDataColumn.ColumnName + ",");
			}

			SW.WriteLine(oStringBuilder.ToString().Substring(0,oStringBuilder.ToString().Length - 1));
			oStringBuilder.Length = 0;

			/*******************************************************************
			 * End, Creating column header
			 * *****************************************************************/

			/*******************************************************************
			 * Start, Creating rows
			 * *****************************************************************/

			foreach(DataRow oDataRow in oDataTable.Rows)	
			{
				
				
				foreach(DataColumn oDataColumn in oDataTable.Columns)	
				{
					oStringBuilder.Append(oDataRow[oDataColumn.ColumnName] + ",");
				}
				SW.WriteLine(oStringBuilder.ToString().Substring(0,oStringBuilder.ToString().Length - 1));
				oStringBuilder.Length = 0;

			}
			

			/*******************************************************************
			 * End, Creating rows
			 * *****************************************************************/


			SW.Close();

			return fullpath;

		}
	}
}
