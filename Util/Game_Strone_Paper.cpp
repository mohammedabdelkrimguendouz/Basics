#include <iostream>
#include<time.h>
using namespace std;
enum enWinner{Player=1,Computer=2,Draw=3};
enum enGameChoice{Strone=1,Paper=2,Scissors=3};
struct stRoundInfo
{
    short RoundNumber=0;
    enGameChoice PlayerChoice;
    enGameChoice ComputerChoice;
    enWinner Winner;
    string WinnerName;
};
struct stGameResult
{
    short GameRound=0;
    short PlyerWinTime=0;
    short ComputerWinTime=0;
    short DrawTime=0;
    enWinner GameWinner;
    string WinnerName="";
};
short ReadHowManyRounds()
{
    short GameRound=1;
    do
    {
        cout<<"How Mant Round 1 to 10 ? \n";
        cin>>GameRound;
    }while(GameRound<1 || GameRound>10);
    return GameRound;
}
void ResetScreen()
{
    system("cls");
    system("color 0F");
}
enGameChoice ReadPlayerChoice()
{
    short Choice=1;
    do
    {
        cout<<"Your Choice : [1]:Stone , [2]:Paper , [3]:Scissors ? ";
        cin>>Choice;
    }while(Choice<1 || Choice>3);
    return (enGameChoice)Choice;
}
enGameChoice GetComputerChoice()
{
    int Random=rand()%(3-1+1)+1;
    return (enGameChoice)Random;
}
enWinner whoWonTheRound(stRoundInfo RoundInfo)
{
    if(RoundInfo.ComputerChoice==RoundInfo.PlayerChoice)
    {
        return enWinner::Draw;
    }
    switch(RoundInfo.PlayerChoice)
    {
    case enGameChoice::Strone:
        if(RoundInfo.ComputerChoice==enGameChoice::Paper)
        {
            return enWinner::Computer;
        }
        break;
    case enGameChoice::Paper:
        if(RoundInfo.ComputerChoice==enGameChoice::Scissors)
        {
            return enWinner::Computer;
        }
        break;
     case enGameChoice::Scissors:
        if(RoundInfo.ComputerChoice==enGameChoice::Strone)
        {
            return enWinner::Computer;
        }
        break;
    }
    return enWinner::Player;

}
string WinnerName(enWinner Winner )
{
    string arrWinerName[3]={"Player","Computer","No Winner"};
    return arrWinerName[Winner-1];
}
string ChoiceName(enGameChoice Choice)
{
    string arrGameChoice[3]={"Stron","Paper","Scissors"};
    return arrGameChoice[Choice-1];
}
void SetWinnerScreenColor(enWinner Winner)
{
    switch(Winner)
    {
    case enWinner::Computer:
        system("color 4F");
        cout<<"\a";
        break;

    case enWinner::Draw:
        system("color 6F");
        break;
    case enWinner::Player:
        system("color 2F");
        break;
    }
}
void PrintRoundResult(stRoundInfo RoundInfo)
{
    cout<<"\n-------------Round ["<< RoundInfo.RoundNumber <<"[ -------------\n\n";
    cout<<"Player Choice  : "<<ChoiceName(RoundInfo.PlayerChoice)<<endl;
    cout<<"Computer Choice: "<<ChoiceName(RoundInfo.ComputerChoice)<<endl;
    cout<<"Round Winner   :["<<RoundInfo.WinnerName <<"] \n";
    cout<<"----------------------------------\n"<<endl;
    SetWinnerScreenColor(RoundInfo.Winner);
}
enWinner whoWonTheGame(short PlayerWinTime,short ComputerWinTime)
{
    if(PlayerWinTime>ComputerWinTime)
    {
        return enWinner::Player;
    }
    else if(PlayerWinTime<ComputerWinTime)
    {
        return enWinner::Computer;
    }
    else
        return enWinner::Draw;
}
stGameResult FillGameResult(int GameRound,short PlayerWinTime,short ComputerWinTime ,short  DrawTimes)
{
    stGameResult GameResults;
    GameResults.GameRound=GameRound;
    GameResults.PlyerWinTime=PlayerWinTime;
    GameResults.ComputerWinTime=ComputerWinTime;
    GameResults.DrawTime=DrawTimes;
    GameResults.GameWinner=whoWonTheGame(PlayerWinTime,ComputerWinTime);
    GameResults.WinnerName=WinnerName(GameResults.GameWinner);
    return GameResults;
}
stGameResult PlayGame(short HowManyRounds)
{
    stRoundInfo RoundInfo;
    short PlayerWinTime=0,ComputerWinTime=0,DrawTime=0;
    for(short GameRound=1;GameRound<=HowManyRounds;GameRound++)
    {
        cout<<"\nRound ["<< GameRound <<"] begins :\n";
        RoundInfo.RoundNumber=GameRound;
        RoundInfo.PlayerChoice=ReadPlayerChoice();
        RoundInfo.ComputerChoice=GetComputerChoice();
        RoundInfo.Winner=whoWonTheRound(RoundInfo);
        RoundInfo.WinnerName=WinnerName(RoundInfo.Winner);
        if(RoundInfo.Winner==enWinner::Computer)
        {
            ComputerWinTime++;
        }
        else if(RoundInfo.Winner==enWinner::Player)
        {
            PlayerWinTime++;
        }
        else
        {
            DrawTime++;
        }
        PrintRoundResult(RoundInfo);
    }
    return FillGameResult(HowManyRounds,PlayerWinTime,ComputerWinTime,DrawTime);
}
string Tabs(short NumbersOfTabs)
{
    string t="";
    for(int i=1;i<NumbersOfTabs;i++)
    {
        t=t+"\t";
        cout<<t;
    }
    return t;
}
void ShowGameOverScreen()
{
    cout<<Tabs(2)<<"--------------------------------------------------------\n\n";
    cout<<Tabs(2)<<"                   +++ G a m e  O v e r +++\n\n";
    cout<<Tabs(2)<<"--------------------------------------------------------\n\n";
}
void ShowFinalGameResults(stGameResult GameResults)
{
    cout<<Tabs(2)<<"--------------------------- [ Game Resulte ] ------------------------------\n\n";
    cout<<Tabs(2)<<"Game Round         : "<<GameResults.GameRound<<endl;
    cout<<Tabs(2)<<"Player Won Times   : "<<GameResults.PlyerWinTime<<endl;
    cout<<Tabs(2)<<"Computer Won Times : "<<GameResults.ComputerWinTime<<endl;
    cout<<Tabs(2)<<"Draw Times         : "<<GameResults.DrawTime<<endl;
    cout<<Tabs(2)<<"Final Winner       : "<<GameResults.WinnerName<<endl;
    cout<<Tabs(2)<<"----------------------------------------------------------------------------\n\n";
    SetWinnerScreenColor(GameResults.GameWinner);
}
void StartGame()
{
    char PlayAgine='Y';
    do
    {
        ResetScreen();
        cout<<"\n"<<Tabs(3) <<"Welcome to the Stone Paper Scissor Game\n\n";
        stGameResult GameResult=PlayGame(ReadHowManyRounds());
        ShowGameOverScreen();
        ShowFinalGameResults(GameResult);
        cout<<endl<<Tabs(3)<<" Do you want to play again? Y/N? ";
        cin>>PlayAgine;
    }while(PlayAgine=='Y'|| PlayAgine=='y');
}
int main()
{
    srand((unsigned)time(NULL));
    StartGame();
    return 0;
}
