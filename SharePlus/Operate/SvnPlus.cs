using EnvDTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoring.SharePlus.Operate
{
    internal class SvnPlus : OperateBase
    {
        public SvnPlus(DTE dte)
            : base(dte)
        {

        }

        public void CommitCallback(object sender, EventArgs e)
        {
            //TODO:
        }

        public void UpdateCallback(object sender, EventArgs e)
        {
            //TODO:
        }
    }
}
