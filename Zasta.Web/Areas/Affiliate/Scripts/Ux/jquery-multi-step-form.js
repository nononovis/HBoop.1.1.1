var current_fs,next_fs,previous_fs,left,opacity,scale,animating;$(".next").click(function(){return animating?!1:(animating=!0,current_fs=$(this).parent(),next_fs=$(this).parent().next(),$("#progressbar li").eq($("fieldset").index(next_fs)).addClass("active"),next_fs.show(),void current_fs.animate({opacity:0},{step:function(t){scale=1-.2*(1-t),left=50*t+"%",opacity=1-t,current_fs.css({transform:"scale("+scale+")"}),next_fs.css({left:left,opacity:opacity})},duration:800,complete:function(){current_fs.hide(),animating=!1},easing:"easeInOutBack"}))}),$(".previous").click(function(){return animating?!1:(animating=!0,current_fs=$(this).parent(),previous_fs=$(this).parent().prev(),$("#progressbar li").eq($("fieldset").index(current_fs)).removeClass("active"),previous_fs.show(),void current_fs.animate({opacity:0},{step:function(t){scale=.8+.2*(1-t),left=50*(1-t)+"%",opacity=1-t,current_fs.css({left:left}),previous_fs.css({transform:"scale("+scale+")",opacity:opacity})},duration:800,complete:function(){current_fs.hide(),animating=!1},easing:"easeInOutBack"}))}),$(".submit").click(function(){return!1});