#include <stdio.h>
#include <stdlib.h>
#include<stdbool.h>
typedef struct NodeTree
{
  int data;
  struct NodeTree* right;
  struct NodeTree* left;
}*Node;

int Max(int Number1,int number2)
{
    if(Number1>number2) return Number1;
    return number2;
}
int ReadHowNumberAddToTree()
{
    int HowNumberAddToList=0;
    printf("Enter How Number Add To Tree ? ");
    scanf("%d",&HowNumberAddToList);
    return HowNumberAddToList;
}

Node CreationNode(int value)
{
    Node NewNode=malloc(sizeof(struct NodeTree)) ;
    NewNode->data=value;
    NewNode->left=NULL;
    NewNode->right=NULL;
    return NewNode;
}

Node InsertNodeToTreeRecursion(Node temp,int value)
{
    if(temp==NULL)
    {
         return CreationNode(value);
    }
    if(temp->data>=value)
    {
           temp->left= InsertNodeToTreeRecursion(temp->left, value);
    }
    else
    {
        temp->right=InsertNodeToTreeRecursion(temp->right, value);
    }
}

int GetHigth(Node temp)
{
    if(temp==NULL)
    {
        return 0;
    }
    else
    {
        int left_sub_tree=GetHigth(temp->left);
        int right_sub_tree=GetHigth(temp->right);
        return 1+Max(left_sub_tree,right_sub_tree);
    }
}

void PrintPreorder(Node temp)
{
    if(temp==NULL)
    {
        return ;
    }
    printf("%d   ",temp->data);
    PrintPreorder(temp->left);
    PrintPreorder(temp->right);
}
void PrintInorder(Node temp)
{
    if(temp==NULL)
    {
        return ;
    }

    PrintInorder(temp->left);
    printf("%d   ",temp->data);
    PrintInorder(temp->right);
}
void PrintPostorder(Node temp)
{
    if(temp==NULL)
    {
        return ;
    }
    PrintPostorder(temp->left);
    PrintPostorder(temp->right);
    printf("%d   ",temp->data);
}

int GetMax(Node temp)
{
    if(temp->right==NULL)
    {
        return temp->data;
    }
    return GetMax(temp->right);
}

int GetMin(Node temp)
{
    if(temp->left==NULL)
    {
        return temp->data;
    }
    return GetMin(temp->left);
}

Node CreationTreeComplet(int H)
{
    if(H==0) return NULL;
    Node Left,Right,Result;
    Left=CreationTreeComplet(H-1);
    Right=CreationTreeComplet(H-1);
    Result=CreationNode(rand()%100);
    Result->left=Left;
    Result->right=Right;
    return Result;
}

Node DeleteNodeInTree(Node Root,int value)
{
    if(Root==NULL)return NULL;
    if(value<Root->data)
        Root->left=DeleteNodeInTree(Root->left,value);
    else if(value>Root->data)
        Root->right=DeleteNodeInTree(Root->right,value);
    else
    {
         if(Root->left==NULL)
         {
             Node temp=Root->right;
             free (Root);
             return temp;
         }
         else if(Root->right==NULL)
         {
             Node temp=Root->left;
             free(Root);
             return temp;
         }
         else
         {
             int MaxValue=GetMax(Root->left);
             Root->data=MaxValue;
             Root->left=DeleteNodeInTree(Root->left,MaxValue);
         }
    }
    return Root;
}

Node ConvertireTree(int Number,int Base)
{
   Node Temp=CreationNode(Number);
   Node Root=Temp;
   while(Number>0)
   {
           int m=Number%Base;
           Number/=Base;
           if(Number!=0)
               Temp->left=CreationNode(Number);
           Temp->right=CreationNode(m);
           Temp=Temp->left;
   }
   return Root;
}

void PrintConvertire(Node Root)
{
   if(Root==NULL)  return;
   PrintConvertire(Root->left);
   printf("%d   ",Root->right->data);
}

int NumberRandom(int To,int From)
{
    return rand()%(To-From+1)+From;
}

Node CreationBinarySearchTreeRandomly(int HowNumberAddToTree)
{
   Node Root=NULL;
   for(int i=1;i<=HowNumberAddToTree;i++)
   {
       Root=InsertNodeToTreeRecursion(Root,NumberRandom(100,1));
   }
   return Root;
}

bool IsExistByValue(Node Temp,int Value)
{
    while(Temp!=NULL&&Temp->data!=Value)
    {
        if(Temp->data>Value)  Temp=Temp->left,Value;
        else Temp=Temp->right,Value;
    }
    if(Temp!=NULL) return true;
    return false;
}
bool IsExistByValueRecursion(Node Temp,int Value)
{
    if(Temp==NULL||Temp->data==Value)
    {
        if(Temp!=NULL) return true;
        return false;
    }
        if(Temp->data>Value)  IsExistByValueRecursion(Temp->left,Value);
        else IsExistByValueRecursion(Temp->right,Value);
}


int main()
{
    Node Root=NULL;
    Root=InsertNodeToTreeRecursion(Root,10);
    Root=InsertNodeToTreeRecursion(Root,5);
    Root=InsertNodeToTreeRecursion(Root,15);
    Root=InsertNodeToTreeRecursion(Root,7);
    Root=InsertNodeToTreeRecursion(Root,12);
    //Root=CreationBinarySearchTreeRandomly(ReadHowNumberAddToTree());
    PrintInorder(Root);printf("\n");
    PrintPostorder(Root);printf("\n");
    PrintPreorder(Root);printf("\n");
    printf("height : %d  \n",GetHigth(Root));
    printf("max : %d \n",GetMax(Root));
    printf("min : %d \n",GetMin(Root));
    printf("%d \n",IsExistByValue(Root,10));
    printf("%d \n",IsExistByValueRecursion(Root,12));
    /*Node bin=ConvertireTree(100,2);
    PrintConvertire(bin);printf("\n");
    Node Complet=CreationTreeComplet(4);
    PrintInorder(Complet);printf("\n");
    DeleteNodeInTree(Root,10);
    PrintInorder(Root);*/
    return 0;
}
