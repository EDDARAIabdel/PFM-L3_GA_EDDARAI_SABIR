$(document).ready(function () {
    
    // Nav slide Toggle
    $('i.icon').click(function () {
        $('.nav-list').slideToggle();
    });
    
    //Stickey navbar
    $(window).scroll(function () {
        var sc = $(this).scrollTop();
        if (sc > 70) {
            $('header').addClass('sticky');
        } else {
            $('header').removeClass('sticky');
        }
    });
});

function countdown() {
    var now = new Date();
    var eventDate = new Date(2020, 07, 15);
    
    var currentTime = now.getTime();
    var eventTime= eventDate.getTime();
    
    var remTime = eventTime - currentTime;
    
    var s = math.floor(remTime / 1000);
    var m = math.floor(s / 60);
    var h = math.floor(m / 60);
    var d = math.floor(h / 24);
    
    h %= 24;
    m %= 60;
    s %= 60;
    
    h = (h < 10) ? "0" + h : h;
    m = (m < 10) ? "0" + m : m;
    s = (s < 10) ? "0" + s : s;
    
    document.getElementById("days").textContent = d;
    document.getElementById("days").innerText = d;
    
    document.getElementById("hours").textContent = h;
    document.getElementById("minutes").textContent = m;
    document.getElementById("seconds").textContent = s;
    
    setTimeout(countdown, 1000);
}