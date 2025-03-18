
const loginButton = document.querySelector("button");
if (loginButton) {
    loginButton.addEventListener("click", function () {
        const username = document.getElementById("username").value;
        const password = document.getElementById("password").value;

        if (username === "admin" && password === "admin") {
            window.location.href = "table.html";
        } else {
            alert("Invalid username or password. Please try again.");
        }
    });
}


const classForm = document.getElementById("classForm");
if (classForm) {
    classForm.addEventListener("submit", function (event) {
        event.preventDefault();


        const className = document.getElementById("className").value;
        const numPeople = document.getElementById("numPeople").value;
        const description = document.getElementById("description").value;


        const table = document.getElementById("classTable").getElementsByTagName("tbody")[0];
        const newRow = table.insertRow();


        newRow.insertCell(0).textContent = className;
        newRow.insertCell(1).textContent = numPeople;
        newRow.insertCell(2).textContent = description;

        classForm.reset();
    });
}
