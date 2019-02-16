// Code by Robert Kalmar 2017-2019
// More information at avp.robert-k.net
// More information at Github @pizzarobi
// Comments in German
// Methods begin Upper Case
// Objects / Attributes Lower Case

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
        bool vertret;
        bool allLessons = false;

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
        private void FillDataGrid(string Website, bool showAll)
        {
            //Während geladen wird, soll Warte-cursor gezeigt werden
            Cursor.Current = Cursors.WaitCursor;

            if (AutoLoadLessons() && CheckNet())
            {
                int Rows = 1;
                vertret = false;
                dataGrid.ColumnCount = 8;
                dataGrid.RowCount = Rows;

                var UngeradeZelle = new List<HtmlNode>();
                var GeradeZelle = new List<HtmlNode>();

                List<string> Strings = new List<string>();

                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc;

                //Versucht den Sourcecode der Website runterzuladen
                try
                {
                    doc = web.Load(Website);
                }catch
                {
                    Header.Text = "Error";
                    Mitteilungen.Text = "Keine Internetverbindung. Falls eine Internetverbindung besteht, überprüfe deine Firewall.";
                    doc = null;
                }

                //Versucht den Vertretungsplan und einzelne Elementa davon zu laden
                try
                {
                    Header.Text = doc.DocumentNode.SelectSingleNode("//h2[@class='TextUeberschrift']").InnerText;

                    try
                    {
                        Mitteilungen.Text = doc.DocumentNode.SelectSingleNode("//table[@class='TabelleMitteilung']").InnerText.Remove(0, 3).ToString();
                    }
                    catch
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
                catch
                {
                    Header.Text = "Vertretungsplan konnte nicht geladen werden.";
                }

                //Fügt die Elemente der Strings Liste hinzu
                foreach (var item in UngeradeZelle)
                {
                    Strings.Add(item.InnerText);
                }
                foreach (var item in GeradeZelle)
                {
                    Strings.Add(item.InnerText);
                }

                //Für alle Elemente in String wird überprüft, ob diese die Kurse aus der Liste beinhalten
                for (int i = 0; i < Strings.Count; i++)
                {
                    if(showAll)
                    {
                        //Zeigt alle Kurse an
                        dataGrid.RowCount = Rows++;  //Substring entfernt leerzeichen am Anfang von Kursen
                        dataGrid.Rows.Add(Strings[i++], Strings[i++], Strings[i++], Strings[i++], Strings[i++], Strings[i++], Strings[i++], Strings[i]);
                        
                        vertret = true;
                    }
                    else
                    {
                        for (int k = 0; k < Kurse.Count; k++)
                        {
                            //Strings[i].Contains(Kurse[k])
                            if(Strings[i].Length >=2)
                            {
                                //Substring entfernt leerzeichen am Anfang von Kursen
                                string Kurs = Strings[i].Substring(1);

                                if (Strings[i].Substring(1) == Kurse[k])
                                {
                                    dataGrid.RowCount = Rows++;

                                    dataGrid.Rows.Add(Strings[i++].Substring(1), Strings[i++], Strings[i++], Strings[i++], Strings[i++], Strings[i++], Strings[i++], Strings[i]);

                                    vertret = true;
                                }
                            }

                        }
                    }
                }

                if (vertret == false)
                {
                    dataGrid.Rows.Add("Keine Vertretungen");
                }

                ColumnName();

                if (showAll)
                {
                    dataGrid.Sort(dataGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                }
                else 
                {
                    dataGrid.Sort(dataGrid.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                }

            }else if(!CheckNet())
            {
                Header.Text = "Error";
                Mitteilungen.Text = "Bitte überprüfen Sie ihre Internetverbindung.";
            }else if(!File.Exists(@"Kurse.json"))
            {
                Header.Text = "Error";
                Mitteilungen.Text = "Fügen Sie bitte Kurse hinzu! Dies wird gemacht indem der Kursname in das Textfeld eingefügt wird, und die Taste Enter oder der Hinzufügen Knopf gedrückt wird.";
            }else
            {
                Header.Text = "Error";
                Mitteilungen.Text = "Diesen Fehler dürfte es normalerweise nicht geben! Bitte kontakrieren Sie den Entwickler und schicken sie ihm hiervon ein Bild. Pogchamp Out!";
            }

            //Wenn Methode fertig, soll wieder normaler Cursor angezeigt werden
            Cursor.Current = Cursors.WaitCursor;
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
        /// Aktualisiert und zeigt die Kurse an
        /// </summary>
        private void UpdateLessons()
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
        /// Lädt den Vertretungsplan von morgen
        /// </summary>
        private void LoadTableTomorrow_Click(object sender, EventArgs e)
        {
            FillDataGrid("http://www.hans-sachs-gymnasium.de/WocheHP/schuelerplan_morgen.htm", allLessons);
        }
        
        /// <summary>
        /// Lädt den Vertretungsplan von heute
        /// </summary>
        private void LoadTableToday_Click(object sender, EventArgs e)
        {
            FillDataGrid("http://www.hans-sachs-gymnasium.de/WocheHP/schuelerplan_heute.htm",allLessons);
        }
        
        /// <summary>
        /// Falls auf addLesson geklickt wird, wird ein neuer Kurs hinzugefügt
        /// </summary>
        private void AddLesson_Click(object sender, EventArgs e)
        {
            AddLessons();
        }
        
        /// <summary>
        /// Wenn Enter gedrückt ist, wird ein neuer Kurs hinzugefügt
        /// </summary>
        private void LessonName_KeyDown(object sender, KeyEventArgs e)
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
            if(lessonName.Text!="")
            {
                if (lessonName.Text.Contains("\r\n"))
                {
                    try
                    {
                        string Kurs = lessonName.Text.Substring(2);
                        Kurse.Add(Kurs);
                    }
                    catch { }
                }
                else
                {
                    Kurse.Add(lessonName.Text);
                }
                lessonName.ResetText();
            }

            SaveDataInJson();
            UpdateLessons();
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

        /// <summary>
        /// Zeigt eine kleine Nachricht
        /// </summary>
        private void MadeBy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmiert von Robert Kalmar http://www.github.com/Pizzarobi mithilfe von Microsoft Visual Studio."+ "\n" + "Und der Benutzung von Newtonsoft.Json und HtmlAgilityPack.\nIcon kreiert von Maxim Kalaschnikow\nEin Changelog befindet sich auf https://robert-k.net/projekte/avp/changelog/ . \n", "Version 1.0");
        }

        /// <summary>
        /// Zeigt die eingegebenen Kurse in der Tabelle an
        /// </summary>
        private void ShowLessons_Click(object sender, EventArgs e)
        {
            UpdateLessons();
        }

        /// <summary>
        /// Führt DeleteLessons() aus
        /// </summary>
        private void DeleteLessons_Click(object sender, EventArgs e)
        {
            DeleteLessons();
        }

        /// <summary>
        /// Löscht den eingegebenen Kurs und speichert die Liste neu ab
        /// </summary>
        private void DeleteLessons()
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
            UpdateLessons();
        }

        //Internet Connection Check
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        /// <summary>
        /// Überprüft ob der Computer mit dem Internet Verbunden
        /// </summary>
        /// <returns>Gibt True zurück wenn der Computer mit dem Internet verbunden ist</returns>
        public static bool CheckNet()
        {
            return InternetGetConnectedState(out int desc, 0);
        }

        /// <summary>
        /// Wenn ein Zelle angeklickt wird, soll der Inhalt dem Textfeld hinzugefügt werden
        /// </summary>
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lessonName.ResetText();
                lessonName.Text = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            catch
            {
                lessonName.Text = "";
            }
        }

        /// <summary>
        /// Überprüft ob die showAll Box geklickt wurde
        /// </summary>
        private void ShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (showAll.Checked)
            {
                allLessons = true;
            }
            else
            {
                allLessons = false;
            }
        }

        private void DataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lessonName.Text = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            catch
            {
                lessonName.Text = "";
            }
        }

        private void DataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteLessons();
            }
        }
    }
}