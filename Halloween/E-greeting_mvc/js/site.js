$(document).ready(function () {


   
    var length = 0; 

    $('input,textarea').keyup(function () {
        var maxLength = $(this).attr("maxlength");
        var length = $(this).val().length;
        var length = maxLength - length;
        $(this).siblings(".countdown").text(length +" characters left");
    });

    $('input,textarea').change(function () {
        $(this).siblings(".countdown").text("");
    })

    $('#message').keyup(function () {
        var maxLength = $(this).attr("maxlength");
        var length = $(this).val().length;
        var length = maxLength - length;
        $(this).closest("#countdown").text(length);
    });

   
  
    $('#subject').keyup(function () {
        var maxLength = $(this).attr("maxlength");
        var length = $(this).val().length;
        var length = maxLength - length;
        $('#countdown_subject').text(length);
    });
}); 