// Guids.cs
// MUST match guids.h
using System;

namespace Shoring.SharePlus
{
    static class GuidList
    {
        public const string guidSharePlusPkgString = "c531455a-e9f3-49b0-8a03-1a581d34aa8d";
        public const string guidSharePlusCmdSetString = "a7dd6f56-f6a0-4f59-9c2c-7b5799a6cd6c";


        public static readonly Guid guidSharePlusCmdSet = new Guid(guidSharePlusCmdSetString);


        public const string guidSharePlusContextMenuString = "43744006-b60d-47e5-bd0b-a60ebdfd7dbd";
        public static readonly Guid guidSharePlisContextMenuCmdSet = new Guid(guidSharePlusContextMenuString);

        //public const string guidInsertTodoString = "43744006-b60d-47e5-bd0b-a60ebdfd7dbd";
        //public static readonly Guid guidInsertTodo = new Guid("43744006-b60d-47e5-bd0b-a60ebdfd7dbd");
    };
}