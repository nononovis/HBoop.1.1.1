 $(document).ready(function() {
    $("#reservation").parsley();
    $("#reservation").bind("submit", function(e) {
        e.preventDefault();
        var dateR = $("#dateR").val(),
            heureR = $("#heureR").val(),
            prestation = $("#prestation").val(),
            SecondName = $("#SecondNam").val();
        "" != $("#heureR").val() && "" != $("#dateR").val() && "" != $("#prestation").val() && 
		$.ajax({
            type: "POST",
            url: "",
            data: {
                dateR: dateR,
                heureR: heureR,
                prestation: prestation,
                SecondName: SecondName
            },
            success: function() {
                $(".alertMessage").css("display", "block"), $("#dateR").val(""), $("#heureR").val(""), $("#prestation").val(""), $("#SecondName").val("")
            },
            error: function() {
                $(".erreur").css("display", "block"), $("#dateR").val(""), $("#heureR").val(""), $("#prestation").val(""), $("#SecondName").val("")
            }
        })
    })
});