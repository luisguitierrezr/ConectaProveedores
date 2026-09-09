import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { Container as OSWidgets$Container, List as OSWidgets$List, Expression as OSWidgets$Expression, Text as OSWidgets$Text } from "@outsystems/runtime-widgets-js";
import ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_mvc_view from "./ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByInvoiceId.mvc$view.js";
import { createElement } from "react";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$view.js";
import { SE_position as ConectaProveedores_staticEntities_position, SE_color as ConectaProveedores_staticEntities_color, SE_space as ConectaProveedores_staticEntities_space } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$view.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsFiles.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsFiles.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((model.variables.getInvoiceFilesDataAct.isDataFetchedAttr && (!(model.variables.getInvoiceFilesDataAct.hasFetchErrorAttr))), false, this, function () {
return [$if((!(model.variables.getInvoiceFilesDataAct.mainFilesOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card min-height-71vh",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ZipName: model.getCachedValue(idService.getId("dTVXQECSOE+Ps0X5eepldw.ZipName"), function () {
return (((model.variables.i_InvoiceNameIn + "-") + OS$BuiltinFunctions.dateToText(OS$BuiltinFunctions.currDate())) + ".zip");
}, function () {
return model.variables.i_InvoiceNameIn;
}),
_zipNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_InvoiceNameInDataFetchStatus),
InvoiceId: model.variables.i_InvoiceIdIn,
_invoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_InvoiceIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
start$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadAllFolioFilesStart$Action(controller.callContext(eventHandlerContext));

;
},
end$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadAllFolioFilesEnd$Action(controller.callContext(eventHandlerContext));

;
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
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "bold subtitle-line text-neutral-8",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jskkHQSmVUCiis_ePQxvpw#Value", "Invoice Files"))), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getInvoiceFilesDataAct.mainFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.mainFilesOut.length), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).storageAttr.idAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("rOkeVuzrakaZk4f_PEQLgA.Style"), function () {
return ((((((model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden "));
}, function () {
return model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).storageAttr.idAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
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
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
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
uuid: "12",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_Filename: model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
end$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileEnd$Action(controller.callContext(eventHandlerContext));

;
},
start$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileStart$Action(controller.callContext(eventHandlerContext));

;
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
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("tEwLrYlmk0uhk31waoCCXA#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr)]
})), createElement(OSWidgets$Expression, {
style: "margin-left-s",
value: model.getCachedValue(idService.getId("NM9hvb5mnkaN9qtiyUTXeA.Value"), function () {
return OS$BuiltinFunctions.substr(OS$BuiltinFunctions.substr(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, ".", 0, false, false)), 0, 20);
}, function () {
return model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr;
}),
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.secondary
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
uuid: "16",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("lVBAjjtxK0CVJGtomWizGw.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, (OS$BuiltinFunctions.index(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr) - OS$BuiltinFunctions.index(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr;
}),
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getInvoiceFilesDataAct.mainFilesOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getInvoiceFilesDataAct.mainFilesOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Space: ConectaProveedores_staticEntities_space.base
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
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.getInvoiceFilesDataAct.extraFilesOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "bold subtitle-line text-neutral-8",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("l8e7WmsFrEGGCuCzM_ydNA#Value", "Extra Files"))), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getInvoiceFilesDataAct.extraFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.extraFilesOut.length), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("9K+ggvcEZEi415pkSNEPqg.Style"), function () {
return ((((((model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden  "));
}, function () {
return model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
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
uuid: "28",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
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
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FileSize: model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_Filename: model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
end$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileEnd$Action(controller.callContext(eventHandlerContext));

;
},
start$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileStart$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "31",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("xK32PAsBG06ANN9_+vutLQ#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr)]
})), createElement(OSWidgets$Expression, {
style: "margin-left-s",
value: model.getCachedValue(idService.getId("YaCLgqtF80iGYiQbbOOGuw.Value"), function () {
return OS$BuiltinFunctions.substr(OS$BuiltinFunctions.substr(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, ".", 0, false, false)), 0, 20);
}, function () {
return model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr;
}),
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.secondary
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
uuid: "34",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("sqK+pwCtx02vUQco7JX8VA.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, (OS$BuiltinFunctions.index(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr) - OS$BuiltinFunctions.index(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr;
}),
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getInvoiceFilesDataAct.extraFilesOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getInvoiceFilesDataAct.extraFilesOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Space: ConectaProveedores_staticEntities_space.base
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
uuid: "38",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})))];
}, callContext, idService, "2")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)]
})];
}, function () {
return [];
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center card",
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("eYz9pFQ8y0qb8dBMXKS7zA#Value", "No files were found in this invoice."))],
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_InvoiceDetailsFiles",
functionKey: "bab64e23-2525-431a-bd26-36b175632d84",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_InvoiceDetailsFiles",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.d_Invoices.Wb_InvoiceDetailsFiles.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_mvc_view, ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, OutSystemsUI_Content_Tag_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view];
};


return ELEM;
};

export default componentFactory()
