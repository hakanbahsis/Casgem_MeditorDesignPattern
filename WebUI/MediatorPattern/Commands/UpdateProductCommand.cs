﻿using MediatR;

namespace WebUI.MediatorPattern.Commands
{
    public class UpdateProductCommand:IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
    }
}
