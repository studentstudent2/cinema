namespace Cinema_Demo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.filmsButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.yearField = new System.Windows.Forms.Label();
            this.ticketLogo = new System.Windows.Forms.PictureBox();
            this.sessionLogo = new System.Windows.Forms.PictureBox();
            this.filmLogo = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.pictureBox3);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.ticketLogo);
            this.mainPanel.Controls.Add(this.yearField);
            this.mainPanel.Controls.Add(this.button5);
            this.mainPanel.Controls.Add(this.button4);
            this.mainPanel.Controls.Add(this.button3);
            this.mainPanel.Controls.Add(this.sessionLogo);
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.filmLogo);
            this.mainPanel.Controls.Add(this.filmsButton);
            this.mainPanel.Controls.Add(this.minimizeButton);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.mainLogo);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPanel.Location = new System.Drawing.Point(1, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(311, 523);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(29, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Залы";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(29, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сеансы";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // filmsButton
            // 
            this.filmsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filmsButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.filmsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmsButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmsButton.ForeColor = System.Drawing.Color.Black;
            this.filmsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filmsButton.Location = new System.Drawing.Point(29, 144);
            this.filmsButton.Name = "filmsButton";
            this.filmsButton.Size = new System.Drawing.Size(254, 43);
            this.filmsButton.TabIndex = 3;
            this.filmsButton.Text = "Фильмы";
            this.filmsButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(29, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Сектора";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(29, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 43);
            this.button4.TabIndex = 9;
            this.button4.Text = "Продажа билетов";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(29, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(254, 43);
            this.button5.TabIndex = 10;
            this.button5.Text = "Режжисеры";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // yearField
            // 
            this.yearField.AutoSize = true;
            this.yearField.BackColor = System.Drawing.Color.Transparent;
            this.yearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearField.ForeColor = System.Drawing.Color.Gray;
            this.yearField.Location = new System.Drawing.Point(88, 501);
            this.yearField.Name = "yearField";
            this.yearField.Size = new System.Drawing.Size(140, 16);
            this.yearField.TabIndex = 11;
            this.yearField.Text = "00.00.0000 00:00:00";
            // 
            // ticketLogo
            // 
            this.ticketLogo.BackColor = System.Drawing.Color.Transparent;
            this.ticketLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ticketLogo.Image = global::Cinema_Demo.Properties.Resources.ticket;
            this.ticketLogo.Location = new System.Drawing.Point(33, 393);
            this.ticketLogo.Name = "ticketLogo";
            this.ticketLogo.Size = new System.Drawing.Size(35, 35);
            this.ticketLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ticketLogo.TabIndex = 12;
            this.ticketLogo.TabStop = false;
            // 
            // sessionLogo
            // 
            this.sessionLogo.BackColor = System.Drawing.Color.Transparent;
            this.sessionLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sessionLogo.Image = global::Cinema_Demo.Properties.Resources.session;
            this.sessionLogo.Location = new System.Drawing.Point(33, 197);
            this.sessionLogo.Name = "sessionLogo";
            this.sessionLogo.Size = new System.Drawing.Size(35, 35);
            this.sessionLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sessionLogo.TabIndex = 7;
            this.sessionLogo.TabStop = false;
            // 
            // filmLogo
            // 
            this.filmLogo.BackColor = System.Drawing.Color.Transparent;
            this.filmLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filmLogo.Image = global::Cinema_Demo.Properties.Resources.film;
            this.filmLogo.Location = new System.Drawing.Point(33, 148);
            this.filmLogo.Name = "filmLogo";
            this.filmLogo.Size = new System.Drawing.Size(35, 35);
            this.filmLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filmLogo.TabIndex = 4;
            this.filmLogo.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = global::Cinema_Demo.Properties.Resources.minimize;
            this.minimizeButton.Location = new System.Drawing.Point(264, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::Cinema_Demo.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(284, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mainLogo
            // 
            this.mainLogo.Image = global::Cinema_Demo.Properties.Resources.mainLogo;
            this.mainLogo.Location = new System.Drawing.Point(0, -45);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(311, 212);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLogo.TabIndex = 0;
            this.mainLogo.TabStop = false;
            this.mainLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Cinema_Demo.Properties.Resources.session;
            this.pictureBox1.Location = new System.Drawing.Point(33, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Cinema_Demo.Properties.Resources.session;
            this.pictureBox2.Location = new System.Drawing.Point(33, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Cinema_Demo.Properties.Resources.session;
            this.pictureBox3.Location = new System.Drawing.Point(33, 344);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(313, 525);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление кинотеатром";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox mainLogo;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Button filmsButton;
        private System.Windows.Forms.PictureBox filmLogo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox sessionLogo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label yearField;
        private System.Windows.Forms.PictureBox ticketLogo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

