namespace wf_tictactoe {
	partial class Form2 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.p1 = new System.Windows.Forms.TextBox();
			this.p2 = new System.Windows.Forms.TextBox();
			this.playBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Player One Name: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(35, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Player Two Name: ";
			// 
			// p1
			// 
			this.p1.Location = new System.Drawing.Point(180, 21);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(230, 20);
			this.p1.TabIndex = 2;
			// 
			// p2
			// 
			this.p2.Location = new System.Drawing.Point(180, 57);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(230, 20);
			this.p2.TabIndex = 3;
			this.p2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p2_KeyPress);
			// 
			// playBtn
			// 
			this.playBtn.Location = new System.Drawing.Point(335, 91);
			this.playBtn.Name = "playBtn";
			this.playBtn.Size = new System.Drawing.Size(75, 23);
			this.playBtn.TabIndex = 4;
			this.playBtn.Text = "Play";
			this.playBtn.UseVisualStyleBackColor = true;
			this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 134);
			this.Controls.Add(this.playBtn);
			this.Controls.Add(this.p2);
			this.Controls.Add(this.p1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(457, 173);
			this.MinimumSize = new System.Drawing.Size(457, 173);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tic Tac Toe";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox p1;
		private System.Windows.Forms.TextBox p2;
		private System.Windows.Forms.Button playBtn;
	}
}