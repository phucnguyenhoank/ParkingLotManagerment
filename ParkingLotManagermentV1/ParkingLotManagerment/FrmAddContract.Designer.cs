namespace ParkingLotManagement
{
    partial class FrmAddContract
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
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMaintenanceContract = new System.Windows.Forms.RadioButton();
            this.rbRentalContract = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpRentalStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRentalEnđate = new System.Windows.Forms.DateTimePicker();
            this.txtRentalDurationInDays = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.cbRenter = new System.Windows.Forms.ComboBox();
            this.txtWarrantyDurationInMonths = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerIDAddContract = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContractID
            // 
            this.txtContractID.Location = new System.Drawing.Point(197, 105);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.Size = new System.Drawing.Size(100, 22);
            this.txtContractID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contract ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rental Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rental End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rental Duration In Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Payment Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMaintenanceContract);
            this.groupBox1.Controls.Add(this.rbRentalContract);
            this.groupBox1.Location = new System.Drawing.Point(156, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of contract";
            // 
            // rbMaintenanceContract
            // 
            this.rbMaintenanceContract.AutoSize = true;
            this.rbMaintenanceContract.Location = new System.Drawing.Point(208, 45);
            this.rbMaintenanceContract.Name = "rbMaintenanceContract";
            this.rbMaintenanceContract.Size = new System.Drawing.Size(157, 20);
            this.rbMaintenanceContract.TabIndex = 1;
            this.rbMaintenanceContract.TabStop = true;
            this.rbMaintenanceContract.Text = "Maintenance Contract";
            this.rbMaintenanceContract.UseVisualStyleBackColor = true;
            // 
            // rbRentalContract
            // 
            this.rbRentalContract.AutoSize = true;
            this.rbRentalContract.Location = new System.Drawing.Point(41, 45);
            this.rbRentalContract.Name = "rbRentalContract";
            this.rbRentalContract.Size = new System.Drawing.Size(119, 20);
            this.rbRentalContract.TabIndex = 0;
            this.rbRentalContract.TabStop = true;
            this.rbRentalContract.Text = "Rental Contract";
            this.rbRentalContract.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 610);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Renter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 610);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Warranty Duration In Months";
            // 
            // dtpRentalStartDate
            // 
            this.dtpRentalStartDate.Location = new System.Drawing.Point(216, 161);
            this.dtpRentalStartDate.Name = "dtpRentalStartDate";
            this.dtpRentalStartDate.Size = new System.Drawing.Size(241, 22);
            this.dtpRentalStartDate.TabIndex = 10;
            // 
            // dtpRentalEnđate
            // 
            this.dtpRentalEnđate.Location = new System.Drawing.Point(216, 204);
            this.dtpRentalEnđate.Name = "dtpRentalEnđate";
            this.dtpRentalEnđate.Size = new System.Drawing.Size(241, 22);
            this.dtpRentalEnđate.TabIndex = 11;
            // 
            // txtRentalDurationInDays
            // 
            this.txtRentalDurationInDays.Location = new System.Drawing.Point(263, 271);
            this.txtRentalDurationInDays.Name = "txtRentalDurationInDays";
            this.txtRentalDurationInDays.Size = new System.Drawing.Size(100, 22);
            this.txtRentalDurationInDays.TabIndex = 12;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(263, 312);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Location = new System.Drawing.Point(239, 351);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(121, 24);
            this.cbPaymentStatus.TabIndex = 14;
            // 
            // cbRenter
            // 
            this.cbRenter.FormattingEnabled = true;
            this.cbRenter.Location = new System.Drawing.Point(105, 641);
            this.cbRenter.Name = "cbRenter";
            this.cbRenter.Size = new System.Drawing.Size(121, 24);
            this.cbRenter.TabIndex = 15;
            // 
            // txtWarrantyDurationInMonths
            // 
            this.txtWarrantyDurationInMonths.Location = new System.Drawing.Point(494, 641);
            this.txtWarrantyDurationInMonths.Name = "txtWarrantyDurationInMonths";
            this.txtWarrantyDurationInMonths.Size = new System.Drawing.Size(100, 22);
            this.txtWarrantyDurationInMonths.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(665, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Customer";
            // 
            // txtCustomerIDAddContract
            // 
            this.txtCustomerIDAddContract.Location = new System.Drawing.Point(763, 90);
            this.txtCustomerIDAddContract.Name = "txtCustomerIDAddContract";
            this.txtCustomerIDAddContract.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerIDAddContract.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(613, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Đây là chỗ của một list các xe của Customer tham gia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(311, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "người dùng sẽ chọn xe tham gia hợp đồng từ list này";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(613, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(310, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Chọn các dịch vụ/công việc mà các xe sẽ được làm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(613, 403);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(404, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Từ các dịch vụ được chọn sẽ sinh ra các chi tiết hợp đồng tương ứng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(87, 555);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(531, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Tùy và giá trị được tick chọn là gì mà các mục tương ứng bên dưới sẽ cho nhập hay" +
    " không";
            // 
            // FrmAddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 850);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCustomerIDAddContract);
            this.Controls.Add(this.txtWarrantyDurationInMonths);
            this.Controls.Add(this.cbRenter);
            this.Controls.Add(this.cbPaymentStatus);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRentalDurationInDays);
            this.Controls.Add(this.dtpRentalEnđate);
            this.Controls.Add(this.dtpRentalStartDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContractID);
            this.Name = "FrmAddContract";
            this.Text = "Add Contract";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMaintenanceContract;
        private System.Windows.Forms.RadioButton rbRentalContract;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpRentalStartDate;
        private System.Windows.Forms.DateTimePicker dtpRentalEnđate;
        private System.Windows.Forms.TextBox txtRentalDurationInDays;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.ComboBox cbRenter;
        private System.Windows.Forms.TextBox txtWarrantyDurationInMonths;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomerIDAddContract;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}