#pragma once
#include<iostream>
#include"clsMyQueue.h"
using namespace std;

template<class T>
class clsMyStack:public clsMyQueue<T>
{
public:
	void puch(T Item)
	{
		clsMyQueue<T>::_MyArr.InsertAtBeginning(Item);
	}
	T Top()
	{
		return clsMyQueue<T>:: front();
	}
	T Bottom()
	{
		return clsMyQueue<T>::back();
	}
	
};

