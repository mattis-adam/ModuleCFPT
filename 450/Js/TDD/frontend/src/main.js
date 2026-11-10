import { Fibonacci } from "./fibonacci.js";
let fibonacci = new Fibonacci();
let output = "<ul>";
for (let i = 0; i <= 16; i++) {
    output += `<li>F(${i})=${fibonacci.GetValue(i)}</li>`
}
output += "</ul>";
document.querySelector('#app').innerHTML = output;
