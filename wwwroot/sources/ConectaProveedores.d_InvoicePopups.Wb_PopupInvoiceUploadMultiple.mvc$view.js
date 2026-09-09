import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Expression as OSWidgets$Expression, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Label as OSWidgets$Label, List as OSWidgets$List, Image as OSWidgets$Image, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$view.js";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model } from "@outsystems/runtime-core-js";
import { SE_size as ConectaProveedores_staticEntities_size, SE_color as ConectaProveedores_staticEntities_color, SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import OutSystemsUI_Utilities_ButtonLoading_mvc_view from "./OutSystemsUI.Utilities.ButtonLoading.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
name: "Header"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width9"
},
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display font-size-main-heading",
text: [$text(getTranslation("VW+_HRG_hES7kPFFiDGVCw#Value", "Multiple Invoices Upload"))],
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
style: "display font-size-main-heading",
value: ((" (" + (model.variables.filesListVar.length).toString()) + ")"),
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-auto",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopup$Action(false, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
})))), $if((model.variables.getSupplierDataAct.isDataFetchedAttr && model.variables.getInvoicesByRequisitionOrFolioDataAct.isDataFetchedAttr), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-l",
visible: true,
_idProps: {
service: idService,
name: "MainFiles"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FilesMaxSize: 20971520,
i_IsEnabled: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.customUploadOnFileChange$Action(fileIn, errorIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "9",
alias: "1"
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
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("dpWrL9kzFkGaVber04XaVA#ValueExpression.806138567.1", "Attach Main Files (zip/rar)"),
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.filesListVar.isEmpty, false, this, function () {
return [createElement(OSWidgets$Text, {
style: "text-neutral-9",
text: [$text(getTranslation("nN+PUmQSEkmIpAf09sJjNg#Value", "Click here or drag files to upload"))],
_idProps: {
service: idService,
uuid: "14"
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
uuid: "15"
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
uuid: "16"
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
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr), asPrimitiveValue(model.variables.filesListVar.getCurrent(callContext.iterationContext).errorMsgAttr)]
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Size: ConectaProveedores_staticEntities_size.small,
Color: model.getCachedValue(idService.getId("pxQvS670W06ak0IcqoXFdQ.Color"), function () {
return (((model.variables.filesListVar.getCurrent(callContext.iterationContext).errorMsgAttr === "")) ? (ConectaProveedores_staticEntities_color.neutral3) : (ConectaProveedores_staticEntities_color.red));
}, function () {
return model.variables.filesListVar.getCurrent(callContext.iterationContext).errorMsgAttr;
})
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
uuid: "18",
alias: "2"
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
uuid: "19"
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
i_Text: model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr,
i_NChar: 20
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
uuid: "20",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "21"
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
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}))))];
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
style: model.getCachedValue(idService.getId("Mgr8ruRQW0SO3LG+y7Pbyg.style"), function () {
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
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.filesListVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-l",
visible: true,
_idProps: {
service: idService,
name: "Actions"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: ((!(model.variables.isSavingVar)) && (!(model.variables.isExecutingVar))),
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopup$Action(false, controller.callContext(eventHandlerContext));

;
},
style: "btn btn-back",
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("yZWgFodK6EaKdq7yF+k_aA#Value", "Close"))), createElement(OSWidgets$Button, {
enabled: ((!(model.variables.isSavingVar)) && (!(model.variables.isExecutingVar))),
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.saveOnClick$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("LQegaZWshk2G4SRX5SLIuw#ValueExpression.2569629.1", "Save"),
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(!(model.variables.requisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-m",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_ButtonLoading_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "full-width",
IsLoading: model.variables.isExecutingVar,
ShowLabelOnLoading: true
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
uuid: "30",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
button: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: (!(model.variables.isSavingVar)),
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.saveOnClick$Action(true, controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-btn-loading__spinner-animation",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("SkOYgLAn8U+23SRY2oECNA.Value"), function () {
return ((((model.variables.invoiceStatusIdIn) !== (ConectaProveedores_staticEntities_invoiceStatus.modify))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ce42jtMwFUSE3Dqjx9TqxQ#ValueExpression.-1582438992.1", "Start approval process")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ce42jtMwFUSE3Dqjx9TqxQ#ValueExpression.1436936423.1", "Resubmit approval process")));
}, function () {
return model.variables.invoiceStatusIdIn;
}),
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._invoiceStatusIdInDataFetchStatus)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables._invoiceStatusIdInDataFetchStatus), asPrimitiveValue(model.variables.invoiceStatusIdIn), asPrimitiveValue(model.variables.isSavingVar)]
}))];
}, function () {
return [];
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_PopupInvoiceUploadMultiple",
functionKey: "a4e6e43c-4b6c-4c44-a9cd-5818a7300e2e",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_InvoicePopups.Wb_PopupInvoiceUploadMultiple",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, OutSystemsUI_Content_Tag_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, OutSystemsUI_Utilities_ButtonLoading_mvc_view];
};


return ELEM;
};

export default componentFactory()
