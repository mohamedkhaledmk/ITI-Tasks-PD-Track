let imgs;
let id = null;

let moveRight0 = true;
let moveRight1 = false;
let moveDown2 = true;

let vals;

window.onload = function () {
  let cont = document.getElementById("container");

  cont.innerHTML += '<img src="../../Task Resources/movingPic/icon1.gif">';
  cont.innerHTML += '<img src="../../Task Resources/movingPic/icon2.gif">';
  cont.innerHTML += '<img src="../../Task Resources/movingPic/top.jpg">';

  imgs = document.getElementsByTagName("img");

  vals = document.getElementsByTagName("h6");

  cont.style.position = "relative";
  for (let i = 0; i < imgs.length; i++) {
    imgs[i].style.position = "absolute";
  }

  imgs[0].style.top = "40%";
  imgs[0].style.left = "20px";

  imgs[1].style.top = "40%";
  imgs[1].style.left = "300px";

  imgs[2].style.top = "0px";
  imgs[2].style.left = "45%";

  id = setInterval(moveImages, 50);
};

function moveImages() {
  let x0 = parseInt(imgs[0].style.left);
  imgs[0].style.left = (moveRight0 ? x0 + 10 : x0 - 10) + "px";
  if (x0 > 340) moveRight0 = false;
  if (x0 < 20) moveRight0 = true;

  let x1 = parseInt(imgs[1].style.left);
  imgs[1].style.left = (moveRight1 ? x1 + 10 : x1 - 10) + "px";
  if (x1 > 340) moveRight1 = false;
  if (x1 < 20) moveRight1 = true;

  let y2 = parseInt(imgs[2].style.top);
  imgs[2].style.top = (moveDown2 ? y2 + 10 : y2 - 10) + "px";
  if (y2 > 360) moveDown2 = false;
  if (y2 < 20) moveDown2 = true;

  vals[0].innerHTML = "Position of 1:  " + x0;
  vals[1].innerHTML = "Position of 2:  " + x1;
  vals[2].innerHTML = "Position of 3:  " + y2;
}

function stop() {
  if (id) {
    clearInterval(id);
    id = null;
  } else {
    id = setInterval(moveImages, 50);
  }
}

function clearr() {
  clearInterval(id);
  id = null;
}
