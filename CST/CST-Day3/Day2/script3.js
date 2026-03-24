let s = prompt("Please Enter a string");

let elems = s.split(" ");
let word = "";
for (let i = 0; i < elems.length; i++) {
  if (elems[i].length > word.length) word = elems[i];
}
document.write("The largest word is " + word);
