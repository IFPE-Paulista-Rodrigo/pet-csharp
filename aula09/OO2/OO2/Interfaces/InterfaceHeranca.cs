using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Interfaces
{
    public interface IUndoable { void Undo(); }

    public interface IReadoable : IUndoable { void Redo();  }

/*
    public class MyClass : IUndoable
    {

    }*/
}
