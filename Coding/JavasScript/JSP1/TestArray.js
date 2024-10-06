
function testArrayCopy()
{
 let Arr=[7,4,3,6,8,1,0];
 let ar1=[...Arr]
 ar1[0]=100;
 let ar2={...Arr}
 ar2[0]=200;
console.log('Array',Arr);
console.log('arr1',ar1);
console.log('arr2',ar2);
   
}

function ArrSort()
{
    let Arr=[7,4,3,6,8,1,0];
 
   for(let i=0;i<Arr.length-1;i++)
   {
    let  Max=0
    for(let j=i+1;j<Arr.length-1;j++)
        {
          
     
       if(Arr[i]>Arr[j])
       {
        let temp= Arr[i];
        Arr[i]= Arr[j];
        Arr[j] = temp;       
       }
    
    }


   }
   console.log(Arr)
}

function Arr2ndHighest()
{
    let Arr=[18,14,15,19,13,16,12,11,20];
    let FirstMax=-1    
    let SecondMax=-1;   
   for(let i=0;i<Arr.length;i++)
   {
   
   
     
       if(Arr[i]>FirstMax)
       {
        SecondMax=FirstMax;      
        FirstMax=Arr[i]; 
              
       }
       else if(Arr[i]>SecondMax && Arr[i]!=FirstMax)
        {
            SecondMax=Arr[i];             
        }     
   }
   console.log(SecondMax)
}

Arr2ndHighest();


