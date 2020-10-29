using TG.banco;
using TG.modelos.Documentacao;
using System.Collections.Generic;

namespace TG.modelos
{
    public class Colaborador : Usuario
    {

        public string Nome { get; set; }
        public Documentos Documentos { get; set; }
        public DadosPessoais DadosPessoais { get; set; }
        public List<DadosTrabalhistas> DadosTrabalhistas { get; set; }
        public List<Formacao> Formacoes { get; set; }
        public Contato Contatos { get; set; }

        public bool AtivoContratado { get; set; } //saber se a pessoa ainda esta trabalhando na empresa

        public Gerenciador.GerenciadorCursos GerenciadorCursos() => new Gerenciador.GerenciadorCursos(this.Formacoes);

        public void AtualizarDadosTrabalhistas(DadosTrabalhistas dt)
        {
            if (DadosTrabalhistas == null) DadosTrabalhistas = new List<DadosTrabalhistas>();
            DadosTrabalhistas.Add(dt);
            Atualizar();
        }

        public void AdicionarCurso(Formacao f)
        {
            if (Formacoes == null)
                Formacoes = new List<Formacao>();
            Formacoes.Add(f);
            Atualizar();
        }

        // ----------------------------------------------------------------------------------------------------

        public string TempoRegistrado()
        {
            if (DadosTrabalhistas == null) return "Recente";

            //DateTime hoje = DateTime.Today;
            //DateTime primeiroDia = DadosTrabalhistas[DadosTrabalhistas.Count - 1].DataAdmissao;

            //TimeSpan total = (primeiroDia - hoje);
            //int ano = total.Days/30/12;
            //Console.WriteLine(total);
            //int mes = total.Days % 30;
            return "!pronto";
        }

        public int CargaHorariaTotal()
        {
            if (Formacoes == null) Formacoes = new List<Formacao>();
            if (Formacoes.Count != 0)
            {
                int total = 0;
                //foreach (Formacao curso in Formacoes)
                //{
                //    if (curso.Valido) total += curso.CargaHoraria;
                //}
                return total;
            }
            else return 0;
        }

        public int Ranking() => new ColaboradorDAO().Ranking(Id) + 1;


        //Salvar - Atualizar - Deletar -----------------------------------------------------------------------

        public void Salvar()
        {
            if (DadosTrabalhistas == null) DadosTrabalhistas = new List<DadosTrabalhistas>();
            new ColaboradorDAO().Create(this);
        }

        public void Atualizar()
        {
            new ColaboradorDAO().Update(this);
        }

        public void DesativarFuncionario()
        {
            AtivoContratado = false;
            new ColaboradorDAO().Update(this);
        }

    }
}
