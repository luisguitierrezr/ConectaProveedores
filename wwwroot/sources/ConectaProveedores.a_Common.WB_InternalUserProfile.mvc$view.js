import { withBaseWebBlock, Widget, textWidget as $text, getTranslation, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Text as OSWidgets$Text, Container as OSWidgets$Container, Form as OSWidgets$Form, Label as OSWidgets$Label, Input as OSWidgets$Input, Button as OSWidgets$Button, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Adaptive_Columns3_mvc_view from "./OutSystemsUI.Adaptive.Columns3.mvc$view.js";
import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_a_Common_Wb_TempRoleAssignments_mvc_view from "./ConectaProveedores.a_Common.Wb_TempRoleAssignments.mvc$view.js";
import TelCelNotificationsLib_MainFlow_NotificationManagement_mvc_view from "./TelCelNotificationsLib.MainFlow.NotificationManagement.mvc$view.js";
import ConectaProveedores_a_Common_Wb_ChangePassword_mvc_view from "./ConectaProveedores.a_Common.Wb_ChangePassword.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Common.WB_InternalUserProfile.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.WB_InternalUserProfile.mvc$controller.js";

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
text: [$text(getTranslation("HoELlcL7rkmN26GBA_3nsw#Value", "Your profile"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
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
uuid: "3",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
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
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_EmployeeNumber",
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("sonmhunD7UGh1g1Z2REc+g#Value", "Employee Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 20,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).user_Extended_InternalAttr.employeeNumberAttr, function (value) {
model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).user_Extended_InternalAttr.employeeNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_EmployeeNumber"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Name",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("czWvPwS3bEaQ28a+o6zi8g#Value", "Name"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 256,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr, function (value) {
model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "11"
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
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("BpP3vjB6F0y3+zC7haROIQ#Value", "Email"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: false,
extendedProperties: {
autoComplete: "new-password"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Email*/ 7,
mandatory: false,
maxLength: 256,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Email, model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr, function (value) {
model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Email"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_JobPosition",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("evBQBM98a0qNKNXBk+839A#Value", "Job Position"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 250,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).user_Extended_InternalAttr.jobTitleAttr, function (value) {
model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).user_Extended_InternalAttr.jobTitleAttr = value;
}),
_idProps: {
service: idService,
name: "Input_JobPosition"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Management",
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("lsFaRyrpqEy42FGiDjtSnQ#Value", "Immediate Manager"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 256,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getEntraManagerDataAct.managerNameOut, function (value) {
model.variables.getEntraManagerDataAct.managerNameOut = value;
}),
_idProps: {
service: idService,
name: "Input_Management"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getEntraManagerDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base os-boxlabel non-mandatory",
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
mandatory: true,
targetWidget: "Input_Department",
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("yKK_YA1SMEmH6Jp+pJ3wKQ#Value", "Department"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).departmentAttr.nameAttr, function (value) {
model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).departmentAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Department"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base os-boxlabel non-mandatory",
visible: false,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_RoleTelcell",
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ogi+UF3lZ0Sqf2sydR115g#Value", "Function"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr, function (value) {
model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_RoleTelcell"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base os-boxlabel",
visible: false,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_SubDirector2",
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_c4vP9sdWkuCxaX5Qt9e6g#Value", "Sub Direction\n"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr, function (value) {
model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_SubDirector2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "29"
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
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3o32JOWGQ0eW9zQEL2ifjQ#Value", "Change your password")))))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getUserApplicationRolesDataAct.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getUserApplicationRolesDataAct.userRolesListOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("heUNUc4ttUWhws4LpDh9nQ#Value", "You have no roles assigned or mapped, so you\'re not able to use substitutions.")))];
}, function () {
return [createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
extendedProperties: {
style: "padding: 0;"
},
gridProperties: {
classes: "OSFillParent"
},
style: "form card",
_idProps: {
service: idService,
name: "SubstitutionsForm"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "padding-base",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_a_Common_Wb_TempRoleAssignments_mvc_view, {
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
validationParentId: idService.getId("SubstitutionsForm")
},
_idProps: {
service: idService,
uuid: "35",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(TelCelNotificationsLib_MainFlow_NotificationManagement_mvc_view, {
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
uuid: "37",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.userRolesListOut.isEmpty), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getEntraManagerDataAct.managerNameOut), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraManagerDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).departmentAttr.nameAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).user_Extended_InternalAttr.jobTitleAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).user_Extended_InternalAttr.employeeNumberAttr)]
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-none);"
},
showPopup: model.variables.l_IsOpenPopUpVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "38"
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
uuid: "39",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_IsOpenPopUpVar), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.userRolesListOut.isEmpty), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getEntraManagerDataAct.managerNameOut), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraManagerDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).departmentAttr.nameAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).user_Extended_InternalAttr.jobTitleAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).user_Extended_InternalAttr.employeeNumberAttr)]
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "WB_InternalUserProfile",
functionKey: "340c187c-7bc6-4932-bb9b-d3d34e3b169d",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.WB_InternalUserProfile",
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
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_Columns3_mvc_view, ConectaProveedores_a_Common_Wb_TempRoleAssignments_mvc_view, TelCelNotificationsLib_MainFlow_NotificationManagement_mvc_view, ConectaProveedores_a_Common_Wb_ChangePassword_mvc_view];
};


return ELEM;
};

export default componentFactory()
