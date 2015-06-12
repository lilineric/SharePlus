using EnvDTE;
using Microsoft.VisualStudio.Shell.Interop;
using Shoring.SharePlus.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareCommand = Share.Command;

namespace Shoring.SharePlus.Operate
{
    internal class SvnPlus : OperateBase
    {
        IVsUIShell uiShell;

        internal SvnPlus(DTE dte, IVsUIShell uiShell)
            : base(dte)
        {
            this.uiShell = uiShell;
        }

        internal void CommitCallback(object sender, EventArgs e)
        {
            SvnOperate("svn commit", "-m 'F236'");
        }

        internal void UpdateCallback(object sender, EventArgs e)
        {
            SvnOperate("svn update");
        }

        internal void AddAndCommitCallback(object sender, EventArgs e)
        {
            SvnOperate("svn add");
            SvnOperate("svn commit", "-m 'F236'");
        }

        void SvnOperate(string command, string comment = "")
        {
            var items = dte.SelectedItems;
            if (items.Count <= 0)
            {
                return;
            }
            for (short i = 1; i < items.Count + 1; i++)
            {
                ShareCommand cmd = new ShareCommand((x) => System.Diagnostics.Debug.WriteLine(x), (x) =>
                {
                    if (string.IsNullOrEmpty(x))
                    {
                        return;
                    }
                    System.Diagnostics.Debug.WriteLine(x);
                    MessageBox.Show(uiShell, x);
                });
                cmd.Excute(command + " " + items.Item(i).ProjectItem.get_FileNames(i) + " " + comment);
            }
        }

        
    }
}
