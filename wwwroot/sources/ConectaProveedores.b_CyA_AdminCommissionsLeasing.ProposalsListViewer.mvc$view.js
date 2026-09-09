import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Button as OSWidgets$Button, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Interaction_Search_mvc_view from "./OutSystemsUI.Interaction.Search.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import { ST_bc4abb4233d9ce894e855c520a20c76fStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import Telcel_Theme_Utils_Wb_CalendarClear_mvc_view from "./Telcel_Theme.Utils.Wb_CalendarClear.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { SE_position as ConectaProveedores_staticEntities_position, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import AutoRefreshUtils_Widget_EventExtensibilityBlock_mvc_view from "./AutoRefreshUtils.Widget.EventExtensibilityBlock.mvc$view.js";
import ModelFactory from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ChatBotIsEnable: true,
Initiative: "CYA"
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
text: [$text(getTranslation("JEZLdFQ0EEmnxzRDLXHMnA#Value", "Homepage"))],
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
text: [$text(getTranslation("5E8ynlXHl0SAMKUm0DJQnw#Value", "Dashboard"))],
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
}, createElement(OSWidgets$Text, {
style: "breadcrumb-active",
text: [$text(getTranslation("pl4T85JD2kS3lV1YFFdRrw#Value", "Proposals"))],
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("_G6p_J+QVUCCoJi4QB1y4w#Value", "Proposals"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}), " "];
}),
actions: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: true,
extendedProperties: {
style: "width: auto;"
},
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "DocumentList", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_buscar2.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("J1KQOsLCzEipWBcoOugWpg#Value", "Search for document"))],
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width8"
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_Search_mvc_view, {
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
uuid: "23",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "wcag-hide-text",
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("8q_O+RpLUkGx1CqCkxSCyg#Value", "Search input"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Search*/ 8,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("QlVnNJUg_Ue_sNBZs+Enjw#ValueExpression.-928198894.1", "Proposal"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getProposals_ProposalSearch(), function (value) {
ConectaProveedoresClientVariables.setProposals_ProposalSearch(value);
}),
_idProps: {
service: idService,
name: "Input_Nothing2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_ProposalSearch())]
})), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 700,
WidgetId: idService.getId("Input_Nothing2")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "26",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
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
mandatory: false,
targetWidget: "Dropdown_Bank",
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("htaHmcTrKESBqhoMlAevMQ#Value", "Bank"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("2TcBxgtA806vcQmsOSbWHA#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.bankAttr.nameAttr;
},
list: model.variables.getBanksAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown ",
values: function (elem) {
return elem.bankAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, ConectaProveedoresClientVariables.getProposals_Bank(), function (value) {
ConectaProveedoresClientVariables.setProposals_Bank(value);
}),
_idProps: {
service: idService,
name: "Dropdown_Bank"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getBanksAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_DatePicker_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ShowTodayButton: true,
OptionalConfigs: model.getCachedValue(idService.getId("Datepicker2.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
return rec;
}();
}),
DateFormat: "DD/MM/YYYY"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnPaymentDateFrom$Action(OS$BuiltinFunctions.dateTimeToDate(selectedDateTimeIn), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "Datepicker2",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_PaymentDate2",
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("pTZ+_pHplUKjgjBdr9FThQ#Value", "Payment Date from"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "34",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(Telcel_Theme_Utils_Wb_CalendarClear_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Date: ConectaProveedoresClientVariables.getProposals_PaymentDateFrom()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
clear$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearDateFrom$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "35",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
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
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("t7Amxh2avEWUXQk6rCeoGw#ValueExpression.65921.1", "All"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getProposals_PaymentDateFrom(), function (value) {
ConectaProveedoresClientVariables.setProposals_PaymentDateFrom(value);
}),
_idProps: {
service: idService,
name: "Input_PaymentDate2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_PaymentDateFrom())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_PaymentDateFrom())]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_DatePicker_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionalConfigs: model.getCachedValue(idService.getId("Datepicker.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
return rec;
}();
}),
ShowTodayButton: true,
DateFormat: "DD/MM/YYYY"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnPaymentDateTo$Action(OS$BuiltinFunctions.dateTimeToDate(selectedDateTimeIn), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "Datepicker",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_PaymentDate",
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0_UT+5b4wUO8QP4PsoWdnQ#Value", "Payment Date to"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "41",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(Telcel_Theme_Utils_Wb_CalendarClear_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Date: ConectaProveedoresClientVariables.getProposals_PaymentDateTo()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
clear$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearDateTo$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "42",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
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
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1vlUdvN03ECDfwv9ZHacFA#ValueExpression.65921.1", "All"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getProposals_PaymentDateTo(), function (value) {
ConectaProveedoresClientVariables.setProposals_PaymentDateTo(value);
}),
_idProps: {
service: idService,
name: "Input_PaymentDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_PaymentDateTo())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_PaymentDateTo())]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_Status",
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("HRViBqNkHEOs_pP1yAMISA#Value", "Status"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("2er9z8pF3EOva_MPhIcruA#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.proposalStatusAttr.labelAttr;
},
list: model.variables.getProposalStatusAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.proposalStatusAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getProposals_Status(), function (value) {
ConectaProveedoresClientVariables.setProposals_Status(value);
}),
_idProps: {
service: idService,
name: "Dropdown_Status"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalStatusAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-base",
visible: model.variables.l_ShowFiltersVar,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(false, false, this, function () {
return [];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_AmountML",
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2SJa39IQo0e+idhykC4p4A#Value", "From (Amount ML)"))), createElement(OSWidgets$Input, {
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
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_AmountFromTextVar, function (value) {
model.variables.l_AmountFromTextVar = value;
}),
_idProps: {
service: idService,
name: "Input_AmountML"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
UseNumericInput: true,
PrefixText: "",
RightAlign: true,
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_AmountML"),
GroupSeparator: ",",
DecimalSeparator: ".",
SuffixText: ""
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
name: "MaskCurrency_AmountML",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_AmountML"),
DebounceDelay: 1000
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onDebounce$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "52",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_AmountML2",
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Tj9aACLrkE2Tat4o4KX1Wg#Value", "To (Amount ML)"))), createElement(OSWidgets$Input, {
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
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_AmountToTextVar, function (value) {
model.variables.l_AmountToTextVar = value;
}),
_idProps: {
service: idService,
name: "Input_AmountML2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true,
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
SuffixText: "",
InputId: idService.getId("Input_AmountML2"),
RightAlign: true,
PrefixText: ""
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
name: "MaskCurrency_AmountML2",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("Input_AmountML2")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onDebounce$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "57",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_Currency",
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Ui377g4rLkW84IM2GiK1hQ#Value", "Currency\n"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("uimYDnW2JkyrM+f5AD5Low#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown ",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getProposals_Currency(), function (value) {
ConectaProveedoresClientVariables.setProposals_Currency(value);
}),
_idProps: {
service: idService,
name: "Dropdown_Currency"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_Status2",
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("LImxHhSVVUevTdqqZo92Tg#Value", "Upload Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4ZK5QaUiSUu8RVodfoipLg#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.valueAttr;
},
list: model.variables.getUploadTypeDataAct.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.keyAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getProposals_UploadType(), function (value) {
ConectaProveedoresClientVariables.setProposals_UploadType(value);
}),
_idProps: {
service: idService,
name: "Dropdown_Status2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUploadTypeDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_Status3",
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0hAEr6C+V0GOozePlQusMA#Value", "Proposal type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("np+WZtgskUyJIcTQSTXE9Q#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.proposalTypeAttr.labelAttr;
},
list: model.variables.getProposalTypesAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.proposalTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getProposals_Type(), function (value) {
ConectaProveedoresClientVariables.setProposals_Type(value);
}),
_idProps: {
service: idService,
name: "Dropdown_Status3"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalTypesAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))))), createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.expandFilters$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "padding: 9px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.FilterPurple.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(true, controller.callContext(eventHandlerContext));
});
;
},
style: model.getCachedValue(idService.getId("tkF4MYpG0kCYmZr4SQ_qYQ.Style"), function () {
return ("margin-left-s " + (((((((((((((OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getProposals_ProposalSearch())) !== ("")) || !(ConectaProveedoresClientVariables.getProposals_Bank().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getProposals_PaymentDateFrom().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getProposals_PaymentDateTo().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getProposals_Region().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || ((ConectaProveedoresClientVariables.getProposals_Status()) !== (OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getProposals_AmountMLFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getProposals_AmountMLTo().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || ((ConectaProveedoresClientVariables.getProposals_Currency()) !== (OS$BuiltinFunctions.nullTextIdentifier()))) || ((ConectaProveedoresClientVariables.getProposals_UploadType()) !== (OS$BuiltinFunctions.nullIdentifier())))) ? ("") : ("visibility-hidden ")));
}, function () {
return ConectaProveedoresClientVariables.getProposals_ProposalSearch();
}, function () {
return ConectaProveedoresClientVariables.getProposals_Bank();
}, function () {
return ConectaProveedoresClientVariables.getProposals_PaymentDateFrom();
}, function () {
return ConectaProveedoresClientVariables.getProposals_PaymentDateTo();
}, function () {
return ConectaProveedoresClientVariables.getProposals_Region();
}, function () {
return ConectaProveedoresClientVariables.getProposals_Status();
}, function () {
return ConectaProveedoresClientVariables.getProposals_AmountMLFrom();
}, function () {
return ConectaProveedoresClientVariables.getProposals_AmountMLTo();
}, function () {
return ConectaProveedoresClientVariables.getProposals_Currency();
}, function () {
return ConectaProveedoresClientVariables.getProposals_UploadType();
}),
visible: true,
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_cerrar2.svg"),
style: "img-l",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "71"
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
uuid: "72",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
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
uuid: "73",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "img-m margin-left-base",
visible: true,
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_recargar2.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("3mxcFw8um0K8ooQJS5675A#Value", "Refresh Table"))];
})
},
_dependencies: []
})];
})
},
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalsAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getProposalsAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5dbqAfqM5EqQxlYTY0tPjQ#Value", "There are no proposals to show.")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setColumnVisiblityOnClick$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
name: "OpenPopupLink"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "font-semi-bold italic",
text: [$text(getTranslation("Da1ak081FE+DqIEDwMCPog#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "81"
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
uuid: "82",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getProposalsAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "ConectaProveedoresProposalsGetProposals"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.Name",
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Dh10wK_GxkSXl8niBcWekg#Value", "Proposal"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalType.Label",
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("o+8AArKSgUaNC6uk3WzS9g#Value", "Type"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.CreatedOn",
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("L4VYQPAoE0mwm5hlO1TqEw#Value", "Uploaded Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.PaymentDate",
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6Wp1I3zl4Eai71WMblA5RQ#Value", "Payment Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Bank.Name",
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("oqMg95Nko0OWKr0sjIzpkg#Value", "Bank"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Region.CommissionRegion",
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("C1NahIL6r0S+mgjyeBdZzg#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "Proposal.TotalValueML",
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Gn4vBUW1y0WF_SW6AzeZCg#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Currency.Code",
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("43_okU_MyUO3x77xBariZA#Value", "Currency ML"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "ProposalStatus.Label",
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("7KbFB5QWqUW1emMxpdp4yA#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6tI5jv_YnU2u9O8EXRhLtA#Value", "Document")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.hasErrorAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [$if(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.hasErrorAttr, false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalDetailError", {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "96"
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
i_NChar: 10,
i_Text: model.getCachedValue(idService.getId("MCKxLABbgkel7zClIPE7Rg.i_Text"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr) !== (""))) ? (model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr) : (model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
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
uuid: "97",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalDetail", {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "98"
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
i_NChar: 10,
i_Text: model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
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
uuid: "99",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("u4TlaDGiZ0eOK24gDBsrCg.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("C9XnUvm6lka85f_6oIhkGA.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr;
}),
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating ",
visible: true,
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr,
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr + " - ") + model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr),
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating ",
visible: true,
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("DlqVUr+fiE+K7biwMRPa2g.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr, "", 2, ".", ",");
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr;
}),
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr),
i_Class: model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
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
uuid: "123",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).uploadedByAttr.nameAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadFile$Action(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr === OS$BuiltinFunctions.nullTextIdentifier()), false, this, function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
title: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("It9gHitL2Ea26f5106ocEw#Value.795776775.1", "API Upload")
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_excelBlack.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
title: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gHfe_izjRkKmfAG8RLaYPw#Value.-1025651421.1", "Uploaded by:") + " ") + model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).uploadedByAttr.nameAttr)
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_excel.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}, callContext, idService, "6_0")
},
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
ConfigColumnJSON: model.variables.l_ColumnJSONVarGetProposalVar,
TableName: idService.getId("ConectaProveedoresProposalsGetProposals"),
PopupBtnId: idService.getId("OpenPopupLink")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
passColumnObj$Action: function (columnJSONIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.columnTogglerPassColumn$Action(columnJSONIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "131",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut)]
})), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
StartIndex: model.variables.l_StartIndexVar,
TotalCount: model.variables.getProposalsAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.paginationOnNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "132",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tableMaxRecords: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, {
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
refresh$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.paginationOnNavigate$Action(0, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "133",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
next: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-right",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))];
}),
footer: new Widget.PlaceholderContent(function () {
return [$if(model.variables.l_IsAutoRefreshVar, false, this, function () {
return [createElement(AutoRefreshUtils_Widget_EventExtensibilityBlock_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
EveryMilliseconds: 30000
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
eventFromJS$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "137",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsAutoRefreshVar), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getProposalsAggr.countOut), asPrimitiveValue(model.variables.getProposalsAggr.listOut), asPrimitiveValue(model.variables.getProposalsAggr.isDataFetchedAttr), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_AmountMLTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_AmountMLFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_Region()), asPrimitiveValue(model.variables.getProposalTypesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_Type()), asPrimitiveValue(model.variables.getUploadTypeDataAct.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_UploadType()), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_Currency()), asPrimitiveValue(model.variables.l_AmountToTextVar), asPrimitiveValue(model.variables.l_AmountFromTextVar), asPrimitiveValue(model.variables.l_ShowFiltersVar), asPrimitiveValue(model.variables.getProposalStatusAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_Status()), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_PaymentDateTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_PaymentDateFrom()), asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUploadTypeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalStatusAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBanksAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBanksAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_Bank()), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_ProposalSearch())]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ProposalsListViewer",
functionKey: "73b2fbb8-c617-4054-ad30-d71f2220e3bd",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_AdminCommissionsLeasing.ProposalsListViewer",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/ConectaProveedores.UserScripts.DropdownToggle.js"];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Interaction_Search_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, Telcel_Theme_Utils_Wb_CalendarClear_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, AutoRefreshUtils_Widget_EventExtensibilityBlock_mvc_view];
};


return ELEM;
};

export default componentFactory()
