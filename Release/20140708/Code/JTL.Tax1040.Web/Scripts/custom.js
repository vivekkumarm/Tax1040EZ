// JavaScript Document

// checkbox enable disable 

$(function () {
	
//	// wizard action //
//	$(document).ready(function() {
//  	var $validator = $("#commentForm").validate({
//		  rules: {
//		    emailfield: {
//		      required: true,
//		      email: true,
//		      minlength: 3
//		    },
//		    namefield: {
//		      required: true,
//		      minlength: 3
//		    },
//		    urlfield: {
//		      required: true,
//		      minlength: 3,
//		      url: true
//		    }
//		  }
//		});

//	  	$('.wizardblock').bootstrapWizard({
//	  		'tabClass': 'nav nav-pills',
//	  		'onNext': function(tab, navigation, index) {
//	  			var $valid = $("#commentForm").valid();
//	  			if(!$valid) {
//	  				$validator.focusInvalid();
//	  				return false;
//	  			}
//	  		}
//	  	});	
//});
	
//// wizard action end //
	
	
    $('.button-checkbox').each(function () {

        // Settings
        var $widget = $(this),
            $button = $widget.find('button'),
            $checkbox = $widget.find('input:checkbox'),
            color = $button.data('color'),
            settings = {
                on: {
                    icon: 'glyphicon glyphicon-check'
                },
                off: {
                    icon: 'glyphicon glyphicon-unchecked'
                }
            };

        // Event Handlers
        $button.on('click', function () {
            $checkbox.prop('checked', !$checkbox.is(':checked'));
            $checkbox.triggerHandler('change');
            updateDisplay();
        });
        $checkbox.on('change', function () {
            updateDisplay();
        });

        // Actions
        function updateDisplay() {
            var isChecked = $checkbox.is(':checked');

            // Set the button's state
            $button.data('state', (isChecked) ? "on" : "off");

            // Set the button's icon
            $button.find('.state-icon')
                .removeClass()
                .addClass('state-icon ' + settings[$button.data('state')].icon);

            // Update the button's color
            if (isChecked) {
                $button
                    .removeClass('btn-default')
                    .addClass('btn-' + color + ' active');
            }
            else {
                $button
                    .removeClass('btn-' + color + ' active')
                    .addClass('btn-default');
            }
        }

        // Initialization
        function init() {

            updateDisplay();

            // Inject the icon if applicable
            if ($button.find('.state-icon').length == 0) {
                $button.prepend('<i class="state-icon ' + settings[$button.data('state')].icon + '"></i> ');
            }
        }
        init();
    });
	
});


 $(function () {
	 // Right side banner action //
            $('#changeSidebarPos').on('click', function (e) {
                $('body').toggleClass('hide-sidebar');
            });
			
			 $('#menutext').on('click', function (e) {
                $('body').toggleClass('hide-sidebar');
            });
			
			 // left Menu active class action //
			$('ul.side-nav li a').click(function (e) {
			    $('ul.side-nav li.active').removeClass('active');
			    $(this).parent('li').addClass('active');
			});
			
			// Top Menu breadcrumb active class action //
			$('div.btn-breadcrumb a').click(function (e) {
			    $('div.btn-breadcrumb a.active').removeClass('active');
			    $(this).select('a').addClass('active');
			});
     
		
				
			
 });

//Added by Venkat S on 30 June 2014 for Pop Up issue.
 $(document).click(function (e) {
     $('.help').each(function () {
         this.tabIndex = -1;
         if (!$(this).is(e.target) && $(this).has(e.target).length === 0 && $('.popover').has(e.target).length === 0) {
             $(this).popover('hide');

             //if ($(this).data('bs.popover').tip().hasClass('in')) {
             //    $(this).popover('toggle');
             //}

             return;
         }
     });
 });

		
		
