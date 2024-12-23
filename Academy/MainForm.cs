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

        Dictionary<string, int> d_students_groups;
        Dictionary<string, int> d_students_directions;
        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            //MessageBox.Show(this, connectionString, "Connection String", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection = new SqlConnection(connectionString);

            LoadStudents();
            //LoadGroups();
            LoadGroup();
            d_groups = Connector.LoadPair("group_name", "group_id", "Groups");
            d_directions = Connector.LoadPair("direction_name", "direction_id", "Directions");
           
            //LoadDirections();
            //LoadStudentsGroup();
            //LoadStudentsDirection();
            LoadTeachers();
            LoadDictionaryToComboBox(d_directions, cbStudentsDirection);
            LoadDictionaryToComboBox(d_directions, cbGroupsDirection);
            LoadDictionaryToComboBox(d_groups, cbStudentsGroup);
        }
        void LoadStudents()
        {
            //string cmd = "SELECT * FROM Students";
            //SqlCommand command = new SqlCommand(cmd, connection);
            //connection.Open();
            //SqlDataReader reader = command.ExecuteReader();

            //DataTable table = new DataTable();
            //if (reader.HasRows)
            //{
            //    for (int i = 0; i < reader.FieldCount; i++)
            //        table.Columns.Add(reader.GetName(i));
            //    while (reader.Read())
            //    {
            //        DataRow row = table.NewRow();
            //        for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i]; 
            //        table.Rows.Add(row);
            //    }
            //    dataGridViewStudents.DataSource = table;
            //}
            //reader.Close();
            //connection.Close();

            dgvStudents.DataSource = Connector.LoadData
               (
                   "last_name AS 'Фамилия', first_name AS 'Имя', " +
                   "ISNULL(middle_name,N'') AS 'Отчество', " +
                   //+"birth_date AS 'Дата рождения', " +
                   "CONVERT(NVARCHAR, birth_date, 104) AS 'Дата рождения', " +
                   //-"DATEFROMPARTS(YEAR(GETDATE(birth_date)), MONTH(GETDATE(birth_date)), DAY(GETDATE(birth_date)))  AS 'Дата рождения', " +
                   //-"CAST(FORMAT(GETDATE(), 'yyyy-MM-dd') AS date) AS 'Дата рождения', " +
                   //-"DATEDIFF(day,birth_date, CAST(FORMAT(GETDATE(), 'yyyy-MM-dd')AS birth_date) AS 'Дата рождения', " +
                   "DATEDIFF(day,birth_date,GetDATE())/365 AS 'Возраст', " +
                   "group_name AS 'Группа'",
                   "Groups,Students",
                   "[group] = group_id"
               );
            tslStudentsCount.Text = $"Количество студентов: {dgvStudents.RowCount - 1}";
        }

        //void LoadGroups()
        //{
        //    string cmd = "SELECT * FROM Groups";
        //    SqlCommand command = new SqlCommand(cmd, connection);
        //    connection.Open();
        //    SqlDataReader reader = command.ExecuteReader();

        //    DataTable table = new DataTable();
        //    if (reader.HasRows)
        //    {
        //        for (int i = 0; i < reader.FieldCount; i++)
        //            table.Columns.Add(reader.GetName(i));
        //        while (reader.Read())
        //        {
        //            DataRow row = table.NewRow();
        //            for (int i = 0; i < reader.FieldCount; i++)
        //            {
        //                row[i] = reader[i];
        //            }
        //            table.Rows.Add(row);
        //        }
        //        dgvGroups1.DataSource = table;
        //    }
        //    reader.Close();
        //    connection.Close();
        //}
        void LoadGroup()
        {
            dgvGroups1.DataSource = Connector.LoadData
                (
                    "group_id AS 'ID', " +
                    "group_name AS 'Название группы', " +
                    "direction_name AS 'Направление обучения'," +
                    //"(SELECT COUNT(student_id) FROM Groups,Students WHERE Students.[group] = Groups.group_id)  AS 'Количество студентов'," +
                    //"(SELECT COUNT (student_id) FROM Groups,Students WHERE Students.[group] = Groups.group_id) AS 'Количество студентов'",
                    "ISNULL(COUNT (student_id), 0) AS 'Количество студентов'",
                    "Groups, Directions,Students ",//LEFT OUTER JOIN ON 
                    "direction = direction_id AND [group] = group_id" +//
                    " GROUP BY group_id,group_name,direction_name"


                // "group_id AS 'ID', " +
                //"group_name AS 'Название группы', " +
                //"direction_name AS 'Направление обучения'," +
                ////"(SELECT COUNT(student_id) FROM Groups,Students WHERE Students.[group] = Groups.group_id)  AS 'Количество студентов'," +
                ////"(SELECT COUNT (student_id) FROM Groups,Students WHERE Students.[group] = Groups.group_id) AS 'Количество студентов'",
                //"ISNULL(COUNT (student_id), 0) AS 'Количество студентов'",
                //"Students RIGHT JOIN Groups ON [group] = group_id RIGHT JOIN Directions ON direction = direction_id ",//LEFT OUTER JOIN ON 
                //" GROUP BY group_id,group_name,direction_name"
                );

            ////////string cmd = "SELECT group_id AS 'ID', " +
            ////////    "group_name AS 'Название группы',direction_name AS 'Направление обучения'," +
            ////////    "NULL AS 'Количество студентов' FROM Groups,Directions " +
            ////////    "WHERE direction = direction_id";
            ////////string cmd1 = "(SELECT COUNT(student_id) FROM Groups,Students WHERE Students.[group] = Groups.group_id)";

            ////////SqlCommand command = new SqlCommand(cmd, connection);
            ////////SqlCommand command1 = new SqlCommand(cmd1, connection);
            ////////connection.Open();
            ////////SqlDataReader reader = command.ExecuteReader();
            ////////SqlDataReader reader1 = command1.ExecuteReader();

            ////////DataTable table = new DataTable();
            ////////if (reader.HasRows)
            ////////{
            ////////    for (int i = 0; i < reader.FieldCount; i++)
            ////////        table.Columns.Add(reader.GetName(i));
            ////////    while (reader.Read())
            ////////    {
            ////////        DataRow row = table.NewRow();
            ////////        for (int i = 0; i < reader.FieldCount; i++)
            ////////        {
            ////////            row[i] = reader[i];
            ////////        }
            ////////        row[4] = reader1[0];
            ////////        table.Rows.Add(row);
            ////////    }
            ////////    dgvGroups1.DataSource = table;
            ////////}
            ////////reader.Close();
            ////////connection.Close();

            ////cmd = "(SELECT COUNT(student_id) FROM Groups,Students WHERE Students.[group] = Groups.group_id)";
            ////command = new SqlCommand(cmd, connection);
            ////connection.Open();
            ////SqlDataReader reader1 = command.ExecuteReader();

            //////DataTable table1 = new DataTable();
            ////if (reader.HasRows)
            ////{
            ////    //for (int i = 0; i < reader1.FieldCount; i++)
            ////    //    table1.Columns.Add(reader1.GetName(i));
            ////    while (reader1.Read())
            ////    {
            ////        DataRow row = table.NewRow();
            ////        //for (int i = 0; i < reader1.FieldCount; i++)
            ////        //{
            ////            row[4] = reader1[0];
            ////        //}
            ////        table.Rows.Add(row);
            ////    }
            ////    dgvGroups1.DataSource = table;
            ////}
            ////reader.Close();
            ////connection.Close();

            tslGroupsCount.Text = $"Количество групп: {dgvGroups1.RowCount - 1}";
        }

        void LoadDictionaryToComboBox(Dictionary<string, int> tree , ComboBox cb)
        {
            cb.Items.AddRange(tree.Keys.ToArray());
            cb.Items.Insert(0, "Все");
            cb.SelectedIndex = 0;
        }

        void LoadDirections()
        {            
            d_directions = Connector.LoadPair("group_name", "group_id", "Groups");
            //cbGroupsDirection.DataSource = d_groups_directions;
            //cbGroupsDirection.D
            //d_groups_directions["Все"] = 0;
            cbGroupsDirection.Items.AddRange(d_directions.Keys.ToArray());
            cbGroupsDirection.Items.Insert(0, "Все");
            cbGroupsDirection.SelectedIndex = 0;  
        }
        void LoadStudentsGroup()
        {
            d_students_groups = Connector.LoadPair("direction_name", "direction_id", "Directions");

            cbStudentsGroup.Items.AddRange(d_students_groups.Keys.ToArray());
            cbStudentsGroup.Items.Insert(0, "Все");
            cbStudentsGroup.SelectedIndex = 0;
        }
        void LoadStudentsDirection()
        {
            d_students_directions = Connector.LoadPair("direction_name", "direction_id", "Directions");
                        
            cbStudentsDirection.Items.AddRange(d_students_directions.Keys.ToArray());
            cbStudentsDirection.Items.Insert(0, "Все");
            cbStudentsDirection.SelectedIndex = 0;
        }


        private void cbGroupsDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupsDirection.SelectedIndex == 0) LoadGroup();
            else dgvGroups1.DataSource = Connector.LoadData
                (
                    "group_id,group_name, direction_name",
                    "Groups,Directions",
                    $"direction = direction_id AND direction = {d_directions[cbGroupsDirection.SelectedItem.ToString()]}"
                );
            tslGroupsCount.Text = $"Количество групп: {(dgvGroups1.RowCount == 0 ? 0 : dgvGroups1.RowCount - 1)}";
        }
        void LoadTeachers()
        {
            dgvTeachers.DataSource = Connector.LoadData
                (
                    "teacher_id AS 'ID', " +
                    "last_name AS 'Фамилия', first_name AS 'Имя', " +
                    "ISNULL(middle_name,N'') AS 'Отчество', " +
                    "CONVERT(NVARCHAR, birth_date, 104) AS 'Дата рождения', " +
                    "DATEDIFF(day,works_since,GetDATE())/365 AS 'Стаж', " +
                    "rate AS 'Оклад'",
                    "Teachers"
                );
            tslTeachersCount.Text = $"Количество преподавателей: {dgvTeachers.RowCount - 1}";
        }

        private void cbStudentsGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbStudentsDirection.SelectedIndex == 0) LoadStudents();
            //else dgvStudents.DataSource = Connector.LoadData
            //    (
            //       "last_name AS 'Фамилия', first_name AS 'Имя', " +
            //       "ISNULL(middle_name,N'') AS 'Отчество', " +
            //       "CONVERT(NVARCHAR, birth_date, 104) AS 'Дата рождения', " +
            //       "DATEDIFF(day,birth_date,GetDATE())/365 AS 'Возраст', " +
            //       "group_name AS 'Группа'",
            //       "Groups,Students",
            //       $"[group] = group_id AND [group] = {d_students_groups[cbStudentsDirection.SelectedItem.ToString()]}"

            //    );
            tslStudentsCount.Text = $"Количество студентов: {dgvStudents.RowCount - 1}";
        }
    }
}
