let ans = document.getElementById("Answer");
let cleared = false;
function EnterEqual() {
  ans.value = eval(ans.value);
  cleared = true;
}

function EnterNumber(val) {
  if (cleared) {
    EnterClear();
    cleared = false;
  }
  if (val == 0 && ans.value === "0") return;
  if (val != "." && ans.value[ans.value.length - 1] == "0")
    ans.value = ans.value.substr(0, ans.value.length - 1);

  ans.value += val;
}

function EnterOperator(val) {
  cleared = false;
  let lastVal = ans.value[ans.value.length - 1];
  if (!ans.value) return;
  if (
    lastVal == "*" ||
    lastVal == "/" ||
    lastVal == "=" ||
    lastVal == "+" ||
    lastVal == "-"
  )
    ans.value = ans.value.substr(0, ans.value.length - 1);
  ans.value += val;
}

function EnterClear() {
  ans.value = "";
}
