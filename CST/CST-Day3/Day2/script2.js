let s = prompt("Please Enter a string");
let i = confirm(
  "Please Enter a c for case sensitive or i for case insensitive"
);

let flag = true;
let sz = s.length;
if (i) s = s.toLowerCase();
for (let j = 0; j <= sz / 2; j++) {
  if (s[j] != s[sz - 1 - j]) flag = false;
}
document.write("Palindrom Status: " + (flag ? "YES" : "NO"));
