let img = document.getElementById("image");
let idx = 1;
function next() {
  if (idx < 6) img.src = "../TaskResources/SlideShow/" + ++idx + ".jpg";
}
function previous() {
  if (idx > 1) img.src = "../TaskResources/SlideShow/" + --idx + ".jpg";
}
let int;
let id = 1;
function slideshow() {
  int = setInterval(function () {
    img.src = "../TaskResources/SlideShow/" + ((id++ % 6) + 1) + ".jpg";
  }, 2000);
}

function stop() {
  clearInterval(int);
}
