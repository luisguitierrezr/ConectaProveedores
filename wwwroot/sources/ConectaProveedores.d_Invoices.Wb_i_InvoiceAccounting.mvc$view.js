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
import { EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord, RC_3b34889e0cefe5468fc5f63480ce4e0f } from "./ConectaProveedores.model.js";
import ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingRetentions_mvc_view from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccountingRetentions.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_mvc_view from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccountingWaybill.mvc$view.js";
import OutSystemsUI_Adaptive_Columns3_mvc_view from "./OutSystemsUI.Adaptive.Columns3.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceAccountingImport.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_PopupApprove_mvc_view from "./ConectaProveedores.y_Utils.Wb_PopupApprove.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceCancel.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceModify_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceModify.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting.mvc$controller.js";

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
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IuZzlw3RhUG0O83lfavfTQ#ValueExpression.247225343.1", "Requisition with Contract Pending"),
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
text: [$text(getTranslation("EJlnrN4uQE+_AlBUrSeQmw#Value", "Accounting"))],
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
}, $text(getTranslation("mzxWl385WUSbB3KktzJ87Q#Value", "Service Type"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("AvHzSta5_Euh6CB7YGmmbw#Value", "Cost Center"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("3+BtunxqjUKMbZ8i0VpoFQ#Value", "Benefit Center"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("2VYLisaT9kyX9EuE4QOlVw#Value", "Free Text"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("BhyvEDDZAUSZ1UNVM02J5w#Value", "Division"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("tjdw7yr+3UeiL9uL0AFdIQ#Value", "Iva"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Y+TUnfQCakuK7kc1kZudhA.Value"), function () {
return (((((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr) !== ("E")) || ((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr) !== ("G02")))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ga4sG3lu_Eu0H8IotE33uQ#ValueExpression.1964981368.1", "Amount")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ga4sG3lu_Eu0H8IotE33uQ#ValueExpression.-644962060.1", "Total Amount")));
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr;
}),
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("LNN_bXeBEUaeFJjM2ac9qA.Value"), function () {
return (((((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr) !== ("E")) || ((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr) !== ("G02")))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XQ5pfeznBkG+DkV_etvc8A#ValueExpression.-644962060.1", "Total Amount")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XQ5pfeznBkG+DkV_etvc8A#ValueExpression.1964981368.1", "Amount")));
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr;
}),
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("YLK99kKjxku66nTTQwnGvQ#Value", "Payment Method"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("azo8_nVzpEer57l3hAcjiw#Value", "Payment Terms"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("gKSIiqorKke5d6ZiExHXyw#Value", "ICME Indicator"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(0, false, 0, controller.callContext(eventHandlerContext));

;
}
},
_idProps: {
service: idService,
uuid: "25"
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
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) + 1)).toString(),
_idProps: {
service: idService,
uuid: "27"
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
style: model.getCachedValue(idService.getId("ZpLXzJ1iS0WB+_sRE3W9Uw.Style"), function () {
return (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorAccountingAccounts_ServiceTypeAttr))) ? ("") : ("cell-error "));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorAccountingAccounts_ServiceTypeAttr;
}),
_idProps: {
service: idService,
uuid: "28"
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
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.supplierNumberAttr,
_idProps: {
service: idService,
uuid: "30"
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
uuid: "31"
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
ExtendedClass: "max-width-120px",
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
_startingSelectionInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("iZmmwCgUoUmyyekwF_7h9Q#Value.-431112254.1", "Accounting account")
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
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("EFQIyDiyikeuijSO+wPYFw.Value"), function () {
return ((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hVQAejcTakOnNi0iPWD51Q#ValueExpression.-1356305623.1", "Select account")));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr;
}),
_idProps: {
service: idService,
uuid: "34"
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
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
})];
})), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("YZQvvkyuUUSfNqXFiuBUEQ.Style"), function () {
return (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorCostCenterSAPAttr))) ? ("") : ("cell-error "));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorCostCenterSAPAttr;
}),
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
_dependencies: [asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.ceBeCostCenterIdAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.costCenterIdAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditCostCenterSAPAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "37"
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
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("FaFpf2f8mESJBYbZhJmezg#Value.-1520949240.1", "Cost Center"),
OptionsList: model.getCachedValue(idService.getId("CostCenterSearch.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getCostCentersAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.costCenterSAPAttr.idAttr);
target.labelAttr = source.costCenterSAPAttr.ce_costeAttr;
target.descriptionAttr = source.costCenterSAPAttr.denominacionAttr;
return target;
});
}, function () {
return model.variables.getCostCentersAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCostCentersAggr.dataFetchStatusAttr),
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
ExtendedClass: "max-width-120px"
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
return [$if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.ceBeCostCenterIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
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
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("o9F9JGNhL02wXAe8R2sn1w.Value"), function () {
return ((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.costCenterIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("h5woJrKRX02_cFzLp5MIlg#ValueExpression.105748228.1", "Select cost center")));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.costCenterIdAttr;
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr;
}),
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})))];
}, function () {
return [];
})];
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("8flWf33p5E6Gjfn8K1rt6g.Style"), function () {
return (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorBenefitCenterSAPAttr))) ? ("") : ("cell-error "));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorBenefitCenterSAPAttr;
}),
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
_dependencies: [asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).beneficiaryCenterSAPAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.costCenterIdAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.ceBeCostCenterIdAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditBenefitCenterSAPAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditBenefitCenterSAPAttr, false, this, function () {
return [createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionsList: model.getCachedValue(idService.getId("CostCenterSearch2.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getCostCentersAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.costCenterSAPAttr.idAttr);
target.labelAttr = source.costCenterSAPAttr.ceBeAttr;
target.descriptionAttr = source.costCenterSAPAttr.denominacionAttr;
return target;
});
}, function () {
return model.variables.getCostCentersAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCostCentersAggr.dataFetchStatusAttr),
ExtendedClass: "max-width-120px",
StartingSelection: model.getCachedValue(idService.getId("CostCenterSearch2.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.ceBeCostCenterIdAttr);
rec.labelAttr = "";
return rec;
}()]);
return list;
}();
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.ceBeCostCenterIdAttr;
}),
_startingSelectionInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("HSPjmWvgD0a5yN8g+rdHCg#Value.-1381289922.1", "Benefit Center")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_BenefitCenterSearchOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
_idProps: {
service: idService,
name: "CostCenterSearch2",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [$if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.costCenterIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
_this.validateWidget(idService.getId("Form1"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(13, true, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));


;
},
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("mvAZuw0MX0OB1LGD5eRJZw.Value"), function () {
return ((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.ceBeCostCenterIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).beneficiaryCenterSAPAttr) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("mxrx12ds4UOOkkhdtFl3Aw#ValueExpression.448953282.1", "Select Benefit Center")));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.ceBeCostCenterIdAttr;
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).beneficiaryCenterSAPAttr;
}),
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})))];
}, function () {
return [];
})];
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
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditFreeTextAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorFreeTextAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("XBiwb629a0ejJ4LW7tj3Gw.Style"), function () {
return ("custom-textarea " + (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorFreeTextAttr))) ? ("") : ("cell-error ")));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorFreeTextAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "49"
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
mandatory: false,
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("fmz28j3TMUGICjRwhhF2mA#ValueExpression.1511380577.1", "Free Text"),
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
mandatory: false,
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("x0wl1MnQDUyntM7e9Hg4Kg#ValueExpression.1511380577.1", "Free Text"),
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
uuid: "52"
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
i_Text: model.getCachedValue(idService.getId("3nEYGOlhHU6Au5TQ0Tr5ww.i_Text"), function () {
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
uuid: "53",
alias: "5"
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
style: model.getCachedValue(idService.getId("2q7SK7VSPUC4LDdTpVuPZg.Style"), function () {
return (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorDivisionAttr))) ? ("") : ("cell-error "));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorDivisionAttr;
}),
_idProps: {
service: idService,
uuid: "54"
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
uuid: "55"
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
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("EZiIVlFy0ki3xlJMHOZF1A#ValueExpression.429364429.1", "Division"),
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
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Zc4_JPR9Pk2SqFAnksb2LA#ValueExpression.429364429.1", "Division"),
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
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._isCorpInDataFetchStatus)
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("K++cEnfsRk+mlB4pSjR_eQ.Value"), function () {
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
uuid: "59"
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
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getTaxIndicatorsAggr.listOut), asPrimitiveValue(model.variables.getTaxIndicatorsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iVAIndicatorIdAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.ivaIndicatorIdAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditIVAAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "61"
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
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gCNuakZ_wUiLYoY3LVXhXQ#ValueExpression.72884.1", "IVA"),
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
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("w8HKcBSZmkWWazrQ8g+Y7Q#ValueExpression.72884.1", "IVA"),
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
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("byZBJ+ydIUm5qb3f_RnFWg.Value"), function () {
return ((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr) : ("N/A"));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr;
}),
_idProps: {
service: idService,
uuid: "65"
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
style: model.getCachedValue(idService.getId("nYSPN_t4FECbat+qQvMMBg.Style"), function () {
return ("max-width-100px " + (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorAmountAttr))) ? ("") : ("cell-error ")));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorAmountAttr;
}),
_idProps: {
service: idService,
uuid: "66"
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
uuid: "67"
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
InputId: idService.getId("Input_Amount"),
SuffixText: "",
RightAlign: true,
PrefixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
GroupSeparator: ",",
AlwaysShowDecimalDigits: true,
DecimalSeparator: ".",
UseNumericInput: true
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
uuid: "69",
alias: "6"
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
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("bL+SP3Z9DUG_xZk+8UPaCQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr;
}),
_idProps: {
service: idService,
uuid: "71"
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
uuid: "72"
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
ListOfValues: model.getCachedValue(idService.getId("Q28HJeZZEUaGi6zjBDFZfg.ListOfValues"), function () {
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
uuid: "73",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})), createElement(OSWidgets$RowCell, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickEditField$Action(7, false, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
}
},
style: model.getCachedValue(idService.getId("4KIojSmHHUubJMPJ8TeTcg.Style"), function () {
return ("max-width-100px " + (((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorTotalAmountAttr))) ? ("") : ("cell-error ")));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorTotalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "74"
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
uuid: "75"
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
RightAlign: true,
DecimalSeparator: ".",
SuffixText: "",
InputId: idService.getId("Input_ServiceTotalAmount"),
PrefixText: "",
AlwaysShowDecimalDigits: true,
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true
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
uuid: "77",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("6pbk5MDRFUGwnHZX6IxMxA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
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
uuid: "79"
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
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentMethodAttr, false, this, function () {
return [createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("r2PvG1hxX0yWs9sUCTSqxw#ValueExpression.722673599.1", "Select payment method"),
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
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("knbT61PfuUqCePdmZ3tlXQ.Value"), function () {
return ((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr) : (" - "));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr;
}),
_idProps: {
service: idService,
uuid: "83"
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
uuid: "84"
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
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentTermAttr, false, this, function () {
return [createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form1")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("R66h4nzasky68ro7r_IAMQ#ValueExpression.1491920553.1", "Select Payment Terms"),
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
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("Zi4YV4aK4U6siEFCd4gdEQ.Value"), function () {
return ((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr) : (" - "));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr;
}),
_idProps: {
service: idService,
uuid: "88"
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
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iCMEAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.iCMEIndicatorAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditICMEAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "90"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("idJB4IJcbUetAzOpVlrvIQ#ValueExpression.2241586.1", "ICME"),
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("OnZ+8AApgUyjyWtbpY91nQ#ValueExpression.2241586.1", "ICME"),
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
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "padding-12",
value: model.getCachedValue(idService.getId("asTnjLHFD0+XDW3aOi9yMQ.Value"), function () {
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
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "95"
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
uuid: "96",
alias: "9"
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
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "98"
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
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "100"
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
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("vjROe3J_LUWJpZlVKxToDQ#Value", "Service Type"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("K7rGVofvVUm1JwJzSYN9qQ#Value", "Cost Center"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("0hChWPDC8Ua7c0kua1yo7w#Value", "Benefit Center"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("B2BHdC9YuEWVYv+mGvJxZg#Value", "Free Text"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("bHHx6eONQkyQ2NuydMA4bg#Value", "Division"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("5EY++RK0wUS2_b_WK6nbuQ#Value", "Iva"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("YFBgnsGDCkaRUi1cWg7rnw#Value", "Amount"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("sxNfi7d1l0uqt3l_UMD79A#Value", "Total Amount"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("u0qBYomFaU2qwy7uA_tjPg#Value", "Payment Method"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("s0gCdPiVJEGYCCV_hXFa+g#Value", "Payment Terms"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("XYcwN6+k50+1Btmf3E37Uw#Value", "ICME Indicator")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext))]
}, createElement(OSWidgets$Expression, {
value: ((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) + 1)).toString(),
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.isAnticipoWithInvOut), asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.supplierNumberAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext))]
}, $if((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.supplierNumberAttr,
_idProps: {
service: idService,
uuid: "117"
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
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.supplierNumberAttr,
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr,
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).beneficiaryCenterSAPAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).beneficiaryCenterSAPAttr,
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "126"
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
i_Text: model.getCachedValue(idService.getId("eiTTOzMAkk61fwwOkYK+_Q.i_Text"), function () {
return (((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0)) ? (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr) : (" - "))) : (((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr) !== (""))) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr) : (" - "))));
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr;
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.freeTextAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr),
i_NChar: 60,
ExtendedClass: "padding-12"
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
uuid: "127",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext))]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("9mq5YcgV+UOrpdqP+UDzlQ.Value"), function () {
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
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr,
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideServicesFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("KtrUMWm7Xk6cWyvcf91nuA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.amountAttr;
}),
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
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("EqJH5uOEAUiaMGNHdgHDMg.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr,
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr,
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iCMEAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.iCMEIndicatorAttr), asPrimitiveValue(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)]
}, $if((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).hideAccountingFieldsAttr)), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.iCMEIndicatorAttr,
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iCMEAttr,
_idProps: {
service: idService,
uuid: "142"
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
uuid: "143"
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
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display  font-size-main-heading",
text: [$text(getTranslation("JHzB4gIP30+yJx_XMa+eTA#Value", "Addendum"))],
_idProps: {
service: idService,
uuid: "146"
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
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("js4_awSmkkCoVQCI0XkJ8w#Value", "Concept Name"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("o79nDoRf1E6bHyZ9Nq6d9Q#Value", "Iva"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("9iPQfKyNLE2OjVH6+guPyA#Value", "Amount")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "151"
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
uuid: "152"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("y0FNaZuuekCcpV+WlqHJ2g#ValueExpression.-921175677.1", "Concept Name"),
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
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "155"
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
uuid: "156"
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
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
GroupSeparator: ",",
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
SuffixText: "",
RightAlign: true,
PrefixText: ""
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
uuid: "158",
alias: "11"
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
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "160"
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
uuid: "161"
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
RightAlign: true,
SuffixText: "",
InputId: idService.getId("Input_ConceptOutput"),
DecimalSeparator: ".",
PrefixText: "",
UseNumericInput: true,
AlwaysShowDecimalDigits: true,
GroupSeparator: ",",
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
uuid: "163",
alias: "12"
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
uuid: "164"
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
uuid: "165"
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
uuid: "166",
alias: "13"
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
uuid: "167",
alias: "14"
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
InvoiceExtendedTaxList: model.getCachedValue(idService.getId("xuYuWVUylkeiqOMoJ8hkXw.InvoiceExtendedTaxList"), function () {
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
uuid: "168",
alias: "15"
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
uuid: "169",
alias: "16"
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
uuid: "170"
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
uuid: "171",
alias: "17"
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
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "173"
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
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("g9CWhK4vj0C6hgxbnRo6Wg#Value", "SubTotal"))), createElement(OSWidgets$Input, {
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
GroupSeparator: ",",
SuffixText: "",
InputId: idService.getId("Input_SubTotal"),
AlwaysShowDecimalDigits: true,
DecimalSeparator: ".",
UseNumericInput: true,
PrefixText: "",
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
uuid: "176",
alias: "18"
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
uuid: "177"
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
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+gVsPMSFvUijLcCpzq7GZQ#Value", "Retention"))), createElement(OSWidgets$Input, {
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
GroupSeparator: ",",
SuffixText: "",
UseNumericInput: true,
InputId: idService.getId("Input_Retencions"),
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
PrefixText: "",
RightAlign: true,
AlwaysShowDecimalDigits: true
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
uuid: "180",
alias: "19"
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
uuid: "181"
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
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("iix71imkYUuQhAfmjevUzg#Value", "Total Amount"))), createElement(OSWidgets$Input, {
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
UseNumericInput: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true,
GroupSeparator: ",",
DecimalSeparator: ".",
InputId: idService.getId("Input_TotalAmount"),
RightAlign: true,
PrefixText: "",
SuffixText: ""
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
uuid: "184",
alias: "20"
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
uuid: "185"
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
uuid: "186",
alias: "21"
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
uuid: "187",
alias: "22"
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
uuid: "188"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("z6PCm8RvqkuuUreITX1T+Q#Value", "Import")))];
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
uuid: "189"
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
uuid: "190"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("Iis0IbuFqEmmynkjp1AlHQ#Value", "Save"))],
_idProps: {
service: idService,
uuid: "191"
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
uuid: "192"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.ApproveIcon.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "193"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("YyS9algELU6RtIiJhUHM_g#Value", "Approve"))],
_idProps: {
service: idService,
uuid: "194"
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
uuid: "195"
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
uuid: "196",
alias: "23"
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
uuid: "197",
alias: "24"
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
uuid: "198"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._isActiveUserInDataFetchStatus)
}, $text(getTranslation("UeMnKbVozUWsMC1T7Lv+Xw#Value", "Cancel")))];
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
visible: model.getCachedValue(idService.getId("1kDCF6mYfky6tXB4a96CHA.Visible"), function () {
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
uuid: "199"
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
uuid: "200"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("LCI4tYGU50+6S4lTjNE4lw#Value", "Modify"))],
_idProps: {
service: idService,
uuid: "201"
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
uuid: "202"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.ApproveIcon.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "203"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if((!(model.variables.getDataDataAct.isLastLevelOut)), false, this, function () {
return [createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("VK1Fz+wC60i6toBhuw4Wvw#Value", "Approve"))],
_idProps: {
service: idService,
uuid: "204"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("JSjdJ8YFaUmcFNDb5D4ATw#Value", "Send to accounting"))],
_idProps: {
service: idService,
uuid: "205"
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
TotalAmount: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.subtotalAttr.plus(model.variables.getInvoiceExtendedTaxsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).importeSumAttr),
_totalAmountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr, model.variables.getInvoiceExtendedTaxsByInvoiceIdAggr.dataFetchStatusAttr),
SupplierNumber: model.variables.supplierNumberIn,
_supplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._supplierNumberInDataFetchStatus),
i_InvoiceId: model.variables.i_InvoiceIdIn,
_i_InvoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_InvoiceIdInDataFetchStatus),
i_InvoiceAccountingId: model.variables.getInvoiceAccountingDataAct.o_InvoiceAccountingIdOut,
_i_InvoiceAccountingIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
import$Action: function (i_InvoiceAccountingIn, i_InvoiceAccountingServicesIn, i_InvoiceAccountingEntryIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onImportData$Action(i_InvoiceAccountingIn, OS$DataConversion.JSConversions.typeConvertRecordList(i_InvoiceAccountingServicesIn, new (OS$GenericTypeCache.getGenericList(RC_3b34889e0cefe5468fc5f63480ce4e0f))(), function (source, target) {
target.accountingAccounts_ServiceTypeAttr = source.accountingAccounts_ServiceTypeAttr.descriptionAttr;
target.benefitCenterSAPAttr = source.ceBeCostCenterSAPAttr.ceBeAttr;
target.costCenterSAPAttr = source.costCenterSAPAttr.ce_costeAttr;
target.indicatorIVAAttr = source.taxIndicatorAttr.externalIdAttr;
target.invoiceAccountingServicesAttr = source.invoiceAccountingServicesAttr;
return target;
}), i_InvoiceAccountingEntryIn, controller.callContext(eventHandlerContext));

;
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopupImport$Action(controller.callContext(eventHandlerContext));

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
alias: "25"
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
i_Title: model.getCachedValue(idService.getId("Q5yfTW3Gk0+sGbwKTyW+AQ.i_Title"), function () {
return ((model.variables.l_IsApprovalVar) ? (((model.variables.getDataDataAct.isLastLevelOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0Asabh5t1UKZIYqeak+SDw#Value.-1612981715.1", "Send Accounting")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0Asabh5t1UKZIYqeak+SDw#Value.1715465750.1", "Invoice Approval")))) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0Asabh5t1UKZIYqeak+SDw#Value.-1102331993.1", "Cancel invoice")));
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
uuid: "209",
alias: "26"
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
uuid: "211",
alias: "27"
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
i_InvoiceApprovalLevelId: model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.idAttr,
_i_InvoiceApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalAggr.dataFetchStatusAttr),
InvoiceId: model.variables.i_InvoiceIdIn,
_invoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_InvoiceIdInDataFetchStatus)
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
uuid: "213",
alias: "28"
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
uuid: "214"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("nJLKTQ52v0aXc+0oF7i0Eg#Value", "No records were found in this invoice."))],
_idProps: {
service: idService,
uuid: "215"
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
uuid: "216"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_i_InvoiceAccounting",
functionKey: "33c7aed0-8e5a-4414-8d6e-4da1c5820367",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_i_InvoiceAccounting",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting.css"];
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
