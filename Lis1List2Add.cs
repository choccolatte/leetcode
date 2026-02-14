class Solution
{
	public LinkedListNode MergeTwoLists(ListNoda List1, LinkedListNode List2)
	{
		if(List1 == null)
		{
			return List2;
		}
		if(List2 == null)
		{
			return List2;
		}

		if(List1.val <= List2.val)
		{
			List1.next = MergeTwoLists(List1.next, List2);
			return List1;
		}
		else
		{
			List2.next = MergeTwoLists(List1, List2.next);
			return List2;
		}
	}
}