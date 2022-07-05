using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AgendaDeTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} campo obrigatório")]
        [StringLength(50, ErrorMessage = "Limite de 50 caracteres")]
        public string NomeTarefa { get; set; }
        [Required(ErrorMessage = "{0} campo obrigatório")]
        [StringLength(50, ErrorMessage = "Limite de 50 caracteres")]
        public string DescricaoTarefa { get; set; }
        [Required(ErrorMessage = "{0} campo obrigatório")]
        [StringLength(150, ErrorMessage = "Limite de 150 caracteres")]
        public string Data { get; set; }
        [Required(ErrorMessage = "{0} campo obrigatório")]
        [DataType(DataType.Date)]
        public string Horario{ get; set; }
        [Required(ErrorMessage = "{0} campo obrigatório")]
        [DataType(DataType.Time)]
        public string HoraInicio { get; set; }
        [Required(ErrorMessage = "{0} campo obrigatório")]
        [DataType(DataType.Time)]
        public string HoraFim { get; set; }
        [Required(ErrorMessage = "{0} campo obrigatório")]
        [DataType(DataType.Time)]
        public string Prioridade { get; set; }
        [Required(ErrorMessage = "{0} campo obrigatório")]
        [StringLength(5, ErrorMessage = "Limite de 5 caracteres")]
        public string EstadoTarefa { get; set; }
    }
}
