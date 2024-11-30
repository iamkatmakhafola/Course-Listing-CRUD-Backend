using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using u21503193_HW01_API.Interfaces;
using u21503193_HW01_API.Models;

namespace u21503193_HW01_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepo _courseRepo;

        public CourseController(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }

        //EndPoints
        [HttpGet]
        [Route("fetchAllCourses")]

        public async Task<IActionResult> FetchAllCourses() 
        {
            try
            {
                return Ok(await _courseRepo.FetchAllCourses());
            }
            catch (Exception)
            {
                return BadRequest("Hmmm, something's not right. Please hold on and try again shortly :(");
            }
        }

        [HttpGet]
        [Route("fetchAllCourses/{CourseId}")] 

        public async Task<IActionResult> FetchCourse(int CourseId)
        {
            try
            {
                var course = await _courseRepo.FetchCourse(CourseId); 
                if (course == null)
                {
                    return NotFound("Course not found");
                }
                return Ok(course);
            }
            catch (Exception)
            {
                return BadRequest("Hmmm, something's not right. Please hold on and try again shortly :(");
            }
        }

        [HttpPost]
        [Route("addCourse")]

        public async Task<IActionResult> AddCourse([FromBody] Course course) 
        {
            try
            {
                var response = "Successfully added course :)";
                var added = await _courseRepo.AddCourse(course);//
                if (!added)//Switch message
                {
                    response = "Failed to add course :(";
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest("Hmmm, something's not right. Please hold on and try again shortly :(");
            }
        }

        [HttpPost]
        [Route("updateCourse")]

        public async Task<IActionResult> UpdateCourse([FromBody] Course course) 
        {
            try
            {
                var response = "Succesfully updated course :)";
                var updated = await _courseRepo.UpdateCourse(course);
                if (!updated)
                {
                    response = "Failed to update course :(";
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest("Hmmm, something's not right. Please hold on and try again shortly :("); 
            }
        }

        [HttpGet]
        [Route("deleteCourse/{CourseId}")]

        public async Task<IActionResult> DeleteCourse(int CourseId)
        {
            try
            {
                var response = "Succesfully deleted course :)";
                var deleted = await _courseRepo.DeleteCourse(CourseId);
                if (!deleted)
                {
                    response = "Failed to delete :(";
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest("Hmmm, something's not right. Please hold on and try again shortly :(");
            }
        }
    }
}
