﻿namespace OnlineStore.Domain.Entities
{
    /// <summary>
    /// Изображение товара.
    /// </summary>
    public sealed class ProductImage
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Контент изображения.
        /// </summary>
        public byte[] Content { get; set; } = default!;

        /// <summary>
        /// Тип контента.
        /// </summary>
        public string? ContentType { get; set; } = default!;

        /// <summary>
        /// Идентификатор товара.
        /// </summary>
        public int? ProductId { get; set; }

        /// <summary>
        /// Товар.
        /// </summary>
        public Product Product { get; set; } = default!;
    }
}
