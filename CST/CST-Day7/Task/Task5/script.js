let screen = document.getElementById("txt1");
screen.readOnly = true;
function displayVal(curr) {
  screen.value += curr.value.trim();
}

function clearFun() {
  screen.value = "";
}

function eraserFun() {
  screen.value = screen.value.substr(0, screen.value.length - 1);
}
