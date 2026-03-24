let form = document.getElementsByTagName("form")[0];

let data = false;

setTimeout(function () {
  for (let i = 0; i < form.length; i++) {
    if (form[i].value) data = true;
  }
  if (!data) {
    alert("Please Enter data!");
  }
}, 5000);

let btn = document.getElementsByTagName("button")[1];

let custEvent = new Event("alertEvent");

btn.addEventListener("alertEvent", function () {
  alert("Custom Event fired!!!!");
  console.log("custom Event");
});

btn.addEventListener("click", function () {
  console.log("clicked!");
  this.dispatchEvent(custEvent);
});
