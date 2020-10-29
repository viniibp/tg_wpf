using System.Collections.Generic;
using System.Windows.Forms;

namespace TG.modelos.Gerenciador
{
    public class GerenciadorCursos
    {
        private List<Formacao> Cursos;

        public GerenciadorCursos(List<Formacao> cursos)
        {
            Cursos = cursos;
        }

        public int Pontuacao()
        {
            int pt = 0;
            Cursos.ForEach(f => {
                if (f.Valido)
                {
                    pt += f.Pontos;
                }
            });
            return pt;
        }

        public (double, int) CalcularMedia_Validos()
        {
            int somaPesos = 0, validos = 0;
            Cursos.ForEach(f => {
                if (f.Valido)
                {
                    somaPesos += f.Peso;
                    validos++;
                }
            });
            double mediaPeso;
            if (somaPesos == 0 || validos == 0) mediaPeso = 0;
            else mediaPeso = (somaPesos / validos);
            return (mediaPeso, validos);
        }

        public int TotalCursos() => Cursos.Count;

        public Nivel Nivel(ProgressBar pb, int xp)
        {
            Nivel lvl = new Nivel(xp);
            pb.Minimum = lvl.Min;
            pb.Maximum = lvl.Max;
            pb.Value = xp;
            return lvl;
        }

    }

    public class Nivel
    {
        public int Min { get; }
        public int Max { get; }
        public int Level { get; }

        public Nivel(int xp)
        {
            Level = CalcLevel(xp);
            Min = CalcMin(Level);
            Max = CalcMax(Level);
        }

        private int CalcLevel(int xp)
        {
            if (xp == 0) return xp;
            int nivel = 0;
            while (xp > CalcMax(nivel)) nivel++;
            return nivel;
        }

        private int Pot(int num, int pot) //Calcula potencia
        {
            if (pot == 0) return 1;
            if (pot == 1) return num;
            return num * Pot(num, pot - 1);
        }

        private int CalcMax(int nivel) // 300 * (2**(nivel-1)) -1
        {
            if (nivel == 0) return 0;
            return 300 * Pot(2, nivel - 1) - 1;
        }

        private int CalcMin(int nivel) // 300 * (2**(nivel-2))
        {
            if (nivel == 0) return 0;
            if (nivel == 1) return 1;
            return 300 * Pot(2, (nivel - 2));
        }

    }

}