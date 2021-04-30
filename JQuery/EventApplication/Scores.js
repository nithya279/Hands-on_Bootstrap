$(document).ready(() => {
    $("input").keyup(() => {
        calculateSum();
    });
});

function calculateSum() {
    let sum = 0;
    $("input").each(function () {
        if (!isNaN(this.value) && (this.value) !== "") {
            sum += parseFloat(this.value);
        }
    });
    $("#sumValue").text(Number(sum).toFixed(2));
}
