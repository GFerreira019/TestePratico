using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AgendaDeTarefas.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {


        }
    }
}