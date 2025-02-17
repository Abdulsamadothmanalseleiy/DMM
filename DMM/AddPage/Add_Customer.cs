﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM.AddPage
{
    public partial class Add_Customer : DevExpress.XtraEditors.XtraForm
    {
        // DataBase and Tables
        DBDMMEntities2 db;
        TB_Customers tbAdd;
       public DMM.Pages.Page_Customer page;
        // other var
        public int id;
        public Add_Customer()
        {
            InitializeComponent();
        }
        

        // Add Function

        private void Add()
        {
            // Check Empty value
            if (edt_name.Text == "")
            {
                MessageBox.Show("بعض الحقول مطلوبة","بعض الحقول مطلوبة",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                // Check if Add or Edit
                if (id == 0)
                {
                    // Add
                    AddData();
                    ClearData();
                }
                else
                {
                    // Edit
                    EditData();
                }

                // Update Data
                page.LoadData();
            }
        }

        // Add Data
        private void AddData()
        {
            try
            {
                db = new DBDMMEntities2();
                tbAdd = new TB_Customers
                {
                    FullName = edt_name.Text,
                    Address = edt_address.Text,
                    Phone = edt_phone.Text,
                    DateT = DateTime.Now,
                    Debit=0
                    
                };
                db.Entry(tbAdd).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("d2186d70-b540-4a5d-ae3e-d7d1d732b6eb");

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Edit Data
        private void EditData()
        {
            try
            {
                db = new DBDMMEntities2();
                tbAdd = new TB_Customers
                {
                    ID=id,
                    FullName = edt_name.Text,
                    Address = edt_address.Text,
                    Phone = edt_phone.Text,
                    DateT = DateTime.Now,
                    

                };
                db.Set<TB_Customers>().AddOrUpdate(tbAdd);
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("c3041638-7de3-4554-b82a-7ce25b2029e3");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Add void
        private void btn_add_Click(object sender, EventArgs e)
        {
            Add();
           
        }

        // Add and Close void
        private void btn_addclose_Click(object sender, EventArgs e)
        {
            Add();
            Close();
        }

        // Clear Value 
        private void ClearData()
        {
            edt_address.Text = edt_name.Text = edt_name.Text = "";
        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}