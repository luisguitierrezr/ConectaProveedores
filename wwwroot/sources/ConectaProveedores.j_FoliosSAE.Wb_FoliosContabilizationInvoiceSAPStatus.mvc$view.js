import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Image as OSWidgets$Image, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { createElement } from "react";
import { Navigation as OS$Navigation, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.mvc$view.js";
import { SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_FolioLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_FolioLogs.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.mvc$controller.js";

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
style: "position-relative display font-size-main-heading margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
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
uuid: "1",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("6ihTKfLVmUWeEICxlm3AuA#Value", "Invoice"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(model.variables.l_IsInvoiceRetryAccountingRefreshVar, controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
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
uuid: "6",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "7",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("EZlix6t8T0u+tqjiTsOU6Q#Value", "Files"))];
})
},
_dependencies: []
}), createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "8",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("7DBEnynNFkiM2rOCfcDZmA#Value", "History"))];
})
},
_dependencies: []
}), createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "9",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: Widget.PlaceholderContent.Empty
},
_dependencies: []
})];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "10",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if((model.variables.getInvoicesByFolioIdAggr.isDataFetchedAttr && (!(model.variables.getInvoicesByFolioIdAggr.hasFetchErrorAttr))), false, this, function () {
return [$if((!(model.variables.getInvoicesByFolioIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "scroll-box",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.getInvoicesByFolioIdAggr.listOut,
style: "table ",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.Name",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("_L4hcH+PsE+yoJ+e8uDFaw#Value", "Name"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "Invoice.TotalAmount",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("EKcsMUhrk0K7hls6jOu5EQ#Value", "Files"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.InvoiceStatusId",
style: "",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("gevMulUGeUm4f+XdiHeVgA#Value", "Invoice Status"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("vM3P7z_8202GeOG6NP4VKw#Value", "Action")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.currencyAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "bold font-size-h6",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("L+oGQvhPjk+H7yq+MubRlg.Value"), function () {
return ((((OS$BuiltinFunctions.formatDateTime(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr, "yyyy/MM/dd") + "   •   ") + model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.currencyAttr) + " ") + OS$BuiltinFunctions.formatDecimal(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr, 2, ".", ","));
}, function () {
return model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr;
}, function () {
return model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.currencyAttr;
}, function () {
return model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InvoiceId: model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr,
_invoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr)
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
uuid: "25",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.accountingErrorAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.updatedOnAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr)]
}, $if((model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationSuccess), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: (((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("lxksEynqDEm418u+K5O3qA#ValueExpression.1713975493.1", "Invoice Accounting done on") + " ") + OS$BuiltinFunctions.dateTimeToText(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.updatedOnAttr)) + "."),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Expression, {
value: ((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("OQm_ktGRcUuh0xD_9X0FPg#ValueExpression.345272791.1", "Invoice had an accounting error on") + " ") + OS$BuiltinFunctions.dateTimeToText(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.updatedOnAttr)) + ". ") + model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.accountingErrorAttr),
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr)
})];
})), createElement(OSWidgets$RowCell, {
style: "",
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr),
i_Class: model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr)
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
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
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
uuid: "33",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
extendedProperties: {
style: "text-align: center;"
},
visible: ((model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationError) || (model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr === ConectaProveedores_staticEntities_invoiceStatus.pendingAccounting)),
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.retryOnClick$Action(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_administrar_recargas.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("BNLUth5c9EqtpqQJKoi6wg#Value", "Retry Contabilization"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr)]
}), createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
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
uuid: "37",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClickDownload$Action(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_descargar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("o_5dbXWa7EWxrrZEztZIxw#Value", "Download ZIP"))];
})
},
_dependencies: []
})))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr)]
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("i+smynbspkukGDyiqoTT+Q#Value", "No files were found")))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.hasFetchErrorAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.isDataFetchedAttr)]
}), createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "42",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Logs_Wb_FolioLogs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn,
_i_FolioIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FolioIdInDataFetchStatus),
i_refresh: model.getCachedValue(idService.getId("YUvEKvN6tEakCSlfc9UwDg.i_refresh"), function () {
return OS$BuiltinFunctions.currDateTime();
})
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
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables._i_FolioIdInDataFetchStatus), asPrimitiveValue(model.variables.i_FolioIdIn)]
}), createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "44",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_FolioIdIn), asPrimitiveValue(model.variables._i_FolioIdInDataFetchStatus), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.hasFetchErrorAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.isDataFetchedAttr)]
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_FoliosContabilizationInvoiceSAPStatus",
functionKey: "ab63aebe-1e9f-4202-ab83-39c096838d9e",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_y_Logs_Wb_FolioLogs_mvc_view];
};


return ELEM;
};

export default componentFactory()
