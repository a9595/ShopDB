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
using System.Xml;

namespace MyFirma
{

    public partial class MainForm : Form
    {
        static public List<Product> ProductsList = new List<Product>();
        public MainForm()
        {
            InitializeComponent();
            comboBoxGroup.SelectedIndex = 0; // ставим категорію по змовчанню шоб не було пустой
            LoadStandartBase(); 
        }



        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            form.ShowDialog();
            comboBoxGroup.SelectedIndex = 0;
        }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ProductsList[0].Name);
            AddProductToXML(ProductsList);
        }

        public void AddProductToXML(List<Product> products)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("ProdList");
            doc.CreateXmlDeclaration("1.0", "UTF-8", "no");
            doc.AppendChild(root);


            for (int i = 0; i < products.Count; i++)
            {
                XmlNode addedProd = doc.CreateElement("product");
                XmlNode name = doc.CreateElement("name");
                XmlNode category = doc.CreateElement("category");
                XmlNode description = doc.CreateElement("description");
                XmlNode price = doc.CreateElement("price");
                XmlNode imagePath = doc.CreateElement("imagePath");
                XmlNode availabled = doc.CreateElement("availabled");

                name.InnerText = products[i].Name;
                category.InnerText = products[i].Category;
                description.InnerText = products[i].Description;
                price.InnerText = products[i].Price.ToString(CultureInfo.InvariantCulture);
                imagePath.InnerText = products[i].Image_path;
                availabled.InnerText = products[i].StrAvailabled;


                addedProd.AppendChild(name);
                addedProd.AppendChild(category);
                addedProd.AppendChild(description);
                addedProd.AppendChild(price);
                addedProd.AppendChild(imagePath);
                addedProd.AppendChild(availabled);


                if (doc.DocumentElement != null) doc.DocumentElement.AppendChild(addedProd);
            }

            string pathOfSavedXML = "../../TEST2.xml";
            if (saveXML.ShowDialog() == DialogResult.OK)
                pathOfSavedXML = saveXML.FileName;
            doc.Save(pathOfSavedXML);
        }

        /// <summary>
        /// заповнення бази стандартними 
        /// </summary>
//        public void FillStandartProducts()
//        {
//            ProductsList.Add(new Product("Palit GeForce GT440",
//                "Відеокарти", @"Тип интерфейса:PCI-Express
//Видеопроцессор:GeForce 4х серия
//Охлаждение:Активное (кулер)
//Объем:1024
//Тип:GDDR5", "561", "../../images/palit_geforce_gt440.jpg", "YES"));

//            ProductsList.Add(new Product("Sapphire Radeon HD6670", "Відеокарти", @"Тип интерфейса:PCI-Express
//Видеопроцессор:Radeon HD 6х серия
//Охлаждение:Активное (кулер)
//Объем:1024
//Тип:GDDR5", "635", "../../images/sapphire_radeon_hd6670.jpg", "NO"));

//            ProductsList.Add(new Product("Intel Core i5-3570K", "Процессори", @"Socket:LGA1155
//Частота процессора:3400
//Количество ядер:4
//L2:1024 Кб", "1927", "../../images/intel_core_i5.jpg", "PreOrder"));

//            ProductsList.Add(new Product("Transcend JM800QSU-2G", "Оперативна память", @"Назначение:для ноутбуков
//Тип:DDR2
//Объем:2 Гб
//Количество модулей:1 модуль", "196", "../../images/transcend_jm800qsu-2g.jpg", "YES"));
            

