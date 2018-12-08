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
    partial class frmNPC : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNPC));
            this.DarkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.lstIndex = new System.Windows.Forms.ListBox();
            this.DarkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.nudSpawnSecs = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel13 = new DarkUI.Controls.DarkLabel();
            this.nudDamage = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel12 = new DarkUI.Controls.DarkLabel();
            this.nudLevel = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel11 = new DarkUI.Controls.DarkLabel();
            this.nudExp = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel10 = new DarkUI.Controls.DarkLabel();
            this.nudHp = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel9 = new DarkUI.Controls.DarkLabel();
            this.cmbFaction = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel8 = new DarkUI.Controls.DarkLabel();
            this.cmbBehaviour = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel5 = new DarkUI.Controls.DarkLabel();
            this.cmbQuest = new DarkUI.Controls.DarkComboBox();
            this.cmbAnimation = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel7 = new DarkUI.Controls.DarkLabel();
            this.DarkLabel6 = new DarkUI.Controls.DarkLabel();
            this.DarkLabel4 = new DarkUI.Controls.DarkLabel();
            this.nudRange = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSprite = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel3 = new DarkUI.Controls.DarkLabel();
            this.txtAttackSay = new DarkUI.Controls.DarkTextBox();
            this.DarkLabel2 = new DarkUI.Controls.DarkLabel();
            this.picSprite = new System.Windows.Forms.PictureBox();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.DarkLabel1 = new DarkUI.Controls.DarkLabel();
            this.DarkGroupBox3 = new DarkUI.Controls.DarkGroupBox();
            this.cmbSkill6 = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel17 = new DarkUI.Controls.DarkLabel();
            this.cmbSkill5 = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel18 = new DarkUI.Controls.DarkLabel();
            this.cmbSkill4 = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel19 = new DarkUI.Controls.DarkLabel();
            this.cmbSkill3 = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel16 = new DarkUI.Controls.DarkLabel();
            this.cmbSkill2 = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel15 = new DarkUI.Controls.DarkLabel();
            this.cmbSkill1 = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel14 = new DarkUI.Controls.DarkLabel();
            this.DarkGroupBox4 = new DarkUI.Controls.DarkGroupBox();
            this.nudAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel29 = new DarkUI.Controls.DarkLabel();
            this.cmbItem = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel28 = new DarkUI.Controls.DarkLabel();
            this.cmbDropSlot = new DarkUI.Controls.DarkComboBox();
            this.nudChance = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel27 = new DarkUI.Controls.DarkLabel();
            this.DarkLabel26 = new DarkUI.Controls.DarkLabel();
            this.DarkGroupBox5 = new DarkUI.Controls.DarkGroupBox();
            this.nudSpirit = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel23 = new DarkUI.Controls.DarkLabel();
            this.nudIntelligence = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel24 = new DarkUI.Controls.DarkLabel();
            this.nudLuck = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel25 = new DarkUI.Controls.DarkLabel();
            this.nudVitality = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel22 = new DarkUI.Controls.DarkLabel();
            this.nudEndurance = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel21 = new DarkUI.Controls.DarkLabel();
            this.nudStrength = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel20 = new DarkUI.Controls.DarkLabel();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnDelete = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.DarkLabel30 = new DarkUI.Controls.DarkLabel();
            this.cmbSpawnPeriod = new DarkUI.Controls.DarkComboBox();
            this.DarkGroupBox1.SuspendLayout();
            this.DarkGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudSpawnSecs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudDamage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudExp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudHp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudRange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudSprite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picSprite).BeginInit();
            this.DarkGroupBox3.SuspendLayout();
            this.DarkGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudChance).BeginInit();
            this.DarkGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudSpirit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudIntelligence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudLuck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudVitality).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudEndurance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudStrength).BeginInit();
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
            this.DarkGroupBox1.Size = new System.Drawing.Size(227, 504);
            this.DarkGroupBox1.TabIndex = 0;
            this.DarkGroupBox1.TabStop = false;
            this.DarkGroupBox1.Text = "Npc List";
            // 
            // lstIndex
            // 
            this.lstIndex.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.lstIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstIndex.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstIndex.FormattingEnabled = true;
            this.lstIndex.Location = new System.Drawing.Point(4, 16);
            this.lstIndex.Name = "lstIndex";
            this.lstIndex.Size = new System.Drawing.Size(219, 483);
            this.lstIndex.TabIndex = 2;
            // 
            // DarkGroupBox2
            // 
            this.DarkGroupBox2.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox2.Controls.Add(this.cmbSpawnPeriod);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel30);
            this.DarkGroupBox2.Controls.Add(this.nudSpawnSecs);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel13);
            this.DarkGroupBox2.Controls.Add(this.nudDamage);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel12);
            this.DarkGroupBox2.Controls.Add(this.nudLevel);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel11);
            this.DarkGroupBox2.Controls.Add(this.nudExp);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel10);
            this.DarkGroupBox2.Controls.Add(this.nudHp);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel9);
            this.DarkGroupBox2.Controls.Add(this.cmbFaction);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel8);
            this.DarkGroupBox2.Controls.Add(this.cmbBehaviour);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel5);
            this.DarkGroupBox2.Controls.Add(this.cmbQuest);
            this.DarkGroupBox2.Controls.Add(this.cmbAnimation);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel7);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel6);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel4);
            this.DarkGroupBox2.Controls.Add(this.nudRange);
            this.DarkGroupBox2.Controls.Add(this.nudSprite);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel3);
            this.DarkGroupBox2.Controls.Add(this.txtAttackSay);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel2);
            this.DarkGroupBox2.Controls.Add(this.picSprite);
            this.DarkGroupBox2.Controls.Add(this.txtName);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel1);
            this.DarkGroupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox2.Location = new System.Drawing.Point(236, 2);
            this.DarkGroupBox2.Name = "DarkGroupBox2";
            this.DarkGroupBox2.Size = new System.Drawing.Size(394, 231);
            this.DarkGroupBox2.TabIndex = 1;
            this.DarkGroupBox2.TabStop = false;
            this.DarkGroupBox2.Text = "Npc Properties";
            // 
            // nudSpawnSecs
            // 
            this.nudSpawnSecs.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudSpawnSecs.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpawnSecs.Location = new System.Drawing.Point(149, 203);
            this.nudSpawnSecs.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudSpawnSecs.Name = "nudSpawnSecs";
            this.nudSpawnSecs.Size = new System.Drawing.Size(83, 20);
            this.nudSpawnSecs.TabIndex = 36;
            // 
            // DarkLabel13
            // 
            this.DarkLabel13.AutoSize = true;
            this.DarkLabel13.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel13.Location = new System.Drawing.Point(6, 205);
            this.DarkLabel13.Name = "DarkLabel13";
            this.DarkLabel13.Size = new System.Drawing.Size(137, 13);
            this.DarkLabel13.TabIndex = 35;
            this.DarkLabel13.Text = "Respawn Time in Seconds:";
            // 
            // nudDamage
            // 
            this.nudDamage.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudDamage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDamage.Location = new System.Drawing.Point(266, 177);
            this.nudDamage.Name = "nudDamage";
            this.nudDamage.Size = new System.Drawing.Size(120, 20);
            this.nudDamage.TabIndex = 34;
            // 
            // DarkLabel12
            // 
            this.DarkLabel12.AutoSize = true;
            this.DarkLabel12.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel12.Location = new System.Drawing.Point(186, 179);
            this.DarkLabel12.Name = "DarkLabel12";
            this.DarkLabel12.Size = new System.Drawing.Size(77, 13);
            this.DarkLabel12.TabIndex = 33;
            this.DarkLabel12.Text = "Base Damage:";
            // 
            // nudLevel
            // 
            this.nudLevel.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLevel.Location = new System.Drawing.Point(60, 177);
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(120, 20);
            this.nudLevel.TabIndex = 32;
            // 
            // DarkLabel11
            // 
            this.DarkLabel11.AutoSize = true;
            this.DarkLabel11.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel11.Location = new System.Drawing.Point(6, 179);
            this.DarkLabel11.Name = "DarkLabel11";
            this.DarkLabel11.Size = new System.Drawing.Size(36, 13);
            this.DarkLabel11.TabIndex = 31;
            this.DarkLabel11.Text = "Level:";
            // 
            // nudExp
            // 
            this.nudExp.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudExp.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudExp.Location = new System.Drawing.Point(238, 151);
            this.nudExp.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudExp.Name = "nudExp";
            this.nudExp.Size = new System.Drawing.Size(148, 20);
            this.nudExp.TabIndex = 30;
            // 
            // DarkLabel10
            // 
            this.DarkLabel10.AutoSize = true;
            this.DarkLabel10.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel10.Location = new System.Drawing.Point(173, 153);
            this.DarkLabel10.Name = "DarkLabel10";
            this.DarkLabel10.Size = new System.Drawing.Size(59, 13);
            this.DarkLabel10.TabIndex = 29;
            this.DarkLabel10.Text = "Exp Given:";
            // 
            // nudHp
            // 
            this.nudHp.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudHp.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHp.Location = new System.Drawing.Point(60, 151);
            this.nudHp.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudHp.Name = "nudHp";
            this.nudHp.Size = new System.Drawing.Size(107, 20);
            this.nudHp.TabIndex = 28;
            // 
            // DarkLabel9
            // 
            this.DarkLabel9.AutoSize = true;
            this.DarkLabel9.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel9.Location = new System.Drawing.Point(6, 153);
            this.DarkLabel9.Name = "DarkLabel9";
            this.DarkLabel9.Size = new System.Drawing.Size(41, 13);
            this.DarkLabel9.TabIndex = 27;
            this.DarkLabel9.Text = "Health:";
            // 
            // cmbFaction
            // 
            this.cmbFaction.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbFaction.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbFaction.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbFaction.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbFaction.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbFaction.ButtonIcon");
            this.cmbFaction.DrawDropdownHoverOutline = false;
            this.cmbFaction.DrawFocusRectangle = false;
            this.cmbFaction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFaction.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFaction.FormattingEnabled = true;
            this.cmbFaction.Items.AddRange(new object[] { "None", "Baddies", "Goodies" });
            this.cmbFaction.Location = new System.Drawing.Point(259, 124);
            this.cmbFaction.Name = "cmbFaction";
            this.cmbFaction.Size = new System.Drawing.Size(127, 21);
            this.cmbFaction.TabIndex = 26;
            this.cmbFaction.Text = null;
            this.cmbFaction.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // DarkLabel8
            // 
            this.DarkLabel8.AutoSize = true;
            this.DarkLabel8.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel8.Location = new System.Drawing.Point(205, 127);
            this.DarkLabel8.Name = "DarkLabel8";
            this.DarkLabel8.Size = new System.Drawing.Size(45, 13);
            this.DarkLabel8.TabIndex = 25;
            this.DarkLabel8.Text = "Faction:";
            // 
            // cmbBehaviour
            // 
            this.cmbBehaviour.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbBehaviour.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbBehaviour.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbBehaviour.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbBehaviour.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbBehaviour.ButtonIcon");
            this.cmbBehaviour.DrawDropdownHoverOutline = false;
            this.cmbBehaviour.DrawFocusRectangle = false;
            this.cmbBehaviour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBehaviour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBehaviour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBehaviour.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbBehaviour.FormattingEnabled = true;
            this.cmbBehaviour.Items.AddRange(new object[] { "Attack on sight", "Attack when attacked", "Friendly", "Shop keeper", "Guard", "Quest" });
            this.cmbBehaviour.Location = new System.Drawing.Point(60, 124);
            this.cmbBehaviour.Name = "cmbBehaviour";
            this.cmbBehaviour.Size = new System.Drawing.Size(139, 21);
            this.cmbBehaviour.TabIndex = 24;
            this.cmbBehaviour.Text = null;
            this.cmbBehaviour.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // DarkLabel5
            // 
            this.DarkLabel5.AutoSize = true;
            this.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel5.Location = new System.Drawing.Point(6, 127);
            this.DarkLabel5.Name = "DarkLabel5";
            this.DarkLabel5.Size = new System.Drawing.Size(52, 13);
            this.DarkLabel5.TabIndex = 23;
            this.DarkLabel5.Text = "Behavior:";
            // 
            // cmbQuest
            // 
            this.cmbQuest.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbQuest.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbQuest.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbQuest.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbQuest.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbQuest.ButtonIcon");
            this.cmbQuest.DrawDropdownHoverOutline = false;
            this.cmbQuest.DrawFocusRectangle = false;
            this.cmbQuest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbQuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbQuest.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbQuest.FormattingEnabled = true;
            this.cmbQuest.Location = new System.Drawing.Point(218, 97);
            this.cmbQuest.Name = "cmbQuest";
            this.cmbQuest.Size = new System.Drawing.Size(168, 21);
            this.cmbQuest.TabIndex = 22;
            this.cmbQuest.Text = null;
            this.cmbQuest.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // cmbAnimation
            // 
            this.cmbAnimation.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbAnimation.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAnimation.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbAnimation.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbAnimation.ButtonIcon");
            this.cmbAnimation.DrawDropdownHoverOutline = false;
            this.cmbAnimation.DrawFocusRectangle = false;
            this.cmbAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAnimation.FormattingEnabled = true;
            this.cmbAnimation.Location = new System.Drawing.Point(60, 97);
            this.cmbAnimation.Name = "cmbAnimation";
            this.cmbAnimation.Size = new System.Drawing.Size(108, 21);
            this.cmbAnimation.TabIndex = 21;
            this.cmbAnimation.Text = null;
            this.cmbAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // DarkLabel7
            // 
            this.DarkLabel7.AutoSize = true;
            this.DarkLabel7.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel7.Location = new System.Drawing.Point(6, 100);
            this.DarkLabel7.Name = "DarkLabel7";
            this.DarkLabel7.Size = new System.Drawing.Size(56, 13);
            this.DarkLabel7.TabIndex = 20;
            this.DarkLabel7.Text = "Animation:";
            // 
            // DarkLabel6
            // 
            this.DarkLabel6.AutoSize = true;
            this.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel6.Location = new System.Drawing.Point(174, 100);
            this.DarkLabel6.Name = "DarkLabel6";
            this.DarkLabel6.Size = new System.Drawing.Size(38, 13);
            this.DarkLabel6.TabIndex = 18;
            this.DarkLabel6.Text = "Quest:";
            // 
            // DarkLabel4
            // 
            this.DarkLabel4.AutoSize = true;
            this.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel4.Location = new System.Drawing.Point(6, 73);
            this.DarkLabel4.Name = "DarkLabel4";
            this.DarkLabel4.Size = new System.Drawing.Size(42, 13);
            this.DarkLabel4.TabIndex = 15;
            this.DarkLabel4.Text = "Range:";
            // 
            // nudRange
            // 
            this.nudRange.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRange.Location = new System.Drawing.Point(60, 71);
            this.nudRange.Name = "nudRange";
            this.nudRange.Size = new System.Drawing.Size(108, 20);
            this.nudRange.TabIndex = 14;
            // 
            // nudSprite
            // 
            this.nudSprite.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudSprite.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSprite.Location = new System.Drawing.Point(217, 71);
            this.nudSprite.Name = "nudSprite";
            this.nudSprite.Size = new System.Drawing.Size(96, 20);
            this.nudSprite.TabIndex = 13;
            // 
            // DarkLabel3
            // 
            this.DarkLabel3.AutoSize = true;
            this.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel3.Location = new System.Drawing.Point(174, 73);
            this.DarkLabel3.Name = "DarkLabel3";
            this.DarkLabel3.Size = new System.Drawing.Size(37, 13);
            this.DarkLabel3.TabIndex = 12;
            this.DarkLabel3.Text = "Sprite:";
            // 
            // txtAttackSay
            // 
            this.txtAttackSay.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.txtAttackSay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttackSay.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.txtAttackSay.Location = new System.Drawing.Point(60, 45);
            this.txtAttackSay.Name = "txtAttackSay";
            this.txtAttackSay.Size = new System.Drawing.Size(253, 20);
            this.txtAttackSay.TabIndex = 11;
            // 
            // DarkLabel2
            // 
            this.DarkLabel2.AutoSize = true;
            this.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel2.Location = new System.Drawing.Point(6, 47);
            this.DarkLabel2.Name = "DarkLabel2";
            this.DarkLabel2.Size = new System.Drawing.Size(48, 13);
            this.DarkLabel2.TabIndex = 10;
            this.DarkLabel2.Text = "SayMsg:";
            // 
            // picSprite
            // 
            this.picSprite.BackColor = System.Drawing.Color.Black;
            this.picSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSprite.Location = new System.Drawing.Point(319, 19);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(67, 72);
            this.picSprite.TabIndex = 9;
            this.picSprite.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.txtName.Location = new System.Drawing.Point(60, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 20);
            this.txtName.TabIndex = 1;
            // 
            // DarkLabel1
            // 
            this.DarkLabel1.AutoSize = true;
            this.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel1.Location = new System.Drawing.Point(6, 21);
            this.DarkLabel1.Name = "DarkLabel1";
            this.DarkLabel1.Size = new System.Drawing.Size(38, 13);
            this.DarkLabel1.TabIndex = 0;
            this.DarkLabel1.Text = "Name:";
            // 
            // DarkGroupBox3
            // 
            this.DarkGroupBox3.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox3.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox3.Controls.Add(this.cmbSkill6);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel17);
            this.DarkGroupBox3.Controls.Add(this.cmbSkill5);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel18);
            this.DarkGroupBox3.Controls.Add(this.cmbSkill4);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel19);
            this.DarkGroupBox3.Controls.Add(this.cmbSkill3);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel16);
            this.DarkGroupBox3.Controls.Add(this.cmbSkill2);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel15);
            this.DarkGroupBox3.Controls.Add(this.cmbSkill1);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel14);
            this.DarkGroupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox3.Location = new System.Drawing.Point(236, 239);
            this.DarkGroupBox3.Name = "DarkGroupBox3";
            this.DarkGroupBox3.Size = new System.Drawing.Size(394, 71);
            this.DarkGroupBox3.TabIndex = 2;
            this.DarkGroupBox3.TabStop = false;
            this.DarkGroupBox3.Text = "Skills";
            // 
            // cmbSkill6
            // 
            this.cmbSkill6.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbSkill6.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbSkill6.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSkill6.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbSkill6.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbSkill6.ButtonIcon");
            this.cmbSkill6.DrawDropdownHoverOutline = false;
            this.cmbSkill6.DrawFocusRectangle = false;
            this.cmbSkill6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSkill6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkill6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSkill6.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSkill6.FormattingEnabled = true;
            this.cmbSkill6.Location = new System.Drawing.Point(285, 40);
            this.cmbSkill6.Name = "cmbSkill6";
            this.cmbSkill6.Size = new System.Drawing.Size(105, 21);
            this.cmbSkill6.TabIndex = 11;
            this.cmbSkill6.Text = null;
            this.cmbSkill6.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // DarkLabel17
            // 
            this.DarkLabel17.AutoSize = true;
            this.DarkLabel17.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel17.Location = new System.Drawing.Point(266, 43);
            this.DarkLabel17.Name = "DarkLabel17";
            this.DarkLabel17.Size = new System.Drawing.Size(13, 13);
            this.DarkLabel17.TabIndex = 10;
            this.DarkLabel17.Text = "6";
            // 
            // cmbSkill5
            // 
            this.cmbSkill5.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbSkill5.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbSkill5.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSkill5.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbSkill5.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbSkill5.ButtonIcon");
            this.cmbSkill5.DrawDropdownHoverOutline = false;
            this.cmbSkill5.DrawFocusRectangle = false;
            this.cmbSkill5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSkill5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkill5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSkill5.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSkill5.FormattingEnabled = true;
            this.cmbSkill5.Location = new System.Drawing.Point(155, 40);
            this.cmbSkill5.Name = "cmbSkill5";
            this.cmbSkill5.Size = new System.Drawing.Size(105, 21);
            this.cmbSkill5.TabIndex = 9;
            this.cmbSkill5.Text = null;
            this.cmbSkill5.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // DarkLabel18
            // 
            this.DarkLabel18.AutoSize = true;
            this.DarkLabel18.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel18.Location = new System.Drawing.Point(136, 43);
            this.DarkLabel18.Name = "DarkLabel18";
            this.DarkLabel18.Size = new System.Drawing.Size(13, 13);
            this.DarkLabel18.TabIndex = 8;
            this.DarkLabel18.Text = "5";
            // 
            // cmbSkill4
            // 
            this.cmbSkill4.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbSkill4.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbSkill4.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSkill4.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbSkill4.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbSkill4.ButtonIcon");
            this.cmbSkill4.DrawDropdownHoverOutline = false;
            this.cmbSkill4.DrawFocusRectangle = false;
            this.cmbSkill4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSkill4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkill4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSkill4.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSkill4.FormattingEnabled = true;
            this.cmbSkill4.Location = new System.Drawing.Point(25, 40);
            this.cmbSkill4.Name = "cmbSkill4";
            this.cmbSkill4.Size = new System.Drawing.Size(105, 21);
            this.cmbSkill4.TabIndex = 7;
            this.cmbSkill4.Text = null;
            this.cmbSkill4.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // DarkLabel19
            // 
            this.DarkLabel19.AutoSize = true;
            this.DarkLabel19.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel19.Location = new System.Drawing.Point(6, 43);
            this.DarkLabel19.Name = "DarkLabel19";
            this.DarkLabel19.Size = new System.Drawing.Size(13, 13);
            this.DarkLabel19.TabIndex = 6;
            this.DarkLabel19.Text = "4";
            // 
            // cmbSkill3
            // 
            this.cmbSkill3.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbSkill3.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbSkill3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSkill3.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbSkill3.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbSkill3.ButtonIcon");
            this.cmbSkill3.DrawDropdownHoverOutline = false;
            this.cmbSkill3.DrawFocusRectangle = false;
            this.cmbSkill3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSkill3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkill3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSkill3.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSkill3.FormattingEnabled = true;
            this.cmbSkill3.Location = new System.Drawing.Point(285, 13);
            this.cmbSkill3.Name = "cmbSkill3";
            this.cmbSkill3.Size = new System.Drawing.Size(105, 21);
            this.cmbSkill3.TabIndex = 5;
            this.cmbSkill3.Text = null;
            this.cmbSkill3.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // DarkLabel16
            // 
            this.DarkLabel16.AutoSize = true;
            this.DarkLabel16.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel16.Location = new System.Drawing.Point(266, 16);
            this.DarkLabel16.Name = "DarkLabel16";
            this.DarkLabel16.Size = new System.Drawing.Size(13, 13);
            this.DarkLabel16.TabIndex = 4;
            this.DarkLabel16.Text = "3";
            // 
            // cmbSkill2
            // 
            this.cmbSkill2.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbSkill2.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbSkill2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSkill2.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbSkill2.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbSkill2.ButtonIcon");
            this.cmbSkill2.DrawDropdownHoverOutline = false;
            this.cmbSkill2.DrawFocusRectangle = false;
            this.cmbSkill2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSkill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkill2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSkill2.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSkill2.FormattingEnabled = true;
            this.cmbSkill2.Location = new System.Drawing.Point(155, 13);
            this.cmbSkill2.Name = "cmbSkill2";
            this.cmbSkill2.Size = new System.Drawing.Size(105, 21);
            this.cmbSkill2.TabIndex = 3;
            this.cmbSkill2.Text = null;
            this.cmbSkill2.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // DarkLabel15
            // 
            this.DarkLabel15.AutoSize = true;
            this.DarkLabel15.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel15.Location = new System.Drawing.Point(136, 16);
            this.DarkLabel15.Name = "DarkLabel15";
            this.DarkLabel15.Size = new System.Drawing.Size(13, 13);
            this.DarkLabel15.TabIndex = 2;
            this.DarkLabel15.Text = "2";
            // 
            // cmbSkill1
            // 
            this.cmbSkill1.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbSkill1.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbSkill1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSkill1.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbSkill1.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbSkill1.ButtonIcon");
            this.cmbSkill1.DrawDropdownHoverOutline = false;
            this.cmbSkill1.DrawFocusRectangle = false;
            this.cmbSkill1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSkill1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkill1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSkill1.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSkill1.FormattingEnabled = true;
            this.cmbSkill1.Location = new System.Drawing.Point(25, 13);
            this.cmbSkill1.Name = "cmbSkill1";
            this.cmbSkill1.Size = new System.Drawing.Size(105, 21);
            this.cmbSkill1.TabIndex = 1;
            this.cmbSkill1.Text = null;
            this.cmbSkill1.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // DarkLabel14
            // 
            this.DarkLabel14.AutoSize = true;
            this.DarkLabel14.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel14.Location = new System.Drawing.Point(6, 16);
            this.DarkLabel14.Name = "DarkLabel14";
            this.DarkLabel14.Size = new System.Drawing.Size(13, 13);
            this.DarkLabel14.TabIndex = 0;
            this.DarkLabel14.Text = "1";
            // 
            // DarkGroupBox4
            // 
            this.DarkGroupBox4.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox4.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox4.Controls.Add(this.nudAmount);
            this.DarkGroupBox4.Controls.Add(this.DarkLabel29);
            this.DarkGroupBox4.Controls.Add(this.cmbItem);
            this.DarkGroupBox4.Controls.Add(this.DarkLabel28);
            this.DarkGroupBox4.Controls.Add(this.cmbDropSlot);
            this.DarkGroupBox4.Controls.Add(this.nudChance);
            this.DarkGroupBox4.Controls.Add(this.DarkLabel27);
            this.DarkGroupBox4.Controls.Add(this.DarkLabel26);
            this.DarkGroupBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox4.Location = new System.Drawing.Point(236, 400);
            this.DarkGroupBox4.Name = "DarkGroupBox4";
            this.DarkGroupBox4.Size = new System.Drawing.Size(394, 77);
            this.DarkGroupBox4.TabIndex = 3;
            this.DarkGroupBox4.TabStop = false;
            this.DarkGroupBox4.Text = "Drop Items";
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAmount.Location = new System.Drawing.Point(268, 44);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(120, 20);
            this.nudAmount.TabIndex = 7;
            // 
            // DarkLabel29
            // 
            this.DarkLabel29.AutoSize = true;
            this.DarkLabel29.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel29.Location = new System.Drawing.Point(205, 46);
            this.DarkLabel29.Name = "DarkLabel29";
            this.DarkLabel29.Size = new System.Drawing.Size(46, 13);
            this.DarkLabel29.TabIndex = 6;
            this.DarkLabel29.Text = "Amount:";
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbItem.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbItem.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbItem.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbItem.ButtonIcon");
            this.cmbItem.DrawDropdownHoverOutline = false;
            this.cmbItem.DrawFocusRectangle = false;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(66, 43);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 21);
            this.cmbItem.TabIndex = 5;
            this.cmbItem.Text = null;
            this.cmbItem.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // DarkLabel28
            // 
            this.DarkLabel28.AutoSize = true;
            this.DarkLabel28.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel28.Location = new System.Drawing.Point(6, 46);
            this.DarkLabel28.Name = "DarkLabel28";
            this.DarkLabel28.Size = new System.Drawing.Size(30, 13);
            this.DarkLabel28.TabIndex = 4;
            this.DarkLabel28.Text = "Item:";
            // 
            // cmbDropSlot
            // 
            this.cmbDropSlot.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbDropSlot.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbDropSlot.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDropSlot.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbDropSlot.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbDropSlot.ButtonIcon");
            this.cmbDropSlot.DrawDropdownHoverOutline = false;
            this.cmbDropSlot.DrawFocusRectangle = false;
            this.cmbDropSlot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDropSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDropSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDropSlot.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDropSlot.FormattingEnabled = true;
            this.cmbDropSlot.Items.AddRange(new object[] { "Slot 1", "Slot 2", "Slot 3", "Slot 4", "Slot 5" });
            this.cmbDropSlot.Location = new System.Drawing.Point(66, 13);
            this.cmbDropSlot.Name = "cmbDropSlot";
            this.cmbDropSlot.Size = new System.Drawing.Size(121, 21);
            this.cmbDropSlot.TabIndex = 3;
            this.cmbDropSlot.Text = null;
            this.cmbDropSlot.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // nudChance
            // 
            this.nudChance.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudChance.Location = new System.Drawing.Point(294, 14);
            this.nudChance.Name = "nudChance";
            this.nudChance.Size = new System.Drawing.Size(94, 20);
            this.nudChance.TabIndex = 2;
            // 
            // DarkLabel27
            // 
            this.DarkLabel27.AutoSize = true;
            this.DarkLabel27.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel27.Location = new System.Drawing.Point(205, 16);
            this.DarkLabel27.Name = "DarkLabel27";
            this.DarkLabel27.Size = new System.Drawing.Size(83, 13);
            this.DarkLabel27.TabIndex = 1;
            this.DarkLabel27.Text = "Chance 1 out of";
            // 
            // DarkLabel26
            // 
            this.DarkLabel26.AutoSize = true;
            this.DarkLabel26.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel26.Location = new System.Drawing.Point(6, 16);
            this.DarkLabel26.Name = "DarkLabel26";
            this.DarkLabel26.Size = new System.Drawing.Size(54, 13);
            this.DarkLabel26.TabIndex = 0;
            this.DarkLabel26.Text = "Drop Slot:";
            // 
            // DarkGroupBox5
            // 
            this.DarkGroupBox5.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox5.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox5.Controls.Add(this.nudSpirit);
            this.DarkGroupBox5.Controls.Add(this.DarkLabel23);
            this.DarkGroupBox5.Controls.Add(this.nudIntelligence);
            this.DarkGroupBox5.Controls.Add(this.DarkLabel24);
            this.DarkGroupBox5.Controls.Add(this.nudLuck);
            this.DarkGroupBox5.Controls.Add(this.DarkLabel25);
            this.DarkGroupBox5.Controls.Add(this.nudVitality);
            this.DarkGroupBox5.Controls.Add(this.DarkLabel22);
            this.DarkGroupBox5.Controls.Add(this.nudEndurance);
            this.DarkGroupBox5.Controls.Add(this.DarkLabel21);
            this.DarkGroupBox5.Controls.Add(this.nudStrength);
            this.DarkGroupBox5.Controls.Add(this.DarkLabel20);
            this.DarkGroupBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox5.Location = new System.Drawing.Point(236, 316);
            this.DarkGroupBox5.Name = "DarkGroupBox5";
            this.DarkGroupBox5.Size = new System.Drawing.Size(394, 78);
            this.DarkGroupBox5.TabIndex = 4;
            this.DarkGroupBox5.TabStop = false;
            this.DarkGroupBox5.Text = "Stats";
            // 
            // nudSpirit
            // 
            this.nudSpirit.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudSpirit.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpirit.Location = new System.Drawing.Point(320, 45);
            this.nudSpirit.Name = "nudSpirit";
            this.nudSpirit.Size = new System.Drawing.Size(63, 20);
            this.nudSpirit.TabIndex = 11;
            // 
            // DarkLabel23
            // 
            this.DarkLabel23.AutoSize = true;
            this.DarkLabel23.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel23.Location = new System.Drawing.Point(266, 47);
            this.DarkLabel23.Name = "DarkLabel23";
            this.DarkLabel23.Size = new System.Drawing.Size(33, 13);
            this.DarkLabel23.TabIndex = 10;
            this.DarkLabel23.Text = "Spirit:";
            // 
            // nudIntelligence
            // 
            this.nudIntelligence.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudIntelligence.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudIntelligence.Location = new System.Drawing.Point(197, 45);
            this.nudIntelligence.Name = "nudIntelligence";
            this.nudIntelligence.Size = new System.Drawing.Size(63, 20);
            this.nudIntelligence.TabIndex = 9;
            // 
            // DarkLabel24
            // 
            this.DarkLabel24.AutoSize = true;
            this.DarkLabel24.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel24.Location = new System.Drawing.Point(129, 47);
            this.DarkLabel24.Name = "DarkLabel24";
            this.DarkLabel24.Size = new System.Drawing.Size(64, 13);
            this.DarkLabel24.TabIndex = 8;
            this.DarkLabel24.Text = "Intelligence:";
            // 
            // nudLuck
            // 
            this.nudLuck.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudLuck.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLuck.Location = new System.Drawing.Point(60, 45);
            this.nudLuck.Name = "nudLuck";
            this.nudLuck.Size = new System.Drawing.Size(63, 20);
            this.nudLuck.TabIndex = 7;
            // 
            // DarkLabel25
            // 
            this.DarkLabel25.AutoSize = true;
            this.DarkLabel25.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel25.Location = new System.Drawing.Point(6, 47);
            this.DarkLabel25.Name = "DarkLabel25";
            this.DarkLabel25.Size = new System.Drawing.Size(34, 13);
            this.DarkLabel25.TabIndex = 6;
            this.DarkLabel25.Text = "Luck:";
            // 
            // nudVitality
            // 
            this.nudVitality.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudVitality.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudVitality.Location = new System.Drawing.Point(320, 19);
            this.nudVitality.Name = "nudVitality";
            this.nudVitality.Size = new System.Drawing.Size(63, 20);
            this.nudVitality.TabIndex = 5;
            // 
            // DarkLabel22
            // 
            this.DarkLabel22.AutoSize = true;
            this.DarkLabel22.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel22.Location = new System.Drawing.Point(266, 21);
            this.DarkLabel22.Name = "DarkLabel22";
            this.DarkLabel22.Size = new System.Drawing.Size(40, 13);
            this.DarkLabel22.TabIndex = 4;
            this.DarkLabel22.Text = "Vitality:";
            // 
            // nudEndurance
            // 
            this.nudEndurance.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudEndurance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudEndurance.Location = new System.Drawing.Point(197, 19);
            this.nudEndurance.Name = "nudEndurance";
            this.nudEndurance.Size = new System.Drawing.Size(63, 20);
            this.nudEndurance.TabIndex = 3;
            // 
            // DarkLabel21
            // 
            this.DarkLabel21.AutoSize = true;
            this.DarkLabel21.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel21.Location = new System.Drawing.Point(129, 21);
            this.DarkLabel21.Name = "DarkLabel21";
            this.DarkLabel21.Size = new System.Drawing.Size(62, 13);
            this.DarkLabel21.TabIndex = 2;
            this.DarkLabel21.Text = "Endurance:";
            // 
            // nudStrength
            // 
            this.nudStrength.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudStrength.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudStrength.Location = new System.Drawing.Point(60, 19);
            this.nudStrength.Name = "nudStrength";
            this.nudStrength.Size = new System.Drawing.Size(63, 20);
            this.nudStrength.TabIndex = 1;
            // 
            // DarkLabel20
            // 
            this.DarkLabel20.AutoSize = true;
            this.DarkLabel20.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel20.Location = new System.Drawing.Point(6, 21);
            this.DarkLabel20.Name = "DarkLabel20";
            this.DarkLabel20.Size = new System.Drawing.Size(50, 13);
            this.DarkLabel20.TabIndex = 0;
            this.DarkLabel20.Text = "Strenght:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(555, 483);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(236, 483);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(393, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            // 
            // DarkLabel30
            // 
            this.DarkLabel30.AutoSize = true;
            this.DarkLabel30.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel30.Location = new System.Drawing.Point(235, 205);
            this.DarkLabel30.Name = "DarkLabel30";
            this.DarkLabel30.Size = new System.Drawing.Size(48, 13);
            this.DarkLabel30.TabIndex = 37;
            this.DarkLabel30.Text = "Spawns:";
            // 
            // cmbSpawnPeriod
            // 
            this.cmbSpawnPeriod.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbSpawnPeriod.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbSpawnPeriod.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSpawnPeriod.ButtonColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)), System.Convert.ToInt32(System.Convert.ToByte(43)));
            this.cmbSpawnPeriod.ButtonIcon = (System.Drawing.Bitmap)resources.GetObject("cmbSpawnPeriod.ButtonIcon");
            this.cmbSpawnPeriod.DrawDropdownHoverOutline = false;
            this.cmbSpawnPeriod.DrawFocusRectangle = false;
            this.cmbSpawnPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSpawnPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpawnPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSpawnPeriod.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSpawnPeriod.FormattingEnabled = true;
            this.cmbSpawnPeriod.Items.AddRange(new object[] { "Day", "Night", "Dawn", "Dusk", "Always" });
            this.cmbSpawnPeriod.Location = new System.Drawing.Point(285, 202);
            this.cmbSpawnPeriod.Name = "cmbSpawnPeriod";
            this.cmbSpawnPeriod.Size = new System.Drawing.Size(101, 21);
            this.cmbSpawnPeriod.TabIndex = 38;
            this.cmbSpawnPeriod.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // FrmEditor_Npc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.ClientSize = new System.Drawing.Size(637, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.DarkGroupBox5);
            this.Controls.Add(this.DarkGroupBox4);
            this.Controls.Add(this.DarkGroupBox3);
            this.Controls.Add(this.DarkGroupBox2);
            this.Controls.Add(this.DarkGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditor_Npc";
            this.Text = "Npc Editor";
            this.DarkGroupBox1.ResumeLayout(false);
            this.DarkGroupBox2.ResumeLayout(false);
            this.DarkGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudSpawnSecs).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudDamage).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudExp).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudHp).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudRange).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudSprite).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picSprite).EndInit();
            this.DarkGroupBox3.ResumeLayout(false);
            this.DarkGroupBox3.PerformLayout();
            this.DarkGroupBox4.ResumeLayout(false);
            this.DarkGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudChance).EndInit();
            this.DarkGroupBox5.ResumeLayout(false);
            this.DarkGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudSpirit).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudIntelligence).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudLuck).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudVitality).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudEndurance).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudStrength).EndInit();
            this.ResumeLayout(false);
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox1;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox1
        {
            
            get
            {
                return _DarkGroupBox1;
            }

            
            set
            {
                if (_DarkGroupBox1 != null)
                {
                }

                _DarkGroupBox1 = value;
                if (_DarkGroupBox1 != null)
                {
                }
            }
        }

        private ListBox _lstIndex;

        internal ListBox lstIndex
        {
            
            get
            {
                return _lstIndex;
            }

            
            set
            {
                if (_lstIndex != null)
                {
                }

                _lstIndex = value;
                if (_lstIndex != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox2;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox2
        {
            
            get
            {
                return _DarkGroupBox2;
            }

            
            set
            {
                if (_DarkGroupBox2 != null)
                {
                }

                _DarkGroupBox2 = value;
                if (_DarkGroupBox2 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkTextBox _txtName;

        internal DarkUI.Controls.DarkTextBox txtName
        {
            
            get
            {
                return _txtName;
            }

            
            set
            {
                if (_txtName != null)
                {
                }

                _txtName = value;
                if (_txtName != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel1;

        internal DarkUI.Controls.DarkLabel DarkLabel1
        {
            
            get
            {
                return _DarkLabel1;
            }

            
            set
            {
                if (_DarkLabel1 != null)
                {
                }

                _DarkLabel1 = value;
                if (_DarkLabel1 != null)
                {
                }
            }
        }

        private PictureBox _picSprite;

        internal PictureBox picSprite
        {
            
            get
            {
                return _picSprite;
            }

            
            set
            {
                if (_picSprite != null)
                {
                }

                _picSprite = value;
                if (_picSprite != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkTextBox _txtAttackSay;

        internal DarkUI.Controls.DarkTextBox txtAttackSay
        {
            
            get
            {
                return _txtAttackSay;
            }

            
            set
            {
                if (_txtAttackSay != null)
                {
                }

                _txtAttackSay = value;
                if (_txtAttackSay != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel2;

        internal DarkUI.Controls.DarkLabel DarkLabel2
        {
            
            get
            {
                return _DarkLabel2;
            }

            
            set
            {
                if (_DarkLabel2 != null)
                {
                }

                _DarkLabel2 = value;
                if (_DarkLabel2 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudSprite;

        internal DarkUI.Controls.DarkNumericUpDown nudSprite
        {
            
            get
            {
                return _nudSprite;
            }

            
            set
            {
                if (_nudSprite != null)
                {
                }

                _nudSprite = value;
                if (_nudSprite != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel3;

        internal DarkUI.Controls.DarkLabel DarkLabel3
        {
            
            get
            {
                return _DarkLabel3;
            }

            
            set
            {
                if (_DarkLabel3 != null)
                {
                }

                _DarkLabel3 = value;
                if (_DarkLabel3 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel4;

        internal DarkUI.Controls.DarkLabel DarkLabel4
        {
            
            get
            {
                return _DarkLabel4;
            }

            
            set
            {
                if (_DarkLabel4 != null)
                {
                }

                _DarkLabel4 = value;
                if (_DarkLabel4 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudRange;

        internal DarkUI.Controls.DarkNumericUpDown nudRange
        {
            
            get
            {
                return _nudRange;
            }

            
            set
            {
                if (_nudRange != null)
                {
                }

                _nudRange = value;
                if (_nudRange != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel6;

        internal DarkUI.Controls.DarkLabel DarkLabel6
        {
            
            get
            {
                return _DarkLabel6;
            }

            
            set
            {
                if (_DarkLabel6 != null)
                {
                }

                _DarkLabel6 = value;
                if (_DarkLabel6 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbAnimation;

        internal DarkUI.Controls.DarkComboBox cmbAnimation
        {
            
            get
            {
                return _cmbAnimation;
            }

            
            set
            {
                if (_cmbAnimation != null)
                {
                }

                _cmbAnimation = value;
                if (_cmbAnimation != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel7;

        internal DarkUI.Controls.DarkLabel DarkLabel7
        {
            
            get
            {
                return _DarkLabel7;
            }

            
            set
            {
                if (_DarkLabel7 != null)
                {
                }

                _DarkLabel7 = value;
                if (_DarkLabel7 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbQuest;

        internal DarkUI.Controls.DarkComboBox cmbQuest
        {
            
            get
            {
                return _cmbQuest;
            }

            
            set
            {
                if (_cmbQuest != null)
                {
                }

                _cmbQuest = value;
                if (_cmbQuest != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbFaction;

        internal DarkUI.Controls.DarkComboBox cmbFaction
        {
            
            get
            {
                return _cmbFaction;
            }

            
            set
            {
                if (_cmbFaction != null)
                {
                }

                _cmbFaction = value;
                if (_cmbFaction != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel8;

        internal DarkUI.Controls.DarkLabel DarkLabel8
        {
            
            get
            {
                return _DarkLabel8;
            }

            
            set
            {
                if (_DarkLabel8 != null)
                {
                }

                _DarkLabel8 = value;
                if (_DarkLabel8 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbBehaviour;

        internal DarkUI.Controls.DarkComboBox cmbBehaviour
        {
            
            get
            {
                return _cmbBehaviour;
            }

            
            set
            {
                if (_cmbBehaviour != null)
                {
                }

                _cmbBehaviour = value;
                if (_cmbBehaviour != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel5;

        internal DarkUI.Controls.DarkLabel DarkLabel5
        {
            
            get
            {
                return _DarkLabel5;
            }

            
            set
            {
                if (_DarkLabel5 != null)
                {
                }

                _DarkLabel5 = value;
                if (_DarkLabel5 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudHp;

        internal DarkUI.Controls.DarkNumericUpDown nudHp
        {
            
            get
            {
                return _nudHp;
            }

            
            set
            {
                if (_nudHp != null)
                {
                }

                _nudHp = value;
                if (_nudHp != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel9;

        internal DarkUI.Controls.DarkLabel DarkLabel9
        {
            
            get
            {
                return _DarkLabel9;
            }

            
            set
            {
                if (_DarkLabel9 != null)
                {
                }

                _DarkLabel9 = value;
                if (_DarkLabel9 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudExp;

        internal DarkUI.Controls.DarkNumericUpDown nudExp
        {
            
            get
            {
                return _nudExp;
            }

            
            set
            {
                if (_nudExp != null)
                {
                }

                _nudExp = value;
                if (_nudExp != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel10;

        internal DarkUI.Controls.DarkLabel DarkLabel10
        {
            
            get
            {
                return _DarkLabel10;
            }

            
            set
            {
                if (_DarkLabel10 != null)
                {
                }

                _DarkLabel10 = value;
                if (_DarkLabel10 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudDamage;

        internal DarkUI.Controls.DarkNumericUpDown nudDamage
        {
            
            get
            {
                return _nudDamage;
            }

            
            set
            {
                if (_nudDamage != null)
                {
                }

                _nudDamage = value;
                if (_nudDamage != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel12;

        internal DarkUI.Controls.DarkLabel DarkLabel12
        {
            
            get
            {
                return _DarkLabel12;
            }

            
            set
            {
                if (_DarkLabel12 != null)
                {
                }

                _DarkLabel12 = value;
                if (_DarkLabel12 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudLevel;

        internal DarkUI.Controls.DarkNumericUpDown nudLevel
        {
            
            get
            {
                return _nudLevel;
            }

            
            set
            {
                if (_nudLevel != null)
                {
                }

                _nudLevel = value;
                if (_nudLevel != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel11;

        internal DarkUI.Controls.DarkLabel DarkLabel11
        {
            
            get
            {
                return _DarkLabel11;
            }

            
            set
            {
                if (_DarkLabel11 != null)
                {
                }

                _DarkLabel11 = value;
                if (_DarkLabel11 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudSpawnSecs;

        internal DarkUI.Controls.DarkNumericUpDown nudSpawnSecs
        {
            
            get
            {
                return _nudSpawnSecs;
            }

            
            set
            {
                if (_nudSpawnSecs != null)
                {
                }

                _nudSpawnSecs = value;
                if (_nudSpawnSecs != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel13;

        internal DarkUI.Controls.DarkLabel DarkLabel13
        {
            
            get
            {
                return _DarkLabel13;
            }

            
            set
            {
                if (_DarkLabel13 != null)
                {
                }

                _DarkLabel13 = value;
                if (_DarkLabel13 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox3;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox3
        {
            
            get
            {
                return _DarkGroupBox3;
            }

            
            set
            {
                if (_DarkGroupBox3 != null)
                {
                }

                _DarkGroupBox3 = value;
                if (_DarkGroupBox3 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox4;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox4
        {
            
            get
            {
                return _DarkGroupBox4;
            }

            
            set
            {
                if (_DarkGroupBox4 != null)
                {
                }

                _DarkGroupBox4 = value;
                if (_DarkGroupBox4 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox5;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox5
        {
            
            get
            {
                return _DarkGroupBox5;
            }

            
            set
            {
                if (_DarkGroupBox5 != null)
                {
                }

                _DarkGroupBox5 = value;
                if (_DarkGroupBox5 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbSkill1;

        internal DarkUI.Controls.DarkComboBox cmbSkill1
        {
            
            get
            {
                return _cmbSkill1;
            }

            
            set
            {
                if (_cmbSkill1 != null)
                {
                }

                _cmbSkill1 = value;
                if (_cmbSkill1 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel14;

        internal DarkUI.Controls.DarkLabel DarkLabel14
        {
            
            get
            {
                return _DarkLabel14;
            }

            
            set
            {
                if (_DarkLabel14 != null)
                {
                }

                _DarkLabel14 = value;
                if (_DarkLabel14 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbSkill6;

        internal DarkUI.Controls.DarkComboBox cmbSkill6
        {
            
            get
            {
                return _cmbSkill6;
            }

            
            set
            {
                if (_cmbSkill6 != null)
                {
                }

                _cmbSkill6 = value;
                if (_cmbSkill6 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel17;

        internal DarkUI.Controls.DarkLabel DarkLabel17
        {
            
            get
            {
                return _DarkLabel17;
            }

            
            set
            {
                if (_DarkLabel17 != null)
                {
                }

                _DarkLabel17 = value;
                if (_DarkLabel17 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbSkill5;

        internal DarkUI.Controls.DarkComboBox cmbSkill5
        {
            
            get
            {
                return _cmbSkill5;
            }

            
            set
            {
                if (_cmbSkill5 != null)
                {
                }

                _cmbSkill5 = value;
                if (_cmbSkill5 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel18;

        internal DarkUI.Controls.DarkLabel DarkLabel18
        {
            
            get
            {
                return _DarkLabel18;
            }

            
            set
            {
                if (_DarkLabel18 != null)
                {
                }

                _DarkLabel18 = value;
                if (_DarkLabel18 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbSkill4;

        internal DarkUI.Controls.DarkComboBox cmbSkill4
        {
            
            get
            {
                return _cmbSkill4;
            }

            
            set
            {
                if (_cmbSkill4 != null)
                {
                }

                _cmbSkill4 = value;
                if (_cmbSkill4 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel19;

        internal DarkUI.Controls.DarkLabel DarkLabel19
        {
            
            get
            {
                return _DarkLabel19;
            }

            
            set
            {
                if (_DarkLabel19 != null)
                {
                }

                _DarkLabel19 = value;
                if (_DarkLabel19 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbSkill3;

        internal DarkUI.Controls.DarkComboBox cmbSkill3
        {
            
            get
            {
                return _cmbSkill3;
            }

            
            set
            {
                if (_cmbSkill3 != null)
                {
                }

                _cmbSkill3 = value;
                if (_cmbSkill3 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel16;

        internal DarkUI.Controls.DarkLabel DarkLabel16
        {
            
            get
            {
                return _DarkLabel16;
            }

            
            set
            {
                if (_DarkLabel16 != null)
                {
                }

                _DarkLabel16 = value;
                if (_DarkLabel16 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbSkill2;

        internal DarkUI.Controls.DarkComboBox cmbSkill2
        {
            
            get
            {
                return _cmbSkill2;
            }

            
            set
            {
                if (_cmbSkill2 != null)
                {
                }

                _cmbSkill2 = value;
                if (_cmbSkill2 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel15;

        internal DarkUI.Controls.DarkLabel DarkLabel15
        {
            
            get
            {
                return _DarkLabel15;
            }

            
            set
            {
                if (_DarkLabel15 != null)
                {
                }

                _DarkLabel15 = value;
                if (_DarkLabel15 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudStrength;

        internal DarkUI.Controls.DarkNumericUpDown nudStrength
        {
            
            get
            {
                return _nudStrength;
            }

            
            set
            {
                if (_nudStrength != null)
                {
                }

                _nudStrength = value;
                if (_nudStrength != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel20;

        internal DarkUI.Controls.DarkLabel DarkLabel20
        {
            
            get
            {
                return _DarkLabel20;
            }

            
            set
            {
                if (_DarkLabel20 != null)
                {
                }

                _DarkLabel20 = value;
                if (_DarkLabel20 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudSpirit;

        internal DarkUI.Controls.DarkNumericUpDown nudSpirit
        {
            
            get
            {
                return _nudSpirit;
            }

            
            set
            {
                if (_nudSpirit != null)
                {
                }

                _nudSpirit = value;
                if (_nudSpirit != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel23;

        internal DarkUI.Controls.DarkLabel DarkLabel23
        {
            
            get
            {
                return _DarkLabel23;
            }

            
            set
            {
                if (_DarkLabel23 != null)
                {
                }

                _DarkLabel23 = value;
                if (_DarkLabel23 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudIntelligence;

        internal DarkUI.Controls.DarkNumericUpDown nudIntelligence
        {
            
            get
            {
                return _nudIntelligence;
            }

            
            set
            {
                if (_nudIntelligence != null)
                {
                }

                _nudIntelligence = value;
                if (_nudIntelligence != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel24;

        internal DarkUI.Controls.DarkLabel DarkLabel24
        {
            
            get
            {
                return _DarkLabel24;
            }

            
            set
            {
                if (_DarkLabel24 != null)
                {
                }

                _DarkLabel24 = value;
                if (_DarkLabel24 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudLuck;

        internal DarkUI.Controls.DarkNumericUpDown nudLuck
        {
            
            get
            {
                return _nudLuck;
            }

            
            set
            {
                if (_nudLuck != null)
                {
                }

                _nudLuck = value;
                if (_nudLuck != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel25;

        internal DarkUI.Controls.DarkLabel DarkLabel25
        {
            
            get
            {
                return _DarkLabel25;
            }

            
            set
            {
                if (_DarkLabel25 != null)
                {
                }

                _DarkLabel25 = value;
                if (_DarkLabel25 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudVitality;

        internal DarkUI.Controls.DarkNumericUpDown nudVitality
        {
            
            get
            {
                return _nudVitality;
            }

            
            set
            {
                if (_nudVitality != null)
                {
                }

                _nudVitality = value;
                if (_nudVitality != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel22;

        internal DarkUI.Controls.DarkLabel DarkLabel22
        {
            
            get
            {
                return _DarkLabel22;
            }

            
            set
            {
                if (_DarkLabel22 != null)
                {
                }

                _DarkLabel22 = value;
                if (_DarkLabel22 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudEndurance;

        internal DarkUI.Controls.DarkNumericUpDown nudEndurance
        {
            
            get
            {
                return _nudEndurance;
            }

            
            set
            {
                if (_nudEndurance != null)
                {
                }

                _nudEndurance = value;
                if (_nudEndurance != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel21;

        internal DarkUI.Controls.DarkLabel DarkLabel21
        {
            
            get
            {
                return _DarkLabel21;
            }

            
            set
            {
                if (_DarkLabel21 != null)
                {
                }

                _DarkLabel21 = value;
                if (_DarkLabel21 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel26;

        internal DarkUI.Controls.DarkLabel DarkLabel26
        {
            
            get
            {
                return _DarkLabel26;
            }

            
            set
            {
                if (_DarkLabel26 != null)
                {
                }

                _DarkLabel26 = value;
                if (_DarkLabel26 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbDropSlot;

        internal DarkUI.Controls.DarkComboBox cmbDropSlot
        {
            
            get
            {
                return _cmbDropSlot;
            }

            
            set
            {
                if (_cmbDropSlot != null)
                {
                }

                _cmbDropSlot = value;
                if (_cmbDropSlot != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudChance;

        internal DarkUI.Controls.DarkNumericUpDown nudChance
        {
            
            get
            {
                return _nudChance;
            }

            
            set
            {
                if (_nudChance != null)
                {
                }

                _nudChance = value;
                if (_nudChance != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel27;

        internal DarkUI.Controls.DarkLabel DarkLabel27
        {
            
            get
            {
                return _DarkLabel27;
            }

            
            set
            {
                if (_DarkLabel27 != null)
                {
                }

                _DarkLabel27 = value;
                if (_DarkLabel27 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudAmount;

        internal DarkUI.Controls.DarkNumericUpDown nudAmount
        {
            
            get
            {
                return _nudAmount;
            }

            
            set
            {
                if (_nudAmount != null)
                {
                }

                _nudAmount = value;
                if (_nudAmount != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel29;

        internal DarkUI.Controls.DarkLabel DarkLabel29
        {
            
            get
            {
                return _DarkLabel29;
            }

            
            set
            {
                if (_DarkLabel29 != null)
                {
                }

                _DarkLabel29 = value;
                if (_DarkLabel29 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbItem;

        internal DarkUI.Controls.DarkComboBox cmbItem
        {
            
            get
            {
                return _cmbItem;
            }

            
            set
            {
                if (_cmbItem != null)
                {
                }

                _cmbItem = value;
                if (_cmbItem != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel28;

        internal DarkUI.Controls.DarkLabel DarkLabel28
        {
            
            get
            {
                return _DarkLabel28;
            }

            
            set
            {
                if (_DarkLabel28 != null)
                {
                }

                _DarkLabel28 = value;
                if (_DarkLabel28 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkButton _btnCancel;

        internal DarkUI.Controls.DarkButton btnCancel
        {
            
            get
            {
                return _btnCancel;
            }

            
            set
            {
                if (_btnCancel != null)
                {
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkButton _btnDelete;

        internal DarkUI.Controls.DarkButton btnDelete
        {
            
            get
            {
                return _btnDelete;
            }

            
            set
            {
                if (_btnDelete != null)
                {
                }

                _btnDelete = value;
                if (_btnDelete != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkButton _btnSave;

        internal DarkUI.Controls.DarkButton btnSave
        {
            
            get
            {
                return _btnSave;
            }

            
            set
            {
                if (_btnSave != null)
                {
                }

                _btnSave = value;
                if (_btnSave != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbSpawnPeriod;

        internal DarkUI.Controls.DarkComboBox cmbSpawnPeriod
        {
            
            get
            {
                return _cmbSpawnPeriod;
            }

            
            set
            {
                if (_cmbSpawnPeriod != null)
                {
                }

                _cmbSpawnPeriod = value;
                if (_cmbSpawnPeriod != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel30;

        internal DarkUI.Controls.DarkLabel DarkLabel30
        {
            
            get
            {
                return _DarkLabel30;
            }

            
            set
            {
                if (_DarkLabel30 != null)
                {
                }

                _DarkLabel30 = value;
                if (_DarkLabel30 != null)
                {
                }
            }
        }
    }
}