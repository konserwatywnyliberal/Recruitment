

var $citiesList = $('.citiesList');
var $formCity = $('.asd');
var $delButtons = $('.remove');
var $editButtons = $('.edit');
var $detailsButton = $('.details');


$('.button_plus').click(function(){
  if($('.asd').css('display')=='none'){
      $('.asd').css('display', 'block').hide().slideDown(650);
  }else{
      $('.asd').css('display', 'none').show().slideUp(650);
    }
 });

$('.save3').click(function(){
   if( $(this).parent().parent().next().css('display')=='none'){
     $(this).parent().parent().next().css('display', 'table-row').slideDown(1000);
   }else {
     $(this).parent().parent().next().css('display', 'none').slideUp(1000);
   }

});

// ADD new city
  $formCity.delegate('.save2', 'click', function(){

		event.preventDefault();

		var city = {

				Name: $formCity.find('[name=Name]').val(),
				PostalCode: $formCity.find('[name=PostalCode]').val(),

		};

		$.ajax({
			url: 'http://localhost:50722/Cities/Create',
			method: 'POST',
			data: JSON.stringify(city),
			dataType: 'json',
			contentType: 'application/json'
		})
		.done(function(newcity){
			addcity(city);
		})
		.fail(function(response){
			console.log(response);
		})

	});
