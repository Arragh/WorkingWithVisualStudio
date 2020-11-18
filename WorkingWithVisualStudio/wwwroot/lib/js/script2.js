document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "This is the element from the script2.js file";
    document.querySelector("body").appendChild(element);
} );