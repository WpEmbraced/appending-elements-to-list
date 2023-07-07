// Statically defined list
List<int> myList = new List<int> { 2, 5, 6 };

// Appending using Add()
myList.Add(5);  // [2, 5, 6, 5]

// Appending using AddRange()
myList.AddRange(new List<int> { 9 });  // [2, 5, 6, 5, 9]

// Appending using Insert()
int elementToInsert = -4;
myList.Insert(myList.Count, elementToInsert);  // [2, 5, 6, 5, 9, -4]

// Appending using InsertRange()
List<int> elementsToInsert = new List<int> { 3 };
myList.InsertRange(myList.Count, elementsToInsert);  // [2, 5, 6, 5, 9, -4, 3]
