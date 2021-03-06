﻿namespace VBaseProject.Entities.Filter
{
    public abstract class BaseFilter<T>
    {
        public T Entity { get; set; }
        public int Page { get; set; } = 1;
        public int Quantity { get; set; } = 10;
        public string Query { get; set; }
    }
}
