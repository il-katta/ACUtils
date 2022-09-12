# ACUtils.SqlDb

Helpers functions to query MSSQL databases


## Example usage


### QueryDataSet

```csharp
using System.Data;
using ACUtils;

ACUtils.SqlDb db = new ACUtils.SqlDb("Data Source=(local);Initial Catalog=master;Integrated Security=SSPI;");

System.Data.DataSet ds = db.QueryDataSet(
    "SELECT myvalue FROM table WHERE col = @col AND id > @id", 
    "@col".WithValue("my val"),
    "@id".WithValue(123)
);
Console.WriteLine(ds.Tables[0].Rows[0].Field<string>("myvalue"));
```


### QueryDataTable

```csharp
using System.Data;
using ACUtils;

ACUtils.SqlDb db = new ACUtils.SqlDb("Data Source=(local);Initial Catalog=master;Integrated Security=SSPI;");

System.Data.DataTable dt = db.QueryDataTable("SELECT myvalue FROM table WHERE col = @col", "@col".WithValue("my val"));
Console.WriteLine(dt.Rows[0].Field<string>("myvalue"));
```


### QueryDataRow

```csharp
using System.Data;
using ACUtils;

ACUtils.SqlDb db = new ACUtils.SqlDb("Data Source=(local);Initial Catalog=master;Integrated Security=SSPI;");
try {
    System.Data.DataRow dr = db.QueryDataRow("SELECT myvalue FROM table WHERE id = @id", "@id".WithValue("123"));
    Console.WriteLine(dr.Field<string>("myvalue"));
}
catch (ACUtils.Exceptions.NotFoundException)
{
    // when DataTable.Rows.Count == 0
}
catch (ACUtils.Exceptions.TooMuchResultsException)
{
    // when DataTable.Rows.Count > 1
}

```


### QuerySingleValue

```csharp
using ACUtils;

ACUtils.SqlDb db = new ACUtils.SqlDb("Data Source=(local);Initial Catalog=master;Integrated Security=SSPI;");
try
{
    string myvalue = db.QuerySingleValue<string>("SELECT myvalue FROM table WHERE id = @id", "@id".WithValue("123"));
    Console.WriteLine(myvalue);
}
catch (ACUtils.Exceptions.NotFoundException)
{
    // when DataTable.Rows.Count == 0
}
catch (ACUtils.Exceptions.TooMuchResultsException)
{
    // when DataTable.Rows.Count > 1
}
```


### QueryMany<T>

```csharp
using ACUtils;

class MyModel : ACUtils.DBModel<MyModel>
{
    public int id { get; set; } // create a property with same name of table column
    [DbField("myvalue")] // property can be also named different
    public string anotherName { get; set; }
}

ACUtils.SqlDb db = new ACUtils.SqlDb("Data Source=(local);Initial Catalog=master;Integrated Security=SSPI;");
System.Collections.Generic.List<MyModel> models = db.QueryMany<MyModel>("select id, myvalue FROM table WHERE id > @id", "@id".WithValue(1));
foreach(MyModel model in models) 
{
    // ...
}
```


### QueryManyAsync<T>

```csharp
using ACUtils;

class MyModel : ACUtils.DBModel<MyModel>
{
    public int id { get; set; } // create a property with same name of table column
    [DbField("myvalue")] // property can be also named different
    public string anotherName { get; set; }
}

ACUtils.SqlDb db = new ACUtils.SqlDb("Data Source=(local);Initial Catalog=master;Integrated Security=SSPI;");
System.Collections.Generic.IAsyncEnumerable<MyModel> models = db.QueryManyAsync<MyModel>("select id, myvalue FROM table WHERE id > @id", "@id".WithValue(1));
await foreach (MyModel model in models)
{
    // ...
}
```

