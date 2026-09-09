import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Image as OSWidgets$Image, Label as OSWidgets$Label, TextArea as OSWidgets$TextArea, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { createElement } from "react";
import { Navigation as OS$Navigation, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ModelFactory from "./ConectaProveedores.e_Orders.Wb_OrderReject_Popup.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.Wb_OrderReject_Popup.mvc$controller.js";

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
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
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
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("A7BqppprREeCtYBtt6gbCA#Value", "Insert Comment"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: (!(model.variables.isExecutingVar)),
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(false, controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
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
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.isExecutingVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("RPnCpPgRJUyDhbpdac7BzQ.Style"), function () {
return ("os-boxlabel margin-top-m " + ((model.widgets.get(idService.getId("TextArea_l_Reason")).validAttr) ? (" ") : ("os-error")));
}, function () {
return model.widgets.get(idService.getId("TextArea_l_Reason")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "TextArea_l_Reason",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ZGNbyhtyXEqZbf23G3qJ1g#Value", "Comment"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService
},
enabled: (!(model.variables.isExecutingVar)),
extendedProperties: {
style: "resize: none;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
maxLength: 250,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("X8zItq+6tkiTgLVpqEtBig#ValueExpression.345751369.1", "Provide a reason for the rejection..."),
style: "form-control",
textLines: 2,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_ReasonVar, function (value) {
model.variables.l_ReasonVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_l_Reason"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (!(model.variables.isExecutingVar)),
extendedProperties: {
style: "min-width: 100px; max-width: fit-content;"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(false, controller.callContext(eventHandlerContext));

;
},
style: "btn btn-cancel",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("GcbiwwkZh06EM2cLLcjbeg#Value", "Close"))), createElement(OSWidgets$Button, {
enabled: (!(model.variables.isExecutingVar)),
extendedProperties: {
style: "border-width: 0px; min-width: 100px; max-width: fit-content;"
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.confirmOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-download btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1EDhBuF+ZkmnOiUMLtMpzg#Value", "Confirm"))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_OrderReject_Popup",
functionKey: "fa909159-fda6-4abf-8cac-9f7fed47aa74",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.Wb_OrderReject_Popup",
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
return [OutSystemsUI_Utilities_AlignCenter_mvc_view];
};


return ELEM;
};

export default componentFactory()
