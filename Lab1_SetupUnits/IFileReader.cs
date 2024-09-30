using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_SetupUnits
{
    public interface IFileReader
    {
        string[] Read(string path);
    }
}
