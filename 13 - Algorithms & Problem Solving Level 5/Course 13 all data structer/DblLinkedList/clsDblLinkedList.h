#pragma once
#include<iostream>
using namespace std;
template<class T>
class clsDblLinkedList
{
protected:
	int _Size=0;
public:
	class Node
	{
	public:
		T value;
		Node* next;
		Node* prev;
	};
	Node* head = NULL;
	void InsertAtBeginning(T value)
	{
		Node* newNode = new Node();
		newNode->next = head;
		newNode->value = value;
		newNode->prev = NULL;
		if (head != NULL)
		{
			head->prev = newNode;
		}
		head = newNode;
		_Size++;
	}
	void PrintList()
	{
		Node* Current = head;
		while (Current != NULL)
		{
			cout << Current->value << "  ";
			Current = Current->next;
		}
		cout << endl;
	}
	Node* Find(T value)
	{
		Node* Current = head;
		while (Current != NULL && Current->value != value)
		{
			Current = Current->next;
		}
		return Current;
	}
	void InsertAfter(Node* current, T value)
	{
		Node* newNode = new Node();
		newNode->value = value;
		newNode->prev = current;
		newNode->next = current->next;
		if (current->next != NULL)
		{
			current->next->prev = newNode;
		}
		current->next = newNode;
		_Size++;
	}
	void InsertAtEnd(T value)
	{
		Node* newNode = new Node();
		newNode->value = value;
		newNode->next = NULL;
		if (head == NULL)
		{
			newNode->prev = NULL;
			head = newNode;
		}
		else
		{
			
			Node* Current = head;
			while (Current->next != NULL)
			{
				Current = Current->next;
			}
			Current->next = newNode;
			newNode->prev = Current;
		}
		_Size++;
	}
	void DeleteNode(Node*& NodeToDelete)
	{
		if (head == NULL || NodeToDelete == NULL)
			return;
		if (NodeToDelete==head)
		{
			head = head->next;
		}
		if (NodeToDelete->next != NULL)
		{
			NodeToDelete->next->prev = NodeToDelete->prev;
		}
		if(NodeToDelete->prev != NULL)
		{
			NodeToDelete->prev->next = NodeToDelete->next;
		}
		delete NodeToDelete;
		_Size--;
	}
	void DeleteFirstNode()
	{
		if (head != NULL)
		{
			Node* temp = head;
			head = head->next;
			if (head != NULL)
			{
				head->prev = NULL;
			}
			delete temp;
		}
		_Size--;
	}
	void DeleteLastNode()
	{
		if (head == NULL) return;
		_Size--;
		if (head->next == NULL)
		{
			delete head;
			head = NULL;
			return;
		}
		else
		{
			Node* Current = head;
			while (Current->next->next!= NULL)
			{
				Current = Current->next;
			}
			Node* temp = Current->next;
			Current->next = NULL;
			delete temp;
		}
		
	}
	int Size()
	{
		return _Size;
	}
	bool IsEmpty()
	{
		return(_Size == 0);
	}
	void Clear()
	{
		while (_Size>0)
		{
			DeleteFirstNode();
		}
	}
	void Reverse()
	{
		Node* Current = head;
		Node* temp = nullptr;
		while (Current!=nullptr)
		{
			 temp= Current->prev;
			 Current->prev = Current->next;
			 Current->next = temp;
			 Current = Current->prev;
		}
		if(temp!=nullptr)
			head = temp->prev;
		
	}
	Node* GetNode(int Index)
	{
		if (Index > _Size - 1 || Index < 0)
			return NULL;
		int Counter = 0;
		Node* Current = head;
		while (Current!=NULL && Counter!=Index)
		{
			Current = Current->next;
			Counter++;
		}
		return Current;
	}
	T GetItem(int index)
	{
		Node* ItemNode = GetNode(index);
		if (ItemNode == NULL)
			return NULL;
		else
		{
			return ItemNode->value;
		}
	}
	bool UpdateItem(int Index, T NewValue)
	{
		Node* ItemNode = GetNode(Index);
		if (ItemNode != NULL)
		{
			ItemNode->value = NewValue;
			return true;
		}
		else
		{
			return false;
		}
	}
	bool InsertAfter(int Index, T value)
	{
		Node* ItemNode = GetNode(Index);
		if (ItemNode != NULL)
		{
			InsertAfter(ItemNode, value);
			return true;
		}
		else
		{
			return false;
		}  
	}
};


