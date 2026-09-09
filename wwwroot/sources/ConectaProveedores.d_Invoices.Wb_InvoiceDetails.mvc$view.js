import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, Label as OSWidgets$Label, List as OSWidgets$List, Text as OSWidgets$Text, Button as OSWidgets$Button, Image as OSWidgets$Image, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { SE_gutterSize as ConectaProveedores_staticEntities_gutterSize, SE_space as ConectaProveedores_staticEntities_space, SE_color as ConectaProveedores_staticEntities_color, SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_Columns3_mvc_view from "./OutSystemsUI.Adaptive.Columns3.mvc$view.js";
import { createElement } from "react";
import { formatEmpty$Action as ConectaProveedoresController$formatEmpty$Action } from "./ConectaProveedores.controller.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import OutSystemsUI_Content_Accordion_mvc_view from "./OutSystemsUI.Content.Accordion.mvc$view.js";
import OutSystemsUI_Content_AccordionItem_mvc_view from "./OutSystemsUI.Content.AccordionItem.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceCancel.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceModify_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceModify.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_PopupApprove_mvc_view from "./ConectaProveedores.y_Utils.Wb_PopupApprove.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetails.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetails.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((model.variables.getInvoiceExtendedByIdAggr.isDataFetchedAttr && (!(model.variables.getInvoiceExtendedByIdAggr.hasFetchErrorAttr))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card min-height-71vh",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr === "MX"), false, this, function () {
return [createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
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
uuid: "1",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "",
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
style: "text-neutral-8",
value: (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("GA3a7HkzgUa+d5+TF5XFeg#ValueExpression.1481403071.1", "Emitted on") + " "),
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("qWQX_bWoBEebgttbkbYx8A.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(OS$BuiltinFunctions.textToDateTime(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.fechaEmisionAttr), "dd/MM/yyyy");
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.fechaEmisionAttr;
}),
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-base",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-8",
value: (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vqswwmF_LUGJnWpya7NlFg#ValueExpression.995957310.1", "Type (Comprover - Pay M. - Pay W.)") + ": "),
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("rKv_p2nVHU2b4Jmss33rDw.Value"), function () {
return (((((((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr === "I")) ? ("Ingresos") : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("nlc2O61wAU6l3IzC32s4_A#ValueExpression.-129548542.1", "Egresos"))) + "   •   ") + ConectaProveedoresController$formatEmpty$Action(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.metodoPagoAttr, callContext).o_OutputOut) + "   •   ") + ConectaProveedoresController$formatEmpty$Action(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.formaPagoAttr, callContext).o_OutputOut);
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.metodoPagoAttr;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.formaPagoAttr;
}),
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "custom"
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
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-right-base",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jtoXKwtr2ESi2DTGI9kxWw#Value", "Version"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("Nwm9IGZ4VEKLSAMl1705_g.Value"), function () {
return ConectaProveedoresController$formatEmpty$Action(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.versionAttr, callContext).o_OutputOut;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.versionAttr;
}),
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ZOvAU_n2X0m8e20IN6a_qQ#Value", "Serie and Name"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("G43F6uZj9UulrXRoMpzILw.Value"), function () {
return ConectaProveedoresController$formatEmpty$Action(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.serieAttr, callContext).o_OutputOut;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.serieAttr;
}),
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("4tAqY2isbEu63r64hlDMRg#Value", "Usage CFDI"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("K5jM+cCIikadTaWUx6Imww.Value"), function () {
return ConectaProveedoresController$formatEmpty$Action(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr, callContext).o_OutputOut;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr;
}),
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("wQbZUsrCSkSE8Q_ib62wOQ#Value", "Export "))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("9wdnu2oJs0WQOd3hUV5aQg.Value"), function () {
return ConectaProveedoresController$formatEmpty$Action(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.exportacionAttr, callContext).o_OutputOut;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.exportacionAttr;
}),
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-base",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "empty-container",
visible: true,
_idProps: {
service: idService,
name: "Empty"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("O1e9A0jBtE6tZK_qPwfMLg.Value"), function () {
return ConectaProveedoresController$formatEmpty$Action(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.folioAttr, callContext).o_OutputOut;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.folioAttr;
}),
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "empty-container",
visible: true,
_idProps: {
service: idService,
name: "Empty2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("HH+R83NpfUmo47+Tj5iJtA.Value"), function () {
return ConectaProveedoresController$formatEmpty$Action(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.lugarExpedicionAttr, callContext).o_OutputOut;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.lugarExpedicionAttr;
}),
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.lugarExpedicionAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.folioAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.exportacionAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.serieAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.versionAttr)]
}), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Space: ConectaProveedores_staticEntities_space.base,
IsVertical: false,
Color: ConectaProveedores_staticEntities_color.secondary
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
uuid: "30",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("40p1f263AkSs+X7vsSwtlQ#Value", "Subtotal"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("KpOf4zo6Jk6hhmcxxA89vA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.subtotalAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.subtotalAttr;
}),
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("KZdI6xdA5EmLDP_MO+fcmg#Value", "Included Taxes"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("3UDx2iHDv0qVtwtv6WmBGQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.totalIVAAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.totalIVAAttr;
}),
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), $if(!(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.descuentoAttr.equals(OS$BuiltinFunctions.integerToDecimal(0))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("YGDPPNcszkKHoejM57qR8g#Value", "Discounts"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("LJMjKihqjkesNF2XF9fbjA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.descuentoAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.descuentoAttr;
}),
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
}), $if(!(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.retencionesAttr.equals(OS$BuiltinFunctions.integerToDecimal(0))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ihNhZASq206q4mv4rkNe3g#Value", "Retentions"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("CkKxr9A4UkWvBOaMOGBb2Q.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.retencionesAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.retencionesAttr;
}),
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
}), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsVertical: false,
Space: ConectaProveedores_staticEntities_space.base,
Color: ConectaProveedores_staticEntities_color.secondary
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
uuid: "43",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if((!(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
extendedProperties: {
style: "font-weight: normal;"
},
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.valueAttr), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.nombreConceptoAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("gWGD14I9XkW2AckMVr10Gw.Value"), function () {
return OS$BuiltinFunctions.trim(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.nombreConceptoAttr);
}, function () {
return model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.nombreConceptoAttr;
}),
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("XU6Lu8pAPUiNGvgxl0JsFg.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.valueAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.valueAttr;
}),
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)
}))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)]
}), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsVertical: false,
Space: ConectaProveedores_staticEntities_space.base,
Color: ConectaProveedores_staticEntities_color.secondary
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
uuid: "48",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between font-size-base",
visible: true,
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "text-neutral-10",
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_MTEHeVxhEmvl3LUGSdP8w#Value", "Total"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "bold",
value: model.getCachedValue(idService.getId("s55F0HIAbUOeozEIbhwU+g.Value"), function () {
return ((OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.totalAttr.plus(model.variables.getInvoiceExtendedMoreChargesTotalAggr.listOut.getCurrent(callContext.iterationContext).valueSumAttr), 2, ".", ",") + " ") + model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.monedaAttr);
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.totalAttr;
}, function () {
return model.variables.getInvoiceExtendedMoreChargesTotalAggr.listOut.getCurrent(callContext.iterationContext).valueSumAttr;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.monedaAttr;
}),
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr, model.variables.getInvoiceExtendedMoreChargesTotalAggr.dataFetchStatusAttr)
})), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.secondary,
Space: ConectaProveedores_staticEntities_space.base,
IsVertical: false
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
uuid: "52",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("JnuFND5xcUi+hbKs_MHO3A#Value", "Exchange Rate"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("Lm6Y9kJPVkiklNus6XNAwQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoCambioAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoCambioAttr;
}),
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), $if(((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.iD_POLIZA_SAPAttr) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jRIO99FP9E66ndr3Zt5YMA#Value", "Poliza SAP"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.iD_POLIZA_SAPAttr,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-top-14px ",
visible: true,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("APu+nValE0aCu1KarwPjow#Value", "Issuer"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-container",
visible: true,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "padding-x-s text-align-left",
visible: true,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "bold",
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.nombreAttr,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-8",
text: ["RFC"],
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.rFCAttr,
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-8",
text: [$text(getTranslation("ej6sz0kzRkO3E+PSSqXX0Q#Value", "Regime"))],
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.regimenFiscalAttr,
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-8",
text: ["CP"],
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.codigoPostalAttr,
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
}))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-48px",
visible: true,
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("65uk3V4xv0+txflrzFvwTA#Value", "Receiver"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-container",
visible: true,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "padding-x-s text-align-left",
visible: true,
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "bold",
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.nombreAttr,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-8",
text: ["RFC"],
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.rFCAttr,
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-8",
text: [$text(getTranslation("i+hbYl+RR0mFHMot0RWX6Q#Value", "Regime"))],
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.regimenFiscalAttr,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-8",
text: ["CP"],
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.codigoPostalAttr,
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})))))))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-14px",
visible: true,
_idProps: {
service: idService,
uuid: "91"
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "92",
alias: "7"
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
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_AccordionItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: model.getCachedValue(idService.getId("5ukTfD4OwUiDHg5oBGvMcg.ExtendedClass"), function () {
return ("margin-bottom-base " + ((model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.isEmpty) ? ("") : ("border-color-secondary ")));
}, function () {
return model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.isEmpty;
}),
_extendedClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.dataFetchStatusAttr)
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
uuid: "94",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "font-size-s",
text: [$text(getTranslation("1Hfv8Kwy0UmMALvRdDyyNg#Value", "CFDI Relations"))],
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
customIcon: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [$if((!(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.length), asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedRelationsAttr.folioRelacionadoAttr), asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedRelationsAttr.uUIDRelacionadoAttr), asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedRelationsAttr.tipoRelacionAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("LF8q6V8aHUO64HAH4EkAhw#Value", "Relation Type"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedRelationsAttr.tipoRelacionAttr,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("OM+BJA8rWUu8nEy8D1fE8Q#Value", "Related UUID"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedRelationsAttr.uUIDRelacionadoAttr,
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3idRgdX9Bkij9K22ZEkCZg#Value", "Related Number"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedRelationsAttr.folioRelacionadoAttr,
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.dataFetchStatusAttr)
})), $if((model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Space: ConectaProveedores_staticEntities_space.small,
Color: ConectaProveedores_staticEntities_color.secondary
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
uuid: "108",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
}))];
}, callContext, idService, "2")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.dataFetchStatusAttr)]
})];
}, function () {
return [$text(getTranslation("w4JL5Cp3IUecRMEK2fJlXQ#Value", "No data available"))];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_AccordionItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: model.getCachedValue(idService.getId("s7o58gFXK0O+CsAgquyxZg.ExtendedClass"), function () {
return ("margin-bottom-base " + ((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.valorMercanciaAttr.equals(OS$BuiltinFunctions.integerToDecimal(0))) ? ("") : ("border-color-secondary ")));
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.valorMercanciaAttr;
}),
_extendedClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
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
uuid: "110",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "font-size-s",
text: [$text(getTranslation("6gSVvk8TakWJfaUc_Z_gYg#Value", "Carta Porte"))],
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
customIcon: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [$if(((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.descripcionAttr) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("PPBkyIOndUaX0DS0XTrJxg#Value", "Description"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.descripcionAttr,
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("cScyeUy1hkyVN+hMrapCog#Value", "Mercant Value"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("tWw05pjq7EiZEOACMhXVIA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.valorMercanciaAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.valorMercanciaAttr;
}),
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("zQqBo61K5EmiFpUMYMHFSw#Value", "Attention Center"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.centroAtencionAttr,
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("UTWrE9kESkKOYepIT6CF2w#Value", "Street"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.calleAttr,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mSePoyiHdEajfW0oqo72mA#Value", "Ext Number"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.numeroExteriorAttr,
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("36BlvcvFz0mo2W60CxI+KA#Value", "Postal Code"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.codigoPostalAttr,
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})))];
}, function () {
return [$text(getTranslation("BStlrEg+jUS0f+t1CGaKGQ#Value", "No data available"))];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.codigoPostalAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.numeroExteriorAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.calleAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.centroAtencionAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.valorMercanciaAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.descripcionAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: false,
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_AccordionItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: model.getCachedValue(idService.getId("gGJxQRM5CkWxv1m3iuszYA.ExtendedClass"), function () {
return ((model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.isEmpty) ? ("") : ("border-color-secondary "));
}, function () {
return model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.isEmpty;
}),
_extendedClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)
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
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "font-size-s",
text: [$text(getTranslation("rZ7Lni1sfUWSZb8bDjen1g#Value", "Other Charges"))],
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
customIcon: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [$if((!(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.length), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.valueAttr), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.nombreConceptoAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("zdwUYqCcUky0tTXzRmCnag#Value", "Concept Name"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.nombreConceptoAttr,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("T0okXbiIEEeLqIqnu50tXQ#Value", "Concept Value"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("mjqknfoLB0iTxqCwyShjbg.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.valueAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedMoreChargesAttr.valueAttr;
}),
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)
})), $if((model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) < (model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.secondary,
Space: ConectaProveedores_staticEntities_space.small
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
uuid: "143",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
}))];
}, callContext, idService, "3")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr)]
})];
}, function () {
return [$text(getTranslation("p0UomCginUukTcS5909X+A#Value", "No data available"))];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.codigoPostalAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.numeroExteriorAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.calleAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.centroAtencionAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.descripcionAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.valorMercanciaAttr), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.listOut), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesTotalAggr.listOut.getCurrent(callContext.iterationContext).valueSumAttr), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut), asPrimitiveValue(model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesTotalAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.codigoPostalAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.numeroExteriorAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.calleAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.centroAtencionAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.descripcionAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.valorMercanciaAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.codigoPostalAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.regimenFiscalAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.rFCAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.nombreAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.codigoPostalAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.regimenFiscalAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.rFCAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.nombreAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.iD_POLIZA_SAPAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoCambioAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.monedaAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.totalAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.retencionesAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.descuentoAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.totalIVAAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.subtotalAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.lugarExpedicionAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.folioAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.exportacionAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.usoCFDIAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.serieAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.versionAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.formaPagoAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.metodoPagoAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.tipoComprobanteAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.fechaEmisionAttr)]
})];
}, function () {
return [createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
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
uuid: "144",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-8",
value: (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("p2ZWnRFyI0e8q70JILo6lg#ValueExpression.1481403071.1", "Emitted on") + " "),
_idProps: {
service: idService,
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("FznPegU1bk+fWg5Zp55JZw.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(OS$BuiltinFunctions.textToDateTime(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.fechaEmisionAttr), "dd/MM/yyyy");
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.fechaEmisionAttr;
}),
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Space: ConectaProveedores_staticEntities_space.base,
IsVertical: false,
Color: ConectaProveedores_staticEntities_color.secondary
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
uuid: "149",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between font-size-base",
visible: true,
_idProps: {
service: idService,
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "text-neutral-10",
_idProps: {
service: idService,
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("59FF80vsWEKVHcokLLbH3w#Value", "Total"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "bold",
value: model.getCachedValue(idService.getId("fBsStfN4WkOL4OtGzv02qQ.Value"), function () {
return ((OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.totalAttr, 2, ".", ",") + " ") + model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.monedaAttr);
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.totalAttr;
}, function () {
return model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.monedaAttr;
}),
_idProps: {
service: idService,
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), $if(((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.iD_POLIZA_SAPAttr) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1jwA1yrl+UeYyFk_41wWRA#Value", "Poliza SAP"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.iD_POLIZA_SAPAttr,
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-top-14px ",
visible: true,
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "158"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("m4jReADlfECB1gWoG_dvhA#Value", "Issuer"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-container",
visible: true,
_idProps: {
service: idService,
uuid: "160"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "padding-x-s text-align-left",
visible: true,
_idProps: {
service: idService,
uuid: "161"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "bold",
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.nombreAttr,
_idProps: {
service: idService,
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-8",
text: ["RFC"],
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.rFCAttr,
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
}))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-48px",
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
_idProps: {
service: idService,
uuid: "168"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5pPQ32DxNkOoxvjZAx_Yhw#Value", "Receiver"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-container",
visible: true,
_idProps: {
service: idService,
uuid: "169"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "padding-x-s text-align-left",
visible: true,
_idProps: {
service: idService,
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "171"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "bold",
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.nombreAttr,
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "173"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-8",
text: ["RFC"],
_idProps: {
service: idService,
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.rFCAttr,
_idProps: {
service: idService,
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
})))))))];
}),
column3: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.rFCAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedReceiverAttr.nombreAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.rFCAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedIssuerAttr.nombreAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.iD_POLIZA_SAPAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.monedaAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.totalAttr), asPrimitiveValue(model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.fechaEmisionAttr)]
})];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align display-flex margin-top-m margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "176"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "177"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_Width3"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onExit$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-back",
visible: true,
_idProps: {
service: idService,
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("h2_9hNzRUECKL2IwrX2jww#Value", "Close")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "display-flex justify-content-flex-end text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.documentUpload) && (model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdByAttr === OS$BuiltinFunctions.getUserId())) || model.variables.isActiveUserIn), false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsBusyVar)),
gridProperties: {
classes: "ThemeGrid_Width3"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openCancelPopUp$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-cancel",
visible: true,
_idProps: {
service: idService,
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("bCKps0eQv0eT1AKACuHyWA#Value", "Cancel")))];
}, function () {
return [];
}), $if((((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.inApproval_UserArea) || ((model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.inApproval_CxP) && ((model.variables.getInvoiceAccountingByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr) !== (OS$BuiltinFunctions.nullTextIdentifier())))) && model.variables.isActiveUserIn), false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsBusyVar)),
gridProperties: {
classes: "ThemeGrid_Width3"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openModifyPopUp$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-edit",
visible: true,
_idProps: {
service: idService,
uuid: "181"
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
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("CRWoobJBs0S93kvGXF8xCw#Value", "Modify"))],
_idProps: {
service: idService,
uuid: "183"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}), $if((model.variables.isActiveUserIn && ((model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalAttr.hasStartedAccountingAttr) ? (((model.variables.getInvoiceAccountingByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.submissionByAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()))) : (true))), false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsBusyVar)),
gridProperties: {
classes: "ThemeGrid_Width3"
},
isDefault: false,
onClick: function () {
_this.validateWidget("");
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openApprovePopUp$Action(controller.callContext(eventHandlerContext));


;
},
style: "btn btn-approve",
visible: true,
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.ApproveIcon.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "185"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if((((model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalAttr.currentLevelAttr === model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalAttr.maxLevelAttr) && model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalAttr.hasStartedAccountingAttr) && ((model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()))), false, this, function () {
return [createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("ExgVuKqZ0UWXgYZoqbn+Dg#Value", "Finalize"))],
_idProps: {
service: idService,
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("VxmPE2nHk0eKWqqx6U+CDQ#Value", "Approve"))],
_idProps: {
service: idService,
uuid: "187"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}, function () {
return [];
})))), createElement(OSWidgets$Popup, {
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
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_InvoiceApprovalLevelId: model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.idAttr,
_i_InvoiceApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalAggr.dataFetchStatusAttr),
i_InvoiceId: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr,
_i_InvoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.hidePopUps$Action(isRefreshIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "189",
alias: "15"
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
InvoiceId: model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr,
_invoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr),
i_InvoiceApprovalLevelId: model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.idAttr,
_i_InvoiceApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.hidePopUps$Action(isRefreshIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "191",
alias: "16"
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
i_Title: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("6rbaCUR4TESH5HHBFdt9og#Value.-463170278.1", "Approve Invoice")
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "193",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "194"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_InvoiceDetails",
functionKey: "e742bb65-0458-4640-8ebe-0c1c12ecd8c3",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_InvoiceDetails",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.d_Invoices.Wb_InvoiceDetails.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Adaptive_Columns3_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view, OutSystemsUI_Content_Accordion_mvc_view, OutSystemsUI_Content_AccordionItem_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceModify_mvc_view, ConectaProveedores_y_Utils_Wb_PopupApprove_mvc_view];
};


return ELEM;
};

export default componentFactory()
