#pragma once
#include<iostream>
using namespace std;
template<class T>
class clsDynamicArray
{
protected:
	int _Size=0;
	T* _TempArray;
public:
	T* OriginalArray;
	clsDynamicArray(int Size=0)
	{
		if (Size < 0)
			Size = 0;
		_Size = Size;
		OriginalArray = new T[_Size];
	}
	~clsDynamicArray()
	{
		delete[] OriginalArray;
	}
    bool SetItem(int Index, T Value)
	{
		if (Index >= _Size  || Index < 0)
			return false;
		OriginalArray[Index] =Value ;
		return true;
	}
	void PrintList()
	{
		for (int i = 0; i < _Size; i++)
		{
			cout << OriginalArray[i] << "  ";
	    }
		cout << endl;
	}
	int Size()
	{
		return _Size;
	}
	bool IsEmpty()
	{
		return(_Size == 0);
	}
	void Resize(int NewSize)
	{
		if (NewSize < 0)
		{
			NewSize = 0;
		}
		_TempArray = new T[NewSize];
		if (NewSize < _Size)
		{
			_Size = NewSize;
		}
		for (int i = 0; i < _Size; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}
		_Size = NewSize;
		delete[] OriginalArray;
		OriginalArray = _TempArray;
	}
	T GetItem(int Index)
	{
		if (Index >= 0 && Index < _Size)
		{
			return OriginalArray[Index];
		}
	}
	void Reverse()
	{
		for (int i = 0; i < _Size/2; i++)
		{
			T Swap = OriginalArray[i];
			OriginalArray[i] = OriginalArray[_Size - i - 1];
			OriginalArray[_Size - i - 1] = Swap;
		}
	}
	void Clear()
	{
		_Size = 0;
		_TempArray = new T[0];
		delete[] OriginalArray;
		OriginalArray = _TempArray;
	}
	bool DeleteItemAt(int Index)
	{
		if (Index >= _Size || Index < 0)
			return false;
		_Size--;
		_TempArray = new T[_Size];
		for (int i = 0; i < Index; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}
		for (int i = Index+1; i < _Size+1; i++)
		{
			_TempArray[i-1] = OriginalArray[i];
		}
		delete[] OriginalArray;
		OriginalArray = _TempArray;
		return true;
	}
	void DeleteFirstItem()
	{
		DeleteItemAt(0);
	}
	void DeleteLastItem()
	{
		DeleteItemAt(_Size - 1);
	}
	int Find(T value)
	{
		for (int i = 0; i < _Size; i++)
		{
			if (OriginalArray[i] == value)
				return i;
		}
		return -1;
	}
	bool DeleteItem(T value)
	{
		int Index = Find(value);
		if (Index == -1)
			return false;
		DeleteItemAt(Index);
		return true;
	}
	bool InsertAt(int Index, T value)
	{
		if (Index > _Size || Index < 0)
			return false;
		_TempArray = new T[_Size + 1];
		_Size++;
		for ( int i = 0; i < Index; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}
		_TempArray[Index] = value;
		for ( int i = Index; i < _Size-1; i++)
		{
			_TempArray[i+1] = OriginalArray[i];
		}
		delete[] OriginalArray;
		OriginalArray = _TempArray;
		return true;
	}
	void InsertAtBeginning(T value)
	{
		InsertAt(0, value);
	}
	bool InsertBefore(int Index,T value)
	{
		if (Index < 1)
			return InsertAt(0, value);
		return InsertAt(Index - 1, value);
	}
	bool InsertAfter(int Index, T value)
	{
		if (Index >= _Size)
			return InsertAt(_Size - 1, value);
		return InsertAt(Index + 1, value);
	}
	bool InsertAtEnd(T value)
	{
		return InsertAt(_Size , value);
	}
};

