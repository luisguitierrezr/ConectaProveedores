import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Expression as OSWidgets$Expression, Form as OSWidgets$Form, Label as OSWidgets$Label, Dropdown as OSWidgets$Dropdown, Input as OSWidgets$Input, Button as OSWidgets$Button, Popup as OSWidgets$Popup, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_mvc_view from "./ConectaProveedores.h_OrderDistributionConfig.Wb_PositionContact.mvc$view.js";
import ConectaProveedores_h_OrderDistributionConfig_Wb_PopupMessage_mvc_view from "./ConectaProveedores.h_OrderDistributionConfig.Wb_PopupMessage.mvc$view.js";
import OutSystemsUI_Interaction_Sidebar_mvc_view from "./OutSystemsUI.Interaction.Sidebar.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_y_Logs_Wb_GetDistributionLog_mvc_view from "./ConectaProveedores.y_Logs.Wb_GetDistributionLog.mvc$view.js";
import ModelFactory from "./ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails.mvc$controller.js";
import { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import { ICON_LIBRARY_NAME, ICON_MAPPINGS, WEIGHT_MAPPINGS, SIZE_MAPPINGS } from "./Telcel_Theme.Telcel_Theme_Theme.mappings.js";

var componentFactory = function () {
var ELEM = withBaseWebScreen(function (props) {
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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ChatBotIsEnable: false
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
breadcrumbs: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "margin-right: 5px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_inicio2025.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Homepage", {}),
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link font-semi-bold",
text: [$text(getTranslation("GNGOajfOnUKOZN4fHIyhJA#Value", "Homepage"))],
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Dashboard", {}),
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link ",
text: [$text(getTranslation("AWWZHt_8skqtXVRcZ4dohQ#Value", "Dashboard"))],
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDistributionConfig", {}),
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("ZQBEtAd4Y0SO+XZkjNhUog#Value", "Order distribution list"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-active",
text: [$text(getTranslation("qTH+R3M1zUO5b43ilJuohQ#Value", "Order Distribution Details"))],
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "display",
value: model.getCachedValue(idService.getId("rAyEhuQRvUyJvjsm42UaAQ.Value"), function () {
return ((model.variables.configIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("TCKzxAFqg0WwVvYjsl9++A#ValueExpression.-1936978698.1", "New Order Distribution")) : ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("TCKzxAFqg0WwVvYjsl9++A#ValueExpression.-2017373046.1", "Order Distribution ") + model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantAttr)));
}, function () {
return model.variables.configIdIn;
}, function () {
return model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantAttr;
}),
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form card",
_idProps: {
service: idService,
name: "Form1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-right-m",
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
mandatory: false,
targetWidget: "Dropdown_Division",
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("80b0ffNZi0uOarluWgtqbQ#ValueExpression.-599975576.1", "Region/Division"),
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
dropdownMode: /*Text*/ 0,
enabled: model.getCachedValue(idService.getId("Dropdown_Division.Enabled"), function () {
return model.variables.configIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
}, function () {
return model.variables.configIdIn;
}),
gridProperties: {
classes: "ThemeGrid_Width5"
},
labels: function (elem) {
return elem.regionAttr.divisionFIAttr;
},
list: model.variables.getRegionsAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.regionAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.regionIdAttr, function (value) {
model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.regionIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Division"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRegionsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-right-m",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Applicant",
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+ePLizKhQkKpWEZTTmQy5w#Value", "Applicant"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: true,
gridProperties: {
classes: "ThemeGrid_Width5"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 12,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantAttr, function (value) {
model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Applicant"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-right-m",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_ApplicantDescription",
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5YTKk64kg0KkSiyugxuFFw#Value", "Applicant Description"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 200,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantDescriptionAttr, function (value) {
model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantDescriptionAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ApplicantDescription"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-right-m",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_Direction",
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("vuUz5My73kCnu7+V+ILskQ#Value", "Direction"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
dropdownMode: /*Text*/ 0,
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
labels: function (elem) {
return elem.telcelDirectionAttr.nameAttr;
},
list: model.variables.getTelcelDirectionsAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.telcelDirectionAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.directionIdAttr, function (value) {
model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.directionIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Direction"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getTelcelDirectionsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "34"
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
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PositionContactId: model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.firstContact_EntraRoleIdAttr,
_positionContactIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr),
IsMandatory: true,
Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("lC9_0NGcKUm+aXsLM9+N2A#Value.-396990503.1", "Position First Contact"),
ShowLabelFirst: false
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChangePositionContact$Action: function (newPositionContactIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_PositionContactOnChangePositionContact$Action(newPositionContactIn, 1, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "36",
alias: "2"
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
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PositionContactId: model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.secondContact_EntraRoleIdAttr,
_positionContactIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr),
IsMandatory: true,
ShowLabelFirst: false,
Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("jIIm3REQB06EBAUFXX29Cg#Value.2016715819.1", "Position Second Contact")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChangePositionContact$Action: function (newPositionContactIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_PositionContactOnChangePositionContact$Action(newPositionContactIn, 2, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "38",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "39"
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
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsMandatory: true,
Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Au2LUNmM10ak7fJhTccbcw#Value.-1964074452.1", "Position First Approver"),
ShowLabelFirst: false,
PositionContactId: model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.firstApprover_EntraRoleIdAttr,
_positionContactIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChangePositionContact$Action: function (newPositionContactIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_PositionContactOnChangePositionContact$Action(newPositionContactIn, 3, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "41",
alias: "4"
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
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("K204YiK2Ck2TUO8kNuUFng#Value.-153622502.1", "Position Second Approver"),
ShowLabelFirst: false,
IsMandatory: false,
PositionContactId: model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.secondApprover_EntraRoleIdAttr,
_positionContactIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChangePositionContact$Action: function (newPositionContactIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_PositionContactOnChangePositionContact$Action(newPositionContactIn, 4, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "43",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align display-flex margin-top-m justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDistributionConfig", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn btn-back white-space-nowrap",
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("FN21mLTnQ06LKiuSIRDwTA#Value", "Close"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline ThemeGrid_MarginGutter"
},
style: "text-align-right display-flex align-items-center",
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.configIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: true,
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.saveDistribution$Action("", controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("x7oPDM4G1k6_oMUS+UlJUA#Value", "Save")))];
}, function () {
return [createElement(OSWidgets$Button, {
enabled: true,
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.saveOnClick$Action(controller.callContext(eventHandlerContext));


;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("sBZhw83h5UOsH_Bc3VPQkw#Value", "Save"))), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.showPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_h_OrderDistributionConfig_Wb_PopupMessage_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsMandatoryMessage: true,
PromptText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("YfGPm5DukkGjFFNLK_MY3g#Value.-1273350560.1", "Please add here your justification"),
LabelText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3YalyFCwkkCJ48Hcs5nEDQ#Value.-2106298316.1", "In order to apply the change you have to justify the change")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
result$Action: function (textIn, actionContinueIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_PopupMessageResult$Action(textIn, actionContinueIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "50",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.seeLogsOnClick$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("d_ziOpBQEUubxln1LMavPA#Value", "See Logs"))],
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OutSystemsUI_Interaction_Sidebar_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Width: "700",
HasOverlay: false
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
name: "SidebarLog",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display",
visible: true,
_idProps: {
service: idService,
uuid: "56"
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
uuid: "57",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width10"
},
visible: true,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("d4oHjfZsZUCy3QOzrJy8sw#Value", "Historic"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closeSidebar$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
}))];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Logs_Wb_GetDistributionLog_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: 250,
PeriodEnd: model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.updatedOnAttr,
_periodEndInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr),
OriginId: ConectaProveedores_staticEntities_origin.orderDistributionConfig,
PeriodInit: model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.createdOnAttr,
_periodInitInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr),
Identifier: model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.idAttr,
_identifierInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr),
ShowErrors: true,
i_Refresh: OS$BuiltinFunctions.dateTimeToText(model.variables.l_RefeshSideBarVar)
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
uuid: "62",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.idAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.createdOnAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.updatedOnAttr)]
})];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(model.variables.showPopupVar), asPrimitiveValue(model.variables.getTelcelDirectionsAggr.listOut), asPrimitiveValue(model.variables.getRegionsAggr.listOut), asPrimitiveValue(model.variables.getTelcelDirectionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRegionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.idAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.createdOnAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.updatedOnAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.secondApprover_EntraRoleIdAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.firstApprover_EntraRoleIdAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.secondContact_EntraRoleIdAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.firstContact_EntraRoleIdAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.directionIdAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantDescriptionAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.regionIdAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantAttr), asPrimitiveValue(model.variables.configIdIn)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "OrderDistributionConfigDetails",
functionKey: "66d06b2f-6387-4b22-96c0-bb7deec91a96",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "h_OrderDistributionConfig.OrderDistributionConfigDetails",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function (props) {
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
return ("Portal Conecta Proveedores " + ConectaProveedoresController$getEnviroment$Action(callContext).enviromentOut);
},
iconLibrary: ICON_LIBRARY_NAME,
iconMappings: ICON_MAPPINGS,
iconWeightMappings: WEIGHT_MAPPINGS,
iconSizeMappings: SIZE_MAPPINGS
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_mvc_view, ConectaProveedores_h_OrderDistributionConfig_Wb_PopupMessage_mvc_view, OutSystemsUI_Interaction_Sidebar_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, ConectaProveedores_y_Logs_Wb_GetDistributionLog_mvc_view];
};


return ELEM;
};

export default componentFactory()
