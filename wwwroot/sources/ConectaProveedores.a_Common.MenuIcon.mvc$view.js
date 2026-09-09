import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.a_Common.MenuIcon.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.MenuIcon.mvc$controller.js";

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
extendedEvents: {
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClick$Action(controller.callContext(eventHandlerContext));
});
;
}
},
extendedProperties: {
"aria-label": "Toggle the Menu",
role: "button",
tabIndex: "0",
"aria-haspopup": "true"
},
style: "menu-icon",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"aria-hidden": "true",
style: "background-color: #0071D1;"
},
style: "menu-icon-line",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"aria-hidden": "true",
style: "background-color: #0071D1;"
},
style: "menu-icon-line",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"aria-hidden": "true",
style: "background-color: #0071D1;"
},
style: "menu-icon-line",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "MenuIcon",
functionKey: "fd957150-4e58-45ef-9373-04e817a08280",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.MenuIcon",
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
