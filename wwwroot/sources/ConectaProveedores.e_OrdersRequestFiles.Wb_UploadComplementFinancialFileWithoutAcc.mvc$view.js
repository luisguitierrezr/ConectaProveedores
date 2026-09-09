import { withBaseWebBlock, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadWithoutAcc.mvc$view.js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFinancialFileWithoutAcc.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFinancialFileWithoutAcc.mvc$controller.js";

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
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AccountingDataTypeId: model.variables.accountingDataTypeIdIn,
_accountingDataTypeIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._accountingDataTypeIdInDataFetchStatus),
ShowTitle: false,
OrderId: model.variables.orderMainIdIn,
_orderIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._orderMainIdInDataFetchStatus),
OrderAccConceptsId: model.variables.orderAccConceptsIdIn,
_orderAccConceptsIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._orderAccConceptsIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
sendFiles$Action: function (event_FilesListIn, event_InvoiceIn, event_InvoiceForeignIn, event_InvoiceExtendedIn, event_IsNationalIn, event_ClaveProdServIn, event_TipoDeComprobanteIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_InvoiceSAECUploadSendFiles$Action(event_FilesListIn, event_InvoiceIn, event_InvoiceForeignIn, "", "", controller.callContext(eventHandlerContext));

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
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.cancel$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1Rm0+XTL0EW9uhp267WUkQ#Value", "Close"))), createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("+kzJKV4Z3UmP+dagjfqgGA.Enabled"), function () {
return (model.variables.areFilesUploadedVar && !(model.variables.orderAccConceptsIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))));
}, function () {
return model.variables.areFilesUploadedVar;
}, function () {
return model.variables.orderAccConceptsIdIn;
}),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.sendFilesOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._orderAccConceptsIdInDataFetchStatus)
}, $text(getTranslation("dx+cxYnt50eiPYC0IssRaw#Value", "Send Files")))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_UploadComplementFinancialFileWithoutAcc",
functionKey: "03ada168-5230-49a8-ba22-3e44c60eb338",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_OrdersRequestFiles.Wb_UploadComplementFinancialFileWithoutAcc",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFinancialFileWithoutAcc.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_mvc_view];
};


return ELEM;
};

export default componentFactory()
