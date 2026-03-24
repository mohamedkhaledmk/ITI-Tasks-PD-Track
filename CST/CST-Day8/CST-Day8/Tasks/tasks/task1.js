function getCookie(cookieName) {
  let myObj = getAllCookies();
  return myObj[cookieName];
}
function setCookie(cookieName, cookieVal) {
  document.cookie = cookieName + "=" + cookieVal;
}

function getAllCookies() {
  let cookies = {};
  let arr = document.cookie.split("; ");
  for (let x in arr) {
    cookies[arr[x].split("=")[0]] = arr[x].split("=")[1];
  }
  return cookies;
}

function deleteCookie(cookieName) {
  document.cookie = cookieName + "=" + "";
}
function hasCookie(cookieName) {
  return Boolean(getCookie(cookieName));
}

function register() {
  let btns = document.getElementsByName("radio");
  let gender;
  if (btns[0].checked) gender = 1;
  else gender = 2;
  setCookie("gender", gender);
  //   let inps = document.getElementsByTagName("input");
  let name = document.getElementById("name").value;
  let age = document.getElementById("age").value;
  if (getCookie("name") == name && getCookie("age") == age)
    setCookie("count", Number(getCookie("count") || 0) + 1);
  else {
    setCookie("name", name);
    setCookie("age", age);
    setCookie("gender", gender);
    setCookie("count", 1);
  }
  let sel = document.getElementsByTagName("select");
  setCookie("color", sel[0].value);

  window.location.assign("child.html");
}
