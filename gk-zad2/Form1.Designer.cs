namespace gk_zad2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.normalMapLoadButton = new System.Windows.Forms.Button();
            this.normalMapFromFileRadioButton = new System.Windows.Forms.RadioButton();
            this.simpleNormalMapRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bitmapLoadButton = new System.Windows.Forms.Button();
            this.textureColorButton = new System.Windows.Forms.Button();
            this.pictureFromFileRadioButton = new System.Windows.Forms.RadioButton();
            this.singlePictureColorRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mLabel = new System.Windows.Forms.Label();
            this.ksLabel = new System.Windows.Forms.Label();
            this.kdLabel = new System.Windows.Forms.Label();
            this.mSlider = new System.Windows.Forms.TrackBar();
            this.ksSlider = new System.Windows.Forms.TrackBar();
            this.kdSlider = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.animatedLightButton = new System.Windows.Forms.RadioButton();
            this.staticLightButton = new System.Windows.Forms.RadioButton();
            this.lightColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.interpolatedFillingButton = new System.Windows.Forms.RadioButton();
            this.detailedFillingButton = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.recreateMeshButton = new System.Windows.Forms.Button();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.showMeshradioButton = new System.Windows.Forms.RadioButton();
            this.hideMeshradioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerLsource = new System.ComponentModel.BackgroundWorker();
            this.reflektorCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdSlider)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1049, 604);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(852, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 598);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.normalMapLoadButton);
            this.groupBox2.Controls.Add(this.normalMapFromFileRadioButton);
            this.groupBox2.Controls.Add(this.simpleNormalMapRadioButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Normalna mapa";
            // 
            // normalMapLoadButton
            // 
            this.normalMapLoadButton.Location = new System.Drawing.Point(93, 43);
            this.normalMapLoadButton.Name = "normalMapLoadButton";
            this.normalMapLoadButton.Size = new System.Drawing.Size(75, 23);
            this.normalMapLoadButton.TabIndex = 4;
            this.normalMapLoadButton.Text = "wczytaj";
            this.normalMapLoadButton.UseVisualStyleBackColor = true;
            this.normalMapLoadButton.Click += new System.EventHandler(this.normalMapLoadButton_Click);
            // 
            // normalMapFromFileRadioButton
            // 
            this.normalMapFromFileRadioButton.AutoSize = true;
            this.normalMapFromFileRadioButton.Checked = true;
            this.normalMapFromFileRadioButton.Location = new System.Drawing.Point(13, 44);
            this.normalMapFromFileRadioButton.Name = "normalMapFromFileRadioButton";
            this.normalMapFromFileRadioButton.Size = new System.Drawing.Size(84, 17);
            this.normalMapFromFileRadioButton.TabIndex = 1;
            this.normalMapFromFileRadioButton.TabStop = true;
            this.normalMapFromFileRadioButton.Text = "mapa z pliku";
            this.normalMapFromFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // simpleNormalMapRadioButton
            // 
            this.simpleNormalMapRadioButton.AutoSize = true;
            this.simpleNormalMapRadioButton.Location = new System.Drawing.Point(13, 20);
            this.simpleNormalMapRadioButton.Name = "simpleNormalMapRadioButton";
            this.simpleNormalMapRadioButton.Size = new System.Drawing.Size(116, 17);
            this.simpleNormalMapRadioButton.TabIndex = 0;
            this.simpleNormalMapRadioButton.Text = "stały wektor [0,0,1]";
            this.simpleNormalMapRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bitmapLoadButton);
            this.groupBox1.Controls.Add(this.textureColorButton);
            this.groupBox1.Controls.Add(this.pictureFromFileRadioButton);
            this.groupBox1.Controls.Add(this.singlePictureColorRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitmapa";
            // 
            // bitmapLoadButton
            // 
            this.bitmapLoadButton.Location = new System.Drawing.Point(93, 43);
            this.bitmapLoadButton.Name = "bitmapLoadButton";
            this.bitmapLoadButton.Size = new System.Drawing.Size(75, 23);
            this.bitmapLoadButton.TabIndex = 3;
            this.bitmapLoadButton.Text = "wczytaj";
            this.bitmapLoadButton.UseVisualStyleBackColor = true;
            this.bitmapLoadButton.Click += new System.EventHandler(this.bitmapLoadButton_Click);
            // 
            // textureColorButton
            // 
            this.textureColorButton.BackColor = System.Drawing.Color.White;
            this.textureColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.textureColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textureColorButton.Location = new System.Drawing.Point(93, 17);
            this.textureColorButton.Margin = new System.Windows.Forms.Padding(8, 7, 3, 3);
            this.textureColorButton.Name = "textureColorButton";
            this.textureColorButton.Size = new System.Drawing.Size(20, 20);
            this.textureColorButton.TabIndex = 2;
            this.textureColorButton.UseVisualStyleBackColor = false;
            this.textureColorButton.Click += new System.EventHandler(this.textureColorButton_Click);
            // 
            // pictureFromFileRadioButton
            // 
            this.pictureFromFileRadioButton.AutoSize = true;
            this.pictureFromFileRadioButton.Checked = true;
            this.pictureFromFileRadioButton.Location = new System.Drawing.Point(13, 44);
            this.pictureFromFileRadioButton.Name = "pictureFromFileRadioButton";
            this.pictureFromFileRadioButton.Size = new System.Drawing.Size(84, 17);
            this.pictureFromFileRadioButton.TabIndex = 1;
            this.pictureFromFileRadioButton.TabStop = true;
            this.pictureFromFileRadioButton.Text = "obraz z pliku";
            this.pictureFromFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // singlePictureColorRadioButton
            // 
            this.singlePictureColorRadioButton.AutoSize = true;
            this.singlePictureColorRadioButton.Location = new System.Drawing.Point(13, 20);
            this.singlePictureColorRadioButton.Name = "singlePictureColorRadioButton";
            this.singlePictureColorRadioButton.Size = new System.Drawing.Size(74, 17);
            this.singlePictureColorRadioButton.TabIndex = 0;
            this.singlePictureColorRadioButton.Text = "stały kolor";
            this.singlePictureColorRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mLabel);
            this.groupBox3.Controls.Add(this.ksLabel);
            this.groupBox3.Controls.Add(this.kdLabel);
            this.groupBox3.Controls.Add(this.mSlider);
            this.groupBox3.Controls.Add(this.ksSlider);
            this.groupBox3.Controls.Add(this.kdSlider);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(4, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 134);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Współczynniki";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(128, 99);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(33, 13);
            this.mLabel.TabIndex = 5;
            this.mLabel.Text = "m = 1";
            // 
            // ksLabel
            // 
            this.ksLabel.AutoSize = true;
            this.ksLabel.Location = new System.Drawing.Point(128, 58);
            this.ksLabel.Name = "ksLabel";
            this.ksLabel.Size = new System.Drawing.Size(51, 13);
            this.ksLabel.TabIndex = 4;
            this.ksLabel.Text = "ks = 0.50";
            // 
            // kdLabel
            // 
            this.kdLabel.AutoSize = true;
            this.kdLabel.Location = new System.Drawing.Point(128, 19);
            this.kdLabel.Name = "kdLabel";
            this.kdLabel.Size = new System.Drawing.Size(52, 13);
            this.kdLabel.TabIndex = 3;
            this.kdLabel.Text = "kd = 0.50";
            // 
            // mSlider
            // 
            this.mSlider.Location = new System.Drawing.Point(0, 99);
            this.mSlider.Maximum = 100;
            this.mSlider.Minimum = 1;
            this.mSlider.Name = "mSlider";
            this.mSlider.Size = new System.Drawing.Size(129, 45);
            this.mSlider.TabIndex = 2;
            this.mSlider.Value = 1;
            this.mSlider.Scroll += new System.EventHandler(this.mSlider_Scroll);
            // 
            // ksSlider
            // 
            this.ksSlider.Location = new System.Drawing.Point(0, 58);
            this.ksSlider.Maximum = 100;
            this.ksSlider.Name = "ksSlider";
            this.ksSlider.Size = new System.Drawing.Size(129, 45);
            this.ksSlider.TabIndex = 1;
            this.ksSlider.Value = 50;
            this.ksSlider.Scroll += new System.EventHandler(this.ksSlider_Scroll);
            // 
            // kdSlider
            // 
            this.kdSlider.Location = new System.Drawing.Point(0, 19);
            this.kdSlider.Maximum = 100;
            this.kdSlider.Name = "kdSlider";
            this.kdSlider.Size = new System.Drawing.Size(129, 45);
            this.kdSlider.TabIndex = 0;
            this.kdSlider.Value = 50;
            this.kdSlider.Scroll += new System.EventHandler(this.kdSlider_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.reflektorCheckBox);
            this.groupBox4.Controls.Add(this.animatedLightButton);
            this.groupBox4.Controls.Add(this.staticLightButton);
            this.groupBox4.Controls.Add(this.lightColorButton);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 84);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Światło";
            // 
            // animatedLightButton
            // 
            this.animatedLightButton.AutoSize = true;
            this.animatedLightButton.Location = new System.Drawing.Point(13, 58);
            this.animatedLightButton.Name = "animatedLightButton";
            this.animatedLightButton.Size = new System.Drawing.Size(79, 17);
            this.animatedLightButton.TabIndex = 3;
            this.animatedLightButton.Text = "animowane";
            this.animatedLightButton.UseVisualStyleBackColor = true;
            this.animatedLightButton.Click += new System.EventHandler(this.animatedLightButton_Click);
            // 
            // staticLightButton
            // 
            this.staticLightButton.AutoSize = true;
            this.staticLightButton.Checked = true;
            this.staticLightButton.Location = new System.Drawing.Point(13, 35);
            this.staticLightButton.Name = "staticLightButton";
            this.staticLightButton.Size = new System.Drawing.Size(70, 17);
            this.staticLightButton.TabIndex = 2;
            this.staticLightButton.TabStop = true;
            this.staticLightButton.Text = "statyczne";
            this.staticLightButton.UseVisualStyleBackColor = true;
            this.staticLightButton.Click += new System.EventHandler(this.staticLightButton_Click);
            // 
            // lightColorButton
            // 
            this.lightColorButton.BackColor = System.Drawing.Color.White;
            this.lightColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.lightColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightColorButton.Location = new System.Drawing.Point(50, 15);
            this.lightColorButton.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lightColorButton.Name = "lightColorButton";
            this.lightColorButton.Size = new System.Drawing.Size(20, 20);
            this.lightColorButton.TabIndex = 1;
            this.lightColorButton.UseVisualStyleBackColor = false;
            this.lightColorButton.Click += new System.EventHandler(this.lightColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kolor:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.interpolatedFillingButton);
            this.groupBox5.Controls.Add(this.detailedFillingButton);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(4, 394);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(186, 67);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wypełnienie";
            // 
            // interpolatedFillingButton
            // 
            this.interpolatedFillingButton.AutoSize = true;
            this.interpolatedFillingButton.Location = new System.Drawing.Point(13, 42);
            this.interpolatedFillingButton.Name = "interpolatedFillingButton";
            this.interpolatedFillingButton.Size = new System.Drawing.Size(79, 17);
            this.interpolatedFillingButton.TabIndex = 1;
            this.interpolatedFillingButton.Text = "interpolacja";
            this.interpolatedFillingButton.UseVisualStyleBackColor = true;
            // 
            // detailedFillingButton
            // 
            this.detailedFillingButton.AutoSize = true;
            this.detailedFillingButton.Checked = true;
            this.detailedFillingButton.Location = new System.Drawing.Point(13, 19);
            this.detailedFillingButton.Name = "detailedFillingButton";
            this.detailedFillingButton.Size = new System.Drawing.Size(71, 17);
            this.detailedFillingButton.TabIndex = 0;
            this.detailedFillingButton.TabStop = true;
            this.detailedFillingButton.Text = "dokładne";
            this.detailedFillingButton.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.recreateMeshButton);
            this.groupBox6.Controls.Add(this.numericUpDownY);
            this.groupBox6.Controls.Add(this.numericUpDownX);
            this.groupBox6.Controls.Add(this.showMeshradioButton);
            this.groupBox6.Controls.Add(this.hideMeshradioButton);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(4, 468);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(186, 92);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Siatka";
            // 
            // recreateMeshButton
            // 
            this.recreateMeshButton.Location = new System.Drawing.Point(103, 63);
            this.recreateMeshButton.Name = "recreateMeshButton";
            this.recreateMeshButton.Size = new System.Drawing.Size(75, 23);
            this.recreateMeshButton.TabIndex = 4;
            this.recreateMeshButton.Text = "utwórz";
            this.recreateMeshButton.UseVisualStyleBackColor = true;
            this.recreateMeshButton.Click += new System.EventHandler(this.recreateMeshButton_Click);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(56, 65);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownY.TabIndex = 3;
            this.numericUpDownY.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(13, 65);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownX.TabIndex = 2;
            this.numericUpDownX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // showMeshradioButton
            // 
            this.showMeshradioButton.AutoSize = true;
            this.showMeshradioButton.Location = new System.Drawing.Point(13, 19);
            this.showMeshradioButton.Name = "showMeshradioButton";
            this.showMeshradioButton.Size = new System.Drawing.Size(55, 17);
            this.showMeshradioButton.TabIndex = 1;
            this.showMeshradioButton.Text = "Pokaż";
            this.showMeshradioButton.UseVisualStyleBackColor = true;
            // 
            // hideMeshradioButton
            // 
            this.hideMeshradioButton.AutoSize = true;
            this.hideMeshradioButton.Checked = true;
            this.hideMeshradioButton.Location = new System.Drawing.Point(13, 42);
            this.hideMeshradioButton.Name = "hideMeshradioButton";
            this.hideMeshradioButton.Size = new System.Drawing.Size(49, 17);
            this.hideMeshradioButton.TabIndex = 0;
            this.hideMeshradioButton.TabStop = true;
            this.hideMeshradioButton.Text = "Ukryj";
            this.hideMeshradioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(843, 598);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorkerLsource
            // 
            this.backgroundWorkerLsource.WorkerSupportsCancellation = true;
            this.backgroundWorkerLsource.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLsource_DoWork);
            // 
            // reflektorCheckBox
            // 
            this.reflektorCheckBox.AutoSize = true;
            this.reflektorCheckBox.Location = new System.Drawing.Point(99, 48);
            this.reflektorCheckBox.Name = "reflektorCheckBox";
            this.reflektorCheckBox.Size = new System.Drawing.Size(64, 17);
            this.reflektorCheckBox.TabIndex = 4;
            this.reflektorCheckBox.Text = "reflektor";
            this.reflektorCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 604);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "gk2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdSlider)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button normalMapLoadButton;
        private System.Windows.Forms.RadioButton normalMapFromFileRadioButton;
        private System.Windows.Forms.RadioButton simpleNormalMapRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lightColorButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bitmapLoadButton;
        private System.Windows.Forms.Button textureColorButton;
        private System.Windows.Forms.RadioButton pictureFromFileRadioButton;
        private System.Windows.Forms.RadioButton singlePictureColorRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label kdLabel;
        private System.Windows.Forms.TrackBar mSlider;
        private System.Windows.Forms.TrackBar ksSlider;
        private System.Windows.Forms.TrackBar kdSlider;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label ksLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton animatedLightButton;
        private System.Windows.Forms.RadioButton staticLightButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton interpolatedFillingButton;
        private System.Windows.Forms.RadioButton detailedFillingButton;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLsource;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton showMeshradioButton;
        private System.Windows.Forms.RadioButton hideMeshradioButton;
        private System.Windows.Forms.Button recreateMeshButton;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.CheckBox reflektorCheckBox;
    }
}

