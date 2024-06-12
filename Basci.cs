using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatableInCsharp
{
    class Basci
    {
        public void BasicsOfDatatable()
        {
            //creating a new datatable
            DataTable dtEmployee = new DataTable();

            //dt will be null untill we add columns and rows will add manually
            Console.WriteLine("Columns Count new dt: " + dtEmployee.Columns.Count);
            Console.WriteLine("Rows Count new dt: " + dtEmployee.Rows.Count);

            Console.WriteLine("");
            //this will add a new column with default name column 1
            dtEmployee.Columns.Add();

            //add a column with name and default val;ue for that column
            DataColumn colEmpName = new DataColumn();
            colEmpName.ColumnName = "EmpId";

            colEmpName.DefaultValue = 0;

            //another method of adding a new column with datatype
            dtEmployee.Columns.Add(colEmpName);

            dtEmployee.Columns.Add("EmpFirstName",typeof(string));

            dtEmployee.Columns.Add("EmpAge", typeof(int));

            //printing columns count in dt
            Console.WriteLine("Columns Count of dt After adding columns: "+ dtEmployee.Columns.Count);
            Console.WriteLine("");

            //printing column names in array position
            Console.WriteLine("0th Column Name: " + dtEmployee.Columns[0].ColumnName);
            Console.WriteLine("1st Column Name: " + dtEmployee.Columns[1].ColumnName);
            Console.WriteLine("2nd Column Name: " + dtEmployee.Columns[2].ColumnName);
            Console.WriteLine("3rd Column Name: " + dtEmployee.Columns[3].ColumnName);
            Console.WriteLine("");

            //printing columns name and their datatype in foreach loop
            foreach(DataColumn col in dtEmployee.Columns)
            {
                Console.WriteLine($"Column in loop:" +"  "+ col.ColumnName + "    " + col.DataType);
            }
            Console.WriteLine("");

            //remove a column and print datatble
            dtEmployee.Columns.Remove("Column1");

            foreach (DataColumn col in dtEmployee.Columns)
            {
                Console.WriteLine($"After Deleting:" + "  " + col.ColumnName);
            }
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
