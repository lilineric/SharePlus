using EnvDTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoring.SharePlus.Operate
{
    internal class EditorPlus : OperateBase
    {
        internal EditorPlus(DTE dte)
            : base(dte)
        {

        }

        internal void InsertTodoCallback(object sender, EventArgs e)
        {
            if (CurrentDocument == null)
            {
                return;
            }

            var selection = CurrentDocument.Selection as TextSelection;
            selection.Insert(@"//TODO:");
        }

        internal void OpenExplore(object sender, EventArgs e)
        {
            if (CurrentDocument == null)
            {
                return;
            }
            System.Diagnostics.Process.Start("Explorer.exe", " /select," + CurrentDocument.Path + CurrentDocument.Name);
        }
    }
}
