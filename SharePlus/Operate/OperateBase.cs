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
