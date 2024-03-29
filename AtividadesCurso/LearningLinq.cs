﻿namespace AtividadesCurso
{
    class LearningLinq
    {
        public static void ExecutarLearningLinq()
        {
            var listaProdutos = new List<Produto>()

        {
            new Produto{Id = 1, CategoriaId = 3, Nome = "Camiseta",Status = true, Valor = 100},
            new Produto{Id = 2, CategoriaId = 3, Nome = "Short",Status = true, Valor = 1},
            new Produto{Id = 3, CategoriaId = 1, Nome = "Video Game",Status = true, Valor = 99},
            new Produto{Id = 4, CategoriaId = 1, Nome = "Máquina de Lavar",Status = true, Valor = 32},
            new Produto{Id = 5, CategoriaId = 1, Nome = "Microondas",Status = true, Valor = 90},
            new Produto{Id = 6, CategoriaId = 2, Nome = "Arroz",Status = true, Valor = 55},
            new Produto{Id = 7, CategoriaId = 2, Nome = "Feijão",Status = true, Valor = 12},
            new Produto{Id = 8, CategoriaId = 2, Nome = "Geladeira",Status = true, Valor = 10}

        };

            var listaCategorias = new List<Categoria>()
        {
            new Categoria{Id = 1, Status = true, Nome = "Eletronicos"},
            new Categoria{Id = 2, Status = true, Nome = "Alimentos"},
            new Categoria{Id = 3, Status = true, Nome = "Vestuário"},
        };
            //FONTE DE DADOS

            /* CRIAR CONSULTA LINQ
            01 - Exibe todos os atributos da classe para cada objeto instanciado*/
            var resultado = from produto in listaProdutos select produto;

            //02 - Filtrar produtos por nome - função ToLower retorna todos os carcteres convertidos em uma string para minúsculo 
            //var resultado = from produto in listaProdutos where produto.Nome.ToLower() == "arroz" select produto;

            //03 - Filtrar produtos pela primeira letra do nome
            //var resultado = from produto in listaProdutos where produto.Nome.ToLower().Substring(0, 1) == "m".ToLower() select produto;

            //04 - Filtrar pela primeira letra do nome e status ativo
            //var resultado = from produto in listaProdutos where produto.Nome.ToLower().Substring(0, 1) == "a" && produto.Status == true select produto;

            //05 - Ordenar os produtos por ID
            //var resultado = from produto in listaProdutos orderby produto.Id select produto;

            //EXECUTAR A CONSULTA
            foreach (var result in resultado)
            {
                Console.WriteLine($"{result.Id} | {result.Nome} | {result.Valor} | {result.CategoriaId}");
            }
        }
    }
}
class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public bool Status { get; set; }
    public decimal Valor { get; set; }
    public int CategoriaId { get; set; }
}
class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public bool Status { get; set; }
}