//        }


        private void CategoryChanged(object sender, EventArgs e)
        {
            listBoxProducts.Items.Clear();
            foreach (var product in ProductsList)
            {
                if (product.Category == comboBoxGroup.SelectedItem.ToString())
                    listBoxProducts.Items.Add(product.Name);
            }
        }
        public void RefreshProductList()//обновлення списку
        {
            listBoxProducts.Items.Clear();
            foreach (var product in ProductsList)
            {
                if (product.Category == comboBoxGroup.SelectedItem.ToString() && comboBoxGroup.SelectedItem != null)
                    listBoxProducts.Items.Add(product.Name);
            }
        }
        private void ProductSelectionChanged(object sender, EventArgs e)
        {
            textBoxDescription.Clear();

            if (listBoxProducts.SelectedItem == null) return; //шоб не вилітало, коли клікаєш по пустому місці в лістБоксі

            string selectedProductName = listBoxProducts.SelectedItem.ToString();
            foreach (var product in ProductsList)
            {
                if (product.Name == selectedProductName)
                {
                    textBoxDescription.Text = product.Description;
                    labelPriceGRN.Text = product.Price.ToString(CultureInfo.InvariantCulture) + " грн.";
                    labelPriceDollars.Text = (product.Price * AddProductForm.USDinGRN).ToString(CultureInfo.InvariantCulture) + " $";
                    if (product.Image_path == "noimage")
                        pictureBox1.Image = Properties.Resources.noimage;
                    else pictureBox1.ImageLocation = product.Image_path;

                    //pictureBox1.ImageLocation = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)) + "\\images\\nophoto.gif";
                    if (product.Available)
                    {
                        labelAvailable.ForeColor = Color.Green;
                        labelAvailable.Text = "В наявності";
                    }
                    else if (product.PreOrder)
                    {
                        labelAvailable.ForeColor = Color.Red;
                        labelAvailable.Text = "Під замовлення";
                    }
                    else
                    {
                        labelAvailable.ForeColor = Color.Gray;
                        labelAvailable.Text = "Відсутній";
                    }
                }
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex != -1)
            {
                if (MessageBox.Show("Ви дійсно хочете видалити" + listBoxProducts.SelectedItem.ToString() + " ?", "Видалити",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int index = 0; index < ProductsList.Count; index++)
                    {
                        var product = ProductsList[index];
                        if(listBoxProducts.SelectedItem != null)
                        if (listBoxProducts.SelectedItem.ToString() == product.Name)
                        {
                            ProductsList.RemoveAt(index);
                            pictureBox1.Image = Properties.Resources.noimage;
                            labelAvailable.ResetText();
                            labelPriceGRN.ResetText();
                            labelPriceDollars.ResetText();
                            textBoxDescription.Clear();
                            RefreshProductList();
                        }
                    }
                }
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex != -1)
            {
                AddProductForm form = new AddProductForm(listBoxProducts.SelectedItem.ToString());
                form.ShowDialog();
                RefreshProductList();
            }
        }

        private void buttonLoadBase_Click(object sender, EventArgs e)
        {
            openBase.ShowDialog();
            if (MessageBox.Show("Да - очистити \n Нет - обєднати з завантаженною базою?",
                "Очистити попередню базу?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ProductsList.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load(openBase.FileName);
            if (doc.HasChildNodes)
            {
                foreach (XmlNode product in doc.DocumentElement)
                {
                    string[] productNodes = new string[6];
                    int i = 0;
                    foreach (XmlNode property in product.ChildNodes)
                        productNodes[i++] = property.InnerText;

                    bool available = productNodes[5] == "YES",
                         unavailable = productNodes[5] == "NO",
                         preOrder = productNodes[5] == "PreOrder";
                    ProductsList.Add(new Product(productNodes[0], productNodes[1], productNodes[2], productNodes[3],
                           productNodes[4], available, unavailable, preOrder));
                }
            }
            RefreshProductList();
        }
        public void LoadStandartBase()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../base.xml");
            if (doc.HasChildNodes)
            {
                foreach (XmlNode product in doc.DocumentElement)
                {
                    string[] productNodes = new string[6];
                    int i = 0;
                    foreach (XmlNode property in product.ChildNodes)
                        productNodes[i++] = property.InnerText;

                    bool available = productNodes[5] == "YES",
                         unavailable = productNodes[5] == "NO",
                         preOrder = productNodes[5] == "PreOrder";
                    ProductsList.Add(new Product(productNodes[0], productNodes[1], productNodes[2], productNodes[3],
                           productNodes[4], available, unavailable, preOrder));
                }
            }
            RefreshProductList();
        }
    }
}
