$(document).ready(function(){
    $(".CheckId").click(function()
    {
        var DocId=$(this).attr("docId");
        var jsonStr = "{ID:'" + DocId + "'}";        
        $.ajax({
	        type: "POST",
	        url: "/Admin/Webservices/WebService.asmx/UpdateDocument",
	        contentType: "application/json; charset=utf-8",
	        dataType: "json",
	        data: jsonStr,
	        success: function(msg) {
		        return true;
	        },
	        error: function() {
	            return false;
	        }
	    });
    });
    
    $(".CheckShow").click(function()
    {
        var DocId=$(this).attr("docId");
        var jsonStr = "{ID:'" + DocId + "'}";        
        $.ajax({
	        type: "POST",
	        url: "/Admin/Webservices/WebService.asmx/UpdateDocumentVideo",
	        contentType: "application/json; charset=utf-8",
	        dataType: "json",
	        data: jsonStr,
	        success: function(msg) {
		        return true;
	        },
	        error: function() {
	            return false;
	        }
	    });
    });
});
