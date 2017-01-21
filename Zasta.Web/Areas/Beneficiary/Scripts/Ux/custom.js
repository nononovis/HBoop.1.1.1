function setupMainMenu(e){var t=0;var n=20;var r=parseInt(n/2,10);var i=35;main_menu_items.each(function(){var e=$(this);var s=e.find("> a");var o=e.find("> ul");var u=o.length>0;if(u){s.addClass("has_sub");e.data("disable_animation",1);e.on("mouseenter",function(){e.css({zIndex:i});o.stop().css({zIndex:i}).fadeTo(300,1);i++});e.on("mouseleave",function(){e.css({zIndex:25});o.stop().css({zIndex:10}).fadeTo(300,0,function(){o.hide()})});var a=o.find("ul");if(a.length>0){a.hide();a.parent().on("mouseenter",function(){a.stop().css({zIndex:11}).fadeTo(300,1)});a.parent().on("mouseleave",function(){a.stop().css({zIndex:10}).fadeTo(300,0,function(){a.hide()})})}}var f=e.width();var l=parseInt(e.css("margin-left"),10);var c=parseInt(active_marker.css("padding-left"),10);var h=parseInt(active_marker.css("padding-right"),10);var p=parseInt((c+h)/2,10);var d=t+l-r;e.data("left",d);e.data("width",f+n);t+=e.outerWidth()+l;var v=e.data("width");var m=e.data("left");var g=active_item.data("width");var y=active_item.data("left");e.on("hover",function(){active_marker.stop().animate({left:m,width:v},{duration:am_motion_duration,easing:am_easing_type})});main_menu.on("mouseleave",function(){active_marker.stop().animate({left:y,width:g},{duration:am_motion_duration,easing:am_easing_type})})});if(active_item.length>0){var s=active_item.data("width");var o=active_item.data("left");if(e){active_marker.animate({left:o,width:s},{duration:am_motion_duration,easing:am_easing_type})}else{active_marker.css({left:o,width:s}).show()}}}function partnersCarouselFit(){var e=$(".partners_carousel").data("ancarouselinstance");if(typeof e!="undefined"){switch(test_device_type()){case"large_screen":e.updateItemsPerRowNumber(5);break;case"ipad":e.updateItemsPerRowNumber(4);break;case"iphone_landscape":case"iphone":e.updateItemsPerRowNumber(2);break}}}function setupPhotoStream(e,t){if(!t)t=6;var n=e.find("a img");var r=n.length;e.data("images_per_tab",t).data("current_tab",1);if(r>t){var i=Math.ceil(r/t);var s=n.slice(0,t);n.parent().hide();s.parent().show();var o=$('<div class="photostream_tabs" />');for(var u=1;u<=i;u++){var a=$('<a href="#">'+u+"</a>");a.data("index",u);if(u==1)a.addClass("active");a.on("click",function(t){t.preventDefault();var n=$(this);switchPhotostreamTab(e,n)});o.append(a)}e.append(o);o.before('<div class="clear" />')}}function switchPhotostreamTab(e,t){var n=80;var r=500;var i=e.find(".photostream_tabs a");var s=t.data("index");i.removeClass("active");t.addClass("active");var o=e.data("images_per_tab");var u=e.data("current_tab");var a=e.find("a img");var f=(u-1)*o;var l=f+o;var c=a.slice(f,l);var h=(s-1)*o;var p=h+o;var d=a.slice(h,p);c.parent().hide();d.parent().fadeIn(r);e.data("current_tab",s)}var _clearer=null;var main_menu,main_menu_items,active_marker,active_item,am_motion_duration,am_easing_type;jQuery(function(e){_clearer=e("<div />").addClass("clear");e(".site_footer .photostream, .post_entry .post_block .post_details, .module_content, .tab_content, .post_meta, .blog_post_comments, .portfolio_item .item_meta").append(_clearer.clone());e(".cblock").each(function(){var t=e(this);t.before(_clearer.clone());t.append(_clearer.clone())});e(".pagination").before(_clearer.clone());var t=200;var n=8;e(".portfolio_item .item_meta a.liked").each(function(){var r=e(this);var i=e('<div class="already_liked"><i></i>You liked this</div>');r.append(i);i.css({marginTop:n});r.on("mouseenter",function(){if(!i.is(":visible"))i.fadeTo(0,0);i.stop().animate({opacity:1,marginTop:0},t)});r.on("mouseleave",function(){i.stop().animate({opacity:0,marginTop:n},t,function(){i.hide()})});r.each});var r=-5,i=.5,s=120,o="easeInOutQuad";e(".site_header .top_social li").fadeTo(0,i).each(function(){var t=e(this);t.css({position:"relative"});t.on("mouseenter",function(){t.stop().animate({top:r,opacity:1},{duration:s,easing:o})});t.on("mouseleave",function(){t.stop().animate({top:0,opacity:i},{duration:s,easing:o})})});var u=2;var a=5;var f=e(".tweets");if(f.data("tweets"))u=parseInt(f.data("tweets"),10);if(f.data("timeout"))a=parseInt(f.data("timeout"),10);var l=f.children();l.hide().slice(0,u).show();var c={container:f,tweets:l,tweets_per_page:u,timeout:a*1e3,pause_on_hover:true};var h=new tweetRoller(c);h.start();e("a.back_to_top").on("click",function(t){t.preventDefault();e("html,body").animate({scrollTop:0},{duration:800,easing:"easeInOutQuad"})});e(".site_header .bar_top .container").append(_clearer);e(".cblock ul:not(.bullet) li").each(function(){var t=e(this);var n=t.find("ul, ol").length;if(n>0){t.addClass("expanded")}});var p=e("<a />");p.addClass("hide").attr("href","#");e(".alert").each(function(){var t=e(this);var n=p.clone();t.prepend(n);n.on("click",function(e){e.preventDefault();t.slideUp("medium")})});am_motion_duration=450;am_easing_type="easeOutBack";main_menu=e(".main_menu");main_menu_items=main_menu.find("> li");active_marker=e("<div />").addClass("active_marker");active_item=main_menu.find("> li.active");main_menu.append(active_marker);setTimeout(function(){setupMainMenu()},200);var d=e("<table />");d.addClass("outer_title_table").attr("width","100%");var v=e("<tr />");var m=e("<td />").addClass("left_border");var g=e("<td />").addClass("text_env");var y=e("<td />").addClass("right_border");v.append(m).append(g).append(y);d.append(v);e("h1.title, h2.title, h3.title, h4.title").each(function(){var t=e(this);var n=t.get(0).tagName;var r=t.html().toString();var i=e("<"+n+" />").html(r);var s=d.clone();t.after(s).detach();s.find(".text_env").html(i)})});var tweetRoller=function(e){var t=this;var n={container:null,tweets:null,tweets_per_page:2,timeout:0,pause_on_hover:true,show_hide_speed:500};$.extend(n,e);var r=n.container;var i=n.tweets;var s=n.tweets_per_page;var o=n.timeout;var u=n.pause_on_hover;var a=n.show_hide_speed;var f=null;r.css({position:"relative"});this.index=0;this.total=i.length;var l=15;return{next:function(){var e=this.get_indexes();var t=i.slice(e[0],e[1]);this.next_index();e=this.get_indexes();var n=i.slice(e[0],e[1]);t.stop().css({position:"relative"}).animate({top:l,opacity:0},{duration:a,complete:function(){t.css({top:0}).hide();n.fadeTo(0,0);n.stop().css({top:l,position:"relative"}).animate({top:0,opacity:1},{duration:a})}})},get_indexes:function(){var e=t.index;var n=t.index+s;n%=t.total;if(n<e){var r=e-n-s;e-=n-r;n=e+s}return[e,n]},next_index:function(){t.index+=s;t.index=t.index%t.total},start:function(){var e=this;if(o>0){var t=function(){e.next()};f=setInterval(t,o);if(u){r.hover(function(){window.clearInterval(f);f=null},function(){f=setInterval(t,o)})}}}}};var portfolio_items;jQuery(document).ready(function(e){portfolio_items=e(".portfolio_sortable");portfolio_items.find(".portfolio_item").each(function(){var t=e(this);var n=t.data("filter");t.addClass(n);t.hover(function(){t.css({zIndex:5})},function(){t.css({zIndex:4})})});if(!e.isFunction(portfolio_items.imagesLoaded))return;portfolio_items.imagesLoaded(function(){portfolio_items.isotope({masonry:{itemSelector:".portfolio_item",gutterWidth:40,columnWidth:1/4},animationOptions:{duration:750,easing:"linear",queue:false}});if(e.browser.mozilla){portfolio_items.css("position","static")}var t=e(".portfolio_more_results");var n=t.find("> a");if(t.size()==1){portfolio_items.infinitescroll({navSelector:t,nextSelector:n,itemSelector:".portfolio_item",loadingImg:"",bufferPx:5,loading:{selector:e(".portfolio_loading"),msgText:"Loading items…",finishedMsg:"There are no more items to load.",img:"images/loader.gif"}},function(n){var r=e(n);r.each(function(){var t=e(this);var n=t.data("filter");t.addClass(n)});r.hoverZoom({overlayColor:"#000",overlayOpacity:.3}).css({opacity:0}).imagesLoaded(function(){portfolio_items.isotope("appended",r,function(){r.find(".zoom").prettyPhoto({social_tools:""})});var e=portfolio_items.data("infinitescroll");t.show()})});var r=portfolio_items.data("automatic-loading");if(r=="false"||r=="0"||r=="no"){e(window).unbind(".infscr");var i=portfolio_items.data("infinitescroll");n.click(function(e){e.preventDefault();i.retrieve()})}}})});jQuery(document).ready(function(e){var t=e(".accordion");if(e.isFunction(t.accordion)){t.accordion({})}});jQuery(document).ready(function(e){var t=e(".wideslider ul");if(e.isFunction(t.wideslider)){t.wideslider({delay:800,nextPrev:e(".wideslider_nextprev"),prevNextOnKeyboard:true})}});jQuery(document).ready(function(e){var t=e(".portfolio_slider");if(e.isFunction(t.responsiveSlides)){t.imagesLoaded(function(){t.responsiveSlides({nav:true,pause:true,timeout:5e3,controls:t})})}});jQuery(document).ready(function(e){var t={classHolder:"selectbox_env",classToggle:"select_toggle",classSelector:"select_open",classToggleOpen:"select_is_opened",classOptions:"select_options"};e("select.selectbox").each(function(){var n=e(this);if(n.attr("id")=="portfolio_filter"){t.onChange=function(e){var t="."+e;if(t==".*")t="*";portfolio_items.isotope({filter:t});isotopeFix();n.parent().css({position:"relative",zIndex:50})}}n.selectbox(t)})});jQuery(document).ready(function(e){var t=e(".partners_carousel");if(e.isFunction(t.anCarousel)){t.anCarousel({itemsPerRow:5,autoSlide:3e3,pauseOnHover:true});partnersCarouselFit()}});jQuery(document).ready(function(e){var t=e(".zoom");t.hoverZoom({overlayColor:"#000",overlayOpacity:.3});var n={social_tools:""};if(e.isFunction(t.prettyPhoto)){t.prettyPhoto(n)}});jQuery(document).ready(function(e){var t=e(".features_tabs");if(e.isFunction(t.featuresTabs)){t.featuresTabs();t.wrap(e('<div class="large_screen_only" />'))}});jQuery(document).ready(function(e){var t=e(".asyncslider");if(e.isFunction(t.asyncSlider)){t.asyncSlider({prevNextNav:".asyncslider .container",numbersNav:".asyncslider .container"})}});jQuery(function(e){var t=e(".staff_members .staf_member");if(!e.isFunction(t.imagesLoaded))return;t.imagesLoaded(function(){t.each(function(){var t=e(this);var n=t.find(".image");var r=n.find(".connect");var i=parseInt(n.css("padding-left"),10);var s=parseInt(n.css("padding-right"),10);var o=parseInt(n.css("padding-top"),10);var u=parseInt(n.css("padding-bottom"),10);var a=e('<div class="hover_overlay" />');a.height(n.height()+o+u);n.append(a);var f=a.width();var l=a.height();var c=l+o+u;var h={marginTop:-c};var p={marginTop:0};var d={opacity:0};var v={opacity:1};a.css(h);r.show().css(d);n.hover(function(){a.stop().animate(p,{duration:300,easing:"easeOutExpo"});r.stop().animate(v,{duration:300,easing:"easeInOutSine"})},function(){a.stop().animate(h,{duration:450,easing:"easeOutExpo"});r.stop().animate(d,{duration:150,easing:"easeInOutSine"})});r.show().css({left:"50%",top:"50%",marginLeft:-parseInt(r.width()/2,10),marginTop:-parseInt(r.height()/2,10)})})})});jQuery(function(e){e(".featured_post").addClass("clearfix");e(".tab_content").each(function(){e(this).find(".featured_post").last().addClass("last")});e(".tabs").each(function(){var t=e(this);var n=t.find(".tabbed a");var r=n.parent();if(n.size()==2)r.addClass("duo");if(n.size()==3)r.addClass("treo");var i=t.find(".tab_content");i.each(function(){var t=e(this).height();e(this).attr("data-height",t)});n.click(function(t){t.preventDefault();var r=e(this).attr("href");if(e(this).hasClass("active"))return false;n.removeClass("active");e(this).addClass("active");var s=i.filter(":visible");var o=i.filter(r);var u=parseInt(o.attr("data-height"),10);s.css({position:"relative",zIndex:9,overflow:"hidden"}).stop().animate({height:0,opacity:0});o.show().css({position:"relative",zIndex:10,overflow:"hidden",height:0,opacity:0}).stop().animate({height:u,opacity:1})});i.hide();var s=n.filter('[class="active"]').attr("href");i.filter(s).show()})});jQuery(function(e){var t=200;var n=e("ul.testimonials, ul.home_testimonials");var r=n.find("> li");var i=e('<div class="testimonials" />');if(r.length>1){r.hide();var s=e('<a href="#" class="prev"></a>');var o=e('<a href="#" class="next"></a>');s.data("direction",-1);o.data("direction",1);var u=e('<div class="author" />');n.data("total_elements",r.length);n.data("current_index",0);n.after(i);i.append(s).append(o).append(u).append(_clearer.clone());function a(n,i){var s=r.filter(":visible");var o=e(r.get(n));var a=o.data("author");if(s.size()==0){s=o}if(!i){s.stop().fadeTo(t,0,function(){s.hide();o.stop().fadeTo(t,1);u.hide().text(a).fadeTo(t,1)})}else{s.hide();o.add(u.text(a)).show()}}a(0,true);function f(){var e=n.data("total_elements");var t=n.data("current_index");var r=t+1;r=r%e;return r}s.add(o).on("click",function(t){t.preventDefault();var r=e(this);window.clearInterval(l);l=null;var i=r.data("direction");var s=n.data("total_elements");var o=n.data("current_index");var u=o+i;if(u<0)u=s-1;u=u%s;n.data("current_index",u);a(u)});var l;var c=n.data("autoswitch");var h=n.data("timeout");if(c=="1"||c=="true"){l=setInterval(function(){var e=f();a(e);n.data("current_index",e)},parseFloat(h,10)*1e3)}}});jQuery(function(e){var t=e(".photostream");setupPhotoStream(t,6)})