#pragma warning(disable : 4996)

#include<iostream>
#include<ctime>
using namespace std;

int main()
{
    time_t t=time(0);
    char* dt=ctime(&t); // convert to string
    cout<<" Local Date and Time is : "<<dt<<endl;

    tm* now=gmtime(&t); // conerting now to tm struct for UTC date/time // (غرينتش)
    cout<<"Year : "<<now->tm_year+1900<<endl;
    cout<<"Month : "<<now->tm_mon+1<<endl;
    cout<<"Day : "<<now->tm_mday<<endl;
    cout<<"Hour : "<<now->tm_hour<<endl;
    cout<<"Min : "<<now->tm_min<<endl;
    cout<<"Second : "<<now->tm_sec<<endl;
    cout<<"Week day ( day since sunday ) : "<<now->tm_wday<<endl; // ترتيب اليوم في الاسبوم من يوم الاحد
    cout<<"Yeek day ( Year since Jnr 1st ) : "<<now->tm_yday<<endl; // عدد الايام ابتدام من واحد جانفي
    cout<<"Hours ofday light saving time  : "<<now->tm_isdst<<endl;
    dt=asctime(now); // convert to string
    cout<<"(grinthe) UTC Date and Time is : "<<dt<<endl;
    return 0;
}
