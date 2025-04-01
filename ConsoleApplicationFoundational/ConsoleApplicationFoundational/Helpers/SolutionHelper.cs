namespace ConsoleApplicationFoundational.Helpers
{
    public static class SolutionHelper
    {
        public static string GetSolutionPath()
        {
            var currentDirectory = Directory.GetCurrentDirectory();

            var solutionPath = Directory.GetParent(currentDirectory)?.Parent?.Parent?.FullName;

            if (solutionPath == null || solutionPath == string.Empty)
                throw new Exception("Path Not Found");

            return solutionPath;
        }
    }
}
