namespace FinalProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // Members
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Gym.membersPage.Show();
            } catch (Exception ex) { 
                Gym.membersPage = new Members();
                Gym.membersPage.Show();
            }
            Gym.membersPage.TopMost = true;
            Gym.membersPage.TopMost = false;
        }

        // Log Out
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add Member
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Gym.addMemberPage.Show();
            }
            catch (Exception ex)
            {
                Gym.addMemberPage = new AddMember();
                Gym.addMemberPage.Show();
            }

            Gym.addMemberPage.TopMost = true;
            Gym.addMemberPage.TopMost = false;
        }

    }
}
