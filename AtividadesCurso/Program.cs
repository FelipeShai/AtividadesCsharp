using AtividadesCurso.AccountProject;
using AtividadesCurso.ExercicioListas;
using AtividadesCurso.Manipulando_arquivos;
using AtividadesCurso.Pagamentos;
using AtividadesCurso.Trabalhador;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AtividadesCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questao1.Executar();
            //Questao2.Executar();
            //Questao3.Executar();
            //Questao4.Executar();
            //Questao5.Executar();
            //Questao6.Executar();
            //Questao7.Executar();
            //Questao8.Executar();
            //Questao9.Executar();
            //Questao10.Executar();
            //Questao11.Executar();
            //Questao12.Executar();
            //Questao13.Executar();
            //Questao14.Executar();
            //Questao15.Executar();
            //Questao16.Executar();
            //Questao17.Executar();
            //Questao18.Executar();
            //Questao19.Executar();
            //Questao20.Executar();
            //Questao21.Executar();
            //Questao22.Executar();
            //Questao23.Executar();
            //Questao24.Executar();
            //Questao25.Executar();
            //Calculadora.Executar();
            //Foreach.Executar();
            //List.Executar();
            //ExercicioLista.Executar();

            //Padaria padaria = new Padaria();
            //var Tulio = new Tulio();
            //var Joao = new Joao();
            //var Placa = new PlacaPaoDoDia();
            //padaria.Funcionar(Joao,Placa);

            //Cafeteria cafeteria = new Cafeteria();
            //var Shai = new Shai();
            //var Tulio = new Tulio();
            //var Cliente = new Cliente();
            //cafeteria.Operar(Tulio, Shai, Cliente);

            //ResultadoOutputPort outputPort = new();
            //TesteUseCase useCase = new(outputPort);
            //useCase.VerificarNumerosBilhetes(3);

            //if(outputPort.Premiado == true)
            //{
            //    Console.WriteLine("Sucesso");
            //}

            //if (outputPort.Erro == true)
            //{
            //    Console.WriteLine($"Código do erro {outputPort.CodigoErro}");
            //}

            //if (outputPort.NaoPremiado == true)
            //{
            //    Console.WriteLine(outputPort.Mensagem);
            //}

            //LearningLinq.ExecutarLearningLinq();

            //FuncionarioLogica funcionarioLogica = new();
            //funcionarioLogica.Executar();

            //double[,] matrizBidimensional = new double[2,3];
            //Console.WriteLine(matrizBidimensional.Length);
            //Console.WriteLine(matrizBidimensional.Rank);
            //Console.WriteLine(matrizBidimensional.GetLength(0));


            //DateTime moment = DateTime.Now;
            //Order pagamento = new Order
            //{
            //    Id = 1,
            //    Moment = moment,
            //    Status = OrderStatus.Processing
            //};
            //Console.WriteLine(pagamento);

            //Console.Write("Enter department's name: ");
            //string deptName = Console.ReadLine();

            //Console.WriteLine("Enter worker data:");
            //Console.Write("Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Level: (Junior/MidLevel/Senior): ");
            //WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            //Console.Write("Base salary: ");
            //double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Department dept = new Department(deptName);
            //Worker worker = new Worker(name, level, baseSalary, dept);

            //Console.Write("How many contracts to this worker? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Enter #{i} contract data:");
            //    Console.Write("Date (DD/MM/YYYY): ");
            //    DateTime date = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Value per hour: ");
            //    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.Write("Duration (hours): ");
            //    int hours = int.Parse(Console.ReadLine());
            //    HourContract contract = new HourContract(date, valuePerHour, hours);
            //    worker.AddContract(contract);
            //}

            //Console.WriteLine();
            //Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            //string monthAndYear = Console.ReadLine();
            //int month = int.Parse(monthAndYear.Substring(0, 2));
            //int year = int.Parse(monthAndYear.Substring(3));
            //Console.WriteLine("Name : " + worker.Name);
            //Console.WriteLine("Department: " + worker.Department.Name);
            //Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

            //Account acc = new(1001, "Alex", 0.0);
            //BusinessAccount bacc = new(1002, "Maria", 0.0, 500);


            ////UPCASTING
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            ////DOWNCASTING

            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //SavingsAccount acc5 = (SavingsAccount)acc3;

            //BusinessAccount acc6 = acc1 as BusinessAccount;

            //OVERRIDE
            //Account acc1 = new(1001, "Alex", 500.0);
            //Account acc2 = new SavingsAccount(1004, "Anna", 500.0, 0.01);

            //acc1.Withdraw(10);
            //acc2.Withdraw(10);

            //Console.WriteLine("ACC1 = " + acc1.Balance + "\nACC2 = " + acc2.Balance);

            //ManipuladorDeArquivos.TransferirArquivo(@"C:\Users\DTI Digital\Desktop\Arquivo1.txt", @"C:\Users\DTI Digital\Desktop\Arquivo3.txt");

            string path = @"C:\Users\DTI Digital\Desktop\Arquivo1.txt";
            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                fileStream = new(path, FileMode.Open);
                streamReader = new StreamReader(fileStream);
                string line = streamReader.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {

                Console.WriteLine(e);
            }
            finally
            {
                if
                (fileStream != null) { streamReader.Close(); }
                if (fileStream != null) { fileStream.Close(); }
                //comentário
                //comentario diferente
            }
        }        
    }
}
