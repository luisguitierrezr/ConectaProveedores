import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Text as OSWidgets$Text, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Container as OSWidgets$Container, Label as OSWidgets$Label, Expression as OSWidgets$Expression, List as OSWidgets$List, Image as OSWidgets$Image, Popup as OSWidgets$Popup, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$view.js";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model } from "@outsystems/runtime-core-js";
import { SE_color as ConectaProveedores_staticEntities_color, SE_size as ConectaProveedores_staticEntities_size } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import ConectaProveedores_d_Invoices_wb_AccSelect_mvc_view from "./ConectaProveedores.d_Invoices.wb_AccSelect.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.mvc$controller.js";
import { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import { ICON_LIBRARY_NAME, ICON_MAPPINGS, WEIGHT_MAPPINGS, SIZE_MAPPINGS } from "./Telcel_Theme.Telcel_Theme_Theme.mappings.js";

var componentFactory = function () {
var ELEM = withBaseWebScreen(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var spanProvider = useTracing();
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Initiative: "FCP",
ChatBotIsEnable: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
breadcrumbs: Widget.PlaceholderContent.Empty,
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("gtNE0gaOmEuJDO1zxHOFfw#Value", "Mass SAEC Folio Creation"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openPopup$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "question-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "5",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadTemplateOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "download",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("IDlZPOCBSk6p8ablnweOVg#Value", "Download Template"))],
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "11",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsEnabled: true,
i_FilesMaxSize: 20971520
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.customUploadOnFileChange$Action(fileIn, errorIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "12",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
dropArea: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel card custom-upload",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("FhDnRkOdkUyMRzJYwnb1PQ#ValueExpression.911285081.1", "Upload Documents"),
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.filesListVar.isEmpty, false, this, function () {
return [createElement(OSWidgets$Text, {
style: "text-neutral-9",
text: [$text(getTranslation("lBEWKWuKXEWDunBE1cyemg#Value", "Click here or drag files to upload"))],
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.filesListVar,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "width: auto;"
},
gridProperties: {
classes: "OSInline"
},
style: "margin-right-s margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr)]
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.neutral3,
Size: ConectaProveedores_staticEntities_size.small
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "21",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "color: var(--color-third); !important"
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_Text: model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "23",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if(true, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.filesListVar.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr)]
}))];
}, callContext, idService, "1")
},
_dependencies: []
}))];
}), createElement(OSWidgets$Image, {
extendedProperties: {
style: model.getCachedValue(idService.getId("ReLlaqfplEy167rjuo9WRA.style"), function () {
return ((model.variables.filesListVar.isEmpty) ? ("top: 10px;") : ("top: 12px;"));
}, function () {
return model.variables.filesListVar.isEmpty;
})
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_subir.svg"),
style: "img clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.filesListVar)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_Invoices_wb_AccSelect_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderMainID: model.variables.l_OrderMainIDVar,
IsEnable: model.getCachedValue(idService.getId("uLUya+OIAEiF6TyXy8zCHA.IsEnable"), function () {
return !(model.variables.l_OrderMainIDVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())));
}, function () {
return model.variables.l_OrderMainIDVar;
}),
IsFromFolio: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
sendOrderAccConcept$Action: function (oFolioAccDataIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_AccSelectSendOrderAccConcept$Action(oFolioAccDataIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "29",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Popup, {
extendedProperties: {
style: "width: 1000px;"
},
showPopup: model.variables.helpPopupVar,
style: "popup-dialog help-popup",
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-popup-header",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
style: "help-popup-title",
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "heading2",
text: [$text(getTranslation("REZyOBTaV0SJ5qyJOWOE7w#Value", "Considerations for correctly filling out the upload file"))],
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopup$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-popup-subtitle",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jY2VkBAZwUm0HLhGEVNCQQ#Value", "Before uploading the file, carefully review the following information to avoid validation errors.\n")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 700px;"
},
style: "help-popup-content",
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}, "1"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ssyk5Sad10e2S2KAvlYs7A#Value", "Use the Official Format"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_KlPzfAaAUiNVkcc8Adh8A#Value", "You must use the Excel file downloaded from the \"Download upload format\" option.\nDo not change the structure or column names."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, "2"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("6YwZZSHut0eYC+6SGxDMrg#Value", "Column “No.”"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("FQbg_7ioQ0OEVsr6YxgMvQ#Value", "Enter the folio number you wish to create.\nIf you are creating multiple folios, enter the sequential numbering: 1, 2, 3, 4...\nIf a single folio includes multiple positions or multiple supporting files, you must repeat the same number in multiple rows."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, "3"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+li_utR1r06zXzCPQrAjcA#Value", "Column “Order” "))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("AYcs+zejUUG3iKCVyP7QkA#Value", "You must capture a valid order.\nOnly bulk uploads of orders with account assignment Q are allowed."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, "4"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Q9fA0zy+CUiL730QVp_xzQ#Value", "Column \"Attachments\""))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_c1MmJwwl0uUxh+XA4hT7g#Value", "You must specify the exact name of the support file, including the extension.\nThe name entered in the Excel file must exactly match the name of the file you are uploading."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, "5"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Ey50Wop6x0GxDmDBdjbHSQ#Value", "Column “No.”"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1_A0i5E0VkmGEC62vwkO4g#Value", "You must indicate the order position that corresponds to the folio."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}, "6"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0PrWrb9Tt0eb9zPpQLWkHQ#Value", "Column “Delivery Date”"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("BIYt1huNqkmLhZYwSNKFtg#Value", "You must capture the date in DD/MM/YYYY format."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, "7"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("GbV9yRS8Iku0_SaQKqzLSQ#Value", "Column “Amount to be invoiced”"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("lvZD3O7Fe0KbRNbJfyIICg#Value", "It must be greater than 0.\nIt can include up to 3 decimal places.\nIt must not be greater than the order quantity or the quantity on hold."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
}, "8"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("C4D9vHKMSEqtcxWayvnZIQ#Value", "Column “User”"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("77pOnkrZo0ygVYxw66XM1g#Value", "You must provide an email address.\nFor this first version, this information will not be considered for approval, but it must be included in the file."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, "9"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("CPcuE0JU2UyXQHST_wo8WQ#Value", "Columns “PDF Invoice” and “XML Invoice”"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2kcEyqAHHUOhxloC_HTcVQ#Value", "You must specify the exact file names, including the extension.\nThe PDF and XML files must have the same base name, only the extension.\nEach folio can only contain one PDF invoice and one XML invoice.\nIf a folio has multiple rows, you must repeat these names in all corresponding rows."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider
}, "10"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("227+5EtBzUa7h4R_WJyKFg#Value", "Column “PEP”"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3cETN_aA5EKEtLJQ9Qn69Q#Value", "You must enter the corresponding PEP key.\nThe maximum allowed length is 24 characters."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider
}, "11"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("PE1fYOqaMkWHxrZXRUkVvQ#Value", "ID Location and Location Name"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1_rFazO6SkuSpwtbOpX8IQ#Value", "You must capture this information as it corresponds to the related site."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider
}, "12"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("e4ZhG+xuRkeO0ibPMkXnGg#Value", "File Upload"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("aH2gcfsqGkqRCzICBg4XUQ#Value", "All files must be uploaded in a single action:\n. Excel file\n. Supporting files\n. PDF invoice\n. XML invoice"))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider
}, "13"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Y0svdMoW2Uin3Oi2jm+5Aw#Value", "System Validation"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("4WSgvuC+LEGZjanP0AkliQ#Value", "Only rows that pass all validations will be considered for creating folios.\nRows with errors will not be processed.\nYou can view the error details to correct the information."))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item",
visible: true,
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-number",
visible: true,
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider
}, "14"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-body",
visible: true,
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-title",
visible: true,
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("85Oxrv6OT0WAs8T+2kKEtg#Value", "Final Recommendation"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "help-item-text",
visible: true,
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("F9YHH_hAPk6axX9p6YR6Qg#Value", "Before uploading the information, verify:\n. Correct date format\n. Exact file names\n. Order with account assignment Q\n. Valid quantities\n. PDF and XML invoices with the same base name"))))))), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.clearOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("rN7DDB16KE6bKNpZGm6tCw#Value", "Clear"))), createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("VnpP2SkmLUekpTWsCXpyfA.Enabled"), function () {
return (((!(model.variables.folioQListVar.isEmpty)) && (model.variables.numberWithErrorsVar === 0)) && !(model.variables.l_FolioAccDataVar.orderAccConceptIDAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))));
}, function () {
return model.variables.folioQListVar.isEmpty;
}, function () {
return model.variables.numberWithErrorsVar;
}, function () {
return model.variables.l_FolioAccDataVar.orderAccConceptIDAttr;
}),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.importOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("UYWDYCZ4P0WptxG3O3lVYQ#Value", "Import"))), createElement(OSWidgets$Button, {
enabled: ((!(model.variables.filesListVar.isEmpty)) && model.variables.folioQListVar.isEmpty),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.uploadNewFile$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("RLoPQli2pEaoZvAt1212wQ#Value", "Upload Files")))))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "summary-container",
visible: model.variables.getSupplierNameDataAct.isDataFetchedAttr,
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "metrics",
visible: true,
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "metric-card",
visible: true,
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "metric-value",
visible: true,
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("9JsIGVBM0UeGycSHABsTbw#Value", "Supplier Name"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "metric-label",
visible: true,
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getSupplierNameDataAct.supplierNameOut,
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierNameDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "metric-card",
visible: true,
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "metric-value",
visible: true,
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7SC2N94fzkaN0it17qFxhQ#Value", "Number of delivery rows"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "metric-label",
visible: true,
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.numberOfRecordsVar).toString(),
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "metric-card",
visible: true,
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "metric-value",
visible: true,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_DseHDovWkuZ8NlMFE9s1Q#Value", "Number of delivery approval requests"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "metric-label",
visible: true,
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.folioQListVar.length).toString(),
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "metric-card",
visible: true,
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "metric-value",
visible: true,
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("oxWE2H_x3US7NnayF7BwGw#Value", "Positions with error"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "metric-label",
visible: true,
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.numberWithErrorsVar).toString(),
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
})))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.numberOfRecordsVar), asPrimitiveValue(model.variables.getSupplierNameDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierNameDataAct.supplierNameOut), asPrimitiveValue(model.variables.getSupplierNameDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.l_FolioAccDataVar.orderAccConceptIDAttr), asPrimitiveValue(model.variables.numberWithErrorsVar), asPrimitiveValue(model.variables.folioQListVar.length), asPrimitiveValue(model.variables.folioQListVar.isEmpty), asPrimitiveValue(model.variables.helpPopupVar), asPrimitiveValue(model.variables.l_OrderMainIDVar), asPrimitiveValue(model.variables.filesListVar)]
}), $if((!(model.variables.folioQListVar.isEmpty)), false, this, function () {
return [createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "131",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "summary-container",
visible: (!(model.variables.folioQListVar.isEmpty)),
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "horizontal-scroll ",
visible: true,
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.folioQListVar,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "Position",
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Gueduw5RGEWOAUBQWzkoYQ#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "PEP",
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("nzRDDuzzR0mEZC2ZpBd3Fw#Value", "PEP"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "PlaceId",
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4S_51YwI3E6hle0XbjtWug#Value", "Place"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "PlaceName",
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("9Yr0VgduYUqUJskB1dgMzA#Value", "Place Name"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("bHnI5xsq7EmHVukehSHO9A#Value", "Number"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("oc1FXrv8z06icQof_ChKEQ#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "MaterialCode",
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("oxOqQVMlyUWTZnqDv3vykg#Value", "Material Code"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "MaterialDescription",
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("HTHUyp938k+4ep8V9XrZXQ#Value", "Material Description"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "AssigmentCode",
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("cskqJ17xl0iRwwj2sEFSOw#Value", "Assigment Code"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("r1q4EfMD_0+HGvgD_gWakQ#Value", "Delivery Date"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("YzS7nulP+0+cRnA6lYyb4w#Value", "Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("yTkR575l2UussnUk9wp+Vw#Value", "Invoice Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("P3Ay_ze9QEWM7qVtbXEDBQ#Value", "Waiting Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("U_xEk_C8rEynWDo56G8puQ#Value", "Delivered Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("BE2xLb48W0O2SUV_0Y1UXQ#Value", "Unit Price"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("FUQ7UH6YaEaTuaMSYHCDzg#Value", "Total Amount"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("38dmZEWJMkmHpDnSEDzMKA#Value", "Amount Delivered"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("tiIH+zMAkkWTE46nLCqAvQ#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Ti8ymms_+0u8hsyc_pMzkw#Value", "Support Files"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("dOXZ0eTXw0ChH32P2gJQJw#Value", "Invoice files"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).messageAttr), asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).withErrorAttr)]
}, $if(model.variables.folioQListVar.getCurrent(callContext.iterationContext).withErrorAttr, false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "158",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #d10000;"
},
icon: "exclamation-triangle",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).messageAttr,
_idProps: {
service: idService,
uuid: "160"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).messageAttr)]
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "161"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).positionAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.folioQListVar.getCurrent(callContext.iterationContext).positionAttr).toString(),
_idProps: {
service: idService,
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).pEPAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).pEPAttr,
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).placeIdAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).placeIdAttr,
_idProps: {
service: idService,
uuid: "167"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "168"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).placeNameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).placeNameAttr,
_idProps: {
service: idService,
uuid: "169"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).numberAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "171"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.folioQListVar.getCurrent(callContext.iterationContext).numberAttr).toString(),
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "173"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).orderNumberAttr,
_idProps: {
service: idService,
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).materialCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).materialCodeAttr,
_idProps: {
service: idService,
uuid: "176"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "177"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).materialDescriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).materialDescriptionAttr,
_idProps: {
service: idService,
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).assigmentCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).assigmentCodeAttr,
_idProps: {
service: idService,
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "181"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).deliveryDateAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.folioQListVar.getCurrent(callContext.iterationContext).deliveryDateAttr) !== (OS$BuiltinFunctions.dateToText(OS$BuiltinFunctions.nullDate()))), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).deliveryDateAttr,
_idProps: {
service: idService,
uuid: "183"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return ["-"];
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("NHj7ZQ6740KQBhXtBvuEwA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.folioQListVar.getCurrent(callContext.iterationContext).quantityAttr, 2, ".", ",");
}, function () {
return model.variables.folioQListVar.getCurrent(callContext.iterationContext).quantityAttr;
}),
_idProps: {
service: idService,
uuid: "185"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).invoiceQuantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "187"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("5O+HZFfAC0iWciBZM+R5tA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.folioQListVar.getCurrent(callContext.iterationContext).invoiceQuantityAttr, 2, ".", ",");
}, function () {
return model.variables.folioQListVar.getCurrent(callContext.iterationContext).invoiceQuantityAttr;
}),
_idProps: {
service: idService,
uuid: "188"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "189"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).waitingQuantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "190"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("MqUXxMDPXEGywPVnY87mZA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.folioQListVar.getCurrent(callContext.iterationContext).waitingQuantityAttr, 2, ".", ",");
}, function () {
return model.variables.folioQListVar.getCurrent(callContext.iterationContext).waitingQuantityAttr;
}),
_idProps: {
service: idService,
uuid: "191"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "192"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).deliveredQuantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "193"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.folioQListVar.getCurrent(callContext.iterationContext).deliveredQuantityAttr).toString(),
_idProps: {
service: idService,
uuid: "194"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "195"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).unitPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "196"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("tqS4H_vtqUKunX92ite4mQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.folioQListVar.getCurrent(callContext.iterationContext).unitPriceAttr, 2, ".", ",");
}, function () {
return model.variables.folioQListVar.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "197"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "198"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).invoiceQuantityAttr), asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).unitPriceAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("N+7lrLNnQkGFx9DXUYjTEg.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.folioQListVar.getCurrent(callContext.iterationContext).unitPriceAttr.times(model.variables.folioQListVar.getCurrent(callContext.iterationContext).invoiceQuantityAttr), 2, ".", ",");
}, function () {
return model.variables.folioQListVar.getCurrent(callContext.iterationContext).unitPriceAttr;
}, function () {
return model.variables.folioQListVar.getCurrent(callContext.iterationContext).invoiceQuantityAttr;
}),
_idProps: {
service: idService,
uuid: "199"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "200"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).amountDeliveredAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "201"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("nSBXGyYO9kWmIaLFMfKrPw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.folioQListVar.getCurrent(callContext.iterationContext).amountDeliveredAttr, 2, ".", ",");
}, function () {
return model.variables.folioQListVar.getCurrent(callContext.iterationContext).amountDeliveredAttr;
}),
_idProps: {
service: idService,
uuid: "202"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "203"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).currencyAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).currencyAttr,
_idProps: {
service: idService,
uuid: "204"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "205"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).folioQFilesListAttr)]
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.folioQListVar.getCurrent(callContext.iterationContext).folioQFilesListAttr,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "206"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "207"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).folioQFilesListAttr.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).folioQFilesListAttr.getCurrent(callContext.iterationContext).fileExistsAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
uuid: "208"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.folioQListVar.getCurrent(callContext.iterationContext).folioQFilesListAttr.getCurrent(callContext.iterationContext).fileExistsAttr)), false, this, function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #d10018;"
},
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "209"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #037019;"
},
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "210"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width10 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "211"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).folioQFilesListAttr.getCurrent(callContext.iterationContext).filenameAttr,
_idProps: {
service: idService,
uuid: "212"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, callContext, idService, "3")
},
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "213"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).invoiceFilenameXmlAttr), asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).isValidInvoiceFilenameXmlAttr), asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).invoiceFilenamePdfAttr), asPrimitiveValue(model.variables.folioQListVar.getCurrent(callContext.iterationContext).isValidInvoiceFilenamePdfAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "214"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
uuid: "215"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.folioQListVar.getCurrent(callContext.iterationContext).isValidInvoiceFilenamePdfAttr)), false, this, function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #d10018;"
},
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "216"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #037019;"
},
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "217"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width10 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "218"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).invoiceFilenamePdfAttr,
_idProps: {
service: idService,
uuid: "219"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "220"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
uuid: "221"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.folioQListVar.getCurrent(callContext.iterationContext).isValidInvoiceFilenameXmlAttr)), false, this, function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #d10018;"
},
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "222"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #037019;"
},
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "223"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width10 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "224"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.folioQListVar.getCurrent(callContext.iterationContext).invoiceFilenameXmlAttr,
_idProps: {
service: idService,
uuid: "225"
},
_widgetRecordProvider: widgetsRecordProvider
})))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "226"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeOnClick$Action(model.variables.folioQListVar.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "227"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "228"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, callContext, idService, "3_0")
},
_dependencies: []
}))))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.numberOfRecordsVar), asPrimitiveValue(model.variables.getSupplierNameDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierNameDataAct.supplierNameOut), asPrimitiveValue(model.variables.getSupplierNameDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.l_FolioAccDataVar.orderAccConceptIDAttr), asPrimitiveValue(model.variables.numberWithErrorsVar), asPrimitiveValue(model.variables.folioQListVar), asPrimitiveValue(model.variables.helpPopupVar), asPrimitiveValue(model.variables.l_OrderMainIDVar), asPrimitiveValue(model.variables.filesListVar)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "NewMassiveFolioSAE",
functionKey: "ab525bfa-ef71-4d9c-bf99-df4904de28a3",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.NewMassiveFolioSAE",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
return ("Portal Conecta Proveedores " + ConectaProveedoresController$getEnviroment$Action(callContext).enviromentOut);
},
iconLibrary: ICON_LIBRARY_NAME,
iconMappings: ICON_MAPPINGS,
iconWeightMappings: WEIGHT_MAPPINGS,
iconSizeMappings: SIZE_MAPPINGS
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view, ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, OutSystemsUI_Content_Tag_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, ConectaProveedores_d_Invoices_wb_AccSelect_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view];
};


return ELEM;
};

export default componentFactory()
