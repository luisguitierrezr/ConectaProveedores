import { withBaseWebBlock, asPrimitiveValue, Widget, ifWidget as $if, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, List as OSWidgets$List, Expression as OSWidgets$Expression, Link as OSWidgets$Link, Popup as OSWidgets$Popup, Label as OSWidgets$Label, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import JSONBeautifier_JSONBeautifier_JSONBeautifier_mvc_view from "./JSONBeautifier.JSONBeautifier.JSONBeautifier.mvc$view.js";
import ModelFactory from "./ConectaProveedores.y_Logs.Wb_GetDistributionLog.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Logs.Wb_GetDistributionLog.mvc$controller.js";

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
style: "card",
visible: true,
_idProps: {
service: idService,
name: "body"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "",
visible: true,
_idProps: {
service: idService,
name: "list"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getDataDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getDataDataAct.auditListOut,
style: "list list-group margin-top-s",
tag: "div",
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "tl",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).messageAttr), asPrimitiveValue(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceDateTimeAttr), asPrimitiveValue(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceUserAttr), asPrimitiveValue(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).isErrorAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "tl-item",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "tl-left",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("+H576__ReEGSmpZNkpEf8Q.Style"), function () {
return ((model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).isErrorAttr) ? ("tl-doterror") : ("tl-dot"));
}, function () {
return model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).isErrorAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width10"
},
style: "tl-content",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "color: #9fa0a0; font-size: 12px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("fpfmVFWQDUa9BU4kcVxGVg.Value"), function () {
return (((((model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceUserAttr === OS$BuiltinFunctions.nullTextIdentifier())) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kL2Nt35+h0CGVltPgH11NQ#ValueExpression.-1803461041.1", "System")) : (model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceUserAttr)) + " - ") + OS$BuiltinFunctions.dateTimeToText(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceDateTimeAttr));
}, function () {
return model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceUserAttr;
}, function () {
return model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceDateTimeAttr;
}),
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 14px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).messageAttr,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDataDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.linkOnClick$Action(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).originalJSONAttr, model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).changeJSONAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "font-bold font-size-h5 text-info",
value: "...",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
})))))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.showPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("I7i6IOE9gUyj31YMODa2hA#Value", "Before"))), createElement(JSONBeautifier_JSONBeautifier_JSONBeautifier_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
JSON: model.variables.jSON_AfterVar,
AutoExpand: true
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
uuid: "22",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("H9+NthlzKE+WrTznpRrueQ#Value", "After"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "renderjson",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(JSONBeautifier_JSONBeautifier_JSONBeautifier_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxStringLength: 500,
AutoExpand: true,
JSON: model.variables.jSON_BeforeVar
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
uuid: "26",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closeOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("lKSmyUO130+hcVPi7ADvwQ#Value", "Close"))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_GetDistributionLog",
functionKey: "03e88352-e343-45fd-a886-f0b20368355b",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Logs.Wb_GetDistributionLog",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.y_Logs.Wb_GetDistributionLog.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [JSONBeautifier_JSONBeautifier_JSONBeautifier_mvc_view];
};


return ELEM;
};

export default componentFactory()
