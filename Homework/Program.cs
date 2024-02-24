using Homework.Business.Concretes;
using Homework.DataAccess.Concretes;
using Homework.Entities.Concretes;


Course course1 = new Course()
{
    Id = 5,
    InstructorName = "1",
    Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
    PercentageProgress = 10
};


CourseManager courseManager = new(new CourseDal());

List<Course> courses = courseManager.GetAll();

foreach (var course in courses)
{
    Console.WriteLine(course.Name);
}


courseManager.Add(course1);

List<Course> courses1 = courseManager.GetAll();

foreach (var course in courses1)
{
    Console.WriteLine(course.Name);
}


courseManager.Delete(5);

List<Course> courses2 = courseManager.GetAll();

foreach (var course in courses2)
{
    Console.WriteLine(course.Name);
}
