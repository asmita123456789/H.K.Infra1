 /* General Styles */
 body {
    font-family: 'Poppins', sans-serif;
    margin: 0;
    padding: 0;
    background: #0a0a0a;
    color: #fff;
    overflow-x: hidden;
  }
  
  /* Header Section */
  .header-section {
    position: relative;
    width: 100%;
    height: 100vh;
    overflow: hidden;
  }
  
  .header-video {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    object-fit: cover;
    z-index: -1;
  }
  
  .header-overlay {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.6);
    display: flex;
    align-items: center;
    justify-content: center;
    text-align: center;
    color: #fff;
  }
  
  .header-content .title {
    font-size: 3rem;
    font-weight: bold;
    text-transform: uppercase;
  }
  
  .header-content .subtitle {
    font-size: 1.5rem;
    margin-top: 10px;
  }
  
  .btn-primary {
    display: inline-block;
    margin-top: 20px;
    padding: 10px 20px;
    background: #ff4500;
    color: #fff;
    font-size: 1.2rem;
    text-decoration: none;
    border-radius: 5px;
    transition: all 0.3s ease-in-out;
  }
  
  .btn-primary:hover {
    background: #ff6347;
    transform: scale(1.1);
  }
  
  /* Navbar Section */
  .navbar {
    position: fixed;
    top: 0;
    width: 100%;
    background: rgba(0, 0, 0, 0.8);
    padding: 15px 20px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    transition: background 0.3s;
    z-index: 1000;
  }
  
  .navbar.scrolled {
    background: rgba(0, 0, 0, 0.95);
  }
  
  .nav-list {
    list-style: none;
    display: flex;
    gap: 20px;
  }
  
  .nav-link {
    color: #fff;
    text-decoration: none;
    font-size: 1.1rem;
    transition: color 0.3s;
  }
  
  .nav-link:hover {
    color: #ff4500;
  }
  
  .dropdown-menu {
    display: none;
    position: absolute;
    background: rgba(0, 0, 0, 0.9);
    list-style: none;
    padding: 10px;
    border-radius: 5px;
  }
  
  .dropdown:hover .dropdown-menu {
    display: block;
  }
  
  .search-form {
    display: flex;
    align-items: center;
  }
  
  .search-input {
    padding: 8px;
    border: none;
    border-radius: 5px;
    margin-right: 5px;
  }
  
  .btn-search {
    padding: 8px 15px;
    border: none;
    background: #ff4500;
    color: #fff;
    border-radius: 5px;
    cursor: pointer;
    transition: background 0.3s;
  }
  
  .btn-search:hover {
    background: #ff6347;
  }
  
  
  /* Header Section */
  .header-section {
    position: relative;
    width: 100%;
    height: 100vh;
    overflow: hidden;
    text-align: center;
  }
  .header-overlay {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.5);
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
  }
  .header-video {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    object-fit: cover;
    z-index: -1;
  }
  .title {
    font-size: 4rem;
    font-weight: 700;
    animation: fadeInDown 1s ease-in-out;
  }
  .subtitle {
    font-size: 1.5rem;
    opacity: 0.8;
    animation: fadeInUp 1s ease-in-out;
  }
  .btn-primary {
    padding: 15px 30px;
    background: #ff5733;
    border: none;
    border-radius: 50px;
    color: #fff;
    font-size: 1.2rem;
    cursor: pointer;
    transition: all 0.3s ease;
  }
  .btn-primary:hover {
    background: #ff2a00;
    transform: scale(1.1);
  }
  
  /* Navigation */
  .navbar {
    position: fixed;
    width: 100%;
    background: rgba(0, 0, 0, 0.8);
    padding: 10px 0;
    /*backdrop-filter: blur(5px); */
    display: flex;
    align-items: center;
    justify-content: space-between;
    z-index: 1000;
  }
  .nav-list {
    list-style: none;
    display: flex;
    gap: 20px;
  }
  .nav-link {
    text-decoration: none;
    color: white;
    font-size: 1.1rem;
    transition: color 0.3s;
  }
  .nav-link:hover {
    color: #ff5733;
  }
  
  /* Section Layout */
  .section {
    padding: 100px 50px;
    text-align: center;
  }
  .section-title {
    font-size: 3rem;
    margin-bottom: 20px;
    color: #ff5733;
  }
  
  /* Services Cards */
  .card-container {
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
    gap: 20px;
  }
  .card {
    background: #1a1a1a;
    padding: 20px;
    border-radius: 15px;
    transition: transform 0.3s;
    box-shadow: 0px 5px 15px rgba(255, 87, 51, 0.3);
  }
  .card:hover {
    transform: translateY(-10px);
  }
  .card img {
    width: 100%;
    border-radius: 10px;
  }
  
  /* Achievements Section */
  .carousel-image {
    width: 80%;
    border-radius: 15px;
    box-shadow: 0px 5px 15px rgba(255, 87, 51, 0.3);
  }
  
  /* Contact Form */
  .contact-container {
    background: #150a35;
    padding: 50px;
    border-radius: 20px;
    box-shadow: 0px 5px 15px rgba(255, 87, 51, 0.3);
  }
  .contact-form input, 
  .contact-form textarea {
    width: 100%;
    padding: 10px;
    margin: 10px 0;
    border: none;
    border-radius: 10px;
    background: #333;
    color: white;
  }
  button {
    background: #ff5733;
    padding: 15px;
    border: none;
    border-radius: 50px;
    cursor: pointer;
    transition: 0.3s;
  }
  button:hover {
    background: #ff2a00;
    transform: scale(1.05);
  }
  
  /* Social Media Section Styling */
  .social-section {
    background: linear-gradient(135deg, #100448, #2569a9);
    padding: 50px 0;
    text-align: center;
    color: white;
  }
  
  .social-section .section-title {
    font-size: 2rem;
    margin-bottom: 20px;
    font-weight: bold;
    text-transform: uppercase;
  }
  
  .social-links {
    display: flex;
    justify-content: center;
    gap: 20px;
    margin-top: 20px;
  }
  
  .social-btn {
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 10px;
    font-size: 1.2rem;
    color: white;
    text-decoration: none;
    padding: 10px 20px;
    border-radius: 50px;
    transition: transform 0.3s ease, background 0.3s ease;
  }
  
  .social-btn i {
    font-size: 1.5rem;
  }
  
  .youtube {
    background: #FF0000;
  }
  
  .linkedin {
    background: #0077B5;
  }
  
  .instagram {
    background: #E4405F;
  }
  
  .social-btn:hover {
    transform: scale(1.1);
    opacity: 0.9;
  }
  
  /* About Section Styles */
  .about-section {
    background-color: #050404; /* Light gray background */
    padding: 60px 0; /* Top and bottom padding */
  }
  
  .section-title {
    font-size: 2.5rem;
    color: #d22d2d;
    font-weight: bold;
    text-align: center;
    margin-bottom: 30px;
    border: #007bff;
  }
  
  .about-text {
    font-size: 1rem;
    line-height: 1.9;
    color: #ffffff;
    margin-bottom: 20px;
  }
  
  .profile-img {
    width: 400px;
    height: 400px;
    border-radius: 50%;
    object-fit: cover;
    box-shadow: 0 4px 15px rgba(62, 157, 83, 0.1); /* Image shadow */
  }
  
  .text-primary {
    color: #cf0707 !important;
  }
  
  .collapsed-text {
    font-size: 1rem;
    color: #fcfcfc;
    line-height: 1.9;
  }
  
  .btn-outline-primary {
    font-size: 1rem;
    padding: 10px 20px;
    border-radius: 30px;
    transition: all 0.3s ease;
    border: 2px solid #f25641;
    color: #b94f41;
    text-decoration: none;
  }
  
  .btn-outline-primary:hover {
    background-color: #ff4c4f;
    color: #fff;
  }
  
  .mb-4 {
    margin-bottom: 20px;
  }
  
  .mt-4 {
    margin-top: 20px;
  }
  
  .shadow-lg {
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
  }
  
  @media (max-width: 767px) {
    .about-section {
        padding: 40px 0;
    }
    .profile-img {
        width: 150px;
        height: 150px;
    }
    .section-title {
        font-size: 2rem;
    }
  }
  
  
  /* Footer */
  .footer-section {
    background: #111;
    padding: 20px;
    text-align: center;
  }
  .footer-btn {
    text-decoration: none;
    color: white;
    padding: 10px;
    transition: color 0.3s;
  }
  .footer-btn:hover {
    color: #ff5733;
  }
  
  /* Animations */
  @keyframes fadeInDown {
    from {
        opacity: 0;
        transform: translateY(-50px);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
  }
  
  @keyframes fadeInUp {
    from {
        opacity: 0;
        transform: translateY(50px);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
  }
  