import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Container as OSWidgets$Container, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Link as OSWidgets$Link, Image as OSWidgets$Image, Text as OSWidgets$Text, Button as OSWidgets$Button, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import { SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus, SE_position as ConectaProveedores_staticEntities_position, SE_folioStatus as ConectaProveedores_staticEntities_folioStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((model.variables.getInvoicesByFolioIdAggr.isDataFetchedAttr && (!(model.variables.getInvoicesByFolioIdAggr.hasFetchErrorAttr))), false, this, function () {
return [$if((!(model.variables.getInvoicesByFolioIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.getInvoicesByFolioIdAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.Name",
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("1e0ubVxhYEqdO48ckWWU8g#Value", "Name"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "Invoice.TotalAmount",
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("z9lks6wyRUKoChjRdE6gmg#Value", "Files"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.InvoiceStatusId",
style: "",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("pEZnDlwzmE29_HPtdwsBcA#Value", "Invoice Status"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("I6tDFwQJPEG2wsgptabNXA#Value", "Action")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoice_CNAttr.totalAmountAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoice_CNAttr.currencyAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoice_CNAttr.nameAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.creditNoteInvoiceIdAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.currencyAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "bold font-size-h6",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr,
_idProps: {
service: idService,
uuid: "7"
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
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("3CpGktR7Q0iAHdc2zi4dTA.Value"), function () {
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
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr)
})), $if(!(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.creditNoteInvoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "money",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("_la3iIJbb0WhPXxu9ATLCA.Value"), function () {
return (((((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("CNKue3CmSUWTD3b4k7mfbA#ValueExpression.1305281721.1", "Credit Note") + " ") + model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoice_CNAttr.nameAttr) + " ") + "   •   ") + model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoice_CNAttr.currencyAttr) + " ") + OS$BuiltinFunctions.formatDecimal(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoice_CNAttr.totalAmountAttr, 2, ".", ","));
}, function () {
return model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoice_CNAttr.nameAttr;
}, function () {
return model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoice_CNAttr.currencyAttr;
}, function () {
return model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoice_CNAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "13"
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
uuid: "14"
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
uuid: "15",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
style: "",
_idProps: {
service: idService,
uuid: "16"
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
uuid: "17",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr), asPrimitiveValue(model.variables.l_CanUploadInvoiceVar)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(false, false, this, function () {
return [];
}, function () {
return [];
}), $if((model.variables.l_CanUploadInvoiceVar && ((model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr === ConectaProveedores_staticEntities_invoiceStatus.documentUpload) || (model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr === ConectaProveedores_staticEntities_invoiceStatus.modify))), false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "20",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.togglePopupUploadInvoices$Action(false, model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr, model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr, model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.creditNoteInvoiceIdAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_agregar_lleno.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("qrtCB95LA0uvamB13PqJ3w#Value", "Add files"))];
})
},
_dependencies: []
})];
}, function () {
return [];
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
uuid: "23",
alias: "4"
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
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_descargar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("S5JGKXEq10aN2Ky5bvRy6A#Value", "Download ZIP"))];
})
},
_dependencies: []
})))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.l_CanUploadInvoiceVar), asPrimitiveValue(model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr)]
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("XHWJ1uyM5kultQmyi432NA#Value", "No invoices were found to this folio."))],
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}), $if((model.variables.l_CanUploadInvoiceVar || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr === ConectaProveedores_staticEntities_folioStatus.incorrectInvoice)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.togglePopupUploadInvoices$Action(false, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), 0, OS$DataTypes.LongInteger.defaultValue, controller.callContext(eventHandlerContext));
});
;
},
style: "btn",
visible: model.getCachedValue(idService.getId("lu1CT77+xES7NYi_SpGHMw.Visible"), function () {
return ((!(model.variables.isReadOnlyIn)) && ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut);
}, function () {
return model.variables.isReadOnlyIn;
}),
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._isReadOnlyInDataFetchStatus)
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("rE9Jyr4IV0yorFBkKKI_fw.Value"), function () {
return (((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr === ConectaProveedores_staticEntities_folioStatus.incorrectInvoice)) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3u6uKUhIWUq4xtyvbgbzmg#ValueExpression.1343706529.1", "Replace invoice")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3u6uKUhIWUq4xtyvbgbzmg#ValueExpression.-1579707231.1", "New upload")));
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr;
}),
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})))];
}, function () {
return [];
}), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_IsOpenPopupInvoicesVar,
style: "popup-dialog width-750px card",
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderId: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.idAttr,
_orderIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
FolioId: model.variables.i_FolioIdIn,
_folioIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FolioIdInDataFetchStatus),
ImportAnticipo: model.variables.l_ImportAnticipoVar,
InvoiceId: model.variables.l_InvoiceIdToPopupVar,
CreditNoteInvoiceId: model.variables.l_CreditNoteInvoiceIdToPopupVar,
RequisitionId: model.getCachedValue(idService.getId("7yng9K1rSEGOgfhF4NhY_A.RequisitionId"), function () {
return OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
}),
i_ShowOtherEvidences: false
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
closePopup$Action: function (needsRefreshIn, isMissingCreditNoteIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.togglePopupUploadInvoices$Action(needsRefreshIn, OS$DataTypes.LongInteger.defaultValue, 0, OS$DataTypes.LongInteger.defaultValue, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "32",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_SAECInvoices",
functionKey: "6e2f0bcc-10cb-4a89-8950-abacc6ea3a8d",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_SAECInvoices",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_mvc_view];
};


return ELEM;
};

export default componentFactory()
