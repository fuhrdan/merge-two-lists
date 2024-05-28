/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */

 //My original code was not working.  It showed the single digit answers, but did not
 // merge the lists.  This was copied from stack overflow to help learn the why
 // https://stackoverflow.com/questions/70915887/leetcodemerge-two-sorted-lists-i-dont-know-where-the-link-is-wrong
 // Credit for this assignment goes here.

struct ListNode* mergeTwoLists(struct ListNode* list1, struct ListNode* list2) {
    if(!list1&&!list2)
    {
        return NULL;
    }
    if(!list2)
    {
        return list1;
    }
    if(!list1)
    {
        return list2;
    }
    struct ListNode *head = NULL;
    struct ListNode **current = &head;

    struct ListNode* head1 = list1;
    struct ListNode* head2 = list2;

    while ( head1 && head2 )
    {
        if ( head2->val < head1->val )
        {
            *current = head2;
            head2 = head2->next;
        }
        else
        {
            *current = head1;
            head1 = head1->next;
        }

        current = &( *current )->next;
    }

    if ( head1 )
    {
        *current = head1;
    }
    else if ( head2 )
    {
        *current = head2;
    }

//    *list1 = NULL;
//    *list2 = NULL;

    return head;

}