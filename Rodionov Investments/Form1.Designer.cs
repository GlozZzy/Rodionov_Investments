
namespace Rodionov_Investments
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_sell_she = new System.Windows.Forms.Button();
            this.button_buy_she = new System.Windows.Forms.Button();
            this.label_she = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_sell_pou = new System.Windows.Forms.Button();
            this.button_buy_pou = new System.Windows.Forms.Button();
            this.label_pou = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_sell_eur = new System.Windows.Forms.Button();
            this.button_buy_eur = new System.Windows.Forms.Button();
            this.label_eur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_sell_doll = new System.Windows.Forms.Button();
            this.button_buy_doll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_doll = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_bal = new System.Windows.Forms.Button();
            this.label_err = new System.Windows.Forms.Label();
            this.label_ru = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 136);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Стоимость валют в ₽:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.button_sell_she);
            this.panel6.Controls.Add(this.button_buy_she);
            this.panel6.Controls.Add(this.label_she);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(434, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(134, 67);
            this.panel6.TabIndex = 15;
            // 
            // button_sell_she
            // 
            this.button_sell_she.Location = new System.Drawing.Point(65, 39);
            this.button_sell_she.Name = "button_sell_she";
            this.button_sell_she.Size = new System.Drawing.Size(64, 23);
            this.button_sell_she.TabIndex = 13;
            this.button_sell_she.Text = "продать";
            this.button_sell_she.UseVisualStyleBackColor = true;
            this.button_sell_she.Click += new System.EventHandler(this.button_sell_she_Click);
            // 
            // button_buy_she
            // 
            this.button_buy_she.Location = new System.Drawing.Point(1, 39);
            this.button_buy_she.Name = "button_buy_she";
            this.button_buy_she.Size = new System.Drawing.Size(64, 23);
            this.button_buy_she.TabIndex = 12;
            this.button_buy_she.Text = "купить";
            this.button_buy_she.UseVisualStyleBackColor = true;
            this.button_buy_she.Click += new System.EventHandler(this.button_buy_she_Click);
            // 
            // label_she
            // 
            this.label_she.AutoSize = true;
            this.label_she.Location = new System.Drawing.Point(34, 14);
            this.label_she.Name = "label_she";
            this.label_she.Size = new System.Drawing.Size(13, 13);
            this.label_she.TabIndex = 3;
            this.label_she.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "₪:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.button_sell_pou);
            this.panel5.Controls.Add(this.button_buy_pou);
            this.panel5.Controls.Add(this.label_pou);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(294, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(134, 67);
            this.panel5.TabIndex = 14;
            // 
            // button_sell_pou
            // 
            this.button_sell_pou.Location = new System.Drawing.Point(65, 39);
            this.button_sell_pou.Name = "button_sell_pou";
            this.button_sell_pou.Size = new System.Drawing.Size(64, 23);
            this.button_sell_pou.TabIndex = 13;
            this.button_sell_pou.Text = "продать";
            this.button_sell_pou.UseVisualStyleBackColor = true;
            this.button_sell_pou.Click += new System.EventHandler(this.button_sell_pou_Click);
            // 
            // button_buy_pou
            // 
            this.button_buy_pou.Location = new System.Drawing.Point(1, 39);
            this.button_buy_pou.Name = "button_buy_pou";
            this.button_buy_pou.Size = new System.Drawing.Size(64, 23);
            this.button_buy_pou.TabIndex = 12;
            this.button_buy_pou.Text = "купить";
            this.button_buy_pou.UseVisualStyleBackColor = true;
            this.button_buy_pou.Click += new System.EventHandler(this.button_buy_pou_Click);
            // 
            // label_pou
            // 
            this.label_pou.AutoSize = true;
            this.label_pou.Location = new System.Drawing.Point(34, 14);
            this.label_pou.Name = "label_pou";
            this.label_pou.Size = new System.Drawing.Size(13, 13);
            this.label_pou.TabIndex = 3;
            this.label_pou.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "£:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button_sell_eur);
            this.panel4.Controls.Add(this.button_buy_eur);
            this.panel4.Controls.Add(this.label_eur);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(154, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 67);
            this.panel4.TabIndex = 12;
            // 
            // button_sell_eur
            // 
            this.button_sell_eur.Location = new System.Drawing.Point(65, 39);
            this.button_sell_eur.Name = "button_sell_eur";
            this.button_sell_eur.Size = new System.Drawing.Size(64, 23);
            this.button_sell_eur.TabIndex = 13;
            this.button_sell_eur.Text = "продать";
            this.button_sell_eur.UseVisualStyleBackColor = true;
            this.button_sell_eur.Click += new System.EventHandler(this.button_sell_eur_Click);
            // 
            // button_buy_eur
            // 
            this.button_buy_eur.Location = new System.Drawing.Point(1, 39);
            this.button_buy_eur.Name = "button_buy_eur";
            this.button_buy_eur.Size = new System.Drawing.Size(64, 23);
            this.button_buy_eur.TabIndex = 12;
            this.button_buy_eur.Text = "купить";
            this.button_buy_eur.UseVisualStyleBackColor = true;
            this.button_buy_eur.Click += new System.EventHandler(this.button_buy_eur_Click);
            // 
            // label_eur
            // 
            this.label_eur.AutoSize = true;
            this.label_eur.Location = new System.Drawing.Point(34, 14);
            this.label_eur.Name = "label_eur";
            this.label_eur.Size = new System.Drawing.Size(13, 13);
            this.label_eur.TabIndex = 3;
            this.label_eur.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "€:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button_sell_doll);
            this.panel3.Controls.Add(this.button_buy_doll);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label_doll);
            this.panel3.Location = new System.Drawing.Point(14, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 67);
            this.panel3.TabIndex = 11;
            // 
            // button_sell_doll
            // 
            this.button_sell_doll.Location = new System.Drawing.Point(65, 39);
            this.button_sell_doll.Name = "button_sell_doll";
            this.button_sell_doll.Size = new System.Drawing.Size(64, 23);
            this.button_sell_doll.TabIndex = 13;
            this.button_sell_doll.Text = "продать";
            this.button_sell_doll.UseVisualStyleBackColor = true;
            this.button_sell_doll.Click += new System.EventHandler(this.button_sell_doll_Click);
            // 
            // button_buy_doll
            // 
            this.button_buy_doll.Location = new System.Drawing.Point(1, 39);
            this.button_buy_doll.Name = "button_buy_doll";
            this.button_buy_doll.Size = new System.Drawing.Size(64, 23);
            this.button_buy_doll.TabIndex = 12;
            this.button_buy_doll.Text = "купить";
            this.button_buy_doll.UseVisualStyleBackColor = true;
            this.button_buy_doll.Click += new System.EventHandler(this.button_buy_doll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "$:";
            // 
            // label_doll
            // 
            this.label_doll.AutoSize = true;
            this.label_doll.Location = new System.Drawing.Point(34, 14);
            this.label_doll.Name = "label_doll";
            this.label_doll.Size = new System.Drawing.Size(13, 13);
            this.label_doll.TabIndex = 3;
            this.label_doll.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ваши валюты:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_bal);
            this.panel2.Controls.Add(this.label_err);
            this.panel2.Controls.Add(this.label_ru);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(592, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 136);
            this.panel2.TabIndex = 0;
            // 
            // button_bal
            // 
            this.button_bal.Cursor = System.Windows.Forms.Cursors.Help;
            this.button_bal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_bal.Location = new System.Drawing.Point(12, 61);
            this.button_bal.Name = "button_bal";
            this.button_bal.Size = new System.Drawing.Size(168, 66);
            this.button_bal.TabIndex = 3;
            this.button_bal.Text = "Пополнить баланс";
            this.button_bal.UseVisualStyleBackColor = true;
            this.button_bal.Click += new System.EventHandler(this.button_bal_Click);
            // 
            // label_err
            // 
            this.label_err.AutoSize = true;
            this.label_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_err.Location = new System.Drawing.Point(9, 35);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(175, 13);
            this.label_err.TabIndex = 2;
            this.label_err.Text = "Недостаточно денег для покупки";
            this.label_err.Visible = false;
            // 
            // label_ru
            // 
            this.label_ru.AutoSize = true;
            this.label_ru.Location = new System.Drawing.Point(80, 13);
            this.label_ru.Name = "label_ru";
            this.label_ru.Size = new System.Drawing.Size(13, 13);
            this.label_ru.TabIndex = 1;
            this.label_ru.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Баланс в ₽:";
            // 
            // chart1
            // 
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.Name = "ChartArea2";
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.Name = "ChartArea3";
            chartArea8.AxisX.Minimum = 0D;
            chartArea8.Name = "ChartArea4";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.ChartAreas.Add(chartArea8);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 136);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Dollar $";
            series6.ChartArea = "ChartArea2";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Euro €";
            series7.ChartArea = "ChartArea3";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Pound £";
            series8.ChartArea = "ChartArea4";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Sheqel ₪";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(784, 325);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Rodionov Investments";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_sell_doll;
        private System.Windows.Forms.Button button_buy_doll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_doll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_ru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_sell_she;
        private System.Windows.Forms.Button button_buy_she;
        private System.Windows.Forms.Label label_she;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_sell_pou;
        private System.Windows.Forms.Button button_buy_pou;
        private System.Windows.Forms.Label label_pou;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_sell_eur;
        private System.Windows.Forms.Button button_buy_eur;
        private System.Windows.Forms.Label label_eur;
        private System.Windows.Forms.Label label_err;
        private System.Windows.Forms.Button button_bal;
    }
}

