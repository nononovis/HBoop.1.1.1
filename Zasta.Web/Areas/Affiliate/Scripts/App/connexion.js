$(function(){$("input,textarea").jqBootstrapValidation({preventSubmit:true,submitError:function(e,t,n){},submitSuccess:function(e,t){t.preventDefault();var n=$("input#login").val();var r=$("input#email").val();var i=$("input#password").val();var s=name;$.ajax({url:"../../FrontOffice/index.html",type:"POST",data:{login:n,email:r,password:i},cache:false,success:function(){$("#success").html("<div class='alert alert-success'>");$("#success > .alert-success").html("<button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;").append("</button>");$("#success > .alert-success").append("Votre message a été envoyé. ");$("#success > .alert-success").append("</div>");$("#contactForm").trigger("reset")},error:function(){$("#success").html("<div class='alert alert-danger'>");$("#success > .alert-danger").html("<button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;").append("</button>");$("#success > .alert-danger").append("Désolé,  il s’emble qu’il y a un problème s’il vous plaît, essayer encore!");$("#success > .alert-danger").append("</div>");$("#contactForm").trigger("reset")}})},filter:function(){return $(this).is(":visible")}});$('a[data-toggle="tab"]').click(function(e){e.preventDefault();$(this).tab("show")})});$("#name").focus(function(){$("#success").html("")});$(".Switch").click(function(){$(this).toggleClass("On").toggleClass("Off")})