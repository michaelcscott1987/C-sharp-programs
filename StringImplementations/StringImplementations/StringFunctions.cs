using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringImplementations
{
    interface StringFunctions
    {
        int Counter { get; }
        string[] Insert_String(int index, String element);
        String RemoveAt_Index(int index);			 
        String ElementAt_Index(int index);			 
        void Set_String(int index, String element);		 
	void Add_String(String element);			 
        bool Remove_String(String element);
        bool Contains_String(String element);
        int IndexOf_String(String element);
        bool IsEmpty_String();
        string[] Clear_String();
    }

}
