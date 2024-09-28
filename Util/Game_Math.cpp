#include <iostream>
#include<time.h>
using namespace std;
enum enQuestionLevel{Easy=1,Med=2,Hard=3,Mix=4};
enum enOperationType{Add=1,Sub=2,Mul=3,Div=4,MixOp=5};
struct stQuestion
{
    int Number1=0;
    int Number2=0;
    enQuestionLevel QuestionLevel;
    enOperationType  OperationType;
    int CorrectAnswer=0;
    int PlayerAnswer=0;
    bool AnswerResult=false;
};
struct stQuizz
{
  stQuestion QuestionList[100];
  short NumberOfQuestion;
  enQuestionLevel QuestionLevel;
  enOperationType  OpType;
  short NumberOfWrongAnswer;
  short NumberOfRightAnswer;
  bool isPass=false;
};
short ReadHowManyQuestions()
{
    short GameRound=1;
    do
    {
        cout<<"How Many Questions do you want to answer ? ";
        cin>>GameRound;
    }while(GameRound<1);
    return GameRound;
}
enQuestionLevel ReadQuestionLevel()
{
    short Level=1;
    do
    {
        cout<<"Enter Questions Level  [1]:Easy , [2]:Med , [3]:Hard , [4]:Mix  ? ";
        cin>>Level;
    }while(Level<1 || Level>4);
    return (enQuestionLevel)Level;
}
enOperationType ReadOperationType()
{
    short Type=1;
    do
    {
        cout<<"Enter Questions Type  [1]:Add , [2]:Sub , [3]:Mul , [4]:Div , [5]:Mix  ? ";
        cin>>Type;
    }while(Type<1 || Type>5);
    return (enOperationType)Type;
}
void ResetScreen()
{
    system("cls");
    system("color 0F");
}
int RandomNumber(int To,int From)
{
    int random=rand()%(From-To+1)+To;
    return random;
}
int SimpleCalculator(int Number1,int Number2,enOperationType OpType)
{
    switch(OpType)
    {
    case enOperationType::Add:
        return Number1+Number2;
    case enOperationType::Sub:
        return Number1-Number2;
    case enOperationType::Mul:
        return Number1*Number2;
    case enOperationType::Div:
        return Number1/Number2;
    }
}
stQuestion GenerateQuestion(enQuestionLevel QuestionLevel,enOperationType OpType)
{
    stQuestion Question;
    if(QuestionLevel==enQuestionLevel::Mix)
    {
        QuestionLevel=(enQuestionLevel)RandomNumber(1,3);
    }
    if(OpType==enOperationType::MixOp)
    {
        OpType=(enOperationType)RandomNumber(1,4);
    }
    Question.OperationType=OpType;
    switch(QuestionLevel)
    {
    case enQuestionLevel::Easy:
        Question.Number1=RandomNumber(1,10);
        Question.Number2=RandomNumber(1,10);
        Question.CorrectAnswer=SimpleCalculator(Question.Number1,Question.Number2,Question.OperationType);
        Question.QuestionLevel=QuestionLevel;
        return Question;
    case enQuestionLevel::Med:
        Question.Number1=RandomNumber(10,100);
        Question.Number2=RandomNumber(10,100);
        Question.CorrectAnswer=SimpleCalculator(Question.Number1,Question.Number2,Question.OperationType);
        Question.QuestionLevel=QuestionLevel;
        return Question;
    case enQuestionLevel::Hard:
        Question.Number1=RandomNumber(100,1000);
        Question.Number2=RandomNumber(100,1000);
        Question.CorrectAnswer=SimpleCalculator(Question.Number1,Question.Number2,Question.OperationType);
        Question.QuestionLevel=QuestionLevel;
        return Question;
    }
}

void GenerateQuizzQuestion(stQuizz &Quizz)
{
    for(int Qustion=0;Qustion<Quizz.NumberOfQuestion;Qustion++)
    {
        Quizz.QuestionList[Qustion]=GenerateQuestion(Quizz.QuestionLevel,Quizz.OpType);
    }
}

