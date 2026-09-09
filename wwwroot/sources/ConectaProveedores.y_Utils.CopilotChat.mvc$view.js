import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, AdvancedHtml as OSWidgets$AdvancedHtml } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.y_Utils.CopilotChat.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.CopilotChat.mvc$controller.js";

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
}, createElement(OSWidgets$AdvancedHtml, {
extendedProperties: {
style: "width: 100%; height:500px;"
},
tag: "div",
_idProps: {
service: idService,
name: "webchat"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "CopilotChat",
functionKey: "eaec46ee-58c6-4954-92d8-843e7626a92d",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.CopilotChat",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.y_Utils.CopilotChat.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/ConectaProveedores.UserScripts.copilot_js.js"];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
