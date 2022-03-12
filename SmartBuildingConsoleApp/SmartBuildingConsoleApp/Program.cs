using SmartBuildingConsoleApp.DigitalTwins;
using System;
namespace SmartBuildingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalTwinsManager dtHelper = new DigitalTwinsManager();
            // TODO
            /*
            string[] paths = new string[] {
                    @"D:\Binnies\Azure\Code\Console\SmartBuildingConsoleApp\SmartBuildingConsoleApp\Models\Chapter4\campus.json",
                    @"D:\Binnies\Azure\Code\Console\SmartBuildingConsoleApp\SmartBuildingConsoleApp\Models\Chapter4\building.json",
                    @"D:\Binnies\Azure\Code\Console\SmartBuildingConsoleApp\SmartBuildingConsoleApp\Models\Chapter4\floor.json",
                    @"D:\Binnies\Azure\Code\Console\SmartBuildingConsoleApp\SmartBuildingConsoleApp\Models\Chapter4\workarea.json",
                    @"D:\Binnies\Azure\Code\Console\SmartBuildingConsoleApp\SmartBuildingConsoleApp\Models\Chapter4\sensor.json"
            }; 
            dtHelper.CreateModel(paths);
            */

            string path = @"D:\Binnies\Azure\Code\Console\SmartBuildingConsoleApp\SmartBuildingConsoleApp\Models\Chapter4\room.json";
            dtHelper.CreateModel(path);
        }
    }
}