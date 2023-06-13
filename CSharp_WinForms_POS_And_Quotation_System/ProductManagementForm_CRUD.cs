using CSharp_WinForms_POS_And_Quotation_System.Models.Db;
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
            PM_CRUD_ProductIdNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductBarcodeTextBox.ReadOnly = true; //X
            PM_CRUD_ProductNameTextBox.ReadOnly = false; //O
            PM_CRUD_ProductQuantityNumericUpDown.ReadOnly = false; //O
            PM_CRUD_ProductCostPriceNumericUpDown.ReadOnly = false; //O
            PM_CRUD_ProductSellingPriceNumericUpDown.ReadOnly = false; //O
            PM_CRUD_ProductUnitNameTextBox.ReadOnly = false; //O
            PM_CRUD_ChoosePictureLinkLabel.Enabled = true; //O
            PM_CRUD_DeletePictureLinkLabel.Enabled = true; //O
            PM_CRUD_ProductNameTextBox.Focus();

            //PM_CRUD_ProductBarcodeTextBox.Text = TODO
        }
        private void prepareEDIT() //Prepare EDIT
        {
            PM_CRUD_HeadingLabel.Text = "แก้ไขสินค้า";
            PM_CRUD_SaveButton.Text = "บันทึก";
            PM_CRUD_ProductIdNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductBarcodeTextBox.ReadOnly = true; //X
            PM_CRUD_ProductNameTextBox.ReadOnly = false; //O
            PM_CRUD_ProductQuantityNumericUpDown.ReadOnly = false; //O
            PM_CRUD_ProductCostPriceNumericUpDown.ReadOnly = false; //O
            PM_CRUD_ProductSellingPriceNumericUpDown.ReadOnly = false; //O
            PM_CRUD_ProductUnitNameTextBox.ReadOnly = false; //O
            PM_CRUD_ChoosePictureLinkLabel.Enabled = true; //O
            PM_CRUD_DeletePictureLinkLabel.Enabled = true; //O
            PM_CRUD_ProductNameTextBox.Focus();

            PM_CRUD_ProductIdNumericUpDown.Value = theID;

            var data = (from c in db.Products where c.Id == theID select c).FirstOrDefault();
            var cat = from m in db.ProductCategories select new { m.Id, m.Name };
            if (data != null && cat != null)
            {
                //Barcode, Name, Quantity, CostPrice, SellingPrice, UnitName show value
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

                for (int i = 0; i < PM_CRUD_ProductCategoryComboBox.Items.Count; i++)
                {
                    dynamic item = PM_CRUD_ProductCategoryComboBox.Items[i];
                    if (item.Id == data.Category)
                    {
                        PM_CRUD_ProductCategoryComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
        private void prepareDELETE() //Prepare DELETE
        {
            PM_CRUD_HeadingLabel.Text = "ลบสินค้า";
            PM_CRUD_SaveButton.Text = "ลบ";
            PM_CRUD_ProductIdNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductBarcodeTextBox.ReadOnly = true; //X
            PM_CRUD_ProductNameTextBox.ReadOnly = true; //X
            PM_CRUD_ProductQuantityNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductCostPriceNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductSellingPriceNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductUnitNameTextBox.ReadOnly = true; //X
            PM_CRUD_ChoosePictureLinkLabel.Enabled = false; //X
            PM_CRUD_DeletePictureLinkLabel.Enabled = false; //X
            PM_CRUD_SaveButton.Focus();

            PM_CRUD_ProductIdNumericUpDown.Value = theID;
        }
    }
}
