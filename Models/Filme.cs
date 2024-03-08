using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(60,MinimumLength = 2, ErrorMessage = "O título precisa ter entre 2 e 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Formato de data incorreto")]
        [Required(ErrorMessage = "O campo data de lançamento é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "O campo Genero é obrigatório")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Genero com formato inválido.")]
        [StringLength(30,ErrorMessage = "Máximo de 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "O campo valor é obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        public double Valor { get; set; }

        [Display(Name = "Avaliação")]
        [Required(ErrorMessage = "O campo Avaliação é obrigatório")]
        [RegularExpression(@"^[0-5]*$",ErrorMessage = "Somente números entre 0 e 5")]
        public int Avaliacao { get; set; }
    }
}
