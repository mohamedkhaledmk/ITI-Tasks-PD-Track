let num1=parseInt(prompt("Enter num 1"));
let num2=parseInt(prompt("Enter num 2"));
let sum=0;
let s = "Number multiple of 3: "
let s2 = "Number multiple of 5: "
for(let i=num1;i<=num2;i++)
{
    if(i%3==0&&i%5==0)
    {
        s+=i+" , "
        s2+=i+" , "
        sum+=i;
    }else if(i%3==0)
    {
        s+=i+" , "
        sum+=i; 
    }else if(i%5==0)
    {
        s2+=i+" , "
        sum+=i; 
    }
}

document.write(s+"<br>")
document.write(s2+"<br>")


document.write("<br>Total Sum is : "+sum)
