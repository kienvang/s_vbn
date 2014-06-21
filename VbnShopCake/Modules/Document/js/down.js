$(document).ready(function(){
    $(".viewVideo").hide();
    $(".showRemark").hide();
    $(".mark").click(function(){
        if($(this).attr("disabled")!="disabled")
            $(".showRemark").slideToggle(400);
    });
    $(".show").click(function(){
        var isshow=$(this).attr("isshow");
        if(isshow=="True")
            $(".viewVideo").slideToggle(400);
    });
    
    $("input[name=remark]:radio").click(function(){
        
        $(".showRemark").hide();
		$(".mark").attr("disabled","disabled");
		var mark=$("input[name=remark]:radio:checked").val();
        var id=$("input[name=remark]:radio:checked").attr("Intid");
        var jsonStr = "{id:'" + id + "',mark:'"+ mark +"'}";        
        $.ajax({
	        type: "POST",
	        url: "/Admin/Webservices/WebService.asmx/UpdateReMark",
	        contentType: "application/json; charset=utf-8",
	        dataType: "json",
	        data: jsonStr,
	        success: function(msg) {
		        
	        },
	        error: function() {
	            return false;
	        }
	    });
    });
    
});