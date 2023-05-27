using MagicVillaAPI.Modelos;

namespace MagicVillaAPI.Repositorio.IRepositorio
{
    public interface INumeroVillaRepositorio:IRepostiorio<NumeroVilla>
    {
        Task<NumeroVilla> Actualizar(NumeroVilla entidad);
    }
}
