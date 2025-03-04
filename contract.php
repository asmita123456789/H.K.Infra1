<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    include 'config.php';

    $name = $_POST['name'];
    $email = $_POST['email'];
    $subject = $_POST['subject'];

    $sql = "INSERT INTO contacts (name, email, subject) VALUES ('$name', '$email', '$subject')";

    if ($conn->query($sql) === TRUE) {
        echo "<p>Message successfully sent!</p>";
    } else {
        echo "<p>Error: " . $sql . "<br>" . $conn->error . "</p>";
    }

    $conn->close();
}
?>

<div class="contact-container">
    <div class="contact-form">
        <h1>Contact Us</h1>
        <form action="contact.php" method="POST">
            <input type="text" name="name" placeholder="Your Name" required>
            <input type="email" name="email" placeholder="Your Email" required>
            <input type="text" name="subject" placeholder="Subject" required>
            <button type="submit">Send Message</button>
        </form>
    </div>
</div>
