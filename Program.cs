using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DatatableInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //clas for data set example program
            DatasetPro obj3 = new DatasetPro();
            obj3.DatasetDatatable();
            Console.ReadLine();


            //filetrations datatable
            //CalculationsInDatatable obj2 = new CalculationsInDatatable();

            //DataTable dtStudentMarks = obj2.getStudentMarks();
            //DataTable dtFilteredMarks = obj2.FilterStudentMarks(dtStudentMarks);

            //Console.WriteLine("Original Student Marks:");
            //obj2.PrintDataTable(dtStudentMarks);

            //Console.WriteLine("\nFiltered Student Marks:");
            //obj2.PrintDataTable(dtFilteredMarks);
            //Console.ReadLine();



            //object for basics of datatable
            // Basci obj1 = new Basci();
            // obj1.BasicsOfDatatable();
        }
    }
}
