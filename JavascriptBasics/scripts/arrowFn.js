const emps = [
    {
        id:1234,
        ename:'David',
        esal:4321,
        empDet:function(){
            return `EmpName:${this.ename} and EmpId:${this.id}`
        }
    },

    {
        id:1235,
        ename:'Smith',
        esal:4321,
        empDet:()=>{
            return `EmpName:${emps[1].ename} and EmpId:${emps[1].id}`
        }
    },

    {
        id:1236,
        ename:'John',
        esal:4321
    },

    {
        id:1237,
        ename:'Scott',
        esal:4321
    },
]
console.log(emps[0].empDet())
console.log(emps[1].empDet())