import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import UltimatePDF_PrintLayout_ScreenToPDF_mvc_view from "./UltimatePDF.PrintLayout.ScreenToPDF.mvc$view.js";
import { SE_paperSize as ConectaProveedores_staticEntities_paperSize } from "./ConectaProveedores.staticEntities.js";
import UltimatePDF_PrintLayout_PrintLayout_mvc_view from "./UltimatePDF.PrintLayout.PrintLayout.mvc$view.js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.z_TableDownloadsPDF.TableDownloadOrderPDF.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.z_TableDownloadsPDF.TableDownloadOrderPDF.mvc$controller.js";
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
value: model.getCachedValue(idService.getId("l+gPbUhS_k+WeXcQ5UlfnA.Value"), function () {
return ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("m37DOh_b10ygzcy0Q+cjHQ#ValueExpression.-110454839.1", "OrdersTable") + " ") + OS$BuiltinFunctions.formatDateTime(OS$BuiltinFunctions.currDate(), "dd/MM/yyyy"));
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
source: model.variables.getOrdersDataAct.listOut,
style: "table page-container",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "Table"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "ApprovalStatus",
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Approval Status"), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderNumber",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("hJDqM8yb2E+QuDiohTBwuA#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderStatus",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Order Status"), createElement(OSWidgets$HeaderCell, {
sortAttribute: "SupplierName_Number",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Supplier"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Buyer"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Company"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Region"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Currency"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "TotalAmount")];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderNumberAttr,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderStatusAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderStatusAttr,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).supplierName_NumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).supplierName_NumberAttr,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).buyerAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).buyerAttr,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).companyAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).companyAttr,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr)]
}))];
}),
bottomContent: Widget.PlaceholderContent.Empty,
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "TableDownloadOrderPDF",
functionKey: "fb93e012-b044-4522-b244-ff5e598c9c62",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "z_TableDownloadsPDF.TableDownloadOrderPDF",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.z_TableDownloadsPDF.TableDownloadOrderPDF.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
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
