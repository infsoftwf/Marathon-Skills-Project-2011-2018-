using MarathonProject.INF_TOOLS;
using MarathonProject.Properties;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;
using static MarathonProject.Global.SqlEx;

namespace MarathonProject.Forms
{
    public partial class ImportVolunteers : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        String g_PathFileCSV = String.Empty;
        public ImportVolunteers()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void ImportVolunteers_Load(object sender, EventArgs e)
        {
            mainThread = new Thread(() =>
            {
                while (true)
                {
                    DateTime eTime;
                    DateTime.TryParse(s_GlobalMarathonDate, out eTime);
                    var resultTime = eTime.Subtract(DateTime.Now);
                    if (lbEndTime.InvokeRequired && !lbEndTime.IsDisposed)
                    {
                        if (resultTime > TimeSpan.Zero)
                            lbEndTime.BeginInvoke((MethodInvoker)(() => lbEndTime.Text = getTime(resultTime)));

                        lbEndTime.BeginInvoke((MethodInvoker)(() => lbEndTime.Location = new Point((this.Size.Width - lbEndTime.Size.Width) / 2, 16)));
                    }
                    Thread.Sleep(1000);
                }
            })
            {
                IsBackground = true,
                Priority = ThreadPriority.Lowest
            };
            mainThread.Start();
        }

        bool bInit = false;
        private void btLoad_Click(object sender, EventArgs e)
        {
            if (!bInit)
            {
                bInit = true;

                new Thread(() =>
                {
                    try
                    {
                        btLoad.Invoke(new MethodInvoker(() => btLoad.Enabled = false));

                        if (!ValidateCsv(g_PathFileCSV, new Tuple<string, int, string[]>("volunteerid,firstname,lastname,countrycode,gender", 5, new String[] { "Male", "Female" })))
                        {
                            MessageBox.Show(this, "Неверный формат CSV файла!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btLoad.Invoke(new MethodInvoker(() => btLoad.Enabled = true));
                            Thread.CurrentThread.Abort();
                            return;
                        }

                        var pDataTable = GetDataTabletFromCSVFile(g_PathFileCSV);

                        cntRead.Invoke(new MethodInvoker(() => cntRead.Text = pDataTable.Rows.Count.ToString()));

                        long i_countref = 0;
                        for (int i = 0; i < pDataTable.Rows.Count; i++)
                        {
                            var exattr = MyAttributeExists<int>($@"SELECT [VolunteerId] FROM [Volunteer] WHERE VolunteerId = '{pDataTable.Rows[i][0].ToString()}'", sqlConnection);
                            if (exattr < 1)
                            {
                                if (MyAttributeQuery($@"SET IDENTITY_INSERT [Volunteer] ON; INSERT INTO [Volunteer] (VolunteerId,FirstName,LastName,CountryCode,Gender) VALUES ('{pDataTable.Rows[i][0]}', '{pDataTable.Rows[i][1].ToString()}', '{pDataTable.Rows[i][2].ToString()}', '{pDataTable.Rows[i][3].ToString()}', '{pDataTable.Rows[i][4].ToString()}')", sqlConnection) > 0)
                                    i_countref++;
                            }
                            else
                            {
                                if (MyAttributeQuery($@"UPDATE [Volunteer] SET FirstName = '{pDataTable.Rows[i][1].ToString()}', LastName = '{pDataTable.Rows[i][2].ToString()}', CountryCode = '{pDataTable.Rows[i][3].ToString()}', Gender = '{pDataTable.Rows[i][4].ToString()}' WHERE VolunteerId = '{exattr}'", sqlConnection) > 0)
                                    i_countref++;
                            }
                            cntimpt.Invoke(new MethodInvoker(() => cntimpt.Text = i_countref.ToString()));
                        }
                    }
                    catch (Exception ex)
                    {
                        btLoad.Invoke(new MethodInvoker(() => btLoad.Enabled = true));

                        MessageBox.Show(ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Thread.CurrentThread.Abort();
                        return;
                    }

                    bInit = false;
                    btLoad.Invoke(new MethodInvoker(() => btLoad.Enabled = true));
                    Thread.CurrentThread.Abort();
                }).Start();
            }
        }

        private static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            var csvData = new DataTable();
            try
            {
                using (var csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        var datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                                fieldData[i] = null;
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return csvData;
        }

        public bool ValidateCsv(string file, Tuple<String, int, String[]> hPattern)
        {
            if (!File.Exists(file))
                return false;

            var rpm = File.ReadAllText(file);
            if (rpm.Length == 0)
                return false;

            var fileLines = rpm.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            if (fileLines.Count() < 2)
                return false;

            if (fileLines[0].Trim().Replace(" ", null).ToLower() != hPattern.Item1)
                return false;

            foreach (var row in fileLines.Skip(1))
            {
                var cells = row.Split(',');

                if (cells[0] != null && cells.Length != hPattern.Item2)
                    return false;

                foreach (var cmp in hPattern.Item3)
                    if (cells[4] == cmp)
                    return true;
            }

            return false;
        }

        private void btLoadVol_Click(object sender, EventArgs e)
        {
            using (var m_ofd = new OpenFileDialog() { Filter = "CSV files (*.csv) | *.csv", ValidateNames = true })
            {
                if (m_ofd.ShowDialog().Equals(DialogResult.OK))
                {
                    g_PathFileCSV = m_ofd.FileName;
                    txFile.Text = Path.GetFileName(m_ofd.FileName);              
                }
            }
        }

        private void methodExit()
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<MainMenu>().Single().Show();

            INFAPI.__forceExit(typeof(MainMenu));
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<VolunteerManager>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void butlogout_Click(object sender, EventArgs e) => methodExit();

        private void ImportVolunteers_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<VolunteerManager>().Single().Show();

            this.Dispose();
            this.Close();
        }
    }
}

