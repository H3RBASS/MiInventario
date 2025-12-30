using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using MiInventario.Services;
using MiInventario.Modelos;

public class InventarioBase : ComponentBase
{
    // Variables de estado
    protected string searchTerm = "";
    protected string selectedCategory = "";
    protected string stockStatus = "";
    protected decimal minPrice;
    protected decimal maxPrice;
    protected int minQuantity;

    //Inyección del servicio de productos
    public class ProductHelper
    {
        private readonly ProductService _productService;

        public ProductHelper(ProductService productService)
        {
            _productService = productService;
        }

    }

    
    // Métodos
    protected void ClearFilters()
    {
        searchTerm = "";
        selectedCategory = "";
        stockStatus = "";
        minPrice = 0;
        maxPrice = 0;
        minQuantity = 0;
    }
}

