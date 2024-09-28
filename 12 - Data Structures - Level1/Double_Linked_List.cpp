#include<iostream>
using namespace std;
class Node
{
public:
    int Value;
    Node* Next;
    Node* Prev;
};
Node* CreationNode(int Value)
    {
        Node* NewNode=new Node();
        NewNode->Value=Value;
        NewNode->Next=NULL;
        NewNode->Prev=NULL;
        return NewNode;
    }
    void InsertAtBeginning(Node* &Head,int value)
    {
        Node* NewNode=CreationNode(value);

            NewNode->Next=Head;
            NewNode->Prev=NULL;
            if(Head!=NULL)
            {
                Head->Prev=NewNode;
            }
            Head=NewNode;
    }
    void PrintList(Node* Head)
    {
        while(Head!=NULL)
        {
            printf("%d   ",Head->Value);
            Head=Head->Next;
        }
        printf("\n");
    }

void PrintNodeDetails(Node* head)
{

    if (head->Prev != NULL)
        cout << head->Prev->Value;
    else
        cout << "NULL";

    cout << " <--> " << head->Value << " <--> ";

    if (head->Next != NULL)
        cout << head->Next->Value << "\n";
    else
        cout << "NULL";

}

void PrintListDetails(Node* head)
{
    cout << "\n\n";
    while (head != NULL) {
        PrintNodeDetails(head);
        head = head->Next;
    }
}

Node *Find(Node* Head, int Value)
{

    while (Head != NULL) {

        if (Head->Value == Value)
            return Head;


        Head = Head->Next;
    }

    return NULL;

}


 void InsertAfter(Node* Prev_Node,int value)
{
     Node* NewNode=CreationNode(value);
     if(Prev_Node==NULL)
        return;

     NewNode->Next= Prev_Node->Next;
     NewNode->Prev=Prev_Node;

     if( Prev_Node->Next!=NULL)
        Prev_Node->Next->Prev=NewNode;

     Prev_Node->Next=NewNode;


}

 void InsertAtEnd(Node* &Head,int value)
 {
     Node* NewNode=CreationNode(value);
     if(Head==NULL)
     {
         Head=NewNode;
         return;
     }

      Node* Last_Node=Head;
      while(Last_Node->Next!=NULL)
      {
          Last_Node=Last_Node->Next;
      }
      Last_Node->Next=NewNode;
      NewNode->Prev=Last_Node;

 }

 void DeleteNode(Node* &Head ,Node* &NodeToDelete)
{
    if(Head==NULL || NodeToDelete==NULL )
        return;
    if(Head==NodeToDelete)
        Head=NodeToDelete->Next;

    if(NodeToDelete->Next!=NULL)
       NodeToDelete->Next->Prev=NodeToDelete->Prev;

    if(NodeToDelete->Prev!=NULL)
       NodeToDelete->Prev->Next=NodeToDelete->Next;


     delete NodeToDelete;

}

void DeleteFirstNode(Node* &Head)
{
    if(Head==NULL)
        return;
    Node* First_Node =Head;
    Head=First_Node->Next;
    if(Head!=NULL)
        Head->Prev=NULL;
    delete First_Node;
}


void DeleteLastNode(Node* &Head)
{
     if(Head==NULL)
        return;



    if(Head->Next==NULL)
    {
        Head=NULL;
        delete Head;
        return;
    }

    Node* Curr_Node =Head;
    while(Curr_Node->Next->Next!=NULL)
    {
        Curr_Node=Curr_Node->Next;
    }
    Node* Temp=Curr_Node->Next;
    Curr_Node->Next=NULL;
    delete Temp;
}

void ConvertToCircularList(Node* &Head)
{
    if(Head==NULL)
        return;
    Node* Temp=Head;
    while(Temp->Next!=NULL)
    {
        Temp=Temp->Next;
    }

    Temp->Next=Head;
    Head->Prev=Temp;
}


int main()
{
    Node* head=NULL;
    InsertAtEnd(head,1);
    InsertAtEnd(head,2);
    InsertAtEnd(head,3);
    InsertAtEnd(head,4);
    InsertAtEnd(head,5);
    PrintList(head);
    //ConvertToCircularList(head);
    //PrintList(head);

    return 0;
}
