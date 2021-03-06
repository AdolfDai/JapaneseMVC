/**
 * @license Copyright (c) 2003-2017, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function (config) {
    // Define changes to default configuration here. For example:
    // config.language = 'fr';
    // config.uiColor = '#AADC6E';

    //config.extraPlugin = 'syntaxhighlight';
    config.syntaxhighlight_lang = 'csharp';
    config.syntaxhighlight_hideControls = true;
    config.language = 'vi';
    config.filebrowserBrowseUrl = '/Assets/plug-in/ckfinder/ckfinder.html';
    config.filebrowserImageBrowseUrl = '/Assets/plug-in/ckfinder.html?Type=Images';
    config.filebrowserFlashBrowseUrl = '/Assets/plug-in/ckfinder.html?Type=Flash';
    config.filebrowserUploadUrl = '/Assets/plug-in/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    config.filebrowserImageUploadUrl = '/Data';
    config.filebrowserFlashUploadUrl = '/Assets/plug-in/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';

   // CKFinder.setupCKEditor(null, '/Assets/Admin/plug-in/ckfinder/');
    
};
