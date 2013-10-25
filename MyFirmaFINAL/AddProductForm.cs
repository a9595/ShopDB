using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFirma
{
    public partial class AddProductForm : Form
    {
        public const double USDinGRN = 0.12; //курс грн в доларах
        public bool isEditingMode = false; //перевірка чи запускати вікно в режимі редагування чи додавання товару
        public int indexOfEditedProduct = -1;
        public AddProductForm()
        {
            InitializeComponent();
            comboBoxGroup.SelectedIndex = 0; // ставим категорію по змовчанню шоб не було пустой
            isEditingMode = false;
        }
        public AddProductForm(string ProductName)
        {
            InitializeComponent();
            comboBoxGroup.SelectedIndex = 0; // ставим категорію по змовчанню шоб не було пустой
            isEditingMode = true; // ставим вікно в режим редагування продукту
            for (int index = 0; index < MainForm.ProductsList.Count; index++)
            {
                var product = MainForm.ProductsList[index];
                if (product.Name == ProductName)
                {
                    indexOfEditedProduct = index;
                    textBoxProductName.Text = product.Name;
                    comboBoxGroup.SelectedItem = product.Category;
                    textBoxPrice.Text = product.Price.ToString(CultureInfo.InvariantCulture);
                    textBoxDescription.Text = product.Description;
                    pictureBox1.ImageLocation = product.Image_path;
                    radioButton1.Checked = product.Available;
                    radioButton2.Checked = product.Unavailable;
                    radioButton3.Checked = product.PreOrder;
                }
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

            double price = 0;
            if (textBoxPrice.Text == "")
            {
                textBoxPrice.Text = "0";
                //textBoxPrice.SelectionStart = 1;
            }

            else if (!double.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Введіть будь-ласка коректну ціну");
                textBoxPrice.Clear();
            }

            textBoxPriceInDollars.Text = (price * USDinGRN).ToString(CultureInfo.InvariantCulture);
        }


        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool isEmpty = textBoxProductName.Text == "" || textBoxPrice.Text == "" || textBoxDescription.Text == "";
            if (isEmpty)
            {
                MessageBox.Show("Заповніть будь-ласка всі пусті поля");
                return;
            }
            if (pictureBox1.ImageLocation == null)
            {
                pictureBox1.Image = Properties.Resources.noimage;
                pictureBox1.ImageLocation = "noimage";
            }

            if (!isEditingMode)
                MainForm.ProductsList.Add(new Product(textBoxProductName.Text, comboBoxGroup.Text, textBoxDescription.Text,
                 textBoxPrice.Text, pictureBox1.ImageLocation, radioButton1.Checked, radioButton2.Checked, radioButton3.Checked));

            else if (isEditingMode && MainForm.ProductsList.Count > indexOfEditedProduct)
            {
                MainForm.ProductsList.RemoveAt(indexOfEditedProduct);//удаляєм редагуємий товар
                MainForm.ProductsList.Add(new Product(textBoxProductName.Text, comboBoxGroup.Text, textBoxDescription.Text,
                textBoxPrice.Text, pictureBox1.ImageLocation, radioButton1.Checked,
                radioButton2.Checked, radioButton3.Checked)); //додаєм новий продукт - "тіпа відредактували" =)
            }
            Close();
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете вийти?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }


    }
}