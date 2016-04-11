namespace Text_Recognition
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.surface = new System.Windows.Forms.Panel();
            this.trainButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.Untrain = new System.Windows.Forms.Button();
            this.untrainAllButton = new System.Windows.Forms.Button();
            this.symbolSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.symbolDisplayLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.probabilityDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // surface
            // 
            this.surface.BackColor = System.Drawing.Color.White;
            this.surface.Location = new System.Drawing.Point(6, 110);
            this.surface.Name = "surface";
            this.surface.Size = new System.Drawing.Size(256, 256);
            this.surface.TabIndex = 0;
            // 
            // trainButton
            // 
            this.trainButton.BackColor = System.Drawing.Color.White;
            this.trainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainButton.ForeColor = System.Drawing.Color.Teal;
            this.trainButton.Location = new System.Drawing.Point(6, 3);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(152, 29);
            this.trainButton.TabIndex = 1;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = false;
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.White;
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testButton.ForeColor = System.Drawing.Color.Teal;
            this.testButton.Location = new System.Drawing.Point(6, 75);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(152, 29);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = false;
            // 
            // Untrain
            // 
            this.Untrain.BackColor = System.Drawing.Color.White;
            this.Untrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Untrain.ForeColor = System.Drawing.Color.Teal;
            this.Untrain.Location = new System.Drawing.Point(6, 38);
            this.Untrain.Name = "Untrain";
            this.Untrain.Size = new System.Drawing.Size(66, 29);
            this.Untrain.TabIndex = 3;
            this.Untrain.Text = "Untrain";
            this.Untrain.UseVisualStyleBackColor = false;
            // 
            // untrainAllButton
            // 
            this.untrainAllButton.BackColor = System.Drawing.Color.White;
            this.untrainAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.untrainAllButton.ForeColor = System.Drawing.Color.Teal;
            this.untrainAllButton.Location = new System.Drawing.Point(89, 38);
            this.untrainAllButton.Name = "untrainAllButton";
            this.untrainAllButton.Size = new System.Drawing.Size(69, 29);
            this.untrainAllButton.TabIndex = 4;
            this.untrainAllButton.Text = "Untrain all";
            this.untrainAllButton.UseVisualStyleBackColor = false;
            // 
            // symbolSelector
            // 
            this.symbolSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.symbolSelector.FormattingEnabled = true;
            this.symbolSelector.Location = new System.Drawing.Point(227, 8);
            this.symbolSelector.Name = "symbolSelector";
            this.symbolSelector.Size = new System.Drawing.Size(35, 21);
            this.symbolSelector.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Symbol";
            // 
            // symbolDisplayLabel
            // 
            this.symbolDisplayLabel.AutoSize = true;
            this.symbolDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbolDisplayLabel.ForeColor = System.Drawing.Color.White;
            this.symbolDisplayLabel.Location = new System.Drawing.Point(188, 32);
            this.symbolDisplayLabel.Name = "symbolDisplayLabel";
            this.symbolDisplayLabel.Size = new System.Drawing.Size(40, 42);
            this.symbolDisplayLabel.TabIndex = 7;
            this.symbolDisplayLabel.Text = "?";
            this.symbolDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.ForeColor = System.Drawing.Color.Teal;
            this.clearButton.Location = new System.Drawing.Point(174, 76);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 29);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // probabilityDataGrid
            // 
            this.probabilityDataGrid.AllowUserToAddRows = false;
            this.probabilityDataGrid.AllowUserToDeleteRows = false;
            this.probabilityDataGrid.AllowUserToResizeRows = false;
            this.probabilityDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.probabilityDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.probabilityDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.probabilityDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.probabilityDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.probabilityDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.probabilityDataGrid.ColumnHeadersVisible = false;
            this.probabilityDataGrid.GridColor = System.Drawing.Color.White;
            this.probabilityDataGrid.Location = new System.Drawing.Point(268, 38);
            this.probabilityDataGrid.Name = "probabilityDataGrid";
            this.probabilityDataGrid.ReadOnly = true;
            this.probabilityDataGrid.RowHeadersVisible = false;
            this.probabilityDataGrid.Size = new System.Drawing.Size(120, 328);
            this.probabilityDataGrid.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Probability";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(394, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.probabilityDataGrid);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.symbolDisplayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.symbolSelector);
            this.Controls.Add(this.untrainAllButton);
            this.Controls.Add(this.Untrain);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.surface);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "A-Reco";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel surface;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button Untrain;
        private System.Windows.Forms.Button untrainAllButton;
        private System.Windows.Forms.ComboBox symbolSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label symbolDisplayLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView probabilityDataGrid;
        private System.Windows.Forms.Label label2;
    }
}

