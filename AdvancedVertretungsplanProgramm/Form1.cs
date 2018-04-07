using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace AdvancedVertretungsplanProgramm
{
    public partial class Form1 : Form
    {
        private List<string> Kurse = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        /// <summary>
        /// Erstellt und füllt das DataGrid
        /// </summary>
        /// <param name="Website">Website von der die Dateien geholt werden sollen (morgen oder übermorgen)</param>
        private void FillDataGrid(string Website)
        {
            if (AutoLoadLessons() && CheckNet())
            {
                int Rows = 1;
                bool vertret = false;
                dataGrid.ColumnCount = 8;
                dataGrid.RowCount = Rows;

                var UngeradeZelle = new List<HtmlNode>();
                var GeradeZelle = new List<HtmlNode>();

                List<string> Strings = new List<string>();

                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(Website);

                if (doc.DocumentNode.SelectSingleNode("//h2[@class='TextUeberschrift']") != null)
                {
                    Header.Text = doc.DocumentNode.SelectSingleNode("//h2[@class='TextUeberschrift']").InnerText;

                    if (doc.DocumentNode.SelectSingleNode("//table[@class='TabelleMitteilung']") != null)
                    {
                        Mitteilungen.Text = doc.DocumentNode.SelectSingleNode("//table[@class='TabelleMitteilung']").InnerText.Remove(0, 3).ToString();
                    }
                    else
                    { Mitteilungen.Text = null; }

                    if (doc.DocumentNode.SelectNodes("//td[@class='UngeradeZelleTabelleVertretungen']") != null)
                    {
                        UngeradeZelle = doc.DocumentNode.SelectNodes("//td[@class='UngeradeZelleTabelleVertretungen']").ToList();
                    }

                    if (doc.DocumentNode.SelectNodes("//td[@class='ZelleGeradeTabelleVertretungen']") != null)
                    {
                        GeradeZelle = doc.DocumentNode.SelectNodes("//td[@class='ZelleGeradeTabelleVertretungen']").ToList();
                    }
                }
                else
                {
                    Header.Text = "Vertretungsplan konnte nicht geladen werden.";
                }

                foreach (var item in UngeradeZelle)
                {
                    Strings.Add(item.InnerText);
                }
                foreach (var item in GeradeZelle)
                {
                    Strings.Add(item.InnerText);
                }

                for (int i = 0; i < Strings.Count; i++)
                {
                    for (int k = 0; k < Kurse.Count; k++)
                    {
                        if (Strings[i].Contains(Kurse[k]))
                        {
                            dataGrid.RowCount = Rows++;
                            dataGrid.Rows.Add(Strings[i], Strings[++i], Strings[++i], Strings[++i], Strings[++i], Strings[++i], Strings[++i], Strings[++i]);
                            vertret = true;
                        }
                    }
                }

                if (vertret == false)
                {
                    dataGrid.Rows.Add("Keine Vertretungen");
                }

                ColumnName();
                dataGrid.Sort(dataGrid.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            }else {
                Header.Text = "Error";
                Mitteilungen.Text = "Bitte Überprüfe deine Internetverbindung.";
            }
        }

        /// <summary>
        /// Speichert die Kurse in einer JSON Datei ab
        /// </summary>
        private void SaveDataInJson()
        {
            using (StreamWriter file = File.CreateText(@"Kurse.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Kurse);
            }
        }

        /// <summary>
        /// Lädt die Kurse aus einer JSON Datei
        /// </summary>
        private void LoadJson()
        {
            Kurse.Clear();

            using (StreamReader reader = new StreamReader("Kurse.json"))
            {
                string json = reader.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);

                foreach(var item in array)
                {
                    Kurse.Add(item.ToString());
                }
            }
        }

        /// <summary>
        /// Gibt den Spalten Namen
        /// </summary>
        private void ColumnName()
        {
            dataGrid.Columns[0].Name = "Klasse";
            dataGrid.Columns[1].Name = "Stunde";
            dataGrid.Columns[2].Name = "Vertretung";
            dataGrid.Columns[3].Name = "Fach";
            dataGrid.Columns[4].Name = "statt";
            dataGrid.Columns[5].Name = "Lehrer";
            dataGrid.Columns[6].Name = "Raum";
            dataGrid.Columns[7].Name = "Sonstiges";
        }

        /// <summary>
        /// Lädt den Vertretungsplan von morgen
        /// </summary>
        private void loadTableTomorrow_Click(object sender, EventArgs e)
        {
            FillDataGrid("http://www.hans-sachs-gymnasium.de/WocheHP/schuelerplan_morgen.htm");
        }
        
        /// <summary>
        /// Lädt den Vertretungsplan von heute
        /// </summary>
        private void LoadTableToday_Click(object sender, EventArgs e)
        {
            FillDataGrid("http://www.hans-sachs-gymnasium.de/WocheHP/schuelerplan_heute.htm");
        }
        
        private void addLesson_Click(object sender, EventArgs e)
        {
            AddLessons();
        }
        
        private void lessonName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddLessons();
            }
        }

        /// <summary>
        /// Fügt Kurse der Liste Kurse hinzu
        /// </summary>
        private void AddLessons()
        {
            Kurse.Add(lessonName.Text);
            lessonName.ResetText();
        }

        /// <summary>
        /// Überprüft ob eine Kursliste bereits besteht und lädt sie dann
        /// </summary>
        /// <returns>Gibt einen Boolean ob die Kursliste besteht zurück</returns>
        private bool AutoLoadLessons()
        {
            if (File.Exists(@"Kurse.json"))
            {
                LoadJson();
                return true;
            }
            else
            {
                MessageBox.Show("Es besteht keine Kursliste. Erstelle eine Kursliste und speichere sie ab.");
                return false;
            }
        }

        private void saveData_Click(object sender, EventArgs e)
        {
            SaveDataInJson();
            MessageBox.Show("Die Kurse wurden erfolgreich in Kurse.json abgespeichert.");
        }

        private void madeBy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmiert von Robert Kalmar mithilfe von Microsoft Visual Studio."+ "\n" +"Und der Benutzung von Newtonsoft.Json und HtmlAgilityPack.\nEin Changelog befindet sich auf http://avp.robert-k.net","Version Beta 0.8");
        }

        /// <summary>
        /// Zeigt die eingegebenen Kurse in der Tabelle an
        /// </summary>
        private void ShowLessons_Click(object sender, EventArgs e)
        {
            int Rows = 1;
            dataGrid.ColumnCount = 1;
            dataGrid.RowCount = Rows;
            dataGrid.Columns[0].Name = "Kurse";

            if (AutoLoadLessons())
            {
                LoadJson();

                for (int i = 0; i < Kurse.Count; i++)
                {
                    dataGrid.RowCount = Rows++;
                    dataGrid.Rows.Add(Kurse[i]);
                }
            }
        }

        /// <summary>
        /// Löscht den eingegebenen Kurs und speichert die Liste neu ab
        /// </summary>
        private void deleteLessons_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Kurse.Count; i++)
            {
                if (Kurse[i] == lessonName.Text)
                {
                    Kurse.RemoveAt(i);
                    lessonName.ResetText();
                    SaveDataInJson();
                }
            }
        }

        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool CheckNet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }
    }
}