!function(i){i.fn.rlAccordion=function(t,n){var s=i(this),e=i.extend({minus:".minus",plus:".plus",titles:"h3",infos:".mode"},n),l={init:function(){return this.each(function(){i(e.minus).click(function(t){t.preventDefault(),s.find(e.infos).slideUp(),i(e.minus).hide(),i(e.plus).show()}),i(e.plus).click(function(t){t.preventDefault(),s.find(e.infos).slideUp(),i(e.minus).hide(),i(e.plus).show(),i(this).parents(e.titles).next().slideDown(),i(this).siblings().show(),i(this).hide()})})},single:function(){return this.each(function(){i(e.minus).click(function(t){t.preventDefault(),i(this).parents(e.titles).next().slideToggle(),i(this).hide(),i(this).siblings().show()}),i(e.plus).click(function(t){t.preventDefault(),i(this).parents(e.titles).next().slideToggle(),i(this).siblings().show(),i(this).hide()})})}};return l[t]?l[t].apply(this,Array.prototype.slice.call(arguments,1)):"object"!=typeof t&&t?void i.error("Method "+t+" does not exist on jQuery.rlAccordion "):l.init.apply(this,arguments)}}(jQuery);