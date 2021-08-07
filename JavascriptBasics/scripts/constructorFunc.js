//creating custom constructor functions

//how to create co0nstructor funcion
//prototype
//difference between _proto_ and prototype

function Person(fname,lname,age){
    
        this.fname=fname
        this.lname=lname
        this.age=age

    }
 
//functions prototyps

   Person.prototype.city
   Person.prototype.district='Tijuana'
   Person.prototype.state

   var per1 = new Person('Sayantan' , 'Chatterjee' , 23)
   var per2 = new Person('Giogio' , 'Pesci' , 22)
   per2.city='Sinaloa'
   console.log(per1.city)
   console.log(per2.state)
   per2.state='Nicaragua'
//    var a1 = new Array()
//    var b1 = new Array()

console.log(per1)//Object of function
console.log(per2)//Constructor of function
console.log(per1.__proto__)

//per1 get access to the __proto__
//per2 access the prototype    