import { withBaseWebBlock, ifWidget as $if, textWidget as $text, getTranslation, Widget, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model } from "@outsystems/runtime-core-js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$view.js";
import { createElement } from "react";
import { SE_position as ConectaProveedores_staticEntities_position, SE_color as ConectaProveedores_staticEntities_color } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_FilesList_mvc_view from "./ConectaProveedores.y_Utils.Wb_FilesList.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(model.variables.getInvoiceFilesDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(!(model.variables.getInvoiceFilesDataAct.fileXMLOut.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsTagStyle: true,
i_FileSize: model.variables.getInvoiceFilesDataAct.fileSizeXMLOut,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_TagText: "xml",
i_ExtendedClass: "margin-right-s",
i_StorageId: model.variables.getInvoiceFilesDataAct.fileXMLOut,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
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
uuid: "1",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
}), $if(!(model.variables.getInvoiceFilesDataAct.filePDFOut.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsTagStyle: true,
i_StorageId: model.variables.getInvoiceFilesDataAct.filePDFOut,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getInvoiceFilesDataAct.fileSizePDFOut,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr),
i_TagText: "pdf",
i_ExtendedClass: "margin-right-s"
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
uuid: "2",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
}), $if((!(model.variables.getInvoiceFilesDataAct.otherFilesOut.isEmpty)), false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "3",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopupOtherFiles$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "4"
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
ExtendedClass: "border-radius-16px",
Color: ConectaProveedores_staticEntities_color.neutral7
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
uuid: "5",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("RUVtKODHMEaMfPyzCkzFag#Value", "others"))];
})
},
_dependencies: []
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("uU2ayF6vJkKelNsbhIS1SQ#Value", "Other files"))];
})
},
_dependencies: []
})];
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
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), $if(false, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.isOpenPopupOtherFilesVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "7"
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
StorageFileList: model.variables.getInvoiceFilesDataAct.otherFilesOut,
_storageFileListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr)
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
uuid: "8",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_InvoicesFilesPreview",
functionKey: "8c6c0f95-7fae-42e8-8efb-4c65eef5fefd",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_InvoicesFilesPreview",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Content_Tag_mvc_view, ConectaProveedores_y_Utils_Wb_FilesList_mvc_view];
};


return ELEM;
};

export default componentFactory()
