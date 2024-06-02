using FinalProject.Models;


namespace FinalProject
{
    public partial class AddMember : Form
    {
        private MemberModel member;
        private bool editMode = false;

        public AddMember()
        {
            InitializeComponent();
        }

        public AddMember(MemberModel member)
        {
            this.member = member;
            editMode = true;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = textBox1.Text.ToString();
            string phone = textBox2.Text.ToString();
            string age = numericUpDown2.Value.ToString();
            string paid = numericUpDown1.Value.ToString();

            // To-Do: Validate

            if (editMode)
                DBHandler.ExecuteNonQuery($"UPDATE Member SET fullname='{fullname}', phone='{phone}', age={age}, paid={paid} WHERE id={member.id}");
            else
                DBHandler.ExecuteNonQuery($"INSERT INTO Member (fullname, phone, age, paid) VALUES ('{fullname}', '{phone}', {age}, {paid})");

            MessageBox.Show("DONE!");
            this.Close();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                button1.Text = "Edit";
                label5.Text = "Edit " + member.name;
                textBox1.Text = member.name;
                textBox2.Text = member.phone;
                numericUpDown2.Value = Int32.Parse(member.age);
                numericUpDown1.Value = Int32.Parse(member.paid);

            }
            else
            {
                button1.Text = "Register";
                label5.Text = "Add New Member";
            }
        }
    }
}
