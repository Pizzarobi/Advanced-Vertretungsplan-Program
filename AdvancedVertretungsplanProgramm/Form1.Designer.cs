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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGrid.Location = new System.Drawing.Point(12, 156);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(906, 273);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // loadTableTomorrow
            // 
            this.loadTableTomorrow.Location = new System.Drawing.Point(12, 479);
            this.loadTableTomorrow.Name = "loadTableTomorrow";
            this.loadTableTomorrow.Size = new System.Drawing.Size(165, 38);
            this.loadTableTomorrow.TabIndex = 1;
            this.loadTableTomorrow.Text = "Vertretungsplan von morgen laden";
            this.loadTableTomorrow.UseVisualStyleBackColor = true;
            this.loadTableTomorrow.Click += new System.EventHandler(this.loadTableTomorrow_Click);
            // 
            // lessonName
            // 
            this.lessonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonName.Location = new System.Drawing.Point(12, 435);
            this.lessonName.Multiline = true;
            this.lessonName.Name = "lessonName";
            this.lessonName.Size = new System.Drawing.Size(165, 38);
            this.lessonName.TabIndex = 2;
            this.lessonName.Text = "Kursname";
            this.lessonName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lessonName_KeyDown);
            // 
            // addLesson
            // 
            this.addLesson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addLesson.Location = new System.Drawing.Point(184, 435);
            this.addLesson.Name = "addLesson";
            this.addLesson.Size = new System.Drawing.Size(111, 38);
            this.addLesson.TabIndex = 3;
            this.addLesson.Text = "Kurs Hinzufügen";
            this.addLesson.UseVisualStyleBackColor = true;
            this.addLesson.Click += new System.EventHandler(this.addLesson_Click);
            // 
            // LoadTableToday
            // 
            this.LoadTableToday.Location = new System.Drawing.Point(184, 479);
            this.LoadTableToday.Name = "LoadTableToday";
            this.LoadTableToday.Size = new System.Drawing.Size(165, 38);
            this.LoadTableToday.TabIndex = 6;
            this.LoadTableToday.Text = "Vertretungsplan von heute laden";
            this.LoadTableToday.UseVisualStyleBackColor = true;
            this.LoadTableToday.Click += new System.EventHandler(this.LoadTableToday_Click);
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(930, 34);
            this.Header.TabIndex = 7;
            this.Header.Text = "Vertretungsplan für ...";
            // 
            // Mitteilungen
            // 
            this.Mitteilungen.Cursor = System.Windows.Forms.Cursors.Default;
            this.Mitteilungen.Location = new System.Drawing.Point(13, 38);
            this.Mitteilungen.Multiline = true;
            this.Mitteilungen.Name = "Mitteilungen";
            this.Mitteilungen.ReadOnly = true;
            this.Mitteilungen.Size = new System.Drawing.Size(905, 112);
            this.Mitteilungen.TabIndex = 8;
            // 
            // madeBy
            // 
            this.madeBy.AutoSize = true;
            this.madeBy.Location = new System.Drawing.Point(800, 503);
            this.madeBy.Name = "madeBy";
            this.madeBy.Size = new System.Drawing.Size(118, 13);
            this.madeBy.TabIndex = 9;
            this.madeBy.Text = "Made by Robert Kalmar";
            this.madeBy.Click += new System.EventHandler(this.madeBy_Click);
            // 
            // ShowLessons
            // 
            this.ShowLessons.Location = new System.Drawing.Point(355, 479);
            this.ShowLessons.Name = "ShowLessons";
            this.ShowLessons.Size = new System.Drawing.Size(111, 38);
            this.ShowLessons.TabIndex = 10;
            this.ShowLessons.Text = "Kurse Anzeigen";
            this.ShowLessons.UseVisualStyleBackColor = true;
            this.ShowLessons.Click += new System.EventHandler(this.ShowLessons_Click);
            // 
            // deleteLessons
            // 
            this.deleteLessons.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteLessons.Location = new System.Drawing.Point(301, 434);
            this.deleteLessons.Name = "deleteLessons";
            this.deleteLessons.Size = new System.Drawing.Size(111, 38);
            this.deleteLessons.TabIndex = 11;
            this.deleteLessons.Text = "Kurs Entfernen";
            this.deleteLessons.UseVisualStyleBackColor = true;
            this.deleteLessons.Click += new System.EventHandler(this.deleteLessons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 525);
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
    }
}

