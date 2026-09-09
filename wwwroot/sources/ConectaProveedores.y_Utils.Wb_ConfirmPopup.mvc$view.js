import { withBaseWebBlock, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, Link as OSWidgets$Link, Image as OSWidgets$Image, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$controller.js";

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
style: "position-relative display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.i_PopupTitleIn,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_PopupTitleInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
style: "text-align-right position-absolute absolute-center-right margin-right-s margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.i_ConfirmationTextIn,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_ConfirmationTextInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-decline btn-important",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("bOXZxcE3T0iJbRjL_PkOcQ#Value", "No"))), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.confirm$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-approve btn-important",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1Xw9XTJf3U+0JXSSe2+yPw#Value", "Yes"))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_ConfirmPopup",
functionKey: "a7da2eb9-1e0d-491e-88da-89b69749c75b",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_ConfirmPopup",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.y_Utils.Wb_ConfirmPopup.css"];
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
