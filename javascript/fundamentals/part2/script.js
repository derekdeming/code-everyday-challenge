'use strict'; 

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
*/

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