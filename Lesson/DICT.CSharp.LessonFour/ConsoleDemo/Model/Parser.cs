using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Model
{
    class BaseParser
    {
        public string SplitSequence()
        {
            return "";
        }
    }

    class CsvParser : BaseParser
    {
        public string SplitCsv()
        {
            return SplitSequence();
        }
    }

    class PipeParser : BaseParser
    {
        public string SplitPipe()
        {
            return SplitSequence();
        }
    }
}
