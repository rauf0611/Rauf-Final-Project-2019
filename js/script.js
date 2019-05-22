// preloader
$(".navbar-toggler-icon").click(function () {
    $(".header-text").toggleClass('d-none');


})
/* peloader */





// window.onscroll = function() {scrollFunction()};

// function scrollFunction() {
//   if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
//     document.getElementById("myBtn").style.display = "block";
//   } else {
//     document.getElementById("myBtn").style.display = "none";
//   }
// }

// When the user clicks on the button, scroll to the top of the document
// function topFunction() {
//   document.body.scrollTop = 0;
//   document.documentElement.scrollTop = 0;
// }

// owl carousel

if($(".owl-carousel").length > 0){
    $('.owl-carousel').owlCarousel({
        loop: true,
        margin: 10,
        responsiveClass: true,
        responsive: {
            0: {
                items: 1,
                nav: false
            },
            600: {
                items: 1,
                nav: false
            },
            1000: {
                items: 1,
                nav: false,
                loop: true
            }
        }
    })
}

$(document).on('click', '.number-spinner button', function () {
    var btn = $(this),
        oldValue = btn.closest('.number-spinner').find('input').val().trim(),
        newVal = 0;

    if (btn.attr('data-dir') == 'up') {
        newVal = parseInt(oldValue) + 1;
    } else {
        if (oldValue > 1) {
            newVal = parseInt(oldValue) - 1;
        } else {
            newVal = 1;
        }
    }
    btn.closest('.number-spinner').find('input').val(newVal);
});

// description part

// scroll to top
$(document).ready(function () {
    $(window).scroll(function () {
        if ($(this).scrollTop() > 300) {
           
            $('#myBtn').fadeIn();
        } else {
            $('#myBtn').fadeOut();
        }

    });
    $('#myBtn').click(function () {
        $('body,html').animate({
            scrollTop: 0
        }, 1000);
        return false;
    });


});
// scroll to top

// var basket = document.querySelector('.nav-item .basket');

// basket.addEventListener('click',function(){
//     document.location.href = "Basket.html";

// })
