using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LogRepoModularis;
using LogRepoModularis.Tools;

namespace ModularisTest
{
    public  class JobLogger 
    {
        private readonly IlogModularis _ilogModularis;

    
        public JobLogger(IlogModularis ilogModularis)
        {
            _ilogModularis = ilogModularis;
        }

        public void writeLog()
        {
            _ilogModularis.WriteLogConsole(ErrorType.ErrorTypes.Error,"mensaje de prueba Consola");
            _ilogModularis.WriteLogTextFile(ErrorType.ErrorTypes.Error, "mensaje de prueba TextFile");
            _ilogModularis.WriteLogDataBase(ErrorType.ErrorTypes.Error, "mensaje de prueba DataBase");
            _ilogModularis.WriteLogAllOutPut(ErrorType.ErrorTypes.Error, "mensaje de prueba All OutPut");
        }
    }
}
