$(document).ready(function () {
    $('#deja-inscrit').parsley();
    $('#pas-encore-inscrit').parsley();
    $('#carte-bancaire').parsley();
    $('#parametre').parsley();
    document.getElementById("uploadBtn").onchange = function () {
        document.getElementById("uploadFile").value = this.value;
    };
});