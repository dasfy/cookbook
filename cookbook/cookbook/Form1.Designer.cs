﻿namespace cookbook
{
    partial class Form1
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
            this.addReceptB = new System.Windows.Forms.Button();
            this.titleT = new System.Windows.Forms.TextBox();
            this.autorC = new System.Windows.Forms.ComboBox();
            this.kitchenC = new System.Windows.Forms.ComboBox();
            this.ingred1C = new System.Windows.Forms.ComboBox();
            this.ingred2C = new System.Windows.Forms.ComboBox();
            this.ingred3C = new System.Windows.Forms.ComboBox();
            this.ingred4C = new System.Windows.Forms.ComboBox();
            this.ingred5C = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.measure1C = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.measure2C = new System.Windows.Forms.ComboBox();
            this.measure3C = new System.Windows.Forms.ComboBox();
            this.measure4C = new System.Windows.Forms.ComboBox();
            this.measure5C = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addReceptB
            // 
            this.addReceptB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addReceptB.Location = new System.Drawing.Point(356, 303);
            this.addReceptB.Name = "addReceptB";
            this.addReceptB.Size = new System.Drawing.Size(283, 23);
            this.addReceptB.TabIndex = 0;
            this.addReceptB.Text = "Добавить рецепт";
            this.addReceptB.UseVisualStyleBackColor = true;
            this.addReceptB.Click += new System.EventHandler(this.addReceptB_Click);
            // 
            // titleT
            // 
            this.titleT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.titleT.Location = new System.Drawing.Point(12, 41);
            this.titleT.Name = "titleT";
            this.titleT.Size = new System.Drawing.Size(154, 23);
            this.titleT.TabIndex = 1;
            // 
            // autorC
            // 
            this.autorC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.autorC.FormattingEnabled = true;
            this.autorC.Location = new System.Drawing.Point(12, 78);
            this.autorC.Name = "autorC";
            this.autorC.Size = new System.Drawing.Size(154, 24);
            this.autorC.TabIndex = 2;
            // 
            // kitchenC
            // 
            this.kitchenC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kitchenC.FormattingEnabled = true;
            this.kitchenC.Location = new System.Drawing.Point(12, 117);
            this.kitchenC.Name = "kitchenC";
            this.kitchenC.Size = new System.Drawing.Size(154, 24);
            this.kitchenC.TabIndex = 2;
            // 
            // ingred1C
            // 
            this.ingred1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ingred1C.FormattingEnabled = true;
            this.ingred1C.Location = new System.Drawing.Point(18, 47);
            this.ingred1C.Name = "ingred1C";
            this.ingred1C.Size = new System.Drawing.Size(154, 24);
            this.ingred1C.TabIndex = 2;
            // 
            // ingred2C
            // 
            this.ingred2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ingred2C.FormattingEnabled = true;
            this.ingred2C.Location = new System.Drawing.Point(18, 85);
            this.ingred2C.Name = "ingred2C";
            this.ingred2C.Size = new System.Drawing.Size(154, 24);
            this.ingred2C.TabIndex = 2;
            // 
            // ingred3C
            // 
            this.ingred3C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ingred3C.FormattingEnabled = true;
            this.ingred3C.Location = new System.Drawing.Point(18, 123);
            this.ingred3C.Name = "ingred3C";
            this.ingred3C.Size = new System.Drawing.Size(154, 24);
            this.ingred3C.TabIndex = 2;
            // 
            // ingred4C
            // 
            this.ingred4C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ingred4C.FormattingEnabled = true;
            this.ingred4C.Location = new System.Drawing.Point(18, 161);
            this.ingred4C.Name = "ingred4C";
            this.ingred4C.Size = new System.Drawing.Size(154, 24);
            this.ingred4C.TabIndex = 3;
            // 
            // ingred5C
            // 
            this.ingred5C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ingred5C.FormattingEnabled = true;
            this.ingred5C.Location = new System.Drawing.Point(18, 197);
            this.ingred5C.Name = "ingred5C";
            this.ingred5C.Size = new System.Drawing.Size(154, 24);
            this.ingred5C.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ingred1C);
            this.groupBox1.Controls.Add(this.ingred5C);
            this.groupBox1.Controls.Add(this.ingred2C);
            this.groupBox1.Controls.Add(this.ingred4C);
            this.groupBox1.Controls.Add(this.ingred3C);
            this.groupBox1.Controls.Add(this.measure5C);
            this.groupBox1.Controls.Add(this.measure4C);
            this.groupBox1.Controls.Add(this.measure3C);
            this.groupBox1.Controls.Add(this.measure2C);
            this.groupBox1.Controls.Add(this.measure1C);
            this.groupBox1.Location = new System.Drawing.Point(356, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 236);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ингредиенты                            единица измерения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(184, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "- Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(184, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "- Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(184, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "- Кухня";
            // 
            // measure1C
            // 
            this.measure1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.measure1C.FormattingEnabled = true;
            this.measure1C.Location = new System.Drawing.Point(201, 47);
            this.measure1C.Name = "measure1C";
            this.measure1C.Size = new System.Drawing.Size(59, 24);
            this.measure1C.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(12, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(317, 153);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Описание";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(245, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(245, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // measure2C
            // 
            this.measure2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.measure2C.FormattingEnabled = true;
            this.measure2C.Location = new System.Drawing.Point(201, 85);
            this.measure2C.Name = "measure2C";
            this.measure2C.Size = new System.Drawing.Size(59, 24);
            this.measure2C.TabIndex = 2;
            // 
            // measure3C
            // 
            this.measure3C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.measure3C.FormattingEnabled = true;
            this.measure3C.Location = new System.Drawing.Point(201, 123);
            this.measure3C.Name = "measure3C";
            this.measure3C.Size = new System.Drawing.Size(59, 24);
            this.measure3C.TabIndex = 2;
            // 
            // measure4C
            // 
            this.measure4C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.measure4C.FormattingEnabled = true;
            this.measure4C.Location = new System.Drawing.Point(201, 161);
            this.measure4C.Name = "measure4C";
            this.measure4C.Size = new System.Drawing.Size(59, 24);
            this.measure4C.TabIndex = 2;
            // 
            // measure5C
            // 
            this.measure5C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.measure5C.FormattingEnabled = true;
            this.measure5C.Location = new System.Drawing.Point(201, 197);
            this.measure5C.Name = "measure5C";
            this.measure5C.Size = new System.Drawing.Size(59, 24);
            this.measure5C.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kitchenC);
            this.Controls.Add(this.autorC);
            this.Controls.Add(this.titleT);
            this.Controls.Add(this.addReceptB);
            this.Name = "Form1";
            this.Text = "Добавление рецепта";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addReceptB;
        private System.Windows.Forms.TextBox titleT;
        private System.Windows.Forms.ComboBox autorC;
        private System.Windows.Forms.ComboBox kitchenC;
        private System.Windows.Forms.ComboBox ingred1C;
        private System.Windows.Forms.ComboBox ingred2C;
        private System.Windows.Forms.ComboBox ingred3C;
        private System.Windows.Forms.ComboBox ingred4C;
        private System.Windows.Forms.ComboBox ingred5C;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox measure1C;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox measure5C;
        private System.Windows.Forms.ComboBox measure4C;
        private System.Windows.Forms.ComboBox measure3C;
        private System.Windows.Forms.ComboBox measure2C;
    }
}
