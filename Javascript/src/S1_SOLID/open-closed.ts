enum Color {
  Red,
  Green,
  Blue,
}
enum Size {
  Small,
  Medium,
  Large,
}

class Product {
  name: string;
  color: Color;
  size: Size;

  constructor(name: string, color: Color, size: Size) {
    this.name = name;
    this.color = color;
    this.size = size;
  }
}

// Broke Open-Closed principle
// class ProductFilter shouldn't Open for Modification (when we have a new Filter)
class ProductFilter {
  filterByColor(products: Product[], color: Color) {
    return products.filter((product) => product.color === color);
  }

  filterBySize(products: Product[], size: Size) {
    return products.filter((product) => product.size === size);
  }

  filterByColorAndSize(products: Product[], color: Color, size: Size) {
    return products.filter(
      (product) => product.color === color && product.size === size
    );
  }
}

const apple = new Product('Apple', Color.Green, Size.Small);
const tree = new Product('Tree', Color.Green, Size.Large);
const house = new Product('House', Color.Blue, Size.Large);
const products = [apple, tree, house];

const pf = new ProductFilter();
console.log('Green products (old):');
for (const product of pf.filterByColor(products, Color.Green)) {
  console.log(` - ${product.name} is green`);
}

//========================================================================
// Using Specification pattern to make sure Open-Closed principle
// Create 2 new Interface that are Open for Extension

interface Specification<T> {
  isSatisfied: (item: T) => boolean;
}
interface Filter<T> {
  filter: (items: T[], spec: Specification<T>) => T[];
}

class ColorSpecification implements Specification<Product> {
  color: Color;

  constructor(color: Color) {
    this.color = color;
  }

  isSatisfied(item: Product) {
    return item.color === this.color;
  }
}

class SizeSpecification implements Specification<Product> {
  size: Size;

  constructor(size: Size) {
    this.size = size;
  }

  isSatisfied(item: Product) {
    return item.size === this.size;
  }
}

// Combination
class AndSpecification<T> implements Specification<T> {
  specs: Specification<T>[];

  constructor(...specs: Specification<T>[]) {
    this.specs = specs;
  }

  isSatisfied(item: T) {
    return this.specs.every((spec) => spec.isSatisfied(item));
  }
}

class BetterFilter implements Filter<Product> {
  filter(items: Product[], spec: Specification<Product>) {
    return items.filter((item) => spec.isSatisfied(item));
  }
}

const bf = new BetterFilter();

console.log('Green product (new):');
for (const product of bf.filter(
  products,
  new ColorSpecification(Color.Green)
)) {
  console.log(` - ${product.name} is green`);
}

console.log('Large blue items:');
for (const product of bf.filter(
  products,
  new AndSpecification<Product>(
    new ColorSpecification(Color.Blue),
    new SizeSpecification(Size.Large)
  )
)) {
  console.log(` - ${product.name} is blue and large`);
}
