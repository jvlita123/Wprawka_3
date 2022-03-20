// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let number = document.getElementById("number").value;
let txt = "";


if (number % 3 == 0 && number % 5 == 0) {
    text = "fizzBuzz";
}
else if (number % 5 == 0) {
    text = "Buzz";
}
else if (number % 3 == 0) {
    text = "Fizz";
}
else {
    text = "Liczba: <podana przez użytkownika liczba> nie spełnia kryteriów FizzBuzz";
}
document.getElementById("txt").innerHTML = text;
