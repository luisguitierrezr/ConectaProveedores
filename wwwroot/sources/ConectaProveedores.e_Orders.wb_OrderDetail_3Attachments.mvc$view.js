import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import ConectaProveedores_e_Orders_Wb_DocumentsToRequest_mvc_view from "./ConectaProveedores.e_Orders.Wb_DocumentsToRequest.mvc$view.js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.e_Orders.wb_OrderDetail_3Attachments.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.wb_OrderDetail_3Attachments.mvc$controller.js";

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
}, createElement(ConectaProveedores_e_Orders_Wb_DocumentsToRequest_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderId: model.variables.i_OrderIdIn,
_i_OrderIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_OrderIdInDataFetchStatus),
i_SupplierId: model.variables.supplierIdIn,
_i_SupplierIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._supplierIdInDataFetchStatus),
i_HasntRequestDocuments: model.variables.i_HasntRequestDocumentsIn,
_i_HasntRequestDocumentsInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_HasntRequestDocumentsInDataFetchStatus),
i_HasError: model.variables.i_HasErrorIn,
_i_HasErrorInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_HasErrorInDataFetchStatus),
i_CanEditUserArea: model.variables.l_CanEditUserAreaIn,
_i_CanEditUserAreaInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._l_CanEditUserAreaInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
uploadParent$Action: function (orderRequestFilesIn, hasntRequestDocumentsIn, isValidIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_DocumentsToRequestUploadParent$Action(orderRequestFilesIn, hasntRequestDocumentsIn, isValidIn, controller.callContext(eventHandlerContext));
});
;
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
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "wb_OrderDetail_3Attachments",
functionKey: "ec8c2617-f3fb-44db-b9d6-e289024da393",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.wb_OrderDetail_3Attachments",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_e_Orders_Wb_DocumentsToRequest_mvc_view];
};


return ELEM;
};

export default componentFactory()
