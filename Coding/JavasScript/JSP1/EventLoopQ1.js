function test()
{
    console.log('2');
    setTimeout(()=>{

    console.log('b');
},999);

var d=new Promise((res,rej)=>{
    res(1);
    console.log(200);
}).then((val)=>{
    console.log(val)
}).finally(
    console.log('FF')
);
console.log('c')
}
test();