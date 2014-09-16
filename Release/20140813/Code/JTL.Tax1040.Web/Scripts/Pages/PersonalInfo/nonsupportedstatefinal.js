//Added by prasana for displaying "StateOfResidence"  on page logic <o6> on 23.06.2014
//Modified by prasana in order to display non supported state selected in either one dropdown on 26.06.2014(temporary change for now after spec change will change)
$(document).ready(function () {

  var earnedIncomeStateNotLived =  window.sessionStorage.getItem("EarnedIncomeStateNotLived");
  var morethanOneState  = window.sessionStorage.getItem("MorethanOneState");
  var stateOfResidence = window.sessionStorage.getItem("StateOfResidence")

  if (earnedIncomeStateNotLived != '---Select---') {
      $('#state1').html(earnedIncomeStateNotLived);
      $('#state2').html(earnedIncomeStateNotLived);
  }
  else if (morethanOneState != '---Select---') {
      $('#state1').html(morethanOneState);
      $('#state2').html(morethanOneState);
  }
  else if (stateOfResidence != '---Select---') {
      $('#state1').html(stateOfResidence);
      $('#state2').html(stateOfResidence);
  }
  


    
});