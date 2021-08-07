// 'use strict';
//arrays in JS
//declaring array 1. Shorthand notation


 let names = ['Sayantan' , 'Soumya' , 'Shobhandeep' ,'Vranda']

 console.log(names)

//declaring arrays 2. using constructer fucntion

// let newArray= new Arrays() //empty array

// console.log(newArray)

let objArray = new Array(names, 'hello' , 'hi')
console.log(objArray)


//iterating through the names array


for(let i=0 ; i<name.length ; i++){
    console.log(names[i])
}

//iterating using for-in and for-of loops in JS

console.log('For-in loop-------------')

for(let x in names)
{
    console.log(x)
}

console.log('For-of loop-------------')

for(let x of names)
{
    console.log(x)
}

//iterating through forEach loop
names.forEach(function myFunc(n){
    console.log(n)
    
});

console.log('Array foreach using Arrow Function...............')

names.forEach((a) => console.log(a))//for more than one parameters we have to use()

//OR

names.forEach(c => console.log(c))//for just one parameter

// names.forEach((a,b) => console.log(a))

// names.forEach(() => console.log('hi'))

console.log(names)

console.log(names.push('Avina'))

console.log('New list of names array after puhing a new line.......')

console.log(names)

//by using methods loke push,pop etc i am loosing the original state of data and that is called as mutability in JS
//best practice in NOT to mutate states

//immutability in JS

console.log('Originsal array :' +names )

//adding a new element in the array without loosing the initial state
//using spread operator//

let newNames =  [...names,'Manush'] //spreadoperator by those 3 dots then parameter and then we should add a new value for it
console.log('New array with Manush added : ' +newNames)
console.log('Original array: ' , names)
let nums = [1,2,3,4,5,6,7,8,9,10]
//using map function
let multyNumBy2=nums.map((z)=>{
    return z*2
})

console.log('\n' +  multyNumBy2 + ' using map function.......')

for(let val of nums)
{
    val = val*2
    console.log(val)
}

