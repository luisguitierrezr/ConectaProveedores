import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, Checkbox as OSWidgets$Checkbox, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedores_y_Utils_Wb_Sum_mvc_view from "./ConectaProveedores.y_Utils.Wb_Sum.mvc$view.js";
import OutSystemsUI_Interaction_Search_mvc_view from "./OutSystemsUI.Interaction.Search.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import Telcel_Theme_Utils_Wb_CalendarClear_mvc_view from "./Telcel_Theme.Utils.Wb_CalendarClear.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view from "./ConectaProveedores.y_Utils.Wb_SearchSupplierDropdown.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_proposalStatus as ConectaProveedores_staticEntities_proposalStatus, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import Telcel_Theme_Utils_Wb_SupplierName_mvc_view from "./Telcel_Theme.Utils.Wb_SupplierName.mvc$view.js";
import ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvc_view from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.Wb_GetProposalStatusByLevel.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_mvc_view from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.Wb_RejectedCommentTooltip.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_RejectApprovalPopup_mvc_view from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.Wb_RejectApprovalPopup.mvc$view.js";
import OutSystemsUI_Interaction_Sidebar_mvc_view from "./OutSystemsUI.Interaction.Sidebar.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_ProposalLogs.mvc$view.js";
import ModelFactory from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.mvc$controller.js";
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
text: [$text(getTranslation("r2tNet6hd0y8SVpfBkMtfQ#Value", "Homepage"))],
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
text: [$text(getTranslation("qQzBTa8M3U+K1MsJfiDruQ#Value", "Dashboard"))],
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
text: [$text(getTranslation("pZTTLcFxuUCVJTtZqf6xCw#Value", "Commissions and Leases"))],
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
text: [$text(getTranslation("Ev3JWlaIO0eap9y0kvzY9g#Value", "Commissions and Leases"))],
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
}, $if((model.variables.getProposalLinesSumAggr.isDataFetchedAttr && model.variables.getProposalLinesAggr.isDataFetchedAttr), false, this, function () {
return [createElement(ConectaProveedores_y_Utils_Wb_Sum_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Value: model.variables.getProposalLinesSumAggr.listOut.getCurrent(callContext.iterationContext).importeenMLSumAttr,
_i_ValueInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesSumAggr.dataFetchStatusAttr),
i_Currency: model.variables.getProposalLinesSumAggr.listOut.getCurrent(callContext.iterationContext).symbolAttr,
_i_CurrencyInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesSumAggr.dataFetchStatusAttr)
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
extendedProperties: {
style: "height: (auto);"
},
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
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
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
classes: "ThemeGrid_Width10"
},
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
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("kmCyQ0LG00K1Ot6nuHNakw#Value", "Search input"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("6YzXj1h_9kS5sTzkW7gUjg#ValueExpression.-928198894.1", "Proposal"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getCommision_Leases_ProposalSearch(), function (value) {
ConectaProveedoresClientVariables.setCommision_Leases_ProposalSearch(value);
}),
_idProps: {
service: idService,
name: "Input_Nothing2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_ProposalSearch())]
})), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_Nothing2"),
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
uuid: "26",
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
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("bBN_bNOfgk62wqOn9QKJxg#Value", "Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("wKGLjTPGxEaLMNp77rT8Sw#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.proposalTypeAttr.labelAttr;
},
list: model.variables.getProposalTypeAggr.listOut,
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
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getCommision_Leases_TypeId(), function (value) {
ConectaProveedoresClientVariables.setCommision_Leases_TypeId(value);
}),
_idProps: {
service: idService,
name: "Dropdown9"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalTypeAggr.dataFetchStatusAttr),
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
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("F6DiWNV+gEqYUjNUWYsepw#Value", "Status"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("7may7Nqie0iNZV+cmWUGDg#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.approvalStatusAttr.labelAttr;
},
list: model.variables.getApprovalStatusesAggr.listOut,
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
return elem.approvalStatusAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getCommision_Leases_ApprovalStatusId(), function (value) {
ConectaProveedoresClientVariables.setCommision_Leases_ApprovalStatusId(value);
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentProposalStatusId"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApprovalStatusesAggr.dataFetchStatusAttr),
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
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("DcirAMJaBU+JYGbrAUisfQ#Value", "Bank"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZiwkVqGB_U65KYRyXQeHkA#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.bankAttr.shortNameAttr;
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
style: "dropdown",
values: function (elem) {
return elem.bankAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, ConectaProveedoresClientVariables.getCommision_Leases_BankId(), function (value) {
ConectaProveedoresClientVariables.setCommision_Leases_BankId(value);
}),
_idProps: {
service: idService,
name: "Dropdown_BankId"
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
uuid: "36"
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
controller.datePickerOnPaymentDate$Action(selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerPaymentDate",
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
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ob6Zx+NuaE+K4dx7E4gQMQ#Value", "Payment Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "40",
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
i_Date: ConectaProveedoresClientVariables.getCommision_Leases_PaymentDate()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
clear$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CalendarClearClear$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "41",
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Jn_ekzZxSE2E5hAIyTwXvA#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getCommision_Leases_PaymentDate(), function (value) {
ConectaProveedoresClientVariables.setCommision_Leases_PaymentDate(value);
}),
_idProps: {
service: idService,
name: "Input_PaymentDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_PaymentDate())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_PaymentDate())]
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
uuid: "43"
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
uuid: "44"
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
visible: model.getCachedValue(idService.getId("Qy0tJkFCTEeg53ZyvuzNAA.Visible"), function () {
return (((((((((!(ConectaProveedoresClientVariables.getCommision_Leases_AmountMLFrom().equals(OS$BuiltinFunctions.integerToDecimal(0))) || ((ConectaProveedoresClientVariables.getCommision_Leases_ApprovalStatusId()) !== (OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getCommision_Leases_AssignedTo().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getCommision_Leases_BankId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getCommision_Leases_PaymentDate().equals(OS$BuiltinFunctions.nullDate()))) || ((ConectaProveedoresClientVariables.getCommision_Leases_ProposalSearch()) !== (""))) || !(ConectaProveedoresClientVariables.getCommision_Leases_RegionId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getCommision_Leases_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || ((ConectaProveedoresClientVariables.getCommision_Leases_TypeId()) !== (OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getCommision_Leases_UploadDate().equals(OS$BuiltinFunctions.nullDate())));
}, function () {
return ConectaProveedoresClientVariables.getCommision_Leases_AmountMLFrom();
}, function () {
return ConectaProveedoresClientVariables.getCommision_Leases_ApprovalStatusId();
}, function () {
return ConectaProveedoresClientVariables.getCommision_Leases_AssignedTo();
}, function () {
return ConectaProveedoresClientVariables.getCommision_Leases_BankId();
}, function () {
return ConectaProveedoresClientVariables.getCommision_Leases_PaymentDate();
}, function () {
return ConectaProveedoresClientVariables.getCommision_Leases_ProposalSearch();
}, function () {
return ConectaProveedoresClientVariables.getCommision_Leases_RegionId();
}, function () {
return ConectaProveedoresClientVariables.getCommision_Leases_SupplierId();
}, function () {
return ConectaProveedoresClientVariables.getCommision_Leases_TypeId();
}, function () {
return ConectaProveedoresClientVariables.getCommision_Leases_UploadDate();
}),
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_cerrar2.svg"),
style: "img-l",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "display-flex margin-top-base",
visible: model.variables.l_ShowFiltersVar,
_idProps: {
service: idService,
uuid: "47"
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
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsValid: true,
i_IsDisable: false,
i_IsFilter: true,
i_IsMandatory: false,
i_SupplierId: ConectaProveedoresClientVariables.getCommision_Leases_SupplierId()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function (supplierIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSuppliersOnChanged$Action(supplierIdIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "49",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
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
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("IZ8WXttlWUCXunfYGQP8Iw#Value", "Soc."))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("GXbSMql1MUePkvSRyAGbpg#ValueExpression.65921.1", "All"),
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
labels: function (elem) {
return elem.companyAttr.externalIdAttr;
},
list: model.variables.getCompaniesAggr.listOut,
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
return elem.companyAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, ConectaProveedoresClientVariables.getCommision_Leases_CompanyId(), function (value) {
ConectaProveedoresClientVariables.setCommision_Leases_CompanyId(value);
}),
_idProps: {
service: idService,
name: "Dropdown_Operator_AmountML2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCompaniesAggr.dataFetchStatusAttr),
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
visible: false,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("bElJL61IU0WVRn_sZSgzqw#Value", "Operator"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: " ",
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
labels: function (elem) {
return elem.operatorAttr.labelAttr;
},
list: model.variables.getOperatorsAggr.listOut,
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
return elem.operatorAttr.operatorAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getCommision_Operator_AmountML(), function (value) {
ConectaProveedoresClientVariables.setCommision_Operator_AmountML(value);
}),
_idProps: {
service: idService,
name: "Dropdown_Operator_AmountML"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOperatorsAggr.dataFetchStatusAttr),
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
uuid: "56"
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
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("8HZQ+UU8D0WT1fYPUExgFg#Value", "From (Amount ML)"))), createElement(OSWidgets$Input, {
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
InputId: idService.getId("Input_AmountML3"),
AlwaysShowDecimalDigits: true,
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: true,
PrefixText: "",
DecimalSeparator: ".",
GroupSeparator: ",",
UseNumericInput: true
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
uuid: "59",
alias: "9"
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
WidgetId: idService.getId("Input_AmountML3"),
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
uuid: "60",
alias: "10"
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
uuid: "61"
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
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("e7V7bsBtM0ioJrdxa4YfMw#Value", "To (Amount ML)"))), createElement(OSWidgets$Input, {
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
UseNumericInput: true,
PrefixText: "",
GroupSeparator: ",",
RightAlign: true,
SuffixText: "",
InputId: idService.getId("Input_AmountML2"),
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: "."
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
alias: "11"
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
uuid: "65",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.l_IsShowSelectAllVar, false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: ((model.variables.l_IsSelectAllVar === true) || (model.variables.l_IsSelectedVar === true)),
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.approveSelectedOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn bulkrapprove",
visible: true,
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_exito.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "text-third margin-left-s",
text: [$text(getTranslation("FdKu7lpU2E+9+oi8BvZ+aw#Value", "Bulk Approve"))],
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})))), $if(model.variables.l_IsAllowSelectApplicationRolesVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel auto-width margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("gPXMZ+fJ8EeNbPinUQsJLA#Value", "Approval Level"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: true,
labels: function (elem) {
return elem.roleNameAttr;
},
list: model.variables.getUserApplicationRolesDataAct.userRolesListOut,
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
return elem.applicationRoleIdAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.l_ApplicationRoleIdForAggregateVar, function (value) {
model.variables.l_ApplicationRoleIdForAggregateVar = value;
}),
_idProps: {
service: idService,
name: "Dropdown_l_ApplicationRoleIdForAggregate"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalLinesAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getProposalLinesAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("W03yrmzC5025VvUA5crMmw#Value", "You have no pending payments to authorize")))];
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
uuid: "75"
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
text: [$text(getTranslation("48R8TmCjskmkF93RjLb_Aw#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
uuid: "78",
alias: "13"
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
source: model.variables.getProposalLinesAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "ConectaProveedoresApprovalCommissionsandLeasesGetP"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar)]
}, $if(model.variables.l_IsShowSelectAllVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsHorizontal: true
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
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.selectAllLines$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.l_IsSelectAllVar, function (value) {
model.variables.l_IsSelectAllVar = value;
}),
_idProps: {
service: idService,
name: "Checkbox3"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsSelectAllVar)]
}))];
}, function () {
return [];
})), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Nombre1",
style: "donotshow",
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("JKkf7GI8GEW3uMuvr0_ipg#Value", "Supplier"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.N_DocType",
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Pw6mDMToxE+6R5FMllDc5w#Value", "Document"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.Name",
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("RwAajlH0tEWyWwHNcYBMgA#Value", "Proposal"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalType.Label",
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("AlW1fNGFs0aWfyBl2et04A#Value", "Proposal Type"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ApplicationRole.Name",
style: "donotshow",
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("JCG2PFFjAkCt+G2TBNQNIQ#Value", "Assigned"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "ProposalLine.ImporteenML",
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("10aH4NJIPk+Ah8fANurePQ#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.PaymentDate",
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Mgz+N4esUUaSr1sK+KQ4LA#Value", "Payment Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Bank.Code",
style: "donotshow",
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("kG7ZniUEqE2ZkRFZ2_EQ7Q#Value", "Bank"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Soc_",
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("PoZKuML5jUOLW0koISek_Q#Value", "Soc."))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Region.DivisionFI",
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("x0hES8V1s0Seq+jS_0WaKw#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "ApprovalStatus.Label",
style: "donotshow",
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("C0DaYwSLS0qKMWuTRmhwPA#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center; "
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("PqVwbrZCKEqlkf1axLFDvQ#Value", "Approval")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("d1Y2IsLi4kOs3KwnPCTfsg.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.approvalStatusIdAttr)]
}, $if((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsHorizontal: true
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
uuid: "101",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.isAnyLineSelected$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr, function (value) {
model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr)]
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("bke6P78QXkCnI63CS40nqg.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.cuentaAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 16px;"
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_SupplierName_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_SupplierName: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr,
_i_SupplierNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr),
i_SupplierNumber: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.cuentaAttr,
_i_SupplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr),
i_NChar: 20
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
uuid: "106",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("+3iUxaufJU6tBn3fXJ3aMA.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_DocTypeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_DocTypeAttr,
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("F_b+JHUmI0WfIRqcryrzxw.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr,
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("iitDbNS0W0i8oJCyw5xaZw.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("yXUas__A1EyIaBF558DFXQ.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr,
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("EdTZAr810UWd123B21GWMg.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
style: "text-align-right",
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("W_Ln06MGgEGtRi9v3BXCkA.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr, "", 2, ".", ",");
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr;
}),
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("5qW+rXj+CE2G+IXUvaqdhw.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("0UxqAiBp8kelUw5w+BtK3A.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr;
}),
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("eM49rVIQfEONlD4kF0wH3w.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr,
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("+nveltT7CkO2nCnMl2BtnA.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr,
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("x6GnR2NPVkaJusN9y6VVdw.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("u6jWWTxTwU6mlxzKUFXvxQ.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr)]
}, createElement(ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ApprovalStatusLabel: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr,
_i_ApprovalStatusLabelInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr),
i_Class: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
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
uuid: "126",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("3XGTBHRqpECr5672vnp78A.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showDocumentLog$Action(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.idAttr, model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_doc_Attr, model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.proposalIdAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: ("text-align: center;" + (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);")))
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.idAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.approvalStatusIdAttr)]
}, $if((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.rejected), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "132",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_chat.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ProposalLineApprovalLevelId: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.idAttr,
_i_ProposalLineApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
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
uuid: "134",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.idAttr)]
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("WrieM4pSDkW9Pw475C8sjQ.style"), function () {
return (((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval)) ? (" ") : (" background-color: var(--color-neutral-2);"));
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.approvalStatusIdAttr)]
}, $if((model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showRejectPopup$Action(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
gridProperties: {
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.approveOnClick$Action(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_exito.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
}))];
}, callContext, idService, "7_0")
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ConfigColumnJSON: model.variables.l_ColumnJSONVarGetProposalLinesVar,
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
PopupBtnId: idService.getId("OpenPopupLink"),
TableName: idService.getId("ConectaProveedoresApprovalCommissionsandLeasesGetP")
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
uuid: "141",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalLinesVar), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut)]
})];
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TotalCount: model.variables.getProposalLinesAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr),
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
StartIndex: model.variables.l_StartIndexVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onPaginationNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "142",
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
return controller.onPaginationNavigate$Action(0, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "143",
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
uuid: "144"
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
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
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
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowRejectPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_RejectApprovalPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ProposalId: model.variables.l_ProposalIdForRejectPopupVar,
i_ProposalLineApprovalLevelIdToReject: model.variables.l_ProposalLineApprovalLevelIdToRejectVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
reject$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.rejectPopupReject$Action(controller.callContext(eventHandlerContext));
});
;
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.rejectPopupClose$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "148",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OutSystemsUI_Interaction_Sidebar_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
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
name: "SidebarDocumentLog",
alias: "24"
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
uuid: "150"
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
uuid: "151",
alias: "25"
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
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("r7nzOP5+cUi+dr8vmN58Bw#Value", "Historic"))), createElement(OSWidgets$Container, {
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
uuid: "153"
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
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.l_SelectdLogDocumentNumberVar,
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider
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
i_ProposalLineId: model.variables.l_SelectdLogDocumentIdVar,
i_refresh: model.variables.l_RefeshDocumentSideBarVar,
i_ProposalId: model.variables.l_SelectdLogProposalIdVar
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
uuid: "158",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_SelectdLogProposalIdVar), asPrimitiveValue(model.variables.l_RefeshDocumentSideBarVar), asPrimitiveValue(model.variables.l_SelectdLogDocumentIdVar), asPrimitiveValue(model.variables.l_SelectdLogDocumentNumberVar)]
})];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_SelectdLogProposalIdVar), asPrimitiveValue(model.variables.l_RefeshDocumentSideBarVar), asPrimitiveValue(model.variables.l_SelectdLogDocumentIdVar), asPrimitiveValue(model.variables.l_SelectdLogDocumentNumberVar), asPrimitiveValue(model.variables.l_ProposalLineApprovalLevelIdToRejectVar), asPrimitiveValue(model.variables.l_ProposalIdForRejectPopupVar), asPrimitiveValue(model.variables.l_ShowRejectPopupVar), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalLinesVar), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.userRolesListOut), asPrimitiveValue(model.variables.l_ApplicationRoleIdForAggregateVar), asPrimitiveValue(model.variables.l_IsAllowSelectApplicationRolesVar), asPrimitiveValue(model.variables.l_IsSelectedVar), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.l_AmountToTextVar), asPrimitiveValue(model.variables.l_AmountFromTextVar), asPrimitiveValue(model.variables.getOperatorsAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Operator_AmountML()), asPrimitiveValue(model.variables.getCompaniesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_CompanyId()), asPrimitiveValue(model.variables.l_ShowFiltersVar), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_UploadDate()), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_SupplierId()), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_RegionId()), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_AssignedTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_AmountMLFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_PaymentDate()), asPrimitiveValue(model.variables.getBanksAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_BankId()), asPrimitiveValue(model.variables.getApprovalStatusesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_ApprovalStatusId()), asPrimitiveValue(model.variables.getProposalTypeAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_TypeId()), asPrimitiveValue(ConectaProveedoresClientVariables.getCommision_Leases_ProposalSearch()), asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOperatorsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBanksAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalTypeAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesSumAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.countOut), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut), asPrimitiveValue(model.variables.getProposalLinesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProposalLinesSumAggr.listOut.getCurrent(callContext.iterationContext).symbolAttr), asPrimitiveValue(model.variables.getProposalLinesSumAggr.listOut.getCurrent(callContext.iterationContext).importeenMLSumAttr), asPrimitiveValue(model.variables.getProposalLinesSumAggr.isDataFetchedAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ApprovalCommissionsandLeases",
functionKey: "16670669-0ebd-429a-a63b-509326264cee",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, ConectaProveedores_y_Utils_Wb_Sum_mvc_view, OutSystemsUI_Interaction_Search_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, Telcel_Theme_Utils_Wb_CalendarClear_mvc_view, ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, Telcel_Theme_Utils_Wb_SupplierName_mvc_view, ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_RejectApprovalPopup_mvc_view, OutSystemsUI_Interaction_Sidebar_mvc_view, ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view];
};


return ELEM;
};

export default componentFactory()
