import { withBaseWebBlock, ifWidget as $if, textWidget as $text, getTranslation, asPrimitiveValue, Widget, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { Form as OSWidgets$Form, Container as OSWidgets$Container, Expression as OSWidgets$Expression, Label as OSWidgets$Label, Text as OSWidgets$Text, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Link as OSWidgets$Link, TextArea as OSWidgets$TextArea, Dropdown as OSWidgets$Dropdown, Input as OSWidgets$Input, Image as OSWidgets$Image, Button as OSWidgets$Button, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingSum_mvc_view from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccountingSum.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import OutSystemsUI_Content_Accordion_mvc_view from "./OutSystemsUI.Content.Accordion.mvc$view.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import { EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord, RC_3e9738e6e6c45aed847983a73298da67 } from "./ConectaProveedores.model.js";
import ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingRetentions_mvc_view from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccountingRetentions.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_mvc_view from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccountingWaybill.mvc$view.js";
import OutSystemsUI_Adaptive_Columns3_mvc_view from "./OutSystemsUI.Adaptive.Columns3.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceAccountingImport.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_PopupApprove_mvc_view from "./ConectaProveedores.y_Utils.Wb_PopupApprove.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceCancel.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceModify_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceModify.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((model.variables.getInvoiceAccountingDataAct.isDataFetchedAttr && (!(model.variables.getInvoiceAccountingDataAct.hasFetchErrorAttr))), false, this, function () {
return [$if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form",
_idProps: {
service: idService,
name: "Form1"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-bottom: 10px; margin-top: 10px;"
},
style: "text-align-center btn-ADV border-radius-rounded margin-top-s margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "sub-heading",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("bCO6xAayoUW49QApSS47Xg#ValueExpression.247225343.1", "Requisition with Contract Pending"),
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card min-height-71vh",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display font-size-main-heading",
text: [$text(getTranslation("c9I1VPQ_gk2w5ucAFFm+tA#Value", "Accounting"))],
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr === OS$BuiltinFunctions.nullTextIdentifier()) && model.variables.isActiveUserIn), false, this, function () {
return [createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "7",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.getInvoiceAccountingDataAct.o_ListOut,
style: "table table-flat",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("SIsaRVOsSECJqjOSrzwJvQ#Value", "Service Type"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("9HEWD4T0YkaSQozMHOut3Q#Value", "Cost Center"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("m_P4tQnImkGq_nR4H52Shg#Value", "Free Text"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ysUp60wZS0SCV8xbkx7oMA#Value", "Division"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("VmJ_bqTNokGaZ1SisoLeyw#Value", "Iva"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("C5AavuEhz0mD1p7w5dwTkA.Value"), function () {
return (((((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr) !== ("E")) || ((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr) !== ("G02")))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("O6HGSYB5P0qU+O3G+0eVNg#ValueExpression.1964981368.1", "Amount")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("O6HGSYB5P0qU+O3G+0eVNg#ValueExpression.-644962060.1", "Total Amount")));
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr;
}),
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("f71O_7HoZUafORqLiv7uow.Value"), function () {
return (((((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr) !== ("E")) || ((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr) !== ("G02")))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NNDqHG8pI0GmxsEHW__+Dw#ValueExpression.-644962060.1", "Total Amount")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NNDqHG8pI0GmxsEHW__+Dw#ValueExpression.1964981368.1", "Amount")));
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr;
}),
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Ml1La2WXoUOL7P4YyweI3g#Value", "Payment Method"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6L_KbYI7LkSbWnJhDEcuHQ#Value", "Payment Terms"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("FsgxLT0WSEWWcVk42kGbNA#Value", "ICME Indicator"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext))]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) + 1)).toString(),
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(1, (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) > 0), model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
style: model.getCachedValue(idService.getId("MmYgiYzmkU6R0ck_qa3YBQ.Style"), function () {
return (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorAccountingAccounts_ServiceTypeAttr))) ? ("") : ("cell-error "));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorAccountingAccounts_ServiceTypeAttr;
}),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
_dependencies: [asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.listOut), asPrimitiveValue(model.variables.getDataDataAct.isAnticipoWithInvOut), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditAccountingAccounts_ServiceTypeAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.supplierNumberAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext))]
}, $if((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.supplierNumberAttr,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [$if((!(model.variables.getDataDataAct.isAnticipoWithInvOut)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditAccountingAccounts_ServiceTypeAttr, false, this, function () {
return [createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WsquVuIqrUKsUw1bhUciAw#Value.-431112254.1", "Accounting account"),
OptionsList: model.getCachedValue(idService.getId("Account.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getAccountingAccountsServiceTypesAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = source.accountingAccounts_ServiceTypeAttr.cCAttr;
target.labelAttr = source.accountingAccounts_ServiceTypeAttr.cCAttr;
target.descriptionAttr = source.accountingAccounts_ServiceTypeAttr.descriptionAttr;
return target;
});
}, function () {
return model.variables.getAccountingAccountsServiceTypesAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr),
ExtendedClass: "max-width-120px",
StartingSelection: model.getCachedValue(idService.getId("Account.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr;
rec.labelAttr = "";
return rec;
}()]);
return list;
}();
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr;
}),
_startingSelectionInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.accountOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
_idProps: {
service: idService,
name: "Account",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(1, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));


;
},
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("daXp9dO+Kk2Sk6nwQPNkWg.Value"), function () {
return ((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("OAuvGLnG9U24f6B3hV4_2Q#ValueExpression.-1356305623.1", "Select account")));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr;
}),
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}))];
}, function () {
return [createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.supplierNumberAttr,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
})];
})), createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(2, (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) > 0), model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
style: model.getCachedValue(idService.getId("CkyryX6sIk24SnulLagJ4A.Style"), function () {
return (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorCostCenterSAPAttr))) ? ("") : ("cell-error "));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorCostCenterSAPAttr;
}),
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
_dependencies: [asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).beneficiaryCenterSAPAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.costCenterIdAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditCostCenterSAPAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditCostCenterSAPAttr, false, this, function () {
return [createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartingSelection: model.getCachedValue(idService.getId("CostCenterSearch.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.costCenterIdAttr);
rec.labelAttr = "";
return rec;
}()]);
return list;
}();
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.costCenterIdAttr;
}),
_startingSelectionInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rIaGSzBv80OLF9r1ntiBMQ#Value.-1520949240.1", "Cost Center"),
ExtendedClass: "max-width-120px",
OptionsList: model.getCachedValue(idService.getId("CostCenterSearch.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getCostCentersAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.costCenterSAPAttr.idAttr);
target.labelAttr = source.costCenterSAPAttr.ce_costeAttr;
target.groupNameAttr = ("CeBe " + source.costCenterSAPAttr.ceBeAttr);
target.descriptionAttr = source.costCenterSAPAttr.denominacionAttr;
return target;
});
}, function () {
return model.variables.getCostCentersAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCostCentersAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_CostCenterSearchOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
_idProps: {
service: idService,
name: "CostCenterSearch",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(2, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));


;
},
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("Rm+721cDYk+dJOojIisNWg.Value"), function () {
return ((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("JGv1KT8v20OQA+XvAGCEeA#ValueExpression.105748228.1", "Select cost center")));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr;
}),
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})), $if(((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).beneficiaryCenterSAPAttr) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).beneficiaryCenterSAPAttr,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [];
}))];
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(3, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
style: "max-width-200px",
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditFreeTextAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorFreeTextAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("KD+ztdTH2UK56etnRbX8Jg.Style"), function () {
return ("custom-textarea " + (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorFreeTextAttr))) ? ("") : ("cell-error ")));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorFreeTextAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditFreeTextAttr, false, this, function () {
return [$if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
enabled: true,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(3, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ANu39XZMy0Gil11WqvcLkg#ValueExpression.1511380577.1", "Free Text"),
style: "no-margin height-40",
textLines: 1,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr = value;
}),
_idProps: {
service: idService,
name: "TextArea_FreeText2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
enabled: true,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(3, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("BJ_4_lDA602rWZRQs0ugGQ#ValueExpression.1511380577.1", "Free Text"),
style: "no-margin height-40",
textLines: 1,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr = value;
}),
_idProps: {
service: idService,
name: "TextArea_FreeText"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(3, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));


;
},
style: "max-width-200px",
visible: true,
_idProps: {
service: idService,
uuid: "47"
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
i_NChar: 60,
ExtendedClass: "padding-12",
i_Text: model.getCachedValue(idService.getId("Baa8N_3rak2nFc6ripbZiw.i_Text"), function () {
return (((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0)) ? (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr) : (" - "))) : (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr) : (" - "))));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr;
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "48",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}))), createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(4, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
style: model.getCachedValue(idService.getId("EciL8pKjfESxykAObNWKjw.Style"), function () {
return (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorDivisionAttr))) ? ("") : ("cell-error "));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorDivisionAttr;
}),
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
_dependencies: [asPrimitiveValue(model.variables.isCorpIn), asPrimitiveValue(model.variables.getRegionsAggr.listOut), asPrimitiveValue(model.variables._isCorpInDataFetchStatus), asPrimitiveValue(model.variables.getRegionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditDivisionAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditDivisionAttr, false, this, function () {
return [$if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8lIehNXX2U6Bxaoba01nZw#ValueExpression.429364429.1", "Division"),
enabled: true,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(4, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
labels: function (elem) {
return elem.regionAttr.divisionFIAttr;
},
list: model.variables.getRegionsAggr.listOut,
mandatory: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_DivisonOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "dropdown no-margin",
values: function (elem) {
return elem.regionAttr.divisionFIAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Divison2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRegionsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("f2UV4jt1j0ad0eveQ2yi7A#ValueExpression.429364429.1", "Division"),
enabled: true,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(4, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
labels: function (elem) {
return elem.regionAttr.divisionFIAttr;
},
list: model.variables.getRegionsAggr.listOut,
mandatory: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_DivisonOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "dropdown no-margin",
values: function (elem) {
return elem.regionAttr.divisionFIAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Divison3"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRegionsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})];
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: model.variables.isCorpIn,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(4, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));


;
},
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._isCorpInDataFetchStatus)
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("R10fUjg6lke0yhPGGpSrkg.Value"), function () {
return (((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0)) ? (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr) : (" - "))) : (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr) : (" - "))));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr;
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr;
}),
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}))), createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(5, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
style: "max-width-100px ",
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getTaxIndicatorsAggr.listOut), asPrimitiveValue(model.variables.getTaxIndicatorsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iVAIndicatorIdAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.ivaIndicatorIdAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditIVAAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditIVAAttr, false, this, function () {
return [$if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("9pVsriofoU2CgsEENVDgqw#ValueExpression.72884.1", "IVA"),
enabled: true,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(5, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
labels: function (elem) {
return elem.taxIndicatorAttr.externalIdAttr;
},
list: model.variables.getTaxIndicatorsAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdown_IvaOnChange$Action(true, controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown no-margin",
values: function (elem) {
return elem.taxIndicatorAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.ivaIndicatorIdAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.ivaIndicatorIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Iva"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getTaxIndicatorsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VooNUCIqyUS5emh+M+PUbg#ValueExpression.72884.1", "IVA"),
enabled: true,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(5, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
labels: function (elem) {
return elem.taxIndicatorAttr.externalIdAttr;
},
list: model.variables.getTaxIndicatorsAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdown_IvaOnChange$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown no-margin",
values: function (elem) {
return elem.taxIndicatorAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iVAIndicatorIdAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iVAIndicatorIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Iva2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getTaxIndicatorsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})];
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(5, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));


;
},
visible: true,
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("WM+HXJ8hC0qq2fjJrHjPlg.Value"), function () {
return ((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr) : ("N/A"));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr;
}),
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}))), createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(6, (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) > 0), model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
style: model.getCachedValue(idService.getId("u5L1nh7qaEie4351GqGxYg.Style"), function () {
return ("max-width-100px " + (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorAmountAttr))) ? ("") : ("cell-error ")));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorAmountAttr;
}),
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditAmountAttr, false, this, function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
enabled: (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr || model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr),
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(6, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr || model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr),
maxLength: 0,
prompt: " ",
style: "form-control no-margin",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Amount"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
PrefixText: "",
GroupSeparator: ",",
InputId: idService.getId("Input_Amount"),
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
RightAlign: true,
DecimalSeparator: ".",
SuffixText: ""
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "64",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(6, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));


