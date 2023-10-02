using ApiProveedorCL1.Models;
using ApiProveedorCL1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiProveedor.Controllers
{
    public class ProveedorController:ControllerBase
    {
        private readonly IProveedorRepository proveedorRepository;
        public ProveedorController(IProveedorRepository proveedorRepository)
        {
            //Inyeccion de dependencia
            this.proveedorRepository = proveedorRepository;
        }

        [HttpGet]
        [Route("/GetProveedores")]
        public async Task<IEnumerable<Proveedor>> GetProveedores()
        {
            return await proveedorRepository.GetProveedores();
        }

        [HttpGet]
        [Route("/GetProveedorById/{id}")]
        public async Task<Proveedor> GetProveedorById(int id)
        {
            return await proveedorRepository.GetProveedorId(id);
        }

        [HttpPost]
        [Route("/CreateProveedor")]
        public async Task<Proveedor> CreateProveedor(Proveedor proveedor)
        {
            return await proveedorRepository.CreateProveedor(proveedor);
        }

        [HttpPut]
        [Route("/UpdatePreveedor")]
        public async Task<Proveedor> UpdateProveedor(Proveedor proveedor)
        {
            return await proveedorRepository.UpdateProveedor(proveedor);
        }

        [HttpDelete]
        [Route("/DeleteProveedor")]
        public async Task<bool> DeleteProveedor(int id)
        {
            return await proveedorRepository.DeleteProveedor(id);
        }
    }
}
