using CSharp_WinForms_POS_And_Quotation_System.Models.Db;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_WinForms_POS_And_Quotation_System
{
    public partial class ProductManagementForm_CRUD : Form
    {
        CsharpWinFormsPosAndQuotationSystemDbContext db = new CsharpWinFormsPosAndQuotationSystemDbContext();

        private string theCRUD;
        private int theID;

        public ProductManagementForm_CRUD(string _whichCRUD, int _whichID)
        {
            InitializeComponent();
            this.MinimumSize = new Size(550, 550);
            this.Size = new Size(650, 550);

            this.PM_CRUD_ProductCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.theCRUD = _whichCRUD;
            this.theID = _whichID;
        }

        ///////////////////////////////////////// FORM LOAD /////////////////////////////////////////////////////////////
        private void ProductManagementForm_CRUD_Load(object sender, EventArgs e)
        {
            center.isExecuted = false;

            switch (theCRUD)
            {
                case "ADD": prepareADD(); break;
                case "EDIT": prepareEDIT(); break;
                case "DELETE": prepareDELETE(); break;
            }
        }
        private void prepareADD() //Prepare ADD
        {
            PM_CRUD_HeadingLabel.Text = "เพิ่มสินค้า";
            PM_CRUD_SaveButton.Text = "บันทึก";
            PM_CRUD_SaveButton.ForeColor = Color.DarkGreen;

            PM_CRUD_ProductIdNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductBarcodeTextBox.ReadOnly = true; //X
            PM_CRUD_ProductNameTextBox.ReadOnly = false; //O
            PM_CRUD_ProductQuantityNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductCostPriceNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductSellingPriceNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductUnitNameTextBox.ReadOnly = false; //O
            PM_CRUD_EditCategoryLinkLabel.Enabled = true; //O
            PM_CRUD_ChoosePictureLinkLabel.Enabled = true; //O
            PM_CRUD_DeletePictureLinkLabel.Enabled = true; //O
            PM_CRUD_PictureDescriptionLabel.Enabled = true; //O
            PM_CRUD_ProductNameTextBox.Focus();

            //PM_CRUD_ProductBarcodeTextBox.Text = TODO
        }
        private void prepareEDIT() //Prepare EDIT
        {
            PM_CRUD_HeadingLabel.Text = "แก้ไขสินค้า";
            PM_CRUD_SaveButton.Text = "บันทึก";
            PM_CRUD_SaveButton.ForeColor = Color.DarkBlue;

            PM_CRUD_ProductIdNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductBarcodeTextBox.ReadOnly = true; //X
            PM_CRUD_ProductNameTextBox.ReadOnly = false; //O
            PM_CRUD_ProductQuantityNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductCostPriceNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductSellingPriceNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductUnitNameTextBox.ReadOnly = false; //O
            PM_CRUD_EditCategoryLinkLabel.Enabled = true; //O
            PM_CRUD_ChoosePictureLinkLabel.Enabled = true; //O
            PM_CRUD_DeletePictureLinkLabel.Enabled = true; //O
            PM_CRUD_PictureDescriptionLabel.Enabled = true; //O
            PM_CRUD_ProductNameTextBox.Focus();



            var data = (from c in db.Products where c.Id == theID select c).FirstOrDefault();
            var cat = from m in db.ProductCategories select new { m.Id, m.Name };
            if (data != null && cat != null)
            {
                //Barcode, Name, Quantity, CostPrice, SellingPrice, UnitName show value
                PM_CRUD_ProductIdNumericUpDown.Value = theID;

                PM_CRUD_ProductBarcodeTextBox.Text = data.Barcode;
                PM_CRUD_ProductNameTextBox.Text = data.Name;
                PM_CRUD_ProductQuantityNumericUpDown.Value = data.Quantity;
                PM_CRUD_ProductCostPriceNumericUpDown.Value = data.CostPrice;
                PM_CRUD_ProductSellingPriceNumericUpDown.Value = data.SellingPrice;
                PM_CRUD_ProductUnitNameTextBox.Text = data.UnitName;

                //Category show value
                PM_CRUD_ProductCategoryComboBox.Items.AddRange(cat.ToArray());
                PM_CRUD_ProductCategoryComboBox.ValueMember = "Id";
                PM_CRUD_ProductCategoryComboBox.DisplayMember = "Name";

                //Select current category
                foreach (dynamic item in PM_CRUD_ProductCategoryComboBox.Items)
                {
                    if (item.Id == data.Category)
                    {
                        PM_CRUD_ProductCategoryComboBox.SelectedIndex = PM_CRUD_ProductCategoryComboBox.Items.IndexOf(item);
                        break;
                    }
                }
            }
        }
        private void prepareDELETE() //Prepare DELETE
        {
            PM_CRUD_HeadingLabel.Text = "ลบสินค้า";
            PM_CRUD_SaveButton.Text = "ลบ";
            PM_CRUD_SaveButton.ForeColor = Color.DarkRed;

            PM_CRUD_ProductIdNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductBarcodeTextBox.ReadOnly = true; //X
            PM_CRUD_ProductNameTextBox.ReadOnly = true; //X
            PM_CRUD_ProductQuantityNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductCostPriceNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductSellingPriceNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductUnitNameTextBox.ReadOnly = true; //X
            PM_CRUD_EditCategoryLinkLabel.Enabled = false; //X
            PM_CRUD_ChoosePictureLinkLabel.Enabled = false; //X
            PM_CRUD_DeletePictureLinkLabel.Enabled = false; //X
            PM_CRUD_PictureDescriptionLabel.Enabled = false; //X

            PM_CRUD_SaveButton.Focus();

            //Id, Barcode, Name, Quantity, CostPrice, SellingPrice, UnitName, Category show value
            PM_CRUD_ProductIdNumericUpDown.Value = theID;

            var data = (from p in db.Products
                        join c in db.ProductCategories on p.Category equals c.Id
                        where p.Id == theID
                        select new
                        {
                            Pro = p,
                            Cat = c
                        }).FirstOrDefault();

            if (data != null)
            {
                PM_CRUD_ProductBarcodeTextBox.Text = data.Pro.Barcode;
                PM_CRUD_ProductNameTextBox.Text = data.Pro.Name;
                PM_CRUD_ProductQuantityNumericUpDown.Value = data.Pro.Quantity;
                PM_CRUD_ProductCostPriceNumericUpDown.Value = data.Pro.CostPrice;
                PM_CRUD_ProductSellingPriceNumericUpDown.Value = data.Pro.SellingPrice;
                PM_CRUD_ProductUnitNameTextBox.Text = data.Pro.UnitName;
                PM_CRUD_ProductCategoryComboBox.Items.Insert(0, data.Cat.Name);
                PM_CRUD_ProductCategoryComboBox.SelectedIndex = 0;
            }

            PM_CRUD_ProductQuantityNumericUpDown.Minimum = data.Pro.Quantity;
            PM_CRUD_ProductQuantityNumericUpDown.Maximum = data.Pro.Quantity;
        }
    }
}
