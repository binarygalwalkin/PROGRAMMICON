
var commentVisible = 1;
$(document).ready(function(){
	$("#hideComments").click(function() {
		if (commentVisible == 1) {
			$('.jsComment').hide();
			$(this).html('Show comments');
			commentVisible = 0;
		} else {
			$('.jsComment').show();
			$(this).html('Hide comments');
			commentVisible = 1;			
		}
	});
	
	
	
	
	$("span").each(function() {
		//console.log($(this).css('color'));
		if ($(this).css('color') == "rgb(0, 180, 24)") {
			$(this).addClass('jsComment');
		}
	});	

	
	var d = new Date();
	$('#returnedDate').html(d);
	$('#returnedDate2').html(Number(d) + " miliseconds passed since 1970");
	
});





























