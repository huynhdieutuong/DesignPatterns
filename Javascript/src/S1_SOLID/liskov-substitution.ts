interface IEmployee {
  firstName: string;
  lastName: string;
  salary: number;
  calculatePerHourRate(rank: number): void;
}

interface IManager extends IEmployee {
  generatePerformanceReview(): void;
}

interface IManaged extends IEmployee {
  manager: IEmployee;
  assignManager(employee: IEmployee): void;
}

class BaseEmployee implements IEmployee {
  firstName: string;
  lastName: string;
  salary: number;

  calculatePerHourRate(rank: number): void {
    const baseAmount = 12.5;
    this.salary = baseAmount + rank * 2;
  }
}

class Employee extends BaseEmployee implements IManaged {
  manager: Employee;

  assignManager(employee: Employee): void {
    this.manager = employee;
  }
}

class Manager extends Employee implements IManager {
  calculatePerHourRate(rank: number): void {
    const baseAmount = 19.75;
    this.salary = baseAmount + rank * 4;
  }

  generatePerformanceReview(): void {
    console.log(`I'm reviewing a direct report's performance.`);
  }
}

class CEO extends BaseEmployee implements IManager {
  calculatePerHourRate(rank: number): void {
    const baseAmount = 150;
    this.salary = baseAmount * 4;
  }

  generatePerformanceReview(): void {
    console.log(`I'm reviewing a direct report's performance.`);
  }

  fireSomeone() {
    console.log(`You're Fired!`);
  }
}

const accountingVP: IManager = new Manager();
accountingVP.firstName = 'Emma';
accountingVP.lastName = 'Stone';
accountingVP.calculatePerHourRate(4);

const emp: IManaged = new Employee();
emp.firstName = 'Tim';
emp.lastName = 'Corey';
emp.assignManager(accountingVP);
emp.calculatePerHourRate(2);

console.log(`${emp.firstName}'s salary is ${emp.salary}/hour.`);
