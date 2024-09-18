using WebApi.Dto.Vinculo;
using WebApi.Models;

namespace WebApi.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
