// class Monster {
//   name: string;

//   constructor(name: string) {
//     this.name = name;
//   }

//   attack() {
//     console.log(`${this.name} attacked`);
//   }

//   walk() {
//     console.log(`${this.name} walked`);
//   }
// }

// class FlyingMonster extends Monster {
//   fly() {
//     console.log(`${this.name} flew`);
//   }
// }

// class SwimmingMonster extends Monster {
//   swim() {
//     console.log(`${this.name} swam`);
//   }
// }

// const bear = new Monster('bear');
// bear.walk();
// bear.attack();

// const eagle = new FlyingMonster('eagle');
// eagle.walk();
// eagle.attack();
// eagle.fly();

// const shark = new SwimmingMonster('shark');
// shark.walk();
// shark.attack();
// shark.swim();

// // It's Ok until one day, we want a monster can swim and fly. How to implement it?
// // If create new class FlyingSwimmingMonster ==> duplicated code
// class FlyingSwimmingMonster extends Monster {
//   fly() {
//     console.log(`${this.name} flew`);
//   }
//   swim() {
//     console.log(`${this.name} swam`);
//   }
// }

//==============================
interface Monster {
  name: string;
}

function attackerAndWalker({ name }: Monster) {
  return {
    attack: () => console.log(`${name} attacked`),
    walk: () => console.log(`${name} walked`),
  };
}

function swimmer({ name }: Monster) {
  return {
    swim: () => console.log(`${name} swam`),
  };
}

function flyer({ name }: Monster) {
  return {
    fly: () => console.log(`${name} flew`),
  };
}

function swimmingMonsterCreator(name: string) {
  const monster: Monster = { name };

  return {
    ...monster,
    ...attackerAndWalker(monster),
    ...swimmer(monster),
  };
}

function flyingMonsterCreator(name: string) {
  const monster: Monster = { name };

  return {
    ...monster,
    ...attackerAndWalker(monster),
    ...flyer(monster),
  };
}

function flyingSwimmingMonsterCreator(name: string) {
  const monster: Monster = { name };

  return {
    ...monster,
    ...attackerAndWalker(monster),
    ...swimmer(monster),
    ...flyer(monster),
  };
}

const swimObj = swimmingMonsterCreator('Shark');
swimObj.swim();

const flyObj = flyingMonsterCreator('Eagle');
flyObj.fly();

const swimFlyObj = flyingSwimmingMonsterCreator('Duck');
swimFlyObj.fly();
swimFlyObj.swim();
swimFlyObj.attack();
swimFlyObj.walk();
