let date = new Date();
let wait5sec = function () {
  while (true) {
    let currDate = new Date();
    if (currDate - date > 5000) break;
  }
};
wait5sec();
