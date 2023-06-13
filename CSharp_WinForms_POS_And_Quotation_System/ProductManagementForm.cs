﻿using CSharp_WinForms_POS_And_Quotation_System.Models.Db;
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
    public partial class ProductManagementForm : Form
    {
        CsharpWinFormsPosAndQuotationSystemDbContext db = new CsharpWinFormsPosAndQuotationSystemDbContext();
        public ProductManagementForm()
        {
            InitializeComponent();

            this.MinimumSize = new Size(1000, 1000);
            this.Size = new Size(1180, 1250);

            this.PM_DataGridView.ReadOnly = true;
            this.PM_DataGridView.MultiSelect = false;
            this.PM_DataGridView.AllowUserToAddRows = false;
            this.PM_DataGridView.AllowUserToDeleteRows = false;
            this.PM_DataGridView.AllowUserToResizeRows = false;
            this.PM_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.PM_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.PM_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PM_DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10f, FontStyle.Bold);
            this.PM_DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            this.PM_DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.PM_DataGridView.EnableHeadersVisualStyles = false;


            this.PM_DataGridView.DefaultCellStyle.Font = new Font("Tahoma", 10f, FontStyle.Regular);
            this.PM_DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.PM_DataGridView.ClearSelection();

            this.PM_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (DataGridViewColumn column in this.PM_DataGridView.Columns)
            {
                column.Width += 50;
            }

        }

        ///////////////////////////////////////// LOAD /////////////////////////////////////////////////////////////
        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            loadCategory();
            loadData("", 0);
        }

        ///////////////////////////////////////// LOAD DATA /////////////////////////////////////////////////////////
        private void loadData(string keyword, int cat)
        {
            PM_DataGridView.DataSource = null;

            //Add data to DataGridview
            var data = from i in db.Products
                       join r in db.ProductCategories on i.Category equals r.Id
                       where (i.Barcode.Contains(keyword) || i.Name.Contains(keyword)) && (cat == 0 ? true : i.Category == cat)
                       select new
                       {
                           //ที่ = TODO
                           //รูปภาพ = TODO
                           รหัสสินค้า = i.Barcode,
                           ชื่อสินค้า = i.Name,
                           ราคาทุน = i.CostPrice,
                           ราคาขาย = i.SellingPrice,
                           จำนวน = i.Quantity,
                           หน่วยนับ = i.UnitName,
                           ประเภทสินค้า = r.Name
                       };
            if (data != null)
            {
                PM_DataGridView.DataSource = data.ToList();
            }
            else
            {
                PM_DataGridView.DataSource = null;
            }
        }

        ///////////////////////////////////////// LOAD CATEGORY /////////////////////////////////////////////////////////
        private void loadCategory()
        {
            PM_ComboBox.Items.Clear();

            // Add ProductCategory to ComboBox
            var data = from m in db.ProductCategories
                       select new { m.Id, m.Name };

            PM_ComboBox.Items.Add(new { Id = 0, Name = "-ทั้งหมด-" }); // Add Id = 0, Name = "ทั้งหมด" item
            PM_ComboBox.Items.AddRange(data.ToArray());
            PM_ComboBox.ValueMember = "Id";
            PM_ComboBox.DisplayMember = "Name";
            PM_ComboBox.SelectedIndex = 0; // Set the selected index to 0 (the first item)
        }

        ///////////////////////////////////////// SEARCH /////////////////////////////////////////////////////////
        private void PM_SearchButton_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void PM_SearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                searchData();
            }
        }

        private void searchData()
        {
            string keyword = PM_SearchTextBox.Text.Trim() == null ? "" : PM_SearchTextBox.Text.Trim();

            dynamic selectedCat = PM_ComboBox.SelectedItem;
            int catValue = Convert.ToInt32(selectedCat.Id);

            loadData(keyword, catValue);
        }

        /////////////////////////////////////// REFRESH BUTTON ///////////////////////////////////////////////////////
        private void PM_RefreshButton_Click(object sender, EventArgs e)
        {
            PM_SearchTextBox.Clear();
            loadCategory();
            loadData("", 0);      
        }
    }
}