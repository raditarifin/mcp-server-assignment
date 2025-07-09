using ModelContextProtocol.Server;
using System.ComponentModel;


namespace MCPServer.mcp_server
{
    [McpServerToolType]
    public static class DayOfWeekTool
    {
        [McpServerTool, Description("Get the current day of the week")]
        public static string GetDayOfWeek()
        {
            var today = DateTime.Now.ToString("dddd");
            return $"Today is {today}.";
        }
    }

    [McpServerToolType]
    public static class MathTool
    {
        [McpServerTool, Description("Multiply two numbers")]
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