;
},
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("3iA55al5qUyFfGc2PvlDRQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr;
}),
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center text-neutral-6",
visible: true,
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingSum_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ListOfValues: model.getCachedValue(idService.getId("UxLs5UCgbkm4ERRJYtDbOg.ListOfValues"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getInvoiceAccountingDataAct.o_ListOut, new OS$DataTypes.DecimalList(), function (source, target) {
target = source.invoiceAccountingServicesAttr.amountAttr;
return target;
});
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut;
}),
_listOfValuesInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "68",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})), createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(7, (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0), model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
style: model.getCachedValue(idService.getId("diuwW2HfPki5Xg1v_ORusQ.Style"), function () {
return ("max-width-100px " + (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorTotalAmountAttr))) ? ("") : ("cell-error ")));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorTotalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditTotalAmountAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditTotalAmountAttr, false, this, function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
enabled: false,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(7, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 37,
prompt: " ",
style: "form-control no-margin",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ServiceTotalAmount"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalSeparator: ".",
UseNumericInput: true,
RightAlign: true,
AlwaysShowDecimalDigits: true,
PrefixText: "",
SuffixText: "",
GroupSeparator: ",",
InputId: idService.getId("Input_ServiceTotalAmount"),
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "72",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(7, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));


;
},
visible: true,
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("esSrEBGg4E2tgzV23sCJlw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(8, (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0), model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getPaymentMethodsAggr.listOut), asPrimitiveValue(model.variables.getPaymentMethodsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.paymentMethodIdAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentMethodAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentMethodAttr, false, this, function () {
return [createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("82xQz1b7SUGT+XtH8+_7YQ#ValueExpression.722673599.1", "Select payment method"),
enabled: true,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(8, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
labels: function (elem) {
return elem.paymentMethodsAttr.descriptionAttr;
},
list: model.variables.getPaymentMethodsAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdown_PaymentMethodIdOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown no-margin",
values: function (elem) {
return elem.paymentMethodsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.paymentMethodIdAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.paymentMethodIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentMethodId"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentMethodsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(8, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));


;
},
visible: true,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("VMEi001Ny0OdvUNyQURqrg.Value"), function () {
return ((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr) : (" - "));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr;
}),
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(9, (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0), model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.paymentTermsIdAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentTermAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentTermAttr, false, this, function () {
return [createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qtsFTxNjt0mFSoWp7O+9fg#ValueExpression.1491920553.1", "Select Payment Terms"),
enabled: true,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(9, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
labels: function (elem) {
return elem.paymentTermsAttr.descriptionAttr;
},
list: model.variables.getPaymentTermsAggr.listOut,
mandatory: true,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdown_PaymentTermsIdOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown no-margin",
values: function (elem) {
return elem.paymentTermsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.paymentTermsIdAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.paymentTermsIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentTermsId"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentTermsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(9, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));


;
},
visible: true,
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("wgwE4zMB0UKQZHrWtSXhNw.Value"), function () {
return ((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr) : (" - "));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr;
}),
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(10, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iCMEAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.iCMEIndicatorAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditICMEAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditICMEAttr, false, this, function () {
return [$if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
enabled: true,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(10, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("JwD4rGjCs0GLjvLiuwcNJQ#ValueExpression.2241586.1", "ICME"),
style: "form-control no-margin",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.iCMEIndicatorAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.iCMEIndicatorAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ICME"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
enabled: true,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(10, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 1,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kHbsu3uAvkmiYhKS3WVhoA#ValueExpression.2241586.1", "ICME"),
style: "form-control no-margin",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iCMEAttr, function (value) {
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iCMEAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ICME2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(10, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));


;
},
visible: true,
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("+vAngoxoikq1Cs3KuMBdfQ.Value"), function () {
return (((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0)) ? (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.iCMEIndicatorAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.iCMEIndicatorAttr) : ("-"))) : (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iCMEAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iCMEAttr) : ("-"))));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.iCMEIndicatorAttr;
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iCMEAttr;
}),
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.length), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)]
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
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "92",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr, false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickRecordAdd$Action(controller.callContext(eventHandlerContext));

;
},
style: "img-m display-flex align-items-center",
visible: true,
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}), $if((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr && (model.variables.getInvoiceAccountingDataAct.o_ListOut.length > 2)), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickRecordRemove$Action(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
},
style: "img-m display-flex align-items-center",
visible: true,
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.length), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)]
}))];
}, callContext, idService, "7_0")
},
_dependencies: [asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getPaymentMethodsAggr.listOut), asPrimitiveValue(model.variables.getTaxIndicatorsAggr.listOut), asPrimitiveValue(model.variables.isCorpIn), asPrimitiveValue(model.variables.getRegionsAggr.listOut), asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.listOut), asPrimitiveValue(model.variables.getDataDataAct.isAnticipoWithInvOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentMethodsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getTaxIndicatorsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables._isCorpInDataFetchStatus), asPrimitiveValue(model.variables.getRegionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getPaymentMethodsAggr.listOut), asPrimitiveValue(model.variables.getTaxIndicatorsAggr.listOut), asPrimitiveValue(model.variables.isCorpIn), asPrimitiveValue(model.variables.getRegionsAggr.listOut), asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.listOut), asPrimitiveValue(model.variables.getDataDataAct.isAnticipoWithInvOut), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentMethodsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getTaxIndicatorsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables._isCorpInDataFetchStatus), asPrimitiveValue(model.variables.getRegionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut)]
})];
}, function () {
return [createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.getInvoiceAccountingDataAct.o_ListOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("x8ihxeKyO0O8Bzf3tXHvyA#Value", "Service Type"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("YI3S4AA5fEKvx9rMsmicLw#Value", "Cost Center"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("LhfB0b9DvUu+Tqlb0a4gFQ#Value", "Free Text"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("0+FeC28b80uypext46tdHA#Value", "Division"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("xdUVIJRbmkSQGhEm1OSKqg#Value", "Iva"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("gCy8Rsx6qkqWuSlGsDHrPg#Value", "Amount"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("0wCARqwUs0WJvWZBoAn8+Q#Value", "Total Amount"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("LfCLSUkv9EK_Sb_gjOGZyQ#Value", "Payment Method"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("qOwo3jpxDkeo9JWknRRM+A#Value", "Payment Terms"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("9nPBtSyaukKU3ZD2ofJI8A#Value", "ICME Indicator")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext))]
}, createElement(OSWidgets$Expression, {
value: ((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) + 1)).toString(),
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.isAnticipoWithInvOut), asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.supplierNumberAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext))]
}, $if((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.supplierNumberAttr,
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [$if((!(model.variables.getDataDataAct.isAnticipoWithInvOut)), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr,
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.supplierNumberAttr,
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).beneficiaryCenterSAPAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr,
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).beneficiaryCenterSAPAttr,
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext))]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.getCachedValue(idService.getId("BUoghW19bEetCqsEJqXM2A.i_Text"), function () {
return (((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0)) ? (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr) : (" - "))) : (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr) : (" - "))));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr;
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
ExtendedClass: "padding-12",
i_NChar: 60
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "121",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext))]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("ijkWp6zfREuYyigd7gKcPA.Value"), function () {
return (((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0)) ? (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr) : (" - "))) : (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr) : (" - "))));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr;
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr;
}),
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr,
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("_CbMkdpE+kWxY1nOsex6Dw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr;
}),
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("qERwz1decUaR19veoNRXUg.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr,
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr,
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iCMEAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.iCMEIndicatorAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.iCMEIndicatorAttr,
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iCMEAttr,
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}))];
}, callContext, idService, "8_0")
},
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.isAnticipoWithInvOut), asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)]
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display  font-size-main-heading",
text: [$text(getTranslation("o2UEjnDXDUmxI+1DbeYgZQ#Value", "Addendum"))],
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut,
style: "table table-flat",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("x2gJq1K1_kmgG8JQbfRJnQ#Value", "Concept Name"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("b2H8zOQ5C0+0Ltu8HqLJcA#Value", "Iva"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Ivtqddkz7UOgWadq6j4+zw#Value", "Amount")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.nombreConceptoAttr), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables._isActiveUserInDataFetchStatus), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.isActiveUserIn), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr)]
}, $if(((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr === OS$BuiltinFunctions.nullTextIdentifier()) && model.variables.isActiveUserIn), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XZ5lYzJjH0idlkq0IkcIgg#ValueExpression.-921175677.1", "Concept Name"),
style: "form-control no-margin",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.nombreConceptoAttr, function (value) {
model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.nombreConceptoAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ConceptName"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.nombreConceptoAttr,
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_IvaVar), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr)]
}, $if((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr === OS$BuiltinFunctions.nullTextIdentifier()), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0",
style: "form-control no-margin",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_IvaVar, function (value) {
model.variables.l_IvaVar = value;
}),
_idProps: {
service: idService,
name: "Input_Iva2"
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
InputId: idService.getId("Input_Iva2"),
GroupSeparator: ",",
RightAlign: true,
UseNumericInput: true,
PrefixText: "",
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "152",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Expression, {
style: "padding-12",
value: OS$BuiltinFunctions.decimalToText(model.variables.l_IvaVar),
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.valueAttr), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr)]
}, $if((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr === OS$BuiltinFunctions.nullTextIdentifier()), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
prompt: " ",
style: "form-control no-margin",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.valueAttr, function (value) {
model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.valueAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ConceptOutput"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalSeparator: ".",
GroupSeparator: ",",
SuffixText: "",
RightAlign: true,
PrefixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_ConceptOutput"),
UseNumericInput: true,
AlwaysShowDecimalDigits: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "157",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Expression, {
style: "padding-12",
value: OS$BuiltinFunctions.decimalToText(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.valueAttr),
_idProps: {
service: idService,
uuid: "158"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)
})];
}))];
}, callContext, idService, "9_0")
},
_dependencies: [asPrimitiveValue(model.variables.l_IvaVar), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables._isActiveUserInDataFetchStatus), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.isActiveUserIn), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr)]
}))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Accordion_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MultipleItems: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "160",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "161",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingRetentions_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InvoiceExtendedTaxList: model.getCachedValue(idService.getId("WAstSqn2uE+hE66Q6H+YCg.InvoiceExtendedTaxList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getInvoiceRetentionsByInvoiceIdAggr.listOut, new (OS$GenericTypeCache.getGenericList(EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord))(), function (source, target) {
target = source.invoiceExtendedTaxAttr;
return target;
});
}, function () {
return model.variables.getInvoiceRetentionsByInvoiceIdAggr.listOut;
}),
_invoiceExtendedTaxListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceRetentionsByInvoiceIdAggr.dataFetchStatusAttr),
i_ExtendedClass: "margin-bottom-base"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "162",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_InvoiceId: model.variables.i_InvoiceIdIn,
_i_InvoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_InvoiceIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "163",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_InvoiceIdIn), asPrimitiveValue(model.variables._i_InvoiceIdInDataFetchStatus), asPrimitiveValue(model.variables.getInvoiceRetentionsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceRetentionsByInvoiceIdAggr.listOut)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_InvoiceIdIn), asPrimitiveValue(model.variables._i_InvoiceIdInDataFetchStatus), asPrimitiveValue(model.variables.getInvoiceRetentionsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceRetentionsByInvoiceIdAggr.listOut)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "165",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: Widget.PlaceholderContent.Empty,
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-flex-end",
visible: true,
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "167"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_SubTotal",
_idProps: {
service: idService,
uuid: "168"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("petW0idMHUqXMEUC4GQIig#Value", "SubTotal"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: false,
extendedProperties: {
style: "margin-bottom: 0;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
prompt: " ",
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.subtotalAttr, function (value) {
model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.subtotalAttr = value;
}),
_idProps: {
service: idService,
name: "Input_SubTotal"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PrefixText: "",
AlwaysShowDecimalDigits: true,
DecimalSeparator: ".",
UseNumericInput: true,
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: true,
SuffixText: "",
InputId: idService.getId("Input_SubTotal")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "170",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), $if(!(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.retencionesAttr.equals(OS$BuiltinFunctions.integerToDecimal(0))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-left-base",
visible: true,
_idProps: {
service: idService,
uuid: "171"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Retencions",
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("LfM4BF2Z0kOXFboZEtKOxQ#Value", "Retention"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: false,
extendedProperties: {
style: "margin-bottom: 0;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
prompt: " ",
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.retencionesAttr, function (value) {
model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.retencionesAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Retencions"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PrefixText: "",
UseNumericInput: true,
DecimalSeparator: ".",
SuffixText: "",
AlwaysShowDecimalDigits: true,
GroupSeparator: ",",
InputId: idService.getId("Input_Retencions"),
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "174",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-left-base",
visible: true,
_idProps: {
service: idService,
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount",
_idProps: {
service: idService,
uuid: "176"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("pujl4nf0QkGoQSWj6njiVg#Value", "Total Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: false,
extendedProperties: {
style: "margin-bottom: 0;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
prompt: " ",
style: "form-control bold",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getInvoiceAccountingsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr, function (value) {
model.variables.getInvoiceAccountingsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingsByInvoiceIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GroupSeparator: ",",
UseNumericInput: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: true,
AlwaysShowDecimalDigits: true,
SuffixText: "",
InputId: idService.getId("Input_TotalAmount"),
PrefixText: "",
DecimalSeparator: "."
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "178",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr), asPrimitiveValue(model.variables.getInvoiceAccountingsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.retencionesAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.subtotalAttr)]
})), $if(model.variables.isActiveUserIn, false, this, function () {
return [$if((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr === OS$BuiltinFunctions.nullTextIdentifier()), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "180",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: Widget.PlaceholderContent.Empty,
column2: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "181",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopupImport$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-primary ",
visible: true,
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nHGrJmbIlUylhCf9fkp49Q#Value", "Import")))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_Width12"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClickSave$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-edit",
visible: true,
_idProps: {
service: idService,
uuid: "183"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height: 20px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_EditBlue.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("cjMB00o0ZUqheozrpCk5kw#Value", "Save"))],
_idProps: {
service: idService,
uuid: "185"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_Width12"
},
isDefault: false,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClickSendAccounting$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-approve",
visible: true,
_idProps: {
service: idService,
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.ApproveIcon.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "187"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("kfo2ljeg4E2fpB+Zfi4qoA#Value", "Approve"))],
_idProps: {
service: idService,
uuid: "188"
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
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "189"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "190",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: Widget.PlaceholderContent.Empty,
column2: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "191",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.togglePopupApproval$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-cancel width-100pc",
visible: model.variables.isActiveUserIn,
_idProps: {
service: idService,
uuid: "192"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._isActiveUserInDataFetchStatus)
}, $text(getTranslation("4gudz2fUjE+AJ_t_6BcFnw#Value", "Cancel")))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_Width12"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openModifyPopUp$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-edit",
visible: model.getCachedValue(idService.getId("3Z0862hBz0CKsnfkvLxWUg.Visible"), function () {
return (((model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.inApproval_CxP) && ((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()))) && model.variables.isActiveUserIn);
}, function () {
return model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr;
}, function () {
return model.variables.isActiveUserIn;
}),
_idProps: {
service: idService,
uuid: "193"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalAggr.dataFetchStatusAttr, model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr, model.variables._isActiveUserInDataFetchStatus)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height: 20px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_EditBlue.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "194"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("Wka9taybgUSxnt5gwyGOPA#Value", "Modify"))],
_idProps: {
service: idService,
uuid: "195"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_Width12"
},
isDefault: false,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.togglePopupApproval$Action(true, controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-approve",
visible: true,
_idProps: {
service: idService,
uuid: "196"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.ApproveIcon.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "197"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if((!(model.variables.getDataDataAct.isLastLevelOut)), false, this, function () {
return [createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("pl9yB6JATUKCo9ubKF9+Pw#Value", "Approve"))],
_idProps: {
service: idService,
uuid: "198"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("hUcJ3H9JEkehr3BQTq1Wug#Value", "Send to accounting"))],
_idProps: {
service: idService,
uuid: "199"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.isLastLevelOut), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr), asPrimitiveValue(model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr), asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceApprovalAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables._isActiveUserInDataFetchStatus), asPrimitiveValue(model.variables.isActiveUserIn)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.isLastLevelOut), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr), asPrimitiveValue(model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr), asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceApprovalAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables._isActiveUserInDataFetchStatus), asPrimitiveValue(model.variables.isActiveUserIn)]
}))];
})];
}, function () {
return [];
}), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowImportPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "ImportPopup"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_InvoiceAccountingId: model.variables.getInvoiceAccountingDataAct.o_InvoiceAccountingIdOut,
_i_InvoiceAccountingIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
TotalAmount: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.subtotalAttr.plus(model.variables.getInvoiceExtendedTaxsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).importeSumAttr),
_totalAmountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr, model.variables.getInvoiceExtendedTaxsByInvoiceIdAggr.dataFetchStatusAttr),
SupplierNumber: model.variables.supplierNumberIn,
_supplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._supplierNumberInDataFetchStatus),
i_InvoiceId: model.variables.i_InvoiceIdIn,
_i_InvoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_InvoiceIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopupImport$Action(controller.callContext(eventHandlerContext));

