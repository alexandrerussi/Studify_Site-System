
$(window).scroll(function () {
    $('.logoHome').each(function () {
        var imagePos = $(this).offset().top;

        var topOfWindow = $(window).scrollTop();
        if (imagePos < topOfWindow + 400) {
            $(this).addClass("slideUp");
        }
    });
});


$(window).scroll(function () {
    $('.effectSlideUp').each(function () {
        var imagePos = $(this).offset().top;

        var topOfWindow = $(window).scrollTop();
        if (imagePos < topOfWindow + 550) {
            $(this).addClass("slideUp");
        }
    });
});

$(window).scroll(function () {
    $('.effectExpandUp').each(function () {
        var imagePos = $(this).offset().top;

        var topOfWindow = $(window).scrollTop();
        if (imagePos < topOfWindow + 550) {
            $(this).addClass("expandUp");
        }
    });
});

$(window).scroll(function () {
    $('.effectSlideRight').each(function () {
        var imagePos = $(this).offset().top;

        var topOfWindow = $(window).scrollTop();
        if (imagePos < topOfWindow + 550) {
            $(this).addClass("slideRight");
        }
    });
});

$(window).scroll(function () {
    $('.effectSlideExpandUp').each(function () {
        var imagePos = $(this).offset().top;

        var topOfWindow = $(window).scrollTop();
        if (imagePos < topOfWindow + 550) {
            $(this).addClass("slideExpandUp");
        }
    });
});