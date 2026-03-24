let num= prompt("Enter Num Value:");
let sum=parseInt(num);
while(num!=0&&sum<=100)
{
    num= prompt("Enter Num Value:");
    sum+=parseInt(num);
}
document.write(sum);