## What is DataTable?

- A DataTable is essentially a table of data, similar to a table you might find in a database or a spreadsheet. It consists of rows and columns.
- DataTable stores data in its in-memory.
- It can be used to store data retrieved from a database, or to create and manipulate data programmatically.
  
## What is DataColumn ?

- A DataColumn defines a column in a DataTable. It specifies the type of data that can be stored in that column, such as integers, strings, dates, etc.
- A DataColumn is like a single column in a table. It holds one type of information.

## What is DataSet ?

- A DataSet is a collection of DataTable objects. Think of it as a container that can hold multiple tables, along with their relationships. A DataSet can represent a complete set of data, including tables, their relations, and constraints.
  
```csharp
//Datatable Creating Syntax
DataTable dtEmployee = new DataTable();

```csharp
//Datacolumn creating Syntax
dtEmployee.Columns.Add();

DataColumn colEmpName = new DataColumn();
colEmpName.ColumnName = "EmpId";



```csharp
//Dataset Creating Syntax
DataSet dataSet = new DataSet("School");  // school dataset name
dataSet.Tables.Add(dtEmployee);.  // dtEmployee datatable name
