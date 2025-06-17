namespace KickBlast
{
    partial class Search_Deails
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
            this.components = new System.ComponentModel.Container();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.athletesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._sepriyankara_KickblastDataSet = new KickBlast._sepriyankara_KickblastDataSet();
            this.athletesDetailsTableAdapter = new KickBlast._sepriyankara_KickblastDataSetTableAdapters.AthletesDetailsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.athleteRegnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dObDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athletesDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._sepriyankara_KickblastDataSet4 = new KickBlast._sepriyankara_KickblastDataSet4();
            this.athletesDetailsTableAdapter1 = new KickBlast._sepriyankara_KickblastDataSet4TableAdapters.AthletesDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.athletesDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._sepriyankara_KickblastDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athletesDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._sepriyankara_KickblastDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.Font = new System.Drawing.Font("Humnst777 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(627, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 33);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Humnst777 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(345, 54);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 33);
            this.txtSearch.TabIndex = 1;
            // 
            // athletesDetailsBindingSource
            // 
            this.athletesDetailsBindingSource.DataMember = "AthletesDetails";
            this.athletesDetailsBindingSource.DataSource = this._sepriyankara_KickblastDataSet;
            // 
            // _sepriyankara_KickblastDataSet
            // 
            this._sepriyankara_KickblastDataSet.DataSetName = "_sepriyankara_KickblastDataSet";
            this._sepriyankara_KickblastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // athletesDetailsTableAdapter
            // 
            this.athletesDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(60, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Athlete Regno";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::KickBlast.Properties.Resources.images__8_3;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1371, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 47);
            this.btnExit.TabIndex = 27;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClear.Font = new System.Drawing.Font("Humnst777 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(777, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 33);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightGreen;
            this.btnHome.Font = new System.Drawing.Font("Humnst777 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(931, 53);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 33);
            this.btnHome.TabIndex = 29;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AutoGenerateColumns = false;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.athleteRegnoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dObDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.contactnoDataGridViewTextBoxColumn});
            this.dataGridViewSearch.DataSource = this.athletesDetailsBindingSource1;
            this.dataGridViewSearch.Location = new System.Drawing.Point(72, 157);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 51;
            this.dataGridViewSearch.RowTemplate.Height = 24;
            this.dataGridViewSearch.Size = new System.Drawing.Size(1243, 193);
            this.dataGridViewSearch.TabIndex = 30;
            // 
            // athleteRegnoDataGridViewTextBoxColumn
            // 
            this.athleteRegnoDataGridViewTextBoxColumn.DataPropertyName = "AthleteRegno";
            this.athleteRegnoDataGridViewTextBoxColumn.HeaderText = "AthleteRegno";
            this.athleteRegnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.athleteRegnoDataGridViewTextBoxColumn.Name = "athleteRegnoDataGridViewTextBoxColumn";
            this.athleteRegnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dObDataGridViewTextBoxColumn
            // 
            this.dObDataGridViewTextBoxColumn.DataPropertyName = "DOb";
            this.dObDataGridViewTextBoxColumn.HeaderText = "DOb";
            this.dObDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dObDataGridViewTextBoxColumn.Name = "dObDataGridViewTextBoxColumn";
            this.dObDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactnoDataGridViewTextBoxColumn
            // 
            this.contactnoDataGridViewTextBoxColumn.DataPropertyName = "Contactno";
            this.contactnoDataGridViewTextBoxColumn.HeaderText = "Contactno";
            this.contactnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactnoDataGridViewTextBoxColumn.Name = "contactnoDataGridViewTextBoxColumn";
            this.contactnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // athletesDetailsBindingSource1
            // 
            this.athletesDetailsBindingSource1.DataMember = "AthletesDetails";
            this.athletesDetailsBindingSource1.DataSource = this._sepriyankara_KickblastDataSet4;
            // 
            // _sepriyankara_KickblastDataSet4
            // 
            this._sepriyankara_KickblastDataSet4.DataSetName = "_sepriyankara_KickblastDataSet4";
            this._sepriyankara_KickblastDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // athletesDetailsTableAdapter1
            // 
            this.athletesDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // Search_Deails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KickBlast.Properties.Resources._360_F_378584401_6bI0pLsok2utTyrfTvcGhjsSD4KvXm1T;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1434, 450);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "Search_Deails";
            this.Text = "Search_Deails";
            this.Load += new System.EventHandler(this.Search_Deails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.athletesDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._sepriyankara_KickblastDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athletesDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._sepriyankara_KickblastDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private _sepriyankara_KickblastDataSet _sepriyankara_KickblastDataSet;
        private System.Windows.Forms.BindingSource athletesDetailsBindingSource;
        private _sepriyankara_KickblastDataSetTableAdapters.AthletesDetailsTableAdapter athletesDetailsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private _sepriyankara_KickblastDataSet4 _sepriyankara_KickblastDataSet4;
        private System.Windows.Forms.BindingSource athletesDetailsBindingSource1;
        private _sepriyankara_KickblastDataSet4TableAdapters.AthletesDetailsTableAdapter athletesDetailsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteRegnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dObDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnoDataGridViewTextBoxColumn;
    }
}