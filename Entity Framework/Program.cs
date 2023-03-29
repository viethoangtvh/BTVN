// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{

    static void Main(string[] args))
    {

        { Console.OutputEncoding = ecoding.UTF8:
            using (var select = from s in DBNull.studens select s) ;
            foreach (var data in select)
            {
            Console.WriteLine("ID:{ 0}", data.StudenID);
            Console.WriteLine("Name:{ 0}", data.StudenName);
            Console.WriteLine("Gender:{ 0}", data.StudenGender);
            Console.WriteLine("Address:{ 0}", data.Address) );
    }
}
    Console.ReadLine();
}
}
// Thông tin của sinh viên được thêm mới
var student = new Student();
student.StudentID = 2;
student.StudentName = "Nguyễn Nam ";
student.StudentGender = "Nam";
student.Address = " Đà Nẵng";
// Thêm vào database
using (var db = new EntityDBEntities())
{
    db.Students.Add(student);
    db.SaveChanges();
}
using (var db = new EntityDBEntities())
{
    var delete = (from d in db.Students where d.StudentID == 3 select d).Single();
    db.Students.Remove(delete);
    db.SaveChanges();
}