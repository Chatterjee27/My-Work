//named fucntions, callback functions, anonymous functions IIFE
//constructor functions, arrow functions(ES-6)


let todayYear = new Date()
//named fucntion
function calculateAge(birthYear){ 

   let todayYear = new Date()
   console.log(todayYear.getFullYear())
   
   return todayYear.getFullYear() - birthYear
}

let sayanAge=calculateAge(1998)
let soumyaAge=calculateAge(1999)
let anikAge=calculateAge(1997)

console.log(`Age is ${sayanAge}`)
console.log(`Age is ${soumyaAge}`)
console.log(`Age is ${anikAge}`)


//or

// console.log(calculateAge(1997))

//Anonymus functions
let show =function(a,b){
    // a=20
    // a=30
    console.log('This is an anonymous functions'+ a,b)
}
show(34,56); //show here is a function variable

//IIFI -->immediately Invoked Functions Expressions(we need not cal the fucntions)

(function(a,b){
    console.log(a+b)
})(6,7)

let msg = function(){
    console.log(GoodmMorning)
}

msg()

//coverting the above anonymous function to arrow.


// ()=>{
//     console.log('Greeting from arrow function....')//for more thean one statement
// }

var addNums=(x,y)=> x+y
console.log( addNums(4,5))

let disX=(x)=>console.log(`the value of x is ${x} `)

disX('Hello')

let greetMsg=()=>console.log('Greeting from arrow function....')//for only statement

greetMsg()

// click(function(){

// },function(){
    
// },function(){

// })

// click(a,b,c)



