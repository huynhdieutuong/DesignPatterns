interface ObjectInterface {
  [key: string]: string | number;
}

interface Person extends ObjectInterface {
  name: string;
  age: number;
  nationality: string;
}

const person: Person = {
  name: 'John Doe',
  age: 42,
  nationality: 'American',
};

/**
 * Instead of interacting with person object directly, we want to interact with a proxy object.
 * In JS, we can easily create a new proxy by creating a new instance of Proxy.
 *
 * A proxy can be useful to add validation.
 * A user shouldn't be able to change person's age to a string value, or give them an empty name.
 * Or if the user is trying to access a property that doesn't exist, we should let the user know.
 * => The proxy made sure that we weren't modifying the person object with faulty values, which helps us keep our data pure!
 */
const personProxy = new Proxy(person, {
  get: (obj, prop: string) => {
    // const value = obj[prop]
    const value = Reflect.get(obj, prop);
    if (!value) {
      console.log(
        `Hmm.. this property doesn't seem to exist on the target object`
      );
      return;
    }
    console.log(`The value of ${prop} is ${value}`);
  },
  set: (obj, prop: string, value) => {
    if (prop === 'age' && typeof value !== 'number') {
      console.log(`Sorry, you can only pass numeric values for age`);
      return true;
    }
    if (prop === 'name' && value.length < 2) {
      console.log(`You need to provide a valid name`);
      return true;
    }
    console.log(`Changed ${prop} from ${obj[prop]} to ${value}`);
    // obj[prop] = value;
    // return true;
    return Reflect.set(obj, prop, value);
  },
});

personProxy.name; // The value of name is John Doe
personProxy.age = 43; // Changed age from 42 to 43

personProxy.unknown; // Hmm.. this property doesn't seem to exist on the target object
//personProxy.age = ''; // Sorry, you can only pass numeric values for age
personProxy.name = ''; // You need to provide a valid name
