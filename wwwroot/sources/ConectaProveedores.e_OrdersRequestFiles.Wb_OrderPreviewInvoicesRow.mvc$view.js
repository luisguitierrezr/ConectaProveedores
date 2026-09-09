import { withBaseWebBlock, asPrimitiveValue, Widget, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { List as OSWidgets$List, Container as OSWidgets$Container, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedores_e_OrdersRequestFiles_Wb_OrderFilePreviewDownload_mvc_view from "./ConectaProveedores.e_OrdersRequestFiles.Wb_OrderFilePreviewDownload.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_OrdersRequestFiles.Wb_OrderPreviewInvoicesRow.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_OrdersRequestFiles.Wb_OrderPreviewInvoicesRow.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(model.variables.getInvoiceFilesByInvoiceIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getInvoiceFilesByInvoiceIdAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByInvoiceIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr), asPrimitiveValue(model.variables.getInvoiceFilesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getInvoiceFilesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr)]
}, createElement(OSWidgets$Expression, {
style: "margin-left-710",
value: model.variables.getInvoiceFilesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByInvoiceIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically margin-right-194",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_OrdersRequestFiles_Wb_OrderFilePreviewDownload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getInvoiceFilesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByInvoiceIdAggr.dataFetchStatusAttr),
i_Filename: model.variables.getInvoiceFilesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByInvoiceIdAggr.dataFetchStatusAttr),
i_Size: model.variables.getInvoiceFilesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr,
_i_SizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByInvoiceIdAggr.dataFetchStatusAttr)
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
uuid: "4",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByInvoiceIdAggr.dataFetchStatusAttr)]
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "loading-spinner",
visible: true,
_idProps: {
service: idService,
name: "listupdating"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_OrderPreviewInvoicesRow",
functionKey: "ca95db76-0352-46b8-ac0c-06fcc46775d5",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_OrdersRequestFiles.Wb_OrderPreviewInvoicesRow",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.e_OrdersRequestFiles.Wb_OrderPreviewInvoicesRow.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_e_OrdersRequestFiles_Wb_OrderFilePreviewDownload_mvc_view];
};


return ELEM;
};

export default componentFactory()
