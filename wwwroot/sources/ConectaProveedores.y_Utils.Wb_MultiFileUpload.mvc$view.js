import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.dropArea,
style: "drop-area",
_idProps: {
service: idService,
name: "DropArea"
},
_widgetRecordProvider: widgetsRecordProvider
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_MultiFileUpload",
functionKey: "c88203f8-5c0f-48b7-af19-aaa2153b9cf0",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_MultiFileUpload",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.y_Utils.Wb_MultiFileUpload.css"];
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
