using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Net;
using System.Text;

namespace Library.Tools
{
	public class IO
	{
		public static IO CreateInstant()
		{
			return new IO();
		}

		public DataTable RegexToDataTable(string filePathAndName)
		{
			return RegexToDataTable(filePathAndName, true);
		}

		public DataTable RegexToDataTable(string filePathAndName, bool isFirstRowColumnName)
		{
			string pattern = @"(?<=,)\s*(?=,)|^(?=,)|[^\""]{2,}(?=\"")|([^,\""]+(?=,|$))";
			string source = ReadFile(filePathAndName);
			return RegexToDataTable(source, pattern, isFirstRowColumnName);
		}

		public DataTable RegexToDataTable(string source, string pattern, bool isFirstRowColumnName)
		{
			DataTable toReturn = new DataTable();
			System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(pattern);
			DataRow dr;
			foreach (string sourceLine in source.Split('\n'))
			{
				// skip the line if first char is #
				if (sourceLine.Substring(0, 1) != "#")
				{
					//System.Web.HttpContext.Current.Trace.Warn("RegexToDataTable.sourceLine.111", sourceLine);
					if (toReturn.Columns.Count == 0) // if column not set up yet, then add columns
					{
						if (isFirstRowColumnName)
						{
							// add column name by using values of first row
							foreach (System.Text.RegularExpressions.Match match in regex.Matches(sourceLine))
							{
								toReturn.Columns.Add(match.ToString());
							}
						}
						else
						{
							// add column name by index number
							int colIndex = 0;
							foreach (System.Text.RegularExpressions.Match match in regex.Matches(sourceLine))
							{
								toReturn.Columns.Add(colIndex.ToString());
								colIndex++;
							}

							// add first row data
							int i = 0;
							dr = toReturn.NewRow();
							foreach (System.Text.RegularExpressions.Match match in regex.Matches(sourceLine))
							{
								dr[i++] = match.ToString();
							}
							toReturn.Rows.Add(dr);
						}
					}
					else
					{
						int i = 0;
						dr = toReturn.NewRow();
						foreach (System.Text.RegularExpressions.Match match in regex.Matches(sourceLine))
						{
							dr[i++] = match.ToString();
						}
						toReturn.Rows.Add(dr);
					}
				}
				else
				{
					//System.Web.HttpContext.Current.Trace.Warn("RegexToDataTable.sourceLine.222", sourceLine);
				}
			}
			//System.Web.HttpContext.Current.Trace.Warn("RegexToDataTable.toReturn.Rows.Count", toReturn.Rows.Count.ToString());
			return toReturn;
		}

		public String ReadFile(string strFile)
		{
			// Open the stream and read it back.
			String strRet;
			if (File.Exists(strFile))
			{
				using (StreamReader sr = File.OpenText(strFile))
				{
					strRet = sr.ReadToEnd();
					sr.Close();
				}
			}
			else
				strRet = String.Empty;

			return strRet;
		}

		public void AppendFile(string strFile, string strContent)
		{
			using (StreamWriter sw = new StreamWriter(strFile, true))
			{
				// Add some text to the file.
				sw.Write(strContent);
				sw.Close();
			}
		}

		public void WriteFile(string strFile, string strContent)
		{
			using (StreamWriter sw = new StreamWriter(strFile, false))
			{
				// Add some text to the file.
				sw.Write(strContent);
				sw.Close();
			}
		}

		public string GetPageHtmlContent(string Url)
		{
			Uri _Uri = new Uri(Url);
			string pageHtmlCode = string.Empty;
			GetPageStatusCode(ref _Uri, out pageHtmlCode);
			return pageHtmlCode;
		}

		public HttpStatusCode GetPageStatusCode(string Url)
		{
			Uri _Uri = new Uri(Url);
			string pageData = string.Empty;
			return GetPageStatusCode(ref _Uri, out pageData);
		}

		public HttpStatusCode GetPageStatusCode(ref Uri pageUri)
		{
			string pageData = string.Empty;
			return GetPageStatusCode(ref pageUri, out pageData);
		}

		/// <summary>
		/// Read the specified web page's data
		/// </summary>
		/// <param name="pageUri">
		/// Uri object pointing to the desired page
		/// </param>
		/// <param name="pageData">
		/// The data downloaded from the provided Uri
		/// </param>
		/// <returns>
		/// The status code returned by the connection attempt
		/// </returns>
		public HttpStatusCode GetPageStatusCode(ref Uri pageUri, out string pageData)
		{
			HttpStatusCode status = (HttpStatusCode)0;
			HttpWebResponse resp = null;

			// initialize the out param (in case of error)
			pageData = string.Empty;

			try
			{
				// create the web request
				HttpWebRequest req = (HttpWebRequest)WebRequest.Create(pageUri);



				// make the connection
				resp = (HttpWebResponse)req.GetResponse();
				pageUri = resp.ResponseUri;

				// get the page data
				using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
				{
					pageData = sr.ReadToEnd();
					sr.Close();
				}

				// get the status code (should be 200)
				status = resp.StatusCode;
			}
			catch (WebException e)
			{
				string str = string.Format(CultureInfo.CurrentCulture,
																"Caught WebException: {0}",
																e.Status.ToString()); ;

				resp = (HttpWebResponse)e.Response;
				if (null != resp)
				{
					// get the failure code from the response
					status = resp.StatusCode;
					str = string.Format(CultureInfo.CurrentCulture,
															"{0} ({1})",
															str, status);

					// Added by Phuong
					// get the page data
					using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
					{
						pageData = sr.ReadToEnd();
					}

				}
				else
				{
					// generic connection error
					status = (HttpStatusCode)(-1);
				}

			}
			finally
			{
				// close the response
				if (null != resp)
				{
					resp.Close();
				}
			}

			// done
			return status;
		}

		public Hashtable ReadTabDelimitedFileToHashtable(string FileName)
		{
			Hashtable hash = new Hashtable();

			try
			{
				if (File.Exists(FileName))
				{
					// Create an instance of StreamReader to read from a file.
					// The using statement also closes the StreamReader.
					using (StreamReader sr = new StreamReader(FileName))
					{
						String line;
						// Read and display lines from the file until the end of 
						// the file is reached.
						while ((line = sr.ReadLine()) != null)
						{
							string[] items = line.Split('\t');
							if (items.Length >= 2 && !hash.Contains(items[0].Trim().ToLower()) && items[0].Trim().ToLower() != String.Empty)
							{
								try
								{
									hash.Add(items[0].Trim().ToLower(), items[1].Trim());
								}
								catch { }
							}
						}
					}
				}
			}
			catch { }
			return hash;
		}

		public HashSet<string> RealFileToHashSet(string FileName)
		{
			HashSet<string> _HashSet = new HashSet<string>();
			try
			{
				if (File.Exists(FileName))
				{
					// Create an instance of StreamReader to read from a file.
					// The using statement also closes the StreamReader.
					using (StreamReader sr = new StreamReader(FileName))
					{
						String line;
						// Read and display lines from the file until the end of 
						// the file is reached.
						while ((line = sr.ReadLine()) != null)
						{
							if (!_HashSet.Contains(line) && !string.IsNullOrEmpty(line)) {
								_HashSet.Add(line);
							}
						}
					}
				}
			}
			catch { }
			return _HashSet;
		}
		
	}
}
