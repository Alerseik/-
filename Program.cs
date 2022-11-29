using System;
using InspectorLib;

namespace контрольная_работа
{
    class Program
    {
      
        static void Main(string[] args)
        {
            FunctionInsp funct = new FunctionInsp();
            funct.GetInspector();// 1 задание
            funct.GetСarInspection();// 2 задание
            funct.SetInspector();// 3 задание


            funct.GenerateNumber();// 4 задание
            funct.GetWorker(); // 5 задание
            funct.AddWorker(); // 6 задание
            
        }
      





    }
}
