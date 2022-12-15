class Journal {
  entries: string[];
  count: number;

  constructor() {
    this.count = 0;
    this.entries = [];
  }

  addEntry(text: string) {
    this.entries.push(text);
    this.count++;
    return this.count;
  }

  removeEntry(index: number) {
    this.entries.splice(index, 1);
  }
}

class Persistence {
  saveToFile(journal: Journal, fileName: string) {
    console.log(journal.count);
    journal.entries.forEach((j) => console.log(j));
    console.log(`Saved into ${fileName} file.`);
  }
}

const journal = new Journal();
journal.addEntry('I cried today.');
journal.addEntry('I ate a bug.');

const p = new Persistence();
p.saveToFile(journal, 'Journal_1');
