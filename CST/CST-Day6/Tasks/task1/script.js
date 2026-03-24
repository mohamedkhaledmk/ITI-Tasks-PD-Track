let win = open("child.html", "_blank", "width=500,height=500");
let str = "Typing Message";
let idx = 0;

win.onload = function () {
  console.log(win.navigator.userAgent);
  if (!win.navigator.userAgent.includes("Chrome")) {
    win.document.body.innerHTML += `<h2 style="color:red"}> USE CHROME !</h2>`;
  }
  let header = win.document.getElementById("header");
  setInterval(function () {
    if (idx < str.length) header.innerText += str[idx++];
    else win.close();
  }, 500);
};
