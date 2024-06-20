

using linkedlist;
using System.Collections.Generic;

// Important Points =>

// 1. The LinkedList class implements the ICollection<T>,
// IEnumerable<T>, IReadOnlyCollection<T>, ICollection, IEnumerable,
// IDeserializationCallback, and ISerializable interfaces.

//2. It also supports enumerators.

//3. You can remove nodes and reinsert them,
//either in the same list or in another list, which results in no additional objects allocated on the heap.

//4. Every node in a LinkedList<T> object is of the type LinkedListNode<T>.

//5. It does not support chaining, splitting, cycles, or other features that can leave the list in an inconsistent state.

//6. If the LinkedList is empty, the First and Last properties contain null.

//7. The capacity of a LinkedList is the number of elements the LinkedList can hold.

//8. In LinkedList, it is allowed to store duplicate elements but of the same type.


//**********************************************************************************************//
//**********************************************************************************************//

// Creating a linkedlist
// Using LinkedList class

LinkedList<string> stringLinks = new LinkedList<string>();

//**********************************************************************************************//
// Adding elements in the LinkedList
// Using AddLast() method => To a new node or value at the end of the LinkedList.

stringLinks.AddLast("Daniel");
stringLinks.AddLast("Alice");
stringLinks.AddLast("Sheldon");
stringLinks.AddLast("Leonard");

//Adding new node at the start of the linked list => Using AddFirst()

 var newNode = stringLinks.AddFirst("Raj");


//The Add The Node Before Another Node Or After It
stringLinks.AddBefore(newNode, "Sheldon");

stringLinks.AddAfter(newNode, "Sheldon");

//**********************************************************************************************//


Console.WriteLine("Best Friends of mine!");

// Accessing the elements of 
// LinkedList Using foreach loop



//**********************************************************************************************//
//Remove The first Node Of the List :

stringLinks.Remove(stringLinks.First);

stringLinks.RemoveFirst();


//Remove specific Node :

stringLinks.Remove("Alice");

//remove The Last Element:

stringLinks.RemoveLast();


//Clear The Whole List :

stringLinks.Clear();

//**********************************************************************************************//


//Check The Existance Of A Node 

if (stringLinks.Contains("Negar") == true)
{
    Console.WriteLine("The Element Found!");
}
else
{
    Console.WriteLine("Not Found");
}

//**********************************************************************************************//
foreach (string link in stringLinks)
{
    Console.WriteLine(link);
}



