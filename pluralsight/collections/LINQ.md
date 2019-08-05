LINQ is used for querying and extracting the data you want

Language Integrated Query

Limit results-
.Take(n) -> limits how many results taken

Redorder-
Alphabetical: .OrderBy(x=>x.Name)

.Where(x => !x.Name.Contains(','))

How does LINQ work?
Linq sees a collection as a data source
LINQ is made to enumerate
Interface IEnumerable<T> --O <-- used by LINQ method

LINQ query syntax- 
Complex queries become more readable

