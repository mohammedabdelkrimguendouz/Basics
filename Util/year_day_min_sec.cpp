#include<iostream>
#include<string>
#include<ctime>
#include<vector>
using namespace std;
struct sDate
{
    short Day;
    short Month;
    short Year;
};
struct sPeriods
{
    sDate StartDate;
    sDate EndDate;
};
bool IsLeapYear(short Year)
{
   return  ((Year%400==0)|| (Year%4==0&& Year%100!=0));
}

int NumberOfDaysInAYear(short Year)
{
   return IsLeapYear(Year)?366:365;
}
int NumberOfHoursInAYear(short Year)
{
   return 24*NumberOfDaysInAYear(Year);
}
int NumberOfMinuteInAYear(short Year)
{
   return 60*NumberOfHoursInAYear(Year);
}
int NumberOfSecondInAYear(short Year)
{
    return 60*NumberOfMinuteInAYear(Year);
}



short ReadYear()
{
    short Year;
    cout<<" Enter Year ?";
    cin>>Year;
    return Year;
}
short ReadDay()
{
    short Day;
    cout<<" Enter Day ? ";
    cin>>Day;
    return Day;
}
short ReadMonth()
{
    short Month;
    cout<<" Enter Month ? ";
    cin>>Month;
    return Month;
}
int ReadHowManyDayAdd()
{
    short HowManyDayAdd;
    cout<<" Enter How Many Day Add ? ";
    cin>>HowManyDayAdd;
    return HowManyDayAdd;
}

sDate ReadFullDate()
{
    sDate Date;
    Date.Day=ReadDay();
    Date.Month=ReadMonth();
    Date.Year=ReadYear();
    return Date;
}

short ReadVacation()
{
    short vacation;
    cout<<" enter vacation day : ";
    cin>>vacation;
    return vacation;
}

sPeriods ReadPeriod()
{
    sPeriods Periods;
    cout<<" enter start date : \n\n";
    Periods.StartDate=ReadFullDate();
    cout<<" enter end date : \n\n";
    Periods.EndDate=ReadFullDate();
    return Periods;
}

string ReadDateAsString()
{
   string DateString;
   cout<<" please enter date dd/mm/yyyy ? ";
   getline(cin>>ws,DateString);
   return DateString;
}
short NumberOfDaysInAMonth(short Month,short Year)
{
    if(Month<1||Month>12) return 0;
    short ArrMonth[12]={31,28,31,30,31,30,31,31,30,31,30,31};
    return (Month==2 && IsLeapYear(Year))?29: ArrMonth[Month-1];
}
 NumberOfHoursInAMonth(short Month,short Year)
{
   return NumberOfDaysInAMonth(Month,Year)*24;
}
int NumberOfMinuteInAMonth(short Month,short Year)
{
   return NumberOfHoursInAMonth(Month,Year)*60;
}
int NumberOfSecondsInAMonth(short Month,short Year)
{
   return NumberOfMinuteInAMonth(Month,Year)*60;
}

string Date(short Month,short Year,short Day)
{
    return to_string(Day)+"/"+to_string(Month)+"/"+to_string(Year);
}

short DayOfWeekOrder(short Month,short Year,short Day)
{
    int a=(14-Month)/12;
    int y=Year-a;
    int m=Month+(12*a)-2;
    return (Day+y+(y/4)-(y/100)+(y/400)+((31*m)/12))%7;
}

short DayOfWeekOrder(sDate Date)
{
    return DayOfWeekOrder(Date.Month,Date.Year,Date.Day);
}

string DayShortName(short DayOfWeekOrder)
{
    string ArrDayNames[7]={"Sun","Mon","Tue","Wed","Thu","Fri","Sat"};
    return ArrDayNames[DayOfWeekOrder];
}

