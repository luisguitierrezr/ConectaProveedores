import { withBaseWebBlock, Widget, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Dropdown as OSWidgets$Dropdown } from "@outsystems/runtime-widgets-js";
import { DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$controller.js";

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
style: "custom-container-size-records-dropdown",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
labels: function (elem) {
return elem.textAttr;
},
list: model.variables.recordsListVar,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown custom-pagination-dropdown",
values: function (elem) {
return elem.valueAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.maxRecordsVar, function (value) {
model.variables.maxRecordsVar = value;
}),
_idProps: {
service: idService,
name: "Dropdown1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_SetTableRecord",
functionKey: "249a068c-79c0-454d-847a-f9871678a556",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_SetTableRecord",
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
