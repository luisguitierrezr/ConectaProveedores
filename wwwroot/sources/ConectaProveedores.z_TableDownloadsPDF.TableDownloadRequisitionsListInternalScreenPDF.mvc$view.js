import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import UltimatePDF_PrintLayout_ScreenToPDF_mvc_view from "./UltimatePDF.PrintLayout.ScreenToPDF.mvc$view.js";
import { SE_paperSize as ConectaProveedores_staticEntities_paperSize } from "./ConectaProveedores.staticEntities.js";
import UltimatePDF_PrintLayout_PrintLayout_mvc_view from "./UltimatePDF.PrintLayout.PrintLayout.mvc$view.js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.mvc$controller.js";
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
value: model.getCachedValue(idService.getId("29j6q3o78U2zaZOxxWbBTg.Value"), function () {
return ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WECqt_u440CEywEzSkU0ow#ValueExpression.573749414.1", "RequisitionScreenTable") + " ") + OS$BuiltinFunctions.formatDateTime(OS$BuiltinFunctions.currDate(), "dd/MM/yyyy"));
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
source: model.variables.getRequisitionsDataAct.listOut,
style: "table page-container",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "Table"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
style: "donotshow",
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("MwxxaDZb4keeLtjlle_w6g#Value", "Name"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center"
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("HUHTaHnlDUmQxLtRXLiQHA#Value", "Requisition Status"))), createElement(OSWidgets$HeaderCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("T2lc7E9fOEeBBpUa2r2whw#Value", "Creation Date"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("jLIOyPifRE2KuG5qvLU8Dg#Value", "Last change"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6IGemd5spk6u+WJNwVzWdQ#Value", "Requester"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("wBbzH4fJXECGiDhXvpncQQ#Value", "Project"))), createElement(OSWidgets$HeaderCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("uUek2UfwvE+hLUB6kTEHcQ#Value", "Supplier"))), createElement(OSWidgets$HeaderCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("MMyWw0AkS0KHespp0NJjXA#Value", "RGN"))), createElement(OSWidgets$HeaderCell, {
style: "donotshow",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("NBkmOAxxcUuz9j0U5hRj0Q#Value", "Amount"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Mon"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("whtKvEAh6UyjFJGuQkiogg#Value", "Cost Center"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("kNx2_HgJHU2yoy3jSViUnQ#Value", "Company"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("DI7ENqTCVU2Qftv6LeTGmw#Value", "Último aprobador"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("i_iGhINJ8EiFuITMALdmAQ#Value", "ERP SAP"))), createElement(OSWidgets$HeaderCell, {
style: "",
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("fWzrQ48TkEymt82EUkoo+g#Value", "Action")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionNameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-right: 5px; text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionNameAttr,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).creationDateAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).creationDateAttr,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).lastChangeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).lastChangeAttr,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requesterAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).requesterAttr,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).projectAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).projectAttr,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).supplierAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).supplierAttr,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).amountAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).amountAttr,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).costCenterAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).costCenterAttr,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).companyAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).companyAttr,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).lastApproverApprovedOnAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).lastApproverAttr)]
}, createElement(OSWidgets$Expression, {
value: ((model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).lastApproverAttr + "\r\n") + model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).lastApproverApprovedOnAttr),
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).polizaSAP_SentWhenAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).polizaSAP_SentWhenAttr,
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).actionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsDataAct.listOut.getCurrent(callContext.iterationContext).actionAttr,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr)]
}))];
}),
bottomContent: Widget.PlaceholderContent.Empty,
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsDataAct.listOut)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "TableDownloadRequisitionsListInternalScreenPDF",
functionKey: "f0ffc82d-1ba5-423e-8222-eeb7daafb316",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
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
