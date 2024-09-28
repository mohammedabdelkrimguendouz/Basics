

using EntityFrameWork_Test;
using EntityFrameWork_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Diagnostics.Metrics;

////Add
using (AppDbContext dbContext = new AppDbContext())
{
    Country country = new Country()
    {
        //CountryName = "algeria"
    };

    dbContext.Countries.Add(country);
    dbContext.SaveChanges();
}



////Update
using (AppDbContext dbContext = new AppDbContext())
{

    Country? country = dbContext.Countries.Find(1);
    if (country == null)
        return;


    country.CountryName = "algeriaUpdated";

    dbContext.SaveChanges();
}


//// Find
//using (AppDbContext dbContext = new AppDbContext())
//{

//    Country? country = dbContext.Countries.AsNoTracking().SingleOrDefault(country => country.CountryID == 1);
//    if (country == null)
//        return;

//    Console.WriteLine("id : " + country.CountryID);
//    Console.WriteLine("name : " + country.CountryName);

//}


// GetAll
using (AppDbContext dbContext = new AppDbContext())
{
    List<Country> list = new List<Country>();
    list = dbContext.Countries.AsNoTracking().ToList();
    foreach (Country country in list)
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("id : " + country.CountryID);
        Console.WriteLine("name : " + country.CountryName);
    }

}

////Delete
using (AppDbContext dbContext = new AppDbContext())
{

    Country? country = dbContext.Countries.Find(2);
    if (country == null)
        return;

    dbContext.Countries.Remove(country);
    dbContext.SaveChanges();

}










//// Find Student
//using (AppDbContext dbContext = new AppDbContext())
//{

//    Student? student = dbContext.Students.AsNoTracking().Include(s => s.CountryInfo).Include(s => s.GradeInfo)
//        .SingleOrDefault(s => s.StudentID == 1);

//    if (student == null)
//        return;

//    Console.WriteLine("id : " + student.StudentID);
//    Console.WriteLine("name : " + student.FullName);
//    Console.WriteLine("Email : " + student.Email);
//    Console.WriteLine("phone : " + student.Phone);
//    Console.WriteLine("date of birth : " + student.DateOfBirth);
//    Console.WriteLine("age : " + student.Age);
//    Console.WriteLine("gender : " + student.Gender);
//    Console.WriteLine("Grade ID : " + student.GradeID);
//    Console.WriteLine("Algorithm : " + student.GradeInfo.Algorithm);
//    Console.WriteLine("React : " + student.GradeInfo.React);
//    Console.WriteLine("Grade ID : " + student.GradeID);
//    Console.WriteLine("Country id : " + student.CountryID);
//    Console.WriteLine("Country Name : " + student.CountryInfo.CountryName);
//}



