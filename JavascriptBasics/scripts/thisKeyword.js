// 'use strict';
console.log(this) //global execution context in client side JS and refers to window
console.log(document)

name='Zensar'
console.log(name)
console.log(this)
let employee={
    empId:1234,
    ename: 'Giorgio Pesci' ,
    esal:343355.56,
    calculateHRA:function(){
        console.log('in the hra function')
        return Math.round(0.1 * this.esal)
        //return Math.round(0.1 * employee.esal)//can also be written before finishing the employee
    }



}

console.log(`HRA deduction per month ${employee.calculateHRA()}`)

let emp1 = employee

console.log(emp1.ename)

console.log(`HRA deduction per month ${emp1.calculateHRA()}`)


let student = {
    rollNo : 100,
    marks1 : 74,
    marks2 : 77,
    marks3 : 76,
    avgMarks:()=>{
        return (student.marks1 + student.marks2 + student.marks3)/3
    }
}

console.log(student.rollNo)
console.log(student.avgMarks())

let stud = student

console.log(stud.avgMarks())










