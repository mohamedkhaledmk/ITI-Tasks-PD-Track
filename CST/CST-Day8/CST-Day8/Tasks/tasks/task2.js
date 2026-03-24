function params(x, y) {
  if (arguments.length != 2) {
    throw Error("Wrong params");
  } else {
    console.log(x + y);
  }
}

function types(x, y) {
  if (arguments.length != 2) {
    throw Error("Wrong params");
  } else {
    for (let x in arguments) {
      if (isNaN(arguments[x])) {
        console.error("Wrong Type");
        return;
      }
    }
    console.log(x + y);
  }
}
