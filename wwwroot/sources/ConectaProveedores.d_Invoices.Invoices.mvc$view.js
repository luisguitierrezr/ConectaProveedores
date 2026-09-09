import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, Checkbox as OSWidgets$Checkbox, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup, List as OSWidgets$List } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Interaction_Search_mvc_view from "./OutSystemsUI.Interaction.Search.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import { ST_4e53cb8815b86020ced1d2f2652c9b1dStructure, ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ST_bc4abb4233d9ce894e855c520a20c76fStructure, ST_09173c1b0f41f719b9efd6430c2e737dStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view from "./ConectaProveedores.y_Utils.Wb_SearchSupplierDropdown.mvc$view.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import Telcel_Theme_Utils_Wb_CalendarClear_mvc_view from "./Telcel_Theme.Utils.Wb_CalendarClear.mvc$view.js";
import { SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus, SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import Telcel_Theme_Utils_Wb_SupplierNameWithRFC_mvc_view from "./Telcel_Theme.Utils.Wb_SupplierNameWithRFC.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoicesCurrentApprover.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ExpandableTableRow_UIFlow_ExpandableTableRow_mvc_view from "./ExpandableTableRow.UIFlow.ExpandableTableRow.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_I_MoreDetails_mvc_view from "./ConectaProveedores.d_Invoices.Wb_I_MoreDetails.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import { RC_3b5a20a3b041a6f2c3616e35c15dcd14 } from "./ConectaProveedores.model.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkCancel_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceBulkCancel.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceCancel.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkApprove_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceBulkApprove.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_PopupApprove_mvc_view from "./ConectaProveedores.y_Utils.Wb_PopupApprove.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkComment_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceBulkComment.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceComment_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceComment.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceAssignFirstApprover.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceAssignAnalista.mvc$view.js";
import ConectaProveedores_z_TableDownloadsPDF_Wb_DownloadsFloat_mvc_view from "./ConectaProveedores.z_TableDownloadsPDF.Wb_DownloadsFloat.mvc$view.js";
import OutSystemsUI_Interaction_Notification_mvc_view from "./OutSystemsUI.Interaction.Notification.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Invoices.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Invoices.mvc$controller.js";
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
text: [$text(getTranslation("Wqi9cGg7FUuiDyI4gm9eXA#Value", "Homepage"))],
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
text: [$text(getTranslation("7lYilHSOykqh_3pOWbnQbg#Value", "Dashboard"))],
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
text: [$text(getTranslation("TQZhjrWK90W5t6nGVrBjBw#Value", "Invoices"))],
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
text: [$text(getTranslation("e3hzSSSk3Emo5y21V6wFUQ#Value", "Invoices"))],
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
}, $text(getTranslation("81SJXP4gtU2QoK6iIEBP5g#Value", "Search input"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("H6EPho1aZ0O7e7eS2Tjwdw#ValueExpression.-1400292388.1", "Invoice Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getInvoice_InvoiceName(), function (value) {
ConectaProveedoresClientVariables.setInvoice_InvoiceName(value);
}),
_idProps: {
service: idService,
name: "Input_Search"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_InvoiceName())]
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
}, $text(getTranslation("wNgcVevawE6NhV4bVQbJvQ#Value", "Search input"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("elX0Z9sHp0SWH1RAdhmpuA#ValueExpression.466416525.1", "Requisition Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getInvoice_RequisitionName(), function (value) {
ConectaProveedoresClientVariables.setInvoice_RequisitionName(value);
}),
_idProps: {
service: idService,
name: "Input_Search2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_RequisitionName())]
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
uuid: "28",
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
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("g9xWDiqhyU26ePq9UUQkxQ#Value", "Company"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("T+WhHRky+kOC5_QxW638hQ#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.companyAttr.descriptionAttr;
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
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, ConectaProveedoresClientVariables.getInvoice_CompanyId(), function (value) {
ConectaProveedoresClientVariables.setInvoice_CompanyId(value);
}),
_idProps: {
service: idService,
name: "Dropdown_BankId2"
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
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel ",
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
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("XwepFhQN0kew+b19db+S7g#Value", "Project "))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionalConfigs: model.getCachedValue(idService.getId("DropdownSearchProject.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.allowMultipleSelectionAttr = false;
rec.isDisabledAttr = false;
rec.noResultsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("x1mIhJAYGkyYGrOw39p7UA#Value.-1371290541.1", "No projects to show...");
rec.searchPromptAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WlxJKaIDjkCBAVlg2ir6kA#Value.-512840794.1", "Search...");
rec.noOptionsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0Mf7Y48wekuVIhAfKljoxg#Value.-1371290541.1", "No projects to show...");
return rec;
}();
}),
OptionsList: model.getCachedValue(idService.getId("DropdownSearchProject.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getProjectAssetServicesAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.project_Asset_ServiceAttr.idAttr);
target.labelAttr = source.project_Asset_ServiceAttr.descriptionAttr;
return target;
});
}, function () {
return model.variables.getProjectAssetServicesAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3zELemgJEECfq65csUXvsQ#Value.65921.1", "All"),
StartingSelection: model.getCachedValue(idService.getId("DropdownSearchProject.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(ConectaProveedoresClientVariables.getInvoice_ProjectId());
rec.labelAttr = "";
return rec;
}()]);
return list;
}();
}, function () {
return ConectaProveedoresClientVariables.getInvoice_ProjectId();
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownProjectSearchOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DropdownSearchProject",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
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
style: "margin-right-m",
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
i_IsFilter: true,
i_IsMandatory: false,
i_SupplierId: ConectaProveedoresClientVariables.getInvoice_SupplierId(),
i_IsValid: true,
i_IsDisable: false
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
uuid: "36",
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
style: "os-boxlabel margin-left-2percent",
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nt6hOADp00mR24EiL4iLsQ#Value", "Approval Status"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ILCfZd++ikKw4em6ftH_wQ#ValueExpression.65921.1", "All"),
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
labels: function (elem) {
return elem.approvalStatusAttr.labelESAttr;
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
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getInvoice_ApprovalStatusId(), function (value) {
ConectaProveedoresClientVariables.setInvoice_ApprovalStatusId(value);
}),
_idProps: {
service: idService,
name: "Dropdown_ApprovalStatus"
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
DateFormat: "DD/MM/YYYY",
OptionalConfigs: model.getCachedValue(idService.getId("DatePickerFrom.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
return rec;
}();
}),
ShowTodayButton: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerFrom$Action(OS$BuiltinFunctions.dateTimeToDate(selectedDateTimeIn), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerFrom",
alias: "8"
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
uuid: "42"
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
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("hmwQpLi2bUmbRNoj0vJ7HA#Value", "Upload date from"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "44",
alias: "9"
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
i_Date: ConectaProveedoresClientVariables.getInvoice_UploadDateFrom()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
clear$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearUploadDateFrom$Action(controller.callContext(eventHandlerContext));
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
alias: "10"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("c9vn6Q2UoUaXRgoFKATSug#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getInvoice_UploadDateFrom(), function (value) {
ConectaProveedoresClientVariables.setInvoice_UploadDateFrom(value);
}),
_idProps: {
service: idService,
name: "Input_PaymentDate2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_UploadDateFrom())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_UploadDateFrom())]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
name: "DateTo"
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
DateFormat: "DD/MM/YYYY",
OptionalConfigs: model.getCachedValue(idService.getId("DatePickerTo.OptionalConfigs"), function () {
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
controller.datePickerTo$Action(OS$BuiltinFunctions.dateTimeToDate(selectedDateTimeIn), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerTo",
alias: "11"
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
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_PaymentDate3",
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("A2I0X_aIwESHqRn_3ie4jQ#Value", "Upload date to"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "51",
alias: "12"
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
i_Date: ConectaProveedoresClientVariables.getInvoice_UploadDateTo()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
clear$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearUploadDateTo$Action(controller.callContext(eventHandlerContext));
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
alias: "13"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gZ9OXzWuJU+NtLLHF4bC6A#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getInvoice_UploadDateTo(), function (value) {
ConectaProveedoresClientVariables.setInvoice_UploadDateTo(value);
}),
_idProps: {
service: idService,
name: "Input_PaymentDate3"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_UploadDateTo())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_UploadDateTo())]
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
visible: model.getCachedValue(idService.getId("25H2JcjzjU23yrQEkjhqOQ.Visible"), function () {
return (((((((ConectaProveedoresClientVariables.getInvoice_InvoiceName()) !== ("")) || ((ConectaProveedoresClientVariables.getInvoice_RequisitionName()) !== (""))) || !(ConectaProveedoresClientVariables.getInvoice_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getInvoice_UploadDateFrom().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getInvoice_UploadDateTo().equals(OS$BuiltinFunctions.nullDate()))) || ((ConectaProveedoresClientVariables.getInvoice_ApprovalStatusId()) !== (OS$BuiltinFunctions.nullIdentifier())));
}, function () {
return ConectaProveedoresClientVariables.getInvoice_InvoiceName();
}, function () {
return ConectaProveedoresClientVariables.getInvoice_RequisitionName();
}, function () {
return ConectaProveedoresClientVariables.getInvoice_SupplierId();
}, function () {
return ConectaProveedoresClientVariables.getInvoice_UploadDateFrom();
}, function () {
return ConectaProveedoresClientVariables.getInvoice_UploadDateTo();
}, function () {
return ConectaProveedoresClientVariables.getInvoice_ApprovalStatusId();
}),
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_cerrar2.svg"),
style: "img-l",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "55"
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
uuid: "56"
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
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("aA_mQF_sukawN_njF1mEHA#Value", "Approval Level"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: true,
labels: function (elem) {
return elem.roleNameAttr;
},
list: model.variables.getUserApplicationRolesAndMoreDataAct.userRolesListOut,
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
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr),
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
name: "listContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoicesAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getInvoicesAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-align-center",
text: [$text(getTranslation("nqmg7bnnvkmW2jux6aYbHw#Value", "There are no pending invoices at this time."))],
_idProps: {
service: idService,
uuid: "62"
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
uuid: "63"
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
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.l_IsShowSelectAllVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-bottom-s",
visible: model.variables.getUserApplicationRolesAndMoreDataAct.isSupervisorOut,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Button, {
enabled: ((model.variables.l_IsSelectAllForAssignmentVar === true) || (model.variables.l_IsSelectedForAssignmentVar === true)),
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_b_BulkAssignPopUpOpen$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn bulkrapprove",
visible: true,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_crear_grupo.svg"),
style: "img img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "text-third margin-left-s",
text: [$text(getTranslation("zZ6+ngHlVk2QRrBEMxca9w#Value", "Bulk Assign"))],
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
gridProperties: {
classes: "OSInline"
},
visible: (!(model.variables.getUserApplicationRolesAndMoreDataAct.isAnalistaCxPOut)),
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Button, {
enabled: ((model.variables.l_IsSelectAllForApprovalVar === true) || (model.variables.l_IsSelectedForApprovalVar === true)),
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
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_exito.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "text-third margin-left-s",
text: [$text(getTranslation("Wq1djkLIYUKh+HDN2BdhvQ#Value", "Bulk Approve"))],
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
gridProperties: {
classes: "OSInline ThemeGrid_MarginGutter"
},
visible: (!(model.variables.getUserApplicationRolesAndMoreDataAct.isAnalistaCxPOut)),
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Button, {
enabled: ((model.variables.l_IsSelectAllVar === true) || (model.variables.l_IsSelectedForApprovalVar === true)),
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_b_BulkCancelInvoicesPopupOpen$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn bulkreject",
visible: true,
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("1GFAOrI+9U+jiQhgxpCsrg#Value", "Bulk Cancel"))],
_idProps: {
service: idService,
uuid: "77"
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
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: ((model.variables.l_IsSelectAllVar === true) || (model.variables.l_IsSelectedForApprovalVar === true)),
extendedProperties: {
style: "color: #000;"
},
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_c_BulkInvoiceCommentOpen$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn bulkcomment",
visible: true,
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_chat2.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
extendedProperties: {
style: "color: #7b1fa2;"
},
style: "margin-left-s",
text: [$text(getTranslation("Z+u4_ZajIkugTr7hrMVoEA#Value", "Bulk Comment"))],
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}))))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right; bottom: 0; right: 0;"
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
text: [$text(getTranslation("evxMKxdpvkui3ZhBcmeovQ#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(true, false, this, function () {
return [];
}, function () {
return [];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "85"
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
uuid: "86",
alias: "14"
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
source: model.variables.getInvoicesAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "InvoicesTable"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isAnalistaCxPOut), asPrimitiveValue(model.variables.l_IsShowSelectAllVar)]
}, $if(model.variables.l_IsShowSelectAllVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: ((!(model.variables.getUserApplicationRolesAndMoreDataAct.isAnalistaCxPOut)) ? "True" : "False"),
visible: true,
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr)
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
sortAttribute: "Invoice.Name",
style: "donotshow",
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6qEpuINg8US+OTbkKCTr6g#Value", "Invoice"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Requisition.Name",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4mSfXmRGwkqC0r8qk7qidQ#Value", "Requisition"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Supplier.Number",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("0_Xv8Mp+G0ieTH_IkTTOrA#Value", "Supplier "))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Region.Code",
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("a9sXBCeuWE6bkF2qA9iS1w#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.TotalAmount",
style: "",
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("UWYdsP+D70mMk3xyU6f_Ng#Value", "Total Amount"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Invoice.CreatedOn",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("O3AyG1WP40uKAiImIqgF7Q#Value", "Upload Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ApprovalStatus.Id",
style: "donotshow",
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("xc_ETdexQEGM6Cuj8vkAIw#Value", "Action"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.InvoiceStatusId",
style: "donotshow",
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("2wBdJutyHE2Sdvjd4FH3IA#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "InvoiceApprovalLevel.AssignedTo",
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("_k7FDK14WkOQTBGPzbxxgA#Value", "Assigned To"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("+BAtWOHNMUOhyAFU_t+T2Q#Value", "Available Tasks"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isAnalistaCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvedByAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.selectsNextApproverAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr)]
}, $if(((((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr)) && ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.accounting))) || ((((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.toAssign) && ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr)) && model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.selectsNextApproverAttr) && (model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvedByAttr === OS$BuiltinFunctions.nullTextIdentifier()))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: (!(model.variables.getUserApplicationRolesAndMoreDataAct.isAnalistaCxPOut)),
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.isAnyLineSelected$Action(model.variables.getInvoicesAggr.listOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr, function (value) {
model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox_IsSelected"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
style: "bold underline",
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Invoices_Detail", {
i_InvoiceId: OS$DataConversion.ServerDataConverter.to(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "106"
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
i_Text: model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr),
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
uuid: "107",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_Text: model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr)
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
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr)]
}, createElement(Telcel_Theme_Utils_Wb_SupplierNameWithRFC_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_SupplierNumber: model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr,
_i_SupplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr),
i_SupplierName: model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr,
_i_SupplierNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr),
i_NChar: 20,
i_RFC: model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr,
_i_RFCInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr)
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
uuid: "111",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr + " - ") + model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr),
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("1QW_xP_bAEiGXWbGb22YnA.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
style: "",
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Prjjn7cXbEiISDKSvQWqPA.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "",
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr)]
}, $if((((((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr) || ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.toAssign) && model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr)) || (model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId())) || ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.assigned) && model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr)), false, this, function () {
return [createElement(OSWidgets$Expression, {
style: "bold",
value: model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr,
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr)
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
style: "",
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr,
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalAttr.invoiceIdAttr)]
}, createElement(ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InvoiceId: model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalAttr.invoiceIdAttr,
_invoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr)
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
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isAnalistaCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.selectsNextApproverAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvedByAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.selectsFirstApproverAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr) !== (OS$BuiltinFunctions.nullIdentifier())) && ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr)), false, this, function () {
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
uuid: "127",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_c_InvoiceCommentOpen$Action(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr, model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_chat.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("U1CAdXmk7kmyH9Z59e+qqA#Value", "Comment"))];
})
},
_dependencies: []
})];
}, function () {
return [];
}), $if((((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr)) && ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.accounting))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "align-column-vertically",
visible: (!(model.variables.getUserApplicationRolesAndMoreDataAct.isAnalistaCxPOut)),
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr)
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
uuid: "131",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_a_RejectInvoicePopupOpen$Action(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalAttr.invoiceIdAttr, model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "132"
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
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("SnTqykIBe0KfP6XQLzBCRA#Value", "Cancel"))];
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
uuid: "134",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_a_ApproveInvoicePoupOpen$Action(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr, model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_exito.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("WX1iQ6leEEuhuGm4Z9z8Bw#Value", "Approve"))];
})
},
_dependencies: []
}))];
}, function () {
return [$if(((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.toAssign) && ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr)), false, this, function () {
return [$if((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.selectsFirstApproverAttr && (model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvedByAttr === OS$BuiltinFunctions.nullTextIdentifier())), false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "137",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_d_InvoiceAssignFirstApproverOpen$Action(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_crear_grupo.svg"),
style: "img-m text-align-center",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("nr27ntHJmEW28DXmSHedRw#Value", "Assign first approver"))];
})
},
_dependencies: []
})];
}, function () {
return [$if((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.selectsNextApproverAttr && (model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvedByAttr === OS$BuiltinFunctions.nullTextIdentifier())), false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_e_InvoiceAssignAnalistaOpen$Action(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr, model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_crear_grupo.svg"),
style: "img-m text-align-center",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("zfO+Q7DD4Ue3nCzCX2HyvA#Value", "Assign approver"))];
})
},
_dependencies: []
})];
}, function () {
return [];
})];
})];
}, function () {
return [];
})];
}))), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: center;"
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr), asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isAreaCxPAttr)]
}, $if(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isAreaCxPAttr, false, this, function () {
return [createElement(ExpandableTableRow_UIFlow_ExpandableTableRow_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StyleCell: "text-align-center"
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
uuid: "144",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
iconClose: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "chevron-up",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
iconOpen: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "chevron-down",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
iconLabel: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("w0vGAtkwG0G9e6vZf5LdmQ#Value", "Details"))];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_d_Invoices_Wb_I_MoreDetails_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InvoiceId: model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr,
_invoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr)
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
uuid: "147",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr)]
})];
}, function () {
return [];
}))];
}, callContext, idService, "4_0")
},
_dependencies: [asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isAreaCxPAttr), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isAnalistaCxPOut), asPrimitiveValue(model.variables.l_IsShowSelectAllVar)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TableName: idService.getId("InvoicesTable"),
PopupBtnId: idService.getId("OpenPopupLink"),
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
uuid: "148",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isAreaCxPAttr), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isAnalistaCxPOut), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.listOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TotalCount: model.variables.getInvoicesAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesAggr.dataFetchStatusAttr),
StartIndex: model.variables.l_StartIndexVar,
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords()
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
uuid: "149",
alias: "27"
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
uuid: "150",
alias: "28"
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
uuid: "151"
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
uuid: "152"
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
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
name: "Reject"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowBulkRejectPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "BulkRejectInvoices"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkCancel_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
l_InvoiceApprovalLevelList: model.getCachedValue(idService.getId("ZKCK766P60i3KRlZX6mXIw.l_InvoiceApprovalLevelList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.l_InvoiceApprovalLevelListVar, new (OS$GenericTypeCache.getGenericList(RC_3b5a20a3b041a6f2c3616e35c15dcd14))(), function (source, target) {
target.invoiceApprovalLevelAttr = source.invoiceApprovalLevelAttr;
target.invoiceIdAttr = source.invoiceAttr;
return target;
});
}, function () {
return model.variables.l_InvoiceApprovalLevelListVar;
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn, notificationContentIn, notificationErrorIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_BulkCancelInvoicesPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "157",
alias: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowRejectInvoiceVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "RejectInvoice"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_InvoiceId: model.variables.l_InvoiceIdVar,
i_InvoiceApprovalLevelId: model.variables.l_InvoiceApprovalLevelIdVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_a_RejectInvoicesPopupClose$Action(isRefreshIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "159",
alias: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
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
showPopup: model.variables.l_ShowBulkApproveInvoicesVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "BulkApproveInvoices"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkApprove_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
l_InvoiceApprovalLevelList: model.getCachedValue(idService.getId("Of6b0eVXZ0+esrm5d8BZ4A.l_InvoiceApprovalLevelList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.l_InvoiceApprovalLevelListVar, new (OS$GenericTypeCache.getGenericList(RC_3b5a20a3b041a6f2c3616e35c15dcd14))(), function (source, target) {
target.invoiceApprovalLevelAttr = source.invoiceApprovalLevelAttr;
target.invoiceIdAttr = source.invoiceAttr;
return target;
});
}, function () {
return model.variables.l_InvoiceApprovalLevelListVar;
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn, notificationContentIn, notificationErrorIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_BulkApproveInvoicesPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "162",
alias: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowApproveInvoiceVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "ApproveInvoice"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_PopupApprove_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Title: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("B2PSGw5UUESnqNscRNWRPQ#Value.-463170278.1", "Approve Invoice")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isOkIn, commentIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_a_ApproveInvoicePopupClose$Action(isOkIn, commentIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "164",
alias: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowBulkCommentVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "BulkCommentInvoices"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkComment_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
l_InvoiceApprovalLevelList: model.getCachedValue(idService.getId("70g4YVeANkeoJvDAp3Ug3g.l_InvoiceApprovalLevelList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.l_InvoiceApprovalLevelListVar, new (OS$GenericTypeCache.getGenericList(RC_3b5a20a3b041a6f2c3616e35c15dcd14))(), function (source, target) {
target.invoiceApprovalLevelAttr = source.invoiceApprovalLevelAttr;
target.invoiceIdAttr = source.invoiceAttr;
return target;
});
}, function () {
return model.variables.l_InvoiceApprovalLevelListVar;
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn, notificationContentIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_c_BulkInvoiceCommentClose$Action(isRefreshIn, notificationContentIn, controller.callContext(eventHandlerContext));

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
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowCommentVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "CommentInvoice"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceComment_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InvoiceId: model.variables.l_InvoiceIdVar,
i_InvoiceApprovalLevelId: model.variables.l_InvoiceApprovalLevelIdVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_c_InvoiceCommentClose$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "169",
alias: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowAssignFirstApproverPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "AssignApprover"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InvoiceId: model.variables.l_InvoiceIdVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_d_InvoiceAssignFirstApproverClose$Action(isRefreshIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "171",
alias: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); "
},
showPopup: model.variables.l_ShowAssignAnalistaPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "AssignAnalista"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
l_InvoiceApprovalLevelList: model.variables.l_InvoiceApprovalLevelListVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn, notificationContentIn, notificationErrorIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_BulkAssignInvoicesPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "173",
alias: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}),
footer: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_z_TableDownloadsPDF_Wb_DownloadsFloat_mvc_view, {
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
onClick$Action: function (i_IsCSVIn, i_IsPDFIn, i_IsXLSIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_DownloadsFloatOnClick$Action(i_IsCSVIn, i_IsPDFIn, i_IsXLSIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "174",
alias: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OutSystemsUI_Interaction_Notification_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.topRight,
Width: "500px",
ExtendedClass: "card",
OptionalConfigs: model.getCachedValue(idService.getId("NotifContentWB.OptionalConfigs"), function () {
return function () {
var rec = new ST_09173c1b0f41f719b9efd6430c2e737dStructure();
rec.interactToCloseAttr = true;
return rec;
}();
})
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
alias: "38"
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
uuid: "176",
alias: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
style: "font-size-h6",
value: model.variables.notifContentVar.titleAttr,
_idProps: {
service: idService,
uuid: "177"
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
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_info_lleno.svg"),
style: "img img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "179"
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
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "font-semi-bold",
value: ((model.variables.notifContentVar.nrOfRecordsAffectedAttr).toString() + " "),
_idProps: {
service: idService,
uuid: "181"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("VfmOhHcZjUyNqv6XUS8jgQ#Value", "records have been affected"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-bottom-s",
visible: (model.variables.notifContentVar.nrOfRecordsSuccessfulAttr > 0),
_idProps: {
service: idService,
uuid: "183"
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
uuid: "184",
alias: "40"
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
uuid: "185"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
style: "font-semi-bold",
value: ((" " + (model.variables.notifContentVar.nrOfRecordsSuccessfulAttr).toString()) + " "),
_idProps: {
service: idService,
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("A7uZm92aZEu1vL9chBGQJg#Value", "have been successfully processed"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsSuccessfulAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: (model.variables.notifContentVar.nrOfRecordsUnsuccessfulAttr > 0),
_idProps: {
service: idService,
uuid: "187"
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
uuid: "188",
alias: "41"
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
uuid: "189"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
style: "font-semi-bold",
value: ((" " + (model.variables.notifContentVar.nrOfRecordsUnsuccessfulAttr).toString()) + " "),
_idProps: {
service: idService,
uuid: "190"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("zDXrVjLiI06W300Y5HirVg#Value", "have given an error:"))];
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
uuid: "191"
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
Height: "400px",
Orientation: ConectaProveedores_staticEntities_orientation.vertical,
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
uuid: "192",
alias: "42"
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
uuid: "193"
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
uuid: "194"
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
uuid: "195"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.notifErrorVar.approvalErrorListAttr.getCurrent(callContext.iterationContext).errorAttr), asPrimitiveValue(model.variables.notifErrorVar.approvalErrorListAttr.getCurrent(callContext.iterationContext).numberAttr)]
}, createElement(OSWidgets$Expression, {
style: "font-semi-bold",
value: model.variables.notifErrorVar.approvalErrorListAttr.getCurrent(callContext.iterationContext).numberAttr,
_idProps: {
service: idService,
uuid: "196"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
value: (" - " + model.variables.notifErrorVar.approvalErrorListAttr.getCurrent(callContext.iterationContext).errorAttr),
_idProps: {
service: idService,
uuid: "197"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, callContext, idService, "5")
},
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.notifErrorVar.approvalErrorListAttr)]
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.notifErrorVar.approvalErrorListAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsUnsuccessfulAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsSuccessfulAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsAffectedAttr), asPrimitiveValue(model.variables.notifContentVar.titleAttr)]
}), createElement(OutSystemsUI_Interaction_Notification_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "card",
OptionalConfigs: model.getCachedValue(idService.getId("NotifNoPendingAssignInv.OptionalConfigs"), function () {
return function () {
var rec = new ST_09173c1b0f41f719b9efd6430c2e737dStructure();
rec.interactToCloseAttr = true;
return rec;
}();
}),
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
name: "NotifNoPendingAssignInv",
alias: "43"
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
uuid: "199",
alias: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gyqFiPaltk6vD0ybJtWQ8w#ValueExpression.-1854120647.1", "There are no invoices pending assignment") + "."),
_idProps: {
service: idService,
uuid: "200"
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
uuid: "201"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_info_lleno.svg"),
style: "img img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "202"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
})];
})
},
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.notifErrorVar.approvalErrorListAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsUnsuccessfulAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsSuccessfulAttr), asPrimitiveValue(model.variables.notifContentVar.nrOfRecordsAffectedAttr), asPrimitiveValue(model.variables.notifContentVar.titleAttr), asPrimitiveValue(model.variables.l_ShowAssignAnalistaPopupVar), asPrimitiveValue(model.variables.l_ShowAssignFirstApproverPopupVar), asPrimitiveValue(model.variables.l_ShowCommentVar), asPrimitiveValue(model.variables.l_ShowBulkCommentVar), asPrimitiveValue(model.variables.l_ShowApproveInvoiceVar), asPrimitiveValue(model.variables.l_ShowBulkApproveInvoicesVar), asPrimitiveValue(model.variables.l_InvoiceApprovalLevelIdVar), asPrimitiveValue(model.variables.l_InvoiceIdVar), asPrimitiveValue(model.variables.l_ShowRejectInvoiceVar), asPrimitiveValue(model.variables.l_InvoiceApprovalLevelListVar), asPrimitiveValue(model.variables.l_ShowBulkRejectPopupVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isAreaCxPAttr), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsSelectedForApprovalVar), asPrimitiveValue(model.variables.l_IsSelectAllForApprovalVar), asPrimitiveValue(model.variables.l_IsSelectedForAssignmentVar), asPrimitiveValue(model.variables.l_IsSelectAllForAssignmentVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.getInvoicesAggr.countOut), asPrimitiveValue(model.variables.getInvoicesAggr.listOut), asPrimitiveValue(model.variables.getInvoicesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isAnalistaCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isSupervisorOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRolesListOut), asPrimitiveValue(model.variables.l_ApplicationRoleIdForAggregateVar), asPrimitiveValue(model.variables.l_IsAllowSelectApplicationRolesVar), asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_UploadDateTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_UploadDateFrom()), asPrimitiveValue(model.variables.getApprovalStatusesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_ApprovalStatusId()), asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_SupplierId()), asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_ProjectId()), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.listOut), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_CompanyId()), asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_RequisitionName()), asPrimitiveValue(ConectaProveedoresClientVariables.getInvoice_InvoiceName())]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "Invoices",
functionKey: "2399a4ce-a886-4785-a29c-32cc018f3a24",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Invoices",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.d_Invoices.Invoices.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Interaction_Search_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, OutSystemsUI_Interaction_DropdownSearch_mvc_view, ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, Telcel_Theme_Utils_Wb_CalendarClear_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, Telcel_Theme_Utils_Wb_SupplierNameWithRFC_mvc_view, ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ExpandableTableRow_UIFlow_ExpandableTableRow_mvc_view, ConectaProveedores_d_Invoices_Wb_I_MoreDetails_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkCancel_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkApprove_mvc_view, ConectaProveedores_y_Utils_Wb_PopupApprove_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkComment_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceComment_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_mvc_view, ConectaProveedores_z_TableDownloadsPDF_Wb_DownloadsFloat_mvc_view, OutSystemsUI_Interaction_Notification_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view];
};


return ELEM;
};

export default componentFactory()
