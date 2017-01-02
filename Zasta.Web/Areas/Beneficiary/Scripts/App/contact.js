 $(document).ready(function() {
    $("#wave-form").parsley();
    $("#wave-form").bind("submit", function(e) {
        e.preventDefault();
        var nom = $("#nom").val(),
            email = $("#email").val(),
            message = $("#message").val(),
            SecondName = $("#SecondName").val();
        "" != $("#email").val() && "" != $("#nom").val() && "" != $("#message").val() && 
		$.ajax({
            type: "POST",
            url: "../../Mail/mail.asp",
            data: {
                nom: nom,
                email: email,
                message: message,
                SecondName: SecondName
            },
            success: function() {
                $(".alertMessage").css("display", "block"), $("#nom").val(""), $("#email").val(""), $("#message").val(""), $("#SecondName").val("")
            },
            error: function() {
                $(".erreur").css("display", "block"), $("#nom").val(""), $("#email").val(""), $("#message").val(""), $("#SecondName").val("")
            }
        })
    })
});