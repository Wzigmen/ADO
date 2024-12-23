using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace Academy
{
	public partial class MainForm : Form
	{
		string connectionString;
		SqlConnection connection;

		Dictionary<string, int> d_directions;
		Dictionary<string, int> d_groups;
		public MainForm()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
			//MessageBox.Show(this, connectionString, "Connection string", MessageBoxButtons.OK, MessageBoxIcon.Information);
			connection = new SqlConnection(connectionString);

			LoadStudents();
			LoadGroups();
			//LoadDirections();
			LoadTeachers();

			d_directions = Connector.LoadPair("direction_name", "direction_id", "Directions");
			d_groups = Connector.LoadPair("group_name", "group_id", "Groups");
			LoadDictinatyToComboBox(d_directions, cbStudentsDirections);
			LoadDictinatyToComboBox(d_directions, cbGroupsDirection);
			LoadDictinatyToComboBox(d_groups, cbStudentsGroups);
		}
		void LoadStudents()
		{
			#region Load
			//string cmd = "SELECT * FROM Students";
			//SqlCommand command = new SqlCommand(cmd, connection);

			//connection.Open();
			//SqlDataReader reader = command.ExecuteReader();

			//DataTable table = new DataTable();
			//if (reader.HasRows)
			//{
			//	for (int i = 0; i < reader.FieldCount; i++)
			//		table.Columns.Add(reader.GetName(i));
			//	while (reader.Read())
			//	{
			//		DataRow row = table.NewRow();
			//		for (int j = 0; j < reader.FieldCount; j++)
			//		{
			//			row[j] = reader[j];
			//		}
			//		table.Rows.Add(row);
			//	}
			//	dgvStudents.DataSource = table;
			//}

			//reader.Close();
			//connection.Close();
			#endregion

			dgvStudents.DataSource = Connector.LoadData
				(
					"last_name AS N'Фамилия', " +
					"first_name AS N'Имя', " +
					"ISNULL(middle_name, N'') AS N'Отчество', " +
					"birth_date AS N'Дата рождения', " +
					"DATEDIFF(DAY,birth_date,GETDATE())/365 AS N'Возраст', " +
					"group_name AS N'Группа'",
					"Students,Groups",
					"[group]=group_id"
				);
			tslStudentsCount.Text = $"Колличество студентов: {dgvStudents.RowCount - 1}";
			//dataGridViewStudents.Columns[3].ValueType = DateTime.
		}
		void LoadGroups()
		{
			#region Load
			//string cmd = "SELECT * FROM Groups";
			//SqlCommand command = new SqlCommand(cmd, connection);

			//connection.Open();
			//SqlDataReader reader = command.ExecuteReader();

			//DataTable table = new DataTable();

			//if (reader.HasRows)
			//{
			//	for (int i = 0; i < reader.FieldCount; i++)
			//		table.Columns.Add(reader.GetName(i));
			//	while (reader.Read())
			//	{
			//		DataRow row = table.NewRow();
			//		for (int j = 0; j < reader.FieldCount; j++)
			//		{
			//			row[j] = reader[j];
			//		}
			//		table.Rows.Add(row);
			//	}
			//	dataGridViewGroups.DataSource = table;
			//}
			
			//reader.Close();
			//connection.Close(); 
			#endregion
			dgvGroups.DataSource = Connector.LoadData
				(
					"group_id AS 'ID', " +
					"group_name AS N'Название группы', " +
					"direction_name AS N'Направление обучения', " +
					"COUNT(student_id) AS N'Количество студентов' ",

					" Students,Groups,Directions",

					"direction=direction_id AND [group]=group_id" +
					" GROUP BY group_id,group_name,direction_name"
				);

//			int totalStudents = Connector.GetTotalStudentCount();

			tslGroupsCount.Text = $"Колличество групп: {dgvGroups.RowCount - 1}";
		}
		void LoadTeachers()
		{			
			dgvTeachers.DataSource = Connector.LoadData
				(
					"teacher_id AS N'ID', last_name AS N'Фамилия', first_name AS N'Имя', middle_name AS N'Отчество'",
					"Teachers"
				);
			tslTeachersCount.Text = $"Колличество преподавателей: {dgvTeachers.RowCount - 1}";
		}
		private void labelGroupsDirection_Click(object sender, EventArgs e)
		{

		}
		//void LoadDirections()
		//{
		//	//DataTable dt_directions = Connector.LoadData("direction_id,direction_name", "Directions");
		//	//cbGroupsDirection.Items.AddRange(dt_directions);
		//	d_groups_directions = Connector.LoadPair("direction_name", "direction_id", "Directions");
		//	cbGroupsDirection.Items.AddRange(d_groups_directions.Keys.ToArray());
		//	cbGroupsDirection.Items.Insert(0, "Все");
		//	cbGroupsDirection.SelectedIndex = 0;
		//}
		void LoadDictinatyToComboBox(Dictionary<string, int> tree, ComboBox cb)
		{
			//DataTable dt_directions = Connector.LoadData("direction_id,direction_name", "Directions");
			//cbGroupsDirection.Items.AddRange(dt_directions);
			cb.Items.AddRange(tree.Keys.ToArray());
			cb.Items.Insert(0, "Все");
			cb.SelectedIndex = 0;
		}

		private void cbGroupsDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbGroupsDirection.SelectedIndex == 0) LoadGroups();
			else dgvGroups.DataSource = Connector.LoadData
				(
					"group_id, group_name, direction_name",
					"Groups,Directions",
					$"direction=direction_id AND direction = {d_directions[cbGroupsDirection.SelectedItem.ToString()]}"
				);
			tslGroupsCount.Text = $"Колличество групп: {(dgvGroups.RowCount == 0 ? 0 : dgvGroups.RowCount - 1)}";
		}
	}
}
