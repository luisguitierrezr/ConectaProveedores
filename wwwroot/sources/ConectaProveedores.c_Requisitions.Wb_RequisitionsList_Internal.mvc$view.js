import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, Link as OSWidgets$Link, Image as OSWidgets$Image, Button as OSWidgets$Button, Text as OSWidgets$Text, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_position as ConectaProveedores_staticEntities_position, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_requisitionStatus as ConectaProveedores_staticEntities_requisitionStatus, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus, SE_trigger as ConectaProveedores_staticEntities_trigger } from "./ConectaProveedores.staticEntities.js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure, ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure } from "./OutSystemsUI.model.js";
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
import ModelFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal.mvc$controller.js";

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
OptionalConfigs: model.getCachedValue(idService.getId("J5CaHWfQHUCwYGIqWJ3iOg.OptionalConfigs"), function () {
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
return [$text(getTranslation("M1WcEWiNqUOL7rJCRCTSuA#Value", "Approvals"))];
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
return [$text(getTranslation("x9D_NSVQ90WUTOoYe+F0GQ#Value", "Invoice Uploads"))];
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
}, $text(getTranslation("03QhcfQKwE2+f2YzjYg9Eg#Value", "Search input"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("O0ZB0cWBBkauFyPRI1p4cQ#ValueExpression.68060425.1", "Folio"),
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
i_SupplierId: ConectaProveedoresClientVariables.getRequisitions_SupplierId(),
i_IsFilter: true,
i_IsMandatory: false,
i_IsDisable: false,
i_IsValid: true
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
}, $text(getTranslation("5bHghh+unUueMYJOaQPmVw#Value", "Requisition Status"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("_dT66mKc3kOTyzEEfPHD3w#ValueExpression.65921.1", "All"),
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
visible: model.getCachedValue(idService.getId("33drYuVeZ0GDzoRr2FfpkA.Visible"), function () {
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
}, $text(getTranslation("xsb52UeVdUiu20szfuS+YA#Value", "Approval Status"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("b5doumKWfkm6h+luZfNLPQ#ValueExpression.65921.1", "All"),
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
DateFormat: "DD/MM/YYYY",
ShowTodayButton: true
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
}, $text(getTranslation("vbZeeF3tYk++N5KWno4yCQ#Value", "Creation Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1+XJIzajT0aPadiSVNAQ9g#ValueExpression.65921.1", "All"),
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
visible: model.getCachedValue(idService.getId("5fx7nLwwk0mXYWBqO3LSvA.Visible"), function () {
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
}, $text(getTranslation("2YVVxnAMF0a6HPUg3Xu7_w#Value", "Company"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("d3ePGorkU0WwaD0MqUsc7g#ValueExpression.65921.1", "All"),
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
}, $text(getTranslation("mRlR88Gi70evBNUVivN2NQ#Value", "Project "))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
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
OptionalConfigs: model.getCachedValue(idService.getId("DropdownSearchProject.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.allowMultipleSelectionAttr = false;
rec.isDisabledAttr = false;
rec.noResultsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3tmT5XxuBk6+ueX4Po17pw#Value.-1371290541.1", "No projects to show...");
rec.searchPromptAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("t89E2m49g06uPDQKRafy2w#Value.-512840794.1", "Search...");
rec.noOptionsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Bz48PkdPqUGRsJuGIHEmgg#Value.-1371290541.1", "No projects to show...");
return rec;
}();
}),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Z2EQ8LAVk0KHk_N3a3tYFg#Value.65921.1", "All")
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
}, $text(getTranslation("UjVCqEPkDEam4krb5j1lxw#Value", "From Amount"))), createElement(OSWidgets$Input, {
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
RightAlign: true,
SuffixText: "",
UseNumericInput: true,
GroupSeparator: ",",
PrefixText: "",
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true,
InputId: idService.getId("Input_AmountML3")
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
}, $text(getTranslation("bB5c+MdG1UOiiANebr43SQ#Value", "To Amount"))), createElement(OSWidgets$Input, {
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
RightAlign: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_AmountML2"),
PrefixText: "",
UseNumericInput: true,
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
}, $text(getTranslation("ohN6fjNqx0SXKsZf4SBOFA#Value", "Cost Center"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("I51lBGZ0gkeslZvIbF4a7Q#ValueExpression.65921.1", "All"),
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
ExtendedClass: "margin-left-base",
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
return [$text(getTranslation("Wrk2al6GpU20PFIJyvEBAg#Value", "Create Requisition"))];
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
}, $text(getTranslation("J_ZH36+mhEqAasKHC+aTIg#Value", "Approval Level"))), createElement(OSWidgets$Dropdown, {
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
text: [$text(getTranslation("_LkKFOoZJEGJyuobQD+hlg#Value", "You don\'t have any requisitions yet."))],
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
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
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
}, $text(getTranslation("Ftr08P3HEUSdawrreZ61_w#Value", "New requisition"))))];
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
text: [$text(getTranslation("oTBkBoAiS0Ca2kMH03znPQ#Value", "No results were found with the selected filters."))],
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
}, $text(getTranslation("0FkQPEZkTk+Akga9hjp4AA#Value", "Clear filters"))))];
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
text: [$text(getTranslation("jxbR6Wy8XkSHHnzBMIRRgA#Value", "Table settings"))],
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
sortAttribute: "RequisitionName",
style: "donotshow",
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("GYxo0RUYd0a3it4t82Sl0g#Value", "Name"))), createElement(OSWidgets$HeaderCell, {
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
sortAttribute: "RequisitionStatus",
style: "donotshow",
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("mjAlHMDelUq5EUnG4JCTMw#Value", "Action"))), createElement(OSWidgets$HeaderCell, {
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
sortAttribute: "ApprovalStatus",
style: "donotshow",
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("DpT13jocpEWplQzUes_VXQ#Value", "Requisition Status"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "CreatedOn",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("64tZK319eUuCcnQObwXUwg#Value", "Creation Date"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "UpdatedOn",
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("+ihcFXUg6k+PI5GtWfUw3A#Value", "Last change"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ApplicantName",
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6Tuwy5B_7UifhVZqLpqjfw#Value", "Requester"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProjectDescription",
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("IuTC9t6Iw0mdQI42Ysk1VQ#Value", "Project"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "SupplierName",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("uHfmkSTGJE2afkX_q31s3w#Value", "Supplier"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "RegionCode",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("t8+7Mta80kKLeMMTK_ZfHA#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "TotalAmount",
style: "donotshow",
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("DNXHBNtV7ECboVjdRVfEng#Value", "Amount"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "CurrencyCode",
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("jYAv522aC0a5V_Mdi3haSg#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "CostCenterSAPDenominacion",
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("SlMTZUeN8E6rF8XYlGEIyQ#Value", "Cost Center"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "CompanyDescription",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("PNv_kHjDL0Cye7AE7eGahQ#Value", "Company"))), createElement(OSWidgets$HeaderCell, {
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
}, $text(getTranslation("JOG+bWSahkeECwSBjB9Dkg#Value", "Docs"))), createElement(OSWidgets$HeaderCell, {
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
}, $text(getTranslation("wge5nld2JESIOeTWHZX9TA#Value", "Available Tasks")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionNameAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionIdAttr)]
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
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionIdAttr, {
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
i_Text: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionNameAttr,
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).advWithoutInvoiceAttr)]
}, $if(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).advWithoutInvoiceAttr, false, this, function () {
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
return [$text(getTranslation("OzIklXJpaEuSgAfNafMTqg#Value", "Advance Pay Without Invoice"))];
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
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusClassAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).isAccountingAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).accountingRegionIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).assignedToAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.getCachedValue(idService.getId("RequisitionStatus2.i_Text"), function () {
return (((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) || (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.expired)) || ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.canceled) && (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusIdAttr === OS$BuiltinFunctions.nullIdentifier())))) ? ("") : ((((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).applicantIdAttr === OS$BuiltinFunctions.getUserId()) && ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).assignedToAttr) !== (OS$BuiltinFunctions.getUserId()))) && (!(((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && (!(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr))))))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("h9KuTi4avkKF0papnYIgHw#Value.-1942320933.1", "Submitted")) : ((((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusIdAttr) !== (OS$BuiltinFunctions.nullIdentifier())) && (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut) || model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).accountingRegionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut)))) ? (((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).isAccountingAttr) ? ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr + " CxP")) : ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr + " AU")))) : (""))))));
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).applicantIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).assignedToAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionIdAttr;
}, function () {
return model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).accountingRegionIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).isAccountingAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr, model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr),
i_Class: model.getCachedValue(idService.getId("RequisitionStatus2.i_Class"), function () {
return (((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) || (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.expired)) || ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.canceled) && (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusIdAttr === OS$BuiltinFunctions.nullIdentifier())))) ? ("") : ((((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).applicantIdAttr === OS$BuiltinFunctions.getUserId()) && ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).assignedToAttr) !== (OS$BuiltinFunctions.getUserId()))) && (!(((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && (!(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr))))))) ? ("submitted") : ((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut) || model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).accountingRegionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut))) ? (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusClassAttr) : (""))))));
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).applicantIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).assignedToAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionIdAttr;
}, function () {
return model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).accountingRegionIdAttr;
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusClassAttr;
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).hasContractFileUploadedAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).isContractPendingAttr)]
}, $if(((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).isContractPendingAttr && (!(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).hasContractFileUploadedAttr))) && ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.inApproval) || (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.approved))), false, this, function () {
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
return [$text(getTranslation("TUcREkZBjkaz1gL0VUc7MQ#Value", "with Contract Pending"))];
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr)]
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
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr,
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).createdOnAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("HYbm3iKWqke3trBNRhsUfQ.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).createdOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).createdOnAttr;
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).updatedByAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).updatedOnAttr)]
}, $if(!(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).updatedOnAttr.equals(OS$BuiltinFunctions.nullDate())), false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_SupplierName_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_SupplierNumber: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).updatedByAttr,
_i_SupplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
i_NChar: 20,
i_SupplierName: model.getCachedValue(idService.getId("Bk9ZhsAvC0ex6BlAs9Nd+Q.i_SupplierName"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).updatedOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).updatedOnAttr;
}),
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).applicantNameAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).applicantNameAttr,
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).projectDescriptionAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_Text: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).projectDescriptionAttr,
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).supplierNameAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).supplierNumberAttr)]
}, createElement(Telcel_Theme_Utils_Wb_SupplierName_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_SupplierNumber: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).supplierNumberAttr,
_i_SupplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
i_NChar: 20,
i_SupplierName: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).supplierNameAttr,
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionCodeAttr,
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.getCachedValue(idService.getId("rqaF2ZjCC0mBXHh33GioZQ.i_Text"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr;
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).currencyCodeAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).currencyCodeAttr,
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).costCenterSAPDenominacionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).costCenterSAPDenominacionAttr,
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).companyDescriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).companyDescriptionAttr,
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionNameAttr)]
}, createElement(ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
RequisitionName: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionNameAttr,
_requisitionNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
RequisitionId: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionIdAttr,
_requisitionIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
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
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approveAsAreaUsuariaAttr)]
}, $if(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approveAsAreaUsuariaAttr, false, this, function () {
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
return [$text(getTranslation("cCMYmbS9n0GHuzwQBUpJQw#Value", "Without Contract or Proof Of Foreign Residence"))];
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
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).accountingRegionIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).assignedToAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr)]
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
}, $if(((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) && (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).applicantIdAttr === OS$BuiltinFunctions.getUserId())), false, this, function () {
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
controller.showHideCancelPopup$Action(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionIdAttr, controller.callContext(eventHandlerContext));

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
return [$text(getTranslation("krvrLbWZJ0CXeSKQSsNC8A#Value", "Cancel Requisition"))];
})
},
_dependencies: []
})];
}, function () {
return [];
}), $if((((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && (!(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).dontShowActionAttr))) && ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).assignedToAttr === OS$BuiltinFunctions.getUserId()) || (model.variables.getUserApplicationRolesAndMoreDataAct.isCorporativoCxPOut && (model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut) || model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).accountingRegionIdAttr.equals(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut))))), false, this, function () {
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
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionIdAttr, {
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
return [$text(getTranslation("9xCNeVXiPEuMkSHsa3JG9w#Value", "Request Modification"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionIdAttr)]
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
PopupBtnId: idService.getId("OpenPopupLink"),
ConfigColumnJSON: model.variables.l_ColumnJSONVarGetRequisitionsVar,
TableName: idService.getId("ConectaProveedoresRequisitionsGetRequisitions"),
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
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
TotalCount: OS$BuiltinFunctions.integerToLongInteger(model.variables.getRequisitionsDataAct.totalCountOut),
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
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
_dependencies: [asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetRequisitionsVar), asPrimitiveValue(model.variables.getRequisitionsDataAct.totalCountOut), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut), asPrimitiveValue(model.variables.getRequisitionsDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRolesListOut), asPrimitiveValue(model.variables.l_ApplicationRoleIdForAggregateVar), asPrimitiveValue(model.variables.l_IsAllowSelectApplicationRolesVar), asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isSolicitanteAttr), asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.l_AmountToTextVar), asPrimitiveValue(model.variables.l_AmountFromTextVar), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.listOut), asPrimitiveValue(model.variables.getCompaniesAggr.listOut), asPrimitiveValue(model.variables.l_ShowFiltersVar), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_CostCenterId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_AmountTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_AmountFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProjectId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_CompanyId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_UploadDate()), asPrimitiveValue(model.variables.getApprovalStatusesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId()), asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionStatusesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_SupplierId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_RequisitionSearch())]
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
_dependencies: [asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetRequisitionsVar), asPrimitiveValue(model.variables.getRequisitionsDataAct.totalCountOut), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut), asPrimitiveValue(model.variables.getRequisitionsDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.l_ApplicationRoleIdForAggregateVar), asPrimitiveValue(model.variables.l_IsAllowSelectApplicationRolesVar), asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isSolicitanteAttr), asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.l_AmountToTextVar), asPrimitiveValue(model.variables.l_AmountFromTextVar), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.listOut), asPrimitiveValue(model.variables.getCompaniesAggr.listOut), asPrimitiveValue(model.variables.l_ShowFiltersVar), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_CostCenterId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_AmountTo()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_AmountFrom()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProjectId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_CompanyId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_UploadDate()), asPrimitiveValue(model.variables.getApprovalStatusesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId()), asPrimitiveValue(model.variables.getRequisitionStatusesAggr.listOut), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_SupplierId()), asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_RequisitionSearch()), asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.corporativoRegionIdOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRegionOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.userRolesListOut), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.o_CanUploadInvoicesOut)]
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
i_ConfirmationText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NSfmOnZ8GEijt4lcTw8zDA#Value.-417569474.1", "Are you sure you want to cancel the requisition? This action is irreversible."),
i_PopupTitle: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ykR5rW3wakae44_4YF9j5Q#Value.-602822666.1", "Cancel Requisition")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideCancelPopup$Action(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), controller.callContext(eventHandlerContext));

;
},
confirm$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.cancelRequisition$Action(controller.callContext(eventHandlerContext));
});
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
codeFunction: "Wb_RequisitionsList_Internal",
functionKey: "f01e21a3-2374-44a2-a000-2fa39047ddb0",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Requisitions.Wb_RequisitionsList_Internal",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal.css"];
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
