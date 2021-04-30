$(document).ready(function () {
    $("#add_two_numbers").click(function () {
        if (document.getElementById('one' || 'two').value == "") {
            $("#result").text("Pls:Enter the values");
            $("#result").css("color", "red");
        }
        else
        { 
        var one = parseInt($("#one").val());
        var two = parseInt($("#two").val());
            $("#result").text(one + two);
            $("#result").css("color", "forestgreen");
            $("#total").text(one + two);
        }
    });
});
