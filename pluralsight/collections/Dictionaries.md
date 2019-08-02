Dictionaries -- 
Allow you to look up items using a key
great for unordered data

key -> item

Definition: 
Dictionary<TKey, TValue>

Instantiate:
Dictionary<type, object> identity = new Dictionary<type, object>();
or
var identity = new Dictionary<type, object>();


Dictionary Methods:
.Add(key, value) ex. .Add("NOR", norway)


Look up dictionary item with key

Object identity = dictionaryname["Key"];

Console.WriteLine (identity.property);

Enumerating Dictionaries:
foreach (var item in dictionaryname)
    item.key
    item.values


Dictionary initializers are built into visual studio


Finding specific items:
bool exists = dictionary.TryGetValue("Key", out Type name);

