import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Button as OSWidgets$Button, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedores_y_Utils_Wb_Sum_mvc_view from "./ConectaProveedores.y_Utils.Wb_Sum.mvc$view.js";
import OutSystemsUI_Interaction_Search_mvc_view from "./OutSystemsUI.Interaction.Search.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import { ST_4e53cb8815b86020ced1d2f2652c9b1dStructure, ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ST_bc4abb4233d9ce894e855c520a20c76fStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import Telcel_Theme_Utils_Wb_CalendarClear_mvc_view from "./Telcel_Theme.Utils.Wb_CalendarClear.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { SE_position as ConectaProveedores_staticEntities_position, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import OutSystemsUI_Interaction_Sidebar_mvc_view from "./OutSystemsUI.Interaction.Sidebar.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_ProposalLogs.mvc$view.js";
import AutoRefreshUtils_Widget_EventExtensibilityBlock_mvc_view from "./AutoRefreshUtils.Widget.EventExtensibilityBlock.mvc$view.js";
import ModelFactory from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.mvc$controller.js";
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
text: [$text(getTranslation("WchpD1hxAkuyFrgXaChEWQ#Value", "Homepage"))],
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
text: [$text(getTranslation("f5eODVwN+EiusilXjkSvSA#Value", "Dashboard"))],
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
text: [$text(getTranslation("J5exeohVqkS0PPxB2OFB9g#Value", "Proposals"))],
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
text: [$text(getTranslation("7rBZAcx7_k6yncxdLA4TsA#Value", "Proposals"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}), " "];
}),
actions: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getProposalDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(ConectaProveedores_y_Utils_Wb_Sum_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Value: model.variables.getProposalDataAct.sumOut,
_i_ValueInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr),
i_Currency: ""
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
uuid: "14",
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
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (!(model.variables.isBusyVar)),
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
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_buscar2.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("UpVtXCGlBkmrCFk1hZlxBQ#Value", "Search for document"))],
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Button, {
enabled: (!(model.variables.isBusyVar)),
extendedProperties: {
style: "width: auto;"
},
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadPreviousMonthProposals$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_descargar2.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("UeLHYTlG7UOtjUjhKVLk1Q#Value", "Previous Month Report"))],
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width10"
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "27"
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
uuid: "28"
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
uuid: "29",
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
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7TWRogxw6UishAPPpo5AMw#Value", "Search input"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kNFe1lYDx0uYPBpYVuTkyQ#ValueExpression.-928198894.1", "Proposal"),
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
uuid: "32",
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
}, $text(getTranslation("m+MwSep9c0OwmF1Pc9eang#Value", "Region"))), $if(model.variables.getRegionsAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("X4pfJDKySUu0aI9HyY2S_Q#Value.287943634.1", "Select..."),
OptionalConfigs: model.getCachedValue(idService.getId("dropregions.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.allowMultipleSelectionAttr = true;
return rec;
}();
}),
StartingSelection: model.variables.l_SelectedRegionsVar,
OptionsList: model.getCachedValue(idService.getId("dropregions.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getRegionsAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.regionAttr.idAttr);
target.labelAttr = ((source.regionAttr.commissionRegionAttr + " - ") + source.regionAttr.nameAttr);
return target;
});
}, function () {
return model.variables.getRegionsAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRegionsAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSearchOnChangedRegions$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
});
;
},
initialized$Action: function (dropdownSearchIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdownSearchInitialized$Action(dropdownSearchIdIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "dropregions",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
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
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelindex",
targetWidget: "Dropdown_Bank",
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("8WuT06CZz0eZ1TY0M8VmRQ#Value", "Bank"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XYg_TuTaGEyTfuWkoKbcSw#ValueExpression.65921.1", "All"),
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
uuid: "39"
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
OptionalConfigs: model.getCachedValue(idService.getId("Datepicker2.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
return rec;
}();
}),
DateFormat: "DD/MM/YYYY",
ShowTodayButton: true
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
alias: "6"
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
uuid: "41"
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
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("VfFqMfTm10C6SxAT6kMKPw#Value", "Payment Date from"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "43",
alias: "7"
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
uuid: "44",
alias: "8"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("bDcylsBJzkatiPWmPdPZMg#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
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
uuid: "46"
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
ShowTodayButton: true,
OptionalConfigs: model.getCachedValue(idService.getId("Datepicker.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
return rec;
}();
})
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
alias: "9"
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
uuid: "48"
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
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1vPNkYBLckSHPE3+1cb8fQ#Value", "Payment Date to"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "50",
alias: "10"
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
uuid: "51",
alias: "11"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("PjrFM60ppU6ty_9YwaheOQ#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
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
}, $text(getTranslation("Q06jV5yHpE61tse3NZCMAA#Value", "Status"))), $if(model.variables.getProposalStatusDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("wrJ4DpeUo0GHq_SejzxyJg#Value.287943634.1", "Select..."),
OptionsList: model.getCachedValue(idService.getId("dropstatus.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getProposalStatusDataAct.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = (source.idAttr).toString();
target.labelAttr = source.labelAttr;
return target;
});
}, function () {
return model.variables.getProposalStatusDataAct.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalStatusDataAct.dataFetchStatusAttr),
OptionalConfigs: model.getCachedValue(idService.getId("dropstatus.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.allowMultipleSelectionAttr = true;
return rec;
}();
}),
StartingSelection: model.variables.l_SelectedStatusVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
initialized$Action: function (dropdownSearchIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdownSearchInitialized2$Action(dropdownSearchIdIn, controller.callContext(eventHandlerContext));

;
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSearchOnChangedStatus$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "dropstatus",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-base",
visible: model.variables.l_ShowFiltersVar,
_idProps: {
service: idService,
uuid: "56"
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
uuid: "57"
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
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("GAgLMjav20aoxJITYRnPkg#Value", "From (Amount ML)"))), createElement(OSWidgets$Input, {
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
GroupSeparator: ",",
SuffixText: "",
InputId: idService.getId("Input_AmountML"),
RightAlign: true,
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
PrefixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2)
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
alias: "13"
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
WidgetId: idService.getId("Input_AmountML")
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
uuid: "61",
alias: "14"
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
uuid: "62"
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
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("lgURDlxrLEGhyCQwoNPrWA#Value", "To (Amount ML)"))), createElement(OSWidgets$Input, {
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
RightAlign: true,
PrefixText: "",
GroupSeparator: ",",
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
SuffixText: "",
InputId: idService.getId("Input_AmountML2")
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
alias: "15"
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
uuid: "66",
alias: "16"
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
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("S7q3yI+WskKTRUg1_K7Rvw#Value", "Currency"))), $if(model.variables.getCurrenciesAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartingSelection: model.variables.l_SelectedCurrencyVar,
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("_JkyRo+HZkKsQ4q2yBJ61g#Value.287943634.1", "Select..."),
OptionalConfigs: model.getCachedValue(idService.getId("dropcurrency.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.allowMultipleSelectionAttr = true;
return rec;
}();
}),
OptionsList: model.getCachedValue(idService.getId("dropcurrency.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getCurrenciesAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = source.currencyAttr.codeAttr;
target.labelAttr = source.currencyAttr.nameAttr;
return target;
});
}, function () {
return model.variables.getCurrenciesAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
initialized$Action: function (dropdownSearchIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdownSearchInitialized3$Action(dropdownSearchIdIn, controller.callContext(eventHandlerContext));

;
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSearchOnChangedCurrency$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "dropcurrency",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
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
uuid: "70"
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
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("L0cZcaz9eUiNFH+0u4wvJQ#Value", "Upload Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("eXCLYwakN06blJRjnFhvOw#ValueExpression.65921.1", "All"),
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
uuid: "73"
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
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("D2WCDalJFk++GGDXAGBwkA#Value", "Proposal type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NNTsd3aQx06utotoqLROwg#ValueExpression.65921.1", "All"),
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
uuid: "76"
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
uuid: "77"
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
style: model.getCachedValue(idService.getId("c2ooMVYr1UqxYgo61M6Nxw.Style"), function () {
return ("margin-left-s " + (((((((((((((OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getProposals_ProposalSearch())) !== ("")) || !(ConectaProveedoresClientVariables.getProposals_Bank().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getProposals_PaymentDateFrom().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getProposals_PaymentDateTo().equals(OS$BuiltinFunctions.nullDate()))) || ((ConectaProveedoresClientVariables.getProposals_Regions()) !== (""))) || ((ConectaProveedoresClientVariables.getProposals_Statuses()) !== (""))) || !(ConectaProveedoresClientVariables.getProposals_AmountMLFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getProposals_AmountMLTo().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || ((ConectaProveedoresClientVariables.getProposals_Currencies()) !== (""))) || ((ConectaProveedoresClientVariables.getProposals_UploadType()) !== (OS$BuiltinFunctions.nullIdentifier())))) ? ("") : ("visibility-hidden ")));
}, function () {
return ConectaProveedoresClientVariables.getProposals_ProposalSearch();
}, function () {
return ConectaProveedoresClientVariables.getProposals_Bank();
}, function () {
return ConectaProveedoresClientVariables.getProposals_PaymentDateFrom();
}, function () {
return ConectaProveedoresClientVariables.getProposals_PaymentDateTo();
}, function () {
return ConectaProveedoresClientVariables.getProposals_Regions();
}, function () {
return ConectaProveedoresClientVariables.getProposals_Statuses();
}, function () {
return ConectaProveedoresClientVariables.getProposals_AmountMLFrom();
}, function () {
return ConectaProveedoresClientVariables.getProposals_AmountMLTo();
}, function () {
return ConectaProveedoresClientVariables.getProposals_Currencies();
}, function () {
return ConectaProveedoresClientVariables.getProposals_UploadType();
}),
visible: true,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_cerrar2.svg"),
style: "img-l",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "80"
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
uuid: "81",
alias: "18"
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
uuid: "82",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadAuditProposalLines$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "img-m margin-right-base",
visible: true,
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_contract2.svg"),
style: "img-m ",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("ppm_8FqRnEychl_MFOX4tA#Value", "Auditory Report"))];
})
},
_dependencies: []
}), createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "85",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: (!(model.variables.isBusyVar)),
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadProposals$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "img-m",
visible: true,
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_descargar2.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("gBtWn5RgD0KmNLYtTkwnsA#Value", "Proposals Export"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.isBusyVar)]
}), createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "88",
alias: "21"
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
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_recargar2.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("IPRYXrHABUqQKoT14DIozA#Value", "Refresh Table"))];
})
},
_dependencies: []
}), createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "91",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalManualUpload", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn btn-plusbutton margin-left-base",
visible: true,
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.whiteplus.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("IaP2Xy+sZ0Cm6jeTSgTllw#Value", "Add Proposal"))];
})
},
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.isBusyVar)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalDataAct.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getProposalDataAct.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("g4dztuAO00Gu4zJODSX_ug#Value", "There are no proposals to show.")))];
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
uuid: "96"
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
text: [$text(getTranslation("6ukxB9YMX0uRqnx0F1YkXw#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "99"
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
uuid: "100",
alias: "23"
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
source: model.variables.getProposalDataAct.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "ConectaProveedoresProposalsGetProposals"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.Name",
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("WgGdjneOJ0qIDOXXBpo2mA#Value", "Proposal"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalType.Label",
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("07QALSg_DUmEj8SfKnk_HQ#Value", "Type"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.CreatedOn",
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("gnJSFh4tAE2Fh+Y13yAqwg#Value", "Uploaded Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Proposal.PaymentDate",
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("iTG6lDlj30uxHKoIrKTZHQ#Value", "Payment Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Bank.Name",
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("1wi_d6tqxkGrFZ3Nl4GVUA#Value", "Bank"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Region.CommissionRegion",
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("n8rc9N29EUmInWTyQZF6mw#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "Proposal.TotalValueML",
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("cf8r333wME6Z7Hmqe0YmYQ#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Currency.Code",
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("PIBxJNXPsEqstlai8ceuug#Value", "Currency ML"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "ProposalStatus.Label",
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("eZgplL4mIU+r2W6uxOO13w#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("czU0p2QyK0K85ZkIVNGzng#Value", "Document")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.hasErrorAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [$if(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.hasErrorAttr, false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalDetailError", {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "114"
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
i_Text: model.getCachedValue(idService.getId("jxQfMDByx0ie6YgV8Mkfvw.i_Text"), function () {
return ((((model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr) !== (""))) ? (model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr) : (model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr));
}, function () {
return model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr;
}, function () {
return model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr),
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
uuid: "115",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalDetail", {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "116"
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
i_Text: model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr)
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
uuid: "117",
alias: "25"
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
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr)
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
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("F3rmzEPuw0qM2IcpUdKnjQ.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr)
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
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("gAe0btttpUKyY08BJSk9Wg.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr;
}),
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating ",
visible: true,
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr,
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr)
})];
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
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: ((model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr + " - ") + model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr),
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating ",
visible: true,
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("sUplvT9lLUap92sha9hh0w.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr, "", 2, ".", ",");
}, function () {
return model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr;
}),
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr)
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
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr),
i_Class: model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr)
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
uuid: "141",
alias: "26"
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
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).uploadedByAttr.nameAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, $if(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadFile$Action(model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr === OS$BuiltinFunctions.nullTextIdentifier()), false, this, function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
title: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("CDzk0KLceEO6W0i8HInFEQ#Value.795776775.1", "API Upload")
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_excelBlack.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
title: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rqr6uS4FGE+XZhQ2RuBx6Q#Value.-1025651421.1", "Uploaded by:") + " ") + model.variables.getProposalDataAct.listOut.getCurrent(callContext.iterationContext).uploadedByAttr.nameAttr)
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_excel.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "147"
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
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}, callContext, idService, "4_0")
},
_dependencies: [asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PopupBtnId: idService.getId("OpenPopupLink"),
TableName: idService.getId("ConectaProveedoresProposalsGetProposals"),
ConfigColumnJSON: model.variables.l_ColumnJSONVarGetProposalVar,
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar
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
uuid: "149",
alias: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalVar), asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.listOut)]
})), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
TotalCount: OS$BuiltinFunctions.integerToLongInteger(model.variables.getProposalDataAct.countOut),
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalDataAct.dataFetchStatusAttr),
StartIndex: model.variables.l_StartIndexVar
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
uuid: "150",
alias: "28"
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
uuid: "151",
alias: "29"
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
uuid: "152"
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
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "154"
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
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("sYIU6Mn_M0GsiLt2oSCvBA#Value", "See Logs"))],
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "158"
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
alias: "30"
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
uuid: "160"
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
uuid: "161",
alias: "31"
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
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("bl5DRTxE202EFbT3GCy_vQ#Value", "Historic"))), createElement(OSWidgets$Container, {
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
uuid: "163"
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
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "165"
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
i_refresh: model.variables.l_RefeshSideBarVar
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
uuid: "166",
alias: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefeshSideBarVar)]
}))];
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
uuid: "167",
alias: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsAutoRefreshVar), asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalVar), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_Currencies()), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_AmountMLTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_AmountMLFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_Statuses()), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_Regions()), asPrimitiveValue(model.variables.getProposalTypesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_Type()), asPrimitiveValue(model.variables.getUploadTypeDataAct.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_UploadType()), asPrimitiveValue(model.variables.l_SelectedCurrencyVar), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.l_AmountToTextVar), asPrimitiveValue(model.variables.l_AmountFromTextVar), asPrimitiveValue(model.variables.l_ShowFiltersVar), asPrimitiveValue(model.variables.l_SelectedStatusVar), asPrimitiveValue(model.variables.getProposalStatusDataAct.listOut), asPrimitiveValue(model.variables.getProposalStatusDataAct.isDataFetchedAttr), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_PaymentDateTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_PaymentDateFrom()), asPrimitiveValue(model.variables.getBanksAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_Bank()), asPrimitiveValue(model.variables.l_SelectedRegionsVar), asPrimitiveValue(model.variables.getRegionsAggr.listOut), asPrimitiveValue(model.variables.getRegionsAggr.isDataFetchedAttr), asPrimitiveValue(ConectaProveedoresClientVariables.getProposals_ProposalSearch()), asPrimitiveValue(model.variables.isBusyVar), asPrimitiveValue(model.variables.getProposalTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUploadTypeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalStatusDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBanksAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRegionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalDataAct.countOut), asPrimitiveValue(model.variables.getProposalDataAct.listOut), asPrimitiveValue(model.variables.getProposalDataAct.sumOut), asPrimitiveValue(model.variables.getProposalDataAct.isDataFetchedAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ProposalsList",
functionKey: "281bb76d-426d-4941-82f2-bac56aaedcbf",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_AdminCommissionsLeasing.ProposalsList",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/ConectaProveedores.UserScripts.DropdownToggle.js"];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, ConectaProveedores_y_Utils_Wb_Sum_mvc_view, OutSystemsUI_Interaction_Search_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, OutSystemsUI_Interaction_DropdownSearch_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, Telcel_Theme_Utils_Wb_CalendarClear_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, OutSystemsUI_Interaction_Sidebar_mvc_view, ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view, AutoRefreshUtils_Widget_EventExtensibilityBlock_mvc_view];
};


return ELEM;
};

export default componentFactory()
