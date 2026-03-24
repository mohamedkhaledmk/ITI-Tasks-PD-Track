let container = document.getElementById("container");

for (let i = 0; i < 12; i++) {
  if (i % 4 == 0) container.innerHTML += "<br>";
  container.innerHTML +=
    '<img src="../TaskResources/memory Game/moon.gif" onclick=clicked(this) />';
}
let imageStr = "../TaskResources/memory Game/";
let imgs = document.images;
console.log(imgs);
let img1, img2;
let idx = 0;
function clicked(currImg) {
  let i = 0;
  for (; i < imgs.length; i++) {
    if (imgs[i] == currImg) {
      idx = i;
      break;
    }
  }
  if (!img1) {
    img1 = currImg;
    img1.src = imageStr + ((idx % 6) + 1) + ".gif";
  } else {
    img2 = currImg;
    img2.src = imageStr + ((idx % 6) + 1) + ".gif";
    setTimeout(() => {
      if (img1.src == img2.src) {
        img1 = undefined;
        img2 = undefined;
      } else {
        img1.src = imageStr + "moon.gif";
        img2.src = imageStr + "moon.gif";
        img1 = undefined;
        img2 = undefined;
      }
    }, 1000);
  }
}
