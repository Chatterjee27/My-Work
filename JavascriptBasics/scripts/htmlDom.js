// let btn = document.getElementById('btn')
// let btn1=document.querySelector('.myclass')
//console.log(btn1)
// let div1 = document.querySelectorAll('.myclass')
// let div = document.getElementsByClassName('myclass')[1]
// console.log(div)
 
// let allDivs= document.getElementsByTagName('div')
// let allDivsAgain= document.querySelectorAll('div')
//console.log(allDivs)
 
// function onBtnClick(){
//    div.innerHTML='HTML DOM ELEMNETS.....'
// }
//btn.addEventListener('click',onBtnClick)
 
// div.addEventListener('mouseover',()=>{
//     div.cursor='pointer'
//     div.style.display='inline'
//     div.style.backgroundColor='yellow'
 
   // allDivs.style.backgroundColor='yellow'
//})
// div.addEventListener('mouseout',()=>{
//     div.cursor='pointer'
//     div.style.display='inline'
//     div.style.backgroundColor='white'
 
   // allDivs.style.backgroundColor='yellow'
//})
let btn = document.getElementById('btnAdd')
function addNums(){
    
    let inputVal1= parseInt(document.getElementById('num1').value)
    let inputVal2= parseInt(document.getElementById('num2').value)
    let res= inputVal1 + inputVal2
alert(res)
let div = document.querySelector('#result')
div.innerHTML= res.toString()
 
}
btn.addEventListener('click',addNums)


 
//alert(inputVal1)