import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.a_Common.ApplicationTitle.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.ApplicationTitle.mvc$controller.js";

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
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.applicationNameOnClick$Action(controller.callContext(eventHandlerContext));

;
}
},
extendedProperties: {
role: "button",
tabIndex: "0"
},
style: "application-name display-flex align-items-center full-height",
visible: true,
_idProps: {
service: idService,
name: "ApplicationTitleWrapper"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
alt: "",
style: "height: 32px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/ConectaProveedores.Logo.jpg"),
style: "app-logo",
type: /*Static*/ 0,
_idProps: {
service: idService,
name: "AppLogo"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "ApplicationTitle",
functionKey: "99261221-5631-4dea-b701-80292a8a29bf",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.ApplicationTitle",
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
