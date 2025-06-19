using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instâncias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Bruno Ferreira", "123.456.789-00", "brunnnnnoo.f@df.senai.br", "nicol");
        Cliente cliente2 = new Cliente(02, "Ana Souza", "987.654.321-00", "ana.souza@example.com", "Buddy");
        Cliente cliente3 = new Cliente(03, "Pedro Lima", "111.222.333-44", "pedro.lima@example.com", "Mel");
        Cliente cliente4 = new Cliente(04, "Mariana Costa", "444.555.666-77", "mariana.costa@example.com", "Thor");
        Cliente cliente5 = new Cliente(05, "João Santos", "777.888.999-00", "joao.santos@example.com", "Maggie");

        // lista de clientes e atribuir os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // instâncias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "PetsDogs Friendly", "14.543.876/0001-90", "petsdogsfriendly.dog.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Casa dos Gatos Felizes", "22.345.678/0001-11", "casadosgatosfelizes.com.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Pássaros e Cia", "33.456.789/0001-22", "passarosecia.net");
        Fornecedor fornecedor4 = new Fornecedor(04, "Aquário Azul", "44.567.890/0001-33", "aquarioazul.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Tudo para o Pet", "66.789.012/0001-55", "tudoparaopet.com.br");

        // lista de fornecedores e atribuir os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
