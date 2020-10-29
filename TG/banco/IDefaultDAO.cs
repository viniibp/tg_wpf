using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.banco
{
    interface IDefaultDAO<T>
    {
        void Create(T colab);

        T Find(T colab);

        List<T> FindAll();

        void Update(T colab);

        void Remove(T colab);
    }
}
