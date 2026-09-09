import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Popup as OSWidgets$Popup, Container as OSWidgets$Container, Link as OSWidgets$Link, Image as OSWidgets$Image } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { createElement } from "react";
import { Navigation as OS$Navigation, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvc_view from "./CloneOfPDFViewerODC.PDFViewrReactive.BinaryPDF.mvc$view.js";
import XMLPrettify_XMLPrettify_XMLPrettify_mvc_view from "./XMLPrettify.XMLPrettify.XMLPrettify.mvc$view.js";
import ModelFactory from "./ConectaProveedores.g_Reports.Wb_PreviewFile.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.g_Reports.Wb_PreviewFile.mvc$controller.js";

var componentFactory = function () {
var ELEM = withBaseWebBlock(function (props) {
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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_PopupTogglerVar,
style: "popup-dialoga prev card",
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-main-heading margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
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
uuid: "2",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("JJT5zA4VwUuRB9ykSERdtg#Value", "Preview"))), createElement(OSWidgets$Container, {
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
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopUp$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), $if((((model.variables.l_FilenameVar) !== ((OS$BuiltinFunctions.nullIdentifier()).toString())) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.l_FilenameVar), ".pdf", 0, false, false)) !== ((-1)))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PDFBinary: model.variables.l_BinaryVar,
Height: "70vh"
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
uuid: "8",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "background-color: #e7ebef;"
},
style: "preview-content",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.l_FilenameVar), ".xml", 0, false, false)) !== ((-1))), false, this, function () {
return [createElement(XMLPrettify_XMLPrettify_XMLPrettify_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
XML: model.variables.l_xmlVar
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
uuid: "10",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Image, {
imageContent: model.variables.l_BinaryVar,
type: /*Binary*/ 2,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_PreviewFile",
functionKey: "995a9700-03de-4d8d-b25c-489dc39202c4",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "g_Reports.Wb_PreviewFile",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.g_Reports.Wb_PreviewFile.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Utilities_AlignCenter_mvc_view, CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvc_view, XMLPrettify_XMLPrettify_XMLPrettify_mvc_view];
};


return ELEM;
};

export default componentFactory()
