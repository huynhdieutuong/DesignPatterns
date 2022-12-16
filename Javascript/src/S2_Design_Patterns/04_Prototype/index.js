class Dog {
  name;

  constructor(name) {
    this.name = name;
  }

  bark() {
    return 'Woof!';
  }
}

Dog.prototype.play = () => console.log('Playing now!');

const dog1 = new Dog('Daisy'); // dog1 don't have bark and play properties, Dog class share these properties to instance
console.log(Dog.prototype === dog1.__proto__); // true
/**
 * Whenever we try to access a property on an object (dog1) that doesn't exist on the object directly, JS will go down the prototype chain (Dog) to see if the property is available within the prototype chain.
 * => The prototype pattern is very powerful when working with objects that should have access to the same properties. Instead of creating a duplicate of the property each time.
 */

// ====================================
const dog = {
  bark() {
    console.log('Woof!');
  },
};

const pet1 = Object.create(dog);
// Object.create is a simple way to let objects (pet1) directly inherit properties from other objects (dog).
// The pet1 object can access dog properties by walking down the prototype chain.
// => We can avoid duplication of methods and properties, thus reducing the amount of memory used.

pet1.bark();
console.log('Direct properties on dog', Object.keys(dog)); // [bark]
console.log('Direct properties on pet1', Object.keys(pet1)); // []
console.log('Properties on prototype of pet1', Object.keys(pet1.__proto__)); // [bark]
