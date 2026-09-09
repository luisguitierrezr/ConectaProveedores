import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import UltimatePDF_PrintLayout_ScreenToPDF_mvc_view from "./UltimatePDF.PrintLayout.ScreenToPDF.mvc$view.js";
import { SE_paperSize as ConectaProveedores_staticEntities_paperSize } from "./ConectaProveedores.staticEntities.js";
import UltimatePDF_PrintLayout_PrintLayout_mvc_view from "./UltimatePDF.PrintLayout.PrintLayout.mvc$view.js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.z_TableDownloadsPDF.TableDownloadInvoiceScreenPDF.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.z_TableDownloadsPDF.TableDownloadInvoiceScreenPDF.mvc$controller.js";
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
PaperSize: ConectaProveedores_staticEntities_paperSize.landscapeA4
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
extendedProperties: {
style: "margin-top: 20px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
extendedProperties: {
style: "padding: 10px;"
},
style: "sub-heading margin-base",
value: model.getCachedValue(idService.getId("bR+bwfEU+Eea5ptuqwfd6A.Value"), function () {
return ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("A2fBOeOfD0ipauTvX3xZew#ValueExpression.-270253707.1", "InvoiceScreenTable") + " ") + OS$BuiltinFunctions.formatDateTime(OS$BuiltinFunctions.currDate(), "dd/MM/yyyy"));
}),
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-right: 0px; padding: 15px;"
},
style: "page-container margin-base",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.getInvoicesDataAct.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("BI5VUIHBckuX7PzyqKj7RQ#Value", "Invoice"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4KsFlgw4Ik2WfyndzBuotw#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("_KIwz+oTXke181gbrcpwmw#Value", "Requisition"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("fvxOx3pfDE6dUfL3HbjwAg#Value", "Supplier Name"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("BekTWBIZjEKQOFXE++8JkA#Value", "Supplier Number"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("WyJJEapPBEShsOeCvk_2Ow#Value", "TotalAmount"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("wuGNbK+OM0axiHNJzW0NRg#Value", "UploadDate"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("JoO0oO8ArE+8HSqwcg1HYA#Value", "AssignedTo"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("22oefqBTbUKFKDXibeOGLw#Value", "Action")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).invoiceNameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).invoiceNameAttr,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).requisitionNameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).requisitionNameAttr,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).supplierNameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).supplierNameAttr,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).supplierNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).supplierNumberAttr,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).uploadDateAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).uploadDateAttr,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).assignedToAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).assignedToAttr,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).actionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesDataAct.listOut.getCurrent(callContext.iterationContext).actionAttr,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr)]
}))];
}),
bottomContent: Widget.PlaceholderContent.Empty,
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.listOut)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.listOut)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "TableDownloadInvoiceScreenPDF",
functionKey: "ed87bc34-bd93-41fa-9ca0-8eb0007cd117",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "z_TableDownloadsPDF.TableDownloadInvoiceScreenPDF",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.z_TableDownloadsPDF.TableDownloadInvoiceScreenPDF.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [UltimatePDF_PrintLayout_ScreenToPDF_mvc_view, UltimatePDF_PrintLayout_PrintLayout_mvc_view];
};


return ELEM;
};

export default componentFactory()
