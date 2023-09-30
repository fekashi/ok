using System;
using System.Diagnostics;
using System.Net;

namespace Maldade
{
    class GeneralInfo
    {
      public string oSystem; //pegando o SO
        public string uName; //guardando o nome do buxa
        public string cDirectory; //diretorio atual
        public string pName; //guardando nome do processo
        public string ePath; //path do bin
        public string ipv4address; //ipv4
	public string hostName;
        public int pId; //id do processo
        public bool isAdmin; //checando se o bico é adm

        public GeneralInfo(){

            oSystem = Environment.OSVersion.ToString();
            uName = Environment.UserName;
            cDirectory = Environment.CurrentDirectory;
            pName = Process.GetCurrentProcess().ProcessName;
            pId = Process.GetCurrentProcess().Id;
            ePath = Process.GetCurrentProcess().MainModule.FileName;
            hostName = Dns.GetHostName();
            ipv4address = Dns.GetHostByName(hostName).AddressList[1].ToString();
            using var identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            var principal = new System.Security.Principal.WindowsPrincipal(identity);
            isAdmin = principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
        }
    }
}

