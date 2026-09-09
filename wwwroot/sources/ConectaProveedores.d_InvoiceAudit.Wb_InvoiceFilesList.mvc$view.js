import { withBaseWebBlock, textWidget as $text, getTranslation, asPrimitiveValue, Widget, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, Checkbox as OSWidgets$Checkbox, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_mvc_view from "./ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByInvoiceId.mvc$view.js";
import { createElement } from "react";
import { SE_color as ConectaProveedores_staticEntities_color, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesList.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesList.mvc$controller.js";

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
name: "IsTableLoadingOrEmpty"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceFilesDataAct.isDataFetchedAttr, false, this, function () {
return [$if((!(model.variables.getInvoiceFilesDataAct.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-base",
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
ButtonName: model.getCachedValue(idService.getId("JhEj8V2PrkW5qKmiSA2oIA.ButtonName"), function () {
return ((model.variables.isAllSelectedVar) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("EZ5iBHSQ_02uHVVUa2qMFQ#Value.1271832105.1", "Download all")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("EZ5iBHSQ_02uHVVUa2qMFQ#Value.-1444781293.1", "Download selected")));
}, function () {
return model.variables.isAllSelectedVar;
}),
ZipName: model.getCachedValue(idService.getId("JhEj8V2PrkW5qKmiSA2oIA.ZipName"), function () {
return (((model.variables.invoiceNameIn + "-") + OS$BuiltinFunctions.dateToText(OS$BuiltinFunctions.currDate())) + ".zip");
}, function () {
return model.variables.invoiceNameIn;
}),
_zipNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._invoiceNameInDataFetchStatus),
InvoiceId: model.variables.invoiceIdIn,
_invoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._invoiceIdInDataFetchStatus)
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
uuid: "2",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: ((model.variables.getInvoiceFilesDataAct.listOut.length).toString() + " "),
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
}), $text(getTranslation("hWS9ubGuak6Vy0gUDjeVBg#Value", "files were found"))), createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getInvoiceFilesDataAct.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.isAllSelectedVar)]
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.checkboxTopOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.isAllSelectedVar, function (value) {
model.variables.isAllSelectedVar = value;
}),
_idProps: {
service: idService,
name: "Checkbox2"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Filename",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Ub4_mFl+20qsFlwH5zDNvA#Value", "Filename"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Hw0rls5JcEKH8PqU3Qv11w#Value", "Filetype"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "UserName",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("acwZeJem_ES0Cv2gfJndng#Value", "Created By"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "CreatedOn",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("JBo5vVRJM0eTvnCalFm4Hw#Value", "Created On"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).isSelectedAttr)]
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.checkboxOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).isSelectedAttr, function (value) {
model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).isSelectedAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox1"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).isExtraAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr)]
}, createElement(OSWidgets$Expression, {
style: model.getCachedValue(idService.getId("qcGPbuEsdUy+xKyYyr8DGA.Style"), function () {
return (((!(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).isExtraAttr))) ? (" bold") : (""));
}, function () {
return model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).isExtraAttr;
}),
value: model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "17"
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
uuid: "18",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("TIvfsbqCGUqaos0MYJyrrw.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr, (OS$BuiltinFunctions.index(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr) - OS$BuiltinFunctions.index(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).userNameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).userNameAttr,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).createdOnAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("CfgqjgYKA0apLpIDXGVwvg.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).createdOnAttr, "d MMM yyyy HH:mm");
}, function () {
return model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).storageSizeAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr)]
}, $if((((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr), ".pdf", 0, false, false)) !== ((-1))) || ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr), ".xml", 0, false, false)) !== ((-1)))), false, this, function () {
return [createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).storageSizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_ExtendedClass: "margin-right-base"
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
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
}), createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "26",
alias: "4"
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
i_Filename: model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).storageSizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
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
uuid: "27",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("hxMGC74bFU+66ssfVtnBSg#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).storageSizeAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.listOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.isAllSelectedVar)]
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("qPxMvB5QcECY3+H+T44s_w#Value", "No files to show...")))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_InvoiceFilesList",
functionKey: "feea1c84-f825-435d-9702-41c67009b340",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_InvoiceAudit.Wb_InvoiceFilesList",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesList.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_mvc_view, OutSystemsUI_Content_Tag_mvc_view, ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view];
};


return ELEM;
};

export default componentFactory()
