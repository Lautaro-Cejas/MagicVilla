using MagicVillaAPI.Modelos;

namespace MagicVillaAPI.Repositorio.IRepositorio
{
    public interface IVillaRepositorio:IRepostiorio<Villa>
    {
        Task<Villa> Actualizar(Villa entidad);
    }
}
