namespace Bai_5_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblPaymentValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lstAvailableServices = new System.Windows.Forms.ListBox();
            this.lstSelectedServices = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblPaymentValue = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                16F,
                System.Drawing.FontStyle.Bold
            );
            this.lblTitle.Location = new System.Drawing.Point(210, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 30);
            this.lblTitle.Text = "BẢNG TÍNH TIỀN DỊCH VỤ";

            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(45, 75);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(75, 15);
            this.lblCategory.Text = "Loại dịch vụ:";

            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[]
            {
                "Khám bệnh",
                "Xét nghiệm",
                "Chụp X-Quang",
                "Vắc-xin"
            });
            this.cboCategory.Location = new System.Drawing.Point(140, 70);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(220, 23);

            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblAvailable.Location = new System.Drawing.Point(45, 120);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(101, 15);
            this.lblAvailable.Text = "Dịch vụ có sẵn:";

            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblSelected.Location = new System.Drawing.Point(400, 120);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(103, 15);
            this.lblSelected.Text = "Dịch vụ đã chọn:";

            // 
            // lstAvailableServices
            // 
            this.lstAvailableServices.FormattingEnabled = true;
            this.lstAvailableServices.ItemHeight = 15;
            this.lstAvailableServices.Location = new System.Drawing.Point(45, 145);
            this.lstAvailableServices.Name = "lstAvailableServices";
            this.lstAvailableServices.Size = new System.Drawing.Size(270, 154);

            // 
            // lstSelectedServices
            // 
            this.lstSelectedServices.FormattingEnabled = true;
            this.lstSelectedServices.ItemHeight = 15;
            this.lstSelectedServices.Location = new System.Drawing.Point(400, 145);
            this.lstSelectedServices.Name = "lstSelectedServices";
            this.lstSelectedServices.Size = new System.Drawing.Size(270, 154);

            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(335, 150);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(40, 35);
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;

            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(335, 195);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(40, 35);
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;

            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(335, 240);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(40, 35);
            this.btnClearAll.Text = "<<";
            this.btnClearAll.UseVisualStyleBackColor = true;

            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(45, 335);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 15);
            this.lblTotal.Text = "Tổng tiền chưa giảm:";

            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(230, 335);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(48, 15);
            this.lblTotalValue.Text = "0 VNĐ";

            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(45, 370);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(145, 15);
            this.lblDiscount.Text = "Tỷ lệ chiết khấu (%):";

            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.AutoSize = true;
            this.lblDiscountValue.Location = new System.Drawing.Point(230, 370);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(24, 15);
            this.lblDiscountValue.Text = "0%";

            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblPayment.Location = new System.Drawing.Point(45, 405);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(145, 15);
            this.lblPayment.Text = "Thành tiền thanh toán:";

            // 
            // lblPaymentValue
            // 
            this.lblPaymentValue.AutoSize = true;
            this.lblPaymentValue.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblPaymentValue.Location = new System.Drawing.Point(230, 405);
            this.lblPaymentValue.Name = "lblPaymentValue";
            this.lblPaymentValue.Size = new System.Drawing.Size(48, 15);
            this.lblPaymentValue.Text = "0 VNĐ";

            // 
            // Form1
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize =
                new System.Drawing.Size(720, 460);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lstAvailableServices);
            this.Controls.Add(this.lstSelectedServices);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblDiscountValue);
            this.Controls.Add(this.lblPaymentValue);

            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng tính tiền dịch vụ";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}