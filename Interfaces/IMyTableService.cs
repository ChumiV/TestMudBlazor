using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMudBlazor.Models;

namespace TestMudBlazor.Interfaces
{
    interface IMyTableService
    {
        List<MyTable> GetTableData(); 
    }
}
