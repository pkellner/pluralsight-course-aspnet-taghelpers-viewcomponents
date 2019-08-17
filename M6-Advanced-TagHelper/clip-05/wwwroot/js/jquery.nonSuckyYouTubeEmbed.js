/*
 *  jquery.nonSuckyYouTubeEmbed - v1.0.0
 *  jQuery.nonSuckyYouTubeEmbed is a jQuery plugin that takes the (performance) suck out of YouTube Embeds
 *  
 *
 *  Made by Max Chadwick
 *  Under MIT License
 */
(function ($) {

	'use strict';

	$.fn.nonSuckyYouTubeEmbed = function(options) {

		var s = $.extend({
			defaultWidth: 640,
			defaultHeight: 390,
			playBtnSrc: 'data:image/png;base64,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',
			playBtnStyle: 'position: absolute; left: 50%; top: 50%; width: 48px; height: 48px; margin-left: -24px; margin-top: -24px; cursor: pointer',
			thumbStyle: 'width: 100%; height: auto; display: inline; cursor: pointer'
		}, options),

		$this,
		videoID,
		thumb,
		thumbAlt,
		playBtn,
		iframe,
		iframeStyle,
		iframeInContainer,
		width,
		height,
		paddingBottom;

		this.each(function() {
			$this = $(this);
			videoID = $this.attr('youtubeid');
			thumbAlt = ($this.data('alt')) ? $this.data('alt') : '';
			thumb = '<img src="http://i.ytimg.com/vi/'+videoID+'/0.jpg" style="'+s.thumbStyle+'" alt="'+thumbAlt+'" />';
			playBtn = '<img style="'+s.playBtnStyle+'" src="'+s.playBtnSrc+'" alt="Play" />';
			$this.css('position', 'relative');
			$this.html(thumb + playBtn);
		});

		return this.bind('click', function() {
			$this = $(this);
			videoID = $this.attr('youtubeid');
			width = ($this.data('width')) ? $this.data('width') : s.defaultWidth;
			height = ($this.data('height')) ? $this.data('height') : s.defaultHeight;
			paddingBottom = ((height / width) * 100) + '%';
			iframeStyle = 'position: absolute; top: 0; left: 0; width: 100%; height: 100%';
			iframe = '<iframe type="text/html" style="'+iframeStyle+'" src="http://youtube.com/embed/'+videoID+'?autoplay=1" frameborder="0" height="'+height+'" width="'+width+'"></iframe>';
			iframeInContainer = '<div style="position: relative; padding-bottom: '+paddingBottom+'; padding-top: 30px; height: 0; overflow: hidden;">'+iframe+'</div>';
			$this.html(iframeInContainer);
		});
	};

}(jQuery));