;
},
import$Action: function (i_InvoiceAccountingIn, i_InvoiceAccountingServicesIn, i_InvoiceAccountingEntryIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onImportData$Action(i_InvoiceAccountingIn, OS$DataConversion.JSConversions.typeConvertRecordList(i_InvoiceAccountingServicesIn, new (OS$GenericTypeCache.getGenericList(RC_3e9738e6e6c45aed847983a73298da67))(), function (source, target) {
target.accountingAccounts_ServiceTypeAttr = source.accountingAccounts_ServiceTypeAttr.descriptionAttr;
target.costCenterSAPAttr = source.costCenterSAPAttr.ce_costeAttr;
target.indicatorIVAAttr = source.taxIndicatorAttr.externalIdAttr;
target.invoiceAccountingServicesAttr = source.invoiceAccountingServicesAttr;
return target;
}), i_InvoiceAccountingEntryIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "201",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowApprovalInvoiceVar,
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
i_Title: model.getCachedValue(idService.getId("0iwYPxUizEmJRiqFe481Nw.i_Title"), function () {
return ((model.variables.l_IsApprovalVar) ? (((model.variables.getDataDataAct.isLastLevelOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WjHRJVLqb0aiGk_feOQeFA#Value.-1612981715.1", "Send Accounting")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WjHRJVLqb0aiGk_feOQeFA#Value.1715465750.1", "Invoice Approval")))) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WjHRJVLqb0aiGk_feOQeFA#Value.-1102331993.1", "Cancel invoice")));
}, function () {
return model.variables.l_IsApprovalVar;
}, function () {
return model.variables.getDataDataAct.isLastLevelOut;
}),
_i_TitleInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDataDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isOkIn, commentIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClosePopupApproval$Action(isOkIn, commentIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "203",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowCancelInvoiceVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "Cancel"
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
i_InvoiceId: model.variables.i_InvoiceIdIn,
_i_InvoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_InvoiceIdInDataFetchStatus),
i_InvoiceApprovalLevelId: model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.idAttr,
_i_InvoiceApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopupCancel$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "205",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowModifyPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "Modify"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceModify_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InvoiceId: model.variables.i_InvoiceIdIn,
_invoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_InvoiceIdInDataFetchStatus),
i_InvoiceApprovalLevelId: model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.idAttr,
_i_InvoiceApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_PopupInvoiceModifyClose$Action(isRefreshIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "207",
alias: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center card",
visible: true,
_idProps: {
service: idService,
uuid: "208"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("NLaCW2qYx0OCdlGKHcPOQg#Value", "No records were found in this invoice."))],
_idProps: {
service: idService,
uuid: "209"
},
_widgetRecordProvider: widgetsRecordProvider
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
uuid: "210"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_i_InvoiceAccounting_Old",
functionKey: "04ece77a-0a86-48f7-a071-a1ae1ef94378",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_i_InvoiceAccounting_Old",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Interaction_DropdownSearch_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingSum_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Content_Accordion_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingRetentions_mvc_view, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_mvc_view, OutSystemsUI_Adaptive_Columns3_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_mvc_view, ConectaProveedores_y_Utils_Wb_PopupApprove_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceModify_mvc_view];
};


return ELEM;
};

export default componentFactory()
