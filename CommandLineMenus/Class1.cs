using System;
using System.Collections.Generic;
using System.Text;

namespace CommandLineMenus
{
    interface ICommandMenuDisplay
    {
        string NameColumn { get; }
        string DescriptionColumn { get; }
    }
}
