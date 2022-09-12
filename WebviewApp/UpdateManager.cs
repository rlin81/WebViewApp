using System;
using System.Windows.Shapes;

public class UpdateManager
{
	public UpdateManager()
	{
		String filename = @"C:\Update.txt";
	}
	//Checks for updates and returns true if there is updates and 0 for no updates
	public bool CheckForUpdates()
	{
		return true;
	}
	//Returns true when update is ready else returns 0. Maybe some other value if also doing error handling. 
	public bool UpdateReady()
	{
		return true;
	}
	public void BeginUpdate()
	{
	}
}

