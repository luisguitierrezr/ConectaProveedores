import { withBaseWebBlock, Widget, asPrimitiveValue, ifWidget as $if, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, List as OSWidgets$List, Expression as OSWidgets$Expression, Link as OSWidgets$Link, Image as OSWidgets$Image, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_mvc_view from "./ConectaProveedores.e_OrdersRequestFiles.wb_RejectReason.mvc$view.js";
import { SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus, SE_contractFileType as ConectaProveedores_staticEntities_contractFileType } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.mvc$view.js";
import ConectaProveedores_e_Orders_Wb_OrderFilesPreview_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrderFilesPreview.mvc$view.js";
import ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrderFinancialFilesPreview.mvc$view.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_mvc_view from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFinancialFileWithoutAcc.mvc$view.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_mvc_view from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_Orders.WB_OrderFinancialFiles.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.WB_OrderFinancialFiles.mvc$controller.js";

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
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getOrderAccountingsByOrderIdAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "request-files-box",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.needsApprovalAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.idAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.paymentDateAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.amountAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).accountingDataTypeAttr.labelAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width5"
},
style: "request-files-title",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).accountingDataTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "heading6",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
extendedProperties: {
style: "color: #67686a; font-size: 14px;"
},
value: model.getCachedValue(idService.getId("qyVN4FOCfkWArhEcHMJ5kw.Value"), function () {
return (((OS$BuiltinFunctions.decimalToText(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.amountAttr) + " | ") + model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr) + ((!(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.paymentDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? ((" | " + OS$BuiltinFunctions.dateToText(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.paymentDateAttr))) : ("")));
}, function () {
return model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.amountAttr;
}, function () {
return model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr;
}, function () {
return model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.paymentDateAttr;
}),
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr)
})), $if(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderRequestFilesId: model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.idAttr,
_orderRequestFilesIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr)
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
uuid: "9",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "font-size-s text-neutral-10",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && (((model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.accounting) || (model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)) || (model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationSuccess))), false, this, function () {
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
uuid: "11",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr),
i_Text: model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr)
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
uuid: "12",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr), asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr)]
})];
}, function () {
return [];
}))];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((!(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) && !(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))), false, this, function () {
return [createElement(ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InvoiceId: model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr,
_invoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr)
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
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
}), $if(((!(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) && !(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))), false, this, function () {
return [createElement(ConectaProveedores_e_Orders_Wb_OrderFilesPreview_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderRequestFileId: model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.idAttr,
_orderRequestFileIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr)
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
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.needsApprovalAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.getCachedValue(idService.getId("ANc71vpCmkWiluNCeGjLuA.i_Class"), function () {
return ((((model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr === false) && (model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr === false))) ? ("inapproval") : (((model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr) ? ("approved") : ("rejected"))));
}, function () {
return model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr;
}, function () {
return model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr;
}),
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr),
i_Text: model.getCachedValue(idService.getId("ANc71vpCmkWiluNCeGjLuA.i_Text"), function () {
return ((((model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr === false) && (model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr === false))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("34Jnwsdkh06oty8ylpU11A#Value.1070808798.1", "In Approval")) : (((model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("34Jnwsdkh06oty8ylpU11A#Value.1249888983.1", "Approved")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("34Jnwsdkh06oty8ylpU11A#Value.-543852386.1", "Rejected")))));
}, function () {
return model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr;
}, function () {
return model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr)
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
uuid: "18",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) && model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openPopupFinancial$Action(model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.idAttr, model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_subir.svg"),
style: "img img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr)]
}), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getOrderFileByIdAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.needsApprovalAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.idAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderContractFileAttr.startBaseDateAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderFileAttr.idAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).currency_2Attr.codeAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.endBaseDateAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.startBaseDateAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractAmountAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).contractFileTypeAttr.labelAttr), asPrimitiveValue(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).contractFileTypeAttr.idAttr)]
}, $if((model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).contractFileTypeAttr.idAttr === ConectaProveedores_staticEntities_contractFileType.contract), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "request-files-box",
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
classes: "ThemeGrid_Width5"
},
style: "request-files-title",
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
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).contractFileTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "heading6",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
extendedProperties: {
style: "color: #67686a; font-size: 14px;"
},
value: model.getCachedValue(idService.getId("MfKIzGYw60e_hI0a9VlF_Q.Value"), function () {
return ((((OS$BuiltinFunctions.decimalToText(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractAmountAttr) + " | ") + model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).currency_2Attr.codeAttr) + ((!(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.startBaseDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? ((" | " + OS$BuiltinFunctions.dateToText(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.startBaseDateAttr))) : (""))) + ((!(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.endBaseDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? ((" | " + OS$BuiltinFunctions.dateToText(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.endBaseDateAttr))) : ("")));
}, function () {
return model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractAmountAttr;
}, function () {
return model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).currency_2Attr.codeAttr;
}, function () {
return model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.startBaseDateAttr;
}, function () {
return model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.endBaseDateAttr;
}),
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderFileId: model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderFileAttr.idAttr,
_orderFileIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr)
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
uuid: "31",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "request-files-box",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width5"
},
style: "request-files-title",
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).contractFileTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "heading6",
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
extendedProperties: {
style: "color: #67686a; font-size: 14px;"
},
value: model.getCachedValue(idService.getId("TdHbazg1wEqX17vm2AuEdQ.Value"), function () {
return (((OS$BuiltinFunctions.decimalToText(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr) + " | ") + model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr) + ((!(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderContractFileAttr.startBaseDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? ((" | " + OS$BuiltinFunctions.dateToText(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderContractFileAttr.startBaseDateAttr))) : ("")));
}, function () {
return model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr;
}, function () {
return model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr;
}, function () {
return model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderContractFileAttr.startBaseDateAttr;
}),
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr)
})), $if(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderRequestFilesId: model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.idAttr,
_orderRequestFilesIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr)
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
uuid: "39",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((!(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) && !(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))), false, this, function () {
return [createElement(ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderFileId: model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderFileAttr.idAttr,
_orderFileIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr)
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
uuid: "41",
alias: "9"
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
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.needsApprovalAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.getCachedValue(idService.getId("ZJYu_dJTYkabec1dbBEFVQ.i_Class"), function () {
return ((((model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr === false) && (model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr === false))) ? ("inapproval") : (((model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr) ? ("approved") : ("rejected"))));
}, function () {
return model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr;
}, function () {
return model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr;
}),
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr),
i_Text: model.getCachedValue(idService.getId("ZJYu_dJTYkabec1dbBEFVQ.i_Text"), function () {
return ((((model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr === false) && (model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr === false))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("b6u_RYYrt06M5kbwki+evg#Value.1070808798.1", "In Approval")) : (((model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("b6u_RYYrt06M5kbwki+evg#Value.1249888983.1", "Approved")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("b6u_RYYrt06M5kbwki+evg#Value.-543852386.1", "Rejected")))));
}, function () {
return model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr;
}, function () {
return model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr)
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
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) && model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openPopupContract$Action(model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderContractFileAttr.idAttr, model.variables.getOrderFileByIdAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_subir.svg"),
style: "img img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})))];
}))];
}, callContext, idService, "2")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr)]
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "width: 700px; padding: var(--space-base);"
},
showPopup: model.variables.l_ShowPopupFinancialVar,
style: "xl-popup popup-dialog card",
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "49"
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
uuid: "50",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("uC2C2GBYxkC0kV36cpVsFA#Value", "Upload documents"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderAccConceptsId: model.variables.l_OrderAccConceptsIdVar,
AccountingDataTypeId: model.variables.l_AccountingDataTypeIdVar,
i_OrderRequestFileId: model.variables.l_OrderRequestFileIdSelectedVar,
OrderMainId: model.variables.i_OrderIdIn,
_orderMainIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_OrderIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
cancel$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopup$Action(controller.callContext(eventHandlerContext));

;
},
update$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refresh$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "56",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "width: 700px; padding: var(--space-base);"
},
showPopup: model.variables.l_ShowContractPopupVar,
style: "xl-popup popup-dialog card",
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "59"
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
uuid: "60",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("zWUTgEwLq0CErByZR3GWPA#Value", "Upload documents"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderMainId: model.variables.i_OrderIdIn,
_i_OrderMainIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_OrderIdInDataFetchStatus),
i_OrderContractFile: model.variables.l_OrderContractFileVar,
i_OrderRequestFileId: model.variables.l_OrderRequestFileIdSelectedVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
update$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refresh$Action(controller.callContext(eventHandlerContext));
});
;
},
cancel$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopup$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "66",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "WB_OrderFinancialFiles",
functionKey: "41fb7ad5-e1fb-4d1d-904f-52c3bbe624c1",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.WB_OrderFinancialFiles",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.e_Orders.WB_OrderFinancialFiles.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view, ConectaProveedores_e_Orders_Wb_OrderFilesPreview_mvc_view, ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_mvc_view, ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_mvc_view, ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_mvc_view];
};


return ELEM;
};

export default componentFactory()
