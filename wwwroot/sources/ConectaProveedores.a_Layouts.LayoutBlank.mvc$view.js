import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.a_Layouts.LayoutBlank.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Layouts.LayoutBlank.mvc$controller.js";

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
style: model.getCachedValue(idService.getId("MkdPG9nwWUm+zNMFp44sBg.Style"), function () {
return (("layout blank" + (((!(model.variables.enableAccessibilityFeaturesIn))) ? ("") : (" has-accessible-features"))) + (((model.variables.extendedClassIn === "")) ? ("") : ((" " + model.variables.extendedClassIn))));
}, function () {
return model.variables.enableAccessibilityFeaturesIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._enableAccessibilityFeaturesInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
role: "main"
},
style: "content",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
style: "main-content",
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "LayoutBlank",
functionKey: "d1bc3908-71b0-46af-809f-68e60fdec867",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Layouts.LayoutBlank",
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
