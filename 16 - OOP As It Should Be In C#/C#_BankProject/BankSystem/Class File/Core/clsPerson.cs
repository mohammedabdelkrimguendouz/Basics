using System;
public abstract class clsPerson
{
    public string FirstName {  get; set; }  
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public string FullName
    {
        get { return FirstName+" "+LastName; }
    }
        
    public clsPerson(string FirstName,string LastName,string Email,string Phone) 
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Email = Email;
        this.Phone = Phone;
    }

   
}

