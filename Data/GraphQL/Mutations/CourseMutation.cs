
using Data.Models;
using Data.Services;

namespace Data.GraphQL.Mutations;

public class CourseMutation(CourseService courseService)
{
    private readonly CourseService _courseService = courseService;

    [GraphQLName("createCourse")]

    public async Task<Course> CreateCourseAsync(CourseCreateRequest request)
    {
        return await _courseService.CreateCourseAsync(request);
    }

    [GraphQLName("updateCourse")]

    public async Task<Course> UpdateCourseAsync(CourseUpdateRequest request)
    {
        return await _courseService.UpdateCourseAsync(request);
    }

    [GraphQLName("deleteCourse")]

    public async Task<bool> DeleteCourseAsync(string id)
    {
        return await _courseService.DeleteCourseAsync(id);
    }

}
