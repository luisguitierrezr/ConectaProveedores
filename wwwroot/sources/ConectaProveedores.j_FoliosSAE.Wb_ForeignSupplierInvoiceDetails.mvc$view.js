import { withBaseWebBlock, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Input as OSWidgets$Input } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_ForeignSupplierInvoiceDetails.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_ForeignSupplierInvoiceDetails.mvc$controller.js";

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
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "Inputs"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Name",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("xJRlU0whV0yvbITHR5nj2Q#Value", "Invoice Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("iBxEllqXxUKPkTjS9_GwBQ#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.invoiceNumberAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.invoiceNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Name2",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("OdRj5fP6PkatMB5l8v4tuQ#Value", "Direction"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 250,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("xWWRMjhgb06AqIoQV8u0HA#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.directionAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.directionAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Name3",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+FkImhzRnkiOGLp41MYihg#Value", "Social Reason Telcel"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("We9tgm8n30aaKQi39Y3TDg#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.receiverSocialReasonAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.receiverSocialReasonAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name3"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Name10",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("11cs8fzoc0Cd1e9ZtBPK4g#Value", "RFC Telcel"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qHE5wgOu7UGxh44tjkD+MQ#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.receiverRFCAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.receiverRFCAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name10"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Name4",
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3LisfKfmbUaHAsSYWShBtw#Value", "Supplier Social Reason"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vvpliIjNsEedM_5iGNh2RQ#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.issuerSocialReasonAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.issuerSocialReasonAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name4"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Name9",
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3qBbMggVGka6mejyMlDlAg#Value", "Supplier Tax Id"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("v4M6MCxvrUiMJbxFG9CHrA#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.issuerTaxIdAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.issuerTaxIdAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name9"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Name5",
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Y4svEqG+lkKoTp4tqzsxBQ#Value", "Invoice Date"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: model.getCachedValue(idService.getId("Input_Name5.Prompt"), function () {
return ((!(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.invoiceDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (OS$BuiltinFunctions.formatDateTime(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.invoiceDateAttr, "yyyy-MM-dd")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZHMVlkFm2E+Orlx_ZD53RQ#ValueExpression.1815858133.1", "Not found")));
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.invoiceDateAttr;
}),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.textVar2Var, function (value) {
model.variables.textVar2Var = value;
}),
_idProps: {
service: idService,
name: "Input_Name5"
},
_widgetRecordProvider: widgetsRecordProvider,
prompt_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_AmountByServiceType",
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jD6FRNk1c06BUmw5m8b3kw#Value", "Total Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("pb2ekQE0_0aYOrX0NseUEQ#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.totalAmountAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.totalAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_AmountByServiceType"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlwaysShowDecimalDigits: true,
GroupSeparator: ",",
InputId: idService.getId("Input_AmountByServiceType"),
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true,
SuffixText: "",
PrefixText: "",
DecimalSeparator: ".",
RightAlign: true
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
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Name12",
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("r+33ydQKmUu4mTXY86TQnA#Value", "Currency"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: model.getCachedValue(idService.getId("Input_Name12.Prompt"), function () {
return ((((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.currencyAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()))) ? (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.currencyAttr) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3pv9opZ0WkmfA4vrQUGeJQ#ValueExpression.1815858133.1", "Not found")));
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedForeignerAttr.currencyAttr;
}),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.textVarVar, function (value) {
model.variables.textVarVar = value;
}),
_idProps: {
service: idService,
name: "Input_Name12"
},
_widgetRecordProvider: widgetsRecordProvider,
prompt_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_ForeignSupplierInvoiceDetails",
functionKey: "aa791d75-af08-4732-8d28-a3af28fba419",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_ForeignSupplierInvoiceDetails",
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
return [InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view];
};


return ELEM;
};

export default componentFactory()
