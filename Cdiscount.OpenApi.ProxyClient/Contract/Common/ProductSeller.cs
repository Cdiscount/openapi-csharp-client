﻿namespace Cdiscount.OpenApi.ProxyClient.Contract.Common
{
    /// <summary>
    /// Product seller informations
    /// </summary>
    public class ProductSeller
    {
        /// <summary>
        /// Seller identifier
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; }
    }
}