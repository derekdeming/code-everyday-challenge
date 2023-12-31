"use strict";

/*
///////////////////////////////////////
// Activating Strict Mode -- makes sure to write "secure javascript" -- must be at the top 

let hasDriversLicense = false;
const passTest = true;

if (passTest) hasDriversLicense = true;
if (hasDriversLicense) console.log('I can drive :D');

// const interface = 'Audio';
// const private = 534;


///////////////////////////////////////
// Functions
function logger() {
    console.log('My name is Jonas');
  }

// calling / running / invoking function
logger(); 
logger();
logger();

function fruitProcessor(apples, oranges) {
    const juice = `Juice with ${apples} apples and ${oranges} oranges.`;
    return juice;
}

const appleJuice = fruitProcessor(5, 0); // 5, 0 are arguments
console.log(appleJuice);

const appleOrangeJuice = fruitProcessor(2, 4 );
console.log(appleOrangeJuice);

const num = Number('23');


///////////////////////////////////////
// Function Declarations vs. Expressions

// Function declaration
function calcAge(birthyear) {
    return 2037 - birthyear;
}
const age1 = calcAge(1991)
console.log(age1)

// Function expression (annonymous function)
const calcAge2 = function (birthyear) {
    return 2037 - birthyear;
}

const age2 = calcAge2(1991)
console.log(age1, age2)


///////////////////////////////////////
// Arrow functions (still considered a function expression -- return happens implicitly )
const calcAge3 = birthyear => 2037 - birthyear;
const age3 = calcAge3(1991)
console.log(age3)

const yearsUntilRetirement = (birthyear, firstName) => {
    const age = 2037 - birthyear;
    const retirement = 65 - age;
    // return retirement;
    return `${firstName} retires in ${retirement} years`;
}
console.log(yearsUntilRetirement(1991, 'Jonah'))
console.log(yearsUntilRetirement(1980, 'Bob'))


///////////////////////////////////////
// Functions Calling Other Functions

function cutFruitPieces(fruit) {
    return fruit * 4;
}

function fruitProcessor(apples, oranges) {
    const applePieces = cutFruitPieces(apples);
    const orangePieces = cutFruitPieces(oranges);
  
    const juice = `Juice with ${applePieces} piece of apple and ${orangePieces} pieces of orange.`;
    return juice;
  }
  console.log(fruitProcessor(2, 3));


  ///////////////////////////////////////
// Reviewing Functions

const calcAge = function (birthyear) {
    return 2037 - birthyear;
  }
  
  const yearsUntilRetirement = function (birthyear, firstName) {
    const age = calcAge(birthyear);
    const retirement = 65 - age;
  
    if (retirement > 0) {
      console.log(`${firstName} retires in ${retirement} years`);
      return retirement;
    } else {
      console.log(`${firstName} has already retired 🎉`);
      return -1;
    }
  }
  
  console.log(yearsUntilRetirement(1991, 'Jonas'));
  console.log(yearsUntilRetirement(1950, 'Mike'));

   //////// CODING  CHALLENGE: 
   const calcAverage = (score1, score2, score3) => (score1 + score2 + score3) / 3
console.log(calcAverage(44, 23, 71))

let scoreDolphins = calcAverage(44, 23, 71)
let scoreKoalas = calcAverage(65, 54, 49)
console.log(scoreKoalas, scoreDolphins)

const checkWinner = function (avgDolphins, avgKoalas) {
    if (avgDolphins >= 2 * avgKoalas) {
        console.log(`Dolphins win 🏆 (${avgDolphins} vs. ${avgKoalas})`)
    } else if (avgKoalas >= 2 * avgDolphins) {
        console.log(`Koalas win 🏆 (${avgKoalas} vs. ${avgDolphins})`)
    } else {
        console.log('No team wins')
    }
}

checkWinner(scoreDolphins, scoreKoalas)

///////////////////////////////////////
// Introduction to Arrays
const friend1 = 'Michael';
const friend2 = 'Steven';
const friend3 = 'Peter';

const friends = ['Michael', 'Steven', 'Peter']
console.log(friends)
const friends2 = [friend1, friend2, friend3]
console.log(friends2)
const y = new Array(1991, 1987, 1988, 2009, 2303);
console.log(y)

console.log(friends[0])
console.log(friends[2])
console.log(friends.length)
console.log(friends[friends.length - 1])

friends[2] = 'Jay'
console.log(friends)
// 

const firstName = 'Jonas'
const jonas = [firstName, 'Schmedtmann', 2037 - 1991, 'teacher', friends]
console.log(jonas)
console.log(jonas.length)

const calcAge = function (birthyear) {
    return 2037 - birthyear; 
}
const years = [1990, 1993, 1803, 2083]
console.log(calcAge(years))

for (let i = 0; i < years.length; i++) {
    console.log(calcAge(years[i]))
}

const age1 = calcAge(years[0]);
const age2 = calcAge(years[1]);
const age3 = calcAge(years[years.length - 1]);
console.log(age1, age2, age3);

const ages = [calcAge(years[0]), calcAge(years[1]), calcAge(years[years.length - 1])];
console.log(ages);

///////////////////////////////////////
// Basic Array Operations (Methods)
const friends = ['Michael', 'Steven', 'Peter'];
console.log(friends) // length == 3
friends.push('Jay'); // changed / mutated array by adding Jay to the end of the array 
// push: added the element to the end of the array AND returns the new length of the array as a value 
console.log(friends)
console.log(friends.length) // returns 4 

friends.unshift('John') // adds John to the beginning of the array
console.log(friends)
// unshift also returns the new length of the array 

friends.pop() // removes the last element of the array
console.log(friends)
// pop also returns the element that was removed
const popped = friends.pop()
console.log(popped)

friends.shift() // removes the first element of the array
console.log(friends)
const firstelement = friends.shift()
console.log(firstelement)

console.log(friends.indexOf('Steven')) // returns the index of the element in the array
console.log(friends.indexOf('Bob')) // returns -1 if the element is not in the array

friends.push(23);
console.log(friends.includes('Steven')); // includes: returns true or false if the element is in the array  
console.log(friends.includes('Bob')); 
console.log(friends.includes(23));
if (friends.includes('Steven')) {
    console.log('You have a friend called Steven')
}



///////////////////////////////////////
// Coding Challenge #2

const calcTip = function (bill) {
    if (bill >= 50 && bill <= 300) {
        return bill * .15
    } else {
        return bill * .2
    }
}

const bills = [125, 555, 44]
const tips = [calcTip(bills[0]), calcTip(bills[1]), calcTip(bills[2])]
const totals = [bills[0] + tips[0], bills[1] + tips[1], bills[2] + tips[2] ]
console.log(bills, tips, totals)



///////////////////////////////////////
// Introduction to Objects
const jonasArray = [
    'Jonas',
    'Schmedtmann',
    2037 - 1991,
    'teacher',
    ['Michael', 'Peter', 'Steven']
  ];

const jonas = {
    firstName: 'Jonas',
    lastName: 'Schmedtmann',
    age: 2037 - 1991,
    job: 'teacher',
    friends: ['Michael', 'Peter', 'Steven']
}; // object literal syntax 
// objects are equivalent to dictionaries in python
// objects are unordered
console.log(jonas) // objects contain key value pairs which are called properties so firstName is a property of the jonas object




///////////////////////////////////////
// Dot vs. Bracket Notation
const jonas = {
    firstName: 'Jonas',
    lastName: 'Schmedtmann',
    age: 2037 - 1991,
    job: 'teacher',
    friends: ['Michael', 'Peter', 'Steven']
  };
console.log(jonas);

console.log(jonas.lastName); // dot notation
console.log(jonas['lastName']); // bracket notation

const nameKey = 'Name';
console.log(jonas['first' + nameKey]) // bracket notation with expression
console.log(jonas['last' + nameKey])

// console.log(jonas.'last' + nameKey) // dot notation with expression -- does not work

const interestedIn = prompt('What do you want to know about Jonas? Choose between firstName, lastName, age, job, and friends') // prompt returns a string and is equivalent to input in python
console.log(interestedIn)
console.log(jonas[interestedIn]) // bracket notation with prompt

if (jonas[interestedIn]) {
    console.log(jonas[interestedIn])
}
else {
    console.log('Wrong request! Choose between firstName, lastName, age, job, and friends')
}

jonas.location = 'Portugal' // adds a new property to the jonas object
jonas['twitter'] = '@jonasschmedtman' // adds a new property to the jonas object
console.log(jonas)

// Challenge
console.log(`${jonas.firstName} has ${jonas.friends.length} friends, and his best friend is called ${jonas.friends[0]}`);


///////////////////////////////////////
// Object Methods

const jonas = {
    firstName: 'Jonas',
    lastName: 'Schmedtmann',
    birthyear: 1991,
    age: 2037 - 1991,
    job: 'teacher',
    friends: ['Michael', 'Peter', 'Steven'],
    hasDriversLicense: true,

    // calcAge: function (birthYeah) {
    //   return 2037 - birthYeah;
    // }

    // calcAge: function () {
    //   // console.log(this);
    //   return 2037 - this.birthYeah;
    // }

    calcAge: function () {
        this.age = 2037 - this.birthyear;
        return this.age;
    }, // this keyword is the jonas object -- this allows us to access the properties of the object inside the object itself so that we don't have to repeat the object name such as birthyear
    getSummary: function () {
        return `${this.firstName} is a ${this.calcAge()}-year old ${this.job}, and he has ${this.hasDriversLicense ? 'a' : 'no'} driver's license.`
    }
  };
console.log(jonas);
console.log(jonas.calcAge());
console.log(jonas['calcAge']());

// Challenge
// "Jonas is a 46-year old teacher, and he has a driver's license"
console.log(jonas.getSummary());



///////////////////////////////////////
// Coding Challenge #3

const mark = {
    fullName: 'Mark Miller',
    mass: 78,
    height: 1.69,
    calcBMI: function () {
      this.bmi = this.mass / (this.height * this.height);
      return this.bmi;
    }
  };

  const john = {
    fullName: 'John Smith',
    mass: 92,
    height: 1.95,
    calcBMI: function () {
      this.bmi = this.mass / (this.height * this.height);
      return this.bmi;
    }
  };

mark.calcBMI();
john.calcBMI();

console.log(mark.bmi, john.bmi);

if (mark.bmi > john.bmi) {
    console.log(`${mark.fullName}'s BMI (${mark.bmi}) is higher than ${john.fullName}'s BMI (${john.bmi})`)
} else if (john.bmi > mark.bmi) {
    console.log(`${john.fullName}'s BMI (${john.bmi}) is higher than ${mark.fullName}'s BMI (${mark.bmi})`)
}

console.log(mark.calcBMI(), john.calcBMI())



///////////////////////////////////////
// Iteration: The for Loop
// for loop keeps running while condition is TRUE

console.log('Lifting weights repetition 1 🏋️‍♀️')
console.log('Lifting weights repetition 2 🏋️‍♀️')
console.log('Lifting weights repetition 3 🏋️‍♀️')
console.log('Lifting weights repetition 4 🏋️‍♀️')
console.log('Lifting weights repetition 5 🏋️‍♀️')
console.log('Lifting weights repetition 6 🏋️‍♀️')
console.log('Lifting weights repetition 7 🏋️‍♀️')
console.log('Lifting weights repetition 8 🏋️‍♀️')
console.log('Lifting weights repetition 9 🏋️‍♀️')
console.log('Lifting weights repetition 10 🏋️‍♀️')

// for loop keeps running while condition is TRUE
for (let rep = 1; rep <= 10; rep++) {
    console.log(`Lifting weights repetition ${rep} 🏋️‍♀️`)
} // rep = rep + 1
// for loop structure is made up of 3 parts: 1) initial value of the counter variable, 2) condition that is evaluated before each iteration, 3) counter update after each iteration



///////////////////////////////////////
// Looping Arrays, Breaking and Continuing
const jonas = [
    'Jonas',
    'Schmedtmann',
    2037 - 1991,
    'teacher',
    ['Michael', 'Peter', 'Steven'],
    true
];

const types = []

for (let i = 0; i < jonas.length; i++) {
    // reading from jonas array
    console.log(jonas[i], typeof jonas[i])

    // filling types array -- method 1 
    types[i] = typeof jonas[i]
    // filling types array -- method 2 -- better 
    types.push(typeof jonas[i])
}
console.log(types)

const years = [1991, 2007, 1969, 2020]
const ages = []
for (let i = 0 ; i < years.length; i++) {
    ages.push(2037 - years[i])
}
console.log(ages)

// continue and break
// continue exits the current iteration of the loop and continues to the next one
// break completely terminates the whole loop

for (let i = 0; i < jonas.length; i++) {
    if (typeof jonas[i] !== 'string') continue; // if the element is not a string, then continue to the next iteration
    console.log(jonas[i], typeof jonas[i])
}
console.log(types)
console.log('--- ONLY STRINGS ---')

console.log('--- BREAK WITH NUMBER ---')
for (let i = 0; i < jonas.length; i++) {
    if (typeof jonas[i] === 'number') break; // if the element is a number, then break out of the loop
    console.log(jonas[i], typeof jonas[i])
}



///////////////////////////////////////
// Looping Backwards and Loops in Loops
const jonas = [
    'Jonas',
    'Schmedtmann',
    2037 - 1991,
    'teacher',
    ['Michael', 'Peter', 'Steven'],
    true
];

for (let i = jonas.length - 1; i >= 0; i--) {
    console.log(i, jonas[i])
}

// looping inside of a loop


for (let exercise = 1; exercise < 4; exercise++) {
    console.log(`-------- Starting exercise ${exercise} --------`)
    for (let rep = 1; rep < 6; rep++) {
        console.log(`Exercise ${exercise}: Lifting weight repetition ${rep} 🏋️‍♀️`)
    }
}

*/

