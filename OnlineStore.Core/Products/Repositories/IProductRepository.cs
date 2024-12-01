﻿using OnlineStore.Core.Common;
using OnlineStore.Core.Products.Models;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Core.Products.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        /// <summary>
        /// Возвращает список товаров по пагинированному запросу.
        /// </summary>
        /// <param name="request">Пагинированный запрос.</param>
        Task<List<Product>> GetProductsAsync(GetProductsRequest request, CancellationToken cancellation);

        /// <summary>
        /// Возвращает список товаров в категории по её ID.
        /// </summary>
        Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId, CancellationToken cancellation);

        /// <summary>
        /// Возвращает список товаров по их ID.
        /// </summary>
        /// <param name="ids">IDs товаров.</param>
        Task<List<Product>> GetProductsByIdsAsync(List<int> ids, CancellationToken cancellation);

        /// <summary>
        /// Возвращает общее количество всех товаров в категории.
        /// </summary>
        /// <param name="categoryId">ID категории.</param>
        Task<int> GetProductsTotalCountAsync(int categoryId, CancellationToken cancellation);
    }
}
