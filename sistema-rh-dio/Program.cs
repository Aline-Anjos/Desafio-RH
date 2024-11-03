using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Leitura da entrada do usuário
        string input = Console.ReadLine();

        // Processamento da entrada
        List<string> departamentos = input.Split(',')
                                          .ToList();

        // Contagem de funcionários por departamento
        Dictionary<string, int> contagemDepartamentos = ContarFuncionariosPorDepartamento(departamentos);

        // Formatação da saída
        var resultado = string.Join(Environment.NewLine,
                                    contagemDepartamentos.OrderBy(depto => depto.Key)
                                                         .Select(depto => $"{depto.Key}: {depto.Value}"));

        Console.WriteLine(resultado);
    }

    // Método que conta o número de funcionários em cada departamento.
    static Dictionary<string, int> ContarFuncionariosPorDepartamento(List<string> departamentos)
    {
        var contagem = new Dictionary<string, int>();

        foreach (var depto in departamentos)
        {
            // Verifica se o departamento já está no dicionário
            if (contagem.ContainsKey(depto))
            {
                // Incrementa a contagem se o departamento já existe
                contagem[depto]++;
            }
            else
            {
                // Adiciona o departamento com contagem inicial 1
                contagem[depto] = 1;
            }
        }
        return contagem;
    }
}