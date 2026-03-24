let num1=parseInt(prompt("Enter num 1"));
let num2=parseInt(prompt("Enter num 2"));
let num3=parseInt(prompt("Enter num 3"));

if(num1%num2==0 && num1%num3==0)
{
    document.write(num1+" is divisible by "+num2+" and "+num3)
}else if(num1%num2==0)
{
    document.write(num1+" is divisible by "+num2)
}else if(num1%num3==0)
{
    document.write(num1+" is divisible by "+num3)
}else
{
    document.write(num1+" is not divisble by neither "+num2+" nor "+num3)
}