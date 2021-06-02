using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace MeteoStation_2.Class
{
    class DB
    {
		public event EventHandler ButtonClick ;
		internal  DataSet UserAccess = new DataSet();

		internal DataTable UserTable = new DataTable();
		internal DataTable AccessTable = new DataTable();

		internal DataColumn Column_A = new DataColumn("A", System.Type.GetType("System.Int16"));
		internal DataColumn Column_B = new DataColumn("B", System.Type.GetType("System.String"));
		internal DataColumn Column_C = new DataColumn("C", System.Type.GetType("System.String"));
		internal DataColumn Column_D = new DataColumn("D", System.Type.GetType("System.Int16"));

		internal DataColumn Column_E = new DataColumn("E", System.Type.GetType("System.Int16"));
		internal DataColumn Column_F = new DataColumn("F", System.Type.GetType("System.String"));
		internal DataColumn Column_G = new DataColumn("G", System.Type.GetType("System.Boolean"));
		internal DataColumn Column_H = new DataColumn("H", System.Type.GetType("System.Boolean"));
		internal DataColumn Column_I = new DataColumn("I", System.Type.GetType("System.Boolean"));
		internal DataColumn Column_J = new DataColumn("J", System.Type.GetType("System.Boolean"));
		internal static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
										+
										@"Data Source=db\DB_UserAccess.accdb;Cache Authentication=True";
		internal void createDB()
		{

			UserAccess.Tables.Add(UserTable);
			UserAccess.Tables.Add(AccessTable);

			UserTable.Columns.Add(Column_A);
			UserTable.Columns.Add(Column_B);
			UserTable.Columns.Add(Column_C);
			UserTable.Columns.Add(Column_D);

			AccessTable.Columns.Add(Column_E);
			AccessTable.Columns.Add(Column_F);
			AccessTable.Columns.Add(Column_G);
			AccessTable.Columns.Add(Column_H);
			AccessTable.Columns.Add(Column_I);
			AccessTable.Columns.Add(Column_J);
		}
		internal void linkDB(DataGridView dg)
		{
			dg.DataSource = UserTable;
		}
	
		internal void button_RD_Click(object sender, EventArgs e,DataGridView dg)
		{
			string CommandText = "SELECT * from UserTable ORDER BY UserName;";
			UserTable.Rows.Clear();
			using (OleDbConnection connection = new OleDbConnection(connectionString))
			{
				OleDbCommand DBCommand = new OleDbCommand(CommandText, connection);
				try
				{
					connection.Open();
					OleDbDataReader DBReader = DBCommand.ExecuteReader();
					if (DBReader.HasRows)
					{
						DataRow row;
						while (DBReader.Read())
						{
							row = UserTable.NewRow();
							row["A"] = DBReader[0];
							row["B"] = DBReader[1];
							row["C"] = DBReader[2];
							row["D"] = DBReader[3];
							UserTable.Rows.Add(row);
						}
					}
					DBReader.Close();
					connection.Close();
				}
				catch (Exception ex)
				{
					System.Windows.MessageBox.Show(ex.Message);
				}
			}
			dg.DataSource = UserTable;
		}
		internal void button_DL_Click(object sender, EventArgs e, DataGridView dg,String name)
		{
			string CommandText = "DELETE FROM UserTable WHERE UserName = '"+name+"'";
			UserTable.Rows.Clear();
			using (OleDbConnection connection = new OleDbConnection(connectionString))
			{
				OleDbCommand DBCommand = new OleDbCommand(CommandText, connection);
				try
				{
					connection.Open();
					DBCommand.ExecuteNonQuery();
					connection.Close();
				}
				catch (Exception ex)
				{
					System.Windows.MessageBox.Show(ex.Message);
				}
			}
		 
			dg.DataSource = UserTable;
		}
		internal void button_Insert_Click(object sender, EventArgs e, DataGridView dg ,String name, String pwd, int access)
		{
			if (verification(access,name, pwd))
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
					try
					{
						connection.Open();
						OleDbCommand DBCommand = new OleDbCommand();
						DBCommand.Connection = connection;
						DBCommand.CommandText = "insert into UserTable (UserName,UserPassword,AccessKey_Id) values('" + name + "', '" + pwd + "', "+access+")";
						DBCommand.ExecuteNonQuery();
						connection.Close();
					}
					catch (Exception ex)
					{
						System.Windows.MessageBox.Show(ex.Message);
					}
				}
				dg.DataSource = UserTable;
			}
			else
			{
				System.Windows.MessageBox.Show("Vous devez remplir les champs");
			}
		}

		internal User ConnectDB(String name, String pwd)
		{
			string CommandText = "SELECT * from UserTable WHERE UserName = '"+name+"'" + " AND UserPassword = '" +pwd+ "'";
			if (verificationConnect(name, pwd))
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
					try
					{
						connection.Open();
						OleDbCommand DBCommand = new OleDbCommand(CommandText, connection);
						OleDbDataReader DBReader = DBCommand.ExecuteReader();
						if (DBReader.HasRows)
						{
							if (DBReader.Read())
							{
								return new User((int)DBReader[0], DBReader[1].ToString(), DBReader[2].ToString(), (int)DBReader[3]);
							}
						}
						else
						{
							System.Windows.MessageBox.Show("Votre compte n'est pas dans la database");
							return null;
						}
					}
					catch (Exception ex)
					{
						System.Windows.MessageBox.Show(ex.Message);
						return null;
					}
				}
			}
			else
			{
				System.Windows.MessageBox.Show("Vous devez remplir les champs");
				return null;
			}
			return null;
		}

		private bool verificationConnect(string name, string pwd)
		{
			if (name.Length.Equals(0) || pwd.Length.Equals(0))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		private bool verification(int access, String name, String pwd)
		{
			if (access.Equals(0)|| name.Length.Equals(0) || pwd.Length.Equals(0))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
