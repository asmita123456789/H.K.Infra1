document.addEventListener("DOMContentLoaded", function () {
    const dropdownToggle = document.querySelector(".dropdown-toggle");
    const dropdownMenu = document.querySelector(".dropdown-menu");

    dropdownToggle.addEventListener("click", function (event) {
        event.preventDefault();
        dropdownMenu.classList.toggle("show");
    });

    // Close dropdown when clicking outside
    document.addEventListener("click", function (event) {
        if (!dropdownToggle.contains(event.target) && !dropdownMenu.contains(event.target)) {
            dropdownMenu.classList.remove("show");
        }
    });

    // Smooth Scroll
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener("click", function (event) {
            event.preventDefault();
            const targetSection = document.querySelector(this.getAttribute("href"));
            if (targetSection) {
                window.scrollTo({
                    top: targetSection.offsetTop - 50,
                    behavior: "smooth"
                });
            }
        });
    });
});

document.addEventListener("DOMContentLoaded", function () {
    const video = document.querySelector(".header-video");
    const muteButton = document.createElement("button");

    muteButton.textContent = "Mute/Unmute";
    muteButton.style.position = "absolute";
    muteButton.style.top = "20px";
    muteButton.style.right = "20px";
    muteButton.style.backgroundColor = "#fff";
    muteButton.style.border = "none";
    muteButton.style.padding = "10px";
    muteButton.style.cursor = "pointer";

    document.body.appendChild(muteButton);

    muteButton.addEventListener("click", function () {
        video.muted = !video.muted;
    });
});

document.addEventListener("DOMContentLoaded", function () {
    document.querySelectorAll("img").forEach(img => {
        img.onerror = function () {
            this.src = "assets/images/placeholder.jpg"; // Set a default image
        };
    });
});

document.addEventListener("DOMContentLoaded", function () {
    const contactForm = document.getElementById("contactForm");

    contactForm.addEventListener("submit", function (event) {
        let isValid = true;

        const name = document.getElementById("name");
        const email = document.getElementById("email");
        const subject = document.getElementById("subject");

        if (name.value.trim() === "") {
            document.getElementById("nameError").style.display = "block";
            isValid = false;
        } else {
            document.getElementById("nameError").style.display = "none";
        }

        const emailPattern = /^[^ ]+@[^ ]+\.[a-z]{2,3}$/;
        if (!email.value.match(emailPattern)) {
            document.getElementById("emailError").style.display = "block";
            isValid = false;
        } else {
            document.getElementById("emailError").style.display = "none";
        }

        if (subject.value.trim() === "") {
            document.getElementById("subjectError").style.display = "block";
            isValid = false;
        } else {
            document.getElementById("subjectError").style.display = "none";
        }

        if (!isValid) {
            event.preventDefault();
        }
    });
});

document.addEventListener("DOMContentLoaded", function () {
    let index = 0;
    const slides = document.querySelectorAll(".carousel-item");
    function showSlide() {
        slides.forEach(slide => slide.classList.remove("active"));
        slides[index].classList.add("active");
        index = (index + 1) % slides.length;
    }
    setInterval(showSlide, 3000);
});
