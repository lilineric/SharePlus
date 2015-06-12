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
        public EditorPlus(DTE dte)
            : base(dte)
        {

        }

        public void InsertTodoCallback(object sender, EventArgs e)
        {
            var activeDocument = dte.ActiveDocument;
            if (activeDocument == null)
            {
                return;
            }

            var selection = activeDocument.Selection as TextSelection;
            selection.Insert(@"//TODO:");
        }
    }
}
