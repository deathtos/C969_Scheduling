using C969_Scheduling.ProcessModels;

namespace C969_Scheduling.Helpers
{
    public class FileHelper
    {
        private readonly string _logFilePath;
        private readonly string _loginHistoryFileName;
        private readonly string _reportFileName = "report.csv";
        public FileHelper(AppSettings settings)
        {
            _logFilePath = Environment.CurrentDirectory;
            _loginHistoryFileName = settings.LoginHistoryFileName;
        }


        public void WriteToLoginHistoryFile(string content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Path.Combine(_logFilePath, _loginHistoryFileName), true))
                {
                    writer.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        public bool ExportReportToFile(DataGridView dgvReport)
        {
            try
            {
                if (dgvReport.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.");
                    return false;
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    Title = "Save Report",
                    FileName = _reportFileName
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string reportFileName = saveFileDialog.FileName;
                    WriteReportToFile(dgvReport);
                    MessageBox.Show("Report exported successfully.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Export cancelled.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report: {ex.Message}");
                return false;
            }
        }

        private void WriteReportToFile(DataGridView dgvReport)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_reportFileName))
                {
                    // Write the header
                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                    {
                        writer.Write(dgvReport.Columns[i].HeaderText);
                        if (i < dgvReport.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();
                    // Write the data
                    foreach (DataGridViewRow row in dgvReport.Rows)
                    {
                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            writer.Write(row.Cells[i].Value);
                            if (i < dgvReport.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing report to file: {ex.Message}");
            }
        }
    }
}
