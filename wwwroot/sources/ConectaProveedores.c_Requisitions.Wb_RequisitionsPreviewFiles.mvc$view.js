import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Image as OSWidgets$Image, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$view.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_FilesList_mvc_view from "./ConectaProveedores.y_Utils.Wb_FilesList.mvc$view.js";
import ModelFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewFiles.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewFiles.mvc$controller.js";

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
style: "overflow-vertical max-height-70vh min-height-30vh",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getFilesByRequisitionIdDataAct.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getFilesByRequisitionIdDataAct.filesPDFOut.isEmpty, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 20px;"
},
style: "display",
text: [$text(getTranslation("vi3ljZcmi06tM_ebZgxTbw#Value", "PDF Files"))],
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 16px; margin-top: 5px;"
},
gridProperties: {
classes: "ThemeGrid_Width1"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
gridProperties: {
width: "30px"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_pdf.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$TableRecords, {
extendedProperties: {
style: "margin-top: 10px;"
},
showHeader: true,
source: model.variables.getFilesByRequisitionIdDataAct.filesPDFOut,
style: "table scrollable-area-content",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "Filename",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("XYCFh3DolES6bUlldetL+g#Value", "Filename"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.filesPDFOut.getCurrent(callContext.iterationContext).filenameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getFilesByRequisitionIdDataAct.filesPDFOut.getCurrent(callContext.iterationContext).filenameAttr,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.filesPDFOut.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.filesPDFOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.filesPDFOut.getCurrent(callContext.iterationContext).storageIdAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ExtendedClass: "margin-right-s padding-top-xs",
i_StorageId: model.variables.getFilesByRequisitionIdDataAct.filesPDFOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
i_TagText: "pdf",
i_IsTagStyle: false,
i_FileSize: model.variables.getFilesByRequisitionIdDataAct.filesPDFOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr)
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
uuid: "14",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FileSize: model.variables.getFilesByRequisitionIdDataAct.filesPDFOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFilesByRequisitionIdDataAct.filesPDFOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
i_Filename: model.variables.getFilesByRequisitionIdDataAct.filesPDFOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr)
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
uuid: "15",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr)]
}))];
}), $if(model.variables.getFilesByRequisitionIdDataAct.filesXMLOut.isEmpty, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
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
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 20px;"
},
style: "display",
text: [$text(getTranslation("8dR5QlqQkEeIrbq5VXkL_Q#Value", "XML Files"))],
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 5px;"
},
gridProperties: {
classes: "ThemeGrid_Width1"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 32px; height: 30px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_xml.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$TableRecords, {
extendedProperties: {
style: "margin-top: 10px;"
},
showHeader: true,
source: model.variables.getFilesByRequisitionIdDataAct.filesXMLOut,
style: "table scrollable-list-with-scroll",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "Filename",
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("maPtm6fO2UGqNHfPLpSkgw#Value", "Filename"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.filesXMLOut.getCurrent(callContext.iterationContext).filenameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getFilesByRequisitionIdDataAct.filesXMLOut.getCurrent(callContext.iterationContext).filenameAttr,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.filesXMLOut.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.filesXMLOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.filesXMLOut.getCurrent(callContext.iterationContext).storageIdAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ExtendedClass: "margin-right-s padding-top-xs",
i_IsTagStyle: false,
i_StorageId: model.variables.getFilesByRequisitionIdDataAct.filesXMLOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFilesByRequisitionIdDataAct.filesXMLOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
i_TagText: "xml"
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
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Filename: model.variables.getFilesByRequisitionIdDataAct.filesXMLOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFilesByRequisitionIdDataAct.filesXMLOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFilesByRequisitionIdDataAct.filesXMLOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr)
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
uuid: "30",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr)]
}))];
}), $if(model.variables.getFilesByRequisitionIdDataAct.otherFilesOut.isEmpty, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 20px;"
},
style: "display",
text: [$text(getTranslation("ikMYWJqP6UCZXwZgZzX_lA#Value", "Other Files"))],
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 5px;"
},
gridProperties: {
classes: "ThemeGrid_Width1"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 32px; height: 30px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_file_detail.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$TableRecords, {
extendedProperties: {
style: "margin-top: 10px;"
},
showHeader: true,
source: model.variables.getFilesByRequisitionIdDataAct.otherFilesOut,
style: "table scrollable-list-with-scroll",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "Filename",
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("igfbQftaFEqtSNhZnXXMwA#Value", "Filename"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.otherFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getFilesByRequisitionIdDataAct.otherFilesOut.getCurrent(callContext.iterationContext).filenameAttr,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.otherFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.otherFilesOut.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.otherFilesOut.getCurrent(callContext.iterationContext).storageIdAttr)]
}, createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getFilesByRequisitionIdDataAct.otherFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
i_Filename: model.variables.getFilesByRequisitionIdDataAct.otherFilesOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFilesByRequisitionIdDataAct.otherFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr)
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
uuid: "43",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, callContext, idService, "3_0")
},
_dependencies: [asPrimitiveValue(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr)]
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
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_IsOpenPopupOtherFilesVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_FilesList_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StorageFileList: model.variables.getFilesByRequisitionIdDataAct.otherFilesOut,
_storageFileListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFilesByRequisitionIdDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onClose$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopupOtherFiles$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "46",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_RequisitionsPreviewFiles",
functionKey: "6bd1cb32-f87a-43b9-9fb2-23b3af1d29d8",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Requisitions.Wb_RequisitionsPreviewFiles",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewFiles.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, ConectaProveedores_y_Utils_Wb_FilesList_mvc_view];
};


return ELEM;
};

export default componentFactory()
