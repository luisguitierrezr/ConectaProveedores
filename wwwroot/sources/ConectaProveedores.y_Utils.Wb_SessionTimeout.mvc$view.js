import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Popup as OSWidgets$Popup, Container as OSWidgets$Container, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_SessionTimeout.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_SessionTimeout.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(false, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Popup, {
showPopup: model.variables.showWarningVar,
style: "popup-logout",
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "popup-logout-up",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "info-circle",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("EsIA0XkPr02ofVEJdrWiNA#Value", "You will be logged out of the application in ")), createElement(OSWidgets$Expression, {
gridProperties: {
marginLeft: "0"
},
value: model.getCachedValue(idService.getId("gYWHiX9kXk+te7YpILr+0g.Value"), function () {
return (((model.variables.secondsVar).toString() + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("KKL5WTC5o0avHgSjixmopg#ValueExpression.1724034196.1", " second")) + (((model.variables.secondsVar > 1)) ? ("s") : ("")));
}, function () {
return model.variables.secondsVar;
}),
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("w6tkcD9yy0evUdDtzkYAVw#Value", ".  Click continue to keep working in the application or exit to log out now.")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "popup-logout-down",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.continueOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary width-180px",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("B0qqFXV4zkyPnXwst8MtEg#Value", "Continue"))), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
marginLeft: "10px"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.logoutOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn margin-left-s width-180px",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("34fOC8WNTkeKs4UjRZd86w#Value", "Exit")))))];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_SessionTimeout",
functionKey: "aafed7e2-aa4f-4f9c-9117-b8c673dd7edc",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_SessionTimeout",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.y_Utils.Wb_SessionTimeout.css"];
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
