#pragma once
#include <iostream>
#include"clsDynamicArray.h"
using namespace std;
template<class T>
class clsMyQueueArr
{
protected:
	clsDynamicArray<T>_MyList;
public:
	void push(T Item)
	{
		_MyList.InsertAtEnd(Item);
	}
	void Print()
	{
		_MyList.PrintList();
	}
	int Size()
	{
		return _MyList.Size();
	}
	bool IsEmpty()
	{
		return _MyList.IsEmpty();
	}
	T front()
	{
		return _MyList.GetItem(0);
	}
	T back()
	{
		return _MyList.GetItem(Size() - 1);
	}
	void pop()
	{
		_MyList.DeleteFirstItem();
	}
	T GetItem(int Index)
	{
		return _MyList.GetItem(Index);
	}
	void Reverse()
	{
		_MyList.Reverse();
	}
	void UpdateItem(int Index, T Item)
	{
		_MyList.SetItem(Index, Item);
	}
	void InsertAfter(int Index, T Item)
	{
		_MyList.InsertAfter(Index, Item);
	}
	void InsertAtFront(T Item)
	{
		_MyList.InsertAtBeginning(Item);
	}
	void InsertAtBack(T Item)
	{
		_MyList.InsertAtEnd(Item);
	}
	void Clear()
	{
		_MyList.Clear();
	}
};

