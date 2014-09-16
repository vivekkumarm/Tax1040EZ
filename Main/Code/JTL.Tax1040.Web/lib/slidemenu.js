//Slide Menu.

document.write("<div class='slide-menu'>" +
    "<ul class='menu-items'>" +
    "<li class='menu-item' data-target='#Panel1'><div class='menu-icon'><b class='ic-help'></b></div>" +
        "<div class='menu-content'><span>Help</span></div>" +
            "<div class='menu-close'><b class='ic-times'></b></div></li>" +
                "<li id='CalendarIcon' class='menu-item' data-target='#Panel2'><div class='menu-icon'><b class='ic-bulb'></b></div>" +
                    "<div class='menu-content'><span>FAQ</span></div><div class='menu-close'><b class='ic-times'></b></div></li>" +
                        "<li id='ShoppingIcon' class='menu-item' data-target='#Panel3'><div class='menu-icon'><b class='ic-search'></b></div>" +
                            "<div class='menu-content'><span>Search</span></div><div class='menu-close'><b class='ic-times'></b></div></li>" +
                                "<li id='SearchIcon' class='menu-item' data-target='#Panel4'><div class='menu-icon'><b class='ic-phone'></b></div>" +
                                    "<div class='menu-content'><span>Need Live Support? </span></div>" +
                                        "<div class='menu-close'><b class='ic-times'></b></div></li></ul>" +
                                            "<div class='menu-panels'><div id='Panel1' class='menu-panel'><h4>User Name</h4><p>User Name Should at least 6 characters. You can choose your own name or memorable one </p><a class='more' target='_blank' href=''>Read Common Question</a></div>" +
                                                "<div id='Panel2' class='menu-panel'><a href='#' target='_blank'>What is User ID?</a><a href='#' target='_blank'>Secured Password?</a><a href='#' target='_blank'>Security Question?</a><a href='#' target='_blank'>Tems and Services?</a><a href='#' target='_blank'>Captch?</a></div>" +
                                                    "<div id='Panel3' class='menu-panel'><h4>Search Answers</h4><div class='input-group input-group-sm'><input type='text' class='form-control'><span class='input-group-btn'><button class='btn btn-success ' type='button'>Go!</button></span></div></div>" +
                                                        "<div id='Panel4' class='menu-panel'><div class='toll'>Toll Free <h4>1-866-245-3918</h4></div>" +
                                                            "<div class='chat'>Live Chat<h4><a class='actv' href='#'>Online</a> </h4></div></div></div></div>");