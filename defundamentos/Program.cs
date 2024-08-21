using defundamentos;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{


    private static void Main(string[] args)
    {
        //        //Instanciar um objeto de tipo Aluno
        //        Aluno aluno1 = new Aluno();
        //        Aluno aluno2 = new Aluno();
        //        Aluno aluno3 = new Aluno();

        //        //Preencher os atributos do objeto
        //        aluno1.Nome = "Ana clara chiaramonte Lopes";
        //        aluno1.RM = "3489TI";
        //        aluno1.Email = "ana.chiaramonte@portalsesisp.org.br";
        //        aluno1.Nascimento = new DateOnly(2007, 05, 20);

        //        aluno2.Nome = "Ana julia geremias ";
        //        aluno2.RM = "3492TI";
        //        aluno2.Email = "anageremiias@gmail.com";
        //        aluno2.Nascimento = new DateOnly(2007, 01, 03);

        //        aluno3.Nome = "Gabriela caput ";
        //        aluno3.RM = "4449TI";
        //        aluno3.Email = "GabrielaCaput@gmail.com";
        //        aluno3.Nascimento = new DateOnly(2007, 03, 16);

        //        //Im primir na tela
        //        Console.WriteLine("Aluno 1");
        //        Console.WriteLine("Nome:" + aluno1.Nome);
        //        Console.WriteLine("RM:" + aluno1.RM);
        //        Console.WriteLine("Email:" + aluno1.Email);
        //        Console.WriteLine("Nascimento:" + aluno1.Nascimento);
        //        Console.WriteLine("===============================================");

        //        Console.WriteLine("Aluno 2");
        //        Console.WriteLine("Nome:" + aluno2.Nome);
        //        Console.WriteLine("RM:" + aluno2.RM);
        //        Console.WriteLine("Email:" + aluno2.Email);
        //        Console.WriteLine("Nascimento:" + aluno2.Nascimento);
        //        Console.WriteLine("===============================================");

        //        Console.WriteLine("Aluno 3");
        //        Console.WriteLine("Nome:" + aluno3.Nome);
        //        Console.WriteLine("RM:" + aluno3.RM);
        //        Console.WriteLine("Email:" + aluno3.Email);
        //        Console.WriteLine("Nascimento:" + aluno3.Nascimento);
        //        Console.WriteLine("===============================================");


        //        //instanciar um Objeto do tipo Produto
        //        Produto p1 = new Produto();
        //        p1.Codigo = 123456;
        //        p1.Nome = "Coca-cola 3 Litros";
        //        p1.Preco = 12.99;
        //        p1.Estoque = 96;
        //        //chamar o metodo quantidadeestoque
        //        p1.Quantidadeestoque();
        //        p1.Estoque = 85;
        //        //chamar o metodo quantidadeestoque
        //        p1.Quantidadeestoque();

        //        Console.WriteLine("====================================================");
        //        Console.WriteLine();
        //        //instanciar um objeto do tipo carro
        //        Carro carro1 = new Carro();
        //        carro1.Marca = "Ferrari";
        //        carro1.Modelo = "488";
        //        carro1.Velocidade = 80;

        //        carro1.Acelerar();
        //        carro1.Desacelerar();
        //        carro1.Acelerar();
        //        carro1.Desacelerar();

        //        Console.WriteLine("====================================================");
        //        Console.WriteLine();

        //        Pessoa pessoa1 = new Pessoa();
        //        pessoa1.Nome = "Ana";
        //        pessoa1.Idade = 18;

        //        pessoa1.Envelhecer(5);
        //        pessoa1.Envelhecer(3);


        //        Console.WriteLine("====================================================");
        //        Console.WriteLine();

        //        Funcionario funcionario1 = new Funcionario();
        //        funcionario1.Nome = "Clara";
        //        funcionario1.Idade = 19;
        //        funcionario1.Cargo = "Aprendiz";
        //        funcionario1.Salario = 1400.00;

        //        funcionario1.Apresentarse();

        //        Console.WriteLine("======================================================");
        //        Console.WriteLine();

        //        //Instanciar um objeto
        //        Animal animal1 = new Animal();

        //        //inserindo dados no atributo
        //        animal1.Especie = "Cachorro";

        //        //chamando o metodo do objeto
        //        animal1.emitirSom();

        //        //imprimindo a informação na tela
        //        Console.WriteLine("O animal " + animal1.Especie + " emitiu um som");














        //Livro livro1 = new Livro();
        //livro1.Titulo = "Harry Potter";
        //livro1.Editora = "Editora Abril";
        //livro1.Autor = "J.K.R";
        //livro1.AnoLancamento = 2001;

        //Livro livro2 = new Livro();
        //livro2.Titulo = "Programação em C#";
        //livro2.Editora = "Editora nova";
        //livro2.AnoLancamento = 1982;
        //livro2.Autor = "Gustavo Castello";

        //Livro livro3 = new Livro();
        //livro3.Titulo = "Pai Rico Pai Pobre";
        //livro3.Editora = "Cris";
        //livro3.AnoLancamento = 2000;
        //livro3.Autor = "Cristiano de Paula";

        //Gato gato = new Gato();
        //gato.Nome = "Sr.Meia Noite";
        //Console.WriteLine(gato.Nome + " faz: ");
        //gato.emitirSom();

        //Console.WriteLine();

        //Porco porco = new Porco();
        //porco.Nome = "Gleison";
        //Console.WriteLine(porco.Nome + " faz :");
        //porco.emitirSom();

        //Console.WriteLine();

        //Galinha galinha = new Galinha();
        //galinha.Nome = "Albert Einstein";
        //Console.WriteLine(galinha.Nome + " faz :");
        //galinha.emitirSom();
        Elfo elfo = new Elfo();
        elfo.Nome = " Tinker ";
        elfo.Forca = 55;
        elfo.Vida = 100;
        elfo.inteligencia = 87;
        elfo.Agilidade = 60;
        elfo.Nivel = 1;


        Mago mago = new Mago();
        mago.Nome = " Cleiton ";
        mago.Forca = 80;
        mago.Vida = 100;
        mago.Agilidade = 55;
        mago.inteligencia = 90;
        mago.Nivel = 1;



        Cavaleiro cavaleiro = new Cavaleiro();

        cavaleiro.Nome = " Jerson ";
        cavaleiro.Forca = 10;
        cavaleiro.Vida = 100;
        cavaleiro.Agilidade = 70;
        cavaleiro.inteligencia = 33;
        cavaleiro.Nivel = 1;


        mago.Apresentarse();
        cavaleiro.Apresentarse();
        mago.Batalha(cavaleiro);


    }
}