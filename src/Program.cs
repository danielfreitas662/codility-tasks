using Task;

var l1array = new[] { 9,9,9,9,9,9,9};
var l2array = new[] { 9,9,9,9 };

ListNode l1 = new(l1array[0]);
ListNode l2 = new(l2array[0]);
var curr = l1;
for (int i = 1; i < l1array.Length; i++)
{
    curr.next = new ListNode(l1array[i]);
    curr = curr.next;
}
curr = l2;
for (int i = 1; i < l2array.Length; i++)
{
    curr.next = new ListNode(l2array[i]);
    curr = curr.next;
}
var result = AddTwoNumbersChallenge.AddTwoNumbers(l1, l2);

while (result != null)
{
    Console.Write($"{result.val} -> ");
    result = result.next;
}
