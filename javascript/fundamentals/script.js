/*let js = 'amazing';

let x = 40 + 8 - 23 + 10;
console.log(x)

////////////////////////////////////
// Values and Variables
console.log("Jonas");
console.log(23);

// let firstName = "Derek";

console.log(firstName);
console.log(firstName);
console.log(firstName);

// Variable name conventions
let jonas_matilda = "JM";
let $function = 27;

let person = "jonas";
let PI = 3.1415;

let myFirstJob = "Coder";
let myCurrentJob = "Teacher";

let job1 = "programmer";
let job2 = "teacher";

console.log(myFirstJob);

////////////////////////////////////
// Data Types
let javascriptIsFun = true;
console.log(javascriptIsFun);

// console.log(typeof true);
console.log(typeof javascriptIsFun);
// console.log(typeof 23);
// console.log(typeof 'Jonas');

javascriptIsFun = 'YES!';
console.log(typeof javascriptIsFun);

let year;
console.log(year);
console.log(typeof year);

year = 1991;
console.log(typeof year);

console.log(typeof null);

////////////////////////////////////
// let, const and var
let age = 30;
age = 31;

const birthYear = 1991;
// birthYear = 1990;
// const job;

var job = 'programmer';
job = 'teacher'

lastName = 'Schmedtmann';
console.log(lastName);

////////////////////////////////////
// Basic Operators
// Math operators
// const now = 2037;
// const ageJonas = now - 1991;
// const ageSarah = now - 2018;
// console.log(ageJonas, ageSarah);

console.log(ageJonas * 2, ageJonas / 10, 2 ** 3);
// 2 ** 3 means 2 to the power of 3 = 2 * 2 * 2

const firstName = 'Jonas';
const lastName = 'Schmedtmann';
console.log(firstName + ' ' + lastName);

// Assignment operators
let y = 10 + 5; // 15
y += 10; // y = y + 10 = 25
y *= 4; // y = y * 4 = 100
y++; // y = y + 1
y--;
y--;
console.log(y);

// Comparison operators
console.log(ageJonas > ageSarah); // >, <, >=, <=

console.log(ageSarah >= 18);

const isFullAge = ageSarah >= 18;

console.log(now - 1991 > now - 2018);

////////////////////////////////////
// Operator Precedence
const now = 2037;
const ageJonas = now - 1991;
const ageSarah = now - 2018;

console.log(now - 1991 > now - 2018);

let x, n;
x = n = 25 - 10 - 5; // x = n = 10, x = 10
console.log(x, n);

const averageAge = (ageJonas + ageSarah) / 2;
console.log(ageJonas, ageSarah, averageAge);

////////////////////////////////////


const firstName = "derek"
const job = "software engineer"
const birthYear = 1998
const curr_year = 2023

const derek = "I'm " + firstName + ', a ' + (curr_year-birthYear) + ' years old ' + job + '!';
console.log(derek)  

const derekNew = `I'm ${firstName}, a ${curr_year-birthYear} years old ${job}!`;



const age = 15


if (age >= 18) {
    console.log("Sarah can start driving license 🚗")
} else {
    const yearsLeft = 18 - age;
    console.log(`Sarah is too young. Wait another ${yearsLeft} years :)`)
}

// control structure for if else statements: 

// if (condition) {
//     // code
// }
// else if (another condition) {
//     // code
// } 

// const birthYear = 1991
// let century; 
// if (birthYear <= 2000) {
//     let century = 20; 
// } else {
//     let century = 21;
// }
// console.log(century)

////////////////////////////////
// Type Conversion and Coercion

// type conversion -- manually change type from one to another 

const inputYear = '1991';
console.log(inputYear + 18);
console.log(Number(inputYear) + 18);

console.log(Number('Derek'));
console.log(typeof NaN);

console.log(String(23), 23);

// type coercion -- javascript automatically change type from one to another

console.log('I am ' + 23 + ' years old'); // + operator turns numbers into strings 
console.log('23' - '10' - 3); // - operator turns strings into numbers 

console.log('23' * '2'); // converts them to numbers 
console.log('23' / '2'); // converts to numbers 


// truthy and falsy values 
// 5 falsy values: 0, '', undefined, null, NaN -- they will be converted to false when we attempt to convert them into a boolean 

console.log(Boolean(0));
console.log(Boolean(undefined));
console.log(Boolean('Derek'));
console.log(Boolean({}));
console.log(Boolean(''));
console.log(!null);
console.log(!'Derek');
console.log(!0);

const money = 0 
if (money) {
    console.log("Don't spend it all");
} else {
    console.log("You should get a job"); // this converts the if condition to false so it runs the else statement (falsey value) 
}

*/
////////////////////////////////////
// Equality Operators: == vs. ===

const age = '18'
if (age === 18) console.log('you just became an adult (strict -- does not perform type coersion)')

if (age == 18) console.log("you just became an adult (loose -- it does perform type coersion meaning '18' == 18)")

const favorite = Number(prompt("What's your favorite number?"));
console.log(favorite);
console.log(typeof favorite);

if (favorite == 23) {
    console.log('Cool! 23 is an amazing number!')
}

if (favorite === 23) {
    console.log('Cool! 23 is an amazing number!')
} else if (favorite === 8) {
    console.log('8 is also a cool number')
} else {
    console.log('Number is not 23 or 8')
}

if (favorite !== 23) console.log('Why not 23?') // strict (!==) and loose (!=) -- always use the strict version 

*/