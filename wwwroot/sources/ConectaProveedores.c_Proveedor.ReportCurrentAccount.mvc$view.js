import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import UltimatePDF_PrintLayout_ScreenToPDF_mvc_view from "./UltimatePDF.PrintLayout.ScreenToPDF.mvc$view.js";
import { SE_paperSize as ConectaProveedores_staticEntities_paperSize, SE_marginSize as ConectaProveedores_staticEntities_marginSize } from "./ConectaProveedores.staticEntities.js";
import UltimatePDF_PrintLayout_PrintLayout_mvc_view from "./UltimatePDF.PrintLayout.PrintLayout.mvc$view.js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, Text as OSWidgets$Text, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import { EN_17720044fda96c0c2d8d0760c429f48aEntityRecord } from "./Organization.model.js";
import ConectaProveedores_c_Proveedor_wb_ASDocumentPaymentDetail_mvc_view from "./ConectaProveedores.c_Proveedor.wb_ASDocumentPaymentDetail.mvc$view.js";
import ModelFactory from "./ConectaProveedores.c_Proveedor.ReportCurrentAccount.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Proveedor.ReportCurrentAccount.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, createElement(UltimatePDF_PrintLayout_ScreenToPDF_mvc_view, {
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
contentBlock: new Widget.PlaceholderContent(function () {
return [createElement(UltimatePDF_PrintLayout_PrintLayout_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
HideFooterOnLastPage: false,
PaperSize: ConectaProveedores_staticEntities_paperSize.landscapeA4,
MarginSize: ConectaProveedores_staticEntities_marginSize.one_in,
HideHeaderOnFirstPage: false
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
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
background: Widget.PlaceholderContent.Empty,
header: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-y-xxl padding-y-l margin-x-xxl",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getSupplierUserByUserIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierUserByUserIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 14px;"
},
style: "vertical-align font-semi-bold",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-third",
text: ["#"],
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "margin-left-xs",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-third",
text: ["Proveedor:"],
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
extendedProperties: {
style: "width: auto;"
},
value: model.variables.getSupplierUserByUserIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierUserByUserIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 12px;"
},
style: "vertical-align font-semi-bold",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "margin-left-xs",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-third",
text: [$text(getTranslation("kMzrgaeVA0awr_WnJTp14w#Value", "Date and time for this data: "))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
extendedProperties: {
style: "width: auto;"
},
value: model.getCachedValue(idService.getId("aKCWTa8i206gzTveq8XD4A.Value"), function () {
return OS$BuiltinFunctions.dateTimeToText(OS$BuiltinFunctions.currDateTime());
}),
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
})))), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
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
uuid: "16",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "bold",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "font-size-sub-heading",
text: [$text(getTranslation("PKAN7hV6p0S2SpfRN1MOiw#Value", "Montante total pago"))],
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
gridProperties: {
marginLeft: "0"
},
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mYtK7PcyY02QBAE9GyDnPA#Value", "Total en moneda nacional"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "text-cyan-dark",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("qM1N0q7+tk2JHDVusfOevQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getSapDataDataAct.totalenmonedanacional2Out, 2, ".", ",");
}, function () {
return model.variables.getSapDataDataAct.totalenmonedanacional2Out;
}),
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
gridProperties: {
marginLeft: "0"
},
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("qyyOflpzXEyWUwnD2dxtvQ#Value", "Total en moneda extranjera\n"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "text-cyan-dark",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("aGiezMpq4Umruk4CJtgHrQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjera2Out, 2, ".", ",");
}, function () {
return model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjera2Out;
}),
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
}))), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
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
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "bold",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "font-size-sub-heading",
text: [$text(getTranslation("AdQrpJfZPkW6qNPqUe0xyg#Value", "Montante pendente de pagamento"))],
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
gridProperties: {
marginLeft: "0"
},
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("t1fgqJDDw0OWY7Qwkw5WGA#Value", "Total en moneda nacional"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "text-cyan-dark",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("bMBmlps79kK5l6ZD2zvrVg.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getSapDataDataAct.totalenmonedanacionalOut, 2, ".", ",");
}, function () {
return model.variables.getSapDataDataAct.totalenmonedanacionalOut;
}),
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
gridProperties: {
marginLeft: "0"
},
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("SgNEB_B20U+E7Za5+kQzzQ#Value", "Total en moneda extranjera\n"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "text-cyan-dark",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("R0pPZLcmfE2_ugpx25InFw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjeraOut, 2, ".", ",");
}, function () {
return model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjeraOut;
}),
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
}))), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
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
uuid: "36",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "bold",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "font-size-sub-heading",
text: [$text(getTranslation("Qc86YcAjlEu_h79We8w3Yw#Value", "Total amount invoiced"))],
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2gWcRMiaHE+SzVo3j8qVQw#Value", "Total en moneda nacional"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "text-cyan-dark",
visible: true,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("pqYvkbiSbkqHYbKd9DA+Og.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getSapDataDataAct.totalenmonedanacionalOut.plus(model.variables.getSapDataDataAct.totalenmonedanacional2Out), 2, ".", ",");
}, function () {
return model.variables.getSapDataDataAct.totalenmonedanacionalOut;
}, function () {
return model.variables.getSapDataDataAct.totalenmonedanacional2Out;
}),
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("TrasFz08G06nE4QSrDNmaA#Value", "Total en moneda extranjera\n"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "text-cyan-dark",
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("SIpvolViBEu5tc8nkxhIXQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjeraOut.plus(model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjera2Out), 2, ".", ",");
}, function () {
return model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjeraOut;
}, function () {
return model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjera2Out;
}),
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
}))), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
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
uuid: "46",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "heading3",
visible: true,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Faturas Pendentes de pagamento"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s card",
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Número de factura"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Contra Recibo"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Fecha del documento"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Condición de pago"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Fecha programada de pago"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("QgLNh0PxXEirpAlH2TBXHA#Value", "Importe de la factura"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Moneda")];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getSapDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).xBLNRAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).xBLNRAttr,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getSapDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).zUONRAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).zUONRAttr,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getSapDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).zFBDTAttr)]
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateToText(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).zFBDTAttr),
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getSapDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).zTERMAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).zTERMAttr,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getSapDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).aUGDTAttr)]
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateToText(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).aUGDTAttr),
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getSapDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).wRBTRAttr)]
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).wRBTRAttr),
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getSapDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).wAERSAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getCurrent(callContext.iterationContext).wAERSAttr,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr)
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getSapDataDataAct.dataFetchStatusAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "heading3",
visible: true,
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 30px; text-align: center;"
},
style: "heading3",
visible: true,
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Faturas Pendentes de pagamento")), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_c_Proveedor_wb_ASDocumentPaymentDetail_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ShowFilter: false,
i_T_FAC_PAG: model.variables.getSapDataDataAct.listOut.t_FAC_PAG_OutAttr,
_i_T_FAC_PAGInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSapDataDataAct.dataFetchStatusAttr),
i_PaymentTerms: model.getCachedValue(idService.getId("af1+NAJ12k+XWus1kKLslA.i_PaymentTerms"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getPaymentTermsAggr.listOut, new (OS$GenericTypeCache.getGenericList(EN_17720044fda96c0c2d8d0760c429f48aEntityRecord))(), function (source, target) {
target = source.paymentTermsAttr;
return target;
});
}, function () {
return model.variables.getPaymentTermsAggr.listOut;
}),
_i_PaymentTermsInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentTermsAggr.dataFetchStatusAttr)
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
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}),
bottomContent: Widget.PlaceholderContent.Empty,
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getSapDataDataAct.listOut.t_FAC_PAG_OutAttr), asPrimitiveValue(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr), asPrimitiveValue(model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjeraOut), asPrimitiveValue(model.variables.getSapDataDataAct.totalenmonedanacionalOut), asPrimitiveValue(model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjera2Out), asPrimitiveValue(model.variables.getSapDataDataAct.totalenmonedanacional2Out), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSapDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierUserByUserIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierUserByUserIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr), asPrimitiveValue(model.variables.getSupplierUserByUserIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getSapDataDataAct.listOut.t_FAC_PAG_OutAttr), asPrimitiveValue(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr), asPrimitiveValue(model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjeraOut), asPrimitiveValue(model.variables.getSapDataDataAct.totalenmonedanacionalOut), asPrimitiveValue(model.variables.getSapDataDataAct.importetotaldefacturasmonedaextranjera2Out), asPrimitiveValue(model.variables.getSapDataDataAct.totalenmonedanacional2Out), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSapDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierUserByUserIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierUserByUserIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr), asPrimitiveValue(model.variables.getSupplierUserByUserIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ReportCurrentAccount",
functionKey: "35dd5bea-e57c-4d41-8d11-753098465d2c",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Proveedor.ReportCurrentAccount",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.c_Proveedor.ReportCurrentAccount.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [UltimatePDF_PrintLayout_ScreenToPDF_mvc_view, UltimatePDF_PrintLayout_PrintLayout_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view, ConectaProveedores_c_Proveedor_wb_ASDocumentPaymentDetail_mvc_view];
};


return ELEM;
};

export default componentFactory()
