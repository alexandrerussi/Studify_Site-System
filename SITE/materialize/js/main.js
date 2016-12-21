$(document).ready(function () {
    $(".button-collapse").sideNav();
});

$(document).ready(function () {
    $('select').material_select();
});

$(document).ready(function () {
    $('.parallax').parallax();
});

$(document).ready(function () {
    $('ul.tabs').tabs('select_tab', 'tab_id');
});

$(document).ready(function () {
    $('.collapsible').collapsible({
        accordion: false // A setting that changes the collapsible behavior to expandable instead of the default accordion style
    });
});

$(document).ready(function () {
    // the "href" attribute of .modal-trigger must specify the modal ID that wants to be triggered
    $('.modal-trigger').leanModal();
});

$('.datepicker').pickadate({
    selectMonths: true, // Creates a dropdown to control month
    selectYears: 200 // Creates a dropdown of 15 years to control year
});

$(document).ready(function () {

    if ($(window).width() > 1900) {
        var showChar = 500;
    }
    else {
        if ($(window).width() > 1740) {
            var showChar = 490;
        }
        else {
            if ($(window).width() > 1500) {
                var showChar = 420;
            }
            else {
                if ($(window).width() > 1300) {
                    var showChar = 360;
                }
                else {
                    if ($(window).width() > 1100) {
                        var showChar = 330;
                    }
                    else {
                        if ($(window).width() > 992) {
                            var showChar = 310;
                        }
                        else {
                            var showChar = 600;
                        }
                    }

                }
            }

        }
    }


    // Configure/customize these variables.
    var ellipsestext = "...";
    var moretext = "Mostrar mais >";
    var lesstext = "Diminuir";


    $('.readToggle1').each(function () {
        var content = $(this).html();

        if (content.length > showChar) {

            var c = content.substr(0, showChar);

            var html = c + '<span class="moreellipses">' + ellipsestext + '&nbsp;</span>';

            $(this).html(html);
        }

    });


    if ($(window).width() > 1840) {
        var showChar2 = 455;
    }
    else {
        if ($(window).width() > 1700) {
            var showChar2 = 420;
        }
        else {
            if ($(window).width() > 1500) {
                var showChar2 = 350;
            }
            else {
                if ($(window).width() > 1400) {
                    var showChar2 = 320;
                }
                else {
                    if ($(window).width() > 1300) {
                        var showChar2 = 300;
                    }
                    else {
                        if ($(window).width() > 1200) {
                            var showChar2 = 285;
                        }
                        else {
                            if ($(window).width() > 1100) {
                                var showChar2 = 260;
                            }
                            else {
                                if ($(window).width() > 1010) {
                                    var showChar2 = 200;
                                }
                                else {
                                    if ($(window).width() > 992) {
                                        var showChar2 = 180;
                                    }
                                    else {
                                        var showChar2 = 500;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }




    // Configure/customize these variables.
    var ellipsestext = "...";
    var moretext = "Mostrar mais >";
    var lesstext = "Diminuir";


    $('.readToggle2').each(function () {
        var content = $(this).html();

        if (content.length > showChar) {

            var c = content.substr(0, showChar2);

            var html = c + '<span class="moreellipses">' + ellipsestext + '&nbsp;</span>';

            $(this).html(html);
        }

    });

});


$(window).scroll(function () {
    var windowpos2 = $(window).height();
    var scrollpos2 = $(window).scrollTop();
    if (scrollpos2 > windowpos2) {
        $('#sticky2').addClass('stick');
    }
    else {
        $('#sticky2').removeClass('stick');
    }
});
