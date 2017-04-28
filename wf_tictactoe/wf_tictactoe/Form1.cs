using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_tictactoe
{
    public partial class Form1 : Form
    {
		bool turn = true; // true = X turn; false = Y turn
		int turn_cnt = 0;
		
        public Form1() {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("By Yiying", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

		private void button_Click(object sender, EventArgs e) {
			Button b = (Button)sender;

			if (turn) {
				b.Text = "X";
			} else {
				b.Text = "O";
			}

			turn = !turn;
			b.Enabled = false;
			turn_cnt++;
			checkForWinner();
		}

		private void checkForWinner() {
			bool there_is_a_winner = false;

			// horizontal checks
			if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) {
				there_is_a_winner = true;
			} else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled)) {
				there_is_a_winner = true;
			} else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled)) {
				there_is_a_winner = true;
			}

			// vertical check
			if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled)) {
				there_is_a_winner = true;
			} else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled)) {
				there_is_a_winner = true;
			} else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled)) {
				there_is_a_winner = true;
			}

			// Diagonal check
			if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled)) {
				there_is_a_winner = true;
			} else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled)) {
				there_is_a_winner = true;
			}

			if (there_is_a_winner) {
				disableButtons();

				String winner = "";
				if (turn) {
					winner = "O";
					o_win_cnt.Text = (Int32.Parse(o_win_cnt.Text) + 1).ToString();
				} else {
					winner = "X";
					x_win_cnt.Text = (Int32.Parse(x_win_cnt.Text) + 1).ToString();

				}

				MessageBox.Show(winner + " Wins!", "Yay!");
			} else {
				// if there is a draw
				if (turn_cnt == 9) {
					draw_cnt.Text = (Int32.Parse(draw_cnt.Text) + 1).ToString();
					MessageBox.Show("There is a draw!", " Bummer!");
				}
			}


		} // end checkForWinner

		private void disableButtons() {
			try {

				foreach (Control c in Controls) {
					Button b = (Button)c;
					b.Enabled = false;
				}
			} catch { }

			
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e) {
			turn = true;
			turn_cnt = 0;

			
			foreach (Control c in Controls) {
				try {
					Button b = (Button)c;
					b.Enabled = true;
					b.Text = "";
				} catch { }
			} 
		}

		private void button_enter(object sender, EventArgs e) {
			Button b = (Button)sender;

			if (turn) {
				b.Text = "X";
			} else {
				b.Text = "O";
			}

		}

		private void button_leave(object sender, EventArgs e) {

			Button b = (Button)sender;

			if (b.Enabled) {
				b.Text = "";
			}
		}

		private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e) {
			o_win_cnt.Text = "0";
			x_win_cnt.Text = "0";
			draw_cnt.Text = "0";
		}
	}
}
