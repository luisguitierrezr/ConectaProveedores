import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, Button as OSWidgets$Button, Checkbox as OSWidgets$Checkbox, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup, List as OSWidgets$List } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Interaction_Search_mvc_view from "./OutSystemsUI.Interaction.Search.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure, ST_bc4abb4233d9ce894e855c520a20c76fStructure, ST_09173c1b0f41f719b9efd6430c2e737dStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import Telcel_Theme_Utils_Wb_SupplierName_mvc_view from "./Telcel_Theme.Utils.Wb_SupplierName.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import { RC_9983883fbc26c5bf3e842f01355fd0c8 } from "./ConectaProveedores.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_PopupFormSAEBulkApprove_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_PopupFormSAEBulkApprove.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import OutSystemsUI_Interaction_Notification_mvc_view from "./OutSystemsUI.Interaction.Notification.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.FoliosSAEForApprovalold.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.FoliosSAEForApprovalold.mvc$controller.js";
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
text: [$text(getTranslation("fvUvubU5f06ETZm83xStCA#Value", "Homepage"))],
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
text: [$text(getTranslation("zNiIftWSN02+g0uH4F5LfQ#Value", "Dashboard"))],
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
text: [$text(getTranslation("u3TkkzqRbki4hoptldg1pg#Value", "Invoices"))],
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
text: [$text(getTranslation("mas+9lDBZUGrNoUYJIRPiQ#Value", "Folios SAEC"))],
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
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "17"
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
uuid: "21",
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
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("a5wN3VqzaEu8Eg9QiRT6Ug#Value", "Search input"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("TNeSVPXaUk+qQV0dJ5w05Q#ValueExpression.205497893.1", "Form Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getFolioForApproval_FolioNumber(), function (value) {
ConectaProveedoresClientVariables.setFolioForApproval_FolioNumber(value);
}),
_idProps: {
service: idService,
name: "Input_Search"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_FolioNumber())]
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("Input_Search")
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
uuid: "24",
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
uuid: "26",
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
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jinjspjB9EWCM+e_7EnBkg#Value", "Search input"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("T2jwg2t6ikOk5pGupeQHMQ#ValueExpression.69519515.1", "Order Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getFolioForApproval_OrderNumber(), function (value) {
ConectaProveedoresClientVariables.setFolioForApproval_OrderNumber(value);
}),
_idProps: {
service: idService,
name: "Input_Search2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_OrderNumber())]
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_Search2"),
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
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
name: "Region"
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
}, $text(getTranslation("J7KUgseZsUeeQ4gh1EzPTQ#Value", "Region"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("2ORsJlgg4E+6JvPvfQyINw#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.region_TextAttr;
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
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, ConectaProveedoresClientVariables.getFolioForApproval_RegionId(), function (value) {
ConectaProveedoresClientVariables.setFolioForApproval_RegionId(value);
}),
_idProps: {
service: idService,
name: "Dropdown_Regiond"
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
extendedProperties: {
style: "margin-right: 0px;"
},
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
name: "SupplierName"
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
}, $text(getTranslation("EeZRueOL1ke5c1OwuGd4PA#Value", "Supplier"))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionsList: model.getCachedValue(idService.getId("DropdownSearchSupplier.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getSuppliersAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.supplierAttr.idAttr);
target.labelAttr = source.supplierAttr.nameAttr;
target.descriptionAttr = source.supplierAttr.numberAttr;
return target;
});
}, function () {
return model.variables.getSuppliersAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSuppliersAggr.dataFetchStatusAttr),
StartingSelection: model.getCachedValue(idService.getId("DropdownSearchSupplier.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(ConectaProveedoresClientVariables.getFolioForApproval_SupplierId());
rec.labelAttr = "";
return rec;
}()]);
return list;
}();
}, function () {
return ConectaProveedoresClientVariables.getFolioForApproval_SupplierId();
}),
OptionalConfigs: model.getCachedValue(idService.getId("DropdownSearchSupplier.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.allowMultipleSelectionAttr = false;
rec.isDisabledAttr = false;
rec.noResultsTextAttr = "No suppliers to show...";
rec.searchPromptAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("nIBooTrZkUa2gN_6Nz8mQA#Value.-512840794.1", "Search...");
rec.noOptionsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("wnixZhs6PUq_20MpbK3eDg#Value.-1274859484.1", "No suppliers to show...");
return rec;
}();
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSearchOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DropdownSearchSupplier",
alias: "6"
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
name: "DateFrom"
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
OptionalConfigs: model.getCachedValue(idService.getId("DatePickerCreatedOn.OptionalConfigs"), function () {
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
controller.datePickerCreatedOn$Action(OS$BuiltinFunctions.dateTimeToDate(selectedDateTimeIn), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerCreatedOn",
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
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_CreatedOnDate",
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Xm7MkknS0EGvAaxDiSE+7A#Value", "Created On Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.BlueCalendar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("aBrc5T+IlE2OdBAUKhAojQ#ValueExpression.65921.1", "All"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getFolioForApproval_CreatedOnDate(), function (value) {
ConectaProveedoresClientVariables.setFolioForApproval_CreatedOnDate(value);
}),
_idProps: {
service: idService,
name: "Input_CreatedOnDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_CreatedOnDate())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_CreatedOnDate())]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2",
marginLeft: "0"
},
style: "",
visible: true,
_idProps: {
service: idService,
name: "DateFrom2"
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
OptionalConfigs: model.getCachedValue(idService.getId("DatePickerCreatedTo.OptionalConfigs"), function () {
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
controller.datePickerCreatedOn$Action(OS$BuiltinFunctions.dateTimeToDate(selectedDateTimeIn), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerCreatedTo",
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
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_CreatedToDate",
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("SFy66Zv2O0Kaa2bjhDrzEA#Value", "Created To Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "47",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.BlueCalendar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Yq8pWxtLBk+s8TsDzu3k9w#ValueExpression.65921.1", "All"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getFolioForApproval_CreatedToDate(), function (value) {
ConectaProveedoresClientVariables.setFolioForApproval_CreatedToDate(value);
}),
_idProps: {
service: idService,
name: "Input_CreatedToDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_CreatedToDate())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_CreatedToDate())]
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
visible: model.getCachedValue(idService.getId("m_Rj0BzZOECOe69yER75oA.Visible"), function () {
return (((((((ConectaProveedoresClientVariables.getFolioForApproval_FolioNumber()) !== ("")) || ((ConectaProveedoresClientVariables.getFolioForApproval_OrderNumber()) !== (""))) || !(ConectaProveedoresClientVariables.getFolioForApproval_RegionId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getFolioForApproval_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getFolioForApproval_CreatedOnDate().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getFolioForApproval_CreatedToDate().equals(OS$BuiltinFunctions.nullDate())));
}, function () {
return ConectaProveedoresClientVariables.getFolioForApproval_FolioNumber();
}, function () {
return ConectaProveedoresClientVariables.getFolioForApproval_OrderNumber();
}, function () {
return ConectaProveedoresClientVariables.getFolioForApproval_RegionId();
}, function () {
return ConectaProveedoresClientVariables.getFolioForApproval_SupplierId();
}, function () {
return ConectaProveedoresClientVariables.getFolioForApproval_CreatedOnDate();
}, function () {
return ConectaProveedoresClientVariables.getFolioForApproval_CreatedToDate();
}),
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_cerrar2.svg"),
style: "img-l",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "51"
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
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(model.variables.l_IsAllowSelectApplicationRolesVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel auto-width margin-top-m",
visible: true,
_idProps: {
service: idService,
name: "ApprovalLevel"
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
}, $text(getTranslation("zMJ2iYOmEk+tJ81Wlm+UzQ#Value", "Approval Level"))), createElement(OSWidgets$Dropdown, {
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
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "",
visible: true,
_idProps: {
service: idService,
name: "list"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getFoliosSAEAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getFoliosSAEAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-align-center",
text: [$text(getTranslation("3wMLzXITokm00OtMqFRIGQ#Value", "There are no pending folios at this time."))],
_idProps: {
service: idService,
uuid: "58"
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
uuid: "59"
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
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.l_IsShowSelectAllVar && model.variables.getUserApplicationRolesDataAct.canBulkApproveOut), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: ((model.variables.l_IsSelectAllVar === true) || (model.variables.l_IsSelectedVar === true)),
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_b_BulkApprovePopUpOpen$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn bulkrapprove",
visible: true,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_exito.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "text-third margin-left-s",
text: [$text(getTranslation("mizNJMCkMkGREKZS8PaeBw#Value", "Bulk Approve"))],
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "align-column-vertically margin-top-base margin-left-base",
visible: true,
_idProps: {
service: idService,
name: "MyFolios"
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
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, ConectaProveedoresClientVariables.getFolioForApproval_AssignedToMe(), function (value) {
ConectaProveedoresClientVariables.setFolioForApproval_AssignedToMe(value);
}),
_idProps: {
service: idService,
name: "Checkbox1"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("KaWRJK2xIUK5uV2TpbAPpg#Value", "Assigned To Me"))],
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
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
text: [$text(getTranslation("735JBMP1skyJk9TsKX4lBA#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "73"
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
uuid: "74",
alias: "11"
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
source: model.variables.getFoliosSAEAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "FoliosTable"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("eqPlJeuRvECTDTgn9VxSVA.style"), function () {
return ("text-align: center; " + ((model.variables.getUserApplicationRolesDataAct.canBulkApproveOut) ? (" ") : ("display: none; ")));
}, function () {
return model.variables.getUserApplicationRolesDataAct.canBulkApproveOut;
})
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "76"
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
uuid: "77"
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
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "Folio.FolioNumber",
style: "donotshow",
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("aDCppmNaEkGsJoTvjBS5GA#Value", "Folio Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "ApprovalStatus.Order",
style: "donotshow",
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("wBGafQme4kGJ2z6vFTfJsQ#Value", "Action"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderMain.OrderNumber",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("S9tjPfVTREaM80n1WMM6_Q#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Supplier.Name",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("QFx2qF40UUCPsXKutEHrOw#Value", "Supplier"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Region.Code",
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ZO5D_FLkKkC1Hs11C7ibfQ#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "Folio.TotalAmount",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("7Mo09mr940aHZjnZFihabA#Value", "Total Amount"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("tdo2pDMRZkCq5hfOLLzOcA#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Folio.CreatedOn",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("3MWQWufsEkaNJlE3LYz5+g#Value", "Upload Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Folio.FolioStatusId",
style: "donotshow",
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4+EfhALLQUmpHn2Gt2t2zw#Value", "Folio Status")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("VAoq+EvnQEOrZB07hIXq7g.style"), function () {
return ((model.variables.getUserApplicationRolesDataAct.canBulkApproveOut) ? (" ") : ("display: none; "));
}, function () {
return model.variables.getUserApplicationRolesDataAct.canBulkApproveOut;
})
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).canApproveAttr)]
}, $if(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).canApproveAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "89"
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
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr, function (value) {
model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox_IsSelected"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.idAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Details", {
i_FolioId: OS$DataConversion.ServerDataConverter.to(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "92"
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
i_NChar: 20,
i_Text: model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr)
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
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr),
i_Text: model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr)
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
name: "RequisitionStatus2",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr),
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
uuid: "97",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr)]
}, createElement(Telcel_Theme_Utils_Wb_SupplierName_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_SupplierName: model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr,
_i_SupplierNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr),
i_SupplierNumber: model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr,
_i_SupplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr)
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
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Rx9di+WNAUOH5nH32Fm_wg.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr,
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("M570zActYUG5mCZt25X3sw.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.labelAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.classAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr),
i_Text: model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr)
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
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, callContext, idService, "3_0")
},
_dependencies: [asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.canBulkApproveOut)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PopupBtnId: idService.getId("OpenPopupLink"),
TableName: idService.getId("FoliosTable"),
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
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
uuid: "111",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.canBulkApproveOut), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
TotalCount: model.variables.getFoliosSAEAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosSAEAggr.dataFetchStatusAttr),
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
uuid: "112",
alias: "18"
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
uuid: "113",
alias: "19"
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
uuid: "114"
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
uuid: "115"
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
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "popups"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1"
},
visible: true,
_idProps: {
service: idService,
name: "Approve"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowBulkApproveFolioVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "BulkApproveForms"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_PopupFormSAEBulkApprove_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
l_FormApprovalLevelList: model.getCachedValue(idService.getId("aV0s3qHXkUmOvXwYAd5wPQ.l_FormApprovalLevelList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.l_FolioApprovalLevelListVar, new (OS$GenericTypeCache.getGenericList(RC_9983883fbc26c5bf3e842f01355fd0c8))(), function (source, target) {
target.formAttr = source.folioAttr;
target.formApprovalLevelAttr = source.folioApprovalLevelAttr;
return target;
});
}, function () {
return model.variables.l_FolioApprovalLevelListVar;
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn, notificationContentIn, notificationErrorIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_BulkApproveFoliosPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, controller.callContext(eventHandlerContext));
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
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowApproveFolioVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "ApproveForm"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ConfirmationText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("zA4wDLEKFk6XXkyoH8VjPA#Value.-1066222683.1", "Are you sure you want to approve the form?"),
i_PopupTitle: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("tPAAE5KHP0iR2aAq15PnAw#Value.-1679196512.1", "Confirm")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
confirm$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_a_ApproveFolioPopupClose$Action(true, controller.callContext(eventHandlerContext));
});
;
},
close$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_a_ApproveFolioPopupClose$Action(false, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "122",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))))];
}),
footer: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: false,
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider
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
uuid: "124",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_a_ApproveFolioPopupOpen$Action(model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.idAttr, model.variables.getFoliosSAEAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_exito.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("WSIytTlPb0SVgBSWLGNnCQ#Value", "Approve"))];
})
},
_dependencies: []
})), createElement(OutSystemsUI_Interaction_Notification_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionalConfigs: model.getCachedValue(idService.getId("NotifContentWB.OptionalConfigs"), function () {
return function () {
var rec = new ST_09173c1b0f41f719b9efd6430c2e737dStructure();
rec.interactToCloseAttr = true;
rec.closeAfterTimeAttr = 10000;
return rec;
}();
}),
Width: "500px",
Position: ConectaProveedores_staticEntities_position.topRight,
ExtendedClass: "card"
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
name: "NotifContentWB",
alias: "23"
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
uuid: "128",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
style: "font-size-h6",
value: model.variables.notifContentVar.titleAttr,
_idProps: {
service: idService,
uuid: "129"
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
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_info_lleno.svg"),
style: "img img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.notifContentVar.titleAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "font-semi-bold",
value: ((model.variables.notifContentVar.nrOfRecordsAffectedAttr).toString() + " "),
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("j4_TUydOw0K2fiNNJZPewA#Value", "records have been affected"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-bottom-s",
visible: (model.variables.notifContentVar.nrOfRecordsSuccessfulAttr > 0),
_idProps: {
service: idService,
uuid: "135"
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
uuid: "136",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_hecho_lleno.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
style: "font-semi-bold",
value: ((" " + (model.variables.notifContentVar.nrOfRecordsSuccessfulAttr).toString()) + " "),
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("u+ANXVMXJ0WHxVmVQumTFQ#Value", "have been successfully processed"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsSuccessfulAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: (model.variables.notifContentVar.nrOfRecordsUnsuccessfulAttr > 0),
_idProps: {
service: idService,
uuid: "139"
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
uuid: "140",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
style: "font-semi-bold",
value: ((" " + (model.variables.notifContentVar.nrOfRecordsUnsuccessfulAttr).toString()) + " "),
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("MjSme18fkkGGjP7yMNdqbQ#Value", "have given an error:"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsUnsuccessfulAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.notifErrorVar.approvalErrorListAttr,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.notifErrorVar.approvalErrorListAttr.getCurrent(callContext.iterationContext).errorAttr), asPrimitiveValue(model.variables.notifErrorVar.approvalErrorListAttr.getCurrent(callContext.iterationContext).numberAttr)]
}, createElement(OSWidgets$Expression, {
style: "font-semi-bold",
value: model.variables.notifErrorVar.approvalErrorListAttr.getCurrent(callContext.iterationContext).numberAttr,
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
value: (" - " + model.variables.notifErrorVar.approvalErrorListAttr.getCurrent(callContext.iterationContext).errorAttr),
_idProps: {
service: idService,
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, callContext, idService, "4")
},
_dependencies: []
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.notifErrorVar.approvalErrorListAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsUnsuccessfulAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsSuccessfulAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsAffectedAttr), asPrimitiveValue(model.variables.notifContentVar.titleAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.notifErrorVar.approvalErrorListAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsUnsuccessfulAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsSuccessfulAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsAffectedAttr), asPrimitiveValue(model.variables.notifContentVar.titleAttr), asPrimitiveValue(model.variables.l_ShowApproveFolioVar), asPrimitiveValue(model.variables.l_FolioApprovalLevelListVar), asPrimitiveValue(model.variables.l_ShowBulkApproveFolioVar), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_AssignedToMe()), asPrimitiveValue(model.variables.l_IsSelectedVar), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.getFoliosSAEAggr.countOut), asPrimitiveValue(model.variables.getFoliosSAEAggr.listOut), asPrimitiveValue(model.variables.getFoliosSAEAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.canBulkApproveOut), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.userRolesListOut), asPrimitiveValue(model.variables.l_ApplicationRoleIdForAggregateVar), asPrimitiveValue(model.variables.l_IsAllowSelectApplicationRolesVar), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_CreatedToDate()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_CreatedOnDate()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_SupplierId()), asPrimitiveValue(model.variables.getSuppliersAggr.listOut), asPrimitiveValue(model.variables.getFoliosSAEAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSuppliersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRegionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRegionsAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_RegionId()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_OrderNumber()), asPrimitiveValue(ConectaProveedoresClientVariables.getFolioForApproval_FolioNumber())]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "FoliosSAEForApprovalold",
functionKey: "a85928e6-28e8-46b6-83bb-c2dd199944d2",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.FoliosSAEForApprovalold",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.j_FoliosSAE.FoliosSAEForApprovalold.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Interaction_Search_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, OutSystemsUI_Interaction_DropdownSearch_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, Telcel_Theme_Utils_Wb_SupplierName_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_PopupFormSAEBulkApprove_mvc_view, ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Interaction_Notification_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view];
};


return ELEM;
};

export default componentFactory()
