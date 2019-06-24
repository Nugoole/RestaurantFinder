using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class uscResultGrid
    {
        public List<DataGridViewColumn> columns { get; set; }
        public void MakePivotTable()
        {
            DataGridViewColumnCollection dataGridViewColumnCollection = new DataGridViewColumnCollection(gridResult);
            dataGridViewColumnCollection.AddRange(columns.ToArray());

        }

        public void  AddColumn(string colName)
        {
            DataGridViewColumn column = new DataGridViewColumn();

            column.Name = colName;

            columns.Add(column);
        }

    }
}
