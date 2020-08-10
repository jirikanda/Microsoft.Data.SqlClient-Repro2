using Microsoft.Data.SqlClient;
using System;

namespace ClassLibrary1
{
	public class Class1
	{
		public static void DoIt()
		{
			using (var connection = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=tempdb"))
			{
				connection.Open();
			}
		}
	}
}
