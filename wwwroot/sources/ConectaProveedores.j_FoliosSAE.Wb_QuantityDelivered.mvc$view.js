import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_QuantityDelivered.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_QuantityDelivered.mvc$controller.js";

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
value: OS$BuiltinFunctions.decimalToText(model.variables.getFolioItemsByOrderMainItemIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceQttSumAttr),
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByOrderMainItemIdAggr.dataFetchStatusAttr)
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_QuantityDelivered",
functionKey: "3d6e88c7-c58d-471e-a639-fca1c148d4ee",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_QuantityDelivered",
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
