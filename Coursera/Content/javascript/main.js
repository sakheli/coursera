$(document).ready(function () {
    $(window).scroll(function () {
        var scroll = $(window).scrollTop();
        if (scroll > 50) {
            $("#nav").addClass("animated_nav");
            $('.logo').addClass("shrink_logo");
            $('.navigation__search').addClass("shrink_search");
        }
        else {
            $("nav").removeClass("animated_nav");   
            $('.logo').removeClass("shrink_logo");
            $('.navigation__search').removeClass("shrink_search");

        }

    });

    $(".search_icon").click(function () {
        $(".search_input").animate({
            top: '55px',
            opacity: '1'
        });
    });
});


