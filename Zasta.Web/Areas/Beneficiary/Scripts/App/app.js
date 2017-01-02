	/* preloader */
		jQuery(window).load(function() { // makes sure the whole site is loaded
			jQuery("#status").fadeOut(); // will first fade out the loading animation
			jQuery("#preloader").delay(350).fadeOut("slow"); // will fade out the white DIV that covers the website.
		})

	/* barre search Mobile */
	$(document).ready(function() {
	 $('.searchHidden').click(function() {
		$('#search').slideToggle();
	
		if ($(this).text() === '<i class="fa fa-minus"></i>') {
			$(this).html('<i class="fa fa-plus"></i>');
		}
		else {
			$(this).html('<i class="fa fa-minus"></i>');
		}
	 });
	});
	


	/* rating */
		jQuery(function() {
			jQuery('.starbox').each(function() {
				var starbox = jQuery(this);
				starbox.starbox({
					average: starbox.attr('data-start-value'),
					changeable: starbox.hasClass('unchangeable') ? false : starbox.hasClass('clickonce') ? 'once' : true,
					ghosting: starbox.hasClass('ghosting'),
					autoUpdateAverage: starbox.hasClass('autoupdate'),
					buttons: starbox.hasClass('smooth') ? false : starbox.attr('data-button-count') || 5,
					stars: starbox.attr('data-star-count') || 5
				}).bind('starbox-value-changed', function(event, value) {
					if(starbox.hasClass('random')) {
						var val = Math.random();
						starbox.next().text('Random: '+val);
						return val;
					} else {
						starbox.next().text('Clicked: '+value);
					}
				}).bind('starbox-value-moved', function(event, value) {
					starbox.next().text('Moved to: '+value);
				});
			});
		});	
/* Toggle Foire aux questions */
  $(document).ready(function() {

            $(".show1").hide();
            $(".show2").hide();
            $(".show3").hide();
            $(".show4").hide();
            $(".show5").hide();
            $(".show6").hide();
            $(".show7").hide();
            $(".toggleFAQ1").click(function() {
                $(".show1").toggle();
            });
            $(".toggleFAQ2").click(function() {
                $(".show2").toggle();
            });
            $(".toggleFAQ3").click(function() {
                $(".show3").toggle();
            });
            $(".toggleFAQ4").click(function() {
                $(".show4").toggle();
            });
            $(".toggleFAQ5").click(function() {
                $(".show5").toggle();
            });
            $(".toggleFAQ6").click(function() {
                $(".show6").toggle();
            });
            $(".toggleFAQ7").click(function() {
                $(".show7").toggle();
            });
        });
		
		
		 $(document).ready(function() {
            $('.popup-with-zoom-anim').magnificPopup({
                type: 'inline',
                fixedContentPos: false,
                fixedBgPos: true,
                overflowY: 'auto',
                closeBtnInside: true,
                preloader: false,
                midClick: true,
                removalDelay: 300,
                mainClass: 'my-mfp-zoom-in'
            });

        });
   /* Menu Vertical */
		 $(document).ready(function() {
            function isTouchDevice() {
                return 'ontouchstart' in window
            };
            if (isTouchDevice()) {
                $("body").swipe({
                    swipe: function(event, direction, distance, duration, fingerCount, fingerData) {
                        if (direction == 'left') {
                            $('html').removeClass('ma5-menu-active');
                        }
                        if (direction == 'right') {
                            $('html').addClass('ma5-menu-active');
                        }
                    },
                    allowPageScroll: "vertical"
                });
            };
        });
		




		  
 $(document).ready(function() {
            $('#horizontalTab').easyResponsiveTabs({
                type: 'default', //Types: default, vertical, accordion           
                width: 'auto', //auto or any width like 600px
                fit: true // 100% fit in a container
            });
            $("#gallery li img").click(function() {
                $('#main-img').attr('src', $(this).attr('src').replace('Images/', ''));
            });
        });
        $(document).ready(function() {
            // Image swap on hover
            $("#gallery li img").click(function() {
                $('#main-img').attr('src', $(this).attr('src').replace('thumb/', ''));
            });
            // Image preload
            var imgSwap = [];
            $("#gallery li img").each(function() {
                imgUrl = this.src.replace('thumb/', '');
                imgSwap.push(imgUrl);
            });
            $(imgSwap).preload();
        });
        $.fn.preload = function() {
            this.each(function() {
                $('<Images/>')[0].src = this;
            });
        }	

		
