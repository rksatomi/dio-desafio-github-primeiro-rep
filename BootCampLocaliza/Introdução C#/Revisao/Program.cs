using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos =new Aluno[5];
            var indeceAluno=0;
            string opcaoUsuario = ObterOpcao();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: Adionar alunos 
                        Console.WriteLine("Informe o nome do aluno");
                        Aluno aluno =new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o nota do aluno");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota; 
                        } 
                        else
                        {
                            throw new Exception("Valor da nota deve ser decimal");
                        }
                        alunos[indeceAluno]=aluno;
                        indeceAluno++;                          

                        break;
                    case "2":
                        //TODO: Listar alunos 
                        foreach(var a in alunos)
                        {
                            if(a.Nome != null){
                                Console.WriteLine($"Aluno: {a.Nome}  -  Nota: {a.Nota}");
                            }
                        }
                        break;
                    case "3":
                        //TODO: Calcular média geral alunos
                        decimal notaTotal=0;
                        var nrAlunos=0;

                        for(int i=0;i<alunos.Length;i++){
                            if(!string.IsNullOrEmpty(alunos[i].Nome)){
                                notaTotal+=alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral=notaTotal/nrAlunos;
                        Conceito conceitoGeral;
                        if(mediaGeral <= 3)
                        {
                            conceitoGeral=Conceito.E;
                        }
                        if(mediaGeral <= 5)
                        {
                            conceitoGeral=Conceito.D;
                        }
                        else if(mediaGeral <= 7)
                        {
                            conceitoGeral=Conceito.C;
                        }
                        else if(mediaGeral <= 9)
                        {
                            conceitoGeral=Conceito.B;
                        } 
                        else if(mediaGeral >= 9)
                        {
                            conceitoGeral=Conceito.A;
                        }

                        Console.WriteLine($"Media geral: {mediaGeral}  -  Conceito: {conceitoGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcao();
              


            }
        }

        private static string ObterOpcao()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1. Inserir novo aluno:");
            Console.WriteLine("2. Listar alunos:");
            Console.WriteLine("3. Calcular média geral:");
            Console.WriteLine("X. Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}