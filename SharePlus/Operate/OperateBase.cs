using EnvDTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoring.SharePlus.Operate
{
    internal abstract class OperateBase
    {
        public const string Property = "#p";   //代码段标记，表示属性: property
        public const string PropertyComplete = "#pc";  //代码段标记，表示包含私有成员的完整属性: property complete

        protected DTE dte;

        public Document CurrentDocument
        {
            get
            {
                return dte.ActiveDocument;
            }
        }

        public OperateBase(DTE dte)
        {
            this.dte = dte;
        }
    }
}
