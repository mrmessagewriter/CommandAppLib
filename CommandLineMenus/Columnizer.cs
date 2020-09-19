using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CommandLineMenus
{
    internal enum ColumnJustification
    {
        Left,
        Right,
        Center
    }

    internal class ColumnSetting
    {
        public int Width { get; }
        public ColumnJustification Justification { get; }
        public string ColumnName { get; }

        public ColumnSetting(int width,
                             ColumnJustification justification,
                             string columnName=null)
        {
            Width = width;
            Justification = justification;
            ColumnName = columnName;
        }
    }

    internal class Columnizer
    {
        internal string columnSeparator = "|";
        internal string rowSeparator = "";
        internal string headerSeparator = "";
        internal string tableBorder = "";
        internal List<ColumnSetting> columns = null;
        internal List<List<string>> rows = new List<List<string>>() { };

        public Columnizer(List<ColumnSetting> columns, string tableBorder="", string columnSeparator="|", string rowSeparator="", string headerSeparator="=")
        {
            this.columnSeparator = columnSeparator;
            this.headerSeparator = headerSeparator;
            this.rowSeparator = rowSeparator;
            this.tableBorder = tableBorder;
            this.columns = columns;
        }

        public void AddRow(List<string> rowsList) => this.rows.Add(rowsList);

        public List<string> GenerateColumns(bool includeHeaderNames = false)
        {
            List<List<string>> sizedRows = new List<List<string>>() {};

            //Do a simple split of the string, into "column" sized chunks per line.
            int colIndex = -1;
            
            foreach (List<string> row in this.rows)
            {
                colIndex += 1;
                List<string> sizedRow = new List<string>();

                foreach (string colText in row)
                {

                }

            }
        }
    }
}
