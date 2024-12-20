﻿namespace MigrationSystem.View
{
    partial class UserEntryForm
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            tabControl1 = new TabControl();
            EnterData = new TabPage();
            label2 = new Label();
            label1 = new Label();
            ShowRoadMap = new TabPage();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            EnterData.SuspendLayout();
            ShowRoadMap.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(22, 121);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(462, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Являетесь ли вы высококвалифицированным специалистом?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(22, 183);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(367, 24);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Состояли ли вы на миграционном учете ранее?";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(22, 248);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(575, 24);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Являетесь ли вы участником программы перенаселения соотечественников?";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(566, 55);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(329, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 55);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(EnterData);
            tabControl1.Controls.Add(ShowRoadMap);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(938, 583);
            tabControl1.TabIndex = 6;
            // 
            // EnterData
            // 
            EnterData.Controls.Add(label2);
            EnterData.Controls.Add(label1);
            EnterData.Controls.Add(comboBox1);
            EnterData.Controls.Add(checkBox1);
            EnterData.Controls.Add(dateTimePicker1);
            EnterData.Controls.Add(checkBox2);
            EnterData.Controls.Add(checkBox3);
            EnterData.Location = new Point(4, 29);
            EnterData.Margin = new Padding(3, 4, 3, 4);
            EnterData.Name = "EnterData";
            EnterData.Padding = new Padding(3, 4, 3, 4);
            EnterData.Size = new Size(930, 550);
            EnterData.TabIndex = 1;
            EnterData.Text = "Ввод данных";
            EnterData.UseVisualStyleBackColor = true;
            EnterData.Click += EnterData_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(566, 19);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 7;
            label2.Text = "Укажите дату въезда в РФ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 6;
            label1.Text = "Укажите свое гражданство:";
            label1.Click += label1_Click_1;
            // 
            // ShowRoadMap
            // 
            ShowRoadMap.Controls.Add(textBox1);
            ShowRoadMap.Location = new Point(4, 29);
            ShowRoadMap.Margin = new Padding(3, 4, 3, 4);
            ShowRoadMap.Name = "ShowRoadMap";
            ShowRoadMap.Size = new Size(930, 550);
            ShowRoadMap.TabIndex = 2;
            ShowRoadMap.Text = "Дорожная карта";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(905, 540);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // UserEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserEntryForm";
            Text = "Форма Мигранта";
            tabControl1.ResumeLayout(false);
            EnterData.ResumeLayout(false);
            EnterData.PerformLayout();
            ShowRoadMap.ResumeLayout(false);
            ShowRoadMap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TabControl tabControl1;
        private TabPage EnterData;
        private TabPage ShowRoadMap;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}