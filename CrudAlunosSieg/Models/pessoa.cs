using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudAlunosSieg.Models
{
    public class pessoa
    {


        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public int idade { get; set; }
    }
}