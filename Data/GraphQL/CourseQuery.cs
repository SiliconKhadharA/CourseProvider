using Data.Models;
using Data.Services;

namespace Data.GraphQL;

public class CourseQuery(CourseService courseService)
{
    private readonly CourseService _courseService = courseService;

    [GraphQLName("getCourses")]

    public async Task<IEnumerable<Course>> GetCoursesAsync()
    {
        return await _courseService.GetCoursesAsync();
    }



    [GraphQLName("getCoursesById")]

    public async Task<Course> GetCourseByIdAsync(string id)
    {
        return await _courseService.GetCourseByIdAsync(id);
    }
}
