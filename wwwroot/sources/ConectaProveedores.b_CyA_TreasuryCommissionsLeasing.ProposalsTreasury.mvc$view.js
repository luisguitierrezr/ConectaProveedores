import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedores_y_Utils_Wb_Sum_mvc_view from "./ConectaProveedores.y_Utils.Wb_Sum.mvc$view.js";
import OutSystemsUI_Interaction_Search_mvc_view from "./OutSystemsUI.Interaction.Search.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import Telcel_Theme_Utils_Wb_CalendarClear_mvc_view from "./Telcel_Theme.Utils.Wb_CalendarClear.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import { SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_proposalStatus as ConectaProveedores_staticEntities_proposalStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import OutSystemsUI_Interaction_Sidebar_mvc_view from "./OutSystemsUI.Interaction.Sidebar.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_ProposalLogs.mvc$view.js";
import ModelFactory from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.mvc$controller.js";
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
Initiative: "CYA",
ChatBotIsEnable: true
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
text: [$text(getTranslation("hKiXXx2WpEyn+VU12qBmYQ#Value", "Homepage"))],
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
text: [$text(getTranslation("G8Ac4c8iNUayLxwyfPwmkA#Value", "Dashboard"))],
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
text: [$text(getTranslation("PcWQDwhhB0iCR0Pui7RXpg#Value", "Proposals"))],
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
text: [$text(getTranslation("J3sVYawOcUWgbp31D5CMLA#Value", "Payment Proposals"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getProposalsSumAggr.isDataFetchedAttr && model.variables.getProposalsAggr.isDataFetchedAttr), false, this, function () {
return [createElement(ConectaProveedores_y_Utils_Wb_Sum_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Currency: model.variables.getProposalsSumAggr.listOut.getCurrent(callContext.iterationContext).symbolAttr,
_i_CurrencyInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsSumAggr.dataFetchStatusAttr),
i_Value: model.variables.getProposalsSumAggr.listOut.getCurrent(callContext.iterationContext).totalValueMLSumAttr,
_i_ValueInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsSumAggr.dataFetchStatusAttr)
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
uuid: "15",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4"
},
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})];
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
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "20"
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
uuid: "21"
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
uuid: "22",
alias: "3"
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
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("9musH46hJEiRrJyiAFV8aA#Value", "Search input"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("17z7uiuQHkyx2rafKRZGbQ#ValueExpression.-928198894.1", "Proposal"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getTreasury_ProposalSearch(), function (value) {
ConectaProveedoresClientVariables.setTreasury_ProposalSearch(value);
}),
_idProps: {
service: idService,
name: "Input_Nothing"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_ProposalSearch())]
})), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_Nothing"),
DebounceDelay: 700
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
uuid: "25",
alias: "4"
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
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_Region",
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("G51SgAIxdEqHcS4QcZgS6A#Value", "Region"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NuVGieJU8UeIv6eTjpm8WA#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return ((elem.regionAttr.commissionRegionAttr + " - ") + elem.regionAttr.nameAttr);
},
list: model.variables.getRegionsAggr.listOut,
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
return elem.regionAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, ConectaProveedoresClientVariables.getTreasury_Region(), function (value) {
ConectaProveedoresClientVariables.setTreasury_Region(value);
}),
_idProps: {
service: idService,
name: "Dropdown_Region"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRegionsAggr.dataFetchStatusAttr),
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
uuid: "29"
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
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("94xpW7gm90CV+1AwDwjAmA#Value", "Bank"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("l8pvme3WJU2Eu2oL77MKfQ#ValueExpression.65921.1", "All"),
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
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, ConectaProveedoresClientVariables.getTreasury_Bank(), function (value) {
ConectaProveedoresClientVariables.setTreasury_Bank(value);
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
uuid: "32"
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
DateFormat: "DD/MM/YYYY",
ShowTodayButton: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnPaymentDate$Action(OS$BuiltinFunctions.dateTimeToDate(selectedDateTimeIn), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "Datepicker",
alias: "5"
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
uuid: "34"
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
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("EtfKEpHRCE+e8F5Zfyy_Gw#Value", "Payment Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "36",
alias: "6"
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
i_Date: ConectaProveedoresClientVariables.getTreasury_PaymentDate()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
clear$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.paymentDateClear$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "37",
alias: "7"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("_qeuuYVLd06WseyCLgSxDg#ValueExpression.65921.1", "All"),
style: "form-control  cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getTreasury_PaymentDate(), function (value) {
ConectaProveedoresClientVariables.setTreasury_PaymentDate(value);
}),
_idProps: {
service: idService,
name: "Input_PaymentDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_PaymentDate())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_PaymentDate())]
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
uuid: "39"
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
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("uaE27Y3R10SH9VW0ICWsuA#Value", "Status"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("26y37cG+uUWLar8S5Yfy4w#ValueExpression.65921.1", "All"),
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
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getTreasury_Status(), function (value) {
ConectaProveedoresClientVariables.setTreasury_Status(value);
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
})), createElement(OSWidgets$Link, {
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
uuid: "42"
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
uuid: "43"
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
style: "margin-left-s",
visible: model.getCachedValue(idService.getId("ZqHACs8vaUWHtlpx4NCRlQ.Visible"), function () {
return ((((((((((ConectaProveedoresClientVariables.getTreasury_ProposalSearch()) !== (OS$BuiltinFunctions.nullTextIdentifier())) || !(ConectaProveedoresClientVariables.getTreasury_Region().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getTreasury_Bank().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getTreasury_PaymentDate().equals(OS$BuiltinFunctions.nullDate()))) || ((ConectaProveedoresClientVariables.getTreasury_Status()) !== (OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getTreasury_AmountMLFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getTreasury_AmountMLTo().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || ((ConectaProveedoresClientVariables.getTreasury_Assigned()) !== (OS$BuiltinFunctions.nullTextIdentifier()))) || !(ConectaProveedoresClientVariables.getTreasury_CreationDate().equals(OS$BuiltinFunctions.nullDate())));
}, function () {
return ConectaProveedoresClientVariables.getTreasury_ProposalSearch();
}, function () {
return ConectaProveedoresClientVariables.getTreasury_Region();
}, function () {
return ConectaProveedoresClientVariables.getTreasury_Bank();
}, function () {
return ConectaProveedoresClientVariables.getTreasury_PaymentDate();
}, function () {
return ConectaProveedoresClientVariables.getTreasury_Status();
}, function () {
return ConectaProveedoresClientVariables.getTreasury_AmountMLFrom();
}, function () {
return ConectaProveedoresClientVariables.getTreasury_AmountMLTo();
}, function () {
return ConectaProveedoresClientVariables.getTreasury_Assigned();
}, function () {
return ConectaProveedoresClientVariables.getTreasury_CreationDate();
}),
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_cerrar2.svg"),
style: "img-l",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-base display-flex",
visible: model.variables.l_ShowFiltersVar,
_idProps: {
service: idService,
uuid: "46"
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
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_AmountML3",
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3G2nqASSPkK1VE8Yk5m4fA#Value", "From (Amount ML)"))), createElement(OSWidgets$Input, {
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
name: "Input_AmountML3"
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
PrefixText: "",
SuffixText: "",
RightAlign: true,
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_AmountML3"),
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
GroupSeparator: ","
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
uuid: "50",
alias: "8"
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
WidgetId: idService.getId("Input_AmountML3")
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
uuid: "51",
alias: "9"
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
uuid: "52"
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
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("fJGu5LcLn028DaXfx3kwhQ#Value", "To (Amount ML)"))), createElement(OSWidgets$Input, {
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
AlwaysShowDecimalDigits: true,
GroupSeparator: ",",
SuffixText: "",
UseNumericInput: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_AmountML2"),
DecimalSeparator: ".",
PrefixText: "",
RightAlign: true
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
uuid: "55",
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
WidgetId: idService.getId("Input_AmountML2"),
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
uuid: "56",
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
uuid: "57"
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
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jjQcWU+470qdQrHUnO187g#Value", "Signed to"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("tdsDW2MFGkO3z9BwJ9jOjw#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.nameAttr;
},
list: model.variables.getProposalsAssignAggr.listOut,
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
return elem.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getTreasury_Assigned(), function (value) {
ConectaProveedoresClientVariables.setTreasury_Assigned(value);
}),
_idProps: {
service: idService,
name: "Dropdown_Status2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAssignAggr.dataFetchStatusAttr),
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
uuid: "60"
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
DateFormat: "DD/MM/YYYY"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnCreationDate$Action(selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "Datepicker2",
alias: "12"
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
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_CreationDate",
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("v_JzgzSDzU2RCXxjW5r+dA#Value", "Creation Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "64",
alias: "13"
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
i_Date: ConectaProveedoresClientVariables.getTreasury_CreationDate()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
clear$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.creationDateClear$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "65",
alias: "14"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3ca_i_AECE2Ue8mxQ7N4jQ#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getTreasury_CreationDate(), function (value) {
ConectaProveedoresClientVariables.setTreasury_CreationDate(value);
}),
_idProps: {
service: idService,
name: "Input_CreationDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_CreationDate())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_CreationDate())]
}))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "67"
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
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("anZz9Za9qk6RRgRpYYKF8A#Value", "You have no pending proposals to pay")))];
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
uuid: "69"
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
text: [$text(getTranslation("A8fqPOUkvkGdrBcwJ0K4DA#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "72"
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
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default,
Orientation: ConectaProveedores_staticEntities_orientation.horizontal
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
name: "ConectProveedoresProposalsTreasuryGetProposals"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.Name",
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("xeX51DjDBkO0nhXnGU39DA#Value", "Proposal"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalType.Label",
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Trdt+QoYDUuveWzlVCiCLw#Value", "Type"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.CreatedOn",
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("F_j3bOdTvUaCRD0AjCvmNg#Value", "Uploaded Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.PaymentDate",
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("b5y4rCZkNkijUJ+yxKpnXA#Value", "Payment Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.ProposalDate",
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("th9B+65OpkCjx+MiyFqGkg#Value", "Proposal Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Bank.Name",
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Pub6AxUsbUOJPJeeslc7Lw#Value", "Bank"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Region.CommissionRegion",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("d+_fO9mgC0mds3eItz7BAg#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.TotalValueML",
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("a8FDsDnBdkKnEEk5lHYaoQ#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Currency.Code",
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("lvgBIdgFfESbdBZI5tc38Q#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "ProposalStatus.Label",
style: "donotshow",
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6deXNVVP2Ee9lN23Jysafw#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("DS5zDEULQ0KAXyeA9i2ujA#Value", "Document"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("rr_KRpKJXki3aq+f+jTC8Q#Value", "Assigned to")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("vR9A7prS2EWuFTfeCnyFbg.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalDetailTreasury", {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "90"
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
uuid: "91",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("uetlyGOjbE+WRjydXEX+aQ.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("vpLq9YhyNUmlS8fxLDE6tw.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("nC66lcTgeUS1a6d_U1wC8A.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("dn_bkJpfL0yizSpTwzN9aQ.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("1fUBIWmUjEK1G6WWFjLVUQ.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr;
}),
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("rhWShoD8v0WQPbY1xPuJnA.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalDateAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("bYjmyopLNkm1HokmtpskdQ.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalDateAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalDateAttr;
}),
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("WJKcNO+FwkKOgiZWKOmF7Q.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("ln9Dx6O360SuZaCbyyxrMw.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr)]
}, createElement(OSWidgets$Expression, {
value: ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr + " - ") + model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr),
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("OLgI9S9qUkmeE+DuNsfSEA.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
style: "text-align-right",
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("8LOIAafbGE2w4QDK3y3SRA.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr, "", 2, ".", ",");
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr;
}),
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("A_uT4pJcW0GrcwE8mfZmVA.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("8XAVlf9Lr0OnEGCsijLNIQ.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
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
uuid: "109",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("JJMBxDE7bUWzuGcqjmwobQ.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showlogByProposal$Action(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("QzK72N9KNUCwWqpwzIIf7A.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "114"
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
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_excel.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider
})))), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("pi3oBBDqWE6XXlMoUF_J7A.style"), function () {
return ((((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid) || ((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.lt(OS$BuiltinFunctions.currDate())))) ? (" background-color: var(--color-neutral-2);") : (" "));
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
}, function () {
return model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr)]
}, $if((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.nullTextIdentifier()), false, this, function () {
return [];
}, function () {
return [$if((model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.getUserId()), false, this, function () {
return [$text(getTranslation("STs74kngtkGVu7TxAoN63g#Value", "To Myself"))];
}, function () {
return [createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getProposalsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalsAggr.dataFetchStatusAttr),
i_NChar: 10
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
uuid: "118",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})];
}))];
}, callContext, idService, "5_0")
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
ConfigColumnJSON: model.variables.l_ColumnJSONVarGetProposalsTreasuryVar,
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
PopupBtnId: idService.getId("OpenPopupLink"),
TableName: idService.getId("ConectProveedoresProposalsTreasuryGetProposals")
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
uuid: "119",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalsTreasuryVar), asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.listOut)]
})), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartIndex: model.variables.startIndexVar,
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
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
uuid: "120",
alias: "20"
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
uuid: "121",
alias: "21"
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
uuid: "122"
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
uuid: "123"
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
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OutSystemsUI_Interaction_Sidebar_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
HasOverlay: false,
Width: "700"
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
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-sub-heading",
visible: true,
_idProps: {
service: idService,
uuid: "126"
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
uuid: "127",
alias: "23"
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
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("EO9U+r6rg0qqGTFFanGitw#Value", "Historic"))), createElement(OSWidgets$Container, {
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
uuid: "129"
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
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
}))];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_refresh: model.variables.l_RefeshSideBarVar,
i_ProposalId: model.variables.l_proposalIdVar
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
uuid: "132",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_proposalIdVar), asPrimitiveValue(model.variables.l_RefeshSideBarVar)]
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_proposalIdVar), asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalsTreasuryVar), asPrimitiveValue(model.variables.getProposalsAssignAggr.listOut), asPrimitiveValue(model.variables.l_AmountToTextVar), asPrimitiveValue(model.variables.l_AmountFromTextVar), asPrimitiveValue(model.variables.l_ShowFiltersVar), asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_CreationDate()), asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_Assigned()), asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_AmountMLTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_AmountMLFrom()), asPrimitiveValue(model.variables.getProposalStatusAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_Status()), asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_PaymentDate()), asPrimitiveValue(model.variables.getBanksAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_Bank()), asPrimitiveValue(model.variables.getRegionsAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_Region()), asPrimitiveValue(ConectaProveedoresClientVariables.getTreasury_ProposalSearch()), asPrimitiveValue(model.variables.getProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAssignAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalStatusAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBanksAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRegionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsSumAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalsAggr.countOut), asPrimitiveValue(model.variables.getProposalsAggr.listOut), asPrimitiveValue(model.variables.getProposalsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProposalsSumAggr.listOut.getCurrent(callContext.iterationContext).totalValueMLSumAttr), asPrimitiveValue(model.variables.getProposalsSumAggr.listOut.getCurrent(callContext.iterationContext).symbolAttr), asPrimitiveValue(model.variables.getProposalsSumAggr.isDataFetchedAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ProposalsTreasury",
functionKey: "1e9ceae2-487c-4b91-bc04-f9a7b8ed9082",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury",
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
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, ConectaProveedores_y_Utils_Wb_Sum_mvc_view, OutSystemsUI_Interaction_Search_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, Telcel_Theme_Utils_Wb_CalendarClear_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, OutSystemsUI_Interaction_Sidebar_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view];
};


return ELEM;
};

export default componentFactory()
