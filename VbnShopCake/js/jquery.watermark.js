/**
 * @param defaultVal default null
 * @param color default #cccccc
 * @param fontStyle defualt italic
 * @return jQuery object
 */
(function($){
    $.fn.extend({
        'fieldWaterMark' :function(options){
            var defaults = {
                'defaultVal'    : null,
                'color'         : '#cccccc',
                'fontStyle'     : 'italic'
            };
            
            options = $.extend(defaults, options);
            
            return this.each(function(){
                var $this = $(this);
                var currentVal = $.trim($this.val());
                
                $this.css({
                    'color'         : options.color,
                    'font-style'    : options.fontStyle
                });
                
                if(currentVal.length <= 0 && options.defaultVal != null)
                {
                    $this.val(options.defaultVal);
                    currentVal = options.defaultVal;
                }
                
                $this.focus(function(){
                    if($.trim($(this).val()) == currentVal)
                    {
                        $(this).val('')
                        .css({
                            'color'         : '',
                            'font-style'    : ''
                        });
                    }
                })
                .blur(function(){
                    if($.trim($(this).val()).length <= 0)
                    {
                        $(this).css({
                            'color'         : options.color,
                            'font-style'    : options.fontStyle
                        })
                        .val(currentVal);
                    }
                });
            });
        }
    });
})(jQuery);