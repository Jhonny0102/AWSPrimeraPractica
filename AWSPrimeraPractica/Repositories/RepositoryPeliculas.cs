using AWSPrimeraPractica.Data;
using AWSPrimeraPractica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSPrimeraPractica.Repositories
{
    public class RepositoryPeliculas
    {
        private PeliculasContext context;
        public RepositoryPeliculas(PeliculasContext context)
        {
            this.context = context;
        }
        public async Task<List<Pelicula>> GetPeliculasAsync()
        {
            return await this.context.Peliculas.ToListAsync();
        }

        public async Task<List<Pelicula>> GetPeliculasActores(string actor)
        {
            return await this.context.Peliculas.Where(z => z.Actores.Contains(actor)).ToListAsync();
        }
    }

}
