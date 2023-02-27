/* 
   Copyright (C) codepoet
   
   This is free software; you can redistribute it and/or
   modify it under the terms of the GNU Library General Public
   License as published by the Free Software Foundation; either
   version 2 of the License, or (at your option) any later version.
   
   This library is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
   Library General Public License for more details.
   
   You should have received a copy of the GNU Library General Public
   License along with this software; if not, write to the Free
   Software Foundation, Inc., 59 Temple Place - Suite 330, Boston,
   MA 02111-1307, USA

  Don't use it to find and eat babies ... unless you're really REALLY hungry ;-)

*/

using System.Threading;
using Microsoft.Data.Sqlite;

namespace Athena
{
	public partial class MainForm
	{
		void CreateConnection()
		{
			string connStr = "data source=\"C:\\Users\\damie\\Documents\\GoldingsGym\\GoldingsGymDev\\C-Sharp\\Heracles\\Project DB\\project.db\"";
			using SqliteConnection conn = new SqliteConnection(connStr);
			using SqliteCommand cmd = new(
				"SELECT * FROM [table_spec]",
				conn
				);
			conn.Open();
			using var reader = cmd.ExecuteReader();
			if (reader.HasRows == false)
			{
				MessageBox.Show("There's something wrong with the connection\r\nNo rows");
				return;
			}

			int rowCount = 0;

			while(reader.Read())
			{
				rowCount++;
			}

			MessageBox.Show($"The connection seems to be OK\r\nRow count is: {rowCount}");
		}

		void CreateProjectDatabase(string fileName)
		{
			string tableSpecSql = @"
				CREATE TABLE ""table_spec"" (
				""id""	INTEGER NOT NULL UNIQUE,
				""table_name""	TEXT NOT NULL UNIQUE,
				""source_tool""	TEXT NOT NULL,
				""plugin_guid""	TEXT NOT NULL UNIQUE,
				PRIMARY KEY(""id"" AUTOINCREMENT)
				)";
			try
			{
				MessageBox.Show("SQL",tableSpecSql);
				string connStr = $"data source=\"{fileName}\"";
				using SqliteConnection conn = new SqliteConnection(connStr);
				conn.Open();
				using SqliteCommand cmd = new(tableSpecSql,conn);
				int resp = cmd.ExecuteNonQuery();
				if (resp > 0)
				{
					MessageBox.Show("Rows", $"Response: {resp}");
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error creating project database", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

	}
}