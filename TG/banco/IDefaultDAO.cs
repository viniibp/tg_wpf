using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.banco
{
    interface IDefaultDAO<T>
    {
        void Create();

        T Find();

        T FindAll();

        void Update();

        void Remove();
    }
}
