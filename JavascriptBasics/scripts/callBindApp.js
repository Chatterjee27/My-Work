// (function(){
 
// })()
 
//object literal
 
var david = {
    name:'David',
    age:26,
    job:'Developer',
    presentation:function(style,timeOfDay){
        if(style=== 'formal'){
            console.log('Good '+ timeOfDay + ', Ladies and gentlemen I am ' + this.name)
        }else if(style==='friendly'){
                console.log('Hey Whats up I am ' + this.name + ' and my age is ' + this.age + ' good'+timeOfDay)
        }else{
            console.log('Order Change ....' +this.name + ' and ' + this.age)
        }
    }
}
 
var john ={
    name:'John',
    age:45,
    job:'painter'
}
 
var azhar ={
    name:'Azhar',
    age:22,
    job:'Manager'
}
 
david.presentation('formal', 'morning')
david.presentation.call(john,'friendly','evening')
 
david.presentation.apply(azhar,['formal','afternoon'])
//obj.methodName()
 
//bind is very similar to call except 
//bind allows us to set the this variable explicitly
 
//bind method does not call the function immediately but it generates a
//copy of the function so that it can be stored
 
var davidFriendly = david.presentation.bind(david,'friendly')
 
var changeOrder= david.presentation.bind(david,'night')
changeOrder('friendly' +' CHANGE ORDER')
 
davidFriendly('night')
 
davidFriendly('morning')
 
var davidFormal=david.presentation.bind(david,'formal')
 
davidFormal('afternoon')
 
johnFriendly = david.presentation.bind(john,'friendly')
johnFriendly('late evening')
 
//PROPER EG ON CALL BIND APPLy
 var years =[1990,1965, 1937, 2005,1998]
 
 function arrayCalc(arr,fn){
     var arrRes=[]
     for(let i=0; i<arr.length; i++){
        arrRes.push(fn(arr[i])) 
     }
     return arrRes;
 }
 
 function calculateAge(el){
     return 2020-el
 }
 
 function isFullAge(limit,el){
     return el >=limit
 }
 
 var ages = arrayCalc(years,calculateAge)
 
var  fullIndia= arrayCalc(ages,isFullAge.bind(this,18))
 
console.log(fullIndia)
console.log('all Ages :' + ages)
 
var fullUS=arrayCalc(ages,isFullAge.bind(this,14))
console.log(fullUS)