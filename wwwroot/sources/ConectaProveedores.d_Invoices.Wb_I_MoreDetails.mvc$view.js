import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_I_MoreDetails.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_I_MoreDetails.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(false, false, this, function () {
return [];
}, function () {
return [$if(model.variables.moreDetailsAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "content"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "body invoice-card",
visible: true,
_idProps: {
service: idService,
name: "body"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m margin-top-m",
visible: true,
_idProps: {
service: idService,
name: "subheader"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "invoice-label",
text: [$text(getTranslation("UtyJSmE4uk2bh01_eyN7Ow#Value", "Comment:"))],
_idProps: {
service: idService,
name: "Comment"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "invoice-value",
value: model.variables.latestInvoiceCommentAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.messageAttr,
_idProps: {
service: idService,
name: "Message"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.latestInvoiceCommentAggr.dataFetchStatusAttr)
})), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
name: "details_list",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "invoice-section",
visible: true,
_idProps: {
service: idService,
name: "rows"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s invoice-row",
visible: true,
_idProps: {
service: idService,
name: "project"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "invoice-label",
text: [$text(getTranslation("_0lXDtjeVkygY_ZDQmWUNQ#Value", "Project :"))],
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "invoice-value",
value: model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.moreDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s invoice-row",
visible: true,
_idProps: {
service: idService,
name: "period"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "invoice-label",
text: [$text(getTranslation("IV4K5Haj6k+IS48eEIHIUA#Value", "Period :"))],
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "invoice-value",
value: model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.fechaEmisionAttr,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.moreDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s invoice-row",
visible: true,
_idProps: {
service: idService,
name: "frequency"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "invoice-label",
text: [$text(getTranslation("yaFH627q3UKuI6IZtbT7Fg#Value", "Frequency :"))],
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "invoice-value",
value: model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).frequencyAttr.labelAttr,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.moreDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s invoice-row",
visible: true,
_idProps: {
service: idService,
name: "bussinesvalue"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "invoice-label",
text: [$text(getTranslation("LDLC6s_aMkmgtIRpmhSfdw#Value", "Bussines Value :"))],
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "invoice-value",
value: model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).businessValueCategoryAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.moreDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s invoice-row",
visible: true,
_idProps: {
service: idService,
name: "bussinesvaluesubcategory"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "invoice-label",
text: [$text(getTranslation("_qnkDIyg9kSnS6A_hqQpjw#Value", "Business Value Subcategory :"))],
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "invoice-value",
value: model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).businessValueSubcategoryAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.moreDetailsAggr.dataFetchStatusAttr)
})))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "rows2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s invoice-row",
visible: true,
_idProps: {
service: idService,
name: "paymentdate"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "invoice-label",
text: [$text(getTranslation("DYdtngD91EC5Ig1qFNyddw#Value", "Payment Date :"))],
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "invoice-value",
value: OS$BuiltinFunctions.dateTimeToText(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.paymentDateTimeAttr),
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.moreDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s invoice-row",
visible: true,
_idProps: {
service: idService,
name: "invoicetype"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "invoice-label",
text: [$text(getTranslation("xDjYvKs74EepxlsP5wCVIw#Value", "Invoice Type :"))],
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "invoice-value",
value: model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).invoiceTaxTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.moreDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s invoice-row",
visible: true,
_idProps: {
service: idService,
name: "invoicedate"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "invoice-label",
text: [$text(getTranslation("MxUhU64gI0G0LyE6leM8sA#Value", "Invoice Date :"))],
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "invoice-value",
value: model.getCachedValue(idService.getId("3Vix4IUjuUW0rEos7EYN4w.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr, "d MMM yyyy HH:mm");
}, function () {
return model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.moreDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s invoice-row",
visible: true,
_idProps: {
service: idService,
name: "series"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "invoice-label",
text: [$text(getTranslation("33SrFRtZBUi7WbyolEZ4GA#Value", "Series :"))],
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "invoice-value",
value: model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.serieAttr,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.moreDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s invoice-row",
visible: true,
_idProps: {
service: idService,
name: "Distribution"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "invoice-label",
text: [$text(getTranslation("jJ29Vq3G10edUH0AVOzkDg#Value", "Distribucion :"))],
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "invoice-value",
value: model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).distributionAttr.labelAttr,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.moreDetailsAggr.dataFetchStatusAttr)
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.moreDetailsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).distributionAttr.labelAttr), asPrimitiveValue(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).invoiceTaxTypeAttr.labelAttr), asPrimitiveValue(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr), asPrimitiveValue(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.paymentDateTimeAttr), asPrimitiveValue(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).businessValueSubcategoryAttr.descriptionAttr), asPrimitiveValue(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).businessValueCategoryAttr.descriptionAttr), asPrimitiveValue(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).frequencyAttr.labelAttr), asPrimitiveValue(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.serieAttr), asPrimitiveValue(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.fechaEmisionAttr), asPrimitiveValue(model.variables.moreDetailsAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr)]
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "loading-spinner",
visible: true,
_idProps: {
service: idService,
name: "listupdating"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_I_MoreDetails",
functionKey: "f1a5a4e2-273f-4778-b3b0-54bfe6116ffb",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_I_MoreDetails",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.d_Invoices.Wb_I_MoreDetails.css"];
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
