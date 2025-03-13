function updateClock() {
    let now = new Date();
    let timeString = now.toLocaleTimeString();
    document.getElementById("clock").textContent = timeString;
}


setInterval(updateClock, 1000);
updateClock();

document.addEventListener("keydown", function(event) {
    if (event.key.toLowerCase() === "h") {
        let forms = document.querySelectorAll("form");
        forms.forEach(form => {
            form.classList.toggle("hidden");
        });
    }
});
