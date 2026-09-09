import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Expression as OSWidgets$Expression, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { SE_gutterSize as ConectaProveedores_staticEntities_gutterSize } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_ValidationReport.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_ValidationReport.mvc$controller.js";

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
style: "margin-y-xxl padding-y-l margin-x-xxl",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "Page1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center font-bold font-size-h3 h1",
visible: true,
_idProps: {
service: idService,
name: "Title"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("SLrlX9JPtkG2g_IYmMJFAg#Value", "VALIDATION REPORT"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "font-size-xs",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
name: "GeneralData"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "font-size-h6",
visible: true,
_idProps: {
service: idService,
name: "Supplier"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("NS93uteaLUOB7fSQfv9XsA#Value", "Supplier"))],
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
style: "bold text-capitalize",
value: model.variables.validationReportIn.supplierAttr,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: ((model.variables.validationReportIn.projectAttr) !== ("")),
_idProps: {
service: idService,
name: "Project"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("U7BNt2PNXUWAqxRNFhisIA#Value", "Project"))],
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.projectAttr,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GutterSize: ConectaProveedores_staticEntities_gutterSize.none
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
uuid: "13",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [$if(((model.variables.validationReportIn.reservePeriodAttr) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: ((model.variables.validationReportIn.reservePeriodAttr) !== ("")),
_idProps: {
service: idService,
name: "ReservePeriod"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("XA50vM9NCEqMg5iae+5fjQ#Value", "Reserve Period"))],
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.reservePeriodAttr,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}))];
}, function () {
return [];
}), $if(((model.variables.validationReportIn.frequencyAttr) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "Frequency"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("UHCL0SCWtUagDLFLzw1MHw#Value", "Frequency"))],
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.frequencyAttr,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: false,
_idProps: {
service: idService,
name: "DeliveryDateHIDDEN"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("8BG80J0b3kiBObZ1Q8lFBA#Value", "Delivery Date"))],
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.deliveryDateAttr,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), $if((!(model.variables.isFromRequisitionIn)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "DeliverySite"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px bold",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7 font-regular",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WlBLoo40Y0m8uQH2Gk6BKw#ValueExpression.416002035.1", "Delivery Site"),
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.deliverySiteAttr,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "EntryNumber"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px bold",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7 font-regular",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hPkbvNpf6EOIY046eO_VGw#ValueExpression.114980599.1", "Entry Number"),
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.entryNumberAttr,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "DeliverySite3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px bold",
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7 font-regular",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("AIr0RkSivE2Y5dUdqryq5w#ValueExpression.-31482148.1", "Entry Date"),
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("CI2lZgiD6Uyd16AsUBYuXg.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.validationReportIn.entryDateAttr, "dd/MM/yyyy");
}, function () {
return model.variables.validationReportIn.entryDateAttr;
}),
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}))];
}, function () {
return [];
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "InvoiceNumber"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px",
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("JsVeDW05vEKIvcslyzxvmw#Value", "Invoice Number"))],
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.invoiceNumberAttr,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), $if((!(model.variables.isFromRequisitionIn)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "OrderNumber"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px bold",
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7 font-regular",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("KzmzDheu_U6oEh9XDhLEQA#ValueExpression.69519515.1", "Order Number"),
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.orderNumberAttr,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "ReqNumber"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px bold",
visible: true,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7 font-regular",
value: model.getCachedValue(idService.getId("UOkpYxqMe0emN7p9RJQjOA.Value"), function () {
return ((model.variables.isFromRequisitionIn) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IyVwRwrnC0Cege096vsSjw#ValueExpression.466416525.1", "Requisition Number")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IyVwRwrnC0Cege096vsSjw#ValueExpression.-1141793184.1", "Folio Number")));
}, function () {
return model.variables.isFromRequisitionIn;
}),
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._isFromRequisitionInDataFetchStatus)
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.requisitionNumberAttr,
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), $if((!(model.variables.isFromRequisitionIn)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "FolioDate"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px bold",
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7 font-regular",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4tPrpCydHkCRwh_28rbihg#ValueExpression.-1512072840.1", "Folio creation date"),
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("C4PPWksLg0SCImKwtZOk2w.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.validationReportIn.folioCreationDateAttr, "dd/MM/yyyy");
}, function () {
return model.variables.validationReportIn.folioCreationDateAttr;
}),
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "Company"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px bold",
visible: true,
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7 font-regular",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vUHfK4oAcE+G7nhEVEqXHQ#ValueExpression.-374112632.1", "Society"),
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.societyAttr,
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "PEPElement"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-120px bold",
visible: true,
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7 font-regular",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("r+ffZN2qKUawKzh28C3MRw#ValueExpression.-1327014729.1", "PEP Element"),
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.pEPElementAttr,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.isFromRequisitionIn), asPrimitiveValue(model.variables._isFromRequisitionInDataFetchStatus), asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.pEPElementAttr), asPrimitiveValue(model.variables.validationReportIn.societyAttr), asPrimitiveValue(model.variables.validationReportIn.folioCreationDateAttr), asPrimitiveValue(model.variables.validationReportIn.requisitionNumberAttr), asPrimitiveValue(model.variables.validationReportIn.orderNumberAttr), asPrimitiveValue(model.variables.validationReportIn.invoiceNumberAttr), asPrimitiveValue(model.variables.validationReportIn.entryDateAttr), asPrimitiveValue(model.variables.validationReportIn.entryNumberAttr), asPrimitiveValue(model.variables.validationReportIn.deliverySiteAttr), asPrimitiveValue(model.variables.validationReportIn.deliveryDateAttr), asPrimitiveValue(model.variables.validationReportIn.frequencyAttr), asPrimitiveValue(model.variables.validationReportIn.reservePeriodAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-l",
visible: true,
_idProps: {
service: idService,
name: "DeliveryTable"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center bold font-size-s",
visible: true,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("A8imGqNJ40uY_KGxtMTAww#Value", "Delivery Description"))), createElement(OSWidgets$TableRecords, {
extendedProperties: {
style: "table-layout: fixed; width: 100%; word-wrap: break-word;"
},
showHeader: true,
source: model.variables.validationReportIn.validationReportItemsAttr,
style: "table margin-top-s",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
style: "col-pos",
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "justify-content-space-evenly text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "",
text: [$text(getTranslation("s0wSMjFjaEOJo6LI6DWvdw#Value", "Pos"))],
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
style: "col-articulo text-align-center",
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "justify-content-space-evenly text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1mcuQmxANkCFo7Fm_zGqTQ#Value", "Article")))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Kyfpali6GkG9dyYQuVDXSg#Value", "Description"))), createElement(OSWidgets$HeaderCell, {
style: "col-codigo",
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "justify-content-space-evenly text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("yHyrLHShkkOGvHN6bmFA9Q#Value", "Material Code")))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
style: "col-cant",
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "justify-content-space-evenly text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jrzmirjG5kaD6oGOR4pFpw#Value", "Quantity")))), createElement(OSWidgets$HeaderCell, {
style: "col-precio",
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "justify-content-space-evenly text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NAP8v3+wS0qKEeF7OQtfvg#Value", "Unity Price")))), createElement(OSWidgets$HeaderCell, {
style: "col-monto",
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "justify-content-space-evenly text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mfR16UB3D0qIK+F3bl6zng#Value", "TotalAmount")))), createElement(OSWidgets$HeaderCell, {
style: "col-moneda",
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "justify-content-space-evenly text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mBEu3I5+kEShRJjqroNpRg#Value", "Currency"))))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.validationReportItemsAttr.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).articleAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("03KCcXTfdUqgiTzyeHhbgA.Value"), function () {
return ((((model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).articleAttr) !== ("0"))) ? (((model.variables.validationReportIn.validationReportItemsAttr.getCurrentRowNumber(callContext.iterationContext) + 1)).toString()) : (""));
}, function () {
return model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).articleAttr;
}, function () {
return model.variables.validationReportIn.validationReportItemsAttr.getCurrentRowNumber(callContext.iterationContext);
}),
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).articleAttr)]
}, createElement(OSWidgets$Expression, {
style: "",
value: model.getCachedValue(idService.getId("crwoG_zU2k6+XU9MzqxPLw.Value"), function () {
return ((((model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).articleAttr) !== ("0"))) ? (model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).articleAttr) : (""));
}, function () {
return model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).articleAttr;
}),
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).descriptionAttr,
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).materialCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).materialCodeAttr,
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("I1NsG+3c2EmeDOPWimbGyQ.Value"), function () {
return ((((model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).quantityAttr) !== (0))) ? ((model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).quantityAttr).toString()) : (""));
}, function () {
return model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).quantityAttr;
}),
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).unitPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("rDDTxsjloEaq5hFLGc_maQ.Value"), function () {
return ((((model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).unitPriceAttr) !== (""))) ? (model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).unitPriceAttr) : (""));
}, function () {
return model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.validationReportItemsAttr.length), asPrimitiveValue(model.variables.validationReportIn.validationReportItemsAttr.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).totalAmountAttr)]
}, createElement(OSWidgets$Expression, {
style: model.getCachedValue(idService.getId("8QN306De20qkTun6ArtstA.Style"), function () {
return (((model.variables.validationReportIn.validationReportItemsAttr.getCurrentRowNumber(callContext.iterationContext) === (model.variables.validationReportIn.validationReportItemsAttr.length - 1))) ? ("bold ") : (""));
}, function () {
return model.variables.validationReportIn.validationReportItemsAttr.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.validationReportIn.validationReportItemsAttr.length;
}),
value: model.getCachedValue(idService.getId("8QN306De20qkTun6ArtstA.Value"), function () {
return ((((model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).totalAmountAttr) !== (""))) ? (model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).totalAmountAttr) : (""));
}, function () {
return model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus),
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).currencyAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.validationReportItemsAttr.getCurrent(callContext.iterationContext).currencyAttr,
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus)]
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "page-break",
visible: true,
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "font-size-xs",
visible: true,
_idProps: {
service: idService,
name: "Page2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-xxl",
visible: true,
_idProps: {
service: idService,
name: "AfterTable2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "padding-top-base",
visible: ((model.variables.validationReportIn.businessCatAttr) !== ("")),
_idProps: {
service: idService,
name: "Category2"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-200px",
visible: true,
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("SwxQfQmDiUGYBX9EMYSJ5g#Value", "Business Category"))],
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.businessCatAttr,
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: ((model.variables.validationReportIn.businessSubcatAttr) !== ("")),
_idProps: {
service: idService,
name: "Subcategory2"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-200px",
visible: true,
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("O+MxhahAwUKgIgQCdyAGjw#Value", "Business Subcategory"))],
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.businessSubcatAttr,
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: false,
_idProps: {
service: idService,
name: "Characteristics2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-200px",
visible: true,
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("IUp9PqbhxEyO_lDmfXfB4A#Value", "Characteristics"))],
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.characteristicsAttr,
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: false,
_idProps: {
service: idService,
name: "Deliveries2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-200px",
visible: true,
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("iclz8xHb8kaXR3KduUOICQ#Value", "Deliveries"))],
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.deliveriesAttr,
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
name: "Attachments2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-200px",
visible: true,
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("lTA8k7P+l0Sxpp3m4KSaWg#Value", "Attachments"))],
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Expression, {
gridProperties: {
marginLeft: "0"
},
value: model.variables.validationReportIn.attachmentsAttr,
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center bold margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("GeWKc_k38U+7BwHuaJYnuA#Value", "I reviewed the documentation of this operation, acknowledging that the goods and services have been received to the satisfaction of the area."))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-l",
visible: true,
_idProps: {
service: idService,
name: "AuthorizationsTable3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center bold font-size-s",
visible: true,
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("OufUdgWauU2Wwm05ZgS34A#Value", "Electronic Authorizations"))), createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.validationReportIn.validationReportAuthorizationsAttr,
style: "table margin-top-s",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("OW2JrrXZyUuGP7Qi5GOLvQ#Value", "Name and Field")))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dKRWme7D+0mcc5diHrGXtg#Value", "Date")))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2veaLWtMHUiIJWDVepAuyg#Value", "Hour"))))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.validationReportAuthorizationsAttr.getCurrent(callContext.iterationContext).fieldAttr), asPrimitiveValue(model.variables.validationReportIn.validationReportAuthorizationsAttr.getCurrent(callContext.iterationContext).nameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.validationReportAuthorizationsAttr.getCurrent(callContext.iterationContext).nameAttr,
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.validationReportAuthorizationsAttr.getCurrent(callContext.iterationContext).fieldAttr,
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.validationReportAuthorizationsAttr.getCurrent(callContext.iterationContext).dateAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "",
value: model.variables.validationReportIn.validationReportAuthorizationsAttr.getCurrent(callContext.iterationContext).dateAttr,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus), asPrimitiveValue(model.variables.validationReportIn.validationReportAuthorizationsAttr.getCurrent(callContext.iterationContext).hourAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.validationReportIn.validationReportAuthorizationsAttr.getCurrent(callContext.iterationContext).hourAttr,
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._validationReportInDataFetchStatus)
})))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables._validationReportInDataFetchStatus)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-xl font-size-10px",
visible: true,
_idProps: {
service: idService,
name: "DisclaimerCont"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "",
text: ["TELCEL acepta las evidencias proporcionadas por el PROVEEDOR en las condiciones en las que se encuentran en el entendido de que los Bienes o Servicios y están operando correctamente conforme fue solicitado por Telcel. En caso de que Telcel llegara a detectar alguna desviación en las cantidades o modelos de lo suministrado (Bienes o Servicios) así como en la operación de los mismos posterior a la emisión del Acta de Validación, o bien si tuviera algún problema operativo o de desempeño de los suministros (Bienes o Servicios), el PROVEEDOR se compromete, por el acto de validación de la presente acta, a dar solución a cualquier problema que se presente incluyendo de forma enunciativa más no limitativa el suministro de Bienes o servicios, etc. sin ningún costo adicional para Telcel."],
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_ValidationReport",
functionKey: "4df7175e-c343-4e86-89c5-387df95f4334",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_ValidationReport",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.y_Utils.Wb_ValidationReport.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Adaptive_Columns2_mvc_view];
};


return ELEM;
};

export default componentFactory()
