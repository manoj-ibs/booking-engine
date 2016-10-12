jQuery.fn.delay = function(time,func){
	this.each(function(){
		setTimeout(func,time);
	});
	
	return this;
};

function imgCache() {
	var d=document;
	if(d.images) { 
		if(!d.MM_p) d.MM_p=new Array();
		var i,j=d.MM_p.length,a=imgCache.arguments; for(i=0; i<a.length; i++)
		if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}
	}
}

$(document).ready(function () {
	$('a').mouseenter(function () {
		$(this).css('cursor','pointer');
	});
});


/* Wipeout search box on focus */
$(document).ready(function () {
	var already_focused = 0;
	$('#site_search_terms').focus(function () {
		if (already_focused == 0) {
			$(this).attr('value','');
		}
		already_focused = 1;	
	});
});

/* Highlight fields in inline forms */
$(document).ready(function () {
	$('.inf').focus(function () {
		$(this).addClass('inf-on');
	});
	$('.inf').blur(function () {
		$(this).removeClass('inf-on');
	});
});

/* Cursor mod for Firefox */
$(document).ready(function () {
	$('.hand_cursor').mouseenter(function () {
		$(this).css('cursor','pointer');
	});
});


/****************************/
/* Site-specific functions: */
/****************************/


/* Cache the hover state images */
$(document).ready(function () {
	imgCache(
		'/fb_site/images/logo-hov.png', 
		'/fb_site/images/bg-mn-career.png', 
		'/fb_site/images/bg-mn-contact.png', 
		'/fb_site/images/bg-mn-find-training.png', 
		'/fb_site/images/bg-mn-job-board.png', 
		'/fb_site/images/bg-mn-partners.png', 
		'/fb_site/images/bg-mn-resources.png', 
		'/fb_site/images/bg-mn-trainers.png',
		'/fb_site/images/bg-learn-more-on.png',
		'/fb_site/images/bg-find-out-how-on.png'

	);
});

/* Hover state for logo */
$(document).ready(function () {
	$('#tl_logo').mouseenter(function () {
		$(this).attr('src','/fb_site/images/logo-hov.png');
	});
	$('#tl_logo').mouseleave(function () {
		$(this).attr('src','/fb_site/images/logo.png');
	});
});

/* Hover states for main nav menu */
$(document).ready(function () {

	var menuClass = $('#main_nav').attr('class');

	$('#mn_01').mouseenter(function () {
		$('#main_nav').removeClass(menuClass).addClass('mn_01_on');
	});
	$('#mn_02').mouseenter(function () {
		$('#main_nav').removeClass(menuClass).addClass('mn_02_on');
	});
	$('#mn_03').mouseenter(function () {
		$('#main_nav').removeClass(menuClass).addClass('mn_03_on');
	});
	$('#mn_04').mouseenter(function () {
		$('#main_nav').removeClass(menuClass).addClass('mn_04_on');
	});
	$('#mn_05').mouseenter(function () {
		$('#main_nav').removeClass(menuClass).addClass('mn_05_on');
	});
	$('#mn_06').mouseenter(function () {
		$('#main_nav').removeClass(menuClass).addClass('mn_06_on');
	});
	$('#mn_07').mouseenter(function () {
		$('#main_nav').removeClass(menuClass).addClass('mn_07_on');
	});
	$('#mn_01, #mn_02, #mn_03, #mn_04, #mn_05, #mn_06, #mn_07').mouseleave(function () {
		if ($(this).hasClass('mn_on') == false) {
			$('#main_nav').attr('class', menuClass);
		}
	});
});

/* Hover state for FIND OUT HOW button */
$(document).ready(function () {
	$('#btn_foh').mouseenter(function () {
		$(this).attr('src','/fb_site/images/btn-find-out-how-on.jpg');
	});
	$('#btn_foh').mouseleave(function () {
		$(this).attr('src','/fb_site/images/btn-find-out-how-off.jpg');
	});
});

/* Hover for LEARN MORE buttons */
$(document).ready(function () {
	$('.btn_learn').mouseenter(function () {
		$(this).attr('src','/fb_site/images/btn-learn-more-on.png');
	});
	$('.btn_learn').mouseleave(function () {
		$(this).attr('src','/fb_site/images/btn-learn-more-off.png');
	});
});


/* Wipeout email signup boxes on focus */
$(document).ready(function () {
	$('#h_mailing_list_name').focus(function () {
		$(this).attr('value','');
	});
	$('#h_mailing_list_email').focus(function () {
		$(this).attr('value','');
	});
});

/* Close alert panel and keep it closed */
function closeAlert() {

	$.post("/fb_site/util/util_alert_close.php", { closeIt: 'yes' } );
	$('div#alert').slideUp('fast');

}

/* Manage the suggestion box thing */
$(document).ready(function () {
	
	$('#sug_box_main').mouseenter(function () {
		$(this).css('cursor','pointer');
	});
	
	$('#sug_box_main').click(function () {
		window.location = '/suggestion-box.html';
	});
	
	$('#sug_box_close').click(function () {
		$.post("/fb_site/util/util_sug_close.php", { closeIt: 'yes' } );
		$('#sug_box').fadeOut('fast');
	});
	
});























































































