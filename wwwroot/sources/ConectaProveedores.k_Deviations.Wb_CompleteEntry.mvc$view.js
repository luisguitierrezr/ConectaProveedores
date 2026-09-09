import { withBaseWebBlock, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Form as OSWidgets$Form, Container as OSWidgets$Container, Label as OSWidgets$Label, Input as OSWidgets$Input, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ModelFactory from "./ConectaProveedores.k_Deviations.Wb_CompleteEntry.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.k_Deviations.Wb_CompleteEntry.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form",
_idProps: {
service: idService,
name: "Form"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "position-relative display font-size-main-heading",
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("vUASbvZUz0+PsjUpYWXb7Q#Value", "Complete Entry")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Year",
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("FSN63hsg7kCPXsPnwCk7eg#Value", "Year"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
gridProperties: {
classes: "ThemeGrid_Width3"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 4,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.yearVar, function (value) {
model.variables.yearVar = value;
}),
_idProps: {
service: idService,
name: "Input_Year"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-base",
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
targetWidget: "Input_EntryNumber",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("GYRtc_C5f0udSjTU+ONiBQ#Value", "Entry Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
gridProperties: {
classes: "ThemeGrid_Width6"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 10,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.entryNumberVar, function (value) {
model.variables.entryNumberVar = value;
}),
_idProps: {
service: idService,
name: "Input_EntryNumber"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
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
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopup$Action(false, controller.callContext(eventHandlerContext));

;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("vgpQBHoT60yIogTM3_wfoA#Value", "Back"))), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.submitOnClick$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("H1cTskN2k0OdiQXHgNsC8Q#Value", "Submit"))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_CompleteEntry",
functionKey: "daf592fc-f690-4ed5-87ee-cbdd24248f37",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "k_Deviations.Wb_CompleteEntry",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.k_Deviations.Wb_CompleteEntry.css"];
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
