namespace VotingApp
{
    partial class VoterReg
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GenderSelector = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.PollingUnit = new System.Windows.Forms.ComboBox();
            this.Register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewVoterList = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            this.label1.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.label1_ChangeUICues);
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(73, 270);
            this.firstName.Name = "firstName";
            this.firstName.PlaceholderText = "Firstname";
            this.firstName.Size = new System.Drawing.Size(293, 31);
            this.firstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(334, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Voter Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(507, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Middlename";
            // 
            // middleName
            // 
            this.middleName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.middleName.Location = new System.Drawing.Point(507, 267);
            this.middleName.Name = "middleName";
            this.middleName.PlaceholderText = "Middlename";
            this.middleName.Size = new System.Drawing.Size(324, 30);
            this.middleName.TabIndex = 4;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(73, 352);
            this.lastName.Name = "lastName";
            this.lastName.PlaceholderText = "Lastname";
            this.lastName.Size = new System.Drawing.Size(293, 30);
            this.lastName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(73, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(507, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender";
            // 
            // GenderSelector
            // 
            this.GenderSelector.FormattingEnabled = true;
            this.GenderSelector.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.GenderSelector.Location = new System.Drawing.Point(507, 352);
            this.GenderSelector.Name = "GenderSelector";
            this.GenderSelector.Size = new System.Drawing.Size(151, 28);
            this.GenderSelector.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(73, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date Of birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 444);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 27);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(680, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Polling Unit";
            // 
            // PollingUnit
            // 
            this.PollingUnit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PollingUnit.FormattingEnabled = true;
            this.PollingUnit.Items.AddRange(new object[] {
            "ABS"});
            this.PollingUnit.Location = new System.Drawing.Point(680, 350);
            this.PollingUnit.Name = "PollingUnit";
            this.PollingUnit.Size = new System.Drawing.Size(151, 31);
            this.PollingUnit.TabIndex = 12;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Register.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Register.Location = new System.Drawing.Point(487, 444);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(148, 55);
            this.Register.TabIndex = 14;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 177);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 97);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ViewVoterList
            // 
            this.ViewVoterList.AutoSize = true;
            this.ViewVoterList.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ViewVoterList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewVoterList.ForeColor = System.Drawing.Color.Black;
            this.ViewVoterList.Location = new System.Drawing.Point(660, 512);
            this.ViewVoterList.Name = "ViewVoterList";
            this.ViewVoterList.Size = new System.Drawing.Size(259, 28);
            this.ViewVoterList.TabIndex = 16;
            this.ViewVoterList.Text = "View Registered Voters>>";
            this.ViewVoterList.Click += new System.EventHandler(this.ViewVoterList_Click);
            // 
            // VoterReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 571);
            this.Controls.Add(this.ViewVoterList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.PollingUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GenderSelector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.Name = "VoterReg";
            this.Text = "VoterReg";
            this.Load += new System.EventHandler(this.VoterReg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox firstName;
        private Label label2;
        private Label label3;
        private TextBox middleName;
        private TextBox lastName;
        private Label label4;
        private Label label5;
        private ComboBox GenderSelector;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox PollingUnit;
        private Button Register;
        private Panel panel1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label ViewVoterList;
    }
}