import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import OutSystemsUI_Content_AccordionItem_mvc_view from "./OutSystemsUI.Content.AccordionItem.mvc$view.js";
import { Text as OSWidgets$Text, Container as OSWidgets$Container, Label as OSWidgets$Label, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccountingWaybill.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccountingWaybill.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OutSystemsUI_Content_AccordionItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: model.variables.i_ExtendedClassIn,
_extendedClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_ExtendedClassInDataFetchStatus)
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "font-size-s",
text: [$text(getTranslation("RjYUbOkvqUKLLKIxfrqeFA#Value", "Carta Porte"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
customIcon: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [$if(((model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.descripcionAttr) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("FqVOSBN1kE2UOd2YWJoDmA#Value", "Description"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.descripcionAttr,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceWaybillAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("qhSwgb+OYUCkP+OVuA6LGQ#Value", "Mercant Value"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("8dVIehojYkqhcRNkaupWAg.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.valorMercanciaAttr, 2, ".", ",");
}, function () {
return model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.valorMercanciaAttr;
}),
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceWaybillAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("rlFPt7G6XkaDjhJpAtgiog#Value", "Attention Center"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.centroAtencionAttr,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceWaybillAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Q7OnE4wraUGZnj_Yo+BUTQ#Value", "Street"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.calleAttr,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceWaybillAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("I6acz9oack+aSLf_gmzIzA#Value", "Ext Number"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.numeroExteriorAttr,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceWaybillAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("hg4OX1WpREGS7vNyeeN9IA#Value", "Postal Code"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.codigoPostalAttr,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceWaybillAggr.dataFetchStatusAttr)
})))];
}, function () {
return [$text(getTranslation("BsOAdTgOMEu7ozoyqCvqUg#Value", "No data available"))];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceWaybillAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.codigoPostalAttr), asPrimitiveValue(model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.numeroExteriorAttr), asPrimitiveValue(model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.calleAttr), asPrimitiveValue(model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.centroAtencionAttr), asPrimitiveValue(model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.valorMercanciaAttr), asPrimitiveValue(model.variables.getInvoiceWaybillAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedCartaPorteAttr.descripcionAttr)]
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_i_InvoiceAccountingWaybill",
functionKey: "e83c4efa-ec83-4623-b49d-31d87b08d1cf",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_i_InvoiceAccountingWaybill",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Content_AccordionItem_mvc_view];
};


return ELEM;
};

export default componentFactory()
