using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace VideoMovil.Models
{
    public class bd
    {
        readonly SQLiteAsyncConnection basedatos;

        public bd(String pathdb)
        {
            basedatos = new SQLiteAsyncConnection(pathdb);

            basedatos.CreateTableAsync<Video>().Wait();
        }

        // Lista de Videos
        public Task<List<Video>> ObtenerListaVideos()
        {
            return basedatos.Table<Video>().ToListAsync();
        }

        // Codigo de videos
        public Task<Video> ObtenerVideoCodigo(int codeParam)
        {
            return basedatos.Table<Video>()
                .Where(i => i.codigo == codeParam)
                .FirstOrDefaultAsync();
        }

        // Guardar Video
        public Task<int> GuardarVideo(Video photo)
        {
            if (photo.codigo != 0)
            {
                return basedatos.UpdateAsync(photo);
            }
            else
            {
                return basedatos.InsertAsync(photo);
            }

        }

        public Task<int> EliminarVideo(Video photo)
        {
            return basedatos.DeleteAsync(photo);
        }

    }
}

