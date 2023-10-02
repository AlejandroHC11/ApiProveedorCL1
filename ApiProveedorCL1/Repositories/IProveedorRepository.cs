using ApiProveedorCL1.Models;

namespace ApiProveedorCL1.Repositories
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<Proveedor>> GetProveedores();
        Task<Proveedor> GetProveedorId(int id);
        Task<Proveedor> CreateProveedor(Proveedor proveedor);
        Task<Proveedor> UpdateProveedor(Proveedor proveedor);
        Task<bool> DeleteProveedor(int id);
    }
}
