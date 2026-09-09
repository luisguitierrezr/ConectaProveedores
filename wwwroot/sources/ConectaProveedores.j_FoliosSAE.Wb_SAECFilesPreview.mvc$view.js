import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, List as OSWidgets$List, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup, Button as OSWidgets$Button, Text as OSWidgets$Text } from "@outsystems/runtime-widgets-js";
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
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SAECFilesPreview.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SAECFilesPreview.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((model.variables.getFolioFilesDataAct.isDataFetchedAttr && (!(model.variables.getFolioFilesDataAct.hasFetchErrorAttr))), false, this, function () {
return [$if(((((!(model.variables.getFolioFilesDataAct.folioMainFilesOut.isEmpty)) || (!(model.variables.getFolioFilesDataAct.folioExtraFilesOut.isEmpty))) || (!(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.isEmpty))) || (!(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.isEmpty))), false, this, function () {
return [$if(model.variables.getFolioFilesDataAct.isConstructionOut, false, this, function () {
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
FileJsonList: model.variables.getFolioFilesDataAct.filesForDownloadOut,
_fileJsonListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
ZipName: model.getCachedValue(idService.getId("iXv8jHZE4kqTW4LZco_oog.ZipName"), function () {
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
start$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadAllFolioFilesByFileListStart$Action(controller.callContext(eventHandlerContext));

;
},
end$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadAllFolioFilesByFileListEnd$Action(controller.callContext(eventHandlerContext));

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
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("JIet1FQtBUKfjxcWtyLNAg#Value", "Folio Files"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-container",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getFolioFilesDataAct.folioMainFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.length), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
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
uuid: "8",
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
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("kqhEHguu_0qEA8LktAjc8g.Style"), function () {
return ((((((model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden "));
}, function () {
return model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FileSize: model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "11",
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
uuid: "12"
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
uuid: "13",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(!(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FileSize: model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_Filename: model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "14",
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
return [$text(getTranslation("hDLjpBikzk2MMtDA+C1wSg#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr)]
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
uuid: "15",
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
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("pfZnABeXfE2ESr3k5fGS+w.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false));
}, function () {
return model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr) + "|") + model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr),
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr, false, this, function () {
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
uuid: "22",
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
uuid: "23"
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
uuid: "24"
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
uuid: "25",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("1FBpNykGd0WZ9IbtLN5aaA.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, (OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) - OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioFilesDataAct.folioMainFilesOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getFolioFilesDataAct.folioMainFilesOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "28"
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
uuid: "29",
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
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.getFolioFilesDataAct.folioExtraFilesOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dqo36tIznUOIkq2A7whtOg#Value", "Extra Files"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-container",
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getFolioFilesDataAct.folioExtraFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.length), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
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
uuid: "36",
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
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("lg9H4RAMG0eRjrd15mImWA.Style"), function () {
return ((((((model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden  "));
}, function () {
return model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "40"
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
uuid: "41",
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
i_StorageId: model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_Filename: model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "42",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("30HI1fNDOkCym0iYL1soFg#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr)]
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
uuid: "43",
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
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("PKm4Al_TWUKgVTYME+I2QA.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false));
}, function () {
return model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr) + "|") + model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr),
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1"
},
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr, false, this, function () {
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
uuid: "49",
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
uuid: "50"
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
uuid: "51"
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
uuid: "52",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("cGx86Q4HPUCvOgNRtbxlBA.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, (OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) - OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).isNewFileAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioFilesDataAct.folioExtraFilesOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getFolioFilesDataAct.folioExtraFilesOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "55"
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
uuid: "56",
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
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)]
})))];
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
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "58"
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
ZipName: model.getCachedValue(idService.getId("i9HucPWaKkm2CQ1VvgdG4g.ZipName"), function () {
return (((model.variables.i_FolioNumberIn + "-") + OS$BuiltinFunctions.dateToText(OS$BuiltinFunctions.currDate())) + ".zip");
}, function () {
return model.variables.i_FolioNumberIn;
}),
_zipNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FolioNumberInDataFetchStatus),
FileJsonList: model.variables.getFolioFilesDataAct.filesForDownloadOut,
_fileJsonListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "59",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("rD9Pm0lrhkGpluZw8zwb3w#Value", "Folio Files"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-container",
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getFolioFilesDataAct.invoiceMainFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.length), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
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
uuid: "65",
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
style: model.getCachedValue(idService.getId("Svq0cb3b9Emyw5HFRhO03w.Style"), function () {
return ((((((model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden "));
}, function () {
return model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "67",
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
uuid: "68"
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
uuid: "69",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(!(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FileSize: model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_Filename: model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "70",
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
return [$text(getTranslation("8RsowsMfG0C40g3lsQn_hg#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr)]
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
uuid: "71",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("aZzsKHtgsEyX4XLkBEMz9w.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false));
}, function () {
return model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr) + "|") + model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr),
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "75"
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
uuid: "76",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("waWgki7FtESFhMr1UKCuLQ.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, (OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) - OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getFolioFilesDataAct.folioMainFilesOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "79"
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
uuid: "80",
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
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.folioMainFilesOut.length), asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(true, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("HbY65them0Cmk7EVW9vokQ#Value", "Extra Files"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-container",
visible: true,
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Popup, {
showPopup: model.variables.l_ShowPopupUploadVar,
style: "popup-dialog",
_idProps: {
service: idService,
uuid: "85"
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
i_Valid: model.getCachedValue(idService.getId("hWLMEm1RYUaoYexZeZ2hPw.i_Valid"), function () {
return function () {
var rec = new ST_b453bea0930035904f55a74692afd3a8Structure();
rec.isValidAttr = true;
rec.validationMessageAttr = "";
return rec;
}();
}),
i_Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("YpnicQ1tk0+nB3UuA5JvWQ#Value.911285081.1", "Upload Documents"),
i_FilesMaxSize: 20971520,
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Y0DCh7mRnE6qddEWKroTnw#Value.665136725.1", "New Extra File Upload"),
i_IsMandatory: true,
i_File: model.variables.l_FileVar
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
uuid: "86",
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
uuid: "87"
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
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("aIsXdH5_u0WG5ACK9zBfgA#Value", "Cancel"))))), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getFolioFilesDataAct.invoiceExtraFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.length), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
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
uuid: "91",
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
style: model.getCachedValue(idService.getId("QgGiWdn9uUWJhYiIVsg47A.Style"), function () {
return ((((((model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden  "));
}, function () {
return model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "93",
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
uuid: "94"
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
uuid: "95",
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
i_Filename: model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "96",
alias: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("aqla7Kr6SkWSIMDlYLVlog#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
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
uuid: "97",
alias: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("woc2xv24vkijWQZ_hOyV7Q.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false));
}, function () {
return model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr) + "|") + model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr),
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "101"
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
uuid: "102",
alias: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("dPvlh1m3VUav23Y+_BWIVw.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, (OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr) - OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioFilesDataAct.invoiceExtraFilesOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getFolioFilesDataAct.folioExtraFilesOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "105"
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
uuid: "106",
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
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.folioExtraFilesOut.length), asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)]
})))];
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
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("c+Ij4NavckqZQy3MOcpZTA#Value", "No files were found in this folio."))],
_idProps: {
service: idService,
uuid: "108"
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
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_SAECFilesPreview",
functionKey: "62f23bd9-ea4f-4e57-b7e0-0b8cc2ee1559",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_SAECFilesPreview",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_SAECFilesPreview.css"];
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
