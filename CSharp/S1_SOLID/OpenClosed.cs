using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_SOLID
{
    public static class OpenClosed
    {
        public static void Main()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);
            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();
            Console.WriteLine("Green products (old):");
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            var bf = new BetterFilter();
            Console.WriteLine("Green products (new):");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }
            Console.WriteLine("Large blue items:");
            foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - {p.Name} is blue and large");
            }
        }
    }

    public enum Color { Red, Green, Blue }
    public enum Size { Small, Medium, Large }

    public class Product
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }

        public Product(string name, Color color, Size size)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Color = color;
            Size = size;
        }
    }

    // Open-Closed Principle (OCP): Open for Extension, but Closed for Modification
    // Broke OCP, when we want to combine Color & Size, we Opened for Modification (FilterBySizeAndColor)
    public class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (Product product in products)
            {
                if (product.Color == color) yield return product;
            }
        }

        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach(Product product in products)
            {
                if (product.Size == size) yield return product;
            }
        }

        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (Product product in products)
            {
                if (product.Color == color && product.Size == size) yield return product;
            }
        }
    }

    // Create 2 new Interfaces that are Open for Extension
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class SizeSpecification : ISpecification<Product>
    {
        public Size Size { get; set; }

        public SizeSpecification(Size size)
        {
            Size = size;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Size == Size;
        }
    }

    public class ColorSpecification : ISpecification<Product>
    {
        public Color Color { get; set; }

        public ColorSpecification(Color color)
        {
            Color = color;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Color == Color;
        }
    }

    // Combinator
    public class AndSpecification<T> : ISpecification<T>
    {
        public ISpecification<T> First { get; set; }
        public ISpecification<T> Second { get; set; }
        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            First = first ?? throw new ArgumentNullException(paramName: nameof(first));
            Second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(T item)
        {
            return First.IsSatisfied(item) && Second.IsSatisfied(item);
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
            {
                if (spec.IsSatisfied(item)) yield return item;
            }
        }
    }
}
