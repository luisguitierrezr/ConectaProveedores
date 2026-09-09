import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Switch as OSWidgets$Switch, Text as OSWidgets$Text, Link as OSWidgets$Link, Image as OSWidgets$Image, List as OSWidgets$List, ListItem as OSWidgets$ListItem, Input as OSWidgets$Input, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Model as OS$Model, DataTypes as OS$DataTypes, Navigation as OS$Navigation, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ModelFactory from "./ConectaProveedores.e_Orders.Wb_DocumentsToRequest.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.Wb_DocumentsToRequest.mvc$controller.js";

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
style: "os-boxlabel custom-list-border custom-container margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("G7Qu8BXo00K2TM+5puyMvA#Value", "Request Documents"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
style: "vertical-align  flex-wrap",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService
},
enabled: model.variables.i_CanEditUserAreaIn,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.switchOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.i_HasntRequestDocumentsIn, function (value) {
model.variables.i_HasntRequestDocumentsIn = value;
}),
_idProps: {
service: idService,
name: "SwitchHasRequestDocuments"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_CanEditUserAreaInDataFetchStatus),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_HasntRequestDocumentsInDataFetchStatus)
}), createElement(OSWidgets$Text, {
style: "margin-left-s ",
text: [$text(getTranslation("+NOAO5xNRUKZN21vSLiPxw#Value", "Not applicable"))],
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(model.variables.i_HasntRequestDocumentsIn, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: model.getCachedValue(idService.getId("_Hd3pcYrKk6XvckprgkeiA.style"), function () {
return ("position: relative; " + ((model.variables.i_HasErrorIn) ? ("border-color: red;") : (" ")));
}, function () {
return model.variables.i_HasErrorIn;
})
},
style: "os-boxlabel custom-list-border custom-container margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: model.variables.i_CanEditUserAreaIn,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.addRecord$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "custom-plus-button",
visible: model.variables.i_CanEditUserAreaIn,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_CanEditUserAreaInDataFetchStatus),
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_CanEditUserAreaInDataFetchStatus)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "padding-x-base",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderRequestFilesDataAct.requestFilesOut.isEmpty, false, this, function () {
return [$if(model.variables.i_CanEditUserAreaIn, false, this, function () {
return [createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("IlfZfOLqjkS4tmeZUiS0rQ#Value", "Create request files to the provider"))],
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
})];
}, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getOrderRequestFilesDataAct.requestFilesOut,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
name: "DocumentList2"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$ListItem, {
style: "list-item custom-list-item overflow-visible",
triggerActionOnFullSwipeLeft: false,
triggerActionOnFullSwipeRight: false,
_idProps: {
service: idService,
name: "ListItem2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: model.variables.i_CanEditUserAreaIn,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.removeOnClick$Action(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));
});
;
},
style: "custom-minus-button-wb align-column-vertically",
visible: model.variables.i_CanEditUserAreaIn,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_CanEditUserAreaInDataFetchStatus),
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_CanEditUserAreaInDataFetchStatus)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height : 25px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: model.variables.i_CanEditUserAreaIn,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 100,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.checkValid$Action(controller.callContext(eventHandlerContext));
});
;
},
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("G1a7dVfHP0qPUX9Q0++Gyg#ValueExpression.926364987.1", "Document"),
style: "form-control no-margin",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).descriptionAttr, function (value) {
model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).descriptionAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Current2"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_CanEditUserAreaInDataFetchStatus),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr)
}))];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.requestFilesOut.getCurrent(callContext.iterationContext).descriptionAttr), asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables._i_CanEditUserAreaInDataFetchStatus), asPrimitiveValue(model.variables.i_CanEditUserAreaIn)]
})];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables._i_CanEditUserAreaInDataFetchStatus), asPrimitiveValue(model.variables.i_CanEditUserAreaIn)]
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: false,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (((model.variables.getOrderRequestFilesDataAct.requestFilesOut.length) !== (0)) && model.variables.l_IsValidListVar),
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.sendOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn white-space-nowrap",
visible: (((model.variables.getOrderRequestFilesDataAct.requestFilesOut.length) !== (0)) && model.variables.l_IsValidListVar),
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr),
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr)
}, $text(getTranslation("u7WcWqpCZEWuiJwWGODSYA#Value", "Send")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "list-updating",
visible: model.variables.l_IsBusyVar,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}))))];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_DocumentsToRequest",
functionKey: "0ff5b2f2-7c44-4da1-ba57-dd22cc9bdd8e",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.Wb_DocumentsToRequest",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.e_Orders.Wb_DocumentsToRequest.css"];
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
