namespace btl_uart
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
            this.components = new System.ComponentModel.Container();
            this.btn_check = new System.Windows.Forms.Button();
            this.temHumiHistoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tem = new System.Windows.Forms.Label();
            this.lb_tem_value = new System.Windows.Forms.Label();
            this.lb_humi = new System.Windows.Forms.Label();
            this.lb_humi_value = new System.Windows.Forms.Label();
            this.temHumiHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.temHumiHistoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temHumiHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(146, 161);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 0;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.Btn_check_Click);
            // 
            // temHumiHistoryBindingSource1
            // 
            this.temHumiHistoryBindingSource1.DataSource = typeof(btl_uart.TemHumiHistory);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Temperature and Humidity ";
            // 
            // lb_tem
            // 
            this.lb_tem.AutoSize = true;
            this.lb_tem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tem.Location = new System.Drawing.Point(113, 79);
            this.lb_tem.Name = "lb_tem";
            this.lb_tem.Size = new System.Drawing.Size(89, 16);
            this.lb_tem.TabIndex = 9;
            this.lb_tem.Text = "Temperature:";
            // 
            // lb_tem_value
            // 
            this.lb_tem_value.AutoSize = true;
            this.lb_tem_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tem_value.Location = new System.Drawing.Point(221, 79);
            this.lb_tem_value.Name = "lb_tem_value";
            this.lb_tem_value.Size = new System.Drawing.Size(0, 20);
            this.lb_tem_value.TabIndex = 10;
            // 
            // lb_humi
            // 
            this.lb_humi.AutoSize = true;
            this.lb_humi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_humi.Location = new System.Drawing.Point(139, 113);
            this.lb_humi.Name = "lb_humi";
            this.lb_humi.Size = new System.Drawing.Size(63, 16);
            this.lb_humi.TabIndex = 11;
            this.lb_humi.Text = "Humidity:";
            // 
            // lb_humi_value
            // 
            this.lb_humi_value.AutoSize = true;
            this.lb_humi_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_humi_value.Location = new System.Drawing.Point(221, 113);
            this.lb_humi_value.Name = "lb_humi_value";
            this.lb_humi_value.Size = new System.Drawing.Size(0, 20);
            this.lb_humi_value.TabIndex = 12;
            // 
            // temHumiHistoryBindingSource
            // 
            this.temHumiHistoryBindingSource.DataSource = typeof(btl_uart.TemHumiHistory);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 219);
            this.Controls.Add(this.lb_humi_value);
            this.Controls.Add(this.lb_humi);
            this.Controls.Add(this.lb_tem_value);
            this.Controls.Add(this.lb_tem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temHumiHistoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temHumiHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.BindingSource temHumiHistoryBindingSource;
        private System.Windows.Forms.BindingSource temHumiHistoryBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tem;
        private System.Windows.Forms.Label lb_tem_value;
        private System.Windows.Forms.Label lb_humi;
        private System.Windows.Forms.Label lb_humi_value;
    }
}

