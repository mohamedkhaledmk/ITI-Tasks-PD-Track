console.log(window.location);
let doc = window.document;
let data = location.search;

data = data.substr(1);
console.log(data);

data = data.split("&");

console.log(doc.getElementById("welcome"));
doc.getElementById("welcome").innerText += " " + data[0].split("=")[1];
for (let i = 1; i < data.length; i++) {
  let elems = data[i].split("=");
  doc.body.innerHTML += "<h1>" + elems[0] + " : " + elems[1] + "</h1>";
}
