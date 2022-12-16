/**
 * Singletons are classes which can be instantiated once, and can be accessed globally.
 * This single instance can be shared throughout our application, which makes Singletons great for managing global state in an application.
 */

// let counter = 0;

// class Counter {
//   getInstance() {
//     return this;
//   }

//   getCount() {
//     return counter;
//   }

//   increment() {
//     return ++counter;
//   }

//   decrement() {
//     return --counter;
//   }
// }

// const counter1 = new Counter();
// const counter2 = new Counter();
// console.log(counter1.getInstance() === counter2.getInstance()); // false

/**
 * This class doesn't meet the criteria for a Singleton!
 * A Singleton should only be able to get instantiated once.
 * Currently, we can create multiple instances of the Counter class.
 */

// ====================================================

// let instance: object;
// let counter = 0;

// class Counter {
//   constructor() {
//     if (instance) {
//       throw new Error('You can only create one instance!');
//     }
//     instance = this;
//   }

//   getInstance() {
//     return this;
//   }

//   getCount() {
//     return counter;
//   }

//   increment() {
//     return ++counter;
//   }

//   decrement() {
//     return --counter;
//   }
// }

// const counter1 = new Counter();
// const counter2 = new Counter(); // throw error

// const singletonCounter = Object.freeze(new Counter());
/**
 * The Object.freeze method makes sure that consuming code cannot modify the Singleton.
 */
// export default singletonCounter;

// ==================================
/**
 * Singletons are actually considered an anti-pattern, and can be avoided in JavaScript.
 * Because we can directly create objects in JavaScript, we can simply use a regular object to achieve the same result.
 */

let count = 0;

const counter = {
  getCount() {
    return count;
  },
  increment() {
    return ++count;
  },
  decrement() {
    return --count;
  },
};

Object.freeze(counter);

export default counter;
