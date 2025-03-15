using DependencyInjectionExample.Interfaces;

namespace DependencyInjectionExample.Entities
{
    public class Teacher : ITeacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
            return $"Teacher: {FirstName} {LastName}";
        }
    }
}
