namespace TicTicTacTac
{
    public partial class Form : System.Windows.Forms.Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form()
        {
            InitializeComponent();
        }
        private void ExItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abOUtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("by blUEfAcE jAckIE \n \n " +
            "a classic Tic Tac Toe console game best enjoyed with friends 'cos yunno that's how life should be or choose to go toe to toe with your personal computer which by the way shouldn't be able to think 'cos I dunno haven't you seen Matrix? but yeah sure let's give computers brains why not that'll be fun 'nd hey you not gonna win it smartest you oh wait there's a dumb button. \n \n " +
            "TicTicTacTac© copyright @23seigfried", "TicTicTacTac AbOUt");
        }

        private void hIghScrOrEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            if (turn)
                butt.Text = "X";
            else
                butt.Text = "O";
            turn = !turn;
            butt.Enabled = false;
            turn_count++;

            checkforwinner();
        }

        private void checkforwinner()
        {
            bool there_is_a_winner = false;
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
               there_is_a_winner = true;
            else if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && (!b4.Enabled))
               there_is_a_winner = true;
            else if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && (!b7.Enabled))
                there_is_a_winner = true;


            if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && (!b1.Enabled))
                there_is_a_winner = true;
            else if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && (!b2.Enabled))
                there_is_a_winner = true;
            else if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && (!b3.Enabled))
                there_is_a_winner = true;


            if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && (!b1.Enabled))
                there_is_a_winner = true;
            else if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && (!b3.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disableButtons();
                string winner;
                if (turn)
                {
                    winner = "O";
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Wins!", "Hurry!");
            }
           else
           {
                if (turn_count == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("Draw!", "Ops");
                }
           }
        }

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button butt = (Button)c;
                    butt.Enabled = false;
                }
            catch { }
            }
        }

        private void nEwGAmEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button butt = (Button)c;
                    butt.Enabled = true;
                    butt.Text = "";
                }
                catch { }
            }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            if (butt.Enabled)
            {
                if (turn)
                    butt.Text = "X";
                else
                    butt.Text = "O";

            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            if (butt.Enabled)
            {
                butt.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}