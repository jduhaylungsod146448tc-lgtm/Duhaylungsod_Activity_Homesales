namespace Duhaylungsod_Activity_Homesales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Submit_Click = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.Btn_Clear_Click = new System.Windows.Forms.Button();
            this.Btn_Print_Click = new System.Windows.Forms.Button();
            this.textBox_Initial = new System.Windows.Forms.TextBox();
            this.textBox_AmountOfSale = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.Daniela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E.Edward";
            // 
            // Btn_Submit_Click
            // 
            this.Btn_Submit_Click.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Submit_Click.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Submit_Click.Location = new System.Drawing.Point(71, 204);
            this.Btn_Submit_Click.Name = "Btn_Submit_Click";
            this.Btn_Submit_Click.Size = new System.Drawing.Size(121, 64);
            this.Btn_Submit_Click.TabIndex = 2;
            this.Btn_Submit_Click.Text = "Submit";
            this.Btn_Submit_Click.UseVisualStyleBackColor = false;
            this.Btn_Submit_Click.Click += new System.EventHandler(this.Btn_Submit_Click_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "F.Fatima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Sales Person Initial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount of Sales:";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(121, 281);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(40, 13);
            this.label_Result.TabIndex = 6;
            this.label_Result.Text = "Result:";
            this.label_Result.Click += new System.EventHandler(this.label6_Click);
            // 
            // Btn_Clear_Click
            // 
            this.Btn_Clear_Click.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Clear_Click.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Clear_Click.Location = new System.Drawing.Point(197, 204);
            this.Btn_Clear_Click.Name = "Btn_Clear_Click";
            this.Btn_Clear_Click.Size = new System.Drawing.Size(121, 64);
            this.Btn_Clear_Click.TabIndex = 7;
            this.Btn_Clear_Click.Text = "Clear";
            this.Btn_Clear_Click.UseVisualStyleBackColor = false;
            this.Btn_Clear_Click.Click += new System.EventHandler(this.Btn_Clear_Click_Click);
            // 
            // Btn_Print_Click
            // 
            this.Btn_Print_Click.Location = new System.Drawing.Point(324, 204);
            this.Btn_Print_Click.Name = "Btn_Print_Click";
            this.Btn_Print_Click.Size = new System.Drawing.Size(122, 64);
            this.Btn_Print_Click.TabIndex = 8;
            this.Btn_Print_Click.Text = "Print";
            this.Btn_Print_Click.UseVisualStyleBackColor = true;
            this.Btn_Print_Click.Click += new System.EventHandler(this.Btn_Print_Click_Click);
            // 
            // textBox_Initial
            // 
            this.textBox_Initial.Location = new System.Drawing.Point(241, 128);
            this.textBox_Initial.Name = "textBox_Initial";
            this.textBox_Initial.Size = new System.Drawing.Size(181, 20);
            this.textBox_Initial.TabIndex = 9;
            // 
            // textBox_AmountOfSale
            // 
            this.textBox_AmountOfSale.Location = new System.Drawing.Point(241, 154);
            this.textBox_AmountOfSale.Name = "textBox_AmountOfSale";
            this.textBox_AmountOfSale.Size = new System.Drawing.Size(181, 20);
            this.textBox_AmountOfSale.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 325);
            this.Controls.Add(this.textBox_AmountOfSale);
            this.Controls.Add(this.textBox_Initial);
            this.Controls.Add(this.Btn_Print_Click);
            this.Controls.Add(this.Btn_Clear_Click);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Submit_Click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Submit_Click;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button Btn_Clear_Click;
        private System.Windows.Forms.Button Btn_Print_Click;
        private System.Windows.Forms.TextBox textBox_Initial;
        private System.Windows.Forms.TextBox textBox_AmountOfSale;
    }
}

