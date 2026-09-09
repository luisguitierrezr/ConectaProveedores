import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model } from "@outsystems/runtime-core-js";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_Sum.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_Sum.mvc$controller.js";

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
style: "text-align-right font-size-h3 font-semi-bold",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-third",
text: [$text(getTranslation("eKVybLbVukC9956H8EGhRA#Value", "Subtotal Importe:"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
style: "margin-left-xs",
value: model.getCachedValue(idService.getId("4WYagOXrlEKdO8DODKpeQw.Value"), function () {
return (model.variables.i_CurrencyIn + OS$BuiltinFunctions.formatDecimal(model.variables.i_ValueIn, 2, ".", ","));
}, function () {
return model.variables.i_CurrencyIn;
}, function () {
return model.variables.i_ValueIn;
}),
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_CurrencyInDataFetchStatus, model.variables._i_ValueInDataFetchStatus)
})), $if(true, false, this, function () {
return [];
}, function () {
return [];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_Sum",
functionKey: "2522b3a9-7e3e-415c-8580-dbc9e90ae1d9",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_Sum",
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
