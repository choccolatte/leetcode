public class Solution
{
	public LinkedListNode ReversedList(LinkedListNode head)
	{
		// using iteration
		LinkedListNode previous = null;
		LinkedListNode current = head;

		while(current != null)
		{
			LinkedListNode temp = current.Next;
			current.Next = previous;
			previous = current;
			current = temp;
		}

		return previous;

	}
}