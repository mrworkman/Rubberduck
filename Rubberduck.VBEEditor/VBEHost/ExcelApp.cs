using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Rubberduck.VBEditor.VBEHost
{
    public class ExcelApp : HostApplicationBase<Application>
    {
        public ExcelApp() : base("Excel") { }

        public override void Run(QualifiedMemberName qualifiedMemberName)
        {
            try 
            {
                Application.Run(GenerateMethodCall(qualifiedMemberName));
            }
            catch (COMException comException)
            {
                unchecked
                {
                    if (comException.ErrorCode == (int)0x800A9C68)
                        Debug.WriteLine(comException.Message);
                    else
                        throw;
                }
            }
        }

        protected virtual string GenerateMethodCall(QualifiedMemberName qualifiedMemberName)
        {
            return qualifiedMemberName.ToString();
        }
    }
}