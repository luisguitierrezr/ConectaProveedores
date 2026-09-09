import { withBaseWebBlock, ifWidget as $if, asPrimitiveValue, Widget, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, List as OSWidgets$List, Expression as OSWidgets$Expression, Link as OSWidgets$Link, Image as OSWidgets$Image, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_mvc_view from "./ConectaProveedores.e_OrdersRequestFiles.wb_RejectReason.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.mvc$view.js";
import ConectaProveedores_e_Orders_Wb_OrderFilesPreview_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrderFilesPreview.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_mvc_view from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFile.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementRequestedFiles.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementRequestedFiles.mvc$controller.js";

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
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getOrderRequestFilesDataAct.requestFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "request-files-box display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isApprovedAttr), asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).needsApprovalAttr), asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).invoiceIdAttr), asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).idAttr), asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isRejectedAttr), asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).descriptionAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width5"
},
style: "request-files-title",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).descriptionAttr,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr)
})), $if(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isRejectedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderRequestFilesId: model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).idAttr,
_orderRequestFilesIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr)
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
uuid: "7",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((!(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).invoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) && !(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).invoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))), false, this, function () {
return [createElement(ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InvoiceId: model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).invoiceIdAttr,
_invoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr)
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
uuid: "9",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
}), $if(((!(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).invoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) && !(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))), false, this, function () {
return [createElement(ConectaProveedores_e_Orders_Wb_OrderFilesPreview_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderRequestFileId: model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).idAttr,
_orderRequestFileIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr)
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
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).needsApprovalAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.getCachedValue(idService.getId("CnWtwwynnE66jSKOhmDE8A.i_Class"), function () {
return ((((model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isApprovedAttr === false) && (model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isRejectedAttr === false))) ? ("inapproval") : (((model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isApprovedAttr) ? ("approved") : ("rejected"))));
}, function () {
return model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isApprovedAttr;
}, function () {
return model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isRejectedAttr;
}),
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr),
i_Text: model.getCachedValue(idService.getId("CnWtwwynnE66jSKOhmDE8A.i_Text"), function () {
return ((((!(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isApprovedAttr)) && (model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isRejectedAttr === false))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vXDlNUwZbkKMkS0lAqF5ZQ#Value.1070808798.1", "In Approval")) : (((model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isApprovedAttr) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vXDlNUwZbkKMkS0lAqF5ZQ#Value.1249888983.1", "Approved")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vXDlNUwZbkKMkS0lAqF5ZQ#Value.-543852386.1", "Rejected")))));
}, function () {
return model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isApprovedAttr;
}, function () {
return model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isRejectedAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr)
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
uuid: "13",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).invoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) && model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).isRejectedAttr), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openPopup$Action(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_subir.svg"),
style: "img img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr)]
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "width: 700px; padding: var(--space-base);"
},
showPopup: model.variables.showPopupVar,
style: "xl-popup popup-dialog card",
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "19"
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
uuid: "20",
alias: "5"
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
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("RVKIn7CVz02c0hYM2owIsg#Value", "Upload documents"))), createElement(OSWidgets$Container, {
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
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderMainId: model.variables.i_OrderIdIn,
_orderMainIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_OrderIdInDataFetchStatus),
i_RequestFileId: model.variables.l_RequestFileIdVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
cancel$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopup$Action(controller.callContext(eventHandlerContext));

;
},
update$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refresh$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "26",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_UploadComplementRequestedFiles",
functionKey: "10c26c83-5658-470c-9fab-48124bb2be29",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_OrdersRequestFiles.Wb_UploadComplementRequestedFiles",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementRequestedFiles.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_mvc_view, ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view, ConectaProveedores_e_Orders_Wb_OrderFilesPreview_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_mvc_view];
};


return ELEM;
};

export default componentFactory()
