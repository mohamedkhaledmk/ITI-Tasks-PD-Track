let child, id;
function openChild() {
  child = window.open("child.html", "", { popup: true });
  child.resizeTo(100, 100);
  child.moveTo(0, 0);
  let x = 0,
    down = true;
  id = setInterval(function () {
    if (down) {
      child.moveBy(50, 25);
      x += 50;
    } else {
      child.moveBy(-50, -25);
      x -= 50;
    }
    if (x == 1250) down = false;
    else if (x == 0) down = true;
  }, 100);
}

function stopChild(myChild = child, myId = id) {
  clearInterval(myId);
  myChild.focus();
}

function openScroll() {
  if (!child) child = open("child.html", "", "width=500,height=600");
  else child.focus();
  child.resizeTo(400, 400);
  child.moveTo(600, 100);
  let down = true;
  id = setInterval(function () {
    if (down) {
      child.scrollBy(0, 15);
    } else {
      child.scrollBy(0, -15);
    }
    if (child.scrollY == 0) {
      down = true;
    } else if (child.scrollY > 400) down = false;
  }, 100);
}
