﻿namespace SafePetBackend.SafePet.Resources
{
    public class MostPurchasedProductResource
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
    
}

