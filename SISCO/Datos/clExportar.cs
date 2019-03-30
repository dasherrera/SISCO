using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;


namespace SISCO.Datos
{
    class clExportar
    {
        public void ExportarExcel(DataGridView dgv)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xlsx )|*.xls";
                fichero.FileName = "ArchivoExportado";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application App;
                    Microsoft.Office.Interop.Excel.Workbook Libro;
                    Microsoft.Office.Interop.Excel.Worksheet Hoja;
                    App = new Microsoft.Office.Interop.Excel.Application();
                    Libro = App.Workbooks.Add();
                    Hoja = (Microsoft.Office.Interop.Excel.Worksheet)Libro.Worksheets.get_Item(1);
                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            if ((dgv.Rows[i].Cells[j].Value == null) == false)
                            {
                                Hoja.Cells[i + 1, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    Libro.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    Libro.Close(true);
                    App.Quit();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al exportar el error debido a:" + Ex.ToString());

            }
        }
    }
}
