using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TG.modelos;

namespace TG
{
    public static class Session
    {
        private static Colaborador Sessao;

        public static Colaborador GetColaborador() => Sessao;
        public static void SetSessao(Colaborador f) => Sessao = f;
        public static void CloseSession() => Sessao = null;

    }
}
