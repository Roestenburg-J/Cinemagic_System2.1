namespace Cinemagic
{
    partial class BookingID
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.cinemagicDBDataSet = new Cinemagic.CinemagicDBDataSet();
            this.bOOKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKINGTableAdapter = new Cinemagic.CinemagicDBDataSetTableAdapters.BOOKINGTableAdapter();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTicketCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsSaleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemagicDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.movieIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.totalTicketCostDataGridViewTextBoxColumn,
            this.numberOfSeatsDataGridViewTextBoxColumn,
            this.ticketsSaleDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bOOKINGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(68, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Display database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cinemagicDBDataSet
            // 
            this.cinemagicDBDataSet.DataSetName = "CinemagicDBDataSet";
            this.cinemagicDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKINGBindingSource
            // 
            this.bOOKINGBindingSource.DataMember = "BOOKING";
            this.bOOKINGBindingSource.DataSource = this.cinemagicDBDataSet;
            // 
            // bOOKINGTableAdapter
            // 
            this.bOOKINGTableAdapter.ClearBeforeFill = true;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // totalTicketCostDataGridViewTextBoxColumn
            // 
            this.totalTicketCostDataGridViewTextBoxColumn.DataPropertyName = "Total_TicketCost";
            this.totalTicketCostDataGridViewTextBoxColumn.HeaderText = "Total_TicketCost";
            this.totalTicketCostDataGridViewTextBoxColumn.Name = "totalTicketCostDataGridViewTextBoxColumn";
            // 
            // numberOfSeatsDataGridViewTextBoxColumn
            // 
            this.numberOfSeatsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.HeaderText = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.Name = "numberOfSeatsDataGridViewTextBoxColumn";
            // 
            // ticketsSaleDateDataGridViewTextBoxColumn
            // 
            this.ticketsSaleDateDataGridViewTextBoxColumn.DataPropertyName = "Tickets_SaleDate";
            this.ticketsSaleDateDataGridViewTextBoxColumn.HeaderText = "Tickets_SaleDate";
            this.ticketsSaleDateDataGridViewTextBoxColumn.Name = "ticketsSaleDateDataGridViewTextBoxColumn";
            // 
            // BookingID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookingID";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.BookingID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemagicDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private CinemagicDBDataSet cinemagicDBDataSet;
        private System.Windows.Forms.BindingSource bOOKINGBindingSource;
        private CinemagicDBDataSetTableAdapters.BOOKINGTableAdapter bOOKINGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTicketCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketsSaleDateDataGridViewTextBoxColumn;
    }
}