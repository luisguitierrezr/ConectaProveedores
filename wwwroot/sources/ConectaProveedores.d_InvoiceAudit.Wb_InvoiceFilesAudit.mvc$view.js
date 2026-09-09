import { withBaseWebBlock, Widget, textWidget as $text, getTranslation, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { List as OSWidgets$List, Container as OSWidgets$Container, Checkbox as OSWidgets$Checkbox, Expression as OSWidgets$Expression, Text as OSWidgets$Text } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$view.js";
import { SE_position as ConectaProveedores_staticEntities_position, SE_color as ConectaProveedores_staticEntities_color, SE_space as ConectaProveedores_staticEntities_space } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$view.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesAudit.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesAudit.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((model.variables.invoiceFilesByIdAggr.isDataFetchedAttr && (!(model.variables.invoiceFilesByIdAggr.hasFetchErrorAttr))), false, this, function () {
return [$if((!(model.variables.invoiceFilesByIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.invoiceFilesByIdAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.invoiceFilesByIdAggr.listOut.length), asPrimitiveValue(model.variables.invoiceFilesByIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr), asPrimitiveValue(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr), asPrimitiveValue(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr), asPrimitiveValue(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-right-m",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr, function (value) {
model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox1"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("U2V3Bczw2Ei3+q3aeCC+rA.Style"), function () {
return ((((((model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden "));
}, function () {
return model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FileSize: model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr),
i_StorageId: model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr)
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
uuid: "8"
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
uuid: "9",
alias: "2"
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
i_StorageId: model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr),
i_Filename: model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr),
i_FileSize: model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr)
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
uuid: "10",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("z8ykhvM3+EyiCDN1NxbcIQ#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr), asPrimitiveValue(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr), asPrimitiveValue(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr)]
})), createElement(OSWidgets$Expression, {
style: "margin-left-s",
value: model.getCachedValue(idService.getId("o+ZqycnQp0G53jHPLs6WoQ.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, ".", 0, false, false));
}, function () {
return model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr;
}),
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "12"
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
uuid: "13",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("6UP0_i1Us0im8VH0THsnTQ.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, (OS$BuiltinFunctions.index(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr) - OS$BuiltinFunctions.index(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr;
}),
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.invoiceFilesByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.invoiceFilesByIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.invoiceFilesByIdAggr.listOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "16"
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
uuid: "17",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr)]
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("AZ8R+Pbxo0is6hTJlcG6lg#Value", "No files were found in this invoice."))],
_idProps: {
service: idService,
uuid: "19"
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
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_InvoiceFilesAudit",
functionKey: "aba29213-a917-4cfe-8f17-a1bbd2f3290f",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_InvoiceAudit.Wb_InvoiceFilesAudit",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesAudit.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, OutSystemsUI_Content_Tag_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view];
};


return ELEM;
};

export default componentFactory()
