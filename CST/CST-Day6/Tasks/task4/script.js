let doc = window.document;

let imgs = doc.images;
let idx = 0;
let id;
function startInterval() {
  id = setInterval(() => {
    imgs[idx].src = "../TaskResources/marbels/marble1.jpg";
    idx = (idx + 1) % imgs.length;
    imgs[idx].src = "../TaskResources/marbels/marble3.jpg";
  }, 500);
}
startInterval();
let lightUp = function (currImg) {
  currImg.src = "../TaskResources/marbels/marble3.jpg";
  imgs[idx].src = "../TaskResources/marbels/marble1.jpg";
  clearInterval(id);
};

let leave = function (currImg) {
  for (let i = 0; i < imgs.length; i++) {
    if (imgs[i] == currImg) {
      idx = i;
      break;
    }
  }
  currImg.src = "../TaskResources/marbels/marble1.jpg";
  startInterval();
};
