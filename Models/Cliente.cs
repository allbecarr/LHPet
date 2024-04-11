using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHPet.Models
{
    public class Cliente
    {
        /*
        No trecho de código a seguir são criados os atributos de Cliente e seus getts e setts correspondentes.
        */
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Paciente { get; set; }

        /*
        No trecho de código abaixo é criado o construtor do model Cliente e determinando quais parâmetros são necessários na criação das instâncias.
        */

        public Cliente (int id, string nome, string cpf,string email, string paciente)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Paciente = paciente;
        }
    }
}