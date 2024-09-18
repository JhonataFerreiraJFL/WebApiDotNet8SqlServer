using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Controllers;
using WebApi.Dto.Autor;
using WebApi.Dto.Livro;
using WebApi.Models;

namespace WebApi.Services.Autor
{
    public interface IAutorInterface
    {
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutorId);
        Task<ResponseModel<AutorModel>> BuscarAutorIdLivro(int idLivro);
        Task<ResponseModel<List<AutorModel>>> ListarAutores();
        Task<ResponseModel<List<AutorModel>>> CriarAutor(AutorCriacaoDto autorCriacaoDto);
        Task<ResponseModel<List<AutorModel>>> EditarAutor(AutorEdicaoDto autorEdicaoDto);
        Task<ResponseModel<List<AutorModel>>> ExcluirAutor(int idLivro);

    }
}
