namespace Tasks;


public class ListNode{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null){
        this.val = val;
        this.next = next;
    }

}
public static class AddTwoNumbersChallenge{

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2){
        ListNode result = new(0);
        ListNode ptr = result;
        int carry = 0;
        while(l1 != null || l2 != null){
            int sum = carry;
            if(l1 != null){
                sum += l1.val;
                l1 = l1.next;
            }
            if(l2 != null){
                sum += l2.val;
                l2 = l2.next;
            }
            
            carry = sum / 10;
            sum %= 10;

            ptr.next = new ListNode(sum);
            ptr = ptr.next;
        }
        if (carry == 1) ptr.next = new ListNode(1);
        return result.next;
    }
}