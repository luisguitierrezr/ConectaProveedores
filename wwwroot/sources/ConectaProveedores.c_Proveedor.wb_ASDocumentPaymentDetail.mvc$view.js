import { withBaseWebBlock, Widget, asPrimitiveValue, ifWidget as $if, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { Container as OSWidgets$Container, Icon as OSWidgets$Icon, Input as OSWidgets$Input, Label as OSWidgets$Label, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import { createElement } from "react";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import ModelFactory from "./ConectaProveedores.c_Proveedor.wb_ASDocumentPaymentDetail.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Proveedor.wb_ASDocumentPaymentDetail.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(model.variables.i_ShowFilterIn, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width5"
},
style: "os-boxlabel margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlignIconRight: true
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
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "search",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 100,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_KeywordVar, function (value) {
model.variables.l_KeywordVar = value;
}),
_idProps: {
service: idService,
name: "Input_InvoiceTextNumber"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_KeywordVar)]
}), createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Número de factura o número de documento")), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_InvoiceTextNumber")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.find$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "5",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
}), createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.l_T_FAC_PAGVar,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("UzOxK1DLAE+iviXQsdNs6g#Value", "Invoice Number"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Documento de Pago"), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("X0JTUhhAXkC8XVN177R1MA#Value", "Contabilization Date"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("dB3ecKm8jECDE+X6xq78Tw#Value", "Payment conditions"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("lkyTfZmZyUO2cQY5S2zogA#Value", "Payment Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ptXZBF7b70++LOK3p5xN5w#Value", "Local Import Value"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ViF6n_VF4ku6Si7wxv9F5w#Value", "External Import Value"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("zP3nO_Bc402Eu14CayWGAA#Value", "Tipo de cambio"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Moneda")];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).xBLNRAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).xBLNRAttr,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).aUGBLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).aUGBLAttr,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).zFBDTAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateToText(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).zFBDTAttr),
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).zTERMAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).zTERMAttr,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).aUGDTAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateToText(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).aUGDTAttr),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).wRBT2Attr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("fa+0agrkD0a0OKkLV+yIHw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).wRBT2Attr, 2, ".", ",");
}, function () {
return model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).wRBT2Attr;
}),
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).wRBT3Attr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("6+8ESEQmZ0qHRAR_uB+V8w.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).wRBT3Attr, 2, ".", ",");
}, function () {
return model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).wRBT3Attr;
}),
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).kURSFAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("7ngM7pzrREmfK9qSDyEfOA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).kURSFAttr, 2, ".", ",");
}, function () {
return model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).kURSFAttr;
}),
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).wAERSAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_T_FAC_PAGVar.getCurrent(callContext.iterationContext).wAERSAttr,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, callContext, idService, "1_0")
},
_dependencies: []
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "wb_ASDocumentPaymentDetail",
functionKey: "28b5c2ca-f4da-4453-8b59-0d504056b8ad",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Proveedor.wb_ASDocumentPaymentDetail",
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
return [OutSystemsUI_Interaction_InputWithIcon_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view];
};


return ELEM;
};

export default componentFactory()
