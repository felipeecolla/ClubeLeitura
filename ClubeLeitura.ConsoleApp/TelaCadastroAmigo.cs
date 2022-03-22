using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp
{
    internal class TelaCadastroAmigo
    {
        public Amigo[] amigos;
        public int numeroAmigo;
        public Notificador notificador;

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Caixas");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovoAmigo()
        {
            MostrarTitulo("Inserindo novo amigo");

            Amigo amigo = ObterAmigo();

            numeroAmigo++;

            int posicaoVazia = ObterPosicaoVazia();
            amigos[posicaoVazia] = amigo;

            notificador.ApresentarMensagem("Amigo inserido com sucesso!", "Sucesso");
        }

        private Amigo ObterAmigo()
        {
            Console.Write("Digite o nome do amigo: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome do responsável: ");
            string nomeResponsavel = Console.ReadLine();


            Console.Write("Digite o email: ");
            string email = Console.ReadLine();


            Console.Write("Digite o telefone: ");
            string telefone = Console.ReadLine();


            Console.Write("Digite o endereço: ");
            string endereco = Console.ReadLine();

            Amigo amigos = new Amigo();

            amigos.nomeAmigo = nome;
            amigos.nomeResposavel = nomeResponsavel;
            amigos.email = email;
            amigos.telefone = telefone;
            amigos.endereco = endereco;

            return amigos;
        }
        public void EditarAmigo()
        {
            VisualizarAmigos("Editando amigo");

            VisualizarAmigos("Pesquisando");

            Console.Write("Digite o nome do amigo que você quer editar: ");
            string nome = (Console.ReadLine());

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].nomeAmigo == nome)
                {
                    Amigo amigo = ObterAmigo();

                    amigos[i].nomeAmigo = nome;
                    amigos[i] = amigo;

                    break;
                }
            }

            notificador.ApresentarMensagem("Caixa editada com sucesso", "Sucesso");
        }
        public void MostrarTitulo(string titulo)
        {
            Console.Clear();

            Console.WriteLine(titulo);

            Console.WriteLine();
        }

        public void ExcluirAmigo()
        {
            MostrarTitulo("Excluindo Amigo");

            VisualizarAmigos("Pesquisando");

            Console.Write("Digite o nome do amigo que deseja excluir: ");
            string nome = (Console.ReadLine());

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].nomeAmigo == nome)
                {
                    amigos[i] = null;
                    break;
                }
            }
            notificador.ApresentarMensagem("Amigo excluído com sucesso", "Sucesso");
        }
        public void VisualizarAmigos(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização de Amigos");

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                    continue;

                Amigo a = amigos[i];

                Console.WriteLine("Nome: " + a.nomeAmigo);
                Console.WriteLine("Nome responsável: " + a.nomeResposavel);
                Console.WriteLine("Email: " + a.email);
                Console.WriteLine("Endereço: " + a.endereco);
                Console.WriteLine("Telefone: " + a.telefone);
                Console.WriteLine();
            }
          
        }
        public int ObterPosicaoVazia()
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                    return i;
            }

            return -1;
        }
    }
}
