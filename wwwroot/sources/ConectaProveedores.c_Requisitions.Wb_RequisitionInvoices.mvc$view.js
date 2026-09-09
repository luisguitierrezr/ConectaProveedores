import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion, DataTypes as OS$DataTypes, Navigation as OS$Navigation, Transitions as OS$Transitions } from "@outsystems/runtime-core-js";
import { TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Container as OSWidgets$Container, Expression as OSWidgets$Expression, Link as OSWidgets$Link, Image as OSWidgets$Image, Text as OSWidgets$Text, Button as OSWidgets$Button, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import { SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.mvc$view.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_mvc_view from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.mvc$view.js";
import ModelFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((model.variables.getInvoicesByRequisitionIdAggr.isDataFetchedAttr && (!(model.variables.getInvoicesByRequisitionIdAggr.hasFetchErrorAttr))), false, this, function () {
return [$if((!(model.variables.getInvoicesByRequisitionIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.getInvoicesByRequisitionIdAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr),
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
}, $text(getTranslation("sdzax30IJUeqtPImnQIDBA#Value", "Name"))), createElement(OSWidgets$HeaderCell, {
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
}, $text(getTranslation("JaqfKtZR+0GKu_zgJcitsg#Value", "Files"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Invoice.InvoiceStatusId",
style: "",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4222poDd8USZHAAn8beVqA#Value", "Invoice Status"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("9hofxpgs6EG3CuFjeFw1lg#Value", "Action")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.currencyAttr), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr)]
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
value: model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr)
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
value: model.getCachedValue(idService.getId("tuw7r5yl20yEA_1v49r_nQ.Value"), function () {
return ((((OS$BuiltinFunctions.formatDateTime(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr, "yyyy/MM/dd") + "   •   ") + model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.currencyAttr) + " ") + OS$BuiltinFunctions.formatDecimal(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr, 2, ".", ","));
}, function () {
return model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.createdOnAttr;
}, function () {
return model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.currencyAttr;
}, function () {
return model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr)]
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
uuid: "11"
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
InvoiceId: model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr,
_invoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr)
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
uuid: "12",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
style: "",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr),
i_Text: model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr)
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
uuid: "14",
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
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_CanUploadInvoiceVar), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).canUploadAttr), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ((model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.documentUpload))), false, this, function () {
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
uuid: "17",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Invoices_Detail", {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
i_InvoiceId: OS$DataConversion.ServerDataConverter.to(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_eyeopen.svg"),
style: "padding-top-xs",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("QsKtPaGaLUaCrQU9rsE4zg#Value", "See detail"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr), asPrimitiveValue(model.variables.i_RequisitionIdIn)]
})];
}, function () {
return [];
}), $if((model.variables.l_CanUploadInvoiceVar && model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).canUploadAttr), false, this, function () {
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
return controller.togglePopupUploadInvoices$Action(false, model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr, model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.idAttr, controller.callContext(eventHandlerContext));
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
return [$text(getTranslation("qJqrIJn0DkiOrGc+WV0H1w#Value", "Add files"))];
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
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClickDownload$Action(model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr, controller.callContext(eventHandlerContext));
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
return [$text(getTranslation("C9hFsQN5C0KrIG0S_QNdbw#Value", "Download ZIP"))];
})
},
_dependencies: []
})))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.l_CanUploadInvoiceVar), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr)]
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
text: [$text(getTranslation("p+NyDw0YxE+jErZZgfV7eg#Value", "No invoices were found to this requisition."))],
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}), $if((model.variables.l_CanUploadInvoiceVar && ((!(model.variables.getRequisitionDataDataAct.wasAdvWithoutInvoiceOut)) || model.variables.getInvoicesByRequisitionIdAggr.listOut.isEmpty)), false, this, function () {
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
return controller.togglePopupUploadInvoices$Action(false, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), 0, controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("RL1W1g1DnUeYiELzXIosQg#Value", "New upload"))), $if(model.variables.getRequisitionDataDataAct.allowMultiUploadOut, false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.togglePopupMultiUploadInvoices$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "btn margin-left-base",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("EhgtYV2jXk2PY10gJ9K7mw#Value", "Multiple upload")))];
}, function () {
return [];
}))];
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
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
FolioId: model.getCachedValue(idService.getId("iIVuEVV5pkaIOH0WE6BgLg.FolioId"), function () {
return OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
}),
i_ShowOtherEvidences: true,
RequisitionId: model.variables.i_RequisitionIdIn,
_requisitionIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_RequisitionIdInDataFetchStatus),
InvoiceId: model.variables.l_InvoiceIdToPopupVar,
InvoiceStatusId: model.variables.l_InvoiceStatusIdToPopupVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
closePopup$Action: function (needsRefreshIn, isMissingCreditNoteIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.togglePopupUploadInvoices$Action(needsRefreshIn, OS$DataTypes.LongInteger.defaultValue, 0, controller.callContext(eventHandlerContext));
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
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_IsOpenPopupMultiuploadVar,
style: "popup-dialog width-750px card",
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InvoiceStatusId: model.variables.l_InvoiceStatusIdToPopupVar,
RequisitionId: model.variables.i_RequisitionIdIn,
_requisitionIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_RequisitionIdInDataFetchStatus),
FolioId: model.getCachedValue(idService.getId("RWPgAwE8bk+86iIWce+DEg.FolioId"), function () {
return OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
closePopup$Action: function (needsRefreshIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.togglePopupMultiUploadInvoices$Action(needsRefreshIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "34",
alias: "7"
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
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_RequisitionInvoices",
functionKey: "6f3ca336-6fbc-4e80-a211-5e3745ed2352",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Requisitions.Wb_RequisitionInvoices",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_mvc_view, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_mvc_view];
};


return ELEM;
};

export default componentFactory()
