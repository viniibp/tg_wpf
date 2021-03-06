﻿using System.Collections.Generic;
using System.Windows.Controls;

namespace TG.modelos.Gerenciador
{
    public class GerenciadorCursos
    {
        private List<Formacao> Cursos;
        public int Pontuacao { get; set; }
        public double Media { get; set; }
        public int Validos { get; set; }

        public GerenciadorCursos(List<Formacao> cursos)
        {
            Cursos = cursos;
            CalcPontuacao();
            CalcularMedia_Validos();
        }

        private void CalcPontuacao()
        {
            int pt = 0;
            if (Cursos != null)
            {
                Cursos.ForEach(f =>
                {
                    if (f.Valido)
                    {
                        pt += f.Pontos;
                    }
                });
            }
            Pontuacao = pt;
        }

        private void CalcularMedia_Validos()
        {
            int somaPesos = 0, validos = 0;
            double mediaPeso = 0;
            if (Cursos != null)
            {
                Cursos.ForEach(f =>
                {
                    if (f.Valido)
                    {
                        somaPesos += f.Peso;
                        validos++;
                    }
                });
                if (somaPesos == 0 || validos == 0) mediaPeso = 0;
                else mediaPeso = (somaPesos / validos);
            }
            Media = mediaPeso;
            Validos = validos;
        }

        public int TotalCursos() => Cursos != null ? Cursos.Count : 0;

        public Nivel Nivel(ProgressBar pb, int xp)
        {
            Nivel lvl = new Nivel(xp);
            pb.Minimum = lvl.Min;
            pb.Maximum = lvl.Max;
            pb.Value = xp;
            return lvl;
        }

        public int Nivel(int xp)
        {
            int lvl = new Nivel(xp).Level;
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