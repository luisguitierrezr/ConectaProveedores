import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { Container as OSWidgets$Container, List as OSWidgets$List, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup, Button as OSWidgets$Button, Text as OSWidgets$Text } from "@outsystems/runtime-widgets-js";
import ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvc_view from "./ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByFileList.mvc$view.js";
import { createElement } from "react";
import OutSystemsUI_Adaptive_ColumnsSmallLeft_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallLeft.mvc$view.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$view.js";
import { SE_position as ConectaProveedores_staticEntities_position, SE_color as ConectaProveedores_staticEntities_color, SE_space as ConectaProveedores_staticEntities_space } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$view.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import { ST_b453bea0930035904f55a74692afd3a8Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioFilesPreview.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioFilesPreview.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((model.variables.getFolioFiles2DataAct.isDataFetchedAttr && (!(model.variables.getFolioFiles2DataAct.hasFetchErrorAttr))), false, this, function () {
return [$if(((((!(model.variables.getFolioFiles2DataAct.folioMainFilesOut.isEmpty)) || (!(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.isEmpty))) || (!(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.isEmpty))) || (!(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.isEmpty))), false, this, function () {
return [$if(model.variables.getFolioFiles2DataAct.isConstructionOut, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "min-height-71vh",
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
}, createElement(ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ZipName: model.getCachedValue(idService.getId("vNtS8wsebkCwLO1eL5IoDg.ZipName"), function () {
return (((model.variables.i_FolioNumberIn + "-") + OS$BuiltinFunctions.dateToText(OS$BuiltinFunctions.currDate())) + ".zip");
}, function () {
return model.variables.i_FolioNumberIn;
}),
_zipNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FolioNumberInDataFetchStatus),
FileJsonList: model.variables.getFolioFiles2DataAct.filesForDownloadOut,
_fileJsonListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
end$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadAllFolioFilesByFileListEnd$Action(controller.callContext(eventHandlerContext));

;
},
start$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadAllFolioFilesByFileListStart$Action(controller.callContext(eventHandlerContext));

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
}, $text(getTranslation("A1YdnqZ6n0GdPyd_rb3_+g#Value", "Folio Files"))), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getFolioFiles2DataAct.folioMainFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
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
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.length), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}, createElement(OutSystemsUI_Adaptive_ColumnsSmallLeft_mvc_view, {
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
uuid: "7",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
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
style: model.getCachedValue(idService.getId("LVTN9prLREGPOhXjDRCQFw.Style"), function () {
return ((((((model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden "));
}, function () {
return model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
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
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(!(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Filename: model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
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
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("M6HgEUEY1kuG0LhD3+68Ag#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr)]
})))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
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
uuid: "14",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("h1YKA5e6dUu24Gzb36yCSg.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false));
}, function () {
return model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 10px; text-align: left;"
},
style: "margin-bottom-s text-cyan",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr) + "|") + model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr),
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr, false, this, function () {
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
uuid: "21",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #ffc401;"
},
icon: "star",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return ["Nuevo archivo"];
})
},
_dependencies: []
})];
}, function () {
return [];
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "23"
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
uuid: "24",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("L_UonMdeJU+KxLB9UqwkoQ.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, (OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) - OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioFiles2DataAct.folioMainFilesOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getFolioFiles2DataAct.folioMainFilesOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "27"
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
uuid: "28",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "bold subtitle-line text-neutral-8",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("kiQH3ig4vES0ZMXEb84AkQ#Value", "Extra Files")), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: (("(" + (model.variables.getFolioFiles2DataAct.folioExtraFilesOut.length).toString()) + ")"),
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getFolioFiles2DataAct.folioExtraFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.length), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}, createElement(OutSystemsUI_Adaptive_ColumnsSmallLeft_mvc_view, {
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
uuid: "34",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("FPltahj7rkix7T5evnPUsg.Style"), function () {
return ((((((model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden  "));
}, function () {
return model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
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
uuid: "37",
alias: "11"
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
uuid: "38"
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
uuid: "39",
alias: "12"
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
i_Filename: model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
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
uuid: "40",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("vEyq2QwfiUW1JXtQWopJxw#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
})))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
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
uuid: "41",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("C_jsWB8mx0eTRjClGsQYmQ.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false));
}, function () {
return model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 10px; text-align: left;"
},
style: "margin-bottom-s text-cyan",
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr) + "|") + model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr),
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1"
},
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr, false, this, function () {
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
uuid: "47",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #ffc401;"
},
icon: "star",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return ["Nuevo archivo"];
})
},
_dependencies: []
})];
}, function () {
return [];
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "49"
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
Color: ConectaProveedores_staticEntities_color.neutral6
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
uuid: "50",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("zCHgKSdoe06AWYd7S6_ngQ.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, (OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) - OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioFiles2DataAct.folioExtraFilesOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getFolioFiles2DataAct.folioExtraFilesOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "53"
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
uuid: "54",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})))];
}, callContext, idService, "2")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)]
})];
}, function () {
return [];
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "min-height-71vh",
visible: true,
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
FileJsonList: model.variables.getFolioFiles2DataAct.filesForDownloadOut,
_fileJsonListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
ZipName: model.getCachedValue(idService.getId("SzTasQpKXUuAL3ric1AZYg.ZipName"), function () {
return (((model.variables.i_FolioNumberIn + "-") + OS$BuiltinFunctions.dateToText(OS$BuiltinFunctions.currDate())) + ".zip");
}, function () {
return model.variables.i_FolioNumberIn;
}),
_zipNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FolioNumberInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
end$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadAllFolioFilesByFileListEnd$Action(controller.callContext(eventHandlerContext));

;
},
start$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadAllFolioFilesByFileListStart$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "57",
alias: "18"
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
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "bold subtitle-line text-neutral-8",
visible: true,
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("37eEhnG5bEOE4AAMJOUc+Q#Value", "Folio Files"))), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getFolioFiles2DataAct.invoiceMainFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.length), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}, createElement(OutSystemsUI_Adaptive_ColumnsSmallLeft_mvc_view, {
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
uuid: "62",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("Emf5PTE2tkGpy3HHKn0wDw.Style"), function () {
return ((((((model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden "));
}, function () {
return model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FileSize: model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
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
uuid: "64",
alias: "20"
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
uuid: "65"
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
uuid: "66",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(!(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Filename: model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
start$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileStart$Action(controller.callContext(eventHandlerContext));

;
},
end$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileEnd$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "67",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("xLmwEdyel0uVSRKhJw4E_w#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr)]
}), " ")];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
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
uuid: "68",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("5EoTbRIcbUy1oKlz2my7Ow.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false));
}, function () {
return model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 10px; text-align: left;"
},
style: "margin-bottom-s text-cyan",
visible: true,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr) + "|") + model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr),
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "72"
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
uuid: "73",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Inw7QXaKhkeycgEcXvWNZg.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, (OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) - OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioFiles2DataAct.invoiceMainFilesOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getFolioFiles2DataAct.folioMainFilesOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "76"
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
uuid: "77",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})))];
}, callContext, idService, "3")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioMainFilesOut.length), asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(true, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "bold subtitle-line text-neutral-8",
visible: true,
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+D1iO8zTqkmC5W+gcuUB9A#Value", "Extra Files")), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: (("(" + (model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.length).toString()) + ")"),
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(false, false, this, function () {
return [];
}, function () {
return [];
})), createElement(OSWidgets$Popup, {
showPopup: model.variables.l_ShowPopupUploadVar,
style: "popup-dialog",
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsEnabled: true,
i_Valid: model.getCachedValue(idService.getId("O+m8XqxLCkqs1FhPC1qc5Q.i_Valid"), function () {
return function () {
var rec = new ST_b453bea0930035904f55a74692afd3a8Structure();
rec.isValidAttr = true;
rec.validationMessageAttr = "";
return rec;
}();
}),
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("CxqTIey35kyRjY42h+HPQw#Value.665136725.1", "New Extra File Upload"),
i_Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Bd54Kabe6UiTmhw4Xrny2g#Value.911285081.1", "Upload Documents"),
i_IsMandatory: true,
i_File: model.variables.l_FileVar,
i_FilesMaxSize: 20971520
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomFileUploadOnDelete$Action(controller.callContext(eventHandlerContext));

;
},
onDropFile$Action: function (fileIn, errorIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_CustomFileUploadOnDropFile$Action(fileIn, errorIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "83",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.cancelOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("03XbqXvLxEysK7rTE8mApg#Value", "Cancel"))))), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.length), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}, createElement(OutSystemsUI_Adaptive_ColumnsSmallLeft_mvc_view, {
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
uuid: "88",
alias: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("oGXZap1LvUayVS4WaxScBA.Style"), function () {
return ((((((model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden  "));
}, function () {
return model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FileSize: model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
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
uuid: "90",
alias: "28"
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
uuid: "91"
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
uuid: "92",
alias: "29"
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
i_FileSize: model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr),
i_Filename: model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
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
uuid: "93",
alias: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("6rZRfRgWXEOr9wBWLSChjA#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr)]
})), $if(false, false, this, function () {
return [];
}, function () {
return [];
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
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
uuid: "94",
alias: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Lsq_0UR5vkOVntwPWMUb3g.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false));
}, function () {
return model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 10px; text-align: left;"
},
style: "margin-bottom-s text-cyan",
visible: true,
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr) + "|") + model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr),
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "98"
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
Color: ConectaProveedores_staticEntities_color.neutral6
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
uuid: "99",
alias: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("qVSmPu3q2kq4G4pn7PUwsg.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, (OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) - OS$BuiltinFunctions.index(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioFiles2DataAct.invoiceExtraFilesOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getFolioFiles2DataAct.folioExtraFilesOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "102"
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
uuid: "103",
alias: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})))];
}, callContext, idService, "4")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFiles2DataAct.folioExtraFilesOut.length), asPrimitiveValue(model.variables.getFolioFiles2DataAct.dataFetchStatusAttr)]
})];
}, function () {
return [];
})))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("ypq7yOQsikmDx2Mpb1HWXA#Value", "No files were found in this folio."))],
_idProps: {
service: idService,
uuid: "105"
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
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_FolioFilesPreview",
functionKey: "3f029929-8e37-4eac-9c88-8f5ee0eb5e23",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_FolioFilesPreview",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_FolioFilesPreview.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallLeft_mvc_view, ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, OutSystemsUI_Content_Tag_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view, ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view];
};


return ELEM;
};

export default componentFactory()
