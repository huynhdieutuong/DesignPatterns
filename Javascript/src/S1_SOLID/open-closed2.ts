// enum QuestionType {
//   Boolean = 'boolean',
//   MultipleChoice = 'multipleChoice',
//   Text = 'text',
//   Range = 'range'
// }

// interface Question {
//   type: QuestionType
//   description: string
//   options?: string[]
// }

// function printQuiz(questions: Question[]) {
//   questions.forEach(question => {
//     console.log(question.description)
//     switch(question.type) {
//       case QuestionType.Boolean:
//         console.log('1. True')
//         console.log('2. False')
//         break
//       case QuestionType.MultipleChoice:
//         question.options.forEach((option, index) => {
//           console.log(`${index + 1}. ${option}`)
//         })
//         break
//       case QuestionType.Text:
//         console.log('Answer: ______________')
//         break
//       case QuestionType.Range:
//         console.log('Minimum: ______________')
//         console.log('Maximum: ______________')
//         break
//     }
//     console.log('')
//   })
// }

// const questions: Question[] = [
//   {
//     type: QuestionType.Boolean,
//     description: 'This video is useful.'
//   },
//   {
//     type: QuestionType.MultipleChoice,
//     description: 'What is your favorite language?',
//     options: ['CSS', 'HTML', 'JS', 'Python']
//   },
//   {
//     type: QuestionType.Text,
//     description: 'Describe your favorite JS feature.'
//   },
//   {
//     type: QuestionType.Range,
//     description: 'What is the speed limit in your city?'
//   }
// ]

// printQuiz(questions)
// When we want to add new type (Range type), we need to add into printQuiz function ===> Violet OCP
//================================

enum QuestionType {
  Boolean = 'boolean',
  MultipleChoice = 'multipleChoice',
  Text = 'text',
  Range = 'range',
}

interface Question {
  type: QuestionType;
  description: string;
  options?: string[];
}

function printQuiz(questions: Question[]) {
  questions.forEach((question) => {
    console.log(question.description);
    switch (question.type) {
      case QuestionType.Boolean:
        console.log('1. True');
        console.log('2. False');
        break;
      case QuestionType.MultipleChoice:
        question.options.forEach((option, index) => {
          console.log(`${index + 1}. ${option}`);
        });
        break;
      case QuestionType.Text:
        console.log('Answer: ______________');
        break;
      case QuestionType.Range:
        console.log('Minimum: ______________');
        console.log('Maximum: ______________');
        break;
    }
    console.log('');
  });
}

class BooleanQuestion {
  type: QuestionType;
  description: string;

  constructor(type: QuestionType, description: string) {
    this.type = type;
    this.description = description;
  }

  printQuestion() {
    console.log('1. True');
    console.log('2. False');
  }
}

const questions: Question[] = [
  {
    type: QuestionType.Boolean,
    description: 'This video is useful.',
  },
  {
    type: QuestionType.MultipleChoice,
    description: 'What is your favorite language?',
    options: ['CSS', 'HTML', 'JS', 'Python'],
  },
  {
    type: QuestionType.Text,
    description: 'Describe your favorite JS feature.',
  },
  {
    type: QuestionType.Range,
    description: 'What is the speed limit in your city?',
  },
];
