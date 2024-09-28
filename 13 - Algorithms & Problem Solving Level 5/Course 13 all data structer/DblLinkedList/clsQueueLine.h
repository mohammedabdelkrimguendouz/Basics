#pragma once
#include<iostream>
#include"clsDate.h"
#include<queue>
#include<stack>
using namespace std;
class clsQueueLine
{
private:
	string _Prefix="";
	short _TotalTickets=0;
	short _AvargeServeTime=0;
	class clsTicket
	{
	private:
		short _Number = 0;
		string _Prefix = "";
		string _TicketTime;
		short _WaitingClients=0;
		short _AvargeServeTime = 0;
		short _ExpectedServeTime = 0;
	public:
		clsTicket(string Prefix, short Number, short WaitingClients, short AvargeServeTime)
		{
			_TicketTime = clsDate::GetSystemDateTimeString();
			_Prefix = Prefix;
			_Number = Number;
			_WaitingClients = WaitingClients;
			_AvargeServeTime = AvargeServeTime;
		}
		short Number()
		{
			return _Number;
		}
		string FullNumber()
		{
			return _Prefix+to_string(_Number);
		}
		string Prefix()
		{
			return _Prefix;
		}
		short WaitingClients()
		{
			return _WaitingClients;
		}
		short ExpectedServeTime()
		{
			return  _WaitingClients * _AvargeServeTime;
		}
		void Print()
		{
			cout << "\n\t\t\t  ____________________________\n";
			cout << "\n\t\t\t\t     " << FullNumber();
			cout << "\n\t\t\t    " << _TicketTime;
			cout << "\n\t\t\t    Wating Clients = " << _WaitingClients;
			cout << "\n\t\t\t      Serve Time In "  ;
			cout << "\n\t\t\t        " << ExpectedServeTime()<<" Minuts";
			cout << "\n\t\t\t  ____________________________\n";
		}
	};
public:
	queue<clsTicket> _QueueLine;
	clsQueueLine(string Prefix, short AvargeServeTime)
	{
		_Prefix = Prefix;
		_TotalTickets = 0;
		_AvargeServeTime = AvargeServeTime;
	}
	void PrintInfo()
	{
		cout << "\n\t\t\t -------------------------------\n";
		cout << "\n\t\t\t\tQueue Info\n";
		cout << "\n\t\t\t -------------------------------\n";
		cout << "\n\t\t\t   Prefix = "<<_Prefix;
		cout << "\n\t\t\t   Total Ticket   = "<<_TotalTickets;
		cout << "\n\t\t\t   Served Clients = "<<ServedClients();
		cout << "\n\t\t\t   Wating Clients = " << WaitingClients();
		cout << "\n\t\t\t -------------------------------\n";
		cout << "\n";
	}
	void IssueTicket()
	{
		_TotalTickets++;
		clsTicket Ticket(_Prefix, _TotalTickets , WaitingClients(), _AvargeServeTime);
		_QueueLine.push(Ticket);
	}
	short WaitingClients()
	{
		return _QueueLine.size();
	}
	string WhoIsNext()
	{
		if (_QueueLine.empty())
			return "No Client Left.";
		return _QueueLine.front().FullNumber();
	}
	void PrintTicketsLineRTL()
	{
		if (_QueueLine.empty())
			cout << "\n\t\tTicket:No Ticket";
		else
			cout << "\n\t\tTicket: ";
		queue<clsTicket>TempQueueLine = _QueueLine;
		while (!TempQueueLine.empty())
		{
			cout << TempQueueLine.front().FullNumber()<<" <--- ";
			TempQueueLine.pop();
		}
		cout << "\n";
	}
	void PrintTicketsLineLTR()
	{
		if (_QueueLine.empty())
			cout << "\n\t\tTicket:No Ticket";
		else
			cout << "\n\t\tTicket: ";
		queue<clsTicket>TempQueueLine = _QueueLine;
		stack<clsTicket>TempStackLine;
		while (!TempQueueLine.empty())
		{
			TempStackLine.push(TempQueueLine.front());
			TempQueueLine.pop();
		}
		while (!TempStackLine.empty())
		{
			cout << TempStackLine.top().FullNumber()<< " ---> ";
			TempStackLine.pop();
		}
		cout << "\n";
	}
	void PrintAllTickets()
	{
		cout <<"\n\n\t\t\t         ---Ticket--- ";
		if (_QueueLine.empty())
		cout <<"\n\n\t\t\t       ---No Ticket---\n";	
		queue<clsTicket>TempQueueLine = _QueueLine;
		while (!TempQueueLine.empty())
		{
			TempQueueLine.front().Print();
			TempQueueLine.pop();
		}
		cout << "\n";
	}
	bool ServeNextClient()
	{
		if (_QueueLine.empty())
			return false;
		_QueueLine.pop();
		return true;
	}
	short ServedClients()
	{
		return _TotalTickets - WaitingClients();
	}

};

