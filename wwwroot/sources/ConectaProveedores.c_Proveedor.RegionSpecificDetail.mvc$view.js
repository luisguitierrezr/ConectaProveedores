import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ModelFactory from "./ConectaProveedores.c_Proveedor.RegionSpecificDetail.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Proveedor.RegionSpecificDetail.mvc$controller.js";

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
}, $if(model.variables.getInvoiceApprovalLevelsAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getInvoiceApprovalLevelsAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Jpih_65O1U6lnmW_h_qoEg#Value", "No invoices to list.")))];
}, function () {
return [createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
uuid: "2",
alias: "1"
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
source: model.variables.getInvoiceApprovalLevelsAggr.listOut,
style: "table custom-table-region-specific",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "TableInvoiceApprovalLevels"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.Name",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ASkNGCL_o0Go3H6nKfveEg#Value", "Invoice Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Invoice.AccountingDateTime",
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("aEvIJdtFUEKi6QTGL4wTxQ#Value", "Accounting Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "PaymentTerms.Description",
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("uCC+KAFlfUK82Z+AVD+sDw#Value", "Paydays / Payment Terms"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Invoice.PaymentDateTime",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("L1c0O7KZQEitHiZbDNGjxQ#Value", "Payment Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-lign: right;"
},
sortAttribute: "Invoice.TotalAmount",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("wrOU8HZBQk67Y1BGSIvNkw#Value", "Local Currency Amount"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-lign: right;"
},
sortAttribute: "Invoice.TotalAmount",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("LxQZ7uBjf06g9CXHY00E8A#Value", "Foeign Currency Amount"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "RequisitionAccounting.NegociatedExchangeRateAcc",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("e_ibxQMnnU+Kd+lz1QYZVA#Value", "Exchange rate"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("rESJ0ibhokKJnlfy48hydQ#Value", "Status")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.accountingDateTimeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("pzMuYyCG3EGnRWf4JlKNmw.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.accountingDateTimeAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.accountingDateTimeAttr;
}),
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).paymentTermsAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).paymentTermsAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.paymentDateTimeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("5ghIl5DgWUSkmzvKlX_ZxA.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.paymentDateTimeAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.paymentDateTimeAttr;
}),
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("45UOXihwQkSyO2EFD5yK1w.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("DQqnZsvD902ksThv3VYw8Q.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).requisitionAccountingAttr.negociatedExchangeRateAccAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("jrx1+rmmz02yozYnS_DKng.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).requisitionAccountingAttr.negociatedExchangeRateAccAttr, "", 2, ".", ",");
}, function () {
return model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).requisitionAccountingAttr.negociatedExchangeRateAccAttr;
}),
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr), asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr),
i_Text: model.variables.getInvoiceApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr)
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
uuid: "27",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceApprovalLevelsAggr.listOut)]
}), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartIndex: model.variables.startIndexVar,
TotalCount: model.variables.getInvoiceApprovalLevelsAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalLevelsAggr.dataFetchStatusAttr),
MaxRecords: model.variables.maxRecordsVar
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
uuid: "28",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "29"
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
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
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
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "RegionSpecificDetail",
functionKey: "42998753-2183-4761-8dbe-c5068c7c9358",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Proveedor.RegionSpecificDetail",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, OutSystemsUI_Navigation_Pagination_mvc_view];
};


return ELEM;
};

export default componentFactory()
