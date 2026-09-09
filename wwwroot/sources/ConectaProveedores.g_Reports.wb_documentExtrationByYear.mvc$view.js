import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Dropdown as OSWidgets$Dropdown, Link as OSWidgets$Link, Icon as OSWidgets$Icon, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Checkbox as OSWidgets$Checkbox, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { DataTypes as OS$DataTypes, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedores_g_Reports_Wb_PreviewFile_mvc_view from "./ConectaProveedores.g_Reports.Wb_PreviewFile.mvc$view.js";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ModelFactory from "./ConectaProveedores.g_Reports.wb_documentExtrationByYear.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.g_Reports.wb_documentExtrationByYear.mvc$controller.js";

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
style: "margin-s",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width3"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("AQE7ERu700uJvH6kYttSeA#Value", "Year"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: true,
labels: function (elem) {
return elem;
},
list: model.variables.getYearsDataAct.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refresh$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.yearVar, function (value) {
model.variables.yearVar = value;
}),
_idProps: {
service: idService,
name: "Dropdown1"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getYearsDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(ConectaProveedores_g_Reports_Wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ForceRefresh: model.variables.forceRefreshVar,
StorageId: model.variables.storageIdVar
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
uuid: "4",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.isSelectOneVar, false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadAll$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "download",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #a6a8aa;"
},
icon: "download",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.yearAux$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getInvoiceFilesByCreatedOnAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Supplier.Name",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("XRHbfDiGv02Gz0_58CLVlg#Value", "Supplier Name"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.Name",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("1yIZaIdbvka_afZ1Bdb6Kg#Value", "Invoice Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.RequisitionId",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("v9_jS0PgX0aGo0Us9SAquA#Value", "Requisition"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "Invoice.TotalAmount",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6_lzbkR58EiNTTdWbfW7Og#Value", "Total Amount"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.Currency",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("S0NrVXkEU0yix6V+5yz3Eg#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "InvoiceExtended.UUID",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Ni4SAeRDqkaLGFCyDdvEGQ#Value", "UUID"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Storage.Filename",
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4mQ7Pz4Dqky2BzjXvR31qA#Value", "Filename"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "InvoiceFile.CreatedOn",
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Wf1yvIEgQEWQIVQ1_fil_Q#Value", "Created On"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "InvoiceAccounting.ServiceCalledOn",
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("cYMxRvT6e0Gc1_9gprhRLQ#Value", "Account Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("2dz3zpFIOkWF75Xoec1Eqg#Value", "Options")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).selectAttr)]
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.selectLines$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).selectAttr, function (value) {
model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).selectAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox1"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Y90XRluMrU6_sA5ISGjGCw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.currencyAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.currencyAttr,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.uUIDAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.uUIDAttr,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.filenameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.filenameAttr,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.createdOnAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateTimeToText(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceFileAttr.createdOnAttr),
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.serviceCalledOnAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("WUEu33UzOE6PICNSByQ2nA.Value"), function () {
return ((model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.serviceCalledOnAttr.equals(OS$BuiltinFunctions.nullDate())) ? ("-") : (OS$BuiltinFunctions.dateTimeToText(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.serviceCalledOnAttr)));
}, function () {
return model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.serviceCalledOnAttr;
}),
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.selectFile$Action(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "eye",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "download",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr)]
})), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: model.variables.maxRecordsVar,
TotalCount: model.variables.getInvoiceFilesByCreatedOnAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr),
StartIndex: model.variables.startIndexVar
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
uuid: "49",
alias: "2"
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
uuid: "50"
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
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "wb_documentExtrationByYear",
functionKey: "fb0c7331-c1b5-4106-948f-b9629d43b240",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "g_Reports.wb_documentExtrationByYear",
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
return [ConectaProveedores_g_Reports_Wb_PreviewFile_mvc_view, OutSystemsUI_Navigation_Pagination_mvc_view];
};


return ELEM;
};

export default componentFactory()
