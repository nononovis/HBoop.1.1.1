
jQuery(window).load(function () { // makes sure the whole site is loaded
    jQuery("#status").fadeOut(); // will first fade out the loading animation
    jQuery("#preloader").delay(350).fadeOut("slow"); // will fade out the white DIV that covers the website.
})

$(document).ready(function () {
    $('.popup-with-zoom-anim').magnificPopup({
        type: 'inline',
        fixedContentPos: false,
        fixedBgPos: true,
        overflowY: 'auto',
        closeBtnInside: true,
        preloader: false,
        midClick: true,
        removalDelay: 300,
        mainClass: 'my-mfp-zoom-in'
    });
    $(".supprimer").css({ "pointer-events": "none", "opacity": "0.7" });
    $('.check').on('click', function () {
        $(".supprimer").css({ "pointer-events": "initial", "opacity": "1" });
    });
});

