#include <iostream>
using namespace std;
class Node
{
public:
    int Value;
    Node* Next;
};
Node* CreationNode(int Value)
{
    Node* NewNode=new Node();
    NewNode->Value=Value;
    NewNode->Next=NULL;
    return NewNode;
}
void  InsertAtBeginning(Node* &Head,int value)
{
   Node* NewNode=CreationNode(value);

   NewNode->Next=Head;
   Head=NewNode;
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
    void PrintList(Node* Head)
    {
        while(Head!=NULL)
        {
            printf("%d   ",Head->Value);
            Head=Head->Next;
        }
        printf("\n");
    }

 void InsertAfter(Node* Prev_Node,int value)
 {
     Node* NewNode=CreationNode(value);
     if(Prev_Node==NULL)
        return;

       NewNode->Next= Prev_Node->Next;
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

     Node* LastNode=Head;
     while(LastNode->Next!=NULL)
     {
         LastNode=LastNode->Next;
     }
     LastNode->Next=NewNode;
 }

 void DeleteNode(Node* &Head ,int value)
{
    Node* Prev_Node=Head;
    Node* Curr_Node=Head;

    if(Head==NULL)
        return;

    if(Curr_Node->Value==value)
    {
        Head->Next=Curr_Node->Next;
        delete Curr_Node;
        return;
    }

    while(Curr_Node!=NULL&& Curr_Node->Value!=value)
    {
        Prev_Node=Curr_Node;
        Curr_Node=Curr_Node->Next;
    }
    if(Curr_Node==NULL)
        return ;

    Prev_Node->Next=Curr_Node->Next;
    delete Curr_Node;
}

void DeleteFirstNode(Node* &Head)
{
    if(Head==NULL)
        return;

    Node* First_Node =Head;

    Head=First_Node->Next;

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
    Node* Prev_Node =Head;
    while(Curr_Node!=NULL&& Curr_Node->Next!=NULL)
    {
        Prev_Node=Curr_Node;
        Curr_Node=Curr_Node->Next;
    }
    Prev_Node=NULL;

    delete Curr_Node;
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
