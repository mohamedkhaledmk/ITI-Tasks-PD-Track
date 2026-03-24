let cont;
let i = 1;

window.onload = function () {
  cont = document.getElementById("container");
  let name = getCookie("name");
  let age = getCookie("age");
  let gender = getCookie("gender");
  let count = getCookie("count");
  let color = getCookie("color");
  cont.innerHTML +=
    '<h1>Welcome  <span style="color:' +
    color +
    '">' +
    name +
    "</span> , you have visitied this site " +
    count +
    " times</h1>>";
  cont.innerHTML += '<img src="../Task Resources/cookies/' + gender + '.jpg">';
};
