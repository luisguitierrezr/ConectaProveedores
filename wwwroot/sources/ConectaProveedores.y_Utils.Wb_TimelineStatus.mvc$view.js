import { withBaseWebBlock, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, List as OSWidgets$List, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_TimelineStatus.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_TimelineStatus.mvc$controller.js";

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
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: false,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Custom*/ 1,
source: model.variables.stepListIn,
style: "list list-group status-list",
tag: "div",
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._stepListInDataFetchStatus),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Expression, {
extendedProperties: {
title: model.variables.stepListIn.getCurrent(callContext.iterationContext).labelAttr
},
style: ("text-ellipsis status-item timeline-" + model.variables.stepListIn.getCurrent(callContext.iterationContext).extendedClassAttr),
value: model.variables.stepListIn.getCurrent(callContext.iterationContext).labelAttr,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._stepListInDataFetchStatus),
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._stepListInDataFetchStatus),
_dependencies: []
})];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables._stepListInDataFetchStatus)]
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_TimelineStatus",
functionKey: "2f9a0f10-7fc5-49bd-a80b-bd325ed274ad",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_TimelineStatus",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.y_Utils.Wb_TimelineStatus.css"];
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
