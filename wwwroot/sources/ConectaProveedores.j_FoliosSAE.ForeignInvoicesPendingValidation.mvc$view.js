import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Interaction_Search_mvc_view from "./OutSystemsUI.Interaction.Search.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view from "./ConectaProveedores.y_Utils.Wb_SearchSupplierDropdown.mvc$view.js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import Telcel_Theme_Utils_Wb_SupplierName_mvc_view from "./Telcel_Theme.Utils.Wb_SupplierName.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.ForeignInvoicesPendingValidation.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.ForeignInvoicesPendingValidation.mvc$controller.js";
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
text: [$text(getTranslation("iOnO0pt0UUuAqXayX1fOFA#Value", "Homepage"))],
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
text: [$text(getTranslation("RCgCvcN+B06CHV5IPf_OXw#Value", "Dashboard"))],
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
text: [$text(getTranslation("RXfkXwajyEyijjgv4e28AA#Value", "Foreign invoices pending validation"))],
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
text: [$text(getTranslation("8vUlTqvrLkK63++ajsDAMg#Value", "Foreign invoices pending validation"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: Widget.PlaceholderContent.Empty,
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
style: "display-flex",
visible: true,
_idProps: {
service: idService,
name: "filtersMain"
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
name: "SearchInvoice"
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
uuid: "20",
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
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("KhZfoK9Gm0iTFR3lDKJrlw#Value", "Search input"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0pGwJgFvZUmVCKnEY4cevA#ValueExpression.1518460963.1", "Folio SAEC"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_FolioNumber(), function (value) {
ConectaProveedoresClientVariables.setForeignInvoicesPendingValidation_FolioNumber(value);
}),
_idProps: {
service: idService,
name: "Input_Search"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_FolioNumber())]
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_Search"),
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
uuid: "23",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "margin-2percent",
visible: true,
_idProps: {
service: idService,
name: "SearchRequisition"
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
uuid: "25",
alias: "4"
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
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("v+p_0uUn8ECsQ7V1YWfTvg#Value", "Search input"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Ufr_zy4SlUmBrDBkjwEE8A#ValueExpression.69519515.1", "Order Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_OrderNumber(), function (value) {
ConectaProveedoresClientVariables.setForeignInvoicesPendingValidation_OrderNumber(value);
}),
_idProps: {
service: idService,
name: "Input_Search2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_OrderNumber())]
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("Input_Search2")
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
uuid: "28",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4"
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
i_SupplierId: ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_SupplierId(),
i_IsValid: true,
i_IsDisable: false,
i_IsMandatory: false,
i_IsFilter: true
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
uuid: "30",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width3"
},
style: "os-boxlabel margin-2percent",
visible: true,
_idProps: {
service: idService,
name: "Status"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nokgy89ySEysBv3+VkKmAw#Value", "Status"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vXZ1P+ykjUSYNhDuDjF6Sg#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.folioStatusAttr.labelAttr;
},
list: model.variables.getFolioStatusesAggr.listOut,
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
return elem.folioStatusAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_StatusId(), function (value) {
ConectaProveedoresClientVariables.setForeignInvoicesPendingValidation_StatusId(value);
}),
_idProps: {
service: idService,
name: "Dropdown_Status"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioStatusesAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(true, controller.callContext(eventHandlerContext));
});
;
},
visible: model.getCachedValue(idService.getId("yZ0rz98nHUGfoqg7pnzdlg.Visible"), function () {
return (((((ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_FolioNumber()) !== ("")) || ((ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_OrderNumber()) !== (""))) || !(ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || ((ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_StatusId()) !== (OS$BuiltinFunctions.nullIdentifier())));
}, function () {
return ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_FolioNumber();
}, function () {
return ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_OrderNumber();
}, function () {
return ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_SupplierId();
}, function () {
return ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_StatusId();
}),
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_cerrar2.svg"),
style: "img-l",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
})))), createElement(OSWidgets$Container, {
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
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "list"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getFolioApprovalLevelsByAssignedToAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-align-center",
text: [$text(getTranslation("sAI+tqIZb0CpNL8Ljrz+8g#Value", "There are no pending invoices at this time."))],
_idProps: {
service: idService,
uuid: "39"
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
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right; bottom: 0; right: 0;"
},
gridProperties: {
classes: "ThemeGrid_Width2"
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
text: [$text(getTranslation("yItJYjarLEegkmbxlHK0jg#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "44"
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
uuid: "45",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(model.variables.l_TableSortVar, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "Table_ForeignInvoicesPendingValidation"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "Folio.FolioNumber",
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("aeenEmuG3EOYdlVrkq0a4w#Value", "Folio SAEC"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "ApprovalStatus.LabelES",
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("YiTsFKBiuU2tvz0bAGNmfg#Value", "Action"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "FolioStatus.LabelES",
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("dZ8N3CHCCkmS5jb40G8OnQ#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderMain.OrderNumber",
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("5FI8Lmnt0kirSLtVe01LEg#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Supplier.Name",
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("fWp8k1mAF0O1TlD5xgWRmg#Value", "Supplier"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Region.Code",
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("RPt9LpzpFUidAWVYY2aZ6g#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Ml5rCHUvyk2tZ+Nrwn3Nlg#Value", "Amount"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Currency.Code",
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("EYutpXsOK02KFxV5UaWWjw#Value", "Currency")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.idAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Details", {
i_FolioId: OS$DataConversion.ServerDataConverter.to(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr,
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelESAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr),
i_Text: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelESAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
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
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.classAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.labelESAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.labelESAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr),
i_Class: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
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
uuid: "61",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr)]
}, createElement(Telcel_Theme_Utils_Wb_SupplierName_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_SupplierName: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr,
_i_SupplierNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr),
i_NChar: 20,
i_SupplierNumber: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr,
_i_SupplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
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
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr,
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("atFPz5Mh0UmXY9orGHnkaw.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
}))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PopupBtnId: idService.getId("OpenPopupLink"),
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
TableName: idService.getId("Table_ForeignInvoicesPendingValidation"),
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
uuid: "72",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
StartIndex: model.variables.l_StartIndexVar,
TotalCount: model.variables.getFolioApprovalLevelsByAssignedToAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
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
uuid: "73",
alias: "12"
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
uuid: "74",
alias: "13"
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
uuid: "75"
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
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
}))];
})];
}, function () {
return [];
})))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.countOut), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioStatusesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_StatusId()), asPrimitiveValue(ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_SupplierId()), asPrimitiveValue(ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_OrderNumber()), asPrimitiveValue(ConectaProveedoresClientVariables.getForeignInvoicesPendingValidation_FolioNumber())]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ForeignInvoicesPendingValidation",
functionKey: "31499d2f-76a1-43b3-a1ee-bcef1852e790",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.ForeignInvoicesPendingValidation",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.j_FoliosSAE.ForeignInvoicesPendingValidation.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Interaction_Search_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, Telcel_Theme_Utils_Wb_SupplierName_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view];
};


return ELEM;
};

export default componentFactory()
