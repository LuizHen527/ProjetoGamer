using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_projeto_gamer.Models;

namespace MVC_projeto_gamer.infra
{
    public class Context:DbContext
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Conexao importante

                //Autenticacao pelo windows
                //Intergrated security
                // TrustServerCertificate

                //Autenticacao pelo SQL server
                //User Id = nome do seu usuario
                //pwd = "senha do seu usuario"
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-C6SOG6K; initial catalog = gamerManha; User Id = sa; pwd = pPtA3002; TrustServerCertificate = true");
            }
        }


        //Referencia de classes nas tabelasS
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
    }
}