using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Shapes;

public class UpdateManager
{
	private static bool updateIsReady = true;
	private static bool updateExist = true;
	private	static String filename = @"C:\Users\rlin8\Documents\Git\Projects\WebviewApp\UpdateFileSample\Updates.txt";
	private UpdateManager()
	{
	}
	//Checks for updates and returns true if there is updates and 0 for no updates
	public static bool CheckForUpdates()
	{
		return updateExist;
	}
	//Returns true when update is ready to be installed else returns 0.  
	public static bool UpdateReady()
	{
		return updateIsReady;
	}
	//returns the first string representing the version of the latest update
	public static string GetUpdateVersion()
	{
		string updateVersion = "version not found";
		try
		{
			string line;
			using (StreamReader reader = new StreamReader(filename))
			{
				string searchString = "ProductVersion = ";
				while (true)
				{
					line = reader.ReadLine();
					if (line == null) { break; }
					Debug.WriteLine(line);
					if (line.Contains(searchString))
					{
						return line.Substring(line.IndexOf(searchString) + searchString.Length);
					}
				}
			}
			return updateVersion;
		}
		catch(Exception e)
		{
			Debug.WriteLine(e.Message);
			return updateVersion;
		}
	}
	public static void BeginUpdate()
	{
	}
}

