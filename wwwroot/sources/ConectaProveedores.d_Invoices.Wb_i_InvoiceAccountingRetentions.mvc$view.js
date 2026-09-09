import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import OutSystemsUI_Content_AccordionItem_mvc_view from "./OutSystemsUI.Content.AccordionItem.mvc$view.js";
import { Text as OSWidgets$Text, List as OSWidgets$List, Container as OSWidgets$Container, Label as OSWidgets$Label, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { SE_color as ConectaProveedores_staticEntities_color, SE_space as ConectaProveedores_staticEntities_space } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccountingRetentions.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccountingRetentions.mvc$controller.js";

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
text: [$text(getTranslation("CEN001lLAU6x2B8Zt3QmZw#Value", "Retentions"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
customIcon: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [$if((!(model.variables.invoiceExtendedTaxListIn.isEmpty)), false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.invoiceExtendedTaxListIn,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._invoiceExtendedTaxListInDataFetchStatus),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._invoiceExtendedTaxListInDataFetchStatus), asPrimitiveValue(model.variables.invoiceExtendedTaxListIn.length), asPrimitiveValue(model.variables.invoiceExtendedTaxListIn.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).importeAttr), asPrimitiveValue(model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).tasaOCuotaAttr), asPrimitiveValue(model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).baseAttr), asPrimitiveValue(model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).impuestoAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5boeCxcWXkGmOqk25MxUSA#Value", "Tax"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).impuestoAttr,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._invoiceExtendedTaxListInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ywq6xSFmP0K4ry182LtJag#Value", "Base"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("uTs2e4oFvkO9hQUucwFLJQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).baseAttr, 2, ".", ",");
}, function () {
return model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).baseAttr;
}),
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._invoiceExtendedTaxListInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-8",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("yUgbtg3s6UiJTfmJJDMGkA.Value"), function () {
return (((model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).impuestoAttr === "001")) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ldhXNjVpXUC5hhT3jbMruA#ValueExpression.73832.1", "Isr")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ldhXNjVpXUC5hhT3jbMruA#ValueExpression.73908.1", "Iva")));
}, function () {
return model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).impuestoAttr;
}),
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._invoiceExtendedTaxListInDataFetchStatus)
})), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("JTzCTf6oeEOwlVO6wSmEyw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).tasaOCuotaAttr, 2, ".", ",");
}, function () {
return model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).tasaOCuotaAttr;
}),
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._invoiceExtendedTaxListInDataFetchStatus)
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
}, $text(getTranslation("1GUgPOlX60uFXbVMtSXebg#Value", "Amount"))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("sCF4Y9QBUUqY83o0mb4dAg.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).importeAttr, 2, ".", ",");
}, function () {
return model.variables.invoiceExtendedTaxListIn.getCurrent(callContext.iterationContext).importeAttr;
}),
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._invoiceExtendedTaxListInDataFetchStatus)
})), $if((model.variables.invoiceExtendedTaxListIn.getCurrentRowNumber(callContext.iterationContext) < (model.variables.invoiceExtendedTaxListIn.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "17"
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
uuid: "18",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
}))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables._invoiceExtendedTaxListInDataFetchStatus)]
})];
}, function () {
return [$text(getTranslation("7EA7hyiKRE6qgehBaGc7oA#Value", "No data available"))];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables._invoiceExtendedTaxListInDataFetchStatus), asPrimitiveValue(model.variables.invoiceExtendedTaxListIn)]
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_i_InvoiceAccountingRetentions",
functionKey: "b720e6cd-3a56-45eb-8668-787d3ffe6c3e",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_i_InvoiceAccountingRetentions",
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
return [OutSystemsUI_Content_AccordionItem_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view];
};


return ELEM;
};

export default componentFactory()
