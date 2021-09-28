using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Interfaces
{

    public class TextBox : IUndoable
    {
        public virtual void Undo() => Console.WriteLine("TextBox.Undo");
    }

    public class RichTextBox : TextBox
    {
        public override void Undo()
        {
            Console.WriteLine("RichTextBox.Undo");
        }
    }


}


