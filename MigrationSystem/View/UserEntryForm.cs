using MigrationSystem.Controller;
using MigrationSystem.Services;
using MigrationSystem.Repositories;

namespace MigrationSystem.View
{
    public partial class UserEntryForm : Form
    {
        public UserEntryForm()
        {
            InitializeComponent();
            string[] list = new string[] { "Белоруссия", "Украина", "Киргизия", "Казахстан", "Армения", "Таджикистан", "Узбекистан", "Камерун" } ;
            comboBox1.Items.AddRange(list);
            tabControl1.SelectedIndexChanged += ShowRoadMap_Click;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EnterData_Click(object sender, EventArgs e)
        {

        }
        public void ShowRoadMap_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab.Name == "ShowRoadMap")
            {
                var userService = new UserService();
                var rulesRepository = new RulesRepository();
                var userController = new UserController(userService);

                DateTime entryDate = dateTimePicker1.Value;
                bool wasMigrant = checkBox2.Checked;
                string? citizenship = comboBox1.SelectedItem?.ToString();
                bool isHighQualified = checkBox1.Checked;
                bool IsInProgram = checkBox3.Checked;

                if (citizenship == null)
                {
                    MessageBox.Show("Пожалуйста, выберите гражданство.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabControl1.SelectedIndex = 0;
                    return;
                }

                userController.EnterDetails(entryDate, wasMigrant, citizenship, isHighQualified, IsInProgram);

                var roadMapController = new RoadMapController(rulesRepository, userService);

                textBox1.Text = roadMapController.GetRoadMap();
            }
        }
    }
}
