using u21503193_HW01_API.Models;

namespace u21503193_HW01_API.Interfaces
{
    public interface ICourseRepo
    {
        Task<bool> AddCourse(Course course); 

        Task<List<Course>> FetchAllCourses(); 

        Task<Course> FetchCourse(int courseId); 

        Task<bool> UpdateCourse(Course course); 

        Task<bool> DeleteCourse(int CourseId);
    }
}
