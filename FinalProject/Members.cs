using FinalProject.Models;
using System.Collections;
using System.Data;


namespace FinalProject
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        ArrayList members;
        ArrayList searched = new ArrayList();
        DataTable dt;

        private void Members_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("Joined At", typeof(DateTime));
            dt.Columns.Add("Days Left", typeof(string));

            members = DBHandler.GetMembers();

            this.FillTable(members);
        }

        private void FillTable(ArrayList data)
        {
            dt.Rows.Clear();

            foreach (MemberModel member in data)
            {
                dt.Rows.Add(new object[] { member.id, member.name, member.phone, DateTime.Parse(member.joined_at), member.paid });
            }

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            foreach (MemberModel member in members)
            {
                if (member.id == id)
                {
                    Gym.editMemberPage = new AddMember(member);
                    Gym.editMemberPage.Show();
                    Gym.editMemberPage.TopMost = true;
                    Gym.editMemberPage.TopMost = false;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.ToString().Trim();
            searched = new ArrayList();

            if (s == "")
            {
                this.FillTable(members);
            }
            else
            {
                foreach (MemberModel member in members)
                {
                    if (member.name.Contains(s) || member.phone.Contains(s)) 
                    {
                        searched.Add(member);
                    }
                }
                this.FillTable(searched);
            }
        }
    }
}
