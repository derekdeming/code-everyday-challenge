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
*/
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