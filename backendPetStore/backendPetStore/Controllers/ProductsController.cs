using backendPetStore.Context;
using backendPetStore.Dtos;
using backendPetStore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendPetStore.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProductsController(ApplicationDbContext context)
    {
        _context = context;
    }
    //CRUD

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateUpdateProductDto dto)
    {
        var newProduct = new ProductEntity()
        {
            Brand = dto.Brand,
            Title = dto.Title,
        };
         await _context.Products.AddAsync(newProduct);
         await _context.SaveChangesAsync();
         return Ok("Product saved successfully");
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _context.Products.ToListAsync();
        return Ok(products);
    }
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetProductById([FromRoute] long id)
    {
        var product = await _context.Products.FirstOrDefaultAsync(q => q.Id == id);

        if (product is null)
        {
            return NotFound("Product not found");
        }
        
        return Ok(product);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateProduct([FromRoute] long id, [FromBody] CreateUpdateProductDto dto)
    {
        var product = await _context.Products.FirstOrDefaultAsync(q => q.Id == id);

        if (product is null)
        {
            return NotFound("Product not found");
        }

        product.Title = dto.Title;
        product.Brand = dto.Brand;
        product.UpdatedAt =  DateTime.Now;

        await _context.SaveChangesAsync();

        return Ok("Product updated Successfully");
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteProduct([FromRoute] long id)
    {
        var product = await _context.Products.FirstOrDefaultAsync(q => q.Id == id);
        if (product is null)
        {
            return NotFound("Product not found");
        }

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();

        return Ok("Product Deleted Successfully");
    }
}