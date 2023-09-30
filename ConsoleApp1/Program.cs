using System;

namespace Maldade{
    class Ruindade{
        static void Main(String[] args){
            
           GeneralInfo infoObject =new GeneralInfo();
            Console.WriteLine(infoObject.uName);
            Console.WriteLine(infoObject.ipv4address);
            Console.WriteLine(infoObject.pId);
            Console.WriteLine(infoObject.oSystem);
            Console.WriteLine(infoObject.ePath);
            Console.WriteLine(infoObject.hostName);
            Console.WriteLine(infoObject.pName);
            Console.WriteLine(infoObject.cDirectory);
        }
    }
}