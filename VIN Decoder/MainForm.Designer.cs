namespace VIN_Decoder {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.VinTextBox = new System.Windows.Forms.TextBox();
			this.DecodeBtn = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.LabelChassis = new System.Windows.Forms.TextBox();
			this.LabelManufacturer = new System.Windows.Forms.TextBox();
			this.LabelMake = new System.Windows.Forms.TextBox();
			this.LabelType = new System.Windows.Forms.TextBox();
			this.LabelLine = new System.Windows.Forms.TextBox();
			this.LabelSeries = new System.Windows.Forms.TextBox();
			this.LabelBody = new System.Windows.Forms.TextBox();
			this.LabelModelYear = new System.Windows.Forms.TextBox();
			this.LabelAssemblyPlant = new System.Windows.Forms.TextBox();
			this.LabelVehID = new System.Windows.Forms.TextBox();
			this.LabelDisplacement = new System.Windows.Forms.TextBox();
			this.LabelEngineManufactuerer = new System.Windows.Forms.TextBox();
			this.LabelCylinders = new System.Windows.Forms.TextBox();
			this.LabelFuel = new System.Windows.Forms.TextBox();
			this.LabelNetHP = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// VinTextBox
			// 
			this.VinTextBox.Location = new System.Drawing.Point(12, 12);
			this.VinTextBox.Name = "VinTextBox";
			this.VinTextBox.Size = new System.Drawing.Size(293, 26);
			this.VinTextBox.TabIndex = 0;
			// 
			// DecodeBtn
			// 
			this.DecodeBtn.Location = new System.Drawing.Point(311, 12);
			this.DecodeBtn.Name = "DecodeBtn";
			this.DecodeBtn.Size = new System.Drawing.Size(75, 26);
			this.DecodeBtn.TabIndex = 1;
			this.DecodeBtn.Text = "Decode";
			this.DecodeBtn.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 44);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(374, 362);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.LabelVehID);
			this.tabPage1.Controls.Add(this.LabelAssemblyPlant);
			this.tabPage1.Controls.Add(this.LabelModelYear);
			this.tabPage1.Controls.Add(this.LabelBody);
			this.tabPage1.Controls.Add(this.LabelSeries);
			this.tabPage1.Controls.Add(this.LabelLine);
			this.tabPage1.Controls.Add(this.LabelType);
			this.tabPage1.Controls.Add(this.LabelMake);
			this.tabPage1.Controls.Add(this.LabelManufacturer);
			this.tabPage1.Controls.Add(this.LabelChassis);
			this.tabPage1.Controls.Add(this.label15);
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.label13);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(366, 329);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Vehicle";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.LabelNetHP);
			this.tabPage2.Controls.Add(this.LabelFuel);
			this.tabPage2.Controls.Add(this.LabelCylinders);
			this.tabPage2.Controls.Add(this.LabelEngineManufactuerer);
			this.tabPage2.Controls.Add(this.LabelDisplacement);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(366, 329);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Engine";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Manufacturer";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(120, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Make";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(125, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Type";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(129, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Line";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(114, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Series";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(103, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Chassis";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(123, 202);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "Body";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(27, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(141, 20);
			this.label8.TabIndex = 3;
			this.label8.Text = "Displacement/Litre";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(95, 41);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 20);
			this.label9.TabIndex = 4;
			this.label9.Text = "Cylinders";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(128, 76);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 20);
			this.label10.TabIndex = 5;
			this.label10.Text = "Fuel";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(64, 105);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(104, 20);
			this.label11.TabIndex = 6;
			this.label11.Text = "Manufacturer";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(54, 137);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(114, 20);
			this.label12.TabIndex = 7;
			this.label12.Text = "Net Brake H.P.";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(78, 234);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(90, 20);
			this.label13.TabIndex = 7;
			this.label13.Text = "Model Year";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(51, 266);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(117, 20);
			this.label14.TabIndex = 8;
			this.label14.Text = "Assembly Plant";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 298);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(162, 20);
			this.label15.TabIndex = 9;
			this.label15.Text = "Sequential Vehicle ID";
			// 
			// LabelChassis
			// 
			this.LabelChassis.Location = new System.Drawing.Point(174, 167);
			this.LabelChassis.Name = "LabelChassis";
			this.LabelChassis.ReadOnly = true;
			this.LabelChassis.Size = new System.Drawing.Size(186, 26);
			this.LabelChassis.TabIndex = 10;
			// 
			// LabelManufacturer
			// 
			this.LabelManufacturer.Location = new System.Drawing.Point(174, 6);
			this.LabelManufacturer.Name = "LabelManufacturer";
			this.LabelManufacturer.ReadOnly = true;
			this.LabelManufacturer.Size = new System.Drawing.Size(186, 26);
			this.LabelManufacturer.TabIndex = 11;
			// 
			// LabelMake
			// 
			this.LabelMake.Location = new System.Drawing.Point(174, 38);
			this.LabelMake.Name = "LabelMake";
			this.LabelMake.ReadOnly = true;
			this.LabelMake.Size = new System.Drawing.Size(186, 26);
			this.LabelMake.TabIndex = 12;
			// 
			// LabelType
			// 
			this.LabelType.Location = new System.Drawing.Point(174, 70);
			this.LabelType.Name = "LabelType";
			this.LabelType.ReadOnly = true;
			this.LabelType.Size = new System.Drawing.Size(186, 26);
			this.LabelType.TabIndex = 13;
			// 
			// LabelLine
			// 
			this.LabelLine.Location = new System.Drawing.Point(174, 103);
			this.LabelLine.Name = "LabelLine";
			this.LabelLine.ReadOnly = true;
			this.LabelLine.Size = new System.Drawing.Size(186, 26);
			this.LabelLine.TabIndex = 14;
			// 
			// LabelSeries
			// 
			this.LabelSeries.Location = new System.Drawing.Point(174, 135);
			this.LabelSeries.Name = "LabelSeries";
			this.LabelSeries.ReadOnly = true;
			this.LabelSeries.Size = new System.Drawing.Size(186, 26);
			this.LabelSeries.TabIndex = 15;
			// 
			// LabelBody
			// 
			this.LabelBody.Location = new System.Drawing.Point(174, 199);
			this.LabelBody.Name = "LabelBody";
			this.LabelBody.ReadOnly = true;
			this.LabelBody.Size = new System.Drawing.Size(186, 26);
			this.LabelBody.TabIndex = 16;
			// 
			// LabelModelYear
			// 
			this.LabelModelYear.Location = new System.Drawing.Point(174, 231);
			this.LabelModelYear.Name = "LabelModelYear";
			this.LabelModelYear.ReadOnly = true;
			this.LabelModelYear.Size = new System.Drawing.Size(186, 26);
			this.LabelModelYear.TabIndex = 17;
			// 
			// LabelAssemblyPlant
			// 
			this.LabelAssemblyPlant.Location = new System.Drawing.Point(174, 263);
			this.LabelAssemblyPlant.Name = "LabelAssemblyPlant";
			this.LabelAssemblyPlant.ReadOnly = true;
			this.LabelAssemblyPlant.Size = new System.Drawing.Size(186, 26);
			this.LabelAssemblyPlant.TabIndex = 18;
			// 
			// LabelVehID
			// 
			this.LabelVehID.Location = new System.Drawing.Point(174, 295);
			this.LabelVehID.Name = "LabelVehID";
			this.LabelVehID.ReadOnly = true;
			this.LabelVehID.Size = new System.Drawing.Size(186, 26);
			this.LabelVehID.TabIndex = 19;
			// 
			// LabelDisplacement
			// 
			this.LabelDisplacement.Location = new System.Drawing.Point(174, 6);
			this.LabelDisplacement.Name = "LabelDisplacement";
			this.LabelDisplacement.ReadOnly = true;
			this.LabelDisplacement.Size = new System.Drawing.Size(186, 26);
			this.LabelDisplacement.TabIndex = 11;
			// 
			// LabelEngineManufactuerer
			// 
			this.LabelEngineManufactuerer.Location = new System.Drawing.Point(174, 102);
			this.LabelEngineManufactuerer.Name = "LabelEngineManufactuerer";
			this.LabelEngineManufactuerer.ReadOnly = true;
			this.LabelEngineManufactuerer.Size = new System.Drawing.Size(186, 26);
			this.LabelEngineManufactuerer.TabIndex = 12;
			// 
			// LabelCylinders
			// 
			this.LabelCylinders.Location = new System.Drawing.Point(174, 38);
			this.LabelCylinders.Name = "LabelCylinders";
			this.LabelCylinders.ReadOnly = true;
			this.LabelCylinders.Size = new System.Drawing.Size(186, 26);
			this.LabelCylinders.TabIndex = 12;
			// 
			// LabelFuel
			// 
			this.LabelFuel.Location = new System.Drawing.Point(174, 70);
			this.LabelFuel.Name = "LabelFuel";
			this.LabelFuel.ReadOnly = true;
			this.LabelFuel.Size = new System.Drawing.Size(186, 26);
			this.LabelFuel.TabIndex = 13;
			// 
			// LabelNetHP
			// 
			this.LabelNetHP.Location = new System.Drawing.Point(174, 134);
			this.LabelNetHP.Name = "LabelNetHP";
			this.LabelNetHP.ReadOnly = true;
			this.LabelNetHP.Size = new System.Drawing.Size(186, 26);
			this.LabelNetHP.TabIndex = 14;
			// 
			// MainForm
			// 
			this.AcceptButton = this.DecodeBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 414);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.DecodeBtn);
			this.Controls.Add(this.VinTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox VinTextBox;
		private System.Windows.Forms.Button DecodeBtn;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox LabelVehID;
		private System.Windows.Forms.TextBox LabelAssemblyPlant;
		private System.Windows.Forms.TextBox LabelModelYear;
		private System.Windows.Forms.TextBox LabelBody;
		private System.Windows.Forms.TextBox LabelSeries;
		private System.Windows.Forms.TextBox LabelLine;
		private System.Windows.Forms.TextBox LabelType;
		private System.Windows.Forms.TextBox LabelMake;
		private System.Windows.Forms.TextBox LabelManufacturer;
		private System.Windows.Forms.TextBox LabelChassis;
		private System.Windows.Forms.TextBox LabelNetHP;
		private System.Windows.Forms.TextBox LabelFuel;
		private System.Windows.Forms.TextBox LabelCylinders;
		private System.Windows.Forms.TextBox LabelEngineManufactuerer;
		private System.Windows.Forms.TextBox LabelDisplacement;
	}
}