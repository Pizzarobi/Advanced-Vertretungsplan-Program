namespace AdvancedVertretungsplanProgramm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.loadTableTomorrow = new System.Windows.Forms.Button();
            this.lessonName = new System.Windows.Forms.TextBox();
            this.addLesson = new System.Windows.Forms.Button();
            this.LoadTableToday = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.Mitteilungen = new System.Windows.Forms.TextBox();
            this.madeBy = new System.Windows.Forms.Label();
            this.ShowLessons = new System.Windows.Forms.Button();
            this.deleteLessons = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.debugLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGrid.Location = new System.Drawing.Point(12, 156);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(868, 257);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            this.dataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellEnter);
            this.dataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGrid_KeyDown);
            // 
            // loadTableTomorrow
            // 
            this.loadTableTomorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadTableTomorrow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loadTableTomorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadTableTomorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTableTomorrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTableTomorrow.Location = new System.Drawing.Point(12, 467);
            this.loadTableTomorrow.Name = "loadTableTomorrow";
            this.loadTableTomorrow.Size = new System.Drawing.Size(165, 38);
            this.loadTableTomorrow.TabIndex = 1;
            this.loadTableTomorrow.Text = "Vertretungsplan von morgen laden";
            this.loadTableTomorrow.UseVisualStyleBackColor = false;
            this.loadTableTomorrow.Click += new System.EventHandler(this.LoadTableTomorrow_Click);
            // 
            // lessonName
            // 
            this.lessonName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lessonName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lessonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lessonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lessonName.Location = new System.Drawing.Point(12, 425);
            this.lessonName.MaxLength = 10;
            this.lessonName.Name = "lessonName";
            this.lessonName.Size = new System.Drawing.Size(165, 31);
            this.lessonName.TabIndex = 2;
            this.lessonName.Text = "Kursname";
            this.toolTip1.SetToolTip(this.lessonName, "Kurskennung hier eingeben!\r\nz.B. 2d3");
            this.lessonName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LessonName_KeyDown);
            // 
            // addLesson
            // 
            this.addLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addLesson.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addLesson.Cursor = System.Windows.Forms.Cursors.Default;
            this.addLesson.FlatAppearance.BorderSize = 0;
            this.addLesson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLesson.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addLesson.Location = new System.Drawing.Point(184, 423);
            this.addLesson.Name = "addLesson";
            this.addLesson.Size = new System.Drawing.Size(111, 38);
            this.addLesson.TabIndex = 3;
            this.addLesson.Text = "Kurs Hinzufügen";
            this.toolTip1.SetToolTip(this.addLesson, "Fügt Kurs hinzu (Enter)");
            this.addLesson.UseVisualStyleBackColor = false;
            this.addLesson.Click += new System.EventHandler(this.AddLesson_Click);
            // 
            // LoadTableToday
            // 
            this.LoadTableToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadTableToday.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoadTableToday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadTableToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTableToday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadTableToday.Location = new System.Drawing.Point(184, 467);
            this.LoadTableToday.Name = "LoadTableToday";
            this.LoadTableToday.Size = new System.Drawing.Size(165, 38);
            this.LoadTableToday.TabIndex = 6;
            this.LoadTableToday.Text = "Vertretungsplan von heute laden";
            this.LoadTableToday.UseVisualStyleBackColor = false;
            this.LoadTableToday.Click += new System.EventHandler(this.LoadTableToday_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Header.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(892, 35);
            this.Header.TabIndex = 7;
            this.Header.Text = "Vertretungsplan für ...";
            // 
            // Mitteilungen
            // 
            this.Mitteilungen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mitteilungen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Mitteilungen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mitteilungen.Cursor = System.Windows.Forms.Cursors.Default;
            this.Mitteilungen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mitteilungen.Location = new System.Drawing.Point(13, 38);
            this.Mitteilungen.Multiline = true;
            this.Mitteilungen.Name = "Mitteilungen";
            this.Mitteilungen.ReadOnly = true;
            this.Mitteilungen.Size = new System.Drawing.Size(867, 112);
            this.Mitteilungen.TabIndex = 8;
            // 
            // madeBy
            // 
            this.madeBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.madeBy.AutoSize = true;
            this.madeBy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.madeBy.Location = new System.Drawing.Point(762, 483);
            this.madeBy.Name = "madeBy";
            this.madeBy.Size = new System.Drawing.Size(118, 13);
            this.madeBy.TabIndex = 9;
            this.madeBy.Text = "Made by Robert Kalmar";
            this.madeBy.Click += new System.EventHandler(this.MadeBy_Click);
            // 
            // ShowLessons
            // 
            this.ShowLessons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowLessons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ShowLessons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLessons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowLessons.Location = new System.Drawing.Point(418, 423);
            this.ShowLessons.Name = "ShowLessons";
            this.ShowLessons.Size = new System.Drawing.Size(111, 38);
            this.ShowLessons.TabIndex = 10;
            this.ShowLessons.Text = "Kurse Anzeigen";
            this.ShowLessons.UseVisualStyleBackColor = false;
            this.ShowLessons.Click += new System.EventHandler(this.ShowLessons_Click);
            // 
            // deleteLessons
            // 
            this.deleteLessons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteLessons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteLessons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLessons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteLessons.Location = new System.Drawing.Point(301, 423);
            this.deleteLessons.Name = "deleteLessons";
            this.deleteLessons.Size = new System.Drawing.Size(111, 38);
            this.deleteLessons.TabIndex = 11;
            this.deleteLessons.Text = "Kurs Entfernen";
            this.toolTip1.SetToolTip(this.deleteLessons, "Entfernt Kurs (Entf)");
            this.deleteLessons.UseVisualStyleBackColor = false;
            this.deleteLessons.Click += new System.EventHandler(this.DeleteLessons_Click);
            // 
            // showAll
            // 
            this.showAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showAll.AutoSize = true;
            this.showAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showAll.Location = new System.Drawing.Point(355, 479);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(154, 17);
            this.showAll.TabIndex = 12;
            this.showAll.Text = "Alle Vertretungen Anzeigen";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.CheckedChanged += new System.EventHandler(this.ShowAll_CheckedChanged);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(30, 15);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(39, 13);
            this.debugLabel.TabIndex = 13;
            this.debugLabel.Text = "Debug";
            this.debugLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(892, 513);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.deleteLessons);
            this.Controls.Add(this.ShowLessons);
            this.Controls.Add(this.madeBy);
            this.Controls.Add(this.Mitteilungen);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.LoadTableToday);
            this.Controls.Add(this.addLesson);
            this.Controls.Add(this.lessonName);
            this.Controls.Add(this.loadTableTomorrow);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(652, 360);
            this.Name = "Form1";
            this.Text = "Advanced Vertretungsplan Programm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button loadTableTomorrow;
        private System.Windows.Forms.TextBox lessonName;
        private System.Windows.Forms.Button addLesson;
        private System.Windows.Forms.Button LoadTableToday;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox Mitteilungen;
        private System.Windows.Forms.Label madeBy;
        private System.Windows.Forms.Button ShowLessons;
        private System.Windows.Forms.Button deleteLessons;
        private System.Windows.Forms.CheckBox showAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label debugLabel;
    }
}

