//objects and properties

var arr = new Array()
console.log(arr)
// var doj = new Date()


//creating a custom objects
//1. short hand notation

let employee = {}//here employee is an empty object
console.log(employee)

//2. long hand notation

let student = new Object()
console.log(student)
student.rollNo=27
student.name='Test Stud'
student.maks=98


//ocustom object with properties inside it

let person = {
    firstName:'Rambo',
    lastName :'smith',
    age:22,
    isEmployed:false,
    annualIncome : 564578.8,
        addreess : {
            streeName : 'Mewar',
            city : 'Pune',
        },
    fullName:()=>{
        return this.firstName + ' ' + this.lastName
    }
}
    console.log(person)
    console.log(`The age of the person is' ${person.age} and
    full name is ${person.fullName()} person lives in ${person.addreess.city}`)

    console.log(person['isEmployed'] , '\n' + person['annualIncome'])
     
person.firstName='Sayan'
console.log(person)

//Custom object with properties inside it

let per1={
    firstName:'John',
    lastName :'Rambo',
    age:22,
    isEmployed:true,
    annualIncome : 564578.8,
        addreess : {
            streeName : 'Barcelona',
            city : 'Spain',
        },
    fullName:()=>{
        return this.firstName + ' ' + this.lastName
    }
}

console.log(per1)
