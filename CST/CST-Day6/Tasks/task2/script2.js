// let id = setTimeout(function () {
//   let win = window.open("child.html");
//   let inps = document.getElementsByTagName("input");
//   win.location.search += "?";
//   for (let i in inps) {
//     win.location.search += inps[i].name + "=" + inps[i].value + "&";
//   }
// }, 5000);
let id = setTimeout(function () {
  let inps = document.getElementsByTagName("input");
  let queryParts = [];

  for (let i = 0; i < inps.length; i++) {
    if (inps[i].name) {
      let pair = inps[i].name + "=" + inps[i].value;
      queryParts.push(pair);
    }
  }

  let queryString = queryParts.join("&");

  let win = window.open("child.html?" + queryString, "_self");
}, 5000);
function clear() {
  clearTimeout(id);
}
