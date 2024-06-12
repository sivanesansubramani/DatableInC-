using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DatatableInCsharp
{
    class CalculationsInDatatable
    {
        //created a student datatable and assign values
        public DataTable getStudentMarks()
        {
            DataTable dtStudentMarks = new DataTable();
            dtStudentMarks.Columns.Add("StudentId", typeof(int));
            dtStudentMarks.Columns.Add("StudentName", typeof(string));
            dtStudentMarks.Columns.Add("Tamil", typeof(int));
            dtStudentMarks.Columns.Add("English", typeof(int));
            dtStudentMarks.Columns.Add("Mathematics", typeof(int));
            dtStudentMarks.Columns.Add("Science", typeof(int));
            dtStudentMarks.Columns.Add("SocialScience", typeof(int));
            dtStudentMarks.Columns.Add("Total", typeof(int));
            dtStudentMarks.Columns.Add("Result", typeof(string));

            dtStudentMarks.Rows.Add(1, "Aaa", 85, 80, 88, 82, 80);
            dtStudentMarks.Rows.Add(2, "Bbbb", 78, 65, 68, 60, 55);
            dtStudentMarks.Rows.Add(3, "Cc", 90, 82, 89, 78, 83);
            dtStudentMarks.Rows.Add(4, "Ddd", 80, 38, 80, 81, 85);
            dtStudentMarks.Rows.Add(5, "Eeee", 90, 86, 99, 90, 87);
            dtStudentMarks.Rows.Add(6, "Fff", 70, 95, 85, 75, 80);
            dtStudentMarks.Rows.Add(7, "G", 92, 95, 100, 96, 93);
            dtStudentMarks.Rows.Add(8, "Hh", 81, 78, 90, 80, 77);
            dtStudentMarks.Rows.Add(9, "Iii", 68, 60, 39, 45, 50);
            dtStudentMarks.Rows.Add(10, "Jj", 80, 89, 82, 88, 90);
            return dtStudentMarks;
        }

        public DataTable FilterStudentMarks(DataTable dtStudentMarks)
        {
            // Clone the structure of the original DataTable
            DataTable dtFilteredMarks = dtStudentMarks.Clone();

            foreach (DataRow row in dtStudentMarks.Rows)
            {
                int tamil = Convert.ToInt32(row["Tamil"]);
                int english = Convert.ToInt32(row["English"]);
                int mathematics = Convert.ToInt32(row["Mathematics"]);
                int science = Convert.ToInt32(row["Science"]);
                int socialScience = Convert.ToInt32(row["SocialScience"]);

                // Calculate the total marks
                int total = tamil + english + mathematics + science + socialScience;
                row["Total"] = total;

                // Determine the result based on total marks
                string result = total >= 250 ? "Pass" : "Fail";
                row["Result"] = result;

                // Apply filter: students who scored more than 80 in all subjects
                if (tamil > 80 && english > 80 && mathematics > 80 && science > 80 && socialScience > 80)
                {
                    dtFilteredMarks.ImportRow(row);
                }
            }

            return dtFilteredMarks;
        }

        public void PrintDataTable(DataTable dt)
        {
            // Print column headers
            foreach (DataColumn column in dt.Columns)
            {
                Console.Write($"{column.ColumnName}\t");
            }
            Console.WriteLine();

            // Print rows
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write($"{item}\t");
                }
                Console.WriteLine();
                
            }

        }
    }
}
