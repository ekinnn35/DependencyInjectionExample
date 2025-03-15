namespace DependencyInjectionExample.Entities
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public ClassRoom() { } // Parametresiz constructor

        public ClassRoom(Teacher teacher)
        {
            Teacher = teacher;
            TeacherId = teacher.Id;
        }

        public string GetTeacherInfo()
        {
            return Teacher.GetInfo();
        }
    }
}
