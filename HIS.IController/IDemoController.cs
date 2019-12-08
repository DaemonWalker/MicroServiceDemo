using System;

namespace HIS.IController
{
    public interface IDemoController
    {
        string GetString();
        string GetString(string parm);
        object GetObj(string name, int index);
    }
}
