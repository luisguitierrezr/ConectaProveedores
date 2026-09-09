import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Image as OSWidgets$Image, Label as OSWidgets$Label, Dropdown as OSWidgets$Dropdown, TextArea as OSWidgets$TextArea, Upload as OSWidgets$Upload, Input as OSWidgets$Input, Button as OSWidgets$Button, Text as OSWidgets$Text } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { createElement } from "react";
import { Navigation as OS$Navigation, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import ModelFactory from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpayPaymentPopup.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpayPaymentPopup.mvc$controller.js";

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
}, $text(getTranslation("lXj1knxafE6LT27HGhI9Fg#Value", "Insert Comment"))), createElement(OSWidgets$Container, {
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
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(controller.callContext(eventHandlerContext));

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
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("0PTVH9tHrUm9wyLULrKZEw.Style"), function () {
return ("os-boxlabel margin-top-m " + ((model.widgets.get(idService.getId("Dropdown_ReasonSelected")).validAttr) ? (" ") : ("os-error")));
}, function () {
return model.widgets.get(idService.getId("Dropdown_ReasonSelected")).validAttr;
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
targetWidget: "Dropdown_ReasonSelected",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("xg37IlySsU+62MkET4eFMQ#Value", "Motive"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("q2XUuxjqoUWrYoeX3paiNQ#ValueExpression.1419759626.1", "Select motive"),
enabled: true,
labels: function (elem) {
return elem.optionAttr;
},
list: model.variables.l_DropdownReasonOptionsListVar,
mandatory: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_ReasonSelectedOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "dropdown",
values: function (elem) {
return elem.optionAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_DropdownReasonSelectedVar, function (value) {
model.variables.l_DropdownReasonSelectedVar = value;
}),
_idProps: {
service: idService,
name: "Dropdown_ReasonSelected"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), $if(((model.variables.l_DropdownReasonSelectedVar) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("_sQlrL2G106JgaifFIS+Eg.Style"), function () {
return ("os-boxlabel margin-top-m " + ((model.widgets.get(idService.getId("TextArea_l_UnpayReason")).validAttr) ? (" ") : ("os-error")));
}, function () {
return model.widgets.get(idService.getId("TextArea_l_UnpayReason")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "TextArea_l_UnpayReason",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("yMvLPms7xkSuO+EhItIcxA#Value", "Comment"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedProperties: {
style: "resize: none;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
maxLength: 250,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0iIORAS5BEeOEgV3JywaoA#ValueExpression.-1834383777.1", "Provide a reason for the non payment..."),
style: "form-control",
textLines: 2,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_UnpayReasonVar, function (value) {
model.variables.l_UnpayReasonVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_l_UnpayReason"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "display: none;"
},
visible: true,
_idProps: {
service: idService,
name: "UpoadWidgetHidden"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Upload, {
_validationProps: {
validationService: validationService
},
accept: /*Any*/ 2,
fileContent: model.createVariable(OS$DataTypes.DataTypes.BinaryData, model.variables.l_BinaryDataVar, function (value) {
model.variables.l_BinaryDataVar = value;
}),
fileName: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_FilenameVar, function (value) {
model.variables.l_FilenameVar = value;
}),
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "\"upload\"",
_idProps: {
service: idService,
name: "Upload"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("YstuLNYmB0iy+FMR1aR1pg.Style"), function () {
return ("os-boxlabel " + ((model.widgets.get(idService.getId("Input_Filename")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("Input_Filename")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Filename",
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("gN0jSZJeGECdjt0dE9gNKw#Value", "Evidence"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlignIconRight: true
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
uuid: "18",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.input_FilenameOnClick$Action(controller.callContext(eventHandlerContext));

;
}
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_subir.svg"),
style: "img clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("W_NdazBgWUGiUCEC+z7pVA#ValueExpression.-1731799675.1", "Evidence file"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_FilenameVar, function (value) {
model.variables.l_FilenameVar = value;
}),
_idProps: {
service: idService,
name: "Input_Filename"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_FilenameVar)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
extendedProperties: {
style: "min-width: 100px; max-width: fit-content;"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-cancel",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5kKaF6+vS0KDuXJj93otZA#Value", "Cancel"))), createElement(OSWidgets$Button, {
enabled: true,
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
return controller.unpaidOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-download rejected",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "reject",
text: [$text(getTranslation("Jmr+PxVJFEeMT_aqZoGt8w#Value", "Unpaid"))],
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
})))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_UnpayPaymentPopup",
functionKey: "b51354fe-ad46-4e5f-b080-bc366006d01e",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_TreasuryCommissionsLeasing.Wb_UnpayPaymentPopup",
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
return [OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view];
};


return ELEM;
};

export default componentFactory()
