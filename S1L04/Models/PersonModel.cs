using System.ComponentModel.DataAnnotations; // Add to project

//Ensure that CodeLens is activated
//Select >> Tools >> Options >> Text Editor >> All Languages >> CodeLens
namespace S1L04.Models
{
    public class PersonModel
    {
        public string StuNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}