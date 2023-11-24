using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365.Setup
{
    public static class PSHelper
    {

        public static PowerShellOutput RunPowerShellCommand(string command)
        {
            PowerShellOutput retPSOutput = new PowerShellOutput();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "powershell.exe";
            psi.Arguments = "-NoProfile -ExecutionPolicy unrestricted -Command " + command;
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            
            psi.WorkingDirectory = Path.GetDirectoryName(GlobalVariables.XmlFilePath);
            psi.Verb = "runas";



            using (Process powershell = Process.Start(psi))
            {
                if (powershell != null)
                {

                    using (StreamReader errorReader = powershell.StandardError)
                    {
                        string errorOutput = errorReader.ReadToEnd();
                        if (!string.IsNullOrEmpty(errorOutput))
                        {
                            retPSOutput.Success = false;
                            retPSOutput.Message = errorOutput;
                            return retPSOutput;
                        }
                    }


                    using (System.IO.StreamReader outputReader = powershell.StandardOutput)
                    {
                        retPSOutput.Success = true;
                        retPSOutput.Message = outputReader.ReadToEnd(); ;
                        return retPSOutput;
                    }
                }
                else
                {
                    retPSOutput.Success = false;
                    retPSOutput.Message = "General Powershell Error";
                    return retPSOutput;
                }
            }
        }



    }

    public class PowerShellOutput
    {
        public bool Success { get; set; }
        public string Message { get; set; }

    }
}