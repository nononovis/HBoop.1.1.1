$(document).ready(function(){$("body").append('<div class="ma5-mobile-menu-container"/>'),$(".ma5-menu-mobile").find("ul").clone().addClass("ma5-menu-panel").appendTo(".ma5-mobile-menu-container").find("ul").remove(),$(".ma5-toggle-menu").on("click touch",function(){$("html").toggleClass("ma5-menu-active")}),$(".ma5-btn-enter").on("click touch",function(){$(".ma5-menu-panel").removeClass("ma5-active-ul"),$(".ma5-menu-panel li").removeClass("ma5-active-li");var a=$(this).parent().attr("class").replace("li","ul"),e=$(this).parent().attr("class").replace("li","ul").split("-"),e=(e.splice(-1,1),e.join("-"));$(".ma5-menu-panel").removeClass("ma5-active-leave ma5-parent-leave ma5-active-enter ma5-parent-enter"),$(".ma5-menu-panel."+e).addClass("ma5-parent-enter"),$(".ma5-menu-panel."+a).addClass("ma5-active-enter")}),$(".ma5-leave-bar").on("click touch",function(){var a=$(this).parent().attr("class").replace("li","ul").split("-"),a=(a.splice(-1,1),a.splice(-1,1),a.join("-")),e=$(this).parent().attr("class").replace("li","ul").split("-"),e=(e.splice(-1,1),e.join("-"));$(".ma5-menu-panel").removeClass("ma5-active-leave ma5-parent-leave ma5-active-enter ma5-parent-enter"),$(".ma5-menu-panel."+a).addClass("ma5-parent-leave"),$(".ma5-menu-panel."+e).addClass("ma5-active-leave")})});