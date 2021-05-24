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
		private void buttonEvent(object sender, EventArgs e)
		{
			if (this.ButtonClick != null) this.ButtonClick(this, e);
		}
		internal void button_RD_Click(object sender, EventArgs e,DataGridView dg)
		{
			MessageBox.Show("Hello");
			string CommandText = "SELECT * from UserTable " + "WHERE AccessKey_Id = " + "1 " + "ORDER BY UserName;";

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
						while (DBReader.Read())
						{
							UserTable.Rows.Add(new object[] { DBReader[0], DBReader[1], DBReader[2], DBReader[3] });
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
	}
}
