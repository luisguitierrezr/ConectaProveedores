import { withBaseWebBlock, Widget, textWidget as $text, getTranslation, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Text as OSWidgets$Text, Form as OSWidgets$Form, Container as OSWidgets$Container, Label as OSWidgets$Label, Input as OSWidgets$Input, Button as OSWidgets$Button, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_a_Common_Wb_ChangePassword_mvc_view from "./ConectaProveedores.a_Common.Wb_ChangePassword.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Common.WB_ExternalUserProfile.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.WB_ExternalUserProfile.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, {
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
breadcrumbs: Widget.PlaceholderContent.Empty,
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("8FQcW_HP6UG2CTN5VQyYlA#Value", "Your profile"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form card",
_idProps: {
service: idService,
name: "ProfileDetailsForm"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
_idProps: {
service: idService,
uuid: "3",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
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
targetWidget: "Input_Number",
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("wrbW8GD7QUyVjvWi+exM9A#Value", "Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 12,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Number"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
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
targetWidget: "Input_Name",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("BgPmBmE1PkmxvJx6xizclg#Value", "Name"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 500,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
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
mandatory: false,
targetWidget: "Input_Email",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("rl0dmBL5xky8V7XQcD3zfA#Value", "Email"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Email*/ 7,
mandatory: false,
maxLength: 256,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Email, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.emailAttr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.emailAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Email"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_RFC",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("51Ukr3AhZ0CrjRXwJUqh9g#Value", "RFC"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr = value;
}),
_idProps: {
service: idService,
name: "Input_RFC"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
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
targetWidget: "Input_Region",
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("IF+w90Y3x0611YKGKP3cXg#Value", "Region"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.region_Attr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.region_Attr = value;
}),
_idProps: {
service: idService,
name: "Input_Region"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Group",
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("kL5c4ymYSUCPH3SXHt1KKQ#Value", "Group"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.grupodeporteAttr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.grupodeporteAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Group"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_LineOfBussiness",
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("b3LFR9b8eEKCv9nis4BOPw#Value", "Line Of Bussiness"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.ramoAttr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.ramoAttr = value;
}),
_idProps: {
service: idService,
name: "Input_LineOfBussiness"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("ProfileDetailsForm"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setPopup$Action(controller.callContext(eventHandlerContext));


;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("RNMPFWXaw0GgWFaZNkTrFw#Value", "Change your password"))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getSupplierByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.ramoAttr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.grupodeporteAttr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.region_Attr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.emailAttr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr)]
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-none);"
},
showPopup: model.variables.l_IsOpenPopUpVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_a_Common_Wb_ChangePassword_mvc_view, {
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
},
closePopUp$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setPopup$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "28",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_IsOpenPopUpVar), asPrimitiveValue(model.variables.getSupplierByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.ramoAttr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.grupodeporteAttr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.region_Attr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.emailAttr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr)]
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "WB_ExternalUserProfile",
functionKey: "26fc2db4-c2cf-412f-8bf2-b21ee244ef14",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.WB_ExternalUserProfile",
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
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, ConectaProveedores_a_Common_Wb_ChangePassword_mvc_view];
};


return ELEM;
};

export default componentFactory()
