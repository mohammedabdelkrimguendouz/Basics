#pragma once
#include<iostream>
#include"clsDblLinkedList.h"
using namespace std;

template<class T>
class clsMyQueue 
{
protected:
	clsDblLinkedList<T>_MyArr;
public:
	void push(T Item)
	{
		_MyArr.InsertAtEnd(Item);
	}
	void Print()
	{
		_MyArr.PrintList();
	}
	int Size()
	{
		return _MyArr.Size();
	}
	bool IsEmpty()
	{
		return _MyArr.IsEmpty();
	}
	T front()
	{
		return _MyArr.GetItem(0);
	}
	T back()
	{
		return _MyArr.GetItem(Size() - 1);
	}
	void pop()
	{
		_MyArr.DeleteFirstNode();
	}
	T GetItem(int Index)
	{
		return _MyArr.GetItem(Index);
	}
	void Reverse()
	{
		_MyArr.Reverse();
	}
	void UpdateItem(int Index, T Item)
	{
		_MyArr.UpdateItem(Index, Item);
	}
	void InsertAfter(int Index, T Item)
	{
		 _MyArr.InsertAfter(Index, Item);
	}
	void InsertAtFront(T Item)
	{
		_MyArr.InsertAtBeginning(Item);
	}
	void InsertAtBack(T Item)
	{
		_MyArr.InsertAtEnd(Item);
	}
	void Clear()
	{
		_MyArr.Clear();
	}
};

