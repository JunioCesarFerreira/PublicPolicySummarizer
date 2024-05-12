namespace InsertSumury
{
    partial class FormMain
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            textBox_original = new TextBox();
            textBox_summary = new TextBox();
            label1 = new Label();
            button_save = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox_id = new TextBox();
            button_find = new Button();
            button_next = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox_original, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox_summary, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(7, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(784, 403);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "Resumo";
            // 
            // textBox_original
            // 
            textBox_original.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_original.Location = new Point(3, 18);
            textBox_original.MaxLength = 1000000;
            textBox_original.Multiline = true;
            textBox_original.Name = "textBox_original";
            textBox_original.ScrollBars = ScrollBars.Vertical;
            textBox_original.Size = new Size(386, 382);
            textBox_original.TabIndex = 0;
            // 
            // textBox_summary
            // 
            textBox_summary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_summary.Location = new Point(395, 18);
            textBox_summary.Multiline = true;
            textBox_summary.Name = "textBox_summary";
            textBox_summary.ScrollBars = ScrollBars.Vertical;
            textBox_summary.Size = new Size(386, 382);
            textBox_summary.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Texto Original";
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_save.Location = new Point(739, 6);
            button_save.Margin = new Padding(0);
            button_save.Name = "button_save";
            button_save.Size = new Size(52, 23);
            button_save.TabIndex = 1;
            button_save.Text = "save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += Button_Save_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(94, 397);
            textBox2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(3, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 397);
            textBox3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 5;
            label3.Text = "ID:";
            // 
            // textBox_id
            // 
            textBox_id.BorderStyle = BorderStyle.FixedSingle;
            textBox_id.Location = new Point(39, 6);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(89, 23);
            textBox_id.TabIndex = 6;
            textBox_id.TextAlign = HorizontalAlignment.Center;
            textBox_id.TextChanged += TextBox_Id_TextChanged;
            // 
            // button_find
            // 
            button_find.Location = new Point(143, 6);
            button_find.Margin = new Padding(0);
            button_find.Name = "button_find";
            button_find.Size = new Size(52, 23);
            button_find.TabIndex = 7;
            button_find.Text = "find";
            button_find.UseVisualStyleBackColor = true;
            button_find.Click += Button_Find_Click;
            // 
            // button_next
            // 
            button_next.Location = new Point(204, 6);
            button_next.Margin = new Padding(0);
            button_next.Name = "button_next";
            button_next.Size = new Size(52, 23);
            button_next.TabIndex = 8;
            button_next.Text = "next";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += Button_Next_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_next);
            Controls.Add(button_find);
            Controls.Add(textBox_id);
            Controls.Add(label3);
            Controls.Add(button_save);
            Controls.Add(tableLayoutPanel1);
            Name = "FormMain";
            Text = "Inserção de Resumos";
            Load += FormMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button_save;
        private Label label2;
        private TextBox textBox_original;
        private TextBox textBox_summary;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox_id;
        private Button button_find;
        private Button button_next;
    }
}
