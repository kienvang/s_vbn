var tght = {dialog:null,zoom:{}};
tght.zoom.view = function(url, width, height){
	tght.zoom.dialog = new YAHOO.widget.SimpleDialog(
		"zoom_dialog", 
		{
			width: width + "px",
			height: (height + 30) + "px",
			fixedcenter: true,
			visible: false,
			draggable: false,
			modal: true,
			close: true,
			text:'<div style="height:'+(height+40)+'px;text-align:center"><span id="loading">Loading...</span><img src="'+url+'" onload="tght.zoom.onLoaded(this)" style="display:none" /></div>',
			constraintoviewport: true
		}
	);
	tght.zoom.dialog.setHeader('Zoom');
	tght.zoom.dialog.render(document.body);
	tght.zoom.dialog.show();
};
tght.zoom.onLoaded = function(image){
	image.previousSibling.style.display = 'none';
	image.style.display = '';
};
tght.zoom.cancel = function(){
	tght.dialog.destroy();
};
tght.toggle = function(id){
	var obj = document.getElementById(id);
	if(obj){
		obj.style.display = (obj.style.display == 'none')? '' : 'none';
	}
};
//disable right-click
function clickIE4(){
	if(event.button == 2){
		return false;
	}
}
function clickNS4(e){
	if(document.layers || document.getElementById && !document.all){
		if(e.which == 2 || e.which==3){
			return false;
		}
	}
}
if(document.layers){
	document.captureEvents(Event.MOUSEDOWN);
	document.onmousedown = clickNS4;
}else if(document.all && !document.getElementById){
	document.onmousedown = clickIE4;
}
document.oncontextmenu = new Function("return false");