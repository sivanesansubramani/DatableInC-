using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatableInCsharp
{
    public class DatasetPro
    {
        public void DatasetDatatable()
        {
            // Creating the first DataTable for Students
            DataTable studentsTable = new DataTable("Students");

            // Adding columns to the Students DataTable
            DataColumn studentIdColumn = new DataColumn("StudentID", typeof(int));
            DataColumn studentNameColumn = new DataColumn("Name", typeof(string));
            DataColumn studentAgeColumn = new DataColumn("Age", typeof(int));

            studentsTable.Columns.Add(studentIdColumn);
            studentsTable.Columns.Add(studentNameColumn);
            studentsTable.Columns.Add(studentAgeColumn);

            // Adding rows to the Students DataTable
            DataRow studentRow1 = studentsTable.NewRow();
            studentRow1["StudentID"] = 1;
            studentRow1["Name"] = "John Doe";
            studentRow1["Age"] = 20;
            studentsTable.Rows.Add(studentRow1);

            DataRow studentRow2 = studentsTable.NewRow();
            studentRow2["StudentID"] = 2;
            studentRow2["Name"] = "Jane Smith";
            studentRow2["Age"] = 22;
            studentsTable.Rows.Add(studentRow2);

            // Creating the second DataTable for Courses
            DataTable coursesTable = new DataTable("Courses");

            // Adding columns to the Courses DataTable
            DataColumn courseIdColumn = new DataColumn("CourseID", typeof(int));
            DataColumn courseNameColumn = new DataColumn("CourseName", typeof(string));
            DataColumn studentIdFkColumn = new DataColumn("StudentID", typeof(int)); // Foreign key column

            coursesTable.Columns.Add(courseIdColumn);
            coursesTable.Columns.Add(courseNameColumn);
            coursesTable.Columns.Add(studentIdFkColumn);

            // Adding rows to the Courses DataTable
            DataRow courseRow1 = coursesTable.NewRow();
            courseRow1["CourseID"] = 101;
            courseRow1["CourseName"] = "Mathematics";
            courseRow1["StudentID"] = 1;
            coursesTable.Rows.Add(courseRow1);

            DataRow courseRow2 = coursesTable.NewRow();
            courseRow2["CourseID"] = 102;
            courseRow2["CourseName"] = "Physics";
            courseRow2["StudentID"] = 2;
            coursesTable.Rows.Add(courseRow2);

            // Creating a DataSet and adding both DataTables to it
            DataSet dataSet = new DataSet("School");
            dataSet.Tables.Add(studentsTable);
            dataSet.Tables.Add(coursesTable);

            // Displaying the Students DataTable
            Console.WriteLine("Students Table:");
            foreach (DataRow row in studentsTable.Rows)
            {
                Console.WriteLine($"StudentID: {row["StudentID"]}, Name: {row["Name"]}, Age: {row["Age"]}");
            }

            // Displaying the Courses DataTable
            Console.WriteLine("\nCourses Table:");
            foreach (DataRow row in coursesTable.Rows)
            {
                Console.WriteLine($"CourseID: {row["CourseID"]}, CourseName: {row["CourseName"]}, StudentID: {row["StudentID"]}");
            }
        }
    }
}
