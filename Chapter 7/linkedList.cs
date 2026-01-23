/* Create: LinkedList<string> songChain = new();

Start: Add "Song A" as the First item.

End: Add "Song C" as the Last item.

Insert:

Find the node for "Song A": LinkedListNode<string> nodeA = songChain.Find("Song A");

Add "Song B" After node A: songChain.AddAfter(nodeA, "Song B");

Loop: Print the chain. It should be: Song A, Song B, Song C. */

using System;
using System.Transactions;

class Program
{
	static void Main()
	{
		LinkedList<string> 	songChain = new();

        songChain.AddFirst("A");
        songChain.AddLast("C");

        LinkedListNode<string> nodeA = songChain.Find("A");

        songChain.AddAfter(nodeA, "B");

        //easy way
        foreach(string song in songChain)
        {
            Console.WriteLine(song);
        }

        //manual way
        LinkedListNode<string> current = songChain.First;

        while(current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        } 
        
    }	
}