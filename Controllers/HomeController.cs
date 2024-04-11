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
       // Instrâcia do tipo Cliente
        Cliente cliente1 = new Cliente(01, "Clark Kent","123456789-10","clarkkent@dailyplanet.com","Kripto");
        Cliente cliente2 = new Cliente(02, "Bruce Wayne","147258369-01","batwayne@wayneent.com","ace");
        Cliente cliente3 = new Cliente(03, "Kitty Pryde","369258147-01","kittypride@xmen.com","Lockheed");
        Cliente cliente4 = new Cliente(04, "Sam Wilson","951753258-85","samwilson@shield.org","Asa Vermelha");
        Cliente cliente5 = new Cliente(05, "Kamala Khan","753951258-25","kamalakhan@inumanos.com","Dentinho");

        //Criando a liste de clientes - listaClientes, e atribuindo os clientes

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;
        
        
        //Instância do tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor (01 , "MetroPets Co.", "14.182.102/0001-80", "distrmetropets@dcpets.com");
        Fornecedor fornecedor2 = new Fornecedor (02 , "Gothan Pets Co.", "15.836.698/0001-57", "distrgothanpets@dcpets.com");
        Fornecedor fornecedor3 = new Fornecedor (03 , "X-Pets Co.", "40.810.224/0001-83","distrxpets@marvels.com");
        Fornecedor fornecedor4 = new Fornecedor (04 , "Avengers Pets Co.", "87.945.350/0001-09", "distravenpets@marvels.com");
        Fornecedor fornecedor5 = new Fornecedor (05 , "Inhumans Pets Co.", "18.760.614/0001-37","distrinhumanspets@marvels.com");
        
        //Criando a lista de Fornecedores - listaFornecedores, e atribuindo os fornecedores

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
