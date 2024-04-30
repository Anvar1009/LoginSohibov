namespace LoginFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FullNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            string userFilePath = @"D:\LoginFormDemo\LoginFormDemo\LoginFormDemo\UserList.Txt";
            string userFilePath2 = @"D:\LoginFormDemo\LoginFormDemo";
            string userFilePathFile = @"D:\LoginFormDemo\LoginFormDemo\royxat.txt";
            string[] Id = File.ReadAllLines(userFilePath);
            Directory.CreateDirectory(userFilePath2);
            File.Create(userFilePathFile);

            File.AppendAllText(userFilePath, Id.Length.ToString()+
                   "," + FullNameText.Text + ","
                    + UserNameText.Text + ","
                    + PassText.Text +","
                    + Role.Person
                    +"\n");
            RegisterAccount registerAccount = new RegisterAccount();
            registerAccount.Show(); this.Hide();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show(); this.Hide();
        }
    }
}
