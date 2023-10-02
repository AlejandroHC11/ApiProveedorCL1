using ApiProveedorCL1.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProveedorCL1.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly cibertec2023Context dbContext;
        public ProveedorRepository(cibertec2023Context dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Proveedor> CreateProveedor(Proveedor proveedor)
        {
            dbContext.Proveedors.Add(proveedor);
            await dbContext.SaveChangesAsync();
            return proveedor;
        }

        public async Task<bool> DeleteProveedor(int id)
        {
            var proveedor = await dbContext.Proveedors.FirstOrDefaultAsync(p => p.ProveedorId == id);
            if (proveedor == null)
            {
                return false;
            }
            dbContext.Proveedors.Remove(proveedor);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Proveedor>> GetProveedores()
        {
            return await dbContext.Proveedors.ToListAsync();
        }

        public async Task<Proveedor> GetProveedorId(int id)
        {
            var proveedor = await dbContext.Proveedors.Where(p => p.ProveedorId == id).FirstOrDefaultAsync();
            return proveedor;
        }

        public async Task<Proveedor> UpdateProveedor(Proveedor proveedor)
        {
            dbContext.Proveedors.Update(proveedor);
            await dbContext.SaveChangesAsync();
            return proveedor;
        }
    }
}
