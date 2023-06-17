using CSharp_WinForms_POS_And_Quotation_System.Models.Db;
using Microsoft.IdentityModel.Tokens;
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
using System.Xml;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Collections;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        private void prepareADD() //PREPARE ADD
        {
            PM_CRUD_HeadingLabel.Text = "เพิ่มสินค้า";
            PM_CRUD_SaveButton.Text = "บันทึก";
            PM_CRUD_SaveButton.ForeColor = Color.DarkGreen;

            PM_CRUD_ProductIdNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductBarcodeTextBox.ReadOnly = true; //X
            PM_CRUD_ProductNameTextBox.ReadOnly = false; //O
            PM_CRUD_ProductCostPriceNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductSellingPriceNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductQuantityNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductUnitNameTextBox.ReadOnly = false; //O
            PM_CRUD_EditCategoryLinkLabel.Enabled = true; //O
            PM_CRUD_ChoosePictureLinkLabel.Enabled = true; //O
            PM_CRUD_DeletePictureLinkLabel.Enabled = true; //O
            PM_CRUD_PictureDescriptionLabel.Enabled = true; //O
            PM_CRUD_SaveButton.Select();

            var cat = from m in db.ProductCategories select new { m.Id, m.Name };
            if (cat != null)
            {
                //Category show value
                PM_CRUD_ProductCategoryComboBox.Items.AddRange(cat.ToArray());
                PM_CRUD_ProductCategoryComboBox.ValueMember = "Id";
                PM_CRUD_ProductCategoryComboBox.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show("ไม่สามารถเข้าถึงฐานข้อมูลได้", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //PM_CRUD_ProductIdNumericUpDown.Value = Primary key Generate Auto
            PM_CRUD_ProductBarcodeTextBox.Text = "*สร้างอัตโนมัติ";
        }
        private void prepareEDIT() //PREPARE EDIT
        {
            PM_CRUD_HeadingLabel.Text = "แก้ไขสินค้า";
            PM_CRUD_SaveButton.Text = "บันทึก";
            PM_CRUD_SaveButton.ForeColor = Color.DarkBlue;

            PM_CRUD_ProductIdNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductBarcodeTextBox.ReadOnly = true; //X
            PM_CRUD_ProductNameTextBox.ReadOnly = false; //O
            PM_CRUD_ProductCostPriceNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductSellingPriceNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductQuantityNumericUpDown.Enabled = true; //O
            PM_CRUD_ProductUnitNameTextBox.ReadOnly = false; //O
            PM_CRUD_EditCategoryLinkLabel.Enabled = true; //O
            PM_CRUD_ChoosePictureLinkLabel.Enabled = true; //O
            PM_CRUD_DeletePictureLinkLabel.Enabled = true; //O
            PM_CRUD_PictureDescriptionLabel.Enabled = true; //O
            PM_CRUD_SaveButton.Select();

            var data = (from c in db.Products where c.Id == theID select c).FirstOrDefault();
            var cat = from m in db.ProductCategories select new { m.Id, m.Name };
            if (data != null && cat != null)
            {
                //ID, Barcode, Name, Quantity, CostPrice, SellingPrice, UnitName show value
                PM_CRUD_ProductIdNumericUpDown.Value = theID; //Read only
                PM_CRUD_ProductBarcodeTextBox.Text = data.Barcode; //Read only

                PM_CRUD_ProductNameTextBox.Text = data.Name;
                PM_CRUD_ProductCostPriceNumericUpDown.Value = data.CostPrice;
                PM_CRUD_ProductSellingPriceNumericUpDown.Value = data.SellingPrice;
                PM_CRUD_ProductQuantityNumericUpDown.Value = data.Quantity;
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
            else
            {
                MessageBox.Show("ไม่สามารถเข้าถึงฐานข้อมูลได้", "แก้ไขสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void prepareDELETE() //PREPARE DELETE
        {
            PM_CRUD_HeadingLabel.Text = "ลบสินค้า";
            PM_CRUD_SaveButton.Text = "ลบ";
            PM_CRUD_SaveButton.ForeColor = Color.DarkRed;

            PM_CRUD_ProductIdNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductBarcodeTextBox.ReadOnly = true; //X
            PM_CRUD_ProductNameTextBox.ReadOnly = true; //X
            PM_CRUD_ProductCostPriceNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductSellingPriceNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductQuantityNumericUpDown.ReadOnly = true; //X
            PM_CRUD_ProductUnitNameTextBox.ReadOnly = true; //X
            PM_CRUD_EditCategoryLinkLabel.Enabled = false; //X
            PM_CRUD_ChoosePictureLinkLabel.Enabled = false; //X
            PM_CRUD_DeletePictureLinkLabel.Enabled = false; //X
            PM_CRUD_PictureDescriptionLabel.Enabled = false; //X
            PM_CRUD_SaveButton.Select();


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
                //Id, Barcode, Name, Quantity, CostPrice, SellingPrice, UnitName, Category show value
                PM_CRUD_ProductIdNumericUpDown.Value = theID; //Read only
                PM_CRUD_ProductBarcodeTextBox.Text = data.Pro.Barcode; //Read only

                PM_CRUD_ProductNameTextBox.Text = data.Pro.Name; //Read only
                PM_CRUD_ProductCostPriceNumericUpDown.Value = data.Pro.CostPrice; //Read only
                PM_CRUD_ProductSellingPriceNumericUpDown.Value = data.Pro.SellingPrice; //Read only
                PM_CRUD_ProductQuantityNumericUpDown.Value = data.Pro.Quantity; //Read only
                PM_CRUD_ProductUnitNameTextBox.Text = data.Pro.UnitName; //Read only

                //Category show value
                PM_CRUD_ProductCategoryComboBox.Items.Insert(0, data.Cat.Name); //Read only
                PM_CRUD_ProductCategoryComboBox.SelectedIndex = 0; //Read only

                //Prevent change numericUpDown value
                PM_CRUD_ProductCostPriceNumericUpDown.Minimum = data.Pro.CostPrice; //Disable change
                PM_CRUD_ProductCostPriceNumericUpDown.Maximum = data.Pro.CostPrice; //Disable change

                PM_CRUD_ProductSellingPriceNumericUpDown.Minimum = data.Pro.SellingPrice; //Disable change
                PM_CRUD_ProductSellingPriceNumericUpDown.Maximum = data.Pro.SellingPrice; //Disable change

                PM_CRUD_ProductQuantityNumericUpDown.Minimum = data.Pro.Quantity; //Disable change
                PM_CRUD_ProductQuantityNumericUpDown.Maximum = data.Pro.Quantity; //Disable change
            }
            else
            {
                MessageBox.Show("ไม่สามารถเข้าถึงฐานข้อมูลได้", "ลบสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        ///////////////////////////////////////// EXECUTE BUTTON /////////////////////////////////////////////////////////////
        private void PM_CRUD_SaveButton_Click(object sender, EventArgs e)
        {
            switch (theCRUD)
            {
                case "ADD": executeADD(); break;
                case "EDIT": executeEDIT(); break;
                case "DELETE": executeDELETE(); break;
            }
        }

        private void executeADD() //EXECUTE ADD
        {
            if (string.IsNullOrEmpty(PM_CRUD_ProductNameTextBox.Text))
            {
                MessageBox.Show("โปรดระบุชื่อสินค้า", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (PM_CRUD_ProductCostPriceNumericUpDown.Value == 0)
            {
                MessageBox.Show("โปรดระบุราคาทุน", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (PM_CRUD_ProductSellingPriceNumericUpDown.Value == 0)
            {
                MessageBox.Show("โปรดระบุราคาขาย", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (PM_CRUD_ProductCategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("โปรดเลือกประเภทสินค้า", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string theBarcode = generateBarcode();
                var B = (from b in db.Products
                         where b.Barcode == theBarcode
                         select b).FirstOrDefault();

                if (B == null && theBarcode.Length == 13)
                {
                    try
                    {
                        var tr = db.Database.BeginTransaction();//Transaction control: ADD
                        Product A = new Product();

                        //A.Id = Primary key Generate Auto
                        A.Barcode = theBarcode;
                        A.Name = PM_CRUD_ProductNameTextBox.Text.Trim();
                        A.CostPrice = PM_CRUD_ProductCostPriceNumericUpDown.Value;
                        A.SellingPrice = PM_CRUD_ProductSellingPriceNumericUpDown.Value;
                        A.Quantity = Convert.ToInt32(PM_CRUD_ProductQuantityNumericUpDown.Value);
                        A.UnitName = PM_CRUD_ProductUnitNameTextBox.Text.Trim();

                        dynamic selectedCat = PM_CRUD_ProductCategoryComboBox.SelectedItem;
                        A.Category = Convert.ToInt32(selectedCat.Id);

                        db.Products.Add(A);
                        db.SaveChanges();
                        tr.Commit();

                        center.isExecuted = true;
                        MessageBox.Show("เพิ่มสินค้าสำเร็จ", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }
        private string generateBarcode() // Code-128 หรือ EAN-13
        {
            //Random 12 digit of number
            Random random = new Random();
            long randomID = random.NextInt64(100000000000, 999999999999);
            string randomIDString = Convert.ToString(randomID);

            //Add 13th checking digit by Modulo 10 Algorithm
            int sum = 0;
            int multiplier = 3;
            for (int i = randomIDString.Length - 1; i >= 0; i--)
            {
                int digit = randomIDString[i] - '0';
                sum += digit * multiplier;

                multiplier = (multiplier == 3) ? 1 : 3;
            }
            int remainder = sum % 10;
            int checkDigit = (remainder == 0) ? 0 : 10 - remainder;

            string barcode = (Convert.ToString(randomIDString) + Convert.ToString(checkDigit)).Trim();

            return barcode;
        }

        private void executeEDIT() //EXECUTE EDIT
        {
            if (PM_CRUD_ProductIdNumericUpDown.Value == 0)
            {
                MessageBox.Show("ไม่พบ ID", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(PM_CRUD_ProductBarcodeTextBox.Text))
            {
                MessageBox.Show("ไม่พบรหัสสินค้า", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(PM_CRUD_ProductNameTextBox.Text))
            {
                MessageBox.Show("โปรดระบุชื่อสินค้า", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (PM_CRUD_ProductCostPriceNumericUpDown.Value == 0)
            {
                MessageBox.Show("โปรดระบุราคาทุน", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (PM_CRUD_ProductSellingPriceNumericUpDown.Value == 0)
            {
                MessageBox.Show("โปรดระบุราคาขาย", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (PM_CRUD_ProductCategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("โปรดเลือกประเภทสินค้า", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var E = (from e in db.Products
                         where e.Id == theID
                         select e).FirstOrDefault();

                if (E != null)
                {
                    try
                    {
                        var tr = db.Database.BeginTransaction();//Transaction control: EDIT
                        //E.Id = Stay same
                        //E.Barcode = Stay same
                        E.Name = PM_CRUD_ProductNameTextBox.Text.Trim();
                        E.CostPrice = PM_CRUD_ProductCostPriceNumericUpDown.Value;
                        E.SellingPrice = PM_CRUD_ProductSellingPriceNumericUpDown.Value;
                        E.Quantity = Convert.ToInt32(PM_CRUD_ProductQuantityNumericUpDown.Value);
                        E.UnitName = PM_CRUD_ProductUnitNameTextBox.Text.Trim();

                        dynamic selectedCat = PM_CRUD_ProductCategoryComboBox.SelectedItem;
                        E.Category = Convert.ToInt32(selectedCat.Id);

                        db.SaveChanges();
                        tr.Commit();

                        center.isExecuted = true;
                        MessageBox.Show("แก้ไขสินค้าสำเร็จ", "แก้ไขสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "แก้ไขสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void executeDELETE() //EXECUTE DELETE
        {

        }

        ///////////////////////////////////////// CANCEL BUTTON /////////////////////////////////////////////////////////////
        private void PM_CRUD_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}