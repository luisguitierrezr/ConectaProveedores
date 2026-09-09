import { withBaseWebBlock, asPrimitiveValue, Widget, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, List as OSWidgets$List, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_TimelineUsersV2.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_TimelineUsersV2.mvc$controller.js";

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
extendedProperties: {
style: "text-align: left;"
},
style: "stepper-wrapper",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "stepper-card",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Orientation: ConectaProveedores_staticEntities_orientation.horizontal,
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "2",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$List, {
animateItems: false,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.stepListIn,
style: "\"list list-group\"",
tag: "div",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._stepListInDataFetchStatus),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
title: model.variables.stepListIn.getCurrent(callContext.iterationContext).labelAttr,
style: "text-align: center;"
},
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: ("step-item " + model.variables.stepListIn.getCurrent(callContext.iterationContext).extendedClassAttr),
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._stepListInDataFetchStatus),
_dependencies: [asPrimitiveValue(model.variables._stepListInDataFetchStatus), asPrimitiveValue(model.variables.stepListIn.getCurrent(callContext.iterationContext).underLabelNCharAttr), asPrimitiveValue(model.variables.stepListIn.getCurrent(callContext.iterationContext).underLabelAttr), asPrimitiveValue(model.variables.stepListIn.getCurrent(callContext.iterationContext).labelAttr), asPrimitiveValue(model.variables.stepListIn.getCurrent(callContext.iterationContext).extendedClassAttr), asPrimitiveValue(model.variables.stepListIn.length), asPrimitiveValue(model.variables.stepListIn.getCurrentRowNumber(callContext.iterationContext))]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("DIWqpQdK10KM9Ppn7vplGg.Style"), function () {
return (((model.variables.stepListIn.getCurrentRowNumber(callContext.iterationContext) === (model.variables.stepListIn.length - 1))) ? ("") : (("step-line " + model.variables.stepListIn.getCurrent(callContext.iterationContext).extendedClassAttr)));
}, function () {
return model.variables.stepListIn.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.stepListIn.length;
}, function () {
return model.variables.stepListIn.getCurrent(callContext.iterationContext).extendedClassAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._stepListInDataFetchStatus)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 8px; text-align: center;"
},
gridProperties: {
marginLeft: "8px"
},
style: "step-icon ",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "step-title",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "bold",
value: model.variables.stepListIn.getCurrent(callContext.iterationContext).labelAttr,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._stepListInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "step-subtitle",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.stepListIn.getCurrent(callContext.iterationContext).underLabelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._stepListInDataFetchStatus),
i_NChar: model.variables.stepListIn.getCurrent(callContext.iterationContext).underLabelNCharAttr,
_i_NCharInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._stepListInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "10",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables._stepListInDataFetchStatus)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables._stepListInDataFetchStatus), asPrimitiveValue(model.variables.stepListIn)]
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_TimelineUsersV2",
functionKey: "7ddd62ba-c85a-4de3-8afc-7f955c5979de",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_TimelineUsersV2",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.y_Utils.Wb_TimelineUsersV2.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view];
};


return ELEM;
};

export default componentFactory()
