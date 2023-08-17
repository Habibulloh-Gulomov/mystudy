public interface IUnitOfWork
{
    IRepository<Student> Students { get; }
    IRepository<Mentor> Mentors { get; }
    IRepository<Course> Courses { get; }
    IRepository<Group> Groups { get; }
    void Commit();
    void SaveChanges();
}
