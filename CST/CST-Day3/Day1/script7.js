let x=parseInt(prompt("Enter num 1"));
while(isNaN(x))
{
    console.error("Please Enter number");
    x=parseInt(prompt("Enter num 2"));
}

let y=parseInt(prompt("Enter num 2"));
while(isNaN(y))
{
    console.error("Please Enter number");
    y=parseInt(prompt("Enter num 2"));
}
if(x>y)
    [x,y]=[y,x];
let z=prompt("Enter String");

let sum = 0;
if(z=="even")
{
    for(let i=x;i<=y;i++)
    {
        if(i%2==0)
        {
            document.write(i+" , ")
            sum+=i;
        }
    }
}else if(z=="odd")
    {
        for(let i=x;i<=y;i++)
            {
                if(i%2)
                {
                    document.write(i+" , ")
                    sum+=i;
                }
    }
}else if(z=="no")
{
    for(let i=x;i<=y;i++)
    {
            document.write(i+" , ")
            sum+=i;
    }
}
document.write("<br> sum is : "+sum)
console.warn("sum is "+ sum)