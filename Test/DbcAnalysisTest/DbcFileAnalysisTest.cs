using DBCAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DbcAnalysisTest
{
    class DbcFileAnalysisTest : BaseTest
    {
        public override bool TestExcute()
        {

            DbcFileAnalysis dbcFileAnalysis = new DbcFileAnalysis();
            string path = "D:\\MyWork\\采集器\\HK2010(4V+4T).dbc";//Console.ReadLine();
            dbcFileAnalysis.SetDbcFile(path);
            dbcFileAnalysis.Execute();
            return true;
        }
    }
}