char GetOpTypeSymbol(enOperationType OpType)
{
     switch(OpType)
     {
     case enOperationType::Add:
        return '+';

     case enOperationType::Sub:
        return '-';

     case enOperationType::Mul:
        return 'x';
     case enOperationType::Div:
        return '/';
     }
}
void PrintTheQuestion(stQuizz &Quizz,int QuestionNumber)
{
    cout<<"\n";
    cout<<"Question ["<<QuestionNumber+1<<"/"<<Quizz.NumberOfQuestion<<"]\n\n";
    cout<<"  "<<Quizz.QuestionList[QuestionNumber].Number1<<endl;
    cout<<GetOpTypeSymbol(Quizz.QuestionList[QuestionNumber].OperationType)<<endl;
    cout<<"  "<<Quizz.QuestionList[QuestionNumber].Number2<<endl;
    cout<<"\n----------\n";
    cout<<"= ";
}

int ReadQuestionAnswer()
{
    int Answer=0;
    cin>>Answer;
    return Answer;
}

void SetSecreenColor(bool AnswerResult)
{
    if(AnswerResult==true)
    {
        system("color 2F");
        return ;
    }
    system ("color 4F");
}
void CorrectTheQuetionAnswer(stQuizz& Quizz ,int QuestionNumber)
{
    if(Quizz.QuestionList[QuestionNumber].PlayerAnswer!=Quizz.QuestionList[QuestionNumber].CorrectAnswer)
    {
        Quizz.QuestionList[QuestionNumber].AnswerResult=false;
        Quizz.NumberOfWrongAnswer++;
        cout<<"Worng Answer:-(\n";
        cout<<"The Right answer is : ";
        cout<<Quizz.QuestionList[QuestionNumber].CorrectAnswer;
    }
    else
    {
        Quizz.QuestionList[QuestionNumber].AnswerResult=true;
        Quizz.NumberOfRightAnswer++;
        cout<<"Right Answer :-) \n";
    }
    cout<<endl;
    SetSecreenColor(Quizz.QuestionList[QuestionNumber].AnswerResult);
}

void AskAndCorrectQuestionListAnswer(stQuizz &Quizz)
{
    for(int QuestionNumber=0;QuestionNumber<Quizz.NumberOfQuestion;QuestionNumber++)
    {
        PrintTheQuestion(Quizz,QuestionNumber);
        Quizz.QuestionList[QuestionNumber].PlayerAnswer=ReadQuestionAnswer();
        CorrectTheQuetionAnswer(Quizz,QuestionNumber);
    }
    Quizz.isPass=(Quizz.NumberOfRightAnswer>=Quizz.NumberOfWrongAnswer);
}

string GetFinalResultText(bool pass)
{
    if(pass==true)
    {
        return "Pass :-)";
    }
    return "Fail :-(";
}
string GetQuestionLevelText(enQuestionLevel QuestionLevel)
{
    string arrQuestionLevelText[4]={"Easy","Med","Hard","Mix"};
    return arrQuestionLevelText[QuestionLevel-1];
}
void PrintQuizzResult(stQuizz Quizz)
{
    cout<<"-------------------------\n\n";
    cout<<"Final Result is "<<GetFinalResultText(Quizz.isPass)<<endl;
    cout<<"\n-------------------------\n\n";
    cout<<"Number of Question :"<<Quizz.NumberOfQuestion<<endl;
    cout<<"Question Level : "<<GetQuestionLevelText(Quizz.QuestionLevel)<<endl;
    cout<<"Op Type : " <<GetOpTypeSymbol(Quizz.OpType)<<endl;
    cout<<"Number Of Right Answer : "<<Quizz.NumberOfRightAnswer<<endl;
    cout<<"Number Of Wrong Answer : "<<Quizz.NumberOfWrongAnswer<<endl;
    cout<<"-------------------\n";
    SetSecreenColor(Quizz.isPass);
}
void PlayGame()
{
    stQuizz Quizz;
    Quizz.NumberOfQuestion=ReadHowManyQuestions();
    Quizz.QuestionLevel=ReadQuestionLevel();
    Quizz.OpType=ReadOperationType();
    GenerateQuizzQuestion(Quizz);
    AskAndCorrectQuestionListAnswer(Quizz);
    PrintQuizzResult(Quizz);
}

void StartGame()
{
    char PlayAgine='Y';
    do
    {
        ResetScreen();
        PlayGame();
        cout<<" Do you want to play again? Y/N? ";
        cin>>PlayAgine;
    }while(PlayAgine=='Y'|| PlayAgine=='y');
}
int main()
{
   srand((unsigned)time(NULL));
   StartGame();
    return 0;
}
