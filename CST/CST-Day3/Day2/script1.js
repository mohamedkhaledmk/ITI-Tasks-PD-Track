let s = prompt("Please Enter a string");
let c = prompt("Please Enter a character");
while (c.length > 1) c = prompt("Please Enter a character");
let i = prompt("Please Enter a c for case sensitive or i for case insensitive");
while (i != "c" && i != "i")
  i = prompt("Please Enter a c for case sensitive or i for case insensitive");

let count = 0;
if (i == "i") s = s.toLowerCase();
for (let j = 0; j < s.length; j++) {
  if (s[j] == c) count++;
}
document.write("n.o. characters in sentence " + s.length);
document.write("<br>n.o. the character " + i + " in sentence" + count);
