using u21503193_HW01_API.Data;
using u21503193_HW01_API.Interfaces;
using Microsoft.EntityFrameworkCore;
using u21503193_HW01_API.Models;

namespace u21503193_HW01_API.Services
{
    public class CourseRepo : ICourseRepo
    {
        //Establish connnection with AppDbContext
        private readonly AppDbContext _appDbContext;

        public CourseRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> AddCourse(Course course)
        {
            try
            {
                await _appDbContext.Courses.AddAsync(course);
                await _appDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<List<Course>> FetchAllCourses()
        {
            return await _appDbContext.Courses.ToListAsync(); //Get everything
        }

        public async Task<Course> FetchCourse(int courseId)
        {
            return await _appDbContext.Courses.Where(x => x.CourseId == courseId).FirstAsync(); //LinqLambda return one object
        }

        public async Task<bool> UpdateCourse(Course course)
        {
            try
            {
                _appDbContext.Courses.Update(course); //
                await _appDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteCourse(int CourseId)
        {
            try
            {
                var course = await FetchCourse(CourseId); //pass through id within FetchCourse method
                _appDbContext.Courses.Remove(course); //target Courses table and pass through var found
                await _appDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
