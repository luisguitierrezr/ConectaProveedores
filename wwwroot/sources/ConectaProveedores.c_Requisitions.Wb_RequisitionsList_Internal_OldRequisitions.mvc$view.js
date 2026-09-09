import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, Link as OSWidgets$Link, Image as OSWidgets$Image, Button as OSWidgets$Button, Text as OSWidgets$Text, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_position as ConectaProveedores_staticEntities_position, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_requisitionStatus as ConectaProveedores_staticEntities_requisitionStatus, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus, SE_trigger as ConectaProveedores_staticEntities_trigger } from "./ConectaProveedores.staticEntities.js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure, ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import { createElement } from "react";
import { Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation, BuiltinFunctions as OS$BuiltinFunctions, GenericTypeCache as OS$GenericTypeCache, DataConversion as OS$DataConversion, Transitions as OS$Transitions } from "@outsystems/runtime-core-js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import OutSystemsUI_Interaction_Search_mvc_view from "./OutSystemsUI.Interaction.Search.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view from "./ConectaProveedores.y_Utils.Wb_SearchSupplierDropdown.mvc$view.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import Telcel_Theme_Utils_Wb_CalendarClear_mvc_view from "./Telcel_Theme.Utils.Wb_CalendarClear.mvc$view.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import Telcel_Theme_Utils_Wb_SupplierName_mvc_view from "./Telcel_Theme.Utils.Wb_SupplierName.mvc$view.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewIcons.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$view.js";
import ConectaProveedores_z_TableDownloadsPDF_Wb_DownloadsFloat_mvc_view from "./ConectaProveedores.z_TableDownloadsPDF.Wb_DownloadsFloat.mvc$view.js";
import ModelFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getUserApplicationRolesAndMoreDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TabsOrientation: ConectaProveedores_staticEntities_orientation.horizontal,
OptionalConfigs: model.getCachedValue(idService.getId("_PgpXjlgOUeqSOOJWK__6g.OptionalConfigs"), function () {
return function () {
var rec = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
rec.contentAutoHeightAttr = true;
rec.justifyHeadersAttr = true;
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
uuid: "1",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "2",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("KfGdGUIy30GqgUN8rmsFzg#Value", "Approvals"))];
})
},
_dependencies: []
}), $if(model.variables.getUserApplicationRolesAndMoreDataAct.o_CanUploadInvoicesOut, false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("BPmEnRWu0kqymG75iJJ86Q#Value", "Invoice Uploads"))];
})
},
_dependencies: []
})];
}, function () {
return [];
})];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "4",
alias: "4"
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
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: (auto);"
},
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "8"
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
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "10"
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
uuid: "11"
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
uuid: "12",
alias: "5"
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
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("FeVe_FCoV0amQGHlQZVqXw#Value", "Search input"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("txBGTt_v90271X1glYHYmg#ValueExpression.68060425.1", "Folio"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getRequisitions_RequisitionSearch(), function (value) {
ConectaProveedoresClientVariables.setRequisitions_RequisitionSearch(value);
}),
_idProps: {
service: idService,
name: "Input_Nothing2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_RequisitionSearch())]
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_Nothing2"),
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
uuid: "15",
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
style: "os-boxlabel margin-2percent 2percent",
visible: true,
_idProps: {
service: idService,
uuid: "16"
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
i_SupplierId: ConectaProveedoresClientVariables.getRequisitions_SupplierId(),
i_IsMandatory: false,
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
uuid: "17",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2",
marginLeft: "0"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("lsPz2cUwM0KbFSQZL9bN3Q#Value", "Requisition Status"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("tvxo1RZFkEKg5hwm_rEoHA#ValueExpression.65921.1", "All"),
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
labels: function (elem) {
return elem.requisitionStatusAttr.labelAttr;
},
list: model.variables.getRequisitionStatusesAggr.listOut,
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
return elem.requisitionStatusAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId(), function (value) {
ConectaProveedoresClientVariables.setRequisitions_RequisitionsStatusId(value);
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentProposalStatusId"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionStatusesAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel margin-left-2percent",
visible: model.getCachedValue(idService.getId("AXOu4xEWy0GyDkdJkLx_Vg.Visible"), function () {
return (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut));
}),
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("8NenjMwGpEysGzki5dVt9w#Value", "Approval Status"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("V1WgOAPymEqYspvhGZyKzQ#ValueExpression.65921.1", "All"),
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
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId(), function (value) {
ConectaProveedoresClientVariables.setRequisitions_ApprovalStatusId(value);
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
classes: "ThemeGrid_Width2"
},
style: "margin-2percent",
visible: true,
_idProps: {
service: idService,
uuid: "24"
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
controller.datePickerOnUploadDate$Action(selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerPaymentDateRequisitions",
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
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("WLHt+QVm7EKGjBorFw1VfQ#Value", "Creation Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "28",
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
i_Date: ConectaProveedoresClientVariables.getRequisitions_UploadDate()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
clear$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearCreationDate$Action(controller.callContext(eventHandlerContext));
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qI6I539npUSXBkxFUsDLXA#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getRequisitions_UploadDate(), function (value) {
ConectaProveedoresClientVariables.setRequisitions_UploadDate(value);
}),
_idProps: {
service: idService,
name: "Input_PaymentDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_UploadDate())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_UploadDate())]
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
uuid: "31"
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
uuid: "32"
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
visible: model.getCachedValue(idService.getId("8xo46Q11+kuXUaWWkjHPYw.Visible"), function () {
return (((((((((((!(ConectaProveedoresClientVariables.getRequisitions_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || ((ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId()) !== (OS$BuiltinFunctions.nullIdentifier()))) || ((ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId()) !== (OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getRequisitions_UploadDate().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getRequisitions_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_ProjectId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getRequisitions_CostCenterId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || ((OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getRequisitions_RequisitionSearch())) !== ("")));
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_SupplierId();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_UploadDate();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_CompanyId();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_ProjectId();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_AmountFrom();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_AmountTo();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_CostCenterId();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_RequisitionSearch();
}),
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_cerrar2.svg"),
style: "img-l",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "display-flex margin-top-base",
visible: model.variables.l_ShowFiltersVar,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel ",
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
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1Uo80mP7DkWpEIm6jGCWKg#Value", "Company"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("OXvs_XL99EyXEIwDvtNO8Q#ValueExpression.65921.1", "All"),
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
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, ConectaProveedoresClientVariables.getRequisitions_CompanyId(), function (value) {
ConectaProveedoresClientVariables.setRequisitions_CompanyId(value);
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
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dLtreJ0BNEuHR5+WopUjLw#Value", "Project "))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
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
rec.noResultsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("wWTmORxkXkmO0I7EoLy4Fg#Value.-1371290541.1", "No projects to show...");
rec.searchPromptAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vdRi8SdOmU6YeeSOXunpXg#Value.-512840794.1", "Search...");
rec.noOptionsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vCWKzWpyxUiVKssxpP+eqg#Value.-1371290541.1", "No projects to show...");
return rec;
}();
}),
StartingSelection: model.getCachedValue(idService.getId("DropdownSearchProject.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(ConectaProveedoresClientVariables.getRequisitions_ProjectId());
rec.labelAttr = "";
return rec;
}()]);
return list;
}();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_ProjectId();
}),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ix5W8eSFO0ee+DKSDshqMA#Value.65921.1", "All"),
OptionsList: model.getCachedValue(idService.getId("DropdownSearchProject.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getProjectAssetServicesAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.project_Asset_ServiceAttr.idAttr);
target.labelAttr = source.project_Asset_ServiceAttr.descriptionAttr;
return target;
});
}, function () {
return model.variables.getProjectAssetServicesAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr)
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
alias: "11"
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
uuid: "42"
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
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("asM7w2_i9ky13Tj5NGzhbA#Value", "From Amount"))), createElement(OSWidgets$Input, {
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
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
SuffixText: "",
RightAlign: true,
GroupSeparator: ",",
InputId: idService.getId("Input_AmountML3"),
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
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
uuid: "45",
alias: "12"
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
uuid: "46",
alias: "13"
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
uuid: "47"
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
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("gQfdJtitP0W7xep1dd584Q#Value", "To Amount"))), createElement(OSWidgets$Input, {
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
InputId: idService.getId("Input_AmountML2"),
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true,
PrefixText: "",
DecimalSeparator: ".",
SuffixText: "",
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
uuid: "50",
alias: "14"
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
uuid: "51",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
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
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("AyGY5a03UUKP3FqT7gsZ+w#Value", "Cost Center"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("_5Xa_418ckO7pxo0xuabpw#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.costCenterSAPAttr.ce_costeAttr;
},
list: model.variables.getCostCentersAggr.listOut,
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
return elem.costCenterSAPAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, ConectaProveedoresClientVariables.getRequisitions_CostCenterId(), function (value) {
ConectaProveedoresClientVariables.setRequisitions_CostCenterId(value);
}),
_idProps: {
service: idService,
name: "Dropdown_BankId4"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCostCentersAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "text-align-right",
visible: model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isSolicitanteAttr,
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getEntraRoleAggr.dataFetchStatusAttr)
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top,
ExtendedClass: "margin-left-base"
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
uuid: "56",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
}),
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn btn-plusbutton",
visible: true,
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.whiteplus.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("Um0m_jYw+0aWaZG9G52FUQ#Value", "Create Requisition"))];
})
},
_dependencies: []
})))), $if(model.variables.l_IsAllowSelectApplicationRolesVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel auto-width margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("PXAOzYVp2U+qxehu0Cb1wQ#Value", "Approval Level"))), createElement(OSWidgets$Dropdown, {
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
})), $if(model.variables.getRequisitionsDataAct.isDataFetchedAttr, false, this, function () {
return [$if((((((((((model.variables.getRequisitionsDataAct.listOut.isEmpty && ConectaProveedoresClientVariables.getRequisitions_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && (ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId() === OS$BuiltinFunctions.nullIdentifier())) && ConectaProveedoresClientVariables.getRequisitions_UploadDate().equals(OS$BuiltinFunctions.nullDate())) && ConectaProveedoresClientVariables.getRequisitions_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ConectaProveedoresClientVariables.getRequisitions_ProjectId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ConectaProveedoresClientVariables.getRequisitions_AmountFrom().equals(OS$BuiltinFunctions.integerToDecimal(0))) && ConectaProveedoresClientVariables.getRequisitions_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0))) && ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom().equals(OS$BuiltinFunctions.nullDate())) && ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo().equals(OS$BuiltinFunctions.nullDate())), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("X2aedMF880W1BVKqpJF4rw#Value", "You don\'t have any requisitions yet."))],
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
extendedProperties: {
style: "text-align: center;"
},
style: "margin-top-m",
visible: model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isSolicitanteAttr,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getEntraRoleAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
}),
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), null, true);
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
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_2od82TZHUK4UVxWE0ViBA#Value", "New requisition"))))];
}, function () {
return [$if((model.variables.getRequisitionsDataAct.listOut.isEmpty && (((((((!(ConectaProveedoresClientVariables.getRequisitions_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || ((ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId()) !== (OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getRequisitions_UploadDate().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getRequisitions_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_ProjectId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_CostCenterId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("J_ToxviC0UqUB2E_05fqKQ#Value", "No results were found with the selected filters."))],
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(true, controller.callContext(eventHandlerContext));
});
;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("hixKhsFpFEKvCZImxIp9Bg#Value", "Clear filters"))))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "71"
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
style: "font-semi-bold italic margin-right-s",
text: [$text(getTranslation("GoLvXXYVX0qR2RJEZ6Yr9g#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(true, false, this, function () {
return [];
}, function () {
return [];
})), createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
alias: "17"
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
source: model.variables.getRequisitionsDataAct.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "ConectaProveedoresRequisitionsGetRequisitions"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "Requisition.Name",
style: "donotshow",
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("2+MHtkAoqUWLWN7iiNsCCA#Value", "Name"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center"
},
sortAttribute: "RequisitionStatus.Label",
style: "donotshow",
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("QVQ0mht6Q02vzJ7lWGUotw#Value", "Action"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "ApprovalStatus.Label",
style: "donotshow",
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("pS19YoCGR0qxABkh_WRqLw#Value", "Requisition Status"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Requisition.CreatedOn",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Zq3cdXj8PkGb_rcJMguJFw#Value", "Creation Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Requisition.UpdatedOn",
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("da7V6F8jIkOzbuWFeE+hSA#Value", "Last change"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "UserApplicantName.Value",
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("YsDqPloVxEGjDvHCi8yZNQ#Value", "Requester"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Project_Asset_Service.Description",
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("epP1C5K3l0O9qtCYPr8Bbg#Value", "Project"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "Supplier.Name",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ft6N_U0jS0erkAi8ifvAtQ#Value", "Supplier"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "Region.Code",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4hOySo_rkU+fYvp_x_hlVA#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "Requisition.TotalAmount",
style: "donotshow",
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("mQzBaz7g4UOv6nTzW_+glA#Value", "Amount"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Currency.Code",
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("WOUkmfFbFEy1IgQeAUmyEA#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "CostCenterSAP.Denominacion",
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("h8Uf4tXh_E+IO8PrBwy3yw#Value", "Cost Center"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "Company.RFC",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("hYeM506Sh0CqeTMqdyXqNA#Value", "Company"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("76MrW5130ku6z8y4xYHL2g#Value", "Docs"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center; text-align: center;"
},
style: " setinvisible",
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("svfAov8Pm0yffVZZXd95lw#Value", "Available Tasks")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-right: 5px; text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
style: "margin-top: 2px;"
},
gridProperties: {
classes: "ThemeGrid_Width8"
},
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
}),
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr, {
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
i_NChar: 20,
i_Text: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
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
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr)]
}, $if(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "99"
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
uuid: "100",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
style: "margin-right: 0px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_balance_detalles.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("vNWSNVc0E06lXoQSH2VgHg#Value", "Advance Pay Without Invoice"))];
})
},
_dependencies: []
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr.valueAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.accountingRegionIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.getCachedValue(idService.getId("RequisitionStatus2.i_Text"), function () {
return (((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) || (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.expired)) || ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.canceled) && (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr === OS$BuiltinFunctions.nullIdentifier())))) ? ("") : ((((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId()) && ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr) !== (OS$BuiltinFunctions.getUserId()))) && (!(((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.idAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && (!(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr.valueAttr))))))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("s5mDFOQQX0+zPXTDPE8uJg#Value.-1942320933.1", "Submitted")) : ((((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr) !== (OS$BuiltinFunctions.nullIdentifier())) && (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut) || model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.accountingRegionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut)))) ? (((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr) ? ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr + " CxP")) : ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr + " AU")))) : (""))))));
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.idAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr.valueAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr;
}, function () {
return model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.accountingRegionIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr, model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr),
i_Class: model.getCachedValue(idService.getId("RequisitionStatus2.i_Class"), function () {
return (((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) || (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.expired)) || ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.canceled) && (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr === OS$BuiltinFunctions.nullIdentifier())))) ? ("") : ((((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId()) && ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr) !== (OS$BuiltinFunctions.getUserId()))) && (!(((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.idAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && (!(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr.valueAttr))))))) ? ("submitted") : ((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut) || model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.accountingRegionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut))) ? (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr) : (""))))));
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.idAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr.valueAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr;
}, function () {
return model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.accountingRegionIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr;
}),
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr, model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr)
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
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr)]
}, $if(((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr && (!(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr))) && ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.inApproval) || (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.approved))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "105"
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
Trigger: ConectaProveedores_staticEntities_trigger.onHover,
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
uuid: "106",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.contractPending.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("49Fz0nbdB0qzh1k4CODXFg#Value", "with Contract Pending"))];
})
},
_dependencies: []
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.labelAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.labelAttr,
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.createdOnAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("KTMGezqWtk+iibqGs9NAwQ.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.createdOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).updatedByAttr.valueAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.updatedOnAttr)]
}, $if(!(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.updatedOnAttr.equals(OS$BuiltinFunctions.nullDate())), false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_SupplierName_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_SupplierName: model.getCachedValue(idService.getId("f+_K8jiHbEGJDLtUFzIdIQ.i_SupplierName"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.updatedOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.updatedOnAttr;
}),
_i_SupplierNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
i_SupplierNumber: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).updatedByAttr.valueAttr,
_i_SupplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
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
uuid: "114",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).userApplicantNameAttr.valueAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_Text: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).userApplicantNameAttr.valueAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
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
uuid: "116",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_Text: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
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
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr)]
}, createElement(Telcel_Theme_Utils_Wb_SupplierName_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_SupplierNumber: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr,
_i_SupplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
i_SupplierName: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr,
_i_SupplierNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
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
uuid: "120",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr,
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.getCachedValue(idService.getId("rd0Q0JYmLke1a+CUcGagSw.i_Text"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
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
uuid: "124",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
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
uuid: "126",
alias: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).costCenterSAPAttr.denominacionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).costCenterSAPAttr.denominacionAttr,
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr)]
}, createElement(ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
RequisitionId: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr,
_requisitionIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
RequisitionName: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr,
_requisitionNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
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
alias: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approveAsAreaUsuariaAttr)]
}, $if(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approveAsAreaUsuariaAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "134"
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
Position: ConectaProveedores_staticEntities_position.top,
Trigger: ConectaProveedores_staticEntities_trigger.onHover
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
uuid: "135",
alias: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
style: "margin-top: 10px; padding: 0px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_info.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("XQkNKnUMQkGeY5PPYzaudA#Value", "Without Contract or Proof Of Foreign Residence"))];
})
},
_dependencies: []
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: center;"
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr.valueAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.accountingRegionIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) && (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId())), false, this, function () {
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
uuid: "139",
alias: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideCancelPopup$Action(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
gridProperties: {
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("JyiIsChkH0GbFitcOmjImw#Value", "Cancel Requisition"))];
})
},
_dependencies: []
})];
}, function () {
return [];
}), $if((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.idAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && (!(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr.valueAttr))) && ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || (model.variables.getUserApplicationRolesAndMoreDataAct.isCorporativoCxPOut && (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut) || model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.accountingRegionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut))))), false, this, function () {
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
uuid: "142",
alias: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
}),
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_EditBlue.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("wJ0m0JPMjkeezRWGmiWV2Q#Value", "Request Modification"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr)]
})];
}, function () {
return [];
})))];
}, callContext, idService, "6_0")
},
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TableName: idService.getId("ConectaProveedoresRequisitionsGetRequisitions"),
ConfigColumnJSON: model.variables.l_ColumnJSONVarGetRequisitionsVar,
PopupBtnId: idService.getId("OpenPopupLink"),
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
uuid: "145",
alias: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetRequisitionsVar), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TotalCount: OS$BuiltinFunctions.integerToLongInteger(model.variables.getRequisitionsDataAct.totalCountOut),
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
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
uuid: "146",
alias: "33"
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
uuid: "147",
alias: "34"
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
uuid: "148"
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
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
}))];
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
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetRequisitionsVar), asPrimitiveValue(model.variables.getRequisitionsDataAct.totalCountOut), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut), asPrimitiveValue(model.variables.getRequisitionsDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRolesListOut), asPrimitiveValue(model.variables.l_ApplicationRoleIdForAggregateVar), asPrimitiveValue(model.variables.l_IsAllowSelectApplicationRolesVar), asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isSolicitanteAttr), asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.l_AmountToTextVar), asPrimitiveValue(model.variables.l_AmountFromTextVar), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.listOut), asPrimitiveValue(model.variables.getCompaniesAggr.listOut), asPrimitiveValue(model.variables.l_ShowFiltersVar), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_CostCenterId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_AmountTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_AmountFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProjectId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_CompanyId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_UploadDate()), asPrimitiveValue(model.variables.getApprovalStatusesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId()), asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionStatusesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_SupplierId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_RequisitionSearch())]
}), $if(model.variables.getUserApplicationRolesAndMoreDataAct.o_CanUploadInvoicesOut, false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
alias: "35"
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
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_mvc_view, {
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
uuid: "153",
alias: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: []
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetRequisitionsVar), asPrimitiveValue(model.variables.getRequisitionsDataAct.totalCountOut), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut), asPrimitiveValue(model.variables.getRequisitionsDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.l_ApplicationRoleIdForAggregateVar), asPrimitiveValue(model.variables.l_IsAllowSelectApplicationRolesVar), asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isSolicitanteAttr), asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.l_AmountToTextVar), asPrimitiveValue(model.variables.l_AmountFromTextVar), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.listOut), asPrimitiveValue(model.variables.getCompaniesAggr.listOut), asPrimitiveValue(model.variables.l_ShowFiltersVar), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_CostCenterId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_AmountTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_AmountFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProjectId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_CompanyId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_UploadDate()), asPrimitiveValue(model.variables.getApprovalStatusesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId()), asPrimitiveValue(model.variables.getRequisitionStatusesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_SupplierId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_RequisitionSearch()), asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRolesListOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.o_CanUploadInvoicesOut)]
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowCancelPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "Cancel"
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
i_ConfirmationText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5C3GuCL010iMd+jQ6vh1sA#Value.-417569474.1", "Are you sure you want to cancel the requisition? This action is irreversible."),
i_PopupTitle: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1WBq9gHXcU6_gdBw+Ay1aA#Value.-602822666.1", "Cancel Requisition")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
confirm$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.cancelRequisition$Action(controller.callContext(eventHandlerContext));
});
;
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideCancelPopup$Action(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "156",
alias: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(ConectaProveedores_z_TableDownloadsPDF_Wb_DownloadsFloat_mvc_view, {
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
uuid: "157",
alias: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_RequisitionsList_Internal_OldRequisitions",
functionKey: "c179a2d4-7241-4a7b-bc77-a556ce4ec5b2",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, OutSystemsUI_Interaction_Search_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, Telcel_Theme_Utils_Wb_CalendarClear_mvc_view, OutSystemsUI_Interaction_DropdownSearch_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, Telcel_Theme_Utils_Wb_SupplierName_mvc_view, ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_mvc_view, ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, ConectaProveedores_z_TableDownloadsPDF_Wb_DownloadsFloat_mvc_view];
};


return ELEM;
};

export default componentFactory()
