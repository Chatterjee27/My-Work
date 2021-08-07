//creating variables in JS
//1.
"use strict";
name='Sayantan Chatterjee'
//Variables declared in line 3 above are global variables

console.log('My Name is ' + name)

//2.

// var x=10.45;
// console.log('The value of x is '+x)
console.log('Data type of x is :' + typeof x)

var a =10;
console.log('Data type of a is :' + typeof a)
a='Hi'
console.log(a)
console.log('Data type of a is :' + typeof a)

//Basic Datatype of JS

var isEmployed=true
var age=22
var myName='Giorgio Pesci'
var mySalary
var gender='M'
var myCity=null
//console.log('Data type of isEmployed is' + typeof isEmployed)
let emailId='xyz@yahoo.com'
//Variables in JS are declared in camelCase
//Function in JS are written in camelCase


console.log('Name is' + myName + 'data type of' + myName + 'is' + typeof myName)

//ES6
console.log(` My name is ${myName} and data type of ${myName} is ${typeof myName}`)
console.log(` My name is ${age} and data type of ${age} is ${typeof age}`)
console.log(` My name is ${isEmployed} and data type of ${isEmployed} is ${typeof isEmployed}`)
console.log(` My name is ${gender} and data type of ${gender} is ${typeof gender}`)
console.log(` My name is ${myCity} and data type of ${myCity} is ${typeof myCity}`)
console.log(` My name is ${mySalary} and data type of ${mySalary} is ${typeof mySalary}`)

//var does not have block level scope

console.log('Block Level Scope........')

for(let x=0; x<10; x++)
{
    console.log(x);
}

//console.log(`value of x after for loop ${x}`)

//ES-6 -let const
//const statement values can be assigned once and the cannot be reassigned
//scope const works same as let

 const empId=1234
//empId= empId+10;
 console.log(empId)

//ternary operator

let firstName = 'David'
let perAge= 12 ;
perAge >= 18 ?console.log(`${firstName} is eligible to Vote`) : console.log(`${firstName} is still Kid`)


//Truthy and falsy values

//predefiened falsy values are : null, undefined,0,'',NAN

//truthy values : 

var height='thirty'

if(height || height === 0){
    console.log(`${height} is defined`)
}
else{
    console.log(`${height} is not defined`)
}

//equality : in Js best paractice to check for equality is using === and
//not ==

let num = '3'
console.log(typeof num)

if(num === 3)
{
    console.log('The number value is 3')
}
else{
    console.log('The value of num is NOT 3')
}

//== we are checking onlyfor the value
//=== we are checking for type and value as well

//!==
//!=