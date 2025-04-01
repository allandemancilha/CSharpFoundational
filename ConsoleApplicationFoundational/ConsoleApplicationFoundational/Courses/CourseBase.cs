using ConsoleApplicationFoundational.Courses;
using ConsoleApplicationFoundational.Enums;
using ConsoleApplicationFoundational.Helpers;
using System.Text.Json;

public abstract class CourseBase
{
    protected int CourseId { get; set; }


    protected abstract void SetCourseId();
    protected abstract void PrintCourseName();
    protected abstract void ExecuteCourseLogic();

    public static void Create(CoursesEnum courseType)
    {
        CourseBase course = courseType switch
        {
            CoursesEnum.WriteYourFirstCode => new WriteYourFirstCode(),
            CoursesEnum.CreateSimpleConsoleApplications => new CreateSimpleConsoleApplications(),
            _ => throw new ArgumentException("Invalid Course Type", nameof(courseType)),
        };

        course.SetCourseId();
        course.PrintCourseName();
        course.ExecuteCourseLogic();
    }

    protected virtual uint GetCurrentModule(int courseId)
    {
        var configFileContent = GetJsonConfig();

        using JsonDocument configJsonContent = JsonDocument.Parse(configFileContent);

        var coursesArray = configJsonContent.RootElement.GetProperty("Courses").EnumerateArray();

        var selectedCourse = coursesArray.FirstOrDefault(course => course.GetProperty("CourseId").GetInt32() == courseId);

        if (selectedCourse.ValueKind == JsonValueKind.Undefined)
            throw new InvalidOperationException($"Course {courseId} Not Found.");

        var modulesArray = selectedCourse.GetProperty("Modules").EnumerateArray();

        var moduleInProgress = modulesArray.FirstOrDefault(module => module.GetProperty("Status").GetInt32() == Convert.ToInt32(StatusEnum.InProgress));

        if (moduleInProgress.ValueKind == JsonValueKind.Undefined)
            throw new InvalidOperationException($"Module In Progress Not Found.");

        return moduleInProgress.GetProperty("ModuleId").GetUInt32();
    }

    private static string GetJsonConfig()
    {
        var extensionFile = EnumHelper.GetEnumDescription(ExtensionEnum.JSON);

        var configFilePath = Directory.GetFiles(SolutionHelper.GetSolutionPath(), $"*{extensionFile}").FirstOrDefault();

        if (configFilePath == null || configFilePath == string.Empty)
            throw new Exception("Configurantion File Not Found");

        if(!File.Exists(configFilePath))
            throw new Exception($"File Not Found: {configFilePath}");

        return File.ReadAllText(configFilePath);
    }


    protected virtual void GetCourseName()
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine(EnumHelper.GetEnumDescriptionFromInt<CoursesEnum>(CourseId));
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("");
    }

}
