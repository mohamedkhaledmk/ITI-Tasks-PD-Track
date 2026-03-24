let size = prompt("Please Enter size of array:");
let arr = [size];
for (let i = 0; i < size; i++) {
  arr[i] = prompt("Please enter element number " + (i + 1) + "in the array");
}
arr.sort(function (a, b) {
  return a - b;
});

for (let i = 0; i < size; i++) {
  document.write(arr[i] + " ");
}
