import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, Checkbox as OSWidgets$Checkbox, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup, List as OSWidgets$List } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view from "./ConectaProveedores.y_Utils.Wb_SearchSupplierDropdown.mvc$view.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import Telcel_Theme_Utils_Wb_CalendarClear_mvc_view from "./Telcel_Theme.Utils.Wb_CalendarClear.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_SupplierName_mvc_view from "./Telcel_Theme.Utils.Wb_SupplierName.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import { getNextMonday$Action as ConectaProveedoresController$getNextMonday$Action, getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.mvc$view.js";
import { ST_09173c1b0f41f719b9efd6430c2e737dStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_Notification_mvc_view from "./OutSystemsUI.Interaction.Notification.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.mvc$controller.js";
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
Initiative: "FCP"
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
text: [$text(getTranslation("oSeosjDQ4U2LO0FyMcUAHA#Value", "Homepage"))],
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
text: [$text(getTranslation("sxv3fdT6kU2EySh7K71TVg#Value", "Dashboard"))],
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
}, $text(getTranslation("r2fgjEKIyk6RrFZO08LWLQ#Value", "Folio Invoices Contabilization Errors"))))];
}),
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("tTmmrLNq5UGo34EgTomUKg#Value", "Folio Invoices Contabilization"))],
_idProps: {
service: idService,
uuid: "12"
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
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
name: "body"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: (auto);"
},
style: "",
visible: true,
_idProps: {
service: idService,
name: "filtersCard"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "16"
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
name: "filtersAll"
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
name: "mainfilters"
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
name: "SupplierName"
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
i_IsFilter: true,
i_IsDisable: false,
i_IsMandatory: false,
i_SupplierId: ConectaProveedoresClientVariables.getFolioContabilization_Filters_SupplierId()
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
uuid: "21",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel margin-2percent",
visible: true,
_idProps: {
service: idService,
name: "InvoiceNumber"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_InvoiceNumber",
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0ogTFd9f402bJ9Hmiw79+g#Value", "Invoice Number"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0GKQBLcc2UuYSos9CdkvyQ#ValueExpression.-1400292388.1", "Invoice Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceName(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_InvoiceName(value);
}),
_idProps: {
service: idService,
name: "Input_InvoiceNumber"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_InvoiceNumber"),
DebounceDelay: 1000
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
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "filterchild os-boxlabel",
visible: true,
_idProps: {
service: idService,
name: "FolioNumber"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_FolioNumber",
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("JwWD5qZT2Eicek9_4qtHug#Value", "Folio Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("HOTkP1Jj30W2KQmq_IvOvA#ValueExpression.-1141793184.1", "Folio Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioNumber(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_FolioNumber(value);
}),
_idProps: {
service: idService,
name: "Input_FolioNumber"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_FolioNumber"),
DebounceDelay: 1000
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
uuid: "29",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel margin-2percent",
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
}, $text(getTranslation("6Rd6kx3vWkWCjoc9VOkX_A#Value", "Invoice Status"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("o1kC8mKgOEa1GxpLfcrBIw#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.invoiceStatusAttr.labelAttr;
},
list: model.variables.getInvoiceStatusAggr.listOut,
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
return elem.invoiceStatusAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceStatusId(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_InvoiceStatusId(value);
}),
_idProps: {
service: idService,
name: "InvoiceStatusFilter"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceStatusAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
marginLeft: "0"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.expandFilters$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "33"
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
uuid: "34"
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
visible: model.getCachedValue(idService.getId("Reset.Visible"), function () {
return ((((((((((((((((((!(ConectaProveedoresClientVariables.getFolioContabilization_Filters_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || ((ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceStatusId()) !== (OS$BuiltinFunctions.nullIdentifier()))) || ((ConectaProveedoresClientVariables.getFolioContabilization_Filters_AccountingTypeId()) !== (OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioCreatedOn().equals(OS$BuiltinFunctions.nullDate()))) || ((ConectaProveedoresClientVariables.getFolioContabilization_Filters_FrequencyId()) !== (OS$BuiltinFunctions.nullIdentifier()))) || ((ConectaProveedoresClientVariables.getFolioContabilization_Filters_SpecialApprovalId()) !== (OS$BuiltinFunctions.nullIdentifier()))) || ((ConectaProveedoresClientVariables.getFolioContabilization_Filters_CurrencyId()) !== (OS$BuiltinFunctions.nullTextIdentifier()))) || !(ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceCreatedOn().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getFolioContabilization_Filters_PaidOn().equals(OS$BuiltinFunctions.nullDate()))) || ((ConectaProveedoresClientVariables.getFolioContabilization_Filters_AmountFrom()) !== (0))) || !(ConectaProveedoresClientVariables.getFolioContabilization_Filters_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || ((OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getFolioContabilization_Filters_BusinessValueCategory())) !== (""))) || ((OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getFolioContabilization_Filters_BusinessValueSubCateg())) !== (""))) || ((OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioNumber())) !== (""))) || ((OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceName())) !== (""))) || ((OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getFolioContabilization_Filters_OrderMainNumber())) !== (""))) || ((OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getFolioContabilization_Filters_AssignedTo())) !== (""))) || ((OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getFolioContabilization_Filters_Project())) !== (""))) || ((OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getFolioContabilization_Filters_Period())) !== ("")));
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_SupplierId();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceStatusId();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_AccountingTypeId();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioCreatedOn();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_FrequencyId();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_SpecialApprovalId();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_CurrencyId();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceCreatedOn();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_PaidOn();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_AmountFrom();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_AmountTo();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_BusinessValueCategory();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_BusinessValueSubCateg();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioNumber();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceName();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_OrderMainNumber();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_AssignedTo();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_Project();
}, function () {
return ConectaProveedoresClientVariables.getFolioContabilization_Filters_Period();
}),
_idProps: {
service: idService,
name: "Reset"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_cerrar2.svg"),
style: "img-l",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
extendedProperties: {
style: "text-align: left;"
},
style: "display-flex margin-top-base",
visible: model.variables.l_ShowFiltersVar,
_idProps: {
service: idService,
name: "filterrow1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
name: "OrderNumberFilterContainer"
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
}, $text(getTranslation("g2S+nPfp3UK_vKzlIn5GTQ#Value", "Order Number"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("53gP_Y88ME6_QRtaVNIgJg#ValueExpression.69519515.1", "Order Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getFolioContabilization_Filters_OrderMainNumber(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_OrderMainNumber(value);
}),
_idProps: {
service: idService,
name: "OrderNumberFilter"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("OrderNumberFilter")
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
uuid: "41",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel margin-2percent",
visible: true,
_idProps: {
service: idService,
name: "UserNameFilterContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("k0bJcoxKgEim22GM70pcmA#Value", "Assigned To"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("9vDu6ZTr6kujmFugOLYo6w#ValueExpression.-885218803.1", "Assigned To"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getFolioContabilization_Filters_AssignedTo(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_AssignedTo(value);
}),
_idProps: {
service: idService,
name: "UserNameFilter"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("UserNameFilter"),
DebounceDelay: 1000
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
uuid: "45",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
name: "ProjectFilterContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("P4UVpSZsK0mga6ETKdKxlw#Value", "Project"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("MksZWTlLpkOfwIu7DpEgaw#ValueExpression.1355342585.1", "Project"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getFolioContabilization_Filters_Project(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_Project(value);
}),
_idProps: {
service: idService,
name: "ProjectFilter"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("ProjectFilter")
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
uuid: "49",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel margin-2percent",
visible: true,
_idProps: {
service: idService,
name: "PeriodFilterContainer"
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
}, $text(getTranslation("MIyDykXDLECJ0fJf2lXNsQ#Value", "Period"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VuGvatU7xU+Rj7wOhFv9xQ#ValueExpression.1355342585.1", "Project"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getFolioContabilization_Filters_Period(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_Period(value);
}),
_idProps: {
service: idService,
name: "PeriodFilter"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("PeriodFilter"),
DebounceDelay: 1000
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
uuid: "53",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "display-flex margin-top-m",
visible: model.variables.l_ShowFiltersVar,
_idProps: {
service: idService,
name: "filterrow2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
name: "FrequencyFilterContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NNI+Fzh6ukSCOuaWnuPjrA#Value", "Frequency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("iMSRTWbf8kCMvjNhyc0x5A#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.frequencyAttr.labelAttr;
},
list: model.variables.getFrequenciesAggr.listOut,
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
return elem.frequencyAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getFolioContabilization_Filters_FrequencyId(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_FrequencyId(value);
}),
_idProps: {
service: idService,
name: "FrequencyFilter"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFrequenciesAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel margin-2percent",
visible: true,
_idProps: {
service: idService,
name: "BusinessValueCategoryFilterContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "59"
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
i_Text: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0UJPrZv2FkqI6DatQ0oWFw#Value.2064200525.1", "Business Value Category"),
i_NChar: 18
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
uuid: "60",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("s+n3WWBVckyVc5DbhkAcjg#ValueExpression.2064200525.1", "Business Value Category"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getFolioContabilization_Filters_BusinessValueCategory(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_BusinessValueCategory(value);
}),
_idProps: {
service: idService,
name: "BusinessValueCategoryFilter"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("BusinessValueCategoryFilter")
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
uuid: "62",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
name: "BusinessValueSubcategoryFilterContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "64"
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
i_NChar: 21,
i_Text: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("FXwuSontxkOCPc7WvvV6Yw#Value.-981209457.1", "Business Value Subcategory")
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
uuid: "65",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IIPlYuVsVkCsT_n5OQUeKA#ValueExpression.-624972113.1", "Business value Subcategory"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getFolioContabilization_Filters_BusinessValueSubCateg(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_BusinessValueSubCateg(value);
}),
_idProps: {
service: idService,
name: "BusinessValueSubcategoryFilter"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("BusinessValueSubcategoryFilter"),
DebounceDelay: 1000
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
uuid: "67",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "margin-2percent",
visible: true,
_idProps: {
service: idService,
name: "PaidOn"
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
controller.datePickerOnDatePickerPaidOn$Action(selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerPaidOn",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickOpenPaidOn$Action(controller.callContext(eventHandlerContext));

;
}
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
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+1Eoj+oCbU6Tkx4CQGDgng#Value", "Paid On"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "72",
alias: "14"
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
i_Date: ConectaProveedoresClientVariables.getFolioContabilization_Filters_PaidOn()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
clear$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearPaidOn$Action(controller.callContext(eventHandlerContext));
});
;
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("p83sxNBF9ku0SCHN4c6akQ#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getFolioContabilization_Filters_PaidOn(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_PaidOn(value);
}),
_idProps: {
service: idService,
name: "Input_PaymentDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_PaidOn())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_PaidOn())]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "display-flex margin-top-m",
visible: model.variables.l_ShowFiltersVar,
_idProps: {
service: idService,
name: "filterrow3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "76"
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
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("KdQaYuY_yE2I8UNPUpGKiQ#Value", "From Total Amount"))), createElement(OSWidgets$Input, {
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
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
PrefixText: "",
DecimalSeparator: ".",
UseNumericInput: true,
InputId: idService.getId("Input_AmountML3"),
AlwaysShowDecimalDigits: true,
RightAlign: true,
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
uuid: "79",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
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
uuid: "80",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel margin-2percent",
visible: true,
_idProps: {
service: idService,
uuid: "81"
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
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("rTDvDpQHL0a8_Oj7bDSaeA#Value", "To Total Amount"))), createElement(OSWidgets$Input, {
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
PrefixText: "",
DecimalSeparator: ".",
InputId: idService.getId("Input_AmountML2"),
RightAlign: true,
SuffixText: "",
UseNumericInput: true,
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
uuid: "84",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
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
uuid: "85",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
name: "CurrencyFilterContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("WENRAn+u70qpEB0ln+nB1Q#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("OeGF4CMmQ0m3dxidzdjoEw#ValueExpression.65921.1", "All"),
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
style: "dropdown",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getFolioContabilization_Filters_CurrencyId(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_CurrencyId(value);
}),
_idProps: {
service: idService,
name: "CurrencyFilter"
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
classes: "ThemeGrid_Width2"
},
style: "margin-2percent",
visible: true,
_idProps: {
service: idService,
name: "InvoiceDate"
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
controller.datePickerInvoiceDate$Action(selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerInvoiceDate",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickOpenInvoiceDate$Action(controller.callContext(eventHandlerContext));

;
}
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("yA62eHaLfU2zeNxYhvI37g#Value", "Invoice Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "93",
alias: "21"
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
i_Date: ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceCreatedOn()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
clear$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearInvoiceDate$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "94",
alias: "22"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("BuvmLfUXoUSFTuRO7vGXdw#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceCreatedOn(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_InvoiceCreatedOn(value);
}),
_idProps: {
service: idService,
name: "Input_InvoiceDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceCreatedOn())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceCreatedOn())]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "display-flex margin-top-m",
visible: model.variables.l_ShowFiltersVar,
_idProps: {
service: idService,
name: "filterrow4"
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
name: "ArrivalDate"
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
controller.datePickerOnDatePickerArrivalDate$Action(selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerArrivalDate",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickOpenArrivalDate$Action(controller.callContext(eventHandlerContext));

;
}
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("LTw2Jiwp3UiyVEBSzFZ4lQ#Value", "Arrival Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "101",
alias: "24"
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
i_Date: ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioCreatedOn()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
clear$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearArrivalDate$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "102",
alias: "25"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("RMAe959PuUiNZYY4ebLPmw#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioCreatedOn(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_FolioCreatedOn(value);
}),
_idProps: {
service: idService,
name: "Input_ArrivalDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioCreatedOn())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioCreatedOn())]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel margin-2percent",
visible: true,
_idProps: {
service: idService,
name: "SpecialApprovelFilterContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("PuE7w4E_LEOj1uxdZK3Vkw#Value", "Special Approval"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("JK1XhNEcFUGaynFfSoTwJQ#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.specialApprovalAttr.labelAttr;
},
list: model.variables.getSpecialApprovalsAggr.listOut,
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
return elem.specialApprovalAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getFolioContabilization_Filters_SpecialApprovalId(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_SpecialApprovalId(value);
}),
_idProps: {
service: idService,
name: "CFDITypeFilter3"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSpecialApprovalsAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
name: "CFDITypeFilterContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("AlIX+9Bs3kyGxfZfb_7deQ#Value", "CFDI Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("LglBqbnd9ky_pNUog6QbqQ#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.accountingDataTypeAttr.labelAttr;
},
list: model.variables.getAccountingDataTypesAggr.listOut,
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
return elem.accountingDataTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getFolioContabilization_Filters_AccountingTypeId(), function (value) {
ConectaProveedoresClientVariables.setFolioContabilization_Filters_AccountingTypeId(value);
}),
_idProps: {
service: idService,
name: "CFDITypeFilter4"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))))), createElement(OSWidgets$Container, {
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
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (model.variables.getInvoicesSAPAggr.isDataFetchedAttr && (model.variables.getInvoicesSAPAggr.listOut.isEmpty === false)),
extendedProperties: {
style: "float:right"
},
gridProperties: {
width: "148.396px"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.generateReport$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
}, $text(getTranslation("SUgtYekcLkCsGtVYAmrT2Q#Value", "Generate Report")))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "",
visible: true,
_idProps: {
service: idService,
name: "list"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoicesSAPAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getInvoicesSAPAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-align-center",
text: [$text(getTranslation("D07sKwgUmUePbCUQWyp7fg#Value", "There are no foli invoices contabilization data at this time."))],
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "115"
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
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.l_IsShowSelectAllVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: ((model.variables.l_IsSelectAllVar === true) || ((model.variables.l_IsSelectedVar === true) && model.variables.isAnyBulkApprovableVar)),
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.bulkRetryOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn bulkrapprove",
visible: true,
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_administrar_recargas.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "text-third margin-left-s",
text: [$text(getTranslation("we3ik3H8ykSJffFIoAWbWg#Value", "Retry Contabilization Bulk"))],
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right; bottom: 0;"
},
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "position-absolute",
visible: true,
_idProps: {
service: idService,
name: "TableSettings"
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
text: [$text(getTranslation("eIQoxoe1PUiNMLEuUQ9eBA#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "124"
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
uuid: "125",
alias: "26"
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
source: model.variables.getInvoicesSAPAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "InvoicesTable"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "127"
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
uuid: "128"
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
name: "Checkbox_IsSelectAll"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Supplier.Name",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("HM+4UCqWyU2ZxIt3kttDHA#Value", "Supplier"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.Name",
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("IKOSp3IQD0OYEddLziYAQg#Value", "Invoice Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Folio.FolioNumber",
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("00+bG8mqEEuoX7ojAamuLw#Value", "Folio Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Folio.FolioStatusId",
style: "donotshow",
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("RXxtorti5Ea+pgxBGu2nXg#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderMain.OrderNumber",
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("X_CcfADUGkyyuVAyY2_+XA#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Project_Asset_Service.Description",
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Vh42Bzp2bESxhr3GI5nrtw#Value", "Project"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "InvoiceExtended.FechaEmision",
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("V8ggs0ibWEqxs4LEdtb6sw#Value", "Period"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Frequency.Label",
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("fXQEh2jL2Uym6vUNvJN08w#Value", "Frequency"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "BusinessValueCategory.Description",
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("VtdDMN39BES03j4W_1SlNw#Value", "Business Value Category"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "BusinessValueSubcategory.Description",
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("UxSaG7st4EyvXRCu2UumVw#Value", "Business Value SubCategory"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.UpdatedOn",
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("mzt146VwW0i6a0xslY+y6w#Value", "Paid On"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Folio.TotalAmount",
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Bb3ujz02nUenm0w7uw9CAw#Value", "Total Amount"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.CreatedOn",
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("1jeolVDYeU2qkaG5b3gSBA#Value", "Invoice Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Currency.Code",
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("El9wsoZE4E+q_AQWCDhMQQ#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("2vHA_pi+h0Ct3ckfCluQFg#Value", "Invoice Created"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "SpecialApproval.Label",
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("EKS3C4ioQUGXFaopr+xlgw#Value", "Special Approval"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ZKXi07ZHIkWpzx+HMcDl0w#Value", "Tags"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "AccountingDataType.Label",
_idProps: {
service: idService,
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6qcm9OQgTUuSHUCI9aAEkg#Value", "CFDI Type"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("gqsHxKSCRUWiDMyVXMkgZQ#Value", "Available Tasks"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("KAxC_Ee2yECpoX1rRe2ktg#Value", "Details")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("sT5HIdE6ik232HtDA3gnug.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.isAnyLineSelected$Action(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.idAttr, model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr, controller.callContext(eventHandlerContext));
});
;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr, function (value) {
model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox_IsSelected"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("c+M5KzRoIkeFFTly2F+XZg.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr)]
}, createElement(Telcel_Theme_Utils_Wb_SupplierName_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_SupplierNumber: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr,
_i_SupplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr),
i_NChar: 20,
i_SupplierName: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr,
_i_SupplierNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
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
uuid: "154",
alias: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("ahwpscfj2kyPMc639HjYEg.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.folioAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.folioAttr,
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("GhjGJ_xQt0GlGIQ4YqgKoQ.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.idAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Details", {
i_FolioId: OS$DataConversion.ServerDataConverter.to(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "158"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr,
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("1mcPcBGwDUWLpl5XNnEtHw.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
}),
style: "width: auto;"
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "160"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr),
i_Text: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
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
name: "RequisitionStatus",
alias: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("MNwc10TgTEWo6udKeZZkkA.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_idProps: {
service: idService,
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("02alUNfN_kGqjaOOQfV7sA.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("FnYX3ZwWt0CF2vfyfsOMkA.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.periodAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.periodAttr,
_idProps: {
service: idService,
uuid: "167"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("yRnf4tiWz0SYOCRXBng+XQ.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "168"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).frequencyAttr.labelAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).frequencyAttr.labelAttr,
_idProps: {
service: idService,
uuid: "169"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("iRyzSMchV0ClBGhZ0fvJPg.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).businessValueCategoryAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).businessValueCategoryAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "171"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("r0UIz6XNTkqzGKSDK_uC_A.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).businessValueSubcategoryAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).businessValueSubcategoryAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "173"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("sCv8yHQID0m6ksS4fmwlvg.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.paymentTermCustomDaysAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).paymentTermsAttr.ctd_diasAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).paymentTermsAttr.isSpecialAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr)]
}, $if((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationSuccess), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("KZIvX0kL1EeIv72iBjSU1w.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(OS$BuiltinFunctions.addDays(OS$BuiltinFunctions.addDays(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr, ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).paymentTermsAttr.isSpecialAttr) ? (model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.paymentTermCustomDaysAttr) : (OS$BuiltinFunctions.textToInteger(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).paymentTermsAttr.ctd_diasAttr)))), ConectaProveedoresController$getNextMonday$Action(OS$BuiltinFunctions.textToDateTime(OS$BuiltinFunctions.dateTimeToText(OS$BuiltinFunctions.addDays(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr, ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).paymentTermsAttr.isSpecialAttr) ? (model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.paymentTermCustomDaysAttr) : (OS$BuiltinFunctions.textToInteger(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).paymentTermsAttr.ctd_diasAttr)))))), callContext).daysOut), "dd/MM/yyyy");
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).paymentTermsAttr.isSpecialAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.paymentTermCustomDaysAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).paymentTermsAttr.ctd_diasAttr;
}),
_idProps: {
service: idService,
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("abh8sx0f90OQm3BOiefOUw.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "176"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("23omxPdbj0CYH4N7qujHyw.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "177"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("kmK7hwrfKEOA8VnCfhljVg.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.fechaEmisionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("1oazt+BVvEWFmRnabtlQEg.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(OS$BuiltinFunctions.textToDateTime(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.fechaEmisionAttr), "dd/MM/yyyy");
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.fechaEmisionAttr;
}),
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("nHOLomSem0SLlYy6HThidQ.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "181"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("RroetREsj069+JbEnyfwPw.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("4SwCLzO4yE+mCr0twhfdaQ.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "183"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("jVeZeWtaWECGcl8vE26DwQ.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).specialApprovalAttr.labelAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).specialApprovalAttr.labelAttr,
_idProps: {
service: idService,
uuid: "185"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("hFJ+NH6BXkO00ObeVMcy2w.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ZvPW88HiOEebz5yKR9CD6A#Value", "Invoices with order"))), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("w4BXc80cF0+jiq43PF905Q.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "187"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).accountingDataTypeAttr.labelAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).accountingDataTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "188"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("smqwoP_bHUy88JFO5h_KgQ.class"), function () {
return (((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
}),
style: "text-align: center;"
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "189"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "align-column-vertically",
visible: ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationError) || (model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr === ConectaProveedores_staticEntities_invoiceStatus.pendingAccounting)),
_idProps: {
service: idService,
uuid: "190"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr)
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "191",
alias: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "192"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.retryOnClick$Action(model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "193"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_administrar_recargas.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "194"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("QTBqTCwBrECUtrgHWUA+sw#Value", "Retry Contabilization"))];
})
},
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("zT0FZfo9hECLY0X15FeLZg.class"), function () {
return ((((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.contabilizationError))) && ((model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.pendingAccounting)))) ? ("unable-approve") : (""));
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr;
}, function () {
return model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
}),
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "195"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.detailsOnClick$Action(model.variables.l_InvoiceIdVar, false, model.variables.getInvoicesSAPAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.idAttr, false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "196"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("YWUhY_jQj0SBHK9MPeWyfw#Value", "Details"))))];
}, callContext, idService, "6_0")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TableName: idService.getId("InvoicesTable"),
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
PopupBtnId: idService.getId("OpenPopupLink"),
ConfigColumnJSON: model.variables.l_ColumnJSONVarVar
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
uuid: "197",
alias: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TotalCount: model.variables.getInvoicesSAPAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr),
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
uuid: "198",
alias: "31"
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
uuid: "199",
alias: "32"
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
uuid: "200"
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
uuid: "201"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
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
name: "loader"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "height: 800px; width: 1500px; padding: var(--space-base)"
},
showPopup: model.variables.l_ShowDetailsVar,
style: "popup-invoice card",
_idProps: {
service: idService,
uuid: "203"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "overflow-vertical",
visible: true,
_idProps: {
service: idService,
uuid: "204"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.l_FolioIdVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (i_IsRefreshIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.detailsOnClick$Action(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), true, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), i_IsRefreshIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "205",
alias: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))), createElement(OutSystemsUI_Interaction_Notification_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "card",
OptionalConfigs: model.getCachedValue(idService.getId("NotificationTotals.OptionalConfigs"), function () {
return function () {
var rec = new ST_09173c1b0f41f719b9efd6430c2e737dStructure();
rec.interactToCloseAttr = false;
return rec;
}();
}),
StartsOpen: false,
Position: ConectaProveedores_staticEntities_position.topRight
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
name: "NotificationTotals",
alias: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
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
uuid: "207",
alias: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
style: "font-size-h6",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("t7HkYdimxE6iYsv4FuYGCA#ValueExpression.-183640545.1", "Total amounts"),
_idProps: {
service: idService,
uuid: "208"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "right: var(--space-m);"
},
style: "vertical-align position-absolute",
visible: true,
_idProps: {
service: idService,
uuid: "209"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_info_lleno.svg"),
style: "img img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "210"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
}), $if(model.variables.l_IsCalculatingVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "211"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "212"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "font-semi-bold",
value: ((((model.variables.l_TotalSelectedVar).toString() + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1MVbDfM2OUag9ZzFbIOxHg#ValueExpression.1191572123.1", "selected")) + ":"),
_idProps: {
service: idService,
uuid: "213"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "214"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.l_TotalsListVar,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "215"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-xs",
visible: true,
_idProps: {
service: idService,
uuid: "216"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_TotalsListVar.getCurrent(callContext.iterationContext).currencyAttr.nameAttr), asPrimitiveValue(model.variables.l_TotalsListVar.getCurrent(callContext.iterationContext).currencyAttr.symbolAttr), asPrimitiveValue(model.variables.l_TotalsListVar.getCurrent(callContext.iterationContext).totalAmountAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Gjn5GQhIoUyvPoBwSc6PXw.Value"), function () {
return ((((OS$BuiltinFunctions.formatCurrency(model.variables.l_TotalsListVar.getCurrent(callContext.iterationContext).totalAmountAttr, "", 2, ".", ",") + model.variables.l_TotalsListVar.getCurrent(callContext.iterationContext).currencyAttr.symbolAttr) + " (") + model.variables.l_TotalsListVar.getCurrent(callContext.iterationContext).currencyAttr.nameAttr) + ")");
}, function () {
return model.variables.l_TotalsListVar.getCurrent(callContext.iterationContext).totalAmountAttr;
}, function () {
return model.variables.l_TotalsListVar.getCurrent(callContext.iterationContext).currencyAttr.symbolAttr;
}, function () {
return model.variables.l_TotalsListVar.getCurrent(callContext.iterationContext).currencyAttr.nameAttr;
}),
_idProps: {
service: idService,
uuid: "217"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, callContext, idService, "7")
},
_dependencies: []
}))];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_TotalsListVar), asPrimitiveValue(model.variables.l_TotalSelectedVar), asPrimitiveValue(model.variables.l_IsCalculatingVar)]
})];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_TotalsListVar), asPrimitiveValue(model.variables.l_TotalSelectedVar), asPrimitiveValue(model.variables.l_IsCalculatingVar), asPrimitiveValue(model.variables.l_FolioIdVar), asPrimitiveValue(model.variables.l_ShowDetailsVar), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.isAnyBulkApprovableVar), asPrimitiveValue(model.variables.l_IsSelectedVar), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.getInvoicesSAPAggr.countOut), asPrimitiveValue(model.variables.getInvoicesSAPAggr.listOut), asPrimitiveValue(model.variables.getInvoicesSAPAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.listOut), asPrimitiveValue(model.variables.getSpecialApprovalsAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.l_AmountToTextVar), asPrimitiveValue(model.variables.l_AmountFromTextVar), asPrimitiveValue(model.variables.getFrequenciesAggr.listOut), asPrimitiveValue(model.variables.l_ShowFiltersVar), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_Period()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_Project()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_AssignedTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_OrderMainNumber()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_BusinessValueSubCateg()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_BusinessValueCategory()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_AmountTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_AmountFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_PaidOn()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceCreatedOn()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_CurrencyId()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_SpecialApprovalId()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_FrequencyId()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioCreatedOn()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_AccountingTypeId()), asPrimitiveValue(model.variables.getInvoicesSAPAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSpecialApprovalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceStatusAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceStatusAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceStatusId()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioNumber()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceName()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioContabilization_Filters_SupplierId())]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "FoliosContabilizationSAPStatus",
functionKey: "277b560c-f241-4c60-ba8f-065a322d24c4",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.FoliosContabilizationSAPStatus",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, Telcel_Theme_Utils_Wb_CalendarClear_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_SupplierName_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_mvc_view, OutSystemsUI_Interaction_Notification_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view];
};


return ELEM;
};

export default componentFactory()
