﻿$(function () {
    $('#parametre').parsley();
    document.getElementById("uploadBtn").onchange = function () {
        document.getElementById("uploadFile").value = this.value;
    };
});