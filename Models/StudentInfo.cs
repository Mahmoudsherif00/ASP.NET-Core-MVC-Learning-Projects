using System.Collections.Generic;
using System.Linq;
namespace WebApplication2.Models
{
    public class StudentInfo
    {
        List<Student> students = new List<Student>();
        public StudentInfo() { 
        
            students.Add(new Student{ id=1,name ="Mahmoud",image="img1.jpg", age="21", address="cairo"});
            students.Add(new Student{ id=2,name ="Mohamed",image= "img2.jpg", age="20", address="cairo"});
            students.Add(new Student{ id=3,name ="ali",image= "img4.jpg", age="29", address="cairo"});
            students.Add(new Student{ id=4,name ="hana",image= "img3.jpg", age="9", address="cairo"});
            students.Add(new Student{ id=5,name ="jeo",image= "img5.jpg", age="26", address="cairo"});
            students.Add(new Student{ id=6,name ="talal",image= "img6.jpg", age="15", address="cairo"});
        
        }
        public List<Student> getall()
        {
            return students; 
        }
        public Student getid(int id)
        {
            return students.FirstOrDefault(p => p.id == id);
        }
    }
}
