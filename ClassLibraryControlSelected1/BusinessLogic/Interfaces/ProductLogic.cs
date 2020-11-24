﻿using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using DataBaseImplement;
using DataBaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Interfaces
{
    public class ProductLogic : IProductLogic
    {
        public void CreateOrUpdate(ProductBindingModel model)
        {
            Product product;
            using (var context = new ProductDatabase())
            {

                if (model.Id.HasValue)
                {
                    product = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
                    if (product == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    product = new Product
                    {
                        Name = model.Name,
                        Count = model.Count,
                        Category = model.Category,
                        KindOFProduct = model.KindOFProduct,
                        Price = model.Price
                    };
                    context.Products.Add(product);
                    context.SaveChanges();
                    return;
                }
                product.Name = model.Name;
                product.Count = model.Count;
                product.Category = model.Category;
                product.KindOFProduct = model.KindOFProduct;
                product.Price = model.Price;

                context.SaveChanges();
            }
        }

        public void Delete(ProductBindingModel model)
        {
            using (var context = new ProductDatabase())
            {
                var employee = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
                if (employee != null)
                {
                    context.Products.Remove(employee);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<ProductViewModel> Read(ProductBindingModel model)
        {
            using (var context = new ProductDatabase())
            {
                return context.Products
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
               .Select(rec => new ProductViewModel
               {
                   Id = rec.Id,
                   Name = rec.Name,
                   Category = rec.Category,
                   Count = rec.Count,
                   KindOFProduct = rec.KindOFProduct,
                   Price = rec.Price
               })
               .ToList();
            }
        }
    }
}
