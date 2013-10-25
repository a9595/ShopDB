namespace MyFirma
{
    partial class MainForm
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
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonSaveProduct = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.labelPriceGRN = new System.Windows.Forms.Label();
            this.labelPriceDollars = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.saveXML = new System.Windows.Forms.SaveFileDialog();
            this.buttonLoadBase = new System.Windows.Forms.Button();
            this.openBase = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Items.AddRange(new object[] {
            "Процессори",
            "Оперативна память",
            "Жорсткі диски",
            "Відеокарти",
            "Інше"});
            this.comboBoxGroup.Location = new System.Drawing.Point(103, 12);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(182, 21);
            this.comboBoxGroup.TabIndex = 0;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.CategoryChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Група товару:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Комплектуючі:";
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(15, 85);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(270, 238);
            this.listBoxProducts.TabIndex = 2;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.ProductSelectionChanged);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(15, 330);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(110, 23);
            this.buttonAddProduct.TabIndex = 3;
            this.buttonAddProduct.Text = "Додати товар";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(146, 329);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(110, 23);
            this.buttonDeleteProduct.TabIndex = 3;
            this.buttonDeleteProduct.Text = "Видалити товар";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(15, 359);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(110, 23);
            this.buttonEditProduct.TabIndex = 3;
            this.buttonEditProduct.Text = "Редагувати товар";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonSaveProduct
            // 
            this.buttonSaveProduct.Location = new System.Drawing.Point(146, 358);
            this.buttonSaveProduct.Name = "buttonSaveProduct";
            this.buttonSaveProduct.Size = new System.Drawing.Size(110, 23);
            this.buttonSaveProduct.TabIndex = 3;
            this.buttonSaveProduct.Text = "Зберегти базу";
            this.buttonSaveProduct.UseVisualStyleBackColor = true;
            this.buttonSaveProduct.Click += new System.EventHandler(this.buttonSaveProduct_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(327, 199);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(36, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Опис:";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvailable.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelAvailable.Location = new System.Drawing.Point(518, 15);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(0, 20);
            this.labelAvailable.TabIndex = 1;
            // 
            // labelPriceGRN
            // 
            this.labelPriceGRN.AutoSize = true;
            this.labelPriceGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceGRN.ForeColor = System.Drawing.Color.Green;
            this.labelPriceGRN.Location = new System.Drawing.Point(517, 57);
            this.labelPriceGRN.Name = "labelPriceGRN";
            this.labelPriceGRN.Size = new System.Drawing.Size(0, 25);
            this.labelPriceGRN.TabIndex = 1;
            // 
            // labelPriceDollars
            // 
            this.labelPriceDollars.AutoSize = true;
            this.labelPriceDollars.Location = new System.Drawing.Point(534, 106);
            this.labelPriceDollars.Name = "labelPriceDollars";
            this.labelPriceDollars.Size = new System.Drawing.Size(0, 13);
            this.labelPriceDollars.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::MyFirma.Properties.Resources.noimage;
            this.pictureBox1.Location = new System.Drawing.Point(330, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(330, 215);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(359, 108);
            this.textBoxDescription.TabIndex = 5;
            // 
            // saveXML
            // 
            this.saveXML.Filter = " XML Files(*.xml)|*.xml";
            this.saveXML.RestoreDirectory = true;
            this.saveXML.Title = "XML save";
            // 
            // buttonLoadBase
            // 
            this.buttonLoadBase.Location = new System.Drawing.Point(330, 330);
            this.buttonLoadBase.Name = "buttonLoadBase";
            this.buttonLoadBase.Size = new System.Drawing.Size(133, 52);
            this.buttonLoadBase.TabIndex = 6;
            this.buttonLoadBase.Text = "Завантижити базу з файла";
            this.buttonLoadBase.UseVisualStyleBackColor = true;
            this.buttonLoadBase.Click += new System.EventHandler(this.buttonLoadBase_Click);
            // 
            // openBase
            // 
            this.openBase.DefaultExt = "xml";
            this.openBase.Filter = " XML Files(*.xml)|*.xml";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 392);
            this.Controls.Add(this.buttonLoadBase);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonSaveProduct);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.labelPriceDollars);
            this.Controls.Add(this.labelPriceGRN);
            this.Controls.Add(this.labelAvailable);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonSaveProduct;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.Label labelPriceGRN;
        private System.Windows.Forms.Label labelPriceDollars;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.SaveFileDialog saveXML;
        public System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Button buttonLoadBase;
        private System.Windows.Forms.OpenFileDialog openBase;

    }
}

