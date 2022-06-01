namespace TicTicTacTac
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIlEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEwGAmEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIghScrOrEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hElpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abOUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hOwTOPlAyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b1 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x_win_count = new System.Windows.Forms.Label();
            this.draw_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_Popup);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIlEToolStripMenuItem,
            this.hElpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(254, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // fIlEToolStripMenuItem
            // 
            this.fIlEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEwGAmEToolStripMenuItem,
            this.hIghScrOrEToolStripMenuItem,
            this.exItToolStripMenuItem});
            this.fIlEToolStripMenuItem.Name = "fIlEToolStripMenuItem";
            this.fIlEToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fIlEToolStripMenuItem.Text = "fIlE";
            // 
            // nEwGAmEToolStripMenuItem
            // 
            this.nEwGAmEToolStripMenuItem.Name = "nEwGAmEToolStripMenuItem";
            this.nEwGAmEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nEwGAmEToolStripMenuItem.Text = "nEw gAmE";
            this.nEwGAmEToolStripMenuItem.Click += new System.EventHandler(this.nEwGAmEToolStripMenuItem_Click_1);
            // 
            // hIghScrOrEToolStripMenuItem
            // 
            this.hIghScrOrEToolStripMenuItem.Name = "hIghScrOrEToolStripMenuItem";
            this.hIghScrOrEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hIghScrOrEToolStripMenuItem.Text = "rEsEt cOUnt";
            this.hIghScrOrEToolStripMenuItem.Click += new System.EventHandler(this.hIghScrOrEToolStripMenuItem_Click);
            // 
            // exItToolStripMenuItem
            // 
            this.exItToolStripMenuItem.Name = "exItToolStripMenuItem";
            this.exItToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exItToolStripMenuItem.Text = "ExIt";
            this.exItToolStripMenuItem.Click += new System.EventHandler(this.ExItToolStripMenuItem_Click);
            // 
            // hElpToolStripMenuItem
            // 
            this.hElpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abOUtToolStripMenuItem,
            this.hOwTOPlAyToolStripMenuItem});
            this.hElpToolStripMenuItem.Name = "hElpToolStripMenuItem";
            this.hElpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.hElpToolStripMenuItem.Text = "hElp";
            // 
            // abOUtToolStripMenuItem
            // 
            this.abOUtToolStripMenuItem.Name = "abOUtToolStripMenuItem";
            this.abOUtToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.abOUtToolStripMenuItem.Text = "AbOUt";
            this.abOUtToolStripMenuItem.Click += new System.EventHandler(this.abOUtToolStripMenuItem_Click);
            // 
            // hOwTOPlAyToolStripMenuItem
            // 
            this.hOwTOPlAyToolStripMenuItem.Name = "hOwTOPlAyToolStripMenuItem";
            this.hOwTOPlAyToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.hOwTOPlAyToolStripMenuItem.Text = "hOw tO plAy?";
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Miriam CLM", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b1.Location = new System.Drawing.Point(2, 28);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(85, 85);
            this.b1.TabIndex = 1;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_Click);
            this.b1.MouseEnter += new System.EventHandler(this.button_enter);
            this.b1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Miriam CLM", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b3.Location = new System.Drawing.Point(165, 28);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(85, 85);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_Click);
            this.b3.MouseEnter += new System.EventHandler(this.button_enter);
            this.b3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Miriam CLM", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b2.Location = new System.Drawing.Point(85, 27);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(85, 85);
            this.b2.TabIndex = 3;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_Click);
            this.b2.MouseEnter += new System.EventHandler(this.button_enter);
            this.b2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Miriam CLM", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b6.Location = new System.Drawing.Point(164, 110);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(85, 85);
            this.b6.TabIndex = 4;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button_Click);
            this.b6.MouseEnter += new System.EventHandler(this.button_enter);
            this.b6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Miriam CLM", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b5.Location = new System.Drawing.Point(85, 110);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(85, 85);
            this.b5.TabIndex = 5;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button_Click);
            this.b5.MouseEnter += new System.EventHandler(this.button_enter);
            this.b5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Miriam CLM", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b4.Location = new System.Drawing.Point(3, 110);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(85, 85);
            this.b4.TabIndex = 6;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button_Click);
            this.b4.MouseEnter += new System.EventHandler(this.button_enter);
            this.b4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Miriam CLM", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b8.Location = new System.Drawing.Point(86, 191);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(85, 85);
            this.b8.TabIndex = 7;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button_Click);
            this.b8.MouseEnter += new System.EventHandler(this.button_enter);
            this.b8.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Miriam CLM", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b7.Location = new System.Drawing.Point(3, 191);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(85, 85);
            this.b7.TabIndex = 8;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button_Click);
            this.b7.MouseEnter += new System.EventHandler(this.button_enter);
            this.b7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Miriam CLM", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b9.Location = new System.Drawing.Point(165, 191);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(85, 85);
            this.b9.TabIndex = 9;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button_Click);
            this.b9.MouseEnter += new System.EventHandler(this.button_enter);
            this.b9.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "X win";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(177, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "O win";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "drAw";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Location = new System.Drawing.Point(30, 300);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(13, 15);
            this.x_win_count.TabIndex = 13;
            this.x_win_count.Text = "0";
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Location = new System.Drawing.Point(119, 300);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(13, 15);
            this.draw_count.TabIndex = 14;
            this.draw_count.Text = "0";
            this.draw_count.Click += new System.EventHandler(this.label5_Click);
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Location = new System.Drawing.Point(197, 300);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(13, 15);
            this.o_win_count.TabIndex = 15;
            this.o_win_count.Text = "0";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 318);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "TicTicTacTac";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fIlEToolStripMenuItem;
        private ToolStripMenuItem nEwGAmEToolStripMenuItem;
        private ToolStripMenuItem hIghScrOrEToolStripMenuItem;
        private ToolStripMenuItem hElpToolStripMenuItem;
        private ToolStripMenuItem exItToolStripMenuItem;
        private ToolStripMenuItem abOUtToolStripMenuItem;
        private ToolStripMenuItem hOwTOPlAyToolStripMenuItem;
        private Button b1;
        private Button b3;
        private Button b2;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button b8;
        private Button b7;
        private Button b9;
        private ToolStripItemClickedEventHandler menuStrip_ItemClicked;
        private EventHandler exItToolStripMenuItem_Click;
        private EventHandler nEwgAmEToolStripMenuItem_Click;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label x_win_count;
        private Label draw_count;
        private Label o_win_count;
    }
}