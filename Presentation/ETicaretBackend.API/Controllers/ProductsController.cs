using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaretBackend.Application.Repositories.RepositoryOfCustomer;
using ETicaretBackend.Application.Repositories.RepositoryOfOrder;
using ETicaretBackend.Application.Repositories.RepositoryOfProduct;
using ETicaretBackend.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;
        readonly private IProductReadRepository _productReadRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;

        readonly private IProductWriteRepository _productWriteRepository;
        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }
        [HttpGet("get")]
        public void Get()
        {
            Order order = _orderReadRepository.GetById("7760c9ad-5efe-4807-a3ad-d6069b4d3e02");
            order.Address = "Istanbul";
            _orderWriteRepository.Save();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            Product product = _productReadRepository.GetById(id);
            return Ok(product);
        }
    }
}
