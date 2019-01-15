using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace DataStructures_Algorithms.Week04
{
    public interface IEnumerator<T>
    {
        bool MoveNext();
        void Reset();
        void Dispose();
    }
    public class ListEnumerator<T> : IEnumerator<T>
    {
        bool disposed = false;

        int position = -1;

        public ListEnumerator<T> Current { get; }

        public bool MoveNext()
        {
           
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            if(disposed) return;
            GC.SuppressFinalize(this);
        }

    }
}
