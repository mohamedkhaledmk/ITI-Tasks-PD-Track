let down = document.getElementById("down");
let press = document.getElementById("press");

document.addEventListener("keydown", function () {
  down.innerText += "  " + event.key;
});

document.addEventListener("keypress", function () {
  press.innerText += "  " + event.key;
});

document.addEventListener("keydown", function () {
  if (event.ctrlKey && event.key == "s") {
    event.preventDefault();
    document.body.innerHTML += `<h1 style="color:red">Dont Save Please!</h1>`;
  }
});
