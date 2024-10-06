
function testSplice()
{
 let Arr=[7,4,3,6,8,1,0];
 console.log('testSplice',Arr);
 Ar1=Arr.splice(1,3,88);

 console.log(Ar1);
 console.log(Arr);
   
}
function testslice()
{
 let Arr=[7,4,3,6,8,1,0];
 console.log('testslice',Arr);
 Ar1=Arr.slice(0,3);

 console.log(Ar1);
 console.log(Arr);
   
}
testslice();
testSplice()


