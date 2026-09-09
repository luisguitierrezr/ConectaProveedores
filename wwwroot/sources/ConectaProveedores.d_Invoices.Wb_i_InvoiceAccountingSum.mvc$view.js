import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccountingSum.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccountingSum.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("sqOmHGSEb0+yIho4B_VLaA.Value"), function () {
return (("(" + OS$BuiltinFunctions.formatDecimal(model.variables.sumVar, 2, ".", ",")) + ")");
}, function () {
return model.variables.sumVar;
}),
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_i_InvoiceAccountingSum",
functionKey: "99c39445-9115-49a9-9a44-f59daedd12da",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_i_InvoiceAccountingSum",
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
return [];
};


return ELEM;
};

export default componentFactory()
