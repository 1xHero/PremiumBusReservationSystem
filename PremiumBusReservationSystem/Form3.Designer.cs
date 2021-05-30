
namespace PremiumBusReservationSystem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.atime = new System.Windows.Forms.TextBox();
            this.dtime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tprice = new System.Windows.Forms.TextBox();
            this.nseat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.atime);
            this.groupBox1.Controls.Add(this.dtime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tprice);
            this.groupBox1.Controls.Add(this.nseat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.to);
            this.groupBox1.Controls.Add(this.from);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edite Trip Line ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mdate
            // 
            this.mdate.Location = new System.Drawing.Point(685, 85);
            this.mdate.Name = "mdate";
            this.mdate.Size = new System.Drawing.Size(161, 20);
            this.mdate.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Month date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ticket Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "number of seats";
            // 
            // atime
            // 
            this.atime.Location = new System.Drawing.Point(435, 84);
            this.atime.MaxLength = 5;
            this.atime.Name = "atime";
            this.atime.Size = new System.Drawing.Size(132, 20);
            this.atime.TabIndex = 21;
            this.atime.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // dtime
            // 
            this.dtime.Location = new System.Drawing.Point(171, 77);
            this.dtime.MaxLength = 5;
            this.dtime.Name = "dtime";
            this.dtime.Size = new System.Drawing.Size(100, 20);
            this.dtime.TabIndex = 20;
            this.dtime.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dispatch time";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Arrival time";
            // 
            // tprice
            // 
            this.tprice.Location = new System.Drawing.Point(434, 126);
            this.tprice.Name = "tprice";
            this.tprice.Size = new System.Drawing.Size(133, 20);
            this.tprice.TabIndex = 15;
            // 
            // nseat
            // 
            this.nseat.Location = new System.Drawing.Point(171, 122);
            this.nseat.Name = "nseat";
            this.nseat.Size = new System.Drawing.Size(100, 20);
            this.nseat.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "To";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "From";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(434, 42);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(133, 20);
            this.to.TabIndex = 11;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(171, 42);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(100, 20);
            this.from.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(493, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Display";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(937, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(970, 573);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(970, 573);
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.Text = "Premium Bus Reservation System - Administrator Panel - Trips";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tprice;
        private System.Windows.Forms.TextBox nseat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mdate;
        private System.Windows.Forms.TextBox atime;
        private System.Windows.Forms.TextBox dtime;
    }
}