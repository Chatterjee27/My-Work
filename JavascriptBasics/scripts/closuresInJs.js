//closures in JS
//eg:1
var a='One'
function outer(){
    var b='two'
    function middle(){
        var c='three'
        function inner(){
            console.log(a + ' ' + b + ' ' + c)
        }
        inner()
    }
    middle()
}

outer()

//eg2

function greet(msgtosay){
    return function(name){
        console.log(msgtosay + ' ' + name)
    }
}

greet('Hello')('Giorgio')

let funOuter=greet('No Lunch Today')
console.log(funOuter('Deipanjan'))//global execution context

//eg3.
function retirement(retirementAge){ 
    let a='years left until retirement'
    return function(yearOfBirth){
        let currentYr = new Date().getFullYear()
        let ageInYrs = currentYr-yearOfBirth
        console.log((retirementAge-ageInYrs) + a)
    }
}

let retirementEU = retirement(65);
retirementEU(1997)

let retirementIN = retirement(60);
retirementEU(1997)
