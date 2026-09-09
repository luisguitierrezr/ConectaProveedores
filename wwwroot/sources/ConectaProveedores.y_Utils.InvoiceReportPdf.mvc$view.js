import { withBaseWebScreen, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import UltimatePDF_PrintLayout_ScreenToPDF_mvc_view from "./UltimatePDF.PrintLayout.ScreenToPDF.mvc$view.js";
import { SE_paperSize as ConectaProveedores_staticEntities_paperSize, SE_marginSize as ConectaProveedores_staticEntities_marginSize } from "./ConectaProveedores.staticEntities.js";
import UltimatePDF_PrintLayout_PrintLayout_mvc_view from "./UltimatePDF.PrintLayout.PrintLayout.mvc$view.js";
import { ST_f54c1d1bac41c2667837ac97bb484830Structure } from "./ConectaProveedores.model.js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import ConectaProveedores_y_Utils_Wb_ValidationReport_mvc_view from "./ConectaProveedores.y_Utils.Wb_ValidationReport.mvc$view.js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.y_Utils.InvoiceReportPdf.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.InvoiceReportPdf.mvc$controller.js";
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
HideHeaderOnFirstPage: false,
PaperSize: ConectaProveedores_staticEntities_paperSize.a4,
HideFooterOnLastPage: false,
MarginSize: ConectaProveedores_staticEntities_marginSize.one_in
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
return [createElement(ConectaProveedores_y_Utils_Wb_ValidationReport_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ValidationReport: model.getCachedValue(idService.getId("u4_sE_zgWEeKFASTQVXXWg.ValidationReport"), function () {
return function () {
var rec = new ST_f54c1d1bac41c2667837ac97bb484830Structure();
rec.supplierAttr = model.variables.getMainDataDataAct.validationReportOut.supplierAttr;
rec.projectAttr = model.variables.getMainDataDataAct.validationReportOut.projectAttr;
rec.reservePeriodAttr = model.variables.getMainDataDataAct.validationReportOut.reservePeriodAttr;
rec.invoiceNumberAttr = model.variables.getMainDataDataAct.validationReportOut.invoiceNumberAttr;
rec.frequencyAttr = model.variables.getMainDataDataAct.validationReportOut.frequencyAttr;
rec.requisitionNumberAttr = model.variables.getMainDataDataAct.validationReportOut.requisitionNumberAttr;
rec.orderNumberAttr = model.variables.getMainDataDataAct.validationReportOut.orderNumberAttr;
rec.deliveryDateAttr = model.variables.getMainDataDataAct.validationReportOut.deliveryDateAttr;
rec.validationReportItemsAttr = model.variables.getTableItemsDataAct.tableLineOut;
rec.businessCatAttr = model.variables.getMainDataDataAct.validationReportOut.businessCatAttr;
rec.businessSubcatAttr = model.variables.getMainDataDataAct.validationReportOut.businessSubcatAttr;
rec.characteristicsAttr = model.variables.getMainDataDataAct.validationReportOut.characteristicsAttr;
rec.deliveriesAttr = model.variables.getMainDataDataAct.validationReportOut.deliveriesAttr;
rec.attachmentsAttr = ((model.variables.getInvoiceFilesDataAct.filesStringOut + ", ") + model.variables.getMainDataDataAct.validationReportOut.attachmentsAttr);
rec.validationReportAuthorizationsAttr = model.variables.getEletronicAuthorizationsDataAct.validationReportAuthorizationListOut;
rec.folioCreationDateAttr = model.variables.getMainDataDataAct.validationReportOut.folioCreationDateAttr;
rec.societyAttr = model.variables.getMainDataDataAct.validationReportOut.societyAttr;
rec.pEPElementAttr = model.variables.getMainDataDataAct.validationReportOut.pEPElementAttr;
rec.deliverySiteAttr = model.variables.getMainDataDataAct.validationReportOut.deliverySiteAttr;
rec.entryNumberAttr = model.variables.getMainDataDataAct.validationReportOut.entryNumberAttr;
rec.entryDateAttr = model.variables.getMainDataDataAct.validationReportOut.entryDateAttr;
return rec;
}();
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.supplierAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.projectAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.reservePeriodAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.invoiceNumberAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.frequencyAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.requisitionNumberAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.orderNumberAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.deliveryDateAttr;
}, function () {
return model.variables.getTableItemsDataAct.tableLineOut;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.businessCatAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.businessSubcatAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.characteristicsAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.deliveriesAttr;
}, function () {
return model.variables.getInvoiceFilesDataAct.filesStringOut;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.attachmentsAttr;
}, function () {
return model.variables.getEletronicAuthorizationsDataAct.validationReportAuthorizationListOut;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.folioCreationDateAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.societyAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.pEPElementAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.deliverySiteAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.entryNumberAttr;
}, function () {
return model.variables.getMainDataDataAct.validationReportOut.entryDateAttr;
}),
_validationReportInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getMainDataDataAct.dataFetchStatusAttr, model.variables.getTableItemsDataAct.dataFetchStatusAttr, model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr, model.variables.getEletronicAuthorizationsDataAct.dataFetchStatusAttr),
IsFromRequisition: model.variables.getMainDataDataAct.isFromRequisitionOut,
_isFromRequisitionInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getMainDataDataAct.dataFetchStatusAttr)
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
uuid: "2",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
bottomContent: Widget.PlaceholderContent.Empty,
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getEletronicAuthorizationsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getTableItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getMainDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEletronicAuthorizationsDataAct.validationReportAuthorizationListOut), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.filesStringOut), asPrimitiveValue(model.variables.getTableItemsDataAct.tableLineOut), asPrimitiveValue(model.variables.getMainDataDataAct.isFromRequisitionOut), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.entryDateAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.entryNumberAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.deliverySiteAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.pEPElementAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.societyAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.folioCreationDateAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.attachmentsAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.deliveriesAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.characteristicsAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.businessSubcatAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.businessCatAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.deliveryDateAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.orderNumberAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.requisitionNumberAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.frequencyAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.invoiceNumberAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.reservePeriodAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.projectAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.supplierAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getEletronicAuthorizationsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getTableItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getMainDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEletronicAuthorizationsDataAct.validationReportAuthorizationListOut), asPrimitiveValue(model.variables.getInvoiceFilesDataAct.filesStringOut), asPrimitiveValue(model.variables.getTableItemsDataAct.tableLineOut), asPrimitiveValue(model.variables.getMainDataDataAct.isFromRequisitionOut), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.entryDateAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.entryNumberAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.deliverySiteAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.pEPElementAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.societyAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.folioCreationDateAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.attachmentsAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.deliveriesAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.characteristicsAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.businessSubcatAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.businessCatAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.deliveryDateAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.orderNumberAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.requisitionNumberAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.frequencyAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.invoiceNumberAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.reservePeriodAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.projectAttr), asPrimitiveValue(model.variables.getMainDataDataAct.validationReportOut.supplierAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "InvoiceReportPdf",
functionKey: "6f4dbaee-d6f8-400e-b270-273eca80a16a",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.InvoiceReportPdf",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.y_Utils.InvoiceReportPdf.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [UltimatePDF_PrintLayout_ScreenToPDF_mvc_view, UltimatePDF_PrintLayout_PrintLayout_mvc_view, ConectaProveedores_y_Utils_Wb_ValidationReport_mvc_view];
};


return ELEM;
};

export default componentFactory()