string MonthShortName(short MonthOfYearOrder)
{
    string ArrMonthNames[12]={"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
    return ArrMonthNames[MonthOfYearOrder-1];
}

void ShowCalendarOfMonth(short Month,short Year)
{
   int NumberOfDay=NumberOfDaysInAMonth(Month,Year);
   int current=DayOfWeekOrder(Month,Year,1);
   cout<<"\n\n________________"<<MonthShortName(Month)<<"_____________________\n\n";
   cout<<"  Sun  Mun  Tue  Wed  The  Fri  Sat\n";

   int i;
   for(i=0;i<current;i++)
       printf("     ");
   for(int j=1 ;j<=NumberOfDay;j++)
   {
      printf("%5d",j);
      if(++i==7)
      {
          i=0;
          printf("\n");
      }
   }
}

void ShowCalendarOfYear(short Year)
{
    cout<<"___________________________________\n\n";
    cout<<"\t Calendar - "<<Year<<endl<<endl;
    cout<<"___________________________________\n\n";
    for(int i=1;i<=12;i++)
    {
        ShowCalendarOfMonth(i,Year);
    }
}

int NumberOfDaysFromTheBeginingOfTheYear(short Month,short Year,short Day)
{
   int TotalYear=0;
   for(int i=1;i<Month;i++)
   {
      TotalYear+=NumberOfDaysInAMonth(i,Year);
   }
   return TotalYear+Day;
}

sDate GetDateFromDayOrderInYear(short DayOrderInYear,short Year)
{
   sDate Date;
   Date.Month=1;
   Date.Year=Year;
   int RemainingDays=DayOrderInYear;
   int MonthDay=0;
   while(true)
   {
       MonthDay=NumberOfDaysInAMonth(Date.Month,Year);
       if(RemainingDays>MonthDay)
       {
           RemainingDays-=MonthDay;
           Date.Month++;
       }
       else
       {
           Date.Day=RemainingDays;
           break;
       }
   }
   return Date;
}

sDate DateAddDays(int HowManyDayAdd,sDate DateAdd)
{
    int RemainingDays=HowManyDayAdd+NumberOfDaysFromTheBeginingOfTheYear(DateAdd.Month,DateAdd.Year,DateAdd.Day);
    int MonthDay=0;
    DateAdd.Month=1;
    while(true)
    {
        MonthDay=NumberOfDaysInAMonth(DateAdd.Month,DateAdd.Year);
        if(RemainingDays>MonthDay)
        {
            DateAdd.Month++;
            RemainingDays-=MonthDay;
            if(DateAdd.Month>12)
            {
                DateAdd.Month=1;
                DateAdd.Year++;
            }
        }
        else
        {
            DateAdd.Day=RemainingDays;
            break;
        }

    }
    return DateAdd;
}


bool IsDate1BeforeThenDate2(sDate Date1,sDate Date2)
{
    return (Date1.Year<Date2.Year)?true:(Date1.Year==Date2.Year)
    ?(NumberOfDaysFromTheBeginingOfTheYear(Date1.Month,Date1.Year,Date1.Day)<
      NumberOfDaysFromTheBeginingOfTheYear(Date2.Month,Date2.Year,Date2.Day))
      ?true:false:false;
}

bool IsDate1EqualDate2(sDate Date1,sDate Date2)
{
    return ((Date1.Year==Date2.Year)&(Date1.Month==Date2.Month)&(Date1.Day==Date2.Day));
}

bool IsLastDayInMonth(sDate Date)
{
   return (Date.Day==NumberOfDaysInAMonth(Date.Month,Date.Year));
}

bool IsLastMonthInYear(short Month)
{
    return (Month==12);
}

sDate IncreaseDateByOneDay(sDate Date)
{
   if(IsLastDayInMonth(Date))
   {
       Date.Day=1;
       if(IsLastMonthInYear(Date.Month))
       {
           Date.Month=1;
           Date.Year++;
       }
       else
       {
           Date.Month++;
       }
   }
   else
   {
       Date.Day++;
   }
   return Date;
}

void SwapDate(sDate &Date1,sDate &Date2)
{
        sDate DateSwap=Date1;
        Date1=Date2;
        Date2=DateSwap;
}

int GetDifferenceInDays(sDate Date1,sDate Date2,bool EncludingEndDay=false)
{
    int Day=0;
    short SwapFlagValue=1;
    if(!IsDate1BeforeThenDate2(Date1,Date2))
    {
        SwapDate(Date1,Date2);
        SwapFlagValue=-1;
    }
   while(IsDate1BeforeThenDate2(Date1,Date2))
   {
       Day++;
       Date1=IncreaseDateByOneDay(Date1);
   }
   return (EncludingEndDay)?SwapFlagValue*(++Day):SwapFlagValue*Day;

}

sDate GetSystemDate()
{
   time_t t=time(0);
   tm* now=localtime(&t);
   sDate DateNew;
   DateNew.Year=now->tm_year+1900;
   DateNew.Month=now->tm_mon+1;
   DateNew.Day=now->tm_mday;
   return DateNew;
}

void ShowDate(sDate Date)
{
    cout<<Date.Day<<"/"<<Date.Month<<"/"<<Date.Year<<endl;
}

sDate IncreaseDateByXDay(sDate Date,int Days)
{
    for(int i=1;i<=Days;i++)
    {
        Date=IncreaseDateByOneDay(Date);
    }
    return Date;
}

sDate IncreaseDateByOneWeek(sDate Date)
{
    for(int i=1;i<=7;i++)
    {
        Date=IncreaseDateByOneDay(Date);
    }
    return Date;
}
sDate IncreaseDateByXWeek(sDate Date,int Weeks)
{
    for(int i=1;i<=Weeks;i++)
    {
        Date=IncreaseDateByOneWeek(Date);
    }
    return Date;
}
sDate IncreaseDateByOneMonth(sDate Date)
{
    if(IsLastMonthInYear(Date.Month))
    {
        Date.Month=1;
        Date.Year++;
    }
    else
    {
        Date.Month++;
    }
    int MonthDays=NumberOfDaysInAMonth(Date.Month,Date.Year);
    if(MonthDays<Date.Day)
    {
        Date.Day=MonthDays;
    }
    return Date;
}

sDate IncreaseDateByXMonth(sDate Date,int Monyh)
{
    for(int i=1;i<=Monyh;i++)
    {
        Date=IncreaseDateByOneMonth(Date);
    }
    return Date;

}
sDate IncreaseDateByOneYear(sDate Date)
{
    Date.Year++;
    return Date;

}

sDate IncreaseDateByXYear(sDate Date,int Years)
{
    for(int i=1;i<=Years;i++)
    {
        Date=IncreaseDateByOneYear(Date);
    }
    return Date;
}

sDate IncreaseDateByXYearFaster(sDate Date,int Years)
{
    Date.Year+=Years;
    return Date;
}

sDate IncreaseDateByOneDecade(sDate Date)
{
    Date.Year+=10;
    return Date;
}

sDate IncreaseDateByXDecade(sDate Date,int Decade)
{
    for(int i=1;i<=Decade;i++)
    {
        Date=IncreaseDateByOneDecade(Date);
    }
    return Date;
}
sDate IncreaseDateByXDecadeFaster(sDate Date,int Decade)
{
    Date.Year+=Decade*10;
    return Date;
}

sDate IncreaseDateByOneCentury(sDate Date)
{
    Date.Year+=100;
    return Date;
}
sDate IncreaseDateByOneMillennim(sDate Date)
{
    Date.Year+=1000;
    return Date;
}


sDate DecreaseDateByOneDay(sDate Date)
{
   if(Date.Day==1)
   {
       if(Date.Month==1)
       {
           Date.Month=12;
           Date.Year--;
           Date.Day=31;
       }
       else
       {
           Date.Month--;
           Date.Day=NumberOfDaysInAMonth(Date.Month,Date.Year);
       }
   }
   else
   {
       Date.Day--;
   }
   return Date;
}


sDate DecreaseDateByXDay(sDate Date,int Days)
{
    for(int i=1;i<=Days;i++)
    {
        Date=DecreaseDateByOneDay(Date);
    }
    return Date;
}
sDate DecreaseDateByOneWeek(sDate Date)
{
    for(int i=1;i<=7;i++)
    {
        Date=DecreaseDateByOneDay(Date);
    }
    return Date;
}

sDate DecreaseDateByXWeek(sDate Date,int Weeks)
{
    for(int i=1;i<=Weeks;i++)
    {
        Date=DecreaseDateByOneWeek(Date);
    }
    return Date;
}


sDate DecreaseDateByOneMonth(sDate Date)
{
    if(Date.Month==1)
    {
        Date.Month=12;
        Date.Year--;
    }
    else
    {
        Date.Month--;
    }
    int MonthDays=NumberOfDaysInAMonth(Date.Month,Date.Year);
    if(MonthDays<Date.Day)
    {
        Date.Day=MonthDays;
    }
    return Date;
}

sDate DecreaseDateByXMonth(sDate Date,int Month)
{
    for(int i=1;i<=Month;i++)
    {
        Date=DecreaseDateByOneMonth(Date);
    }
    return Date;
}

sDate DecreaseDateByOneYear(sDate Date)
{
    Date.Year--;
    return Date;
}
sDate DecreaseDateByXYear(sDate Date,int Years)
{
    for(int i=1;i<=Years;i++)
    {
        Date=DecreaseDateByOneYear(Date);
    }
    return Date;
}

sDate DecreaseDateByXYearFaster(sDate Date,int Years)
{
    Date.Year-=Years;
    return Date;
}

sDate DecreaseDateByOneDecade(sDate Date)
{
    Date.Year-=10;
    return Date;
}

sDate DecreaseDateByXDecade(sDate Date,int Decade)
{
    for(int i=1;i<=Decade;i++)
    {
        Date=DecreaseDateByOneDecade(Date);
    }
    return Date;
}
sDate DecreaseDateByXDecadeFaster(sDate Date,int Decade)
{
    Date.Year-=Decade*10;
    return Date;
}

sDate DecreaseDateByOneCentury(sDate Date)
{
    Date.Year-=100;
    return Date;
}
sDate DecreaseDateByOneMillennim(sDate Date)
{
    Date.Year-=1000;
    return Date;
}

bool IsEndOfWeek(sDate Date)
{
    return DayOfWeekOrder(Date)==6;
}
bool IsWeekEnd(sDate Date)
{
    short DayIndex=DayOfWeekOrder(Date);
    return (DayIndex==6||DayIndex==5);
}
bool IsBusinessDay(sDate Date)
{
    return !IsWeekEnd(Date);
}

short DaysUntilTheEndOfWeek(sDate Date)
{
   return 6-DayOfWeekOrder(Date);
}

short DaysUntilTheEndOfMonth(sDate Date)
{
   sDate EndOfMonthDate;
   EndOfMonthDate.Year=Date.Year;
   EndOfMonthDate.Month=Date.Month;
   EndOfMonthDate.Day=NumberOfDaysInAMonth(Date.Month,Date.Year);
   return GetDifferenceInDays(Date,EndOfMonthDate,true);
}

short DaysUntilTheEndOfYear(sDate Date)
{
   sDate EndOfYearDate;
   EndOfYearDate.Year=Date.Year;
   EndOfYearDate.Month=12;
   EndOfYearDate.Day=31;
   return GetDifferenceInDays(Date,EndOfYearDate,true);
}

short CalculateVacationDays(sDate DateFrom,sDate DateTo)
{
    short Days=0;
    while(IsDate1BeforeThenDate2(DateFrom,DateTo))
    {
        if(IsBusinessDay(DateFrom))
            Days++;
        DateFrom=IncreaseDateByOneDay(DateFrom);
    }
    return Days;
}

sDate CalculateVacationReturnDate(sDate DateFrom,short VacationDays)
{
    while(VacationDays>0)
    {
        if(IsBusinessDay(DateFrom))
            VacationDays--;
        DateFrom=IncreaseDateByOneDay(DateFrom);
    }
    return DateFrom;
}

bool IsDate1AfterDate2(sDate Date1,sDate Date2)
{
    return !IsDate1BeforeThenDate2(Date1,Date2) && !IsDate1EqualDate2(Date1,Date2);
}

enum enDateCompare{Before=-1,Equal=0,After=1};

enDateCompare CompareDate(sDate Date1,sDate Date2)
{
    return (IsDate1BeforeThenDate2(Date1,Date2))?enDateCompare::Before:IsDate1EqualDate2(Date1,Date2)?enDateCompare::Equal:enDateCompare::After;
}

bool IsOverlapPeriods(sPeriods Periods1,sPeriods Periods2)
{
   if(CompareDate(Periods2.EndDate,Periods1.StartDate)==enDateCompare::Before
      ||
      CompareDate(Periods2.StartDate,Periods1.EndDate)==enDateCompare::After)
   {
       return false;
   }
   return true;
}

short PeriodLengthInDays(sPeriods Periods,bool EncludingEndDay=false)
{
    return GetDifferenceInDays(Periods.StartDate,Periods.EndDate,EncludingEndDay);
}


bool IsDateInPeriod(sPeriods Period,sDate Date)
{
    return !(CompareDate(Date,Period.StartDate)==enDateCompare::Before
       ||
       CompareDate(Date,Period.EndDate)==enDateCompare::After);
}


int CountOverlapDays(sPeriods Period1,sPeriods Period2)
{
    int Period1Length=PeriodLengthInDays(Period1,true);
    int Period2Length=PeriodLengthInDays(Period2,true);
    int OverLapDays=0;
    if(!IsOverlapPeriods(Period1,Period2))
        return 0;
    if(Period1Length<Period2Length)
    {
        while(IsDate1BeforeThenDate2(Period1.StartDate,Period1.EndDate))
        {
            if(IsDateInPeriod(Period2,Period1.StartDate))
                OverLapDays++;
            Period1.StartDate=IncreaseDateByOneDay(Period1.StartDate);
        }
     }
    else
    {
         while(IsDate1BeforeThenDate2(Period2.StartDate,Period2.EndDate))
        {
            if(IsDateInPeriod(Period1,Period2.StartDate))
                OverLapDays++;
            Period2.StartDate=IncreaseDateByOneDay(Period2.StartDate);
        }
    }


    return OverLapDays;
}

bool IsValidateDate(sDate Date)
{
   return ((Date.Month>0&&Date.Month<13)&& (Date.Day<=NumberOfDaysInAMonth(Date.Month,Date.Year))&&Date.Day>=1);
}

vector<string> SplitString(string Text,string delim)
{
    vector<string> vString;
    string Word;
    short pos=0;
    while((pos=Text.find(delim)) != Text.npos)
    {
        Word=Text.substr(0,pos);
        if(Word!="")
        {
            vString.push_back(Word);
        }
        Text.erase(0,pos+delim.length());
    }

    if(Text!="")
    {
        vString.push_back(Text);
    }
    return vString;
}

sDate StringToDateStructure(string DateString)
{
    sDate Date;
    vector<string> vDate=SplitString(DateString,"/");
    Date.Day=stoi(vDate[0]);
    Date.Month=stoi(vDate[1]);
    Date.Year=stoi(vDate[2]);
    return Date;
}

string DateToString(sDate Date)
{
    string DateString="";
    DateString+=to_string(Date.Day)+"/";
    DateString+=to_string(Date.Month)+"/";
    DateString+=to_string(Date.Year);
    return DateString;

}

string ReplaceWordUsingBulteFunction(string S1,string FromReplace,string ToReplace)
{
    int pos=0;
    while((pos=S1.find(FromReplace)) != S1.npos)
    {
        S1=S1.replace(pos,FromReplace.length(),ToReplace);
    }
    return S1;
}

string FormateDate(sDate Date,string DateFormat="dd/mm/yyyy")
{
    string FormatDateString="";
    FormatDateString=ReplaceWordUsingBulteFunction(DateFormat,"dd",to_string(Date.Day));
    FormatDateString=ReplaceWordUsingBulteFunction(FormatDateString,"mm",to_string(Date.Month));
    FormatDateString=ReplaceWordUsingBulteFunction(FormatDateString,"yyyy",to_string(Date.Year));
    return FormatDateString;
}

int main()
{
   sDate Date=GetSystemDate();
   ShowDate(Date);
  cout<<NumberOfDaysInAYear(2023)<<endl;
cout << NumberOfHoursInAYear(2023) << endl;
cout << NumberOfMinuteInAYear(2023) << endl;
cout << NumberOfSecondInAYear(2023) << endl;
    return 0;
}
