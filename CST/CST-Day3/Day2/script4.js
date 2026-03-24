let userName = prompt("Please Enter your name");
while (isFinite(userName)) userName = prompt("Please Enter your name");

let mobileReg = /^[0-9]{8}$/;
let phoneReg = /^(011|010|012|015)[0-9]{8}$/;
let emailReg = /^[a-zA-Z]+@[a-zA-Z1-9]+.(com|net|org)$/;

let phoneNO = prompt("Please Enter your phone number");
let phon = new RegExp(phoneReg);
let mob = new RegExp(mobileReg);
let em = new RegExp(emailReg);
while (isNaN(phoneNO) || !phon.test(phoneNO))
  phoneNO = prompt("Please Enter a valid phone number");

let mobileNO = prompt("Please Enter a valid mobile number");

while (isNaN(mobileNO) || !mob.test(mobileNO))
  mobileNO = prompt("Please Enter a valid mobile number");

let Email = prompt("Please Enter your email");
while (!em.test(Email)) {
  Email = prompt("Enter a valid email!");
}

let color = prompt("Please Enter color (Green or Red or Blue) Only!");
color = color.toLowerCase();
while (color != "green" && color != "blue" && color != "red") {
  let color = prompt("Please Enter color (Green or Red or Blue) Only!");
  color = color.toLowerCase();
}

console.log("%c Hello " + userName, "color:" + color);
console.log("%c Phone Number " + phoneNO, "color:" + color);
console.log("%c mobile number " + mobileNO, "color:" + color);
console.log("%c Email :  " + Email, "color:" + color);
