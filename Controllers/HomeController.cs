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
        //instancias do tipo cliente

        Cliente cliente1 = new Cliente(1, "Arthur A. Ferreira", "857.032.950-41", "arthur@teste.com", "Madruga");
        Cliente cliente2 = new Cliente(2, "Beatriz B. Silva", "123.456.789-00", "beatriz@teste.com", "Bia");
        Cliente cliente3 = new Cliente(3, "Carlos C. Souza", "987.654.321-00", "carlos@teste.com", "Carlão");
        Cliente cliente4 = new Cliente(4, "Daniel D. Lima", "456.789.123-00", "daniel@teste.com", "Dani");
        Cliente cliente5 = new Cliente(5, "Elisa E. Costa", "789.123.456-00", "elisa@teste.com", "Lili");

        // lista de clientes
        List<Cliente> listaClientes = new();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;
        // instancias Forncederes
        Fornecedor fornecedor1 = new Fornecedor(1, "Empresa A", "12.345.678/0001-90", "contato@empresaA.com");
        Fornecedor fornecedor2 = new Fornecedor(2, "Empresa B", "23.456.789/0001-01", "contato@empresaB.com");
        Fornecedor fornecedor3 = new Fornecedor(3, "Empresa C", "34.567.890/0001-12", "contato@empresaC.com");
        Fornecedor fornecedor4 = new Fornecedor(4, "Empresa D", "45.678.901/0001-23", "contato@empresaD.com");
        Fornecedor fornecedor5 = new Fornecedor(5, "Empresa E", "56.789.012/0001-34", "contato@empresaE.com");

        //lista de fornecedores
        List<Fornecedor> listaFornecedores = new();
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
