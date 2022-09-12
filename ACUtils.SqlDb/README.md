# ACUtils.SqlDb

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


### QuerySingleValue

```csharp
using ACUtils;

ACUtils.SqlDb db = new ACUtils.SqlDb("Data Source=(local);Initial Catalog=master;Integrated Security=SSPI;");

string myvalue = db.QuerySingleValue<string>("SELECT myvalue FROM table WHERE id = @id", "@id".WithValue("123"));
Console.WriteLine(myvalue);
```


### QueryMany<T>

```csharp
using ACUtils;

class MyModel : ACUtils.DBModel<MyModel>
{
    public int id { get; set; }
    public string myvalue { get; set; }
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
    public int id { get; set; }
    public string myvalue { get; set; }
}

ACUtils.SqlDb db = new ACUtils.SqlDb("Data Source=(local);Initial Catalog=master;Integrated Security=SSPI;");
System.Collections.Generic.IAsyncEnumerable<MyModel> models = db.QueryManyAsync<MyModel>("select id, myvalue FROM table WHERE id > @id", "@id".WithValue(1));
await foreach (MyModel model in models)
{
    // ...
}
```