// While Loop -- while loop keeps running while condition is TRUE

let rep = 1
while (rep < 10) {
    console.log(`Lifting weights repetition ${rep} 🏋️‍♀️`)
    rep++
}

// while loop structure: 1) condition, 2) counter update 

let dice = Math.trunc(Math.random() * 6) + 1
console.log(dice)

while (dice !== 6) {
    console.log(`You rolled a ${dice}`)
    dice = Math.trunc(Math.random() * 6) + 1
    if (dice === 6) console.log('Loop is about to end...')
let dice = Math.trunc(Math.random() * 6) + 1
console.log(dice)

let iterations = 0
while (dice !== 6) {
    console.log(`You rolled a ${dice}`)
    dice = Math.trunc(Math.random() * 6) + 1
    iterations++
    if (dice === 6) console.log(`Loop ended after ${iterations} iterations.`)
}
}

// Coding Challenge #4

const calcTip = function (bill) {
    return bill >= 50 && bill <= 300 ? bill * 0.15 : bill * 0.2;
}

const bills = [22, 295, 176, 440, 37, 105, 10, 1100, 86, 52]
const tips = []
const totals = []

for (let i = 0; i < bills.length; i++) {
    const tip = calcTip(bills[i])
    tips.push(tip)
    totals.push(tip + bills[i])
}


