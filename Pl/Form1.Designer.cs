namespace Pl
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            pasukBindingSource3 = new BindingSource(components);
            pasukBindingSource = new BindingSource(components);
            pasukBindingSource1 = new BindingSource(components);
            pasukBindingSource2 = new BindingSource(components);
            textBox2 = new TextBox();
            button4 = new Button();
            comboBox1 = new ComboBox();
            toraBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button5 = new Button();
            button6 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasukBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasukBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasukBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasukBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toraBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(537, 144);
            button1.Name = "button1";
            button1.Size = new Size(279, 29);
            button1.TabIndex = 0;
            button1.Text = "חפש";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Fb TypoTag Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(537, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 24);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(200, 64);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(100, 62);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "חפש";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1318, 649);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // pasukBindingSource3
            // 
            pasukBindingSource3.DataSource = typeof(DOT.Pasuk);
            // 
            // pasukBindingSource
            // 
            pasukBindingSource.DataSource = typeof(DOT.Pasuk);
            // 
            // pasukBindingSource1
            // 
            pasukBindingSource1.DataSource = typeof(DOT.Pasuk);
            // 
            // pasukBindingSource2
            // 
            pasukBindingSource2.DataSource = typeof(DOT.Pasuk);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1044, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 27);
            textBox2.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(1044, 3);
            button4.Name = "button4";
            button4.Size = new Size(325, 29);
            button4.TabIndex = 8;
            button4.Text = "חיפוש ערך גימטרי המחזיר רצף מילים בפסוק";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "בראשית", "שמות", "ויקרא", "במדבר", "דברים" });
            comboBox1.Location = new Point(537, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 28);
            comboBox1.TabIndex = 10;
            // 
            // toraBindingSource
            // 
            toraBindingSource.DataSource = typeof(DOT.Tora);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(537, 66);
            label1.Name = "label1";
            label1.Size = new Size(279, 20);
            label1.TabIndex = 11;
            label1.Text = "באפשרותך לבחור חומש בו יתבצע החיפוש";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 99);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 12;
            label2.Text = "חפש פסוקים לשמות אנשים";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(679, 38);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 13;
            label3.Text = "הקלד טקסט לחיפוש";
            // 
            // button5
            // 
            button5.Location = new Point(1044, 38);
            button5.Name = "button5";
            button5.Size = new Size(325, 29);
            button5.TabIndex = 14;
            button5.Text = "חיפוש ערך גימטרי המחזיר מילה בודדת";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(356, 34);
            button6.Name = "button6";
            button6.Size = new Size(133, 66);
            button6.TabIndex = 15;
            button6.Text = "חיפושים אחרונים";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(356, 106);
            button2.Name = "button2";
            button2.Size = new Size(133, 57);
            button2.TabIndex = 16;
            button2.Text = "מחק חיפושים אחרונים";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 840);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pasukBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pasukBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pasukBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pasukBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)toraBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox4;
        private Button button3;
        private DataGridView dataGridView1;
        private BindingSource pasukBindingSource;
        private BindingSource pasukBindingSource1;
        private BindingSource pasukBindingSource2;
        private DataGridViewTextBoxColumn פסוק;
        private BindingSource pasukBindingSource3;
        private TextBox textBox2;
        private Button button4;
        private ComboBox comboBox1;
        private BindingSource toraBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button5;
        private Button button6;
        private Button button2;
    }
}