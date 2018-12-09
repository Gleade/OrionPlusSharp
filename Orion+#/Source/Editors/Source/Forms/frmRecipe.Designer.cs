﻿using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;

namespace Engine
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    partial class FrmRecipe : System.Windows.Forms.Form
    {

        // Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                    components.Dispose();
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.DarkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.lstIndex = new System.Windows.Forms.ListBox();
            this.DarkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnDelete = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.nudCreateTime = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel7 = new DarkUI.Controls.DarkLabel();
            this.DarkGroupBox3 = new DarkUI.Controls.DarkGroupBox();
            this.btnIngredientAdd = new DarkUI.Controls.DarkButton();
            this.numItemAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel6 = new DarkUI.Controls.DarkLabel();
            this.cmbIngredient = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel5 = new DarkUI.Controls.DarkLabel();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.nudAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel4 = new DarkUI.Controls.DarkLabel();
            this.cmbMakeItem = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel3 = new DarkUI.Controls.DarkLabel();
            this.cmbType = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel2 = new DarkUI.Controls.DarkLabel();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.DarkLabel1 = new DarkUI.Controls.DarkLabel();
            this.DarkGroupBox1.SuspendLayout();
            this.DarkGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudCreateTime).BeginInit();
            this.DarkGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.numItemAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudAmount).BeginInit();
            this.SuspendLayout();
            // 
            // DarkGroupBox1
            // 
            this.DarkGroupBox1.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox1.Controls.Add(this.lstIndex);
            this.DarkGroupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox1.Location = new System.Drawing.Point(3, 2);
            this.DarkGroupBox1.Name = "DarkGroupBox1";
            this.DarkGroupBox1.Size = new System.Drawing.Size(208, 337);
            this.DarkGroupBox1.TabIndex = 0;
            this.DarkGroupBox1.TabStop = false;
            this.DarkGroupBox1.Text = "Recipe List";
            // 
            // lstIndex
            // 
            this.lstIndex.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.lstIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstIndex.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstIndex.FormattingEnabled = true;
            this.lstIndex.Location = new System.Drawing.Point(6, 15);
            this.lstIndex.Name = "lstIndex";
            this.lstIndex.Size = new System.Drawing.Size(196, 314);
            this.lstIndex.TabIndex = 1;
            // 
            // DarkGroupBox2
            // 
            this.DarkGroupBox2.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox2.Controls.Add(this.btnCancel);
            this.DarkGroupBox2.Controls.Add(this.btnDelete);
            this.DarkGroupBox2.Controls.Add(this.btnSave);
            this.DarkGroupBox2.Controls.Add(this.nudCreateTime);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel7);
            this.DarkGroupBox2.Controls.Add(this.DarkGroupBox3);
            this.DarkGroupBox2.Controls.Add(this.nudAmount);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel4);
            this.DarkGroupBox2.Controls.Add(this.cmbMakeItem);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel3);
            this.DarkGroupBox2.Controls.Add(this.cmbType);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel2);
            this.DarkGroupBox2.Controls.Add(this.txtName);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel1);
            this.DarkGroupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox2.Location = new System.Drawing.Point(217, 2);
            this.DarkGroupBox2.Name = "DarkGroupBox2";
            this.DarkGroupBox2.Size = new System.Drawing.Size(364, 337);
            this.DarkGroupBox2.TabIndex = 1;
            this.DarkGroupBox2.TabStop = false;
            this.DarkGroupBox2.Text = "Settings";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(279, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(143, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            // 
            // nudCreateTime
            // 
            this.nudCreateTime.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudCreateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCreateTime.Location = new System.Drawing.Point(171, 118);
            this.nudCreateTime.Name = "nudCreateTime";
            this.nudCreateTime.Size = new System.Drawing.Size(120, 20);
            this.nudCreateTime.TabIndex = 10;
            // 
            // DarkLabel7
            // 
            this.DarkLabel7.AutoSize = true;
            this.DarkLabel7.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel7.Location = new System.Drawing.Point(6, 120);
            this.DarkLabel7.Name = "DarkLabel7";
            this.DarkLabel7.Size = new System.Drawing.Size(106, 13);
            this.DarkLabel7.TabIndex = 9;
            this.DarkLabel7.Text = "Create Time In Secs:";
            // 
            // DarkGroupBox3
            // 
            this.DarkGroupBox3.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox3.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox3.Controls.Add(this.btnIngredientAdd);
            this.DarkGroupBox3.Controls.Add(this.numItemAmount);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel6);
            this.DarkGroupBox3.Controls.Add(this.cmbIngredient);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel5);
            this.DarkGroupBox3.Controls.Add(this.lstIngredients);
            this.DarkGroupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox3.Location = new System.Drawing.Point(9, 144);
            this.DarkGroupBox3.Name = "DarkGroupBox3";
            this.DarkGroupBox3.Size = new System.Drawing.Size(345, 138);
            this.DarkGroupBox3.TabIndex = 8;
            this.DarkGroupBox3.TabStop = false;
            this.DarkGroupBox3.Text = "Ingredients";
            // 
            // btnIngredientAdd
            // 
            this.btnIngredientAdd.Location = new System.Drawing.Point(175, 102);
            this.btnIngredientAdd.Name = "btnIngredientAdd";
            this.btnIngredientAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnIngredientAdd.Size = new System.Drawing.Size(144, 23);
            this.btnIngredientAdd.TabIndex = 6;
            this.btnIngredientAdd.Text = "Update List";
            // 
            // numItemAmount
            // 
            this.numItemAmount.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.numItemAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.numItemAmount.Location = new System.Drawing.Point(286, 62);
            this.numItemAmount.Name = "numItemAmount";
            this.numItemAmount.Size = new System.Drawing.Size(53, 20);
            this.numItemAmount.TabIndex = 5;
            // 
            // DarkLabel6
            // 
            this.DarkLabel6.AutoSize = true;
            this.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel6.Location = new System.Drawing.Point(158, 64);
            this.DarkLabel6.Name = "DarkLabel6";
            this.DarkLabel6.Size = new System.Drawing.Size(87, 13);
            this.DarkLabel6.TabIndex = 4;
            this.DarkLabel6.Text = "Amount Needed:";
            // 
            // cmbIngredient
            // 
            this.cmbIngredient.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbIngredient.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbIngredient.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbIngredient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIngredient.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbIngredient.FormattingEnabled = true;
            this.cmbIngredient.Location = new System.Drawing.Point(161, 35);
            this.cmbIngredient.Name = "cmbIngredient";
            this.cmbIngredient.Size = new System.Drawing.Size(178, 21);
            this.cmbIngredient.TabIndex = 3;
            // 
            // DarkLabel5
            // 
            this.DarkLabel5.AutoSize = true;
            this.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel5.Location = new System.Drawing.Point(158, 19);
            this.DarkLabel5.Name = "DarkLabel5";
            this.DarkLabel5.Size = new System.Drawing.Size(93, 13);
            this.DarkLabel5.TabIndex = 2;
            this.DarkLabel5.Text = "Choose Ingredient";
            // 
            // lstIngredients
            // 
            this.lstIngredients.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.lstIngredients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstIngredients.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(6, 19);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(146, 106);
            this.lstIngredients.TabIndex = 1;
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAmount.Location = new System.Drawing.Point(312, 86);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(42, 20);
            this.nudAmount.TabIndex = 7;
            // 
            // DarkLabel4
            // 
            this.DarkLabel4.AutoSize = true;
            this.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel4.Location = new System.Drawing.Point(297, 88);
            this.DarkLabel4.Name = "DarkLabel4";
            this.DarkLabel4.Size = new System.Drawing.Size(14, 13);
            this.DarkLabel4.TabIndex = 6;
            this.DarkLabel4.Text = "X";
            // 
            // cmbMakeItem
            // 
            this.cmbMakeItem.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbMakeItem.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbMakeItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbMakeItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMakeItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMakeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMakeItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMakeItem.FormattingEnabled = true;
            this.cmbMakeItem.Location = new System.Drawing.Point(87, 85);
            this.cmbMakeItem.Name = "cmbMakeItem";
            this.cmbMakeItem.Size = new System.Drawing.Size(204, 21);
            this.cmbMakeItem.TabIndex = 5;
            // 
            // DarkLabel3
            // 
            this.DarkLabel3.AutoSize = true;
            this.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel3.Location = new System.Drawing.Point(6, 88);
            this.DarkLabel3.Name = "DarkLabel3";
            this.DarkLabel3.Size = new System.Drawing.Size(69, 13);
            this.DarkLabel3.TabIndex = 4;
            this.DarkLabel3.Text = "Creates Item:";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbType.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] { "Herbalist", "WoodWorking", "MetalWorking" });
            this.cmbType.Location = new System.Drawing.Point(87, 54);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(267, 21);
            this.cmbType.TabIndex = 3;
            // 
            // DarkLabel2
            // 
            this.DarkLabel2.AutoSize = true;
            this.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel2.Location = new System.Drawing.Point(6, 57);
            this.DarkLabel2.Name = "DarkLabel2";
            this.DarkLabel2.Size = new System.Drawing.Size(71, 13);
            this.DarkLabel2.TabIndex = 2;
            this.DarkLabel2.Text = "Recipe Type:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.txtName.Location = new System.Drawing.Point(87, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 20);
            this.txtName.TabIndex = 1;
            // 
            // DarkLabel1
            // 
            this.DarkLabel1.AutoSize = true;
            this.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel1.Location = new System.Drawing.Point(6, 27);
            this.DarkLabel1.Name = "DarkLabel1";
            this.DarkLabel1.Size = new System.Drawing.Size(75, 13);
            this.DarkLabel1.TabIndex = 0;
            this.DarkLabel1.Text = "Recipe Name:";
            // 
            // frmEditor_Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.ClientSize = new System.Drawing.Size(588, 346);
            this.ControlBox = false;
            this.Controls.Add(this.DarkGroupBox2);
            this.Controls.Add(this.DarkGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditor_Recipe";
            this.Text = "Recipe Editor";
            this.DarkGroupBox1.ResumeLayout(false);
            this.DarkGroupBox2.ResumeLayout(false);
            this.DarkGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudCreateTime).EndInit();
            this.DarkGroupBox3.ResumeLayout(false);
            this.DarkGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.numItemAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudAmount).EndInit();
            this.ResumeLayout(false);
        }

        public DarkUI.Controls.DarkGroupBox DarkGroupBox1;
        
        public ListBox lstIndex;
        
        public DarkUI.Controls.DarkGroupBox DarkGroupBox2;
        
        public DarkUI.Controls.DarkTextBox txtName;
        
        public DarkUI.Controls.DarkLabel DarkLabel1;
        
        public DarkUI.Controls.DarkComboBox cmbType;
        
        public DarkUI.Controls.DarkLabel DarkLabel2;
        
        public DarkUI.Controls.DarkComboBox cmbMakeItem;
        
        public DarkUI.Controls.DarkLabel DarkLabel3;
        
        public DarkUI.Controls.DarkNumericUpDown nudAmount;
        
        public DarkUI.Controls.DarkLabel DarkLabel4;
        
        public DarkUI.Controls.DarkGroupBox DarkGroupBox3;
        
        public ListBox lstIngredients;
        
        public DarkUI.Controls.DarkComboBox cmbIngredient;
        
        public DarkUI.Controls.DarkLabel DarkLabel5;
        
        public DarkUI.Controls.DarkLabel DarkLabel6;
        
        public DarkUI.Controls.DarkNumericUpDown numItemAmount;
        
        public DarkUI.Controls.DarkButton btnIngredientAdd;
        
        public DarkUI.Controls.DarkNumericUpDown nudCreateTime;
        
        public DarkUI.Controls.DarkLabel DarkLabel7;
        
        public DarkUI.Controls.DarkButton btnCancel;
        
        public DarkUI.Controls.DarkButton btnDelete;
        
        public DarkUI.Controls.DarkButton btnSave;
        
    }
}
