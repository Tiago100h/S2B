using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC01.Models
{
    public class Aluno
    {
        //atalho ctor
        public Aluno(string nome, string curso, string instituicao)
        {
            this.Nome = nome;
            this.Curso = curso;
            this.InstituicaoEnsino = instituicao;
        }

        [Required]
        [StringLength(150)]
        //atalho prop - criar prorpiedades
        public string Nome { get; set; }
        [Required]
        [StringLength(200)]
        public string Curso { get; set; }
        public string InstituicaoEnsino { get; set; }
    }
}