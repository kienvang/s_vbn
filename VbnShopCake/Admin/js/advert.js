jQuery(function($) {
    $(document).ready(function() {
        $(".positiontype").click(function(){
            var jsonStr = "{AdvertPositionId:'" + $(this).attr("Id") + "',PositionType:'" + $(this).attr("t") + "'}";
            
            $.ajax({
			    type: "POST",
			    url: "/Admin/Webservices/WebService.asmx/UpdatePositionType",
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
        
        //--------------
        
        $("#form").dialog({
            bgiframe: true,
            autoOpen: false,
            height: 300,
            width: 400,
            modal: true,
            draggable: false,
            resizable: false,
            buttons: {
                'Cập nhật': function() {
                    updateAdvertPosition($("#posid").val(), $("#typeid").val());
                     var id = $("#posid").val();
                    //$(".pos-" + id).toggle();
                    $("#view").attr("isupdate", "true");
                    $(this).dialog('close');
                },
                'Thoát': function() {
                    var id = $("#posid").val();
                    $(this).dialog('close');
                }
            },
            close: function(){
                if ($("#view").attr("isupdate") == "false"){
                    var id = $("#posid").val();
                    $(".pos-" + id).toggle();
                }
            }
        });
        
        $(".click").click(function(){
            var id = $(this).attr("id");
            var typeid = $(this).attr("typeid");
            loadView(id, typeid);
        });
        
        function loadView(id, typeid)
        {
            var _url = "/Admin/WebServices/Position.aspx";
            var _data = "id=" + id + "&typeid=" + typeid;
            $(".pos-" + id).toggle();
            $.ajax({
                url: _url,
                data: _data,
                cache: false,
                success: function(html) {
                    //alert(html);
                    var obj = $(html);
                    
                    obj.find("#selPos").bind('change',function(){
                        loadItem($(this).val());
                        $("#typeid").val($(this).val());
                    });
                    
                    $("#view").html(obj);
                    $("#form").dialog('open');
                },
                error: function() {
                    
                        $(".pos-" + id).toggle();
                }
            });
        }
        
        function loadItem(typeid)
        {
            var _url = "/Admin/WebServices/PositionItem.aspx";
            var _data = "typeid=" + typeid;
            $.ajax({
                url: _url,
                data: _data,
                cache: false,
                success: function(html) {
                    //alert(html);
                    //var obj = $(html);
                    $(".viewItem").html(html);
                },
                error: function() {
                }
            });
        }
        
        function updateAdvertPosition(id, typeid)
        {
            var jsonStr = "{id:'" + id + "',typeid:'" + typeid + "'}";

            $.ajax({
                type: "POST",
                url: "/Admin/Webservices/WebService.asmx/UpdateAdvertPosition",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: jsonStr,
                success: function(msg) {
                    $(".pos-" + id).toggle();
                    if (msg.d == true)
                    {
                        $("span." + id).html(typeid);
                        $("#form").dialog('close');
                        
                        $("#view").attr("isupdate", "false");
                    }
                    return true;
                },
                error: function() {
                    return false;
                }
            });
        }
        
        $(".ddlPosition").change(function(){
            window.location = "/Admin/Adverts/SettingBasic.aspx?id=" + $(this).val();
        });
    });
});